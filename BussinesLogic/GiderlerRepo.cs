using FlatAutomation.Helpers;
using FlatAutomation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlatAutomation.BussinesLogic
{
   class GiderlerRepo
    {
      
        public List<Gider> FillList()
        {
            List<Gider> lstgd = new List<Gider>();
            DataTable dt = Program.sqlHelper.FillDataTable("select * from Giderler");
            foreach (DataRow dataRow in dt.Rows)
            {
                Gider gd = new Gider();
                gd.Total = (decimal)dataRow["GiderlerTotal"];
                gd.DateTimes = Convert.ToDateTime(dataRow["GiderlerDate"]);
                gd.Giders = dataRow["GiderlerEnum"].ToString();
                lstgd.Add(gd);
                

            }
            return lstgd;

        }
        public void InsertGiderler(Gider gd)
        {
            string query = "insert into Giderler(GiderlerEnum,GiderlerTotal,GiderlerDate) values ('"+gd.Giders+"','"+gd.Total+"','"+gd.DateTimes+"') ";

            Program.sqlHelper.ExecuteCommand(query);






        }
    }
}
