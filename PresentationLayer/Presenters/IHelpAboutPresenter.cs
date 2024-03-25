using PresentationLayer.Views;
using System;

namespace PresentationLayer.Presenters
{
    public interface IHelpAboutPresenter
    {
        IHelpAboutView GetHelpAboutView();
        void OnHelpAboutViewLoadEventRaised(object sender, EventArgs e);
    }
}