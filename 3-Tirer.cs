using System;
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
    public partial class _3_Tirer : Form
    {
        public _3_Tirer()
        {
            InitializeComponent();
        }

        private void CS_TextChanged(object sender, EventArgs e)
        {
            string conString = CS.Text;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(@"select '' table_name
union
select TABLE_NAME from INFORMATION_SCHEMA.tables order by table_name ", con);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            Tables.DisplayMember = "Table_Name";
            Tables.ValueMember = "Table_Name";
            Tables.DataSource = ds.Tables[0];            
            con.Close();

            
        }

        private void Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string Command_Parameters = "";
            string table_obj=Tables.SelectedValue+"_Obj";
            string File_Contents = "using System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Web;\nusing System.Web.UI;\nusing System.Data;\nusing System.Data.SqlClient;";

            File_Contents +=  Environment.NewLine+ @"public class "+Tables.SelectedValue;


            ////////////////////get coloumnsname and data type
            SqlDataAdapter adapter = new SqlDataAdapter(@"select column_name,data_type, character_maximum_length as _Length from information_schema.columns
 where table_name = @tablename
and COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') <> 1", CS.Text);
            adapter.SelectCommand.Parameters.Add("@tablename", SqlDbType.VarChar).Value = Tables.SelectedValue;
            DataSet ds = new DataSet();
            
            adapter.Fill(ds);
            dataGridView_1707.DataSource = ds.Tables[0];
            File_Contents += "{";
            /////////////////////variables
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                File_Contents += Environment.NewLine + " private static " + SqlDataType(item["data_type"].ToString()) +" _"+item["column_name"] + ";";
                Command_Parameters += "\ncmd.Parameters.AddWithValue(\"@"+item["column_name"]+""+"\","+table_obj+"."+item["column_name"]+");";
                
            }
           
            /////////////////////
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                File_Contents += Environment.NewLine + " public static " + SqlDataType(item["data_type"].ToString()) + " " + item["column_name"] + "\n{\nget\n{\nreturn _" + item["column_name"] + ";\n}\nset\n{\n_" + item["column_name"] + "=value;\n}\n}";
                
            }
            File_Contents += "\n}";
            ////////////////////DAL
            File_Contents += "\n\n";
            File_Contents += "public class Insert_Into_" + Tables.SelectedValue ;
            File_Contents += "\n{";
            
            File_Contents += @""+ Environment.NewLine+"public string _Insert(" + Tables.SelectedValue + " "+ table_obj+")"+
            "{"+ Environment.NewLine +
                @"SqlConnection con = new SqlConnection(ConnectionString);
                try
                {
                 con.Open();
                 SqlCommand cmd = new SqlCommand(""SP_CRUD_"", con);
                 cmd.CommandType = CommandType.StoredProcedure;"+Command_Parameters+
                 "\ncmd.ExecuteNonQuery();\ncon.Close();\n}\ncatch(Exception ex)\n{throw ex;}\n}";
            File_Contents += "\n}";


            richTextBox1.Text = File_Contents;
           
            #region Designer+Cs Code 
            ds.Dispose();
            ds=new DataSet();
            adapter = new SqlDataAdapter(@" select name,is_identity from sys.columns where object_id=OBJECT_ID(@tablename)", CS.Text);
            adapter.SelectCommand.Parameters.Add("@tablename", SqlDbType.VarChar).Value = Tables.SelectedValue;
            adapter.Fill(ds);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                string Design = "";
                Design = "<table>";
                Design += "";
            }
           
            #endregion

        }

        private void _3_Tirer_Load(object sender, EventArgs e)
        {
            FolderPath.Text= folderBrowserDialog1.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                FolderPath.Text = folderBrowserDialog1.SelectedPath;
            else
                FolderPath.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream Fs = new FileStream(FolderPath.Text+@"\"+Tables.SelectedValue+".cs", FileMode.Create);
            Fs.Write(Encoding.ASCII.GetBytes(richTextBox1.Text),0,richTextBox1.Text.Length);
            Fs.Close();
            Fs.Dispose();
        }
        public string SqlDataType(string comingDataType)
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
                case "nvarchar":
                case "char":
                    {
                        returndatatype = "string";
                        break;
                    }
                case "int":
                    {
                        returndatatype = "int";
                        break;
                    }
                case "smallint":
                    {
                        returndatatype = "short";
                        break;
                    }
               
            }
            return returndatatype;
        }

        private void dataGridView_1707_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            foreach (DataGridViewRow Row in this.dataGridView_1707.Rows)
            {

                Row.Cells[Check.Name].Value = true;
                Row.Cells[TextBoxDropDown.Name].Value = "TextBox";
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _Design = "<table>";
            string _Cs = Environment.NewLine + "void Crud() {";
            string _BindEditData = Environment.NewLine +Environment.NewLine + "void BindData(){";
            string _InsertUpdateData = Environment.NewLine + Environment.NewLine + "void InsertUpdateData(){";

            string _GridCols = "";
            foreach (DataGridViewRow Row in this.dataGridView_1707.Rows)
            {
                //Last Row Fix
                if (Row.Cells[2].Value == null)
                {
                    continue;
                }
                //
                if ((bool)Row.Cells[Check.Name].Value)
                {
                    _Design += Environment.NewLine+ "<tr>";
                    _Design +=  "\n<td>" + Row.Cells[2].Value + "</td>";
                    if (Row.Cells[TextBoxDropDown.Name].Value.ToString() == "TextBox")
                    {
                        _Design += "\n<td><asp:TextBox runat=\"server\" " + (Row.Cells[4].Value != System.DBNull.Value  ? " MaxLength=\"" + Row.Cells[4].Value + "\"" : "") + "  ID=\"txt" + Row.Cells[2].Value + "\"></asp:TextBox></td>";
                        _Cs += Environment.NewLine + "command.Parameters.AddWithValue(\"@" + Row.Cells[2].Value + "\",txt" + Row.Cells[2].Value + ".Text);";
                        _BindEditData += Environment.NewLine + "txt" + Row.Cells[2].Value + ".Text = ds.Tables[0].Rows[0][\"" + Row.Cells[2].Value + "\"];";
                    }
                    else
                    {
                        _Design += "<td><asp:DropDownList runat=\"server\" ID=\"ddl" + Row.Cells[2].Value + "\"></asp:DropDownList></td>";
                        _Cs +=Environment.NewLine+  "command.Parameters.AddWithValue(\"@" + Row.Cells[2].Value + "\",ddl" + Row.Cells[2].Value + ".SelectedValue);";
                        _BindEditData += Environment.NewLine + "ddl" + Row.Cells[2].Value + ".SelectedValue = ds.Tables[0].Rows[0][\"" + Row.Cells[2].Value + "\"];";
                        
                    }
                    _GridCols += "\n<asp:BoundField HeaderText=\"" + Row.Cells[2].Value + "\"" + " DataField=\"" + Row.Cells[2].Value + "\"" + " />";
                    _Design += "</tr>";
                }
            }
            _Design += "<tr><td><asp:Button runat=\"server\" Text=\"Submit\" ID=\"btnSave\" /></td></tr></table>";
            //Adding GridView to show data
            _Design += @"\n<asp:GridView runat=""server"" ID=""grdResult"">
                         <Columns> " + _GridCols + "\n</Columns>\n</asp:GridView>";
            //
            Design_.Text= _Design;
            _BindEditData += "}";
            _Cs += Environment.NewLine+ "}";
            CS_.Text = _Cs+ _BindEditData;
        }

    
      
       
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }

}
