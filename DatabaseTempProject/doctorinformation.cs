using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DatabaseTeamProject
{
    public partial class doctorinformation : Form
    {
        public manage docs_mng;

        dba a = new dba();

        public doctorinformation(manage _docs_mng)
        {
            InitializeComponent();

            this.docs_mng = _docs_mng;
        }

        private void doctorinformation_Load(object sender, EventArgs e)
        {
            try
            {
                string doctors_select = "select a.id, a.rrn, a.name, a.gender, a.homeaddress, a.cpn, a.htn, b.name 'dname' from doctor a " +
                    "inner join dept b " +
                    "on a.deptcode = b.code";

                MySqlDataAdapter doc_all = new MySqlDataAdapter(doctors_select, a.Connection());

                DataSet ds = new DataSet();

                doc_all.Fill(ds);

                List<DataGridViewTextBoxColumn> makeColumn = new List<DataGridViewTextBoxColumn>();

                for (int i = 0; i < 8; i++)
                    makeColumn.Add(new DataGridViewTextBoxColumn());

                string[] cols = { "id", "rrn", "name", "gender", "homeaddress", "cpn", "htn", "dname" };
                string[] kocols = { "의사 아이디", "주민등록번호", "의사 이름", "성별", "집 주소", "핸드폰 번호", "집 번호", "진료과" };

                for (int i = 0; i < 8; i++)
                {
                    makeColumn[i].DataPropertyName = cols[i].ToString().Trim();
                    makeColumn[i].HeaderText = kocols[i].ToString().Trim();
                    doctors.Columns.Add(makeColumn[i]);
                }

                doctors.AllowUserToAddRows = false;
                doctors.AllowUserToDeleteRows = false;
                doctors.ReadOnly = true;

                doctors.DataSource = ds.Tables[0];

                doctors.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void doctors_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if(e.ColumnIndex == 1)
            //{
            //    if (e.Value != null)
            //    {
            //        e.Value = 

            //    }
            //    else e.Value = "Null";
            //}
        }
    }
}
