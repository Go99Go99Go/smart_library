using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMgr
{
    public partial class JoinForm : Form
    {
        DB db = new DB();
        bool dupCheck;
        public JoinForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void CheckBox() //체크박스 확인
        {
            if (AllAgreechk.Checked == true)
            {
                Agree1chk.Checked = true;
                Agree2chk.Checked = true;
            }
            else if (Agree1chk.Checked == true && Agree2chk.Checked == true)
            {
                AllAgreechk.Checked = true;
            }
            else if (Agree1chk.Checked == false || Agree2chk.Checked == false)
            {
                AllAgreechk.Checked = false;
            }
        }

        private void AllAgreechk_Click(object sender, EventArgs e)
        {
            if(!Agree1chk.Checked || !Agree2chk.Checked)
            {
                Agree1chk.Checked = true;
                Agree2chk.Checked = true;
            }
            else
            {
                Agree1chk.Checked = false;
                Agree2chk.Checked = false;
            }
        }

        private void NextPagebtn_Click(object sender, EventArgs e)//체크사항 확인
        {
            if(Agree1chk.Checked ==true && Agree2chk.Checked == true)
            {
                UserDatapnl.Visible = true;
            }
            else
            {
                MessageBox.Show("약관동의를 해주세요.", "약관 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Agree1chk_CheckedChanged(object sender, EventArgs e)
        {
            AllAgreechk.Checked = Agree1chk.Checked && Agree2chk.Checked;
        }

        private void Agree2chk_CheckedChanged(object sender, EventArgs e)
        {
            AllAgreechk.Checked = Agree1chk.Checked && Agree2chk.Checked;
        }

        private void PrevPage1btn_Click(object sender, EventArgs e) // 이전 페이지 버튼
        {
            UserDatapnl.Visible = false;
        }

        private void SameCheckbtn_Click(object sender, EventArgs e) // 중복확인 버튼
        {
            string id = IDtxt.Text;
            db.connect();
            bool dup = db.dupCheck(id);
            db.close();
            if (dup) //아이디중복화인
            {
                MessageBox.Show("이미 등록된 아이디입니다.", "아이디 중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IDtxt.Text = "";
                
            }
            else if (IDtxt.Text == "")
            {
                MessageBox.Show("아이디를 입력하여 주세요", "아이디 입력", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else 
            {
                MessageBox.Show("사용가능한 아이디입니다.", "아이디 사용가능", MessageBoxButtons.OK, MessageBoxIcon.None);
                dupCheck = true;
                IDtxt.Enabled = false;
            }
        }

        private void NextPage1btn_Click(object sender, EventArgs e) //다음페이지 버튼 조건 충족확인
        {
            if (IDtxt.Text == "" || PW1txt.Text == "" || PW2txt.Text == "" || Emailtxt.Text == "" || EmailCbx.Text == "" || Nametxt.Text == "" || Teltxt.Text == "")
            {
                MessageBox.Show("필수 항목을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!dupCheck)
            {
                MessageBox.Show("중복 확인을 해주세요.", "비밀번호 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PW1txt.Text != PW2txt.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "비밀번호 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("회원가입을 하시겠습니까?", "회원가입", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "insert into user(`ID`, `PW`, `Email`, `Tel`, `Name`, `adress`, `Rank`) values('" + IDtxt.Text +"', '" + PW1txt.Text + "', '" + Emailtxt.Text + "@" + EmailCbx.Text + "', '" + Teltxt.Text + "', '" + Nametxt.Text + "', '" + Addresstxt.Text + "', '1');";
                    db.connect();
                    db.insertQuery(sql);
                    db.close();
                    Joinpnl.Visible = true;
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Homebtn_Click(object sender, EventArgs e) // 홈으로 버튼
        {
            this.Close();
        }

        private void Joinpnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
