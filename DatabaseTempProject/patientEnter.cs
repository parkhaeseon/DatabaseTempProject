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
    public partial class patientEnter : Form
    {
        public manage patientMng;
        public patientAddressSearch pAS;

        dba a = new dba();

        private string patGender, patHome = "", patBlood;

        public patientEnter(manage _patientMng)
        {
            InitializeComponent();

            this.patientMng = _patientMng;

            // 성별 세팅
            string[] s = { "남", "여" };
            patientGender.Items.AddRange(s);
            patientGender.SelectedIndex = 0;

            // 지역번호 세팅
            string[] p = {"02", "051", "053", "032", "062", "042", "052", "044", "031", "033",
            "043", "041", "063", "061", "054", "055", "064"};
            patientHome.Items.AddRange(p);
            patientHome.SelectedIndex = 0;

            // 혈액형 세팅
            string[] b = {"A", "AB", "O", "B"};
            patientBlood.Items.AddRange(b);
            patientBlood.SelectedIndex = 0;
        }


        // 도로명 주소 검색 버튼 클릭
        private void saddr_Click(object sender, EventArgs e)
        {
            pAS = new patientAddressSearch(this);

            pAS.ShowDialog();
        }

        // 직접 입력 버튼 클릭
        private void selfinput_Click(object sender, EventArgs e)
        {
            patientAddress.ReadOnly = false;
            patientAddress.Clear();
            this.ActiveControl = patientAddress;
        }

        // 성별 콤보 박스
        private void patientGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            patGender = patientGender.SelectedItem.ToString();
        }

        // 혈액형 콤보 박스
        private void patientBlood_SelectedIndexChanged(object sender, EventArgs e)
        {
            patBlood = patientBlood.SelectedItem.ToString();
        }

        // 집 앞 번호 콤보 박스
        private void patientHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            patHome = patientHome.SelectedItem.ToString();
        }

        // 재작성 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            patientId.Clear();
            this.ActiveControl = patientId;
            patientId.ReadOnly = false;
            dupIdbutton.Enabled = true;
        }

        // 중복확인버튼
        private void dupIdbutton_Click(object sender, EventArgs e)
        {
            if (patientId.Text.ToString().Trim() == "")
            {
                MessageBox.Show("아이디 칸이 비어있습니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = patientId;
                return;
            }

            if (!Regex.IsMatch(patientId.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(patientId.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientId.Clear();
                this.ActiveControl = patientId;
                return;
            }

            if (patientId.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = patientId;
                patientId.Clear();
                return;
            }

            try
            {
                // 행정직원 아이디랑 중복인지 검사
                string empidselect = "select * from employee where id = '" + patientId.Text.ToString().Trim() + "'";

                MySqlCommand empidselect_cmd = new MySqlCommand(empidselect, a.Connection());

                MySqlDataReader empidselect_cmd_dr = empidselect_cmd.ExecuteReader();

                if (empidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 행정직원의 아이디입니다." + '\n' + "같을 수 없습니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    patientId.Clear();
                    empidselect_cmd_dr.Close();
                    this.ActiveControl = patientId;
                    return;
                }
                empidselect_cmd_dr.Close();

                // 의사 아이디랑 중복인지 검사
                string docidselect = "select * from doctor where id = '" + patientId.Text.ToString().Trim() + "'";

                MySqlCommand docidselect_cmd = new MySqlCommand(docidselect, a.Connection());

                MySqlDataReader docidselect_cmd_dr = docidselect_cmd.ExecuteReader();

                if (docidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 의사의 아이디입니다." + '\n' + "같을 수 없습니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    patientId.Clear();
                    docidselect_cmd_dr.Close();
                    this.ActiveControl = patientId;
                    return;
                }
                docidselect_cmd_dr.Close();


                // 환자 아이디랑 중복인지 검사
                string patidselect = "select * from patient where id = '" + patientId.Text.ToString().Trim() + "'";

                MySqlCommand patidselect_cmd = new MySqlCommand(patidselect, a.Connection());

                MySqlDataReader patidselect_cmd_dr = patidselect_cmd.ExecuteReader();

                if (patidselect_cmd_dr.HasRows)
                {
                    MessageBox.Show("이미 가입된 환자의 아이디입니다.", "사용 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    patientId.Clear();
                    patidselect_cmd_dr.Close();
                    this.ActiveControl = patientId;
                    return;
                }

                MessageBox.Show("사용 가능합니다.", "사용 가능한 아이디", MessageBoxButtons.OK, MessageBoxIcon.Information);

                patidselect_cmd_dr.Close();

                patientId.ReadOnly = true;

                dupIdbutton.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }   
        }

        // 등록하기 버튼 클릭
        private void Entersure_Click(object sender, EventArgs e)
        {
            if (patientId.Text.ToString().Trim() == "" || patientRrn.Text.ToString().Trim() == "" || patientName.Text.ToString().Trim() == "" || patientAddress.Text.ToString().Trim() == "" ||
                patientAddress2.Text.ToString().Trim() == "" || patientPhone.Text.ToString().Trim() == "" || patientHome2.Text.ToString().Trim() == "")
            {

                MessageBox.Show("빈 칸이 있습니다.", "빈 칸", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (!Regex.IsMatch(patientId.Text.ToString().Trim(), @"^[a-zA-Z0-9]+$") || Regex.IsMatch(patientId.Text.ToString().Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("아이디는 영문 또는 영문과 숫자의 조합만 가능합니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientId.Clear();
                this.ActiveControl = patientId;
                return;
            }

            if (patientId.Text.ToString().Trim().Length > 15)
            {
                MessageBox.Show("아이디가 너무 깁니다.", "아이디", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientId.Clear();
                this.ActiveControl = patientId;
                return;
            }

            if (!patientId.ReadOnly)
            {
                MessageBox.Show("아이디 중복 확인을 해주세요.", "아이디 중복 확인 필수", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = dupIdbutton;
                return;
            }

            if (!Regex.IsMatch(patientName.Text.ToString().Trim(), @"[가-힣]{2,5}"))
            {
                MessageBox.Show("이름에 오류가 있습니다.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientName.Clear();
                this.ActiveControl = patientName;
                return;
            }

            if (Regex.IsMatch(patientName.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("이름에 문자가 포함되어있습니다.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientName.Clear();
                this.ActiveControl = patientName;
                return;
            }

            if (patientName.Text.ToString().Trim().Length > 5)
            {
                MessageBox.Show("이름이 너무 깁니다. 한글 5자 이하로 입력하세요.", "이름", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientName.Clear();
                this.ActiveControl = patientName;
                return;
            }

            if (Regex.IsMatch(patientHome2.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("집 전화번호에 문자가 포함되어있습니다.", "집 전화번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientHome2.Clear();
                this.ActiveControl = patientHome2;
                return;
            }

            if (patientHome2.Text.ToString().Trim().Length > 10)
            {
                MessageBox.Show("집 뒷 전화번호가 너무 깁니다." + '\n' + "숫자 10개 이하만 가능합니다.", "집 전화번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientHome2.Clear();
                this.ActiveControl = patientHome2;
                return;
            }

            if (Regex.IsMatch(patientPhone.Text.ToString().Trim(), @"[~!@\#$%^&*\()\=+|\\/:;?""<>'-]"))
            {
                MessageBox.Show("핸드폰 번호에 문자가 포함되어있습니다.", "핸드폰 번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientPhone.Clear();
                this.ActiveControl = patientPhone;
                return;
            }

            if (!Regex.IsMatch(patientPhone.Text.ToString().Trim(), @"^\d{11}$"))
            {
                MessageBox.Show("핸드폰 번호는 숫자로 총 11자리입니다.", "핸드폰 번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientPhone.Clear();
                this.ActiveControl = patientPhone;
                return;
            }

            if (!Regex.IsMatch(patientRrn.Text.ToString().Trim(), @"^\d{13}$"))
            {
                MessageBox.Show("주민등록번호 형식이 올바르지 않습니다.", "주민등록번호", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                patientRrn.Clear();
                this.ActiveControl = patientRrn;
                return;
            }

            try
            {
                string s = patientRrn.Text.ToString().Trim();

                if (s[6] == '1')
                {
                    if (patGender == "여")
                    {
                        MessageBox.Show("주민등록번호와 성별 중 잘못된 부분이 있습니다.", "주민등록번호와 성별 중 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (s[6] == '2')
                {
                    if (patGender == "남")
                    {
                        MessageBox.Show("주민등록번호와 성별 중 잘못된 부분이 있습니다.", "주민등록번호와 성별 중 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                // 행정직원 주민등록번호 검사
                string rrn_select = "select * from employee where rrn = '" + patientRrn.Text.ToString().Trim() + "'";

                MySqlCommand res_select = new MySqlCommand(rrn_select, a.Connection());

                MySqlDataReader reader_select = res_select.ExecuteReader();

                if (reader_select.HasRows)
                {
                    MessageBox.Show("이미 가입된 행정직원 주민등록번호입니다.", "가입 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    patientRrn.Clear();
                    this.ActiveControl = patientRrn;
                    reader_select.Close();
                    return;
                }
                reader_select.Close();


                // 의사 주민등록번호 검사
                string docselect = "select * from doctor where rrn = '" + patientRrn.Text.ToString().Trim() + "'";

                MySqlCommand doccmd = new MySqlCommand(docselect, a.Connection());

                MySqlDataReader docrd = doccmd.ExecuteReader();

                if (docrd.HasRows)
                {
                    MessageBox.Show("이미 가입된 의사의 주민등록번호입니다.", "가입 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    patientRrn.Clear();
                    docrd.Close();
                    this.ActiveControl = patientRrn;
                    return;
                }
                docrd.Close();


                // 환자 주민등록번호 검사
                string dup_sql = "select rrn from patient where rrn = '" + patientRrn.Text.ToString().Trim() + "'";

                MySqlCommand dup_sql_cmd = new MySqlCommand(dup_sql, a.Connection());

                MySqlDataReader reader = dup_sql_cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("이미 등록된 환자의 주민등록번호입니다.", "등록 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    patientRrn.Clear();
                    reader.Close();
                    this.ActiveControl = patientRrn;
                    return;
                }
                reader.Close();

                if (patientHome2.Text.ToString().Trim().Length < 5)
                {
                    MessageBox.Show("전화번호 뒷 자리가 너무 짧습니다.", "전화번호 뒷 자리 짧음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = patientHome2;
                    return;
                }


                string get = patientHome2.Text.ToString().Trim().Substring(0, patHome.Length);

                if (get == patHome)
                {
                    MessageBox.Show("전화번호 뒷 자리에 지역 번호가 포함되어있습니다.", "전화번호 뒷 자리에 지역 번호 포함", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = patientHome2;
                    return;
                }



                patHome += patientHome2.Text.ToString().Trim();

                string insertSQL = "insert into patient values('"
                    + patientId.Text.ToString().Trim() + "', '"
                    + patientRrn.Text.ToString().Trim() + "', '"
                    + patientName.Text.ToString().Trim() + "', '"
                    + patGender + "', '"
                    + patBlood + "', '"
                    + patientAddress.Text.ToString().Trim() + " " + patientAddress2.Text.ToString().Trim() + "', '"
                    + patientPhone.Text.ToString().Trim() + "', '"
                    + patHome + "')";

                MySqlCommand cmd = new MySqlCommand(insertSQL, a.Connection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("환자 등록이 완료되었습니다.", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.None);

                this.Close();
            }
            catch (Exception Test)
            {
                patHome = patientHome.SelectedItem.ToString();
                MessageBox.Show(Test.ToString());
            }
        }

        // 지우기 버튼 클릭
        private void alldelete_Click(object sender, EventArgs e)
        {
            patientId.Clear();
            patientRrn.Clear();
            patientRrn.ReadOnly = false;
            patientName.Clear();
            patientAddress.Clear();
            patientAddress.ReadOnly = false;
            patientAddress2.Clear();
            patientPhone.Clear();
            patientHome2.Clear();


            patientId.ReadOnly = false;
            dupIdbutton.Enabled = true;

            this.ActiveControl = patientId;
        }
    }
}
