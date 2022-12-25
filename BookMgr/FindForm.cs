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
    public partial class FindForm : Form
    {
        DB db = new DB();
        public FindForm()
        {
            InitializeComponent();
        }

        private void FindForm_Load(object sender, EventArgs e)
        {

        }

        private void FindIDbtn_Click(object sender, EventArgs e) //아이디찾기버튼
        {
            String fID;
            String emailA = FindEmail1txt.Text +  "@" + comboBox1.Text;
            if (FindName1txt.Text == "" || FindEmail1txt.Text == "")
            {
                MessageBox.Show("빈칸을 입력해주세요", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                fID = db.findIDCheck(FindName1txt.Text, emailA);
                if (fID == null)
                {
                    MessageBox.Show("화원정보가 존재하지 않습니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("회원님의 아이디는 " + fID + " 입니다", "아이디 찾기", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
             }
        }
        private void FindPWbtn_Click(object sender, EventArgs e) //비밀번호 찾기 버튼
        {
            String fPW;
            String emailA = FindEmail2txt.Text + "@" + comboBox2.Text;
            if (FindName2txt.Text == "" || FindEmail2txt.Text == "" || FindIDtxt.Text == "")
            {
                MessageBox.Show("빈칸을 입력해주세요", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fPW = db.findPWCheck(FindName2txt.Text, FindIDtxt.Text, emailA);
                if (fPW == null)
                {
                    MessageBox.Show("화원정보가 존재하지 않습니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("회원님의 비밀번호는 " + fPW + " 입니다", "비밀번호 찾기", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void Homebtn_Click(object sender, EventArgs e) // 홈으로 버튼
        {
            this.Close();
        }
    }
}
