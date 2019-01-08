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
   class GelirlerRepo
    {
        
        public List<Gelir> FillList()
        {
          
            List<Gelir> lstgd = new List<Gelir>();
            DataTable dt = Program.sqlHelper.FillDataTable("select * from Gelirler");
            foreach (DataRow dataRow in dt.Rows)
            {
              Gelir gd = new Gelir();
                gd.Total = Convert.ToDecimal(dataRow["GelirlerTotal"]);
                gd.DateTimes = Convert.ToDateTime(dataRow["GelirlerDate"]);
                gd.DaireNo = dataRow["GelirlerFlatNo"].ToString();
                lstgd.Add(gd);


            }
            return lstgd;

        }
        public void InsertGelirler(Gelir gd)
        {
            string query = "insert into Gelirler(GelirlerFlatNo,GelirlerDate,GelirlerTotal) values ('"+gd.DaireNo+"','"+gd.DateTimes+"',"+gd.Total+")";
            //SqlParameter p1 = new SqlParameter("flatno",gd.DaireNo);
            //SqlParameter p2 = new SqlParameter("date", gd.DateTimes);
            //SqlParameter p3 = new SqlParameter("total",gd.Total);
            //Program.sqlHelper.ExecuteProc("insertGelir",p1,p2,p3);
            Program.sqlHelper.ExecuteCommand(query);




        }
    }
}
