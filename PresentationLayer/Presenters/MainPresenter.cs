using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters
{
    class MainPresenter : IMainPresenter
    {
        IMainView _mainView;

        public event EventHandler PetsDetailViewBindingDoneEventRaised;

        public IMainView GetMainView() { return _mainView; }

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
        }
    }
}
