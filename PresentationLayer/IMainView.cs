using System.Windows.Forms;
using System;
using System.Collections.Generic;
using CommonComponents;

namespace PresentationLayer
{
    public interface IMainView
    {
        event EventHandler HelpAboutMenuClickEventRaised;
        event EventHandler HomeBtnClickEventRaised;
        event EventHandler MainViewLoadedEventRaised;
        event EventHandler PetsListBtnClickEventRaised;
        event EventHandler<AccessTypeEventArgs> EditPetMenuClickEventRaised;
        event EventHandler<AccessTypeEventArgs> DeletePetMenuClickEventRaised;

        void RefreshMainView();
        Panel GetOptionsPanel();
        void ShowMainView();
        void LoadPetsListToGrid(BindingSource petsListBindingSource, Dictionary<string, string> headingsDictionary,
                                        Dictionary<string, float> gridColumnWidthsDictionary, int rowHeight);
    }
}