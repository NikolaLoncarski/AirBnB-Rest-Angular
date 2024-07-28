using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnB.Domain.Domain
{
    public class Review
    {
        public  int Id { get; set; }
        public RealEstate RealEstate { get; set; }
        public string  Description { get; set; }
        public  int  Grade { get; set; }
    }
}
/* ● Gost koji je ostavio komentar
● Apartman na koji se odnosi komentar
● Tekst
● Ocena za apartman*/