using PresentationLayer.Presenters.UserControls;
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
        List<UserControl> _userControlList;

        public event EventHandler PetsDetailViewBindingDoneEventRaised;

        public IMainView GetMainView() { return _mainView; }

        public MainPresenter(IMainView mainView, IErrorMessageView errorMessageView, IHelpAboutPresenter helpAboutPresenter)
        {
            _mainView = mainView;
            _helpAboutPresenter = helpAboutPresenter;
            SubscribeToEventsSetup();
        }

        private void SubscribeToEventsSetup()
        {
            _mainView.MainViewLoadedEventRaised += new EventHandler(OnMainViewLoadedEventRaised);
            _mainView.HelpAboutMenuClickEventRaised += new EventHandler(OnHelpAboutMenuClickEventRaised);
            _mainView.PetsListBtnClickEventRaised += new EventHandler(OnPetsListBtnClickEventRaised);
        }

        public void OnMainViewLoadedEventRaised(object sender, EventArgs e)
        {
            _userControlList = new List<UserControl>();
            //_userControlList.Add(_petsListPresenter.)
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

        private void SetUserControlVisibleInPanel(UserControl userControl)
        {
            foreach (UserControl uc in _userControlList)
            {
                if (uc.Name == userControl.Name)
                {
                    userControl.Visible = true;
                }
                else uc.Visible = false;
            }
        }
    }
}
