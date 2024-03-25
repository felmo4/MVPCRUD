using System.Windows.Forms;
using System;

namespace PresentationLayer
{
    public interface IMainView
    {
        event EventHandler HelpAboutMenuClickEventRaised;
        event EventHandler HomeBtnClickEventRaised;
        event EventHandler MainViewLoadedEventRaised;
        event EventHandler PetsListBtnClickEventRaised;

        Panel GetOptionsPanel();
        void ResetUserControlPanelSizeandLocation();
        void ShowMainView();
    }
}