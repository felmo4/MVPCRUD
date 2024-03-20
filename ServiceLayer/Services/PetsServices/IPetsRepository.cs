using DomainLayer.Models.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.PetsServices
{
    interface IPetsRepository
    {
        void Add(PetsModel petsModel);
        void Edit(PetsModel petsModel);
        void Delete(PetsModel petsModel);

        IEnumerable<PetsModel> GetAll();
        PetsModel GetByID(int id);

    }
}
