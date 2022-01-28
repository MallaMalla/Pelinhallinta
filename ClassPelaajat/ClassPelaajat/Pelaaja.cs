using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPelaajat
{
    public class Pelaaja : db
    {
        //omat variablet
        private DataTable dt = new DataTable();
        private int loytyi = 0;
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

        public int Loytyi
        {
            get
            {
                return loytyi;
            }
            set
            {
                loytyi = value;
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

        public void HaePelaajat()
        {
            try
            {
                //Tietokantayhteyden avaus
                sqlite_conn.Open();

                SQLiteDataReader reader;
                SQLiteCommand sqlCmd;
                sqlCmd = sqlite_conn.CreateCommand();
                sqlCmd.CommandText = "SELECT * FROM pelaaja";

                reader = sqlCmd.ExecuteReader();

                Dt.Load(reader);

                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                this.Virhe = e.ToString();
            }
        }

        public void HaePelaaja(string sId)
        {
            try
            {
                int iId = Int32.Parse(sId);
                //Tietokantayhteyden avaus
                sqlite_conn.Open();

                SQLiteDataReader reader;
                SQLiteCommand sqlCmd;
                sqlCmd = sqlite_conn.CreateCommand();
                sqlCmd.CommandText = "SELECT * FROM pelaaja WHERE pelaajaID = " + iId;

                reader = sqlCmd.ExecuteReader();

                Dt.Load(reader);

                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                this.Virhe = e.ToString();
            }
        }

        public void muokkaaPelaaja(string sId, string sNimi, string sEmail, string sSalasana)
        {
            try
            {
                int iId = Int32.Parse(sId);

                ////Tietokantayhteyden avaus
                sqlite_conn.Open();

                SQLiteDataReader reader;
                SQLiteCommand sqlCmd;
                sqlCmd = sqlite_conn.CreateCommand();
                sqlCmd.CommandText = "SELECT * FROM pelaaja WHERE email = '" + sEmail + "' AND NOT pelaajaID = " + iId;

                reader = sqlCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    this.Loytyi = 1;

                    reader.Close();
                    sqlite_conn.Close();

                    return;
                }
                else
                {
                    sqlCmd = sqlite_conn.CreateCommand();
                    sqlCmd.CommandText = "UPDATE pelaaja SET nimi = '" + sNimi + "', email = '" + sEmail + "', salasana = '" + sSalasana + "' WHERE pelaajaID = " + iId;
                    sqlCmd.ExecuteNonQuery();
                }

                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                this.Virhe = e.ToString();
            }
        }

        public void poistaPelaaja(string sId)
        {
            try
            {
                int iId = Int32.Parse(sId);

                ////Tietokantayhteyden avaus
                sqlite_conn.Open();

                SQLiteCommand sqlCmd;
                sqlCmd = sqlite_conn.CreateCommand();
                sqlCmd.CommandText = "DELETE FROM pelaaja WHERE pelaajaID = " + iId;

                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                this.Virhe = e.ToString();
            }
        }

        public void Tallenna(string sNimi, string sEmail, string sSalasana)
        {
            try
            {
                //Tietokantayhteyden avaus
                sqlite_conn.Open();

                SQLiteDataReader reader;
                SQLiteCommand sqlCmd;
                sqlCmd = sqlite_conn.CreateCommand();
                sqlCmd.CommandText = "SELECT * FROM pelaaja WHERE email = '" + sEmail + "'";

                reader = sqlCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    this.Loytyi = 1;

                    reader.Close();
                    sqlite_conn.Close();

                    return;
                }
                else
                {
                    sqlCmd = sqlite_conn.CreateCommand();
                    sqlCmd.CommandText = "INSERT INTO pelaaja(nimi, email, salasana) VALUES('" + sNimi + "', '" + sEmail + "', '" + sSalasana + "')";
                    sqlCmd.ExecuteNonQuery();
                }

                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                this.Virhe = e.ToString();
            }
        }
    }
}
