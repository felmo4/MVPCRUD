using CommonComponents;
using DomainLayer.Models.Pets;
using PresentationLayer.Views;
using ServiceLayer.Services.PetsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters
{
    public class PetsDetailPresenter : IPetsDetailPresenter
    {
        private IPetsServices _petsServices;
        private IPetsDetailView _petsDetailView;
        private IBasePresenter _basePresenter;

        public PetsDetailPresenter(IPetsServices petsServices, IPetsDetailView petsDetailView, IBasePresenter basePresenter)
        {
            _petsServices = petsServices;
            _petsDetailView = petsDetailView;
            _basePresenter = basePresenter;
            SubscribeToEventsSetup();
        }

        public IPetsDetailView GetPetsDetailView()
        {
            return _petsDetailView;
        }

        private void SubscribeToEventsSetup()
        {
            _petsDetailView.PetsDetailSaveBtnClickEventRaised += new EventHandler<AccessTypeEventArgs>(OnPetsDetailSaveBtnClickEventRaised);
        }

        private void OnPetsDetailSaveBtnClickEventRaised(object sender, AccessTypeEventArgs accessTypeEventArgs)
        {
            if (accessTypeEventArgs.AccessTypeValue == AccessTypeEventArgs.AccessType.Add)
            {
                PetsModel pm = new PetsModel()
                {
                    petname = _petsDetailView.GetPetName(),
                    petbreed = _petsDetailView.GetPetBreed(),
                    petbday = _petsDetailView.GetPetBday()
                };
                _petsServices.Add(pm);
            }
            else {
                
            }
        }

    }
}
