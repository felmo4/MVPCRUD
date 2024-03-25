using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters
{
    class MainPresenter : IMainPresenter
    {
        IMainView _mainView;
        IHelpAboutPresenter _helpAboutPresenter;

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
            _mainView.HelpAboutMenuClickEventRaised += new EventHandler(OnHelpAboutMenuClickEventRaised);
        }

        public void OnHelpAboutMenuClickEventRaised(object sender, EventArgs e)
        {
            _helpAboutPresenter.GetHelpAboutView().ShowHelpAboutView(); 
        }
    }
}
