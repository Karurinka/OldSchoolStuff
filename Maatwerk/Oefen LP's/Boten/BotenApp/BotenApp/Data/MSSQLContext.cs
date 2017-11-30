using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BotenApp.Logic;

namespace BotenApp.Data
{
    public class MSSQLContext : IContext
    {
        public List<ContractRegel> GetAllContractRegels()
        {
            List<ContractRegel> result = new List<ContractRegel>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM ContractRegel";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            int Huurcontract_ID = Convert.ToInt32(rd["Huurcontract_ID"]);
                            int Artiekel_ID = Convert.ToInt32(rd["Artiekel_ID"]);
                            int Aantal = Convert.ToInt32(rd["Aantal"]);

                            result.Add(new ContractRegel(ID, Huurcontract_ID, Artiekel_ID, Aantal));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Artiekel> GetAllExtraArtiekelen()
        {
            List<Artiekel> result = new List<Artiekel>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Artiekel a " +
                               "INNER JOIN ExtraArtiekel ea ON a.ID = ea.Artiekel_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            decimal Huurprijs = Convert.ToDecimal(rd["Huurprijs"]);

                            result.Add(new ExtraArtiekel(ID, Naam, Huurprijs));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Huurcontract> GetAllHuurcontracten()
        {
            List<Huurcontract> result = new List<Huurcontract>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Huurcontract";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            int Huurder_ID = Convert.ToInt32(rd["Huurder_ID"]);
                            DateTime VanDatum = Convert.ToDateTime(rd["VanDatum"]);
                            DateTime TotDatum = Convert.ToDateTime(rd["TotDatum"]);

                            result.Add(new Huurcontract(ID, Huurder_ID, VanDatum, TotDatum));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Boot> GetAllMotorboten()
        {
            List<Boot> result = new List<Boot>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Artiekel a " +
                               "INNER JOIN Boot b ON a.ID = b.Artiekel_ID " +
                               "INNER JOIN Motorboot mb ON b.ID = mb.Boot_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())  
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            decimal Huurprijs = Convert.ToDecimal(rd["Huurprijs"]);
                            int Registratienummer = Convert.ToInt32(rd["Registratienummer"]);
                            int Tankinhoud = Convert.ToInt32(rd["Tankinhoud"]);
                            int Actieradius = Convert.ToInt32(rd["Actieradius"]);

                            result.Add(new Motorboot(ID, Naam, Huurprijs, Registratienummer, Tankinhoud, Actieradius));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Spierkrachtaangedrevenboot> GetAllSpierkrachtaangedrevenboten()
        {
            List<Spierkrachtaangedrevenboot> result = new List<Spierkrachtaangedrevenboot>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Artiekel a " +
                               "INNER JOIN Boot b ON a.ID = b.Artiekel_ID " +
                               "INNER JOIN Spierkrachtgedrevenboot sb ON b.ID = sb.Boot_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            decimal Huurprijs = Convert.ToDecimal(rd["Huurprijs"]);
                            int Registratienummer = Convert.ToInt32(rd["Registratienummer"]);

                            result.Add(new Spierkrachtaangedrevenboot(ID, Naam, Huurprijs, Registratienummer));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Water> GetAllWateren()
        {
            List<Water> result = new List<Water>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Water";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            decimal Huurprijs = Convert.ToDecimal(rd["Huurprijs"]);
                            decimal Sluisgeld = Convert.ToDecimal(rd["Sluisgeld"]);

                            result.Add(new Water(ID, Naam, Huurprijs, Sluisgeld));
                        }
                        return result;
                    }
                }
            }
        }

        public Boot GetBootByID(int id)
        {
            throw new NotImplementedException();
        }

        public ExtraArtiekel GetExtraArtiekelByID(int id)
        {
            throw new NotImplementedException();
        }

        public Huurcontract GetHuurcontractByID(int id)
        {
            throw new NotImplementedException();
        }

        public Huurder GetHuurderByID(int id)
        {
            Huurder huurder;
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Huurder WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            string Email = Convert.ToString(rd["Email"]);
                            decimal Budget = Convert.ToDecimal(rd["Budget"]);

                            huurder = new Huurder(ID, Naam, Email, Budget);
                            return huurder;
                        }
                    }
                }
                return null;
            }
        }

        public Water GetWaterByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool InsertHuurcontract(Huurcontract huurcontract)
        {
            throw new NotImplementedException();
        }
    }
}
