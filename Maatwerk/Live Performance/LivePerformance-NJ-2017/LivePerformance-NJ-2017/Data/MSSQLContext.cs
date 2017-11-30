using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance_NJ_2017.Logic;
using LivePerformance_NJ_2017.Logic.Exceptions;
using System.Data.SqlClient;


namespace LivePerformance_NJ_2017.Data
{
    public class MSSQLContext : IContext
    {
        //GET ALL FROM DATABASE
        //haalt alle beschikbare partijen op
        public List<Partij> GetAllPartijen()
        {
            List<Partij> result = new List<Partij>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Partij";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            string Lijsttrekker = Convert.ToString(rd["Lijsttrekker"]);

                            result.Add(new Partij(ID, Naam, Lijsttrekker));
                        }
                        return result;
                    }
                }
            }
        }

        //haalt alle beschikbare verkiezingen op
        public List<Verkiezing> GetAllVerkiezingen()
        {
            List<Verkiezing> result = new List<Verkiezing>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Verkiezing";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string Naam = Convert.ToString(rd["Naam"]);
                            DateTime Datum = Convert.ToDateTime(rd["Datum"]);

                            result.Add(new Verkiezing(ID, Naam, Datum));
                        }
                        return result;
                    }
                }
            }
        }

        //GET BY ID
        //Haal de partij op met het gegeven id
        public Partij GetPartijByID(int id)
        {
            Partij partij;
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT * FROM Partij WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            string Naam = Convert.ToString(rd["Naam"]);
                            string Lijsttrekker = Convert.ToString(rd["Lijsttrekker"]);

                            partij = new Partij(Naam, Lijsttrekker);
                            return partij;
                        }
                    }
                }
                return null;
            }
        }

        //laadt alle uitslagen die bij 1 verkiezing horen
        public List<Uitslag> GetUitslagenVoorVerkiezing(int Verkiezing_ID)
        {
            List<Uitslag> result = new List<Uitslag>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "SELECT u.ID, p.Naam, u.Partij_ID, u.Stemmen " +
                               "FROM Uitslag u " +
                               "INNER JOIN Partij p ON u.Partij_ID = p.ID " +
                               "INNER JOIN Verkiezing v ON u.Verkiezing_ID = v.ID " +
                               "WHERE v.ID = @Verkiezing_ID ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Verkiezing_ID", Verkiezing_ID);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int ID = Convert.ToInt32(rd["ID"]);
                            string PartijNaam = Convert.ToString(rd["Naam"]);
                            int Partij_ID = Convert.ToInt32(rd["Partij_ID"]);
                            int Stemmen = Convert.ToInt32(rd["Stemmen"]);

                            result.Add(new Uitslag(ID, PartijNaam, Partij_ID, Stemmen));
                        }

                        return result;
                    }
                }
            }
        }

        //INSERTS
        //insert een nieuwe verkiezing in de database
        public bool InsertPartij(Partij partij)
        {
            using (SqlConnection conn = Database.Connection)
            {
                string query = "INSERT INTO Partij(Naam, Lijsttrekker)" +
                                "VALUES(@Naam, @Lijsttrekker)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Naam", partij.Naam);
                    cmd.Parameters.AddWithValue("@Lijsttrekker", partij.Lijsttrekker);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        throw new InsertDatabaseException("Er is al een partij aanwezig met de ingevulde gegevens");
                    }
                }
            }
        }

        //insert een nieuwe verkiezing in de database
        public bool InsertVerkiezing(Verkiezing verkiezing)
        {
            using (SqlConnection conn = Database.Connection)
            {
                string query = "INSERT INTO Verkiezing(Naam, Datum)" +
                                "VALUES(@Naam, @Datum)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Naam", verkiezing.Naam);
                    cmd.Parameters.AddWithValue("@Datum", verkiezing.Datum);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        throw new UpdateDatabaseException("Een verkiezing met de ingevulde gegevens bestaat al");
                    }
                }
            }
        }

        //UPDATES
        //
        public bool UpdatePartij(Partij partij)
        {
            using (SqlConnection conn = Database.Connection)
            {
                string query = "UPDATE Partij SET Naam = @Naam, Lijsttrekker = @Lijsttrekker " +
                                "WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", partij.ID);
                    cmd.Parameters.AddWithValue("@Naam", partij.Naam);
                    cmd.Parameters.AddWithValue("@Lijsttrekker", partij.Lijsttrekker);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        throw new UpdateDatabaseException("Er is een fout opgetreden bij het opslaan, probeer opnieuw");
                    }
                }
            }
        }

        public bool UpdateUitslag(Uitslag uitslag)
        {
            using (SqlConnection conn = Database.Connection)
            {
                string query = "UPDATE Uitslag SET Stemmen = @Stemmen " +
                                "WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", uitslag.ID);
                    cmd.Parameters.AddWithValue("@Stemmen", uitslag.Stemmen);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        throw new UpdateDatabaseException("Er is een fout opgetreden bij het veranderen van de stemmen, probeer opnieuw");
                    }
                }
            }
        }
    }
}
