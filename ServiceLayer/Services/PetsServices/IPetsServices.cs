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
        void ValidateModel(IPetsModel petsModel);
        void ValidateModelDataAnnotations(IPetsModel petsModel);
        List<PetsSelectDto> GetDepartmentSelectList();
    }
}
