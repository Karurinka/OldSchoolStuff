using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BakkerijGoedGeSpelt.Classes.Exceptions;

namespace BakkerijGoedGeSpelt.Classes
{
    public class Bakkerij
    {
        // properties
        public string Naam { get; private set; }
        public Broodje Broodje { get; private set; }
        public Brood Brood { get; private set; }
        public List<Broodje> Broodjes { get; private set; }
        public List<Brood> Broden { get; private set; }
        public Beleg beleg { get; private set; }
        // constructor
        public Bakkerij(string naam)
        {
            this.Naam = naam;
        }

        public bool VoegBroodjeToe(Broodje broodje)
        {
            if (Broodjes.Contains(Broodje))
            {
                return false;
            }
            else
            {
                Broodjes.Add(Broodje);
                return true;
            }
        }

        public List<Brood> LaadBroodsoortenUitBestand()
        {
            try
            {
                if (
                    File.Exists(
                        (@"C:\Users\miche\Dropbox\Fontys\Maatwerk\Opdrachten\Bakkerij_GoedGespelt\Bakkerij GoedGespelt - Startproject\BakkerijGoedGeSpelt\bin\Debug\BroodSoortenLijst.bin")) == true)
                {
                    FileStream file =
                        File.Open(
                            @"C:\Users\miche\Dropbox\Fontys\Maatwerk\Opdrachten\Bakkerij_GoedGespelt\Bakkerij GoedGespelt - Startproject\BakkerijGoedGeSpelt\bin\Debug\BroodSoortenLijst.bin",
                            FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();

                    Brood = (Brood)bf.Deserialize(file);
                    file.Close();

                    foreach (Brood b in Broden)
                    {
                        bf.Serialize(file, b);
                    }

                    return Broden;
                }
            }
            catch (BakkerijBinairBestand ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }

        public void MaakPrijsLijst(string naamenprijs, string filename)
        {
            FileStream file =
                File.Create(
                    @"C:\Users\miche\Dropbox\Fontys\Maatwerk\Opdrachten\Bakkerij_GoedGespelt\Bakkerij GoedGespelt - Startproject\BakkerijGoedGeSpelt\bin\Debug\Test.bin");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, naamenprijs);
            file.Close();
        }

        public void SlaBroodjesOp(Broodje broodje, string filename)
        {
            FileStream file =
                File.Create(
                    @"C:\Users\miche\Dropbox\Fontys\Maatwerk\Opdrachten\Bakkerij_GoedGespelt\Bakkerij GoedGespelt - Startproject\BakkerijGoedGeSpelt\bin\Debug\broodjes.bin");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, broodje);
            file.Close();

            foreach (Broodje b in Broodjes)
            {
                Broodjes.Add(b);
            }
        }

        public List<Broodje> HaalBroodjesOp()
        {
            try
            {
                if (
                    File.Exists(
                        (@"C:\Users\miche\Dropbox\Fontys\Maatwerk\Opdrachten\Bakkerij_GoedGespelt\Bakkerij GoedGespelt - Startproject\BakkerijGoedGeSpelt\bin\Debug\broodjes.bin")) == true)
                {
                    FileStream file =
                        File.Open(
                            @"C:\Users\miche\Dropbox\Fontys\Maatwerk\Opdrachten\Bakkerij_GoedGespelt\Bakkerij GoedGespelt - Startproject\BakkerijGoedGeSpelt\bin\Debug\broodjes.bin",
                            FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();

                    Broodje = (Brood)bf.Deserialize(file);
                    file.Close();

                    foreach (Broodje b in Broodjes)
                    {
                        bf.Serialize(file, b);
                    }

                    return Broodjes;
                }
            }
            catch (BakkerijBinairBestand ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}
