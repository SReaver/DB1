using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btGetInfo_Click(object sender, EventArgs e)
        {

//            alter proc P_GET_BOOKS
//@code float
//as
//--через динамический SQL
//declare
//@sql varchar(100)
//set @sql = 'select * from Table_Temp2'
//if @code > 0
//set @sql = @sql + ' where id = ' + CAST(@code as varchar)
//exec(@sql)


//--через if
//--if @code = 0
//--select* from Table_Temp2
//--else


//--через case
//--select * from Table_Temp2
//--where id =
//--case when @code = 0 then id else @code end






            string conSt = @"Server = 403_4_\sqlexpress; Database = Books; Trusted_Connection = True";
            //через обычный Select
            //string sql = "select * from Table_Temp2 where id = @param";
            //через процедуру
            string sql = "P_GET_BOOKS"; 
            using (SqlConnection con = new SqlConnection(conSt))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                //через текст
                //cmd.CommandType = CommandType.Text;
                //через процедуру
                cmd.CommandType = CommandType.StoredProcedure;

                //возможности передачи параметров
                //cmd.Parameters.Add("param", SqlDbType.VarChar, 10).Value = tbCode.Text;

                // cmd.Parameters.Add("code", SqlDbType.Float, 10).Value = Convert.ToDouble(tbCode.Text);

                //через AddWithValue
                //cmd.Parameters.AddWithValue("code", Convert.ToDouble(tbCode.Text));

                ////через отдельно созданный параметр
                //SqlParameter param1 = new SqlParameter();
                //param1.ParameterName = "code";
                //param1.SqlDbType = SqlDbType.Float;
                //param1.Direction = ParameterDirection.Input;
                ////без проверки на пустоту
                ////param1.Value = Convert.ToDouble(tbCode.Text);
                ////добавляем проверку на пустой ввод
                //param1.Value = string.IsNullOrEmpty(tbCode.Text) ? 0 : Convert.ToDouble(tbCode.Text);
                //cmd.Parameters.Add(param1);
                ////Console.WriteLine("");




                SqlDataAdapter da = new SqlDataAdapter(cmd);
                try
                {
                    
                    DataSet ds = new DataSet();
                    con.Open();
                    da.Fill(ds);
                    gvBooks.DataSource = ds.Tables[0];


                    Text = "Подключено!";
                }
                catch (Exception err)
                {

                    Text = err.Message;
                }

                finally
                {
                    cmd.Dispose();
                    da.Dispose();
                }

            }
        }
    }
}
