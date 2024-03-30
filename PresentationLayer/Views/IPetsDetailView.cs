using CommonComponents;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public interface IPetsDetailView
    {
        AccessTypeEventArgs AccessTypeEventArgs { get; set; }

        event EventHandler PetsDetailCancelBtnClickEventRaised;
        event EventHandler<AccessTypeEventArgs> PetsDetailSaveBtnClickEventRaised;

        void BindPetsModelToView(Dictionary<string, Binding> bindingDictionary);
        void ClearExistingBindings();
        void SetUpPetsDetailView(Dictionary<string, Binding> bindingDictionary, AccessTypeEventArgs accessTypeEventArgs);
        void ShowPetsDetailView();
    }
}