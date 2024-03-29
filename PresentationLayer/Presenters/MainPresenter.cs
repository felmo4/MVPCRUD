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
        IErrorMessageView _errorMessageView;
        IHelpAboutPresenter _helpAboutPresenter;
        IPetsListPresenter _petsListPresenter;
        IPetsDetailView _petsDetailView;


        //public event EventHandler PetsDetailViewBindingDoneEventRaised;

        public IMainView GetMainView() { return _mainView; }

        public MainPresenter(IMainView mainView, IErrorMessageView errorMessageView, IHelpAboutPresenter helpAboutPresenter, 
                                IPetsListPresenter petsListPresenter, IPetsDetailView petsDetailView)
        {
            _mainView = mainView;
            _errorMessageView = errorMessageView;
            _helpAboutPresenter = helpAboutPresenter;
            _petsListPresenter = petsListPresenter;
            _petsDetailView = petsDetailView;
            SubscribeToEventsSetup();
        }

        private void SubscribeToEventsSetup()
        {
            _mainView.MainViewLoadedEventRaised += new EventHandler(OnMainViewLoadedEventRaised);
            _mainView.HelpAboutMenuClickEventRaised += new EventHandler(OnHelpAboutMenuClickEventRaised);
            _mainView.PetsListBtnClickEventRaised += new EventHandler(OnPetsListBtnClickEventRaised);
            _mainView.HomeBtnClickEventRaised += new EventHandler(OnHomeBtnClickEventRaised);
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
            _petsDetailView.ShowPetsDetailView();
        }


    }
}
