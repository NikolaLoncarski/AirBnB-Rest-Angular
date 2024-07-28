using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnB.Domain.Domain
{
    public class Reservation
    {
        public int Id { get; set; }
        public int  NumberOfDaysBooked { get; set; }
        public decimal  TotalPrice { get; set; }
        public User Guest { get; set; }
        public enum MyEnum
        {
            Created,
            Rejected,
            GaveUp,
            Acepted,
            Finalized

        } 
    }
}

/*  ● Apartman koji je rezervisan
● Početni datum rezervacije
● Broj noćenja (inicijalno 1 noćenje)
● Ukupna cena
● Gost
● Status (Kreirana, Odbijena, Odustanak, Prihvaćena, Završena)
Napomena: Gost može da rezerviše niz slobodnih/dostupnih datuma samo */