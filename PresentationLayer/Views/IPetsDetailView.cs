using CommonComponents;
using System;

namespace PresentationLayer.Views
{
    public interface IPetsDetailView
    {
        event EventHandler<AccessTypeEventArgs> PetsDetailSaveBtnClickEventRaised;

        void ShowPetsDetailView();
    }
}