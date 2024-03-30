using CommonComponents;
using DomainLayer.Models.Pets;
using PresentationLayer.Views;
using System;
using System.ComponentModel;

namespace PresentationLayer.Presenters
{
    public interface IPetsDetailPresenter
    {
        string PetBday { get; set; }
        string PetBreed { get; set; }
        int PetID { get; set; }
        string PetName { get; set; }
        PetsModel PetsModel { get; set; }

        event EventHandler PetsDetailCancelBtnClickEventRaised;
        event EventHandler<AccessTypeEventArgs> PetsDetailSaveBtnClickEventRaised;
        event EventHandler PetsDetailViewReadyToShowEventRaised;
        event PropertyChangedEventHandler PropertyChanged;

        IPetsDetailView GetPetsDetailView();
        void SetupPetForAdd();
        void SetupPetForUpdate(int petID);
    }
}