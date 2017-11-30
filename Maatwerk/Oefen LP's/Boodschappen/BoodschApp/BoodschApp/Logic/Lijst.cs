using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BoodschApp.Logic
{
    public class Lijst
    {
        //properies
        public int ID { get; private set; }
        public int Product_ID { get; private set; }
        public int Aantal { get; private set; }
        public Supermarkt Supermarkt { get; private set; }
        public Product product { get; private set; }
        private List<Product> alleProducten;
        private List<Product> huidigeProducten = new List<Product>();

        //constructor
        public Lijst(int id, int product_ID, int aantal)
        {
            this.ID = id;
            this.Product_ID = product_ID;
            this.Aantal = aantal;
        }

        public Lijst()
        {

        }

        //methods
        public List<Product> SetAlleProducten(List<Product> producten)
        {
            return alleProducten = producten;
        }

        public List<Product> AddToHuidigeProducten(Product product)
        {
            huidigeProducten.Add(product);
            return huidigeProducten;
        }

        public List<Product> GetHuidigeProducten()
        {
            return huidigeProducten;
        }

        public void ProductToevoegen(Product product)
        {
            huidigeProducten.Add(product);
        }

        public void VoegProductToeAanHuidigProduct(Product product)
        {
            huidigeProducten.Add(product);
        }

        public void BoodschappenlijstUitdraaien(string filename, List<Product> huidigeProducten)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Product p in huidigeProducten)
                {
                    writer.Write(p.ToString());
                }
            }
        }

        public override string ToString()
        {
            return "Product: " + Product_ID + "  " + Aantal + "x";
        }
    }
}
