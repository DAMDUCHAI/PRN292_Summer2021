using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Product_WF
{
    class Product
    {
        private string idP;
        private string nameP;
        private int priceP;
        private string nameC;

        public string IdP { get => idP; set => idP = value; }
        public string NameP { get => nameP; set => nameP = value; }
        public int PriceP { get => priceP; set => priceP = value; }
        public string NameC { get => nameC; set => nameC = value; }
        public Product()
        {
        }

        public Product(string idP, string nameP, int priceP, string nameC)
        {
            this.idP = idP;
            this.nameP = nameP;
            this.priceP = priceP;
            this.nameC = nameC;
        }



        //Action for Product
        internal static List<Product> GetProducts()
        {
            List<Product> listP = new List<Product>();
            DataTable dataTable = Database.GetDataBySQL("select p.ProductId,p.ProductName,p.Price ,c.CategoryName  from [dbo].[Products] as p left join [dbo].[Categories] as c on p.CategoryId=c.CategoryId");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string idP = dataRow["ProductId"].ToString();
                string nameP = dataRow["ProductName"].ToString();
                int priceP = int.Parse(dataRow["Price"].ToString());
                string nameC = dataRow["CategoryName"].ToString();
                Product product = new Product(idP, nameP, priceP, nameC);
                listP.Add(product);
            }
            return listP;


        }
    }
}
