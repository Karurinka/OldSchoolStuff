using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using VogeltellersASP.Models.Logic;

namespace VogeltellersASP.Models.Data
{
    public class MSSQLContext : IContext
    {
        IContext Context;

        public MSSQLContext(IContext context)
        {
            this.Context = context;
        }

        public List<Bezoek> GetAllBezoeken()
        {
            List<Bezoek> result = new List<Bezoek>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Bezoek";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            int BezoekNummer = Convert.ToInt32(rd["BezoekNummer"]);
                            int AantalPunten = Convert.ToInt32(rd["AantalPunten"]);
                            DateTime Datum = Convert.ToDateTime(rd["Datum"]);

                            result.Add(new Bezoek(ID, BezoekNummer, AantalPunten, Datum));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Project> GetAllProjecten()
        {
            List<Project> result = new List<Project>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Project";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            string GebiedNaam = Convert.ToString(rd["GebiedNaam"]);

                            result.Add(new Project(ID, Naam, GebiedNaam));
                        }
                        return result;
                    }
                }
            }
        }



        public List<Vogelsoort> GetAllVogelsoorten()
        {
            List<Vogelsoort> result = new List<Vogelsoort>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Vogelsoort";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            string Afkorting = Convert.ToString(rd["Afkorting"]);
                            DateTime BroedStart = Convert.ToDateTime(rd["BroedStart"]);
                            DateTime BroedEind = Convert.ToDateTime(rd["BroedEind"]);
                            int BroedpaarCijfer = Convert.ToInt32(rd["BroedpaarCijfer"]);

                            result.Add(new Vogelsoort(ID, Naam, Afkorting, BroedStart, BroedEind, BroedpaarCijfer));
                        }
                        return result;
                    }
                }
            }
        }

        public List<Waarneming> GetAllWaarnemingen()
        {
            List<Waarneming> result = new List<Waarneming>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Waarnemingen";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            int Vogel_ID = Convert.ToInt32(rd["Vogel_ID"]);
                            string Categorie = Convert.ToString(rd["Categorie"]);
                            string Afkorting = Convert.ToString(rd["Afkorting"]);
                            int Punten = Convert.ToInt32(rd["Punten"]);

                            result.Add(new Waarneming(ID, Vogel_ID, Categorie, Afkorting, Punten));
                        }
                        return result;
                    }
                }
            }
        }

        public Bezoek GetBezoekByID(int id)
        {
            Bezoek bezoek;
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Bezoek WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            int BezoekNummer = Convert.ToInt32(rd["BezoekNummer"]);
                            int AantalPunten = Convert.ToInt32(rd["AantalPunten"]);
                            DateTime Datum = Convert.ToDateTime(rd["Datum"]);

                            bezoek = new Bezoek(ID, BezoekNummer, AantalPunten, Datum);
                            return bezoek;
                        }
                    }
                }
            }
            return null;
        }

        public Vogelsoort GetVogelsoortByID(int id)
        {
            Vogelsoort vogelsoort;
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Vogelsoort WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            string Afkorting = Convert.ToString(rd["Afkorting"]);
                            DateTime BroedStart = Convert.ToDateTime(rd["BroedStart"]);
                            DateTime BroedEind = Convert.ToDateTime(rd["BroedEind"]);
                            int BroedpaarCijfer = Convert.ToInt32(rd["BroedpaarCijfer"]);

                            vogelsoort = new Vogelsoort(ID, Naam, Afkorting, BroedStart, BroedEind, BroedpaarCijfer);
                            return vogelsoort;
                        }
                    }
                }
            }
            return null;
        }

        public Waarneming GetWaarnemingByID(int id)
        {
            Waarneming waarneming;
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Waarneming WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            int Vogel_ID = Convert.ToInt32(rd["Vogel_ID"]);
                            string Categorie = Convert.ToString(rd["Categorie"]);
                            string Afkorting = Convert.ToString(rd["Afkorting"]);
                            int Punten = Convert.ToInt32(rd["Punten"]);

                            waarneming = new Waarneming(ID, Vogel_ID, Categorie, Afkorting, Punten);
                            return waarneming;
                        }
                    }
                }
            }
            return null;
        }

        public Project GetBezoekPerProject(int id)
        {
            Project project;
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Project_Bezoek WHERE Project_ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int Project_ID = Convert.ToInt32(rd["Project_ID"]);

                            return project = new Project(Project_ID);
                        }
                        return null;
                    }
                }
            }
        }

        public Bezoek GetWaarnemingPerBezoek(int id)
        {
            Bezoek bezoek;
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Bezoek_Waarneming WHERE Bezoek_ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int Bezoek_ID = Convert.ToInt32(rd["Bezoek_ID"]);

                            return bezoek = new Bezoek(Bezoek_ID);
                        }
                        return null;
                    }
                }
            }
        }

        public bool InsertBezoek(Bezoek bezoek)
        {
            using (SqlConnection conn = Database.Connection)
            {
                string query = "INSERT INTO Bezoek (ID, BeginTijd, EindTijd)" +
                                "VALUES (@ID, @BeginTijd, @EindTijd)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", bezoek.ID);
                    command.Parameters.AddWithValue("@BezoekNummer", bezoek.BezoekNummer);
                    command.Parameters.AddWithValue("@AantalPunten", bezoek.AantalPunten);
                    command.Parameters.AddWithValue("@Datum", bezoek.Datum);
                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        public bool InsertWaarneming(Waarneming waarneming)
        {
            using (SqlConnection conn = Database.Connection)
            {
                string query = "INSERT INTO Waarneming (ID, Vogel_ID, Categorie, Afkorting, Punten)" +
                                "VALUES (@ID, @Vogel_ID, @Categorie, @Afkorting, @Punten)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", waarneming.ID);
                    command.Parameters.AddWithValue("@Vogel_ID", waarneming.Vogel_ID);
                    command.Parameters.AddWithValue("@Categorie", waarneming.Categorie);
                    command.Parameters.AddWithValue("@Afkorting", waarneming.Afkorting);
                    command.Parameters.AddWithValue("@Punten", waarneming.Punten);
                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        public bool InsertProject(Project project)
        {
            using (SqlConnection conn = Database.Connection)
            {
                string query = "INSERT INTO Project(ID, Naam, GebiedNaam, Kaart)" +
                                "VALUES (@ID, @Naam, @GebiedNaam, @Kaart)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", project.ID);
                    command.Parameters.AddWithValue("@Naam", project.Naam);
                    command.Parameters.AddWithValue("@GebiedNaam", project.GebiedNaam);
                    command.Parameters.AddWithValue("@Kaart", project.Kaart);
                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}