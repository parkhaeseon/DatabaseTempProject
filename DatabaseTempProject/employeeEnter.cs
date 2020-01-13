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
    public partial class employeeEnter : Form
    {
        public login login_main;
        public addSearchEnter adds;

        private string employee_mg;
        private string employee_homenumber = "";

        dba a = new dba();

        public employeeEnter(login _main)
        {
            InitializeComponent();

            this.login_main = _main;

            // 성별 세팅
            string[] s = { "남", "여" };
            mg.Items.AddRange(s);
            mg.SelectedIndex = 0;

            // 지역번호 세팅
            string[] p = {"02", "051", "053", "032", "062", "042", "052", "044", "031", "033",
            "043", "041", "063", "061", "054", "055", "064"};
            home1.Items.AddRange(p);
            home1.SelectedIndex = 0;
        }

        private void mg_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee_mg = mg.SelectedItem.ToString();         
        }

        private void home1_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee_homenumber = home1.SelectedItem.ToString();
        }

        // 중복확인 버튼 클릭
        private void dup_Click(object sender, EventArgs e)
        {
            if (id.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디 칸이 비어있습니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = id;
                return;
            }

            if (!Regex.IsMatch(id.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(id.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                id.Clear();
                this.ActiveControl = id;
                return;
            }

            if (id.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = id;
                return;
            }

            try
            {
                // 의사 아이디랑 중복인지 검사
                string docidselect = "select * from doctor where id = '" + id.Text.ToString().Trim() + "'";

                MySqlCommand docidselect_cmd = new MySqlCommand(docidselect, a.Connection());

                MySqlDataReader docidselect_cmd_dr = docidselect_cmd.ExecuteReader();

                if (docidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 의사의 아이디입니다." + '\n' + "같을 수 없습니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    id.Clear();
                    docidselect_cmd_dr.Close();
                    this.ActiveControl = id;
                    return;
                }
                docidselect_cmd_dr.Close();


                // 환자 아이디랑 중복되는지 검사
                string patidselect = "select * from patient where id = '" + id.Text.ToString().Trim() + "'";

                MySqlCommand patidselect_cmd = new MySqlCommand(patidselect, a.Connection());

                MySqlDataReader patidselect_cmd_dr = patidselect_cmd.ExecuteReader();

                if (patidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 환자의 아이디입니다." + '\n' + "같을 수 없습니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    id.Clear();
                    patidselect_cmd_dr.Close();
                    this.ActiveControl = id;
                    return;
                }
                patidselect_cmd_dr.Close();



                // 행정직원 아이디랑 같은지 검사
                string dup_sql = "select id from employee where id = '" + id.Text.ToString().Trim() + "'";

                MySqlCommand cmd = new MySqlCommand(dup_sql, a.Connection());

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("이미 가입된 행정직원의 아이디입니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    id.Clear();
                }
                else
                {
                    MessageBox.Show("사용 가능합니다.", "사용 가능한 아이디", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id.ReadOnly = true;
                }

                reader.Close();
            }
            catch(Exception z)
            {
                MessageBox.Show(z.ToString());
            }       
        }

        // 지우기 버튼 클릭
        private void alldelete_Click(object sender, EventArgs e)
        {
            id.Clear();
            epw.Clear();
            name.Clear();
            residentnumber.Clear();
            retry_pw.Clear();
            Address.Clear();
            Address2.Clear();
            home2.Clear();
            Address.ReadOnly = false;

            id.ReadOnly = false;
        }

        // 등록하기 버튼
        private void Entersure_Click(object sender, EventArgs e)
        {
            if (id.Text.ToString().Trim() == "" || epw.Text.ToString().Trim() == "" || name.Text.ToString().Trim() == "" ||
               residentnumber.Text.ToString().Trim() == "" || Address.Text.ToString().Trim() == "" ||
               home2.Text.ToString().Trim() == "" || phone.Text.ToString().Trim() == "" || Address2.Text.ToString().Trim() == "")
            {
                MessageBox.Show("빈 칸이 있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (!id.ReadOnly)
            {
                MessageBox.Show("아이디 중복 확인을 하지 않았습니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = dup;
                return;
            }

            if (epw.Text.ToString().Trim().Length > 16)
            {
                MessageBox.Show("비밀번호가 너무 깁니다. 줄여주세요.", "비밀번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                epw.Clear();
                retry_pw.Clear();

                this.ActiveControl = epw;
                return;
            }

            if (!Regex.IsMatch(residentnumber.Text.ToString().Trim(), @"^\d{13}$"))
            {
                MessageBox.Show("주민등록번호 형식이 올바르지 않습니다.", "주민등록번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                residentnumber.Clear();
                this.ActiveControl = residentnumber;
                return;
            }

            if (!Regex.IsMatch(name.Text.ToString().Trim(), @"[가-힣]{2,5}"))
            {
                MessageBox.Show("이름에 오류가 있습니다.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                name.Clear();
                this.ActiveControl = name;
                return;
            }

            if (Regex.IsMatch(name.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("이름에 문자가 포함되어있습니다.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                name.Clear();
                this.ActiveControl = name;
                return;
            }

            if (name.Text.ToString().Trim().Length > 5)
            {
                MessageBox.Show("이름이 너무 깁니다. 한글 5자 이하로 입력하세요.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                name.Clear();
                this.ActiveControl = name;
                return;
            }

            if (Regex.IsMatch(home2.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("집 전화번호에 문자가 포함되어있습니다.", "집 전화번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                home2.Clear();
                this.ActiveControl = home2;
                return;
            }

            if (home2.Text.ToString().Trim().Length > 10)
            {
                MessageBox.Show("집 뒷 전화번호가 너무 깁니다." + '\n' + "숫자 10개 이하만 가능합니다.", "집 전화번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                home2.Clear();
                this.ActiveControl = home2;
                return;
            }

            if (Regex.IsMatch(phone.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("핸드폰 번호에 문자가 포함되어있습니다.", "핸드폰 번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone.Clear();
                this.ActiveControl = phone;
                return;
            }

            if (!Regex.IsMatch(phone.Text.ToString().Trim(), @"^\d{11}$"))
            {
                MessageBox.Show("핸드폰 번호는 숫자로 총 11자리입니다.", "핸드폰 번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone.Clear();
                this.ActiveControl = phone;
                return;
            }

            if (epw.Text.ToString().Trim() != retry_pw.Text.ToString().Trim())
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "비밀번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retry_pw.Clear();
                this.ActiveControl = retry_pw;
                return;
            }
            
            if(epw.Text.ToString().Trim().Length < 8)
            {
                MessageBox.Show("비밀번호의 최소 길이는 8자 이상입니다.", "비밀번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                epw.Clear();
                retry_pw.Clear();

                this.ActiveControl = epw;
                return;
            }

            try
            {
                string s = residentnumber.Text.ToString().Trim();

                if (s[6] == '1')
                {
                    if (employee_mg == "여")
                    {
                        MessageBox.Show("주민등록번호와 성별 중 잘못된 부분이 있습니다.", "주민등록번호와 성별 중 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (s[6] == '2')
                {
                    if(employee_mg == "남")
                    {
                        MessageBox.Show("주민등록번호와 성별 중 잘못된 부분이 있습니다.", "주민등록번호와 성별 중 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 환자 주민등록번호 검사
                string patselect = "select * from patient where rrn = '" + residentnumber.Text.ToString().Trim() + "'";

                MySqlCommand patcmd = new MySqlCommand(patselect, a.Connection());

                MySqlDataReader patrd = patcmd.ExecuteReader();

                if (patrd.HasRows)
                {
                    MessageBox.Show("이미 가입된 환자의 주민등록번호입니다.", "가입 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    residentnumber.Clear();
                    patrd.Close();
                    this.ActiveControl = residentnumber;
                    return;
                }
                patrd.Close();

                // 의사 주민등록번호 검사
                string docselect = "select * from doctor where rrn = '" + residentnumber.Text.ToString().Trim() + "'";

                MySqlCommand doccmd = new MySqlCommand(docselect, a.Connection());

                MySqlDataReader docrd = doccmd.ExecuteReader();

                if (docrd.HasRows)
                {
                    MessageBox.Show("이미 가입된 의사의 주민등록번호입니다.", "가입 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    residentnumber.Clear();
                    docrd.Close();
                    this.ActiveControl = residentnumber;
                    return;
                }
                docrd.Close();

                // 행정직원 주민등록번호 검사
                string rrn_select = "select * from employee where rrn = '" + residentnumber.Text.ToString().Trim() + "'";

                MySqlCommand res_select = new MySqlCommand(rrn_select, a.Connection());

                MySqlDataReader reader_select = res_select.ExecuteReader();

                if (reader_select.HasRows)
                {
                    MessageBox.Show("이미 가입된 행정직원 주민등록번호입니다.", "가입 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    residentnumber.Clear();
                    this.ActiveControl = residentnumber;
                    reader_select.Close();
                    return;
                }

                reader_select.Close();

                if (home2.Text.ToString().Trim().Length < 5)
                {
                    MessageBox.Show("전화번호 뒷 자리가 너무 짧습니다.", "전화번호 뒷 자리 짧음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = home2;
                    return;
                }

                string get = home2.Text.ToString().Trim().Substring(0, employee_homenumber.Length);

                if(get == employee_homenumber)
                {
                    MessageBox.Show("전화번호 뒷 자리에 지역 번호가 포함되어있습니다.", "전화번호 뒷 자리에 지역 번호 포함", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = home2;
                    return;
                }


                // 여기까지 오면 성공
                employee_homenumber += home2.Text.ToString();

                string insertSQL = "insert into employee values('"
                    + id.Text.ToString().Trim() + "', '"
                    + residentnumber.Text.ToString().Trim() + "', '"
                    + epw.Text.ToString().Trim() + "', '"
                    + name.Text.ToString().Trim() + "', '"
                    + employee_mg + "', '"
                    + Address.Text.ToString().Trim() + " " + Address2.Text.ToString().Trim() + "', '"
                    + phone.Text.ToString().Trim() + "', '"
                    + employee_homenumber + "')";

                MySqlCommand cmd = new MySqlCommand(insertSQL, a.Connection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("행정직원 등록이 완료되었습니다.", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.None);

                this.Close();
            }
            catch (Exception Test)
            {
                employee_homenumber = home1.SelectedItem.ToString();
                MessageBox.Show(Test.ToString());
            }            
        }

        // 폼이 열릴 때
        private void employeeEnter_Load(object sender, EventArgs e)
        {
            epw.PasswordChar = '*';
            retry_pw.PasswordChar = '*';
        }

        // 도로명 주소 검색
        private void button1_Click(object sender, EventArgs e)
        {
            adds = new addSearchEnter(this);
            adds.ShowDialog();
        }

        // 직접 입력 클릭
        private void selfinput_Click(object sender, EventArgs e)
        {
            Address.ReadOnly = false;
            Address.Clear();
            this.ActiveControl = Address;
        }
    }
}
