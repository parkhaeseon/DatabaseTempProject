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
    public partial class mypatients : Form
    {
        public manage mypmng;

        dba a = new dba();

        public mypatients(manage _mypmng)
        {
            InitializeComponent();

            this.mypmng = _mypmng;
        }

        // 열릴 때
        private void mypatients_Load(object sender, EventArgs e)
        {
            try
            {
                mypat.DataSource = null;
                mypat.Rows.Clear();

                string namePatSearch = "select a.id 'id', a.rrn 'rrn', a.name 'name', b.starttime 'time', d.name 'dept', e.id 'empId', e.name 'empName' from patient a " +
                    "inner join reservation b on a.id = b.patientid " +
                    "inner join doctor c on b.doctorid = c.id " +
                    "inner join dept d on c.deptcode = d.code " +
                    "inner join employee e on e.id = b.empid " +
                    "where b.empid = '" + mypmng.login_main.LoginID + "' " +
                    "order by b.starttime";

                MySqlDataAdapter np = new MySqlDataAdapter(namePatSearch, a.Connection());

                DataSet ds = new DataSet();

                np.Fill(ds);

                List<DataGridViewTextBoxColumn> makeColumn = new List<DataGridViewTextBoxColumn>();

                for (int i = 0; i < 7; i++)
                    makeColumn.Add(new DataGridViewTextBoxColumn());

                string[] cols = { "id", "rrn", "name", "time", "dept", "empId", "empName" };
                string[] kocols = { "환자 아이디", "환자 주민등록번호", "환자 이름", "예약 시간", "진료과", "예약한 행정직원 ID", "예약한 행정직원 이름" };

                for (int i = 0; i < 7; i++)
                {
                    makeColumn[i].DataPropertyName = cols[i].ToString().Trim();
                    makeColumn[i].HeaderText = kocols[i].ToString().Trim();
                    mypat.Columns.Add(makeColumn[i]);
                }

                mypat.AllowUserToAddRows = false;
                mypat.AllowUserToDeleteRows = false;
                mypat.ReadOnly = true;

                mypat.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }
    }
}
