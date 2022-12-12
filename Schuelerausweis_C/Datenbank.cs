using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace Schuelerausweis_C
{
    internal class Datenbank
    {




        static void Main(string[] args)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            try
            {
                CreateTable(sqlite_conn);

            }
            catch
            {

            }
            InsertData(sqlite_conn);
            ReadData(sqlite_conn);
        }



        //Stellt eine verbindung zur Datenbank her
        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=SADB.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sqlite_conn;
        }




        //Erstellt die Datenbank Tabellen
        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string TableSchueler = "CREATE TABLE IF NOT EXISTS Klasse(kid STRING PRIMARY KEY, dauer INT)";
            string TableKlasse = "REATE TABLE IF NOT EXISTS schueler(sid INT AUTO_INCREMENT, bid INT PRIMARY KEY, status STRING, kid STRING, foto BLOB, auswname STRING, nachname STRING, auswvname STRING, vorname STRING, gebdat DATE, einschulung DATE, gültigbis DATE, FOREIGN KEY(kid) REFERENCES klasse(kid))";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = TableSchueler;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = TableKlasse;
            sqlite_cmd.ExecuteNonQuery();
        }




        //Für das einfügen von Daten in die Datenbank
        static void InsertData(SQLiteConnection conn)
        {
            String kabel = "11BFI0";
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"INSERT INTO Klasse(Col1, Col2) VALUES({kabel}, 3); ";
            sqlite_cmd.ExecuteNonQuery();

        }






        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM SampleTable";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();
        }
    }
}
