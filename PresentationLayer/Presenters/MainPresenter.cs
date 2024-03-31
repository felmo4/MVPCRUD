using CommonComponents;
using PresentationLayer.Presenters;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Presenters
{
    class MainPresenter : IMainPresenter
    {
        IMainView _mainView;
        IHelpAboutPresenter _helpAboutPresenter;
        IPetsListPresenter _petsListPresenter;
        IPetsDetailPresenter _petsDetailPresenter;
        

        //public event EventHandler PetsDetailViewBindingDoneEventRaised;

        public IMainView GetMainView() { return _mainView; }

        public MainPresenter(IMainView mainView, IHelpAboutPresenter helpAboutPresenter, 
                                IPetsListPresenter petsListPresenter, IPetsDetailPresenter petsDetailPresenter)
        {
            _mainView = mainView;
            _helpAboutPresenter = helpAboutPresenter;
            _petsListPresenter = petsListPresenter;
            _petsDetailPresenter = petsDetailPresenter;
            SubscribeToEventsSetup();
        }

        private void SubscribeToEventsSetup()
        {
            _mainView.MainViewLoadedEventRaised += new EventHandler(OnMainViewLoadedEventRaised);
            _mainView.HelpAboutMenuClickEventRaised += new EventHandler(OnHelpAboutMenuClickEventRaised);
            _mainView.PetsListBtnClickEventRaised += new EventHandler(OnPetsListBtnClickEventRaised);
            _mainView.HomeBtnClickEventRaised += new EventHandler(OnHomeBtnClickEventRaised);
            _mainView.EditPetMenuClickEventRaised += new EventHandler<AccessTypeEventArgs>(OnEditPetMenuClickEventRaised);
            _mainView.DeletePetMenuClickEventRaised += new EventHandler<AccessTypeEventArgs>(OnDeletePetMenuClickEventRaised);
        }

        public void OnMainViewLoadedEventRaised(object sender, EventArgs e)
        {

        }

        public void OnHelpAboutMenuClickEventRaised(object sender, EventArgs e)
        {
            _helpAboutPresenter.GetHelpAboutView().ShowHelpAboutView(); 
        }

        public void OnPetsListBtnClickEventRaised(object sender, EventArgs e)
        {
           SetupPetsListInPanel();
        }

        private void SetupPetsListInPanel()
        {
            _petsListPresenter.LoadAllPetsFromDbtoGrid();
        }

        private void OnHomeBtnClickEventRaised(object sender, EventArgs e)
        {
            _petsDetailPresenter.GetPetsDetailView().ShowPetsDetailView();
        }

        private void OnEditPetMenuClickEventRaised(object sender, AccessTypeEventArgs e)
        {
            _petsDetailPresenter.GetPetsDetailView().ShowPetsDetailViewEdit(e.selectedRow);
        }

        private void OnDeletePetMenuClickEventRaised(object sender, AccessTypeEventArgs e)
        {
            _petsListPresenter.DeletePetFromList(e.selectedRow);
        }


    }
}
