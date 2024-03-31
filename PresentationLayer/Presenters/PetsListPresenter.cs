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

        BindingList<PetsModel> _petsBindingList;
        private BindingSource _petsBindingSource;

        public PetsListPresenter(IPetsServices petsServices, IMainView mainView)
        {
            _petsServices = petsServices;
            _mainView = mainView;
        }

        private void SubscribeToEventsSetup()
        {
        }

        private void BuildDataSourceForAllPetsList()
        {
            IEnumerable<PetsModel> allPets = _petsServices.GetAll();
            _petsBindingList = new BindingList<PetsModel>();

            foreach (PetsModel petsMinDetailDto in allPets)
            {
                _petsBindingList.Add(petsMinDetailDto);
            }

            _petsBindingSource = new BindingSource();
            this._petsBindingSource.DataSource = _petsBindingList;

        }


        public void LoadAllPetsFromDbtoGrid()
        {
            BuildDataSourceForAllPetsList();
            
            int rowHeight = 17;

            Dictionary<string, float> gridColumnWidthsDictionary = new Dictionary<string, float>();
            SetPetsListViewGridColumnWidths(gridColumnWidthsDictionary);

            Dictionary<string, string> headingsDictionary = new Dictionary<string, string>();
            SetPetsListViewGridHeadings(headingsDictionary);

            _mainView.LoadPetsListToGrid(_petsBindingSource, headingsDictionary, gridColumnWidthsDictionary, rowHeight);

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

        public void DeletePetFromList(DataGridViewRow selectedRow)
        {
            PetsModel pm = new PetsModel() { petID = int.Parse(selectedRow.Cells["petID"].Value.ToString()) };
            _petsServices.Delete(pm);
            _mainView.RefreshMainView();
        }
    }
}
