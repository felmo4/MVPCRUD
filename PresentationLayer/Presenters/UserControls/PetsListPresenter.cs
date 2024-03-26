using DomainLayer.Models.Pets;
using ServiceLayer.Services.PetsServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Presenters.UserControls
{
    public class PetsListPresenter : IPetsListPresenter
    {
        private IPetsServices _petsServices;
        //private IPetsListViewUC

        BindingList<PetsSelectDto> _petsSelectDtoBindingList;
        private BindingSource _petsSelectDtoBindingSource;

        public PetsListPresenter(IPetsServices petsServices)
        {
            _petsServices = petsServices;
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
            _petsSelectDtoBindingSource.DataSource = _petsSelectDtoBindingList;

        }


        public void LoadAllPetsFromDbtoGrid()
        {
            BuildDataSourceForAllPetsList();
        }

        //public IPetsListPresenter GetPetsListViewUC() { }

    }
}
