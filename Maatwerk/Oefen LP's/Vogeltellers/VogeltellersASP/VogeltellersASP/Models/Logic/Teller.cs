using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VogeltellersASP.Models.Logic
{
    public class Teller
    {
        //properties
        public int ID { get; private set; }
        public string Voornaam { get; private set; }
        public string Achternaam { get; private set; }
        public string Gebruikersnaam { get; private set; }
        public string Wachtwoord { get; private set; }
        private List<Project> Projecten;

        //constructor
        public Teller(int id, string voornaam, string achternaam, string gebruikersnaam, string wachtwoord)
        {
            this.ID = id;
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Gebruikersnaam = gebruikersnaam;
            this.Wachtwoord = wachtwoord;
        }

        public Teller(string gebruikersnaam, string wachtwoord)
        {
            this.Gebruikersnaam = gebruikersnaam;
            this.Wachtwoord = wachtwoord;
        }

        //methods
        //public List<Project> HaalProjectenOp(int projectid)
        //{
        //    List<Project> result = new List<Project>();
        //    foreach (Project p in Projecten)
        //    {
        //        if (projectid == ID)
        //        {
        //            result.Add(p);
        //        }
        //        return result;
        //    }
        //    return null;
        //}
    }
}