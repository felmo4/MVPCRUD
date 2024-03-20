using DomainLayer.Models.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.PetsServices
{
    interface IPetsServices
    {
        void ValidateModel(PetsModel petsModel);
    }
}
