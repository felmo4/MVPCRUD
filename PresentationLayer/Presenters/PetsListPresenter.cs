using DomainLayer.Models.Pets;
using ServiceLayer.Services.PetsServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Presenters
{
    public class PetsListPresenter : IPetsListPresenter
    {
        private IPetsServices _petsServices;
        private IMainView _mainView;
        //private IPetsListViewUC

        BindingList<PetsSelectDto> _petsSelectDtoBindingList;
        private BindingSource _petsSelectDtoBindingSource;

        public PetsListPresenter(IPetsServices petsServices, IMainView mainView)
        {
            _petsServices = petsServices;
            _mainView = mainView;
        }

        private void SubscribeToEventsSetup()
        {
            //_petsListViewUC
        }

        private void BuildDataSourceForAllPetsList()
        {
            IEnumerable<PetsSelectDto> allPets = _petsServices.GetDepartmentSelectList();
            _petsSelectDtoBindingList = new BindingList<PetsSelectDto>();

            foreach (PetsSelectDto petsMinDetailDto in allPets)
            {
                _petsSelectDtoBindingList.Add(petsMinDetailDto);
            }

            _petsSelectDtoBindingSource = new BindingSource();
            this._petsSelectDtoBindingSource.DataSource = _petsSelectDtoBindingList;

        }


        public void LoadAllPetsFromDbtoGrid()
        {
            BuildDataSourceForAllPetsList();
            
            int rowHeight = 17;

            Dictionary<string, float> gridColumnWidthsDictionary = new Dictionary<string, float>();
            SetPetsListViewGridColumnWidths(gridColumnWidthsDictionary);

            Dictionary<string, string> headingsDictionary = new Dictionary<string, string>();
            SetPetsListViewGridHeadings(headingsDictionary);

            _mainView.LoadPetsListToGrid(_petsSelectDtoBindingSource, headingsDictionary, gridColumnWidthsDictionary, rowHeight);

        }

        private void SetPetsListViewGridColumnWidths(Dictionary<string, float> gridColumnWidthsDictionary)
        {
            gridColumnWidthsDictionary["petID"] = (float)(.12);
            gridColumnWidthsDictionary["petname"] = (float)(.25);
            gridColumnWidthsDictionary["petbreed"] = (float)(.25);
            gridColumnWidthsDictionary["petbday"] = (float)(.25);
            gridColumnWidthsDictionary["Options"] = (float)(.15);

        }

        private void SetPetsListViewGridHeadings(Dictionary<string, string> headingsDictionary)
        {
            headingsDictionary["petID"] = "ID";
            headingsDictionary["petname"] = "Pet Name";
            headingsDictionary["petbreed"] = "Breed";
            headingsDictionary["petbday"] = "Birthday";
            headingsDictionary["OptionsButton"] = "Options";
        }

        //public IPetsListPresenter GetPetsListViewUC() { }

    }
}
