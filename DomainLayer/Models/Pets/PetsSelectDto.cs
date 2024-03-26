using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Pets
{
    public class PetsSelectDto
    {
        public int petID {  get; set; } 
        public string petname { get; set;}

        public string petbreed { get; set;}
        
        public string petbday { get; set;}
        

    }
}
