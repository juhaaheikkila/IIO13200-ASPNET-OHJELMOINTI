using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public static class DBDemoxOy
    {
        public static DataTable GetDataSimple()
        {
            //DB-kerros
            //taulu
            DataTable dt = new DataTable();
            //sarakkeet
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            //tietueet eli rivit
            dt.Rows.Add("Kalle", "Isokallio");
            dt.Rows.Add("Matt", "Nickerson");
            return dt;
        }
        public static DataTable GetDataReal()
        {
            //DBkerros, haetaan DemoxOy-tietokannasta taulun asiakkaat tietueet, palauttaa DataTablen
            try
            {
                string sql = "";
                //sql = "SELECT asioid, lastname, firstname, date FROM lasnaolot"; // WHERE asioid='salesa'";
                sql = "SELECT astunnus, asnimi, yhteyshlo, postitmp FROM asiakas ORDER BY astunnus"; // WHERE asioid='salesa'";
//string connStr = @"Data source=eight.labranet.jamk.fi;initial catalog=DemoxOy;user=koodari;password=koodari13";
                string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["Asiakkaat"].ConnectionString;
                //< add name = "Asiakkaat" connectionString = "Data Source=twelve.labranet.jamk.fi;Initial Catalog=DemoxOy;Persist Security Info=True;User ID=koodari;Password=koodari16" providerName = "System.Data.SqlClient" />
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    //avataan yhteys
                    conn.Open();
                    //luodaan komento = command-olio
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "asiakkaat");
                        return ds.Tables["asiakkaat"];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
