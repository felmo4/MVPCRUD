using CommonComponents;
using DomainLayer.Models.Pets;
using InfrastructureLayer.DataAccess.Repositories.Specific.Pets;
using PresentationLayer.Views;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.PetsServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer.Presenters
{
    public class PetsDetailPresenter : IPetsDetailPresenter
    {
        public event EventHandler PetsDetailViewReadyToShowEventRaised;
        public event EventHandler PetsDetailCancelBtnClickEventRaised;
        public event EventHandler<AccessTypeEventArgs> PetsDetailSaveBtnClickEventRaised;

        private IPetsDetailView _petsDetailView;
        private IPetsServices _petsServices;
        private IPetsModel _petsModelWithoutBinding;
        private IPetsModel _petsModelOrigValuesBeforeEdit;

        private bool _isModifiedEnabled = false;
        private bool _petsModelWasChangedInView = false;
        private int _petID;
        private string _petName;
        private string _petBreed;
        private string _petBday;


        public IPetsDetailView GetPetsDetailView()
        {
            return _petsDetailView;
        }

        public PetsDetailPresenter(IPetsDetailView petsDetailView,
                                    IPetsServices petsServices,
                                    IPetsModel petsModelWithoutBinding,
                                    IPetsModel petsModelOrigValuesBeforeEdit)
        {
            _petsDetailView = petsDetailView;
            _petsServices = petsServices;
            _petsModelWithoutBinding = petsModelWithoutBinding;
            _petsModelOrigValuesBeforeEdit = petsModelOrigValuesBeforeEdit;
            SubscribeToEventsSetup();
        }

        private void SubscribeToEventsSetup()
        {
            _petsDetailView.PetsDetailSaveBtnClickEventRaised += new EventHandler<AccessTypeEventArgs>(OnPetsDetailSaveBtnClickEventRaised);
            _petsDetailView.PetsDetailCancelBtnClickEventRaised += new EventHandler(OnPetsDetailCancelBtnClickEventRaised);
        }

        private bool PetsValuesVerifiedToHaveChanged(AccessTypeEventArgs accessTypeEventArg)
        {
            bool changedValueDetected = false;

            if (accessTypeEventArg.AccessTypeValue == AccessTypeEventArgs.AccessType.Edit)
            {
                if (_petsModelOrigValuesBeforeEdit.petname != _petName)
                    changedValueDetected = true;
                else if (_petsModelOrigValuesBeforeEdit.petbreed != _petBreed)
                    changedValueDetected = true;
                else if (_petsModelOrigValuesBeforeEdit.petbday != _petBday)
                    changedValueDetected = true;
            }

            if (changedValueDetected == true)
            {
                accessTypeEventArg.ValuesWereChanged = true;
            }
            else
            {
                accessTypeEventArg.ValuesWereChanged = false;
            }

            return changedValueDetected;
        }

        private void OnPetsDetailSaveBtnClickEventRaised(object sender, AccessTypeEventArgs accessTypeEventArgs)
        {
            if (
           (_petsModelWasChangedInView == true) && (PetsValuesVerifiedToHaveChanged(accessTypeEventArgs) == true)
           ||
           (_petsModelWasChangedInView == true) && (accessTypeEventArgs.AccessTypeValue == AccessTypeEventArgs.AccessType.Add)
         )
            {
                _petsModelWithoutBinding.petname = _petName;
                _petsModelWithoutBinding.petbreed = _petBreed;
                _petsModelWithoutBinding.petbday = _petBday;

                try
                {
                    if (accessTypeEventArgs.AccessTypeValue == AccessTypeEventArgs.AccessType.Edit)
                    {
                        _petsServices.Edit(_petsModelWithoutBinding); //Use model service to save updated model to database 
                    }
                    else
                    {
                        _petsServices.Add(_petsModelWithoutBinding); //Use model service to save updated model to database 
                    }
                    InitializeValues(isModifiedEnabled: false);
                }
                catch (Exception e1)
                {
                    //("Error Message", e1.Message);
                    return;
                }

            }
            EventHelpers.RaiseEvent(this, PetsDetailSaveBtnClickEventRaised, accessTypeEventArgs);
        }

        private void OnPetsDetailCancelBtnClickEventRaised(object sender, EventArgs e)
        {

        }

        private void InitializeValues(bool isModifiedEnabled)
        {
            _petsModelWasChangedInView = false;
            _isModifiedEnabled = isModifiedEnabled;

            _petID = 0;
            _petName = string.Empty;
            _petBreed = string.Empty;
            _petBday = string.Empty;

            _petsModelWithoutBinding.petname = string.Empty;
            _petsModelWithoutBinding.petbreed = string.Empty;
            _petsModelWithoutBinding.petbday = string.Empty;
        }

        public void SetupPetForAdd()
        {
            InitializeValues(isModifiedEnabled: true);

            Dictionary<string, Binding> petModelbindingDictionary = new Dictionary<string, Binding>();

            SetupBindingsForView(petModelbindingDictionary);

            AccessTypeEventArgs accessTypeEventArgs = new AccessTypeEventArgs();

            accessTypeEventArgs.AccessTypeValue = AccessTypeEventArgs.AccessType.Add;

            _petsDetailView.SetUpPetsDetailView(petModelbindingDictionary, accessTypeEventArgs);

            EventHelpers.RaiseEvent(this, PetsDetailViewReadyToShowEventRaised, new EventArgs());
        }

        public void SetupPetForUpdate(int petID)
        {
            InitializeValues(isModifiedEnabled: true);

            Dictionary<string, Binding> petModelbindingDictionary = new Dictionary<string, Binding>();

            LoadPetToBeUpdated(petID);

            SetupBindingsForView(petModelbindingDictionary);

            AccessTypeEventArgs accessTypeEventArgs = new AccessTypeEventArgs();

            accessTypeEventArgs.AccessTypeValue = AccessTypeEventArgs.AccessType.Edit;

            //Tell View to load up its DataGridView with binding objects created here
            _petsDetailView.SetUpPetsDetailView(petModelbindingDictionary, accessTypeEventArgs);

            EventHelpers.RaiseEvent(this, PetsDetailViewReadyToShowEventRaised, new EventArgs());
        }

        private void SetupBindingsForView(Dictionary<string, Binding> petsModelbindingDictionary)
        {
            //Create bindings for data the View will use on its textBoxes
            Binding petIDBinding = new Binding("Text", this, "PetID", false, DataSourceUpdateMode.Never);
            Binding petNameBinding = new Binding("Text", this, "PetName", false, DataSourceUpdateMode.OnPropertyChanged);
            Binding petBreedBinding = new Binding("Text", this, "PetBreed", false, DataSourceUpdateMode.OnPropertyChanged);
            Binding petBdayBinding = new Binding("Text", this, "PetBday", false, DataSourceUpdateMode.OnPropertyChanged);

            //Store bindings into a dictionary for the View to access for its textBoxes
            petsModelbindingDictionary.Add("PetID", petIDBinding);
            petsModelbindingDictionary.Add("PetName", petNameBinding);
            petsModelbindingDictionary.Add("PetBreed", petBreedBinding);
            petsModelbindingDictionary.Add("PetBday", petBdayBinding);
        }

        private void LoadPetToBeUpdated(int petID)
        {
            _petsModelWithoutBinding = _petsServices.GetByID(petID);

            _petID = _petsModelWithoutBinding.petID;
            _petName = _petsModelWithoutBinding.petname;
            _petBreed = _petsModelWithoutBinding.petbreed;
            _petBday = _petsModelWithoutBinding.petbday;

            _petsModelOrigValuesBeforeEdit.petID = _petsModelWithoutBinding.petID;
            _petsModelOrigValuesBeforeEdit.petname = _petsModelWithoutBinding.petname;
            _petsModelOrigValuesBeforeEdit.petbreed = _petsModelWithoutBinding.petbreed;
            _petsModelOrigValuesBeforeEdit.petbday = _petsModelWithoutBinding.petbday;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (_isModifiedEnabled == true)
            {
                _petsModelWasChangedInView = true;
            }
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public PetsModel PetsModel
        {
            get { return (PetsModel)_petsModelWithoutBinding; }
            set
            {
                if (value == _petsModelWithoutBinding) return;
                _petsModelWithoutBinding = value;
                //NotifyPropertyChanged(); not to be implemented for this property
            }
        }

        public int PetID
        {
            get { return this._petID; }
            set
            {
                if (value == this._petID) return;
                this._petID = value;
                NotifyPropertyChanged();
            }
        }

        public string PetName
        {
            get { return this._petName; }
            set
            {
                if (value == this._petName) return;
                this._petName = value;
                NotifyPropertyChanged();
            }
        }

        public string PetBreed
        {
            get { return this._petBreed; }
            set
            {
                if (value == this._petBreed) return;
                this._petBreed = value;
                NotifyPropertyChanged();
            }
        }

        public string PetBday
        {
            get { return this._petBday; }
            set
            {
                if (value == this._petBday) return;
                this._petBday = value;
                NotifyPropertyChanged();
            }
        }

    }
}
