using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnB.Domain.Domain
{
   public class Adress
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public string AdressName { get; set; }
    }
}
