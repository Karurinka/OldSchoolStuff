using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoodschApp.Logic;
using System.Data.SqlClient;

namespace BoodschApp.Data
{
    public class MSSQLContext : IContext
    {
        public List<Gerecht> GetAllGerechten()
        {
            List<Gerecht> result = new List<Gerecht>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Gerecht";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);

                            result.Add(new Gerecht(ID, Naam));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Lijst> GetAllLijsten()
        {
            List<Lijst> result = new List<Lijst>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Lijst";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            int Product_ID = Convert.ToInt32(rd["Product_ID"]);
                            int Aantal = Convert.ToInt32(rd["Aantal"]);

                            result.Add(new Lijst(ID, Product_ID, Aantal));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Product> GetAllProducten()
        {
            List<Product> result = new List<Product>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Product";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            string Hoeveelheid = Convert.ToString(rd["Hoeveelheid"]);

                            result.Add(new Product(ID, Naam, Hoeveelheid));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Supermarkt> GetAllSupermarkten()
        {
            List<Supermarkt> result = new List<Supermarkt>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Supermarkt";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);

                            result.Add(new Supermarkt(ID, Naam));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Product> GetProductenVoorGerecht(int gerecht_ID)
        {
            List<Product> result = new List<Product>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Gerecht_Ingrediënt WHERE Gerecht_ID = @Gerecht_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Gerecht_ID", gerecht_ID);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int Product_ID = Convert.ToInt32(rd["Product_ID"]);
                            Product product = GetProductByID(Product_ID);

                            result.Add(product);
                        }
                        return result;
                    }
                }
            }
        }

        public Gerecht GetGerechtByID(int id)
        {
            Gerecht gerecht;
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Gerecht WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);

                            gerecht = new Gerecht(ID, Naam);
                            return gerecht;
                        }
                    }
                }
                return null;
            }
        }

        public Product GetProductByID(int id)
        {
            Product product;
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Product WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            string Hoeveelheid = Convert.ToString(rd["Hoeveelheid"]);

                            product = new Product(ID, Naam, Hoeveelheid);
                            return product;
                        }
                    }
                }
                return null;
            }
        }
    }
}
