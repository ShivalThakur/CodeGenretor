using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using s = System.Net;
using System.Data.SqlClient;

namespace SearchFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process proc = new System.Diagnostics.Process();
            //proc.StartInfo.FileName = @"C:\Users\Shival\Desktop\date.bat";
            //proc.Start();
           
            
        }

        //private void bindDirectories()
        //{
        //    DataTable dt = new DataTable();
        //    DataRow dr;
        //    DataColumn col = new DataColumn("col", typeof(string));
        //    dt.Columns.Add(col);
        //    string[] arr = System.IO.Directory.GetDirectories(comboBox1.SelectedValue.ToString());
        //    foreach (string str in arr)
        //    {
        //        dr = dt.NewRow();
        //        dr[0] = str.ToUpper();
        //        dt.Rows.Add(dr);
        //    }
        //    folders.DataSource = arr;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'connectionStringsDataSet.tab' table. You can move, or remove it, as needed.
            this.tabTableAdapter.Fill(this.connectionStringsDataSet.tab);
            // TODO: This line of code loads data into the 'connectionStringsDataSet1.tab' table. You can move, or remove it, as needed.
         
            bindDropForDrives();
        }

        private void bindDropForDrives()
        {
            //comboBox1.DataSource = System.Environment.GetLogicalDrives();
           
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bindDirectories();
        }

        private void folders_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindFileExtention();
        }

        private void bindFileExtention()
        {
            //foreach (string file in Directory.GetFiles(folders.SelectedValue.ToString()))
            //{
            //    Path.GetExtension(file);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conStr="";
            if (cs.SelectedValue == null)
                conStr = cs.Text;
            else
                conStr= cs.SelectedValue.ToString();

            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter adapter = new SqlDataAdapter(@"select column_name,data_type from information_schema.columns
 where table_name = @tablename
and COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') <> 1", con);
            adapter.SelectCommand.Parameters.Add("@tablename", SqlDbType.VarChar).Value = textBox3.Text;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            string insertQuery = SqlCommand.Text+"= new SqlCommand(\"insert into "+textBox3.Text+"(";
            //
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
                if(i==0)
                {
                    insertQuery+="["+ds.Tables[0].Rows[i]["column_name"]+"]";
                }
                else
                {
                    insertQuery+=","+"["+ds.Tables[0].Rows[i]["column_name"]+"]";
                }
			 
			}
            insertQuery += ")";
            insertQuery += " values (";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    insertQuery += "@"+ds.Tables[0].Rows[i]["column_name"].ToString().Replace(" ","_");
                }
                else
                {
                    insertQuery += "," +"@"+ ds.Tables[0].Rows[i]["column_name"].ToString().Replace(" ","_");
                }

            }
            insertQuery += ")\","+textBox1.Text+");";
            //parameters
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                insertQuery += "\n"+SqlCommand.Text+".Parameters.Add(\"@" + ds.Tables[0].Rows[i]["column_name"].ToString().Replace(" ", "_") + "\",SqlDbType." +SqlDataType(ds.Tables[0].Rows[i]["data_type"].ToString()) + ").Value="; 
            }
            
            

            ///
            ///
            richTextBox1.Text = insertQuery;
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Method to convert sql data type to c# SqlDbType
        /// </summary>
        /// <param name="comingDataType"></param>
        /// <returns></returns>
     public string   SqlDataType(string comingDataType)
        {
            string returndatatype = "";
            switch (comingDataType.ToLower())
            {
                case "date":
                    {
                        returndatatype = "Date";
                        break;
                    }
                case "datetime":
                    {
                        returndatatype = "DateTime";
                        break;
                    }
                case "varchar":
                    {
                        returndatatype = "VarChar";
                        break;
                    }
                case "int":
                    {
                        returndatatype = "Int";
                        break;
                    }
                case "nvarchar":
                    {
                        returndatatype = "NVarChar";
                        break;
                    }
                case "char":
                    {
                        returndatatype = "Char";
                        break;
                    }
            }
            return returndatatype;
        }

      private void textBox1_TextChanged_1(object sender, EventArgs e)
      {

      }

      private void button3_Click(object sender, EventArgs e)
      {
          
      }

      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void Genrate_Update(object sender, EventArgs e)
      {
          SqlConnection con = new SqlConnection(cs.SelectedValue.ToString());
          SqlDataAdapter adapter = new SqlDataAdapter(@"select column_name,data_type from information_schema.columns
 where table_name = @tablename
and COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') <> 1", con);
          adapter.SelectCommand.Parameters.Add("@tablename", SqlDbType.VarChar).Value = textBox3.Text;
          DataSet ds = new DataSet();
          adapter.Fill(ds);
          string updateQuery = SqlCommand.Text + "= new SqlCommand(\" update " + textBox3.Text + " set ";

          for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
          {
              if (i == 0)
              {
                  updateQuery += "[" + ds.Tables[0].Rows[i]["column_name"] + "]=@" + ds.Tables[0].Rows[i]["column_name"].ToString().Replace(' ', '_') + "";
              }
              else
              {
                  updateQuery += "," + "[" + ds.Tables[0].Rows[i]["column_name"] + "]=@" + ds.Tables[0].Rows[i]["column_name"].ToString().Replace(' ', '_') + "";
              }

          }
          /////////////Get Table Primary Key
          adapter = new SqlDataAdapter(@"SELECT  cu.COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE cu WHERE EXISTS 
 ( SELECT tc.* FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc WHERE tc.TABLE_NAME =@tablename AND tc.CONSTRAINT_TYPE = 'PRIMARY KEY' AND tc.CONSTRAINT_NAME = cu.CONSTRAINT_NAME )
", con);
          adapter.SelectCommand.Parameters.Add("@tablename", SqlDbType.VarChar).Value = textBox3.Text;
          DataSet ds_PK = new DataSet();
          adapter.Fill(ds_PK);
          //////////////////////
          updateQuery = updateQuery + " where " + ds_PK.Tables[0].Rows[0][0].ToString() + " =@" + ds_PK.Tables[0].Rows[0][0].ToString().Replace(" ", "_") + "\"," + textBox1.Text + ");";
          for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
          {
              updateQuery += "\n" + SqlCommand.Text + ".Parameters.Add(\"@" + ds.Tables[0].Rows[i]["column_name"].ToString().Replace(" ", "_") + "\",SqlDbType." + SqlDataType(ds.Tables[0].Rows[i]["data_type"].ToString()) + ").Value=";
          }


          richTextBox1.Text = updateQuery;
      }

      private void button4_Click(object sender, EventArgs e)
      {
          SPs sps = new SPs();
          string conStr = "";
          if (cs.SelectedValue == null)
              conStr = cs.Text;
          else
              conStr = cs.SelectedValue.ToString();

          sps.Connection_Strings.Text = conStr;
          sps.Show();
          //sent to new form
//          string query = @"SELECT SCHEMA_NAME(SCHEMA_ID) AS [Schema],
//SO.name AS [ObjectName],
//SO.Type_Desc AS [ObjectType (UDF/SP)],
//P.parameter_id AS [ParameterID],
//P.name AS [ParameterName],
//TYPE_NAME(P.user_type_id) AS [ParameterDataType],
//P.max_length AS [ParameterMaxBytes],
//P.is_output AS [IsOutPutParameter]
//FROM sys.objects AS SO
//INNER JOIN sys.parameters AS P
//ON SO.OBJECT_ID = P.OBJECT_ID
//WHERE SO.OBJECT_ID IN ( SELECT OBJECT_ID
//FROM sys.objects
//WHERE TYPE IN ('P','FN'))
//ORDER BY [Schema], SO.name, P.parameter_id";

      }

      private void button5_Click(object sender, EventArgs e)
      {
          
          _3_Tirer _3T = new _3_Tirer();
          _3T.CS.Text = cs.SelectedValue.ToString();
          _3T.Show();
      }

       
    }
}
