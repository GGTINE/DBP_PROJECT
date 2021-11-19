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
        private string Connection_Info =
            "Server = kmu.kro.kr;" +
            "Port = 3306;" +
            "Database = s5469394;" +
            "Uid = s5469394;" +
            "Pwd = s5469394;" +
            "Charset = utf8";

        public bool WriteQuery(string Query)
        {
            using MySqlConnection conn = new(Connection_Info);
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

        public DataTable GetGrid(string Query)
        {
            using MySqlConnection conn = new(Connection_Info);
            conn.Open();
            MySqlCommand cmd = new(Query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new();
            dt.Load(rdr);
            return dt;
        }

        public bool Compare(params string[] values)
        {
            using MySqlConnection conn = new(Connection_Info);
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
                        return true;
                    }
                }
            }
            return false;
        }

        public Dictionary<string, string> GetSelect(string Query)
        {
            using MySqlConnection conn = new(Connection_Info);
            conn.Open();
            MySqlCommand cmd = new(Query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            Dictionary<string, string> Dict = new();
            var ColumnName = Enumerable.Range(0, rdr.FieldCount).Select(rdr.GetName).ToList();

            rdr.Read();

            for (int i = 0; i < ColumnName.Count; i++)
            {
                Dict.Add(ColumnName[i], rdr[ColumnName[i]].ToString());
            }
            return Dict;
        }
    }
}