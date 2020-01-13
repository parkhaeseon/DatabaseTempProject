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
    public partial class login : Form
    {
        public employeeEnter eE;
        public manage mng;
        public FindIDPW fip;
        public string LoginID = "";

        dba a;

        public login()
        {
            InitializeComponent();
        }

        // 최초 실행
        private void Login_Load(object sender, EventArgs e)
        {
            a = new dba();

            startImage1.Load("hospital.png");
            startImage1.SizeMode = PictureBoxSizeMode.StretchImage;

            startImage2.Load("cal.png");
            startImage2.SizeMode = PictureBoxSizeMode.StretchImage;

            loginpw.PasswordChar = '*';
        }

        // 직원 등록 버튼 클릭
        private void EnterEmployee_Click(object sender, EventArgs e)
        {
            eE = new employeeEnter(this);

            eE.Owner = this;

            eE.ShowDialog();
        }


        // 로그인 버튼 클릭
        private void gomanage_Click(object sender, EventArgs e)
        {
            // 만약 로그인의 아이디 칸이 비어있다면
            if(loginid.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디를 입력하지 않았습니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = loginid; // 해당 아이디 칸으로 마우스 커서 이동(활성화)
                return;
            }

            // 만약 로그인의 비밀버호 칸이 비어있다면
            if (loginpw.Text.ToString().Trim() == "")
            {
                MessageBox.Show("비밀번호를 입력하지 않았습니다.", "비밀번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = loginpw; // 해당 비밀번호 칸으로 마우스 커서 이동(활성화)
                return;
            }

            // 행정직원(employee) 테이블에서 사용자가 입력한 아이디(id), 비밀번호(pw) 둘 다 일치하는 행이 있는지 select 한다.
            string SelectIDPW = "select id, pw, name from employee where id = '" + loginid.Text.ToString().Trim() + "' and pw = '" + loginpw.Text.ToString().Trim() + "'";

            // SQL문을 실행하기 위한 MySqlCommand
            MySqlCommand cmd = new MySqlCommand(SelectIDPW, a.Connection());

            // MySqlCommand 실행
            MySqlDataReader SelectIDreader = cmd.ExecuteReader();

            // 만족하는 행이 있다면
            if (SelectIDreader.HasRows)
            {
                // 메인화면(자식)에게 넘겨준다.
                mng = new manage(this);

                 
                while(SelectIDreader.Read())
                {
                    mng.empName.Text = SelectIDreader["name"].ToString().Trim() + " 님";
                }
                
                LoginID = loginid.Text.ToString().Trim();

                mng.Text = "종합 예약 시스템   안녕하세요! " + LoginID + "님"; ;

                mng.Owner = this;
      
                
                using (Loading ld = new Loading(WaitData))
                {
                    ld.ShowDialog(this);
                }

                this.Hide();

                mng.Show();

                // 메인 화면에서 로그아웃하여, 다시 로그인 창으로 돌아올 경우를 대비해 아이디, 비밀번호 칸을 비운다.
                loginid.Clear();
                loginpw.Clear();
            }
            else
            {
                // 만족하는 행이 없다면(=입력한 아이디와 비밀번호 중 잘못된 곳이 있다면)
                MessageBox.Show("등록되지 않은 아이디이거나 잘못된 비밀번호 입니다.", "아이디와 비밀번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SelectIDreader.Close();  
        }

        private void WaitData()
        {
            for (int i = 0; i <= 400; i++)
                Thread.Sleep(10);
        }

        private void gomanage_MouseMove(object sender, MouseEventArgs e)
        {
            gomanage.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void gomanage_MouseLeave(object sender, EventArgs e)
        {
            gomanage.BackColor = System.Drawing.Color.LightBlue;
        }

        private void EnterEmployee_MouseMove(object sender, MouseEventArgs e)
        {
            EnterEmployee.BackColor = System.Drawing.Color.HotPink;
        }

        private void EnterEmployee_MouseLeave(object sender, EventArgs e)
        {
            EnterEmployee.BackColor = System.Drawing.Color.LightPink;
        }

        private void findidpw_MouseMove(object sender, MouseEventArgs e)
        {
            findidpw.BackColor = System.Drawing.Color.Gray;
        }

        private void findidpw_MouseLeave(object sender, EventArgs e)
        {
            findidpw.BackColor = System.Drawing.Color.LightGray;
        }

        private void findidpw_Click(object sender, EventArgs e)
        {
            fip = new FindIDPW(this);
            fip.Owner = this;

            fip.ShowDialog();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            a.Close();
        }
    }
}
