using CommonComponents;
using DomainLayer.Models.Pets;
using PresentationLayer.Views;
using ServiceLayer.Services.PetsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer.Presenters
{
    public class PetsDetailPresenter
    {

        public event EventHandler<AccessTypeEventArgs> PetsDetailSaveBtnClickEventRaised;

        private IPetsModel _petsModelWithoutBinding;
        private IPetsServices _petsServices;
        private IPetsDetailView _petsDetailView;

        private bool _isModifiedEnabled = false;
        private bool _petsModelWasChangedInView = false;
        private int _petID;
        private string _petName;
        private string _petBreed;
        private string _petBday;

        public PetsDetailPresenter(IPetsModel petsModelWithoutBinding, IPetsServices petsServices,
                                    IPetsDetailView petsDetailView)
        {
            _petsModelWithoutBinding = petsModelWithoutBinding;
            _petsServices = petsServices;
            _petsDetailView = petsDetailView;
        }

        private void SubscribeToEventsSetup()
        {
            _petsDetailView.PetsDetailSaveBtnClickEventRaised += new EventHandler<AccessTypeEventArgs>(OnPetsDetailSaveBtnClickEventRaised);
        }

        private void OnPetsDetailSaveBtnClickEventRaised(object sender, AccessTypeEventArgs e)
        {
            _petsModelWithoutBinding = 
        }

        private void InitializeValues(bool isModifiedEnabled)
        {
            _petsModelWasChangedInView = false;
            _isModifiedEnabled = isModifiedEnabled;

            _petID = 0;
            _petName = string.Empty;
            _petBreed = string.Empty;
            _petBday = string.Empty;

           _petsModelWithoutBinding.petID = _petID;
           _petsModelWithoutBinding.petname = _petName;
           _petsModelWithoutBinding.petbreed = _petBreed;
           _petsModelWithoutBinding.petbday = _petBday; 
        }

        public void SetupDepartmentForAdd()
        {
            InitializeValues(isModifiedEnabled: true);

            Dictionary<string, Binding> departmentModelbindingDictionary = new Dictionary<string, Binding>();

            SetupBindingsForView(departmentModelbindingDictionary);

            AccessTypeEventArgs accessTypeEventArgs = new AccessTypeEventArgs();

            accessTypeEventArgs.AccessTypeValue = AccessTypeEventArgs.AccessType.Add;

            _departmentDetailViewUC.SetUpDepartmentDetailView(departmentModelbindingDictionary, accessTypeEventArgs);

            EventHelpers.RaiseEvent(this, DepartmentDetailViewReadyToShowEventRaised, new EventArgs());
        }

    }
}
