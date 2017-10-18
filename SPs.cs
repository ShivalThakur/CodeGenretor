﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SearchFile
{
    public partial class SPs : Form
    {
        public SPs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Validations
		 
	        #endregion


            #region Insert_StateMent
            string ParaMeters_of_Sp = "";
            string insertQuery = "insert into "+table_name.Text+"(" ;
            /////form 1 obj
            Form1 f1 = new Form1();
            SqlConnection con = new SqlConnection(Connection_Strings.Text);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(@"select column_name,
 data_type + case when CHARACTER_MAXIMUM_LENGTH Is not null then '('+Convert(varchar,CHARACTER_MAXIMUM_LENGTH)+')' else '' end 
 data_type
 from information_schema.columns
 where table_name = @tablename
and COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') <> 1;
-----------------------SELECT IDENTITY FOR UPDATE
select column_name,data_type + case when CHARACTER_MAXIMUM_LENGTH Is not null then '('+Convert(varchar,CHARACTER_MAXIMUM_LENGTH)+')' else '' end 
data_type  
from information_schema.columns
where table_name = @tablename
 
", con);
            adapter.SelectCommand.Parameters.Add("@tablename", SqlDbType.VarChar).Value = table_name.Text;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();
            string Update__Id_Col = ds.Tables[1].Rows[0][0].ToString();

            //
            ////Insert Statment 
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    insertQuery += "[" + ds.Tables[0].Rows[i]["column_name"] + "]" + Environment.NewLine;
                }
                else
                {
                    insertQuery += "," + "[" + ds.Tables[0].Rows[i]["column_name"] + "]" + Environment.NewLine;
                }

            }
            insertQuery += ")";
            insertQuery += Environment.NewLine + " values (";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    insertQuery += "@" + ds.Tables[0].Rows[i]["column_name"].ToString().Replace(" ", "_") + Environment.NewLine;
                }
                else
                {
                    insertQuery += "," + "@" + ds.Tables[0].Rows[i]["column_name"].ToString().Replace(" ", "_") + Environment.NewLine;
                }

            }

            insertQuery += ")";

            ///SP ParaMeters
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    ParaMeters_of_Sp += Environment.NewLine+ "@" + ds.Tables[0].Rows[i]["column_name"].ToString().Replace(" ", "_") + " " + ds.Tables[0].Rows[i]["data_type"].ToString()+ " = NULL" ;
                }
                else
                {
                    ParaMeters_of_Sp += Environment.NewLine + "," + "@" + ds.Tables[0].Rows[i]["column_name"].ToString().Replace(" ", "_") + " " + ds.Tables[0].Rows[i]["data_type"].ToString() + " = NULL";
                }

            }
            /////////Additional Parameter Which will be used which action should be taken  insert,update or Select
            ParaMeters_of_Sp += Environment.NewLine + ", @I_U_S char(1),@" + ds.Tables[1].Rows[0]["column_name"].ToString().Replace(" ", "_") + " " + ds.Tables[1].Rows[0]["data_type"].ToString() + " = NULL" + " ";

            


            ///
            ///
//            richTextBox1.Text = insertQuery;
            #endregion
            #region Update Statement
            string updateQuery = " update  "+table_name.Text+" set " ;
            ////uPDATE Statment 
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    updateQuery += @"[" + ds.Tables[0].Rows[i]["column_name"] + "]=ISNULL(@" + ds.Tables[0].Rows[i]["column_name"].ToString().Replace(" ", "_") + ",[" + ds.Tables[0].Rows[i]["column_name"].ToString() + "])" + Environment.NewLine;
                }
                else
                {
                    updateQuery += "," + @"[" + ds.Tables[0].Rows[i]["column_name"] + "]=ISNULL(@" + ds.Tables[0].Rows[i]["column_name"].ToString().Replace(" ", "_") + ",[" + ds.Tables[0].Rows[i]["column_name"].ToString() + "])"+ Environment.NewLine;
                }

            }

            updateQuery += Environment.NewLine + @"where " +"["+ Update__Id_Col +"]" + " =@" + ds.Tables[1].Rows[0]["column_name"].ToString().Replace(" ", "_");
            #endregion



            result.Text += @"SET ANSI_NULLS ON
                        GO
                        SET QUOTED_IDENTIFIER ON
                        GO";
            result.Text += Environment.NewLine + @" CREATE PROCEDURE " + sp_name.Text.ToUpper() + " " + ParaMeters_of_Sp.ToUpper() + "  " + Environment.NewLine +

                            @"AS " + Environment.NewLine + ""
                            +
                            @"BEGIN
	                             
	                         SET NOCOUNT ON;
                               
                            " + Environment.NewLine+ " IF @I_U_S='I'" + Environment.NewLine +""+ insertQuery.ToUpper() + "" +
                               
                       Environment.NewLine+     
                           " IF  @I_U_S='U'" + Environment.NewLine +""+  updateQuery.ToUpper() + ""+Environment.NewLine +
                            @" END
                             ";
            string create_File_Path=FolderPath.Text+@"\"+sp_name.Text + ".txt";

            File.WriteAllText(create_File_Path,result.Text);
            FileStream fs = new FileStream(create_File_Path, FileMode.Open);
            



            
                
            //result.Text = CS.SelectedValue.ToString();

           //result.Text= con.ConnectionString;-
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            result.Text = f1.cs.SelectedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                FolderPath.Text = folderBrowserDialog1.SelectedPath;
            else
                FolderPath.Text="";
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void SPs_Load(object sender, EventArgs e)
        {
            #region BindableAttribute SPs names
            SqlConnection con = new SqlConnection(Connection_Strings.Text);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(@"select Upper(name) as Sps from sys.objects
where type='P' order by 1", con);
             
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();
            AllSps.DisplayMember = "Sps";
            AllSps.ValueMember = "Sps";            
            AllSps.DataSource = ds.Tables[0];
            
	        #endregion
       

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connection_Strings.Text);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "";
            SqlDataAdapter adapter = new SqlDataAdapter(@"select PARAMETER_NAME,DATA_TYPE  from INFORMATION_SCHEMA.PARAMETERS

where SPECIFIC_NAME=@procedure", con);
            adapter.SelectCommand.Parameters.Add("@procedure", SqlDbType.VarChar).Value = AllSps.SelectedValue.ToString();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            string updateQuery = "SqlCommand " +SqlCommand_obj.Text +" = new SqlCommand();";
            updateQuery += Environment.NewLine +  SqlCommand_obj.Text+".CommandType =  CommandType.StoredProcedure ;";
            updateQuery += Environment.NewLine + SqlCommand_obj.Text + ".CommandText = \"" + AllSps.SelectedValue.ToString() + "\";";
            ///////////parameters
            Form1 f = new Form1();

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
            updateQuery +=Environment.NewLine+ SqlCommand_obj.Text  +".Parameters.Add(\""+dr["Parameter_name"]+"\",SqlDbType."+f.SqlDataType(dr["Data_Type"].ToString())+").Value=";
            }
            if (ins.Checked)
            {
                updateQuery += "";
            }
            else
            {
            }
            updateQuery +=Environment.NewLine+ SqlCommand_obj.Text+ ".ExecuteNonQuery();";
            richTextBox1.Text = updateQuery;
        }
    }
}