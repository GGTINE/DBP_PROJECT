using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBP_PROJECT
{
    public class DBManager
    {
        private static DBManager instance;
        public static DBManager GetInstance()
        {
            if (instance == null)
                instance = new DBManager();
            return instance;
        }
        private string String_Connection_Infomation =
            "Server = kmu.kro.kr;" +
            "Port = 3306;" +
            "Database = s5469394;" +
            "Uid = s5469394;" +
            "Pwd = s5469394;" +
            "Charset = utf8";


        #region Write
        public bool WriteQuery(string Query)
        {
            using (MySqlConnection conn = new(String_Connection_Infomation))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new(Query, conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public DataTable SELECT(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(String_Connection_Infomation))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                return dt;
            }
        }

        #endregion

        #region Compare
        public bool Compare(params string[] values)
        {
            MySqlConnection conn = new(String_Connection_Infomation);
            conn.Open();
            MySqlCommand cmd = new(values[0], conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                for (int i = 1, count = 1; i < values.Length; i++)
                {
                    if (rdr[values[i++]].ToString() == values[i])
                    {
                        count += 2;
                    }
                    if (values.Length == count)
                    {
                        rdr.Close();
                        conn.Close();
                        return true;
                    }
                }
            }
            rdr.Close();
            conn.Close();
            return false;
        }
        #endregion

        public Dictionary<string, string> Get_Select(string sql_query)
        {
            MySqlConnection conn = new(String_Connection_Infomation);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql_query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            var dict = new Dictionary<string, string>();
            List<string> columns = Enumerable.Range(0, rdr.FieldCount).Select(rdr.GetName).ToList();

            rdr.Read();

            for (int i = 0; i < columns.Count; i++)
            {
                string key = columns[i];
                string value = rdr[columns[i]].ToString();
                dict.Add(key, value);
            }
            conn.Close();
            return dict;
        }
    }
}
