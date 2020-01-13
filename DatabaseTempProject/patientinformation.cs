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
    public partial class patientinformation : Form
    {
        public manage pi_mng;

        dba a = new dba();


        public patientinformation(manage _pi_mng)
        {
            InitializeComponent();

            this.pi_mng = _pi_mng;
        }

        private void patientinformation_Load(object sender, EventArgs e)
        {
            try
            {
                string patients_select = "select * from patient";

                MySqlDataAdapter patients_all = new MySqlDataAdapter(patients_select, a.Connection());

                DataSet ds = new DataSet();

                patients_all.Fill(ds);

                List<DataGridViewTextBoxColumn> makeColumn = new List<DataGridViewTextBoxColumn>();

                for (int i = 0; i < 8; i++)
                    makeColumn.Add(new DataGridViewTextBoxColumn());

                string[] cols = { "id", "rrn", "name", "gender", "blood", "homeaddress", "cpn", "htn"};
                string[] kocols = { "환자 아이디", "주민등록번호", "환자 이름", "성별", "혈액형", "집 주소", "핸드폰 번호", "집 번호" };

                for (int i = 0; i < 8; i++)
                {
                    makeColumn[i].DataPropertyName = cols[i].ToString().Trim();
                    makeColumn[i].HeaderText = kocols[i].ToString().Trim();
                    patients.Columns.Add(makeColumn[i]);
                }

                patients.AllowUserToAddRows = false;
                patients.AllowUserToDeleteRows = false;
                patients.ReadOnly = true;

                patients.DataSource = ds.Tables[0];

                patients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
