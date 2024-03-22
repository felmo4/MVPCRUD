namespace PresentationLayer.Presenters
{
    public interface IBasePresenter
    {
        void ShowErrorMessages(string windowTitle, string errorMessage);
    }
}