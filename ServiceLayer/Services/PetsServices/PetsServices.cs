using DomainLayer.Models.Pets;
using ServiceLayer.CommonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.PetsServices
{
    public class PetsServices : IPetsServices, IPetsRepository
    {
        private IPetsRepository _petsRepository;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public PetsServices(IPetsRepository petsRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _petsRepository = petsRepository;
        }

        public void Add(PetsModel petsModel)
        {
            _petsRepository.Add(petsModel);
        }

        public void Delete(PetsModel petsModel)
        {
            _petsRepository.Delete(petsModel);
        }

        public void Edit(PetsModel petsModel)
        {
            _petsRepository.Edit(petsModel);
        }

        public IEnumerable<PetsModel> GetAll()
        {
            return _petsRepository.GetAll();
        }

        public PetsModel GetByID(int id)
        {
            return _petsRepository.GetByID(id);
        }

        void IPetsServices.ValidateModel(PetsModel petsModel)
        {
            throw new NotImplementedException();
        }
    }
}
