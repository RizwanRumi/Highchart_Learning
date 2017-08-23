using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;//
using System.Data.SqlClient;//
namespace HighchartDemo.Services
{
 
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class HighchartService : System.Web.Services.WebService
    {
        public class FruitEnity
        {
            public string Name { get; set; }
            public int Value { get; set; }
        }
        [WebMethod]
        public List<FruitEnity> FruitAnalysis()
        {
            List<FruitEnity> fruitinfo = new List<FruitEnity>();
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection("Data Source=XXXXE;User Id=XXXX;Password=XXXX;DataBase=XXXX"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select name,value from tbl_fruitanalysis";
                    cmd.Connection = con;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds, "FruitAnalysis");
                    }
                }
            }
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables["FruitAnalysis"].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables["FruitAnalysis"].Rows)
                        {
                            fruitinfo.Add(new FruitEnity { Name = dr["name"].ToString(), Value = Convert.ToInt32(dr["value"]) });
                        }
                    }
                }
            }
            return fruitinfo;
        }
    }
}
