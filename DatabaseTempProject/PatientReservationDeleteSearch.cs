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
    public partial class PatientReservationDeleteSearch : Form
    {
        public patientReservationDelete pRD;

        dba a = new dba();

        public PatientReservationDeleteSearch(patientReservationDelete _pRD)
        {
            InitializeComponent();

            this.pRD = _pRD;
        }

        // 열릴 때
        private void PatientReservationDeleteSearch_Load(object sender, EventArgs e)
        {
            try
            {
                patresnow.DataSource = null;
                patresnow.Rows.Clear();

                string patres = "select a.id, a.rrn, a.name, b.starttime from patient a " +
                    "inner join reservation b on a.id = b.patientid " +
                    "where b.patientid = '" + pRD.patIdResDelete.Text.ToString() + "'";

                MySqlDataAdapter pats = new MySqlDataAdapter(patres, a.Connection());

                DataSet ds = new DataSet();

                pats.Fill(ds);

                DataGridViewTextBoxColumn makeColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn3 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn4 = new DataGridViewTextBoxColumn();

                makeColumn.DataPropertyName = "id";
                makeColumn.HeaderText = "환자 아이디";
                patresnow.Columns.Add(makeColumn);

                makeColumn2.DataPropertyName = "rrn";
                makeColumn2.HeaderText = "환자 주민등록번호";
                patresnow.Columns.Add(makeColumn2);

                makeColumn3.DataPropertyName = "name";
                makeColumn3.HeaderText = "환자 이름";
                patresnow.Columns.Add(makeColumn3);

                makeColumn4.DataPropertyName = "starttime";
                makeColumn4.HeaderText = "예약 시간";
                patresnow.Columns.Add(makeColumn4);

                patresnow.AllowUserToAddRows = false;
                patresnow.AllowUserToDeleteRows = false;
                patresnow.ReadOnly = true;

                patresnow.DataSource = ds.Tables[0];

                patresnow.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        // 해당 행 더블 클릭
        private void patresnow_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DateTime myDate = DateTime.Parse(patresnow.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());

            string g = myDate.ToString("yyyy-MM-dd HH:mm:ss");

            if (MessageBox.Show("선택하신 예약 내역을 삭제하시겠습니까?" + '\n' + g, "예 / 아니오 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string patientDelete_sql_delete = "delete from reservation where patientid = '" + patresnow.Rows[e.RowIndex].Cells[0].Value.ToString().Trim()
                        + "' and starttime = '" + g + "'";

                    MySqlCommand patientDelete_cmd = new MySqlCommand(patientDelete_sql_delete, a.Connection());

                    patientDelete_cmd.ExecuteNonQuery();

                    patresnow.Rows.RemoveAt(patresnow.CurrentRow.Index);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }
    }
}
