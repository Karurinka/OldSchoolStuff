using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VogeltellersASP.Models.Data;
using VogeltellersASP.Models.Logic;

namespace VogeltellersASP.Models.Logic
{
    public class God
    {
        //project
        public Bezoek Bezoek { get; private set; }
        public Project project { get; private set; }
        public Teller Teller { get; private set; }
        public Vogelsoort Vogelsoort { get; private set; }
        public Waarneming Waarneming { get; private set; }
        private List<Waarneming> waarnemingen;
        private List<Project> projecten;

        //constructor
        public God(Bezoek bezoek, Teller teller, Vogelsoort vogelsoort, Waarneming waarneming)
        {
            this.Bezoek = bezoek;
            this.Teller = teller;
            this.Vogelsoort = vogelsoort;
            this.Waarneming = waarneming;
        }

        public God(Bezoek bezoek, Teller teller, Vogelsoort vogelsoort)
        {
            this.Bezoek = bezoek;
            this.Teller = teller;
            this.Vogelsoort = vogelsoort;
        }

        public God(Teller teller, Vogelsoort vogelsoort, Waarneming waarneming)
        {
            this.Teller = teller;
            this.Vogelsoort = vogelsoort;
            this.Waarneming = waarneming;
        }

        //methods
        public Project ZoekProject(int id)
        {
            foreach (Project p in projecten)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
