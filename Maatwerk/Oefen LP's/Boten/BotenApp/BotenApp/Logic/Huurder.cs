using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenApp.Logic
{
    public class Huurder
    {
        //properties
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public string Email { get; private set; }
        public decimal Budget { get; private set; }

        //constructor
        public Huurder(int id, string naam, string email, decimal budget)
        {
            this.ID = id;
            this.Naam = naam;
            this.Email = email;
            this.Budget = budget;
        }

        //methods
        public override string ToString()
        {
            return "Huurder: " + Naam;
        }
    }
}
