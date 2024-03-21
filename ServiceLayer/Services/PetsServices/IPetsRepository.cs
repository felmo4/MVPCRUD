using DomainLayer.Models.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.PetsServices
{
    public interface IPetsRepository
    {
        void Add(IPetsModel petsModel);
        void Edit(IPetsModel petsModel);
        void Delete(IPetsModel petsModel);

        IEnumerable<PetsModel> GetAll();
        PetsModel GetByID(int id);

    }
}
