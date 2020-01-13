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
    public partial class possibleDoctorSelect : Form
    {
        public patientReservation pR_possibleDoctor;

        public string getTime = "";

        dba a = new dba();


        public possibleDoctorSelect(patientReservation _pR_possibleDoctor)
        {
            InitializeComponent();

            this.pR_possibleDoctor = _pR_possibleDoctor;
        }

        // 등록하기 버튼 클릭
        private void Entersure_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr2 = dataGridView2.SelectedRows[0];

            string pID = dr2.Cells[0].Value.ToString().Trim();
            string pNAME = dr2.Cells[1].Value.ToString().Trim();

            if (MessageBox.Show("아래의 정보가 맞습니까?" + "\n" + "\n" + "의사 아이디 : " + pID + "\n" + "이름 : " + pNAME, "예 / 아니오 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pR_possibleDoctor.doctorNameReservation.Text = pNAME;
                pR_possibleDoctor.doctorIdReservation.Text = pID;

                string drop_view = "drop view if exists doctorDept";

                MySqlCommand drop_view_cmd = new MySqlCommand(drop_view, a.Connection());

                drop_view_cmd.ExecuteNonQuery();

                this.Close();
            }   
        }

        // 열릴 때
        private void possibleDoctorSelect_Load(object sender, EventArgs e)
        {
            try
            { 
                string drop_view_if_exists = "drop view if exists doctorDept";

                MySqlCommand drop_view_if_exists_cmd = new MySqlCommand(drop_view_if_exists, a.Connection());

                drop_view_if_exists_cmd.ExecuteNonQuery();

                string create_view = "create view doctorDept as select a.id 'id', a.name 'name', b.name 'dept' from doctor a inner join dept b on a.deptcode = b.code";

                MySqlCommand create_view_cmd = new MySqlCommand(create_view, a.Connection());

                create_view_cmd.ExecuteNonQuery();

                string innerjoinsub = "select * from doctorDept where id not in (select doctorid from reservation where starttime = '" + getTime + "')";

                MySqlDataAdapter mysqldataadapter = new MySqlDataAdapter(innerjoinsub, a.Connection());

                DataSet ds = new DataSet();

                mysqldataadapter.Fill(ds);

                DataGridViewTextBoxColumn makeColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn3 = new DataGridViewTextBoxColumn();

                makeColumn.DataPropertyName = "id";
                makeColumn.HeaderText = "의사 아이디";
                dataGridView2.Columns.Add(makeColumn);

                makeColumn2.DataPropertyName = "name";
                makeColumn2.HeaderText = "이름";
                dataGridView2.Columns.Add(makeColumn2);

                makeColumn3.DataPropertyName = "dept";
                makeColumn3.HeaderText = "진료과";
                dataGridView2.Columns.Add(makeColumn3);

                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.AllowUserToDeleteRows = false;
                dataGridView2.ReadOnly = true;

                dataGridView2.DataSource = ds.Tables[0];

                dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void possibleDoctorSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            string drop_view = "drop view if exists doctorDept";

            MySqlCommand drop_view_cmd = new MySqlCommand(drop_view, a.Connection());

            drop_view_cmd.ExecuteNonQuery();
        }
    }
}
