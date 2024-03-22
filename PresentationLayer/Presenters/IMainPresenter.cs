using System;

namespace PresentationLayer.Presenters
{
    internal interface IMainPresenter
    {
        event EventHandler PetsDetailViewBindingDoneEventRaised;
        IMainView GetMainView();
    }
}