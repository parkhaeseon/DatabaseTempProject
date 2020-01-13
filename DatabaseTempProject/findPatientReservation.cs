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
    public partial class findPatientReservation : Form
    {
        public patientReservation pR_findPatient;

        dba a = new dba();


        public findPatientReservation(patientReservation _pR_findPatient)
        {
            InitializeComponent();

            this.pR_findPatient = _pR_findPatient;
        }

        // 열릴 때
        private void findPatientReservation_Load(object sender, EventArgs e)
        {
            try
            {
                string select_patient_sql = "select id, rrn, name, gender, blood from patient where name = '" + pR_findPatient.patientNameReservation.Text.ToString().Trim() + "'";

                MySqlDataAdapter mysqldataadapter = new MySqlDataAdapter(select_patient_sql, a.Connection());

                DataSet ds = new DataSet();

                mysqldataadapter.Fill(ds);

                List<DataGridViewTextBoxColumn> makeColumn = new List<DataGridViewTextBoxColumn>();

                for (int i = 0; i < 5; i++)
                    makeColumn.Add(new DataGridViewTextBoxColumn());

                string[] cols = { "id", "rrn", "name", "gender", "blood" };
                string[] kocols = { "환자 아이디", "환자 주민등록번호", "환자 이름", "성별", "혈액형" };

                for (int i = 0; i < 5; i++)
                {
                    makeColumn[i].DataPropertyName = cols[i].ToString().Trim();
                    makeColumn[i].HeaderText = kocols[i].ToString().Trim();
                    dataGridView1.Columns.Add(makeColumn[i]);
                }

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;

                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void Entersure_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];

            string pID = dr.Cells[0].Value.ToString().Trim();
            string pNAME = dr.Cells[2].Value.ToString().Trim();
   
            if(MessageBox.Show("아래의 정보가 맞습니까?" + "\n" + "\n" + "아이디 : " + pID + "\n" + "이름 : " + pNAME, "예 / 아니오 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pR_findPatient.patientNameReservation.Text = pNAME;
                pR_findPatient.patientIdReservation.Text = pID;
                this.Close();
            }
        }
    }
}
