#define active

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab35___BazaDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=192.168.3.136,50500; Initial Catalog=TESTOWA; User ID=RAFAL; Password=ADMIN123";

            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Console.WriteLine("Połączenie otwarte");
#if (unactive)

            SqlCommand sqlCommandSelect;
            SqlDataReader sqlDataReader;
            string sqlSelect = "";

            sqlSelect = "select * from portfel";

            sqlCommandSelect = new SqlCommand(sqlSelect, sqlConnection);

            sqlDataReader = sqlCommandSelect.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Console.WriteLine($"{sqlDataReader.GetValue(0)} | {sqlDataReader.GetValue(1)} | {sqlDataReader.GetValue(2)} | {sqlDataReader.GetValue(3)} | {sqlDataReader.GetValue(4)}");
            }

            sqlDataReader.Close();
            sqlCommandSelect.Dispose();

#elif (unactive)

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string sqlInsert = "";

            sqlInsert = "insert into Portfel values (5, 'abc', 'WYDATEK', 1111.11, '11.28.2019')";

            sqlDataAdapter.InsertCommand = new SqlCommand(sqlInsert, sqlConnection);
            int ilosc = sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            Console.WriteLine($"wrzucono nowy wiersz w ilosci {ilosc} sztuk");

#elif (unactive)

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string sqlUpdate = "";

            Console.WriteLine("w ktorej pozycji zmieniamy wysokosc kwoty?");
            int id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("nowa kwota to?");
            decimal kwota = Decimal.Parse(Console.ReadLine());

            sqlUpdate = $"update Portfel set Kwota = {kwota} where Id  = {id}";

            sqlDataAdapter.UpdateCommand = new SqlCommand(sqlUpdate, sqlConnection);
            int ilosc = sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

            Console.WriteLine($"zmodyfikowano {ilosc} wierszy");

#elif(active)

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string sqlDelete = "";

            Console.WriteLine("ktora pozycje usuwamy");
            int id = Int32.Parse(Console.ReadLine());

            sqlDelete = $"delete Portfel where id = {id}";

            sqlDataAdapter.DeleteCommand = new SqlCommand(sqlDelete, sqlConnection);
            int ilosc = sqlDataAdapter.DeleteCommand.ExecuteNonQuery();

            Console.WriteLine($"usunieto {ilosc} wiersz/y");

#endif
            sqlConnection.Close();
            Console.WriteLine("Połączenie zamknięte");
            Console.ReadKey();
        }
    }
}
