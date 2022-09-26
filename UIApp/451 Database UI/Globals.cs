using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace _451_Database_UI
{
    public abstract class Globals
    {
        public static List<string> states;
        public static List<string> cities;
        public static List<string> zips;
        public static List<string> categories;
        public static List<string> checkedCategories = new List<string>();
        public static List<string[]> businessInfo;
        public static List<string[]> tipInfo;
        public static NpgsqlConnection con = new NpgsqlConnection("Host = localhost; Username=postgres;Password=pswd;Database=milestone2");

        public static void UpdateCheckedCategoies()
        {

        }

        /// <summary>
        /// States initialize states list used for testing.
        /// </summary>
        public static void InitStates()
        {
            states = new List<string>();

            //var cs = "Host=localhost;Username=postgres;Password=pswd;Database=milestone2";

            //var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT business_state from Business GROUP by business_state";

            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //add to list
                //Console.WriteLine(rdr.GetString(0));
                states.Add(rdr.GetString(0));
            }
            rdr.Close();
            cmd.Dispose();



        }

        /// <summary>
        /// Generate fake cities for testing.
        /// </summary>
        /// <param name="name">base state</param>
        public static void SetCities(string state)
        {
            cities = new List<string>();


            //string sql = "SELECT business_city from Business WHERE business_state = " + "'" + name + "'" +  " GROUP by business_city";
            string sql = $"SELECT business_city from Business WHERE business_state = '{state}' GROUP by business_city";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //add to list
                //Console.WriteLine(rdr.GetString(0));
                cities.Add(rdr.GetString(0));
            }
            rdr.Close();
            cmd.Dispose();

        }

        /// <summary>
        /// Generate fake zips for testing.
        /// </summary>
        /// <param name="name">base city</param>
        public static void SetZips(string city)
        {
            zips = new List<string>();

            string sql = $"SELECT postal_code from Business WHERE business_city = '{city}' GROUP by postal_code";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //add to list
                //Console.WriteLine(rdr.GetInt16(0));
                zips.Add(rdr.GetInt32(0).ToString());
            }
            rdr.Close();
            cmd.Dispose();
        }

        /// <summary>
        /// Generate fake categories for testing.
        /// </summary>
        /// <param name="name">base zip</param>
        public static void SetCategories(string postal_code)
        {
            categories = new List<string>();

            string sql = $"SELECT category_name from Business " +
                $"JOIN Categories ON Business.business_id = Categories.business_id " +
                $"WHERE postal_code = {postal_code} group by category_name";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //add to list
                //Console.WriteLine(rdr.GetInt16(0));
                categories.Add(rdr.GetString(0));
            }
            rdr.Close();
            cmd.Dispose();
        }

        /// <summary>
        /// Sets the list of business info.
        /// </summary>
        /// <param name="zip">Zip code of businesses.</param>
        /// <param name="categories">Categories of businesses.</param>
        public static void SetBusinessInfo(string zip, List<string> categories)
        {
            businessInfo = new List<string[]> { };
            //string[] inputString = { "name", "address", "stars", "id" };
            //string[] inputString;
            string catString = "";
            string sql = "";
            int count = categories.Count()-1;

            if (categories.Count == 0)
            {
                catString = "1=1";
                sql = $"SELECT business_name, business_address, stars, Business.business_id " +
                   $"FROM Business " +
                   $"JOIN Categories ON Business.business_id = Categories.business_id " +
                   $"WHERE postal_code = {zip} " +
                   $"AND ({catString}) " +
                   $"GROUP by business_name, business_address, stars, Business.business_id ";

            }
            else
            {
                catString = "category_name = '" + categories[0] + "'";

                if (categories.Count > 1)
                {
                    foreach (var category in categories.Skip(1))
                    {
                        catString = catString + " OR category_name = '" + category + "'";
                    }
                }

                

                sql = $"SELECT business_name, business_address, stars, Business.business_id " +
                    $"FROM Business " +
                    $"JOIN Categories ON Business.business_id = Categories.business_id " +
                    $"WHERE postal_code = {zip} " +
                    $"AND ({catString}) " +
                    $"GROUP by business_name, business_address, stars, Business.business_id " +
                    $"having count(category_name) > {count}";
            }
            //Console.WriteLine("catString: " + catString);

            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //add to list
                //Console.WriteLine(rdr.GetInt16(0));
                categories.Add(rdr.GetString(0));
                string[] inputString = {rdr.GetString(0), rdr.GetString(1), rdr.GetDouble(2).ToString(), rdr.GetString(3) };
                businessInfo.Add(inputString);
                
                //print debugging
                /*
                foreach (string input in inputString) {
                    Console.Write(input);
                        };
                Console.WriteLine();
                */
            }
            rdr.Close();
            cmd.Dispose();
        }
        public static void SetTipInfo(string businessID)
        {
            // [userID, date, likes, text]
            tipInfo = new List<string[]>();


            //businessID = "TkoyGi8J7YFjA6SbaRzrxg";
            //Console.WriteLine("id:" + businessID);


            string sql = $"SELECT user_id, tipdate, likes, tipText " +
                $"FROM Tip where business_id = '{businessID}'";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //add to list
                //string[] info = new string[4] { businessID, "1/2/34", "7", "this is an example of the body of a text function" };
                string[] info = new string[4] { rdr.GetString(0), rdr.GetTimeStamp(1).ToString(), rdr.GetInt32(2).ToString(), rdr.GetString(3) };
                //Console.WriteLine(rdr.GetString(3));
                tipInfo.Add(info);
            }
            rdr.Close();
            cmd.Dispose();

            
            //tipInfo.Add(new string[4] { "2346546eor7", "7/3/14", "900", "this place was trash lmao. like really bad. like not edible. really really bad. awful. never again in my life will i make such as drastic mistake like going to this trashy, overpriced, excuse for an eating establishment." });
        }
    }
}
