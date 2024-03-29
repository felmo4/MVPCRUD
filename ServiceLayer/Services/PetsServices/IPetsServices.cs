using DomainLayer.Models.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.PetsServices
{
    public interface IPetsServices
    {
        void Add(IPetsModel petsModel);

        void Delete(IPetsModel petsModel);

        void Edit(IPetsModel petsModel);

        IEnumerable<PetsModel> GetAll();

        PetsModel GetByID(int id);

        void ValidateModel(IPetsModel petsModel);
        void ValidateModelDataAnnotations(IPetsModel petsModel);
    }
}
