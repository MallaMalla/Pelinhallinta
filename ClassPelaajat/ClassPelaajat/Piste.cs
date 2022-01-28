using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPelaajat
{
    public class Piste : db
    {
        //omat variablet
        private DataTable dt = new DataTable();
        private string virhe = "0";

        //julkiset variablet
        public DataTable Dt
        {
            get
            {
                return dt;
            }
            set
            {
                dt = value;
            }
        }

        public string Virhe
        {
            get
            {
                return virhe;
            }
            set
            {
                virhe = value;
            }
        }

        public void Tallenna(string sId, string sPisteet, string sPvm)
        {
            try
            {
                int iId = Int32.Parse(sId);
                int iPisteet = Int32.Parse(sPisteet);

                //Tietokantayhteyden avaus
                sqlite_conn.Open();

                //SQLiteDataReader reader;
                SQLiteCommand sqlCmd;
                sqlCmd = sqlite_conn.CreateCommand();
                sqlCmd.CommandText = "INSERT INTO pisteet(pelaajaID, pisteet, pvm) VALUES(" + iId + ", " + iPisteet + ", '" + sPvm + "')";
                sqlCmd.ExecuteNonQuery();

                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                this.Virhe = e.ToString();
            }
        }

        public void HaeHistoria(string sId)
        {
            try
            {
                int iId = Int32.Parse(sId);
                //Tietokantayhteyden avaus
                sqlite_conn.Open();

                SQLiteDataReader reader;
                SQLiteCommand sqlCmd;
                sqlCmd = sqlite_conn.CreateCommand();
                sqlCmd.CommandText = "SELECT * FROM pisteet INNER JOIN pelaaja ON pisteet.pelaajaID=pelaaja.pelaajaID WHERE pisteet.pelaajaID = " + iId;


                reader = sqlCmd.ExecuteReader();

                Dt.Load(reader);

                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                this.Virhe = e.ToString();
            }
        }

        public void HaeRanking()
        {
            try
            {
                //Tietokantayhteyden avaus
                sqlite_conn.Open();

                SQLiteDataReader reader;
                SQLiteCommand sqlCmd;
                sqlCmd = sqlite_conn.CreateCommand();
                sqlCmd.CommandText = "SELECT *, MAX(pisteet) FROM pisteet INNER JOIN pelaaja ON pisteet.pelaajaID=pelaaja.pelaajaID GROUP BY pelaaja.pelaajaID ORDER BY pisteet DESC";


                reader = sqlCmd.ExecuteReader();

                Dt.Load(reader);

                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                this.Virhe = e.ToString();
            }
        }
    }
}
