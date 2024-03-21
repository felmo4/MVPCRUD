using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Pets
{
    public class PetsModel : IPetsModel
    {
        public int petID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Pet name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Pet name must be 2 to 20 characters")]
        public string petname { get; set; }

        [Required(ErrorMessage = "Pet breed is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Pet breed must be 3 to 20 characters")]
        public string petbreed { get; set; }

        [Required(ErrorMessage = "Pet birthday is required")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public string petbday { get; set; }
    }
}
