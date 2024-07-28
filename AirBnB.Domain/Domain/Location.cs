using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnB.Domain.Domain
{
    public class Location
    {
        public int Id { get; set; }
        public string Latitude { get; set; }
        public string Longidute { get; set; }

        public Adress Adress { get; set; }
    }
}
