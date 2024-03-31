using CommonComponents;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public interface IPetsDetailView
    {
        event EventHandler<AccessTypeEventArgs> PetsDetailSaveBtnClickEventRaised;

        void ShowPetsDetailView();
        void ShowPetsDetailViewEdit(DataGridViewRow selectedRow);
        void ClosePetsDetailView();
        int GetPetID();
        string GetPetName();
        string GetPetBreed();
        string GetPetBday();
    }
}