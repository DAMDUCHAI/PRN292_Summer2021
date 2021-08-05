using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EditShip.DAO
{
    class Ship
    {
        private string name;
        private string classs;
        private int launched;

        public string Name { get => name; set => name = value; }
        public string Classs { get => classs; set => classs = value; }
        public int Launched { get => launched; set => launched = value; }

        public Ship(string name, string classs, int launched)
        {
            this.name = name;
            this.classs = classs;
            this.launched = launched;
        }
        public Ship()
        {
   
        }
        // lop nghiep vu
        internal static List<Ship> SearchShip(string name)
        {
            List<Ship> Ships = new List<Ship>();
            string sql="select * from Ships where name = '"+name+"'";
            DataTable dataTable = Database.GetDataBySQL(sql);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string n= dataRow["name"].ToString();
                string  c = dataRow["class"].ToString();
                int launched = (int)dataRow["launched"];
                 Ship s = new Ship(n, c, launched);
                Ships.Add(s);
            }

            return Ships;


        }


        internal static List<string> GetClass()
        {
            List<string> classs = new List<string>();
            DataTable dataTable = Database.GetDataBySQL("select class from Classes");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string c = dataRow["class"].ToString();

                classs.Add(c);
            }
            return classs;


        }

        internal static int UpdateShip(ArrayList arrayList)
        {
            string sql = "UPDATE dbo.Ships SET class = @classs ,launched = @launched WHERE name = @name";
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@name", SqlDbType.NChar),
            new SqlParameter("@classs", SqlDbType.NChar),
            new SqlParameter("@launched", SqlDbType.Int),
         
            };
            //Gán giá trị cho các tham số của câu truy vấn
            for (int i = 0; i < arrayList.Count; i++)
            {
                para[i].Value = arrayList[i];
            }
            return Database.ExcuteSQL(sql, para);
        }

    }
}
