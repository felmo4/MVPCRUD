using DomainLayer.Models.Pets;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.PetsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Tests
{
    public class PetsServicesFixture
    {
        private IPetsModel _petsModel;
        private IPetsServices _petsServices;

        public PetsServicesFixture()
        {
            _petsModel = new PetsModel();
            _petsServices = new PetsServices(null, new ModelDataAnnotationCheck());
        }

        public PetsModel PetsModel
        {
            get { return (PetsModel)_petsModel; }
            set { _petsModel = value; }
        }

        public PetsServices PetsServices
        {
            get { return (PetsServices)_petsServices; }
            set { _petsServices = value; }
        }

    }
}
