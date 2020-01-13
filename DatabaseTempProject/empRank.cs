using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;

namespace DatabaseTeamProject
{
    public partial class empRank : Form
    {
        public manage empRank_mng;

        dba a = new dba();


        public empRank(manage _empRank_mng)
        {
            InitializeComponent();

            this.empRank_mng = _empRank_mng;
        }

        // 열릴 때
        private void empRank_Load(object sender, EventArgs e)
        {
            try
            {
                string drop_view_if_exists = "drop view if exists employeeRank";
                MySqlCommand drop_view_if_exists_cmd = new MySqlCommand(drop_view_if_exists, a.Connection());
                drop_view_if_exists_cmd.ExecuteNonQuery();


                string create_view = "create view employeeRank as " +
                    "select b.id, b.name, count(*) 'empResCount' from reservation a " +
                    "inner join employee b on a.empid = b.id " +
                    "group by a.empid " +
                    "order by empResCount desc";
                MySqlCommand create_view_cmd = new MySqlCommand(create_view, a.Connection());
                create_view_cmd.ExecuteNonQuery();


                string innerjoinsub = "select a.id, a.name, ifnull((select empResCount from employeeRank where Name = a.name), 0) 'totalCount' from employee a order by totalCount desc";

                MySqlDataAdapter mysqldataadapter = new MySqlDataAdapter(innerjoinsub, a.Connection());

                DataSet ds = new DataSet();

                mysqldataadapter.Fill(ds);

                DataGridViewTextBoxColumn makeColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn makeColumn3 = new DataGridViewTextBoxColumn();

                makeColumn.DataPropertyName = "id";
                makeColumn.HeaderText = "직원 아이디";
                empRankGridView.Columns.Add(makeColumn);

                makeColumn2.DataPropertyName = "name";
                makeColumn2.HeaderText = "직원 이름";
                empRankGridView.Columns.Add(makeColumn2);

                makeColumn3.DataPropertyName = "totalCount";
                makeColumn3.HeaderText = "지금까지 예약한 수";
                empRankGridView.Columns.Add(makeColumn3);

                empRankGridView.AllowUserToAddRows = false;
                empRankGridView.AllowUserToDeleteRows = false;
                empRankGridView.ReadOnly = true;

                empRankGridView.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        // 닫힐 때
        private void empRank_FormClosed(object sender, FormClosedEventArgs e)
        {
            string drop_view_if_exists = "drop view if exists employeeRank";
            MySqlCommand drop_view_if_exists_cmd = new MySqlCommand(drop_view_if_exists, a.Connection());
            drop_view_if_exists_cmd.ExecuteNonQuery();
        }

        private void empRankGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string NumberingText = (e.RowIndex + 1).ToString();

                // 글자 사이즈 구하기.
                SizeF stringSize = e.Graphics.MeasureString(NumberingText, Font);

                // 글자에 맞춰 좌표계산. 
                PointF StringPoint = new PointF
                (
                    Convert.ToSingle(empRankGridView.RowHeadersWidth - 3 - stringSize.Width),
                    Convert.ToSingle(e.RowBounds.Y) + empRankGridView[0, e.RowIndex].ContentBounds.Height * 0.3f
                );

                // 문자열 그리기.
                e.Graphics.DrawString
                (
                    NumberingText,
                    Font,
                    Brushes.Black,
                    StringPoint.X,
                    StringPoint.Y
                );
            }
        }
    }
}
