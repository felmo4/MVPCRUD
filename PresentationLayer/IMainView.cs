using System.Windows.Forms;
using System;
using System.Collections.Generic;

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
        void LoadPetsListToGrid(BindingSource petsListBindingSource, Dictionary<string, string> headingsDictionary,
                                        Dictionary<string, float> gridColumnWidthsDictionary, int rowHeight);
    }
}