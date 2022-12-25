
namespace BookMgr
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BookMenubtn = new System.Windows.Forms.Button();
            this.MemberMenubtn = new System.Windows.Forms.Button();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.PWtxt = new System.Windows.Forms.TextBox();
            this.FindIDPasswordlbl = new System.Windows.Forms.Label();
            this.Findlbl = new System.Windows.Forms.LinkLabel();
            this.Joinlbl = new System.Windows.Forms.LinkLabel();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Verlbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Loginpnl = new System.Windows.Forms.Panel();
            this.extTimerbtn = new System.Windows.Forms.Button();
            this.Logintmr = new System.Windows.Forms.Label();
            this.Seedptr = new System.Windows.Forms.PictureBox();
            this.Leafptr = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ranklbl = new System.Windows.Forms.Label();
            this.Treeptr = new System.Windows.Forms.PictureBox();
            this.Nimlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TabControl();
            this.UserData = new System.Windows.Forms.TabPage();
            this.UserDataUpdatepnl = new System.Windows.Forms.Panel();
            this.Teltxt = new System.Windows.Forms.TextBox();
            this.UserDelbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.EmailCbx = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.UpdatePW2txt = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.UpdatePW1txt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.CheckPWtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderBook = new System.Windows.Forms.TabPage();
            this.Googlebtn = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.Orderbtn = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.OrderDatetxt = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.OrderPublishertxt = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.OrderAuthortxt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.OrderTitletxt = new System.Windows.Forms.TextBox();
            this.MgrOrder = new System.Windows.Forms.TabPage();
            this.Order = new System.Windows.Forms.TabControl();
            this.OrderList = new System.Windows.Forms.TabPage();
            this.BookPutbtn = new System.Windows.Forms.Button();
            this.ListDelbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sucession = new System.Windows.Forms.TabPage();
            this.KickOkbtn = new System.Windows.Forms.Button();
            this.kickNobtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.UserRank = new System.Windows.Forms.TabPage();
            this.RankDown = new System.Windows.Forms.Button();
            this.RankUpbtn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Book = new System.Windows.Forms.TabControl();
            this.Findbookpage = new System.Windows.Forms.TabPage();
            this.SrchDatetxt = new System.Windows.Forms.TextBox();
            this.rntBookBtn = new System.Windows.Forms.Button();
            this.SrchBookbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SrchPublishertxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Srchauthortxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SrchISBNtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SrchTitletxt = new System.Windows.Forms.TextBox();
            this.FindGridView = new System.Windows.Forms.DataGridView();
            this.Returnbookpage = new System.Windows.Forms.TabPage();
            this.Longbtn = new System.Windows.Forms.Button();
            this.Rtnbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.RtnDatetxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RtnPublishertxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RtnAuthortxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RtnTitletxt = new System.Windows.Forms.TextBox();
            this.RtnGridView = new System.Windows.Forms.DataGridView();
            this.Mgrbookpage = new System.Windows.Forms.TabPage();
            this.ListBookbtn = new System.Windows.Forms.Button();
            this.PutBookbtn = new System.Windows.Forms.Button();
            this.DelBookbtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.MgrISBNtxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.MgrPublishertxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MgrAuthortxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MgrDatetxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.MgrTitletxt = new System.Windows.Forms.TextBox();
            this.MgrGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Loginpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Seedptr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leafptr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Treeptr)).BeginInit();
            this.User.SuspendLayout();
            this.UserData.SuspendLayout();
            this.UserDataUpdatepnl.SuspendLayout();
            this.OrderBook.SuspendLayout();
            this.MgrOrder.SuspendLayout();
            this.Order.SuspendLayout();
            this.OrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Sucession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.UserRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Book.SuspendLayout();
            this.Findbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindGridView)).BeginInit();
            this.Returnbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RtnGridView)).BeginInit();
            this.Mgrbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MgrGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookMenubtn
            // 
            this.BookMenubtn.BackColor = System.Drawing.Color.Gray;
            this.BookMenubtn.Image = ((System.Drawing.Image)(resources.GetObject("BookMenubtn.Image")));
            this.BookMenubtn.Location = new System.Drawing.Point(0, 0);
            this.BookMenubtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookMenubtn.Name = "BookMenubtn";
            this.BookMenubtn.Size = new System.Drawing.Size(137, 150);
            this.BookMenubtn.TabIndex = 0;
            this.BookMenubtn.UseVisualStyleBackColor = false;
            // 
            // MemberMenubtn
            // 
            this.MemberMenubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MemberMenubtn.Image = ((System.Drawing.Image)(resources.GetObject("MemberMenubtn.Image")));
            this.MemberMenubtn.Location = new System.Drawing.Point(133, 0);
            this.MemberMenubtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberMenubtn.Name = "MemberMenubtn";
            this.MemberMenubtn.Size = new System.Drawing.Size(137, 150);
            this.MemberMenubtn.TabIndex = 1;
            this.MemberMenubtn.UseVisualStyleBackColor = false;
            // 
            // IDtxt
            // 
            this.IDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDtxt.ForeColor = System.Drawing.Color.Silver;
            this.IDtxt.Location = new System.Drawing.Point(1106, 38);
            this.IDtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(205, 25);
            this.IDtxt.TabIndex = 3;
            this.IDtxt.Text = "아이디";
            this.IDtxt.Enter += new System.EventHandler(this.IDtxt_Enter);
            this.IDtxt.Leave += new System.EventHandler(this.IDtxt_Leave);
            // 
            // PWtxt
            // 
            this.PWtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PWtxt.ForeColor = System.Drawing.Color.Silver;
            this.PWtxt.Location = new System.Drawing.Point(1106, 71);
            this.PWtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PWtxt.Name = "PWtxt";
            this.PWtxt.PasswordChar = '*';
            this.PWtxt.Size = new System.Drawing.Size(205, 25);
            this.PWtxt.TabIndex = 4;
            this.PWtxt.Text = "비밀번호";
            this.PWtxt.Enter += new System.EventHandler(this.Passwordtxt_Enter);
            this.PWtxt.Leave += new System.EventHandler(this.Passwordtxt_Leave);
            // 
            // FindIDPasswordlbl
            // 
            this.FindIDPasswordlbl.AutoSize = true;
            this.FindIDPasswordlbl.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.FindIDPasswordlbl.Location = new System.Drawing.Point(608, 404);
            this.FindIDPasswordlbl.Name = "FindIDPasswordlbl";
            this.FindIDPasswordlbl.Size = new System.Drawing.Size(262, 87);
            this.FindIDPasswordlbl.TabIndex = 5;
            this.FindIDPasswordlbl.Text = "K-형제들";
            // 
            // Findlbl
            // 
            this.Findlbl.AutoSize = true;
            this.Findlbl.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Findlbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Findlbl.LinkColor = System.Drawing.Color.Black;
            this.Findlbl.Location = new System.Drawing.Point(1103, 110);
            this.Findlbl.Name = "Findlbl";
            this.Findlbl.Size = new System.Drawing.Size(145, 13);
            this.Findlbl.TabIndex = 6;
            this.Findlbl.TabStop = true;
            this.Findlbl.Text = "아이디/비밀번호 찾기";
            this.Findlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Joinlbl
            // 
            this.Joinlbl.AutoSize = true;
            this.Joinlbl.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Joinlbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Joinlbl.LinkColor = System.Drawing.Color.Black;
            this.Joinlbl.Location = new System.Drawing.Point(1103, 134);
            this.Joinlbl.Name = "Joinlbl";
            this.Joinlbl.Size = new System.Drawing.Size(63, 13);
            this.Joinlbl.TabIndex = 7;
            this.Joinlbl.TabStop = true;
            this.Joinlbl.Text = "회원가입";
            this.Joinlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Joinlbl_LinkClicked);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Loginbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Loginbtn.Location = new System.Drawing.Point(1319, 38);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(97, 62);
            this.Loginbtn.TabIndex = 8;
            this.Loginbtn.Text = "로그인";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Verlbl
            // 
            this.Verlbl.AutoSize = true;
            this.Verlbl.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Verlbl.Location = new System.Drawing.Point(1314, 796);
            this.Verlbl.Name = "Verlbl";
            this.Verlbl.Size = new System.Drawing.Size(95, 19);
            this.Verlbl.TabIndex = 9;
            this.Verlbl.Text = "ver-1.0.0";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Member.png");
            this.imageList1.Images.SetKeyName(1, "Tree.png");
            this.imageList1.Images.SetKeyName(2, "Book.png");
            this.imageList1.Images.SetKeyName(3, "GoHome.png");
            // 
            // Loginpnl
            // 
            this.Loginpnl.Controls.Add(this.extTimerbtn);
            this.Loginpnl.Controls.Add(this.Logintmr);
            this.Loginpnl.Controls.Add(this.Seedptr);
            this.Loginpnl.Controls.Add(this.Leafptr);
            this.Loginpnl.Controls.Add(this.label4);
            this.Loginpnl.Controls.Add(this.Ranklbl);
            this.Loginpnl.Controls.Add(this.Treeptr);
            this.Loginpnl.Controls.Add(this.Nimlbl);
            this.Loginpnl.Controls.Add(this.Namelbl);
            this.Loginpnl.Controls.Add(this.Logoutbtn);
            this.Loginpnl.Controls.Add(this.userBtn);
            this.Loginpnl.Controls.Add(this.bookBtn);
            this.Loginpnl.Controls.Add(this.Book);
            this.Loginpnl.Controls.Add(this.User);
            this.Loginpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loginpnl.Location = new System.Drawing.Point(0, 0);
            this.Loginpnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Loginpnl.Name = "Loginpnl";
            this.Loginpnl.Size = new System.Drawing.Size(1445, 851);
            this.Loginpnl.TabIndex = 10;
            this.Loginpnl.Visible = false;
            // 
            // extTimerbtn
            // 
            this.extTimerbtn.BackColor = System.Drawing.Color.White;
            this.extTimerbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.extTimerbtn.Location = new System.Drawing.Point(1352, 104);
            this.extTimerbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extTimerbtn.Name = "extTimerbtn";
            this.extTimerbtn.Size = new System.Drawing.Size(64, 30);
            this.extTimerbtn.TabIndex = 30;
            this.extTimerbtn.Text = "연장";
            this.extTimerbtn.UseVisualStyleBackColor = false;
            this.extTimerbtn.Click += new System.EventHandler(this.extTimerbtn_Click);
            // 
            // Logintmr
            // 
            this.Logintmr.AutoSize = true;
            this.Logintmr.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Logintmr.Location = new System.Drawing.Point(1274, 108);
            this.Logintmr.Name = "Logintmr";
            this.Logintmr.Size = new System.Drawing.Size(0, 19);
            this.Logintmr.TabIndex = 29;
            // 
            // Seedptr
            // 
            this.Seedptr.Image = ((System.Drawing.Image)(resources.GetObject("Seedptr.Image")));
            this.Seedptr.Location = new System.Drawing.Point(1102, 38);
            this.Seedptr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Seedptr.Name = "Seedptr";
            this.Seedptr.Size = new System.Drawing.Size(57, 62);
            this.Seedptr.TabIndex = 28;
            this.Seedptr.TabStop = false;
            this.Seedptr.Visible = false;
            // 
            // Leafptr
            // 
            this.Leafptr.Image = ((System.Drawing.Image)(resources.GetObject("Leafptr.Image")));
            this.Leafptr.Location = new System.Drawing.Point(1102, 38);
            this.Leafptr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Leafptr.Name = "Leafptr";
            this.Leafptr.Size = new System.Drawing.Size(57, 62);
            this.Leafptr.TabIndex = 27;
            this.Leafptr.TabStop = false;
            this.Leafptr.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1131, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "등급";
            // 
            // Ranklbl
            // 
            this.Ranklbl.AutoSize = true;
            this.Ranklbl.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ranklbl.ForeColor = System.Drawing.Color.Lime;
            this.Ranklbl.Location = new System.Drawing.Point(1095, 110);
            this.Ranklbl.Name = "Ranklbl";
            this.Ranklbl.Size = new System.Drawing.Size(35, 13);
            this.Ranklbl.TabIndex = 23;
            this.Ranklbl.Text = "나무";
            // 
            // Treeptr
            // 
            this.Treeptr.Image = ((System.Drawing.Image)(resources.GetObject("Treeptr.Image")));
            this.Treeptr.Location = new System.Drawing.Point(1102, 38);
            this.Treeptr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Treeptr.Name = "Treeptr";
            this.Treeptr.Size = new System.Drawing.Size(57, 62);
            this.Treeptr.TabIndex = 22;
            this.Treeptr.TabStop = false;
            this.Treeptr.Visible = false;
            // 
            // Nimlbl
            // 
            this.Nimlbl.AutoSize = true;
            this.Nimlbl.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.Nimlbl.Location = new System.Drawing.Point(1266, 45);
            this.Nimlbl.Name = "Nimlbl";
            this.Nimlbl.Size = new System.Drawing.Size(53, 49);
            this.Nimlbl.TabIndex = 21;
            this.Nimlbl.Text = "님";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.Namelbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Namelbl.Location = new System.Drawing.Point(1153, 45);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(115, 49);
            this.Namelbl.TabIndex = 20;
            this.Namelbl.Text = "홍길동";
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Logoutbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Logoutbtn.Location = new System.Drawing.Point(1319, 38);
            this.Logoutbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(97, 62);
            this.Logoutbtn.TabIndex = 18;
            this.Logoutbtn.Text = "로그아웃";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click_1);
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBtn.Image")));
            this.userBtn.Location = new System.Drawing.Point(133, 0);
            this.userBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(137, 150);
            this.userBtn.TabIndex = 11;
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.BackColor = System.Drawing.Color.Gray;
            this.bookBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookBtn.Image")));
            this.bookBtn.Location = new System.Drawing.Point(0, 0);
            this.bookBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(137, 150);
            this.bookBtn.TabIndex = 10;
            this.bookBtn.UseVisualStyleBackColor = false;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // User
            // 
            this.User.Controls.Add(this.UserData);
            this.User.Controls.Add(this.OrderBook);
            this.User.Controls.Add(this.MgrOrder);
            this.User.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.User.ItemSize = new System.Drawing.Size(50, 50);
            this.User.Location = new System.Drawing.Point(5, 146);
            this.User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.User.Name = "User";
            this.User.Padding = new System.Drawing.Point(22, 3);
            this.User.SelectedIndex = 0;
            this.User.Size = new System.Drawing.Size(1440, 688);
            this.User.TabIndex = 26;
            this.User.Visible = false;
            // 
            // UserData
            // 
            this.UserData.BackColor = System.Drawing.Color.White;
            this.UserData.Controls.Add(this.UserDataUpdatepnl);
            this.UserData.Controls.Add(this.label19);
            this.UserData.Controls.Add(this.Nextbtn);
            this.UserData.Controls.Add(this.CheckPWtxt);
            this.UserData.Controls.Add(this.label1);
            this.UserData.Location = new System.Drawing.Point(4, 54);
            this.UserData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserData.Name = "UserData";
            this.UserData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserData.Size = new System.Drawing.Size(1432, 630);
            this.UserData.TabIndex = 0;
            this.UserData.Text = "회원정보";
            // 
            // UserDataUpdatepnl
            // 
            this.UserDataUpdatepnl.Controls.Add(this.Teltxt);
            this.UserDataUpdatepnl.Controls.Add(this.UserDelbtn);
            this.UserDataUpdatepnl.Controls.Add(this.Updatebtn);
            this.UserDataUpdatepnl.Controls.Add(this.EmailCbx);
            this.UserDataUpdatepnl.Controls.Add(this.label41);
            this.UserDataUpdatepnl.Controls.Add(this.Emailtxt);
            this.UserDataUpdatepnl.Controls.Add(this.label37);
            this.UserDataUpdatepnl.Controls.Add(this.Addresstxt);
            this.UserDataUpdatepnl.Controls.Add(this.label38);
            this.UserDataUpdatepnl.Controls.Add(this.Nametxt);
            this.UserDataUpdatepnl.Controls.Add(this.label39);
            this.UserDataUpdatepnl.Controls.Add(this.label35);
            this.UserDataUpdatepnl.Controls.Add(this.UpdatePW2txt);
            this.UserDataUpdatepnl.Controls.Add(this.label34);
            this.UserDataUpdatepnl.Controls.Add(this.UpdatePW1txt);
            this.UserDataUpdatepnl.Controls.Add(this.label23);
            this.UserDataUpdatepnl.Controls.Add(this.label21);
            this.UserDataUpdatepnl.Controls.Add(this.label20);
            this.UserDataUpdatepnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDataUpdatepnl.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserDataUpdatepnl.Location = new System.Drawing.Point(3, 4);
            this.UserDataUpdatepnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserDataUpdatepnl.Name = "UserDataUpdatepnl";
            this.UserDataUpdatepnl.Size = new System.Drawing.Size(1426, 622);
            this.UserDataUpdatepnl.TabIndex = 4;
            this.UserDataUpdatepnl.Visible = false;
            // 
            // Teltxt
            // 
            this.Teltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Teltxt.Location = new System.Drawing.Point(949, 250);
            this.Teltxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Teltxt.Name = "Teltxt";
            this.Teltxt.Size = new System.Drawing.Size(285, 26);
            this.Teltxt.TabIndex = 31;
            // 
            // UserDelbtn
            // 
            this.UserDelbtn.BackColor = System.Drawing.Color.LightGray;
            this.UserDelbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserDelbtn.Location = new System.Drawing.Point(1161, 471);
            this.UserDelbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserDelbtn.Name = "UserDelbtn";
            this.UserDelbtn.Size = new System.Drawing.Size(126, 56);
            this.UserDelbtn.TabIndex = 30;
            this.UserDelbtn.Text = "회원탈퇴";
            this.UserDelbtn.UseVisualStyleBackColor = false;
            this.UserDelbtn.Click += new System.EventHandler(this.UserDelbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.LightGray;
            this.Updatebtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Updatebtn.Location = new System.Drawing.Point(1021, 471);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(126, 56);
            this.Updatebtn.TabIndex = 29;
            this.Updatebtn.Text = "수정완료";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // EmailCbx
            // 
            this.EmailCbx.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmailCbx.FormattingEnabled = true;
            this.EmailCbx.Items.AddRange(new object[] {
            "naver.com",
            "gmail.com",
            "kyungmin.ac.kr",
            "hanmail.com"});
            this.EmailCbx.Location = new System.Drawing.Point(470, 251);
            this.EmailCbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailCbx.Name = "EmailCbx";
            this.EmailCbx.Size = new System.Drawing.Size(188, 24);
            this.EmailCbx.TabIndex = 28;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(443, 255);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(21, 16);
            this.label41.TabIndex = 27;
            this.label41.Text = "@";
            // 
            // Emailtxt
            // 
            this.Emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Emailtxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Emailtxt.Location = new System.Drawing.Point(263, 250);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(180, 26);
            this.Emailtxt.TabIndex = 23;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label37.Location = new System.Drawing.Point(800, 256);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(90, 16);
            this.label37.TabIndex = 20;
            this.label37.Text = "*전화번호:";
            // 
            // Addresstxt
            // 
            this.Addresstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Addresstxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Addresstxt.Location = new System.Drawing.Point(949, 175);
            this.Addresstxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(423, 26);
            this.Addresstxt.TabIndex = 19;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label38.Location = new System.Drawing.Point(800, 181);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(48, 16);
            this.label38.TabIndex = 18;
            this.label38.Text = "주소:";
            // 
            // Nametxt
            // 
            this.Nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nametxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Nametxt.Location = new System.Drawing.Point(949, 100);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(114, 26);
            this.Nametxt.TabIndex = 17;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.Location = new System.Drawing.Point(800, 106);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(56, 16);
            this.label39.TabIndex = 16;
            this.label39.Text = "*이름:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label35.Location = new System.Drawing.Point(114, 256);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(73, 16);
            this.label35.TabIndex = 13;
            this.label35.Text = "*이메일:";
            // 
            // UpdatePW2txt
            // 
            this.UpdatePW2txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdatePW2txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdatePW2txt.Location = new System.Drawing.Point(263, 175);
            this.UpdatePW2txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdatePW2txt.Name = "UpdatePW2txt";
            this.UpdatePW2txt.PasswordChar = '*';
            this.UpdatePW2txt.Size = new System.Drawing.Size(285, 26);
            this.UpdatePW2txt.TabIndex = 12;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.Location = new System.Drawing.Point(114, 181);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(124, 16);
            this.label34.TabIndex = 11;
            this.label34.Text = "*비밀번호확인:";
            // 
            // UpdatePW1txt
            // 
            this.UpdatePW1txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdatePW1txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdatePW1txt.Location = new System.Drawing.Point(263, 100);
            this.UpdatePW1txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdatePW1txt.Name = "UpdatePW1txt";
            this.UpdatePW1txt.PasswordChar = '*';
            this.UpdatePW1txt.Size = new System.Drawing.Size(285, 26);
            this.UpdatePW1txt.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(114, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 16);
            this.label23.TabIndex = 9;
            this.label23.Text = "*비밀번호:";
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(57, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(1314, 2);
            this.label21.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.label20.Location = new System.Drawing.Point(591, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(261, 61);
            this.label20.TabIndex = 4;
            this.label20.Text = "회원정보수정";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.label19.Location = new System.Drawing.Point(571, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(273, 61);
            this.label19.TabIndex = 3;
            this.label19.Text = "비밀번호 확인";
            // 
            // Nextbtn
            // 
            this.Nextbtn.Image = ((System.Drawing.Image)(resources.GetObject("Nextbtn.Image")));
            this.Nextbtn.Location = new System.Drawing.Point(632, 305);
            this.Nextbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(103, 112);
            this.Nextbtn.TabIndex = 2;
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // CheckPWtxt
            // 
            this.CheckPWtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckPWtxt.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CheckPWtxt.Location = new System.Drawing.Point(473, 186);
            this.CheckPWtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckPWtxt.Name = "CheckPWtxt";
            this.CheckPWtxt.PasswordChar = '*';
            this.CheckPWtxt.Size = new System.Drawing.Size(457, 39);
            this.CheckPWtxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.label1.Location = new System.Drawing.Point(322, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "비밀번호:";
            // 
            // OrderBook
            // 
            this.OrderBook.BackColor = System.Drawing.Color.White;
            this.OrderBook.Controls.Add(this.Googlebtn);
            this.OrderBook.Controls.Add(this.label36);
            this.OrderBook.Controls.Add(this.label42);
            this.OrderBook.Controls.Add(this.Orderbtn);
            this.OrderBook.Controls.Add(this.label24);
            this.OrderBook.Controls.Add(this.OrderDatetxt);
            this.OrderBook.Controls.Add(this.label25);
            this.OrderBook.Controls.Add(this.OrderPublishertxt);
            this.OrderBook.Controls.Add(this.label26);
            this.OrderBook.Controls.Add(this.OrderAuthortxt);
            this.OrderBook.Controls.Add(this.label27);
            this.OrderBook.Controls.Add(this.OrderTitletxt);
            this.OrderBook.Location = new System.Drawing.Point(4, 54);
            this.OrderBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderBook.Name = "OrderBook";
            this.OrderBook.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderBook.Size = new System.Drawing.Size(1432, 630);
            this.OrderBook.TabIndex = 1;
            this.OrderBook.Text = "도서신청";
            // 
            // Googlebtn
            // 
            this.Googlebtn.Image = ((System.Drawing.Image)(resources.GetObject("Googlebtn.Image")));
            this.Googlebtn.Location = new System.Drawing.Point(599, 72);
            this.Googlebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Googlebtn.Name = "Googlebtn";
            this.Googlebtn.Size = new System.Drawing.Size(249, 79);
            this.Googlebtn.TabIndex = 14;
            this.Googlebtn.UseVisualStyleBackColor = true;
            this.Googlebtn.Click += new System.EventHandler(this.Googlebtn_Click);
            // 
            // label36
            // 
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Location = new System.Drawing.Point(57, 62);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(1314, 2);
            this.label36.TabIndex = 13;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.label42.Location = new System.Drawing.Point(626, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(195, 61);
            this.label42.TabIndex = 12;
            this.label42.Text = "도서 신청";
            // 
            // Orderbtn
            // 
            this.Orderbtn.BackColor = System.Drawing.Color.LightGray;
            this.Orderbtn.Location = new System.Drawing.Point(659, 475);
            this.Orderbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Orderbtn.Name = "Orderbtn";
            this.Orderbtn.Size = new System.Drawing.Size(126, 56);
            this.Orderbtn.TabIndex = 11;
            this.Orderbtn.Text = "신청하기";
            this.Orderbtn.UseVisualStyleBackColor = false;
            this.Orderbtn.Click += new System.EventHandler(this.Orderbtn_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(479, 406);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 16);
            this.label24.TabIndex = 10;
            this.label24.Text = "발행일:";
            // 
            // OrderDatetxt
            // 
            this.OrderDatetxt.BackColor = System.Drawing.Color.White;
            this.OrderDatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderDatetxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderDatetxt.Location = new System.Drawing.Point(602, 400);
            this.OrderDatetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderDatetxt.Name = "OrderDatetxt";
            this.OrderDatetxt.Size = new System.Drawing.Size(245, 26);
            this.OrderDatetxt.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(479, 331);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 16);
            this.label25.TabIndex = 8;
            this.label25.Text = "출판사:";
            // 
            // OrderPublishertxt
            // 
            this.OrderPublishertxt.BackColor = System.Drawing.Color.White;
            this.OrderPublishertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderPublishertxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderPublishertxt.Location = new System.Drawing.Point(602, 325);
            this.OrderPublishertxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderPublishertxt.Name = "OrderPublishertxt";
            this.OrderPublishertxt.Size = new System.Drawing.Size(245, 26);
            this.OrderPublishertxt.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(479, 256);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 16);
            this.label26.TabIndex = 6;
            this.label26.Text = "저자:";
            // 
            // OrderAuthortxt
            // 
            this.OrderAuthortxt.BackColor = System.Drawing.Color.White;
            this.OrderAuthortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderAuthortxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderAuthortxt.Location = new System.Drawing.Point(602, 250);
            this.OrderAuthortxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderAuthortxt.Name = "OrderAuthortxt";
            this.OrderAuthortxt.Size = new System.Drawing.Size(245, 26);
            this.OrderAuthortxt.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(479, 181);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 16);
            this.label27.TabIndex = 4;
            this.label27.Text = "제목:";
            // 
            // OrderTitletxt
            // 
            this.OrderTitletxt.BackColor = System.Drawing.Color.White;
            this.OrderTitletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderTitletxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderTitletxt.Location = new System.Drawing.Point(602, 175);
            this.OrderTitletxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderTitletxt.Name = "OrderTitletxt";
            this.OrderTitletxt.Size = new System.Drawing.Size(245, 26);
            this.OrderTitletxt.TabIndex = 3;
            // 
            // MgrOrder
            // 
            this.MgrOrder.BackColor = System.Drawing.Color.White;
            this.MgrOrder.Controls.Add(this.Order);
            this.MgrOrder.Location = new System.Drawing.Point(4, 54);
            this.MgrOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MgrOrder.Name = "MgrOrder";
            this.MgrOrder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MgrOrder.Size = new System.Drawing.Size(1432, 630);
            this.MgrOrder.TabIndex = 2;
            this.MgrOrder.Text = "신청관리";
            // 
            // Order
            // 
            this.Order.Controls.Add(this.OrderList);
            this.Order.Controls.Add(this.Sucession);
            this.Order.Controls.Add(this.UserRank);
            this.Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Order.ItemSize = new System.Drawing.Size(120, 30);
            this.Order.Location = new System.Drawing.Point(3, 4);
            this.Order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Order.Name = "Order";
            this.Order.SelectedIndex = 0;
            this.Order.Size = new System.Drawing.Size(1426, 622);
            this.Order.TabIndex = 0;
            // 
            // OrderList
            // 
            this.OrderList.BackColor = System.Drawing.Color.White;
            this.OrderList.Controls.Add(this.BookPutbtn);
            this.OrderList.Controls.Add(this.ListDelbtn);
            this.OrderList.Controls.Add(this.dataGridView1);
            this.OrderList.Location = new System.Drawing.Point(4, 34);
            this.OrderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderList.Name = "OrderList";
            this.OrderList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderList.Size = new System.Drawing.Size(1418, 584);
            this.OrderList.TabIndex = 0;
            this.OrderList.Text = "도서신청관리";
            this.OrderList.Enter += new System.EventHandler(this.OrderList_Enter);
            // 
            // BookPutbtn
            // 
            this.BookPutbtn.BackColor = System.Drawing.Color.LightGray;
            this.BookPutbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BookPutbtn.Location = new System.Drawing.Point(1223, 125);
            this.BookPutbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookPutbtn.Name = "BookPutbtn";
            this.BookPutbtn.Size = new System.Drawing.Size(126, 56);
            this.BookPutbtn.TabIndex = 32;
            this.BookPutbtn.Text = "도서등록";
            this.BookPutbtn.UseVisualStyleBackColor = false;
            this.BookPutbtn.Click += new System.EventHandler(this.BookPutbtn_Click);
            // 
            // ListDelbtn
            // 
            this.ListDelbtn.BackColor = System.Drawing.Color.LightGray;
            this.ListDelbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListDelbtn.Location = new System.Drawing.Point(1223, 50);
            this.ListDelbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListDelbtn.Name = "ListDelbtn";
            this.ListDelbtn.Size = new System.Drawing.Size(126, 56);
            this.ListDelbtn.TabIndex = 31;
            this.ListDelbtn.Text = "목록제거";
            this.ListDelbtn.UseVisualStyleBackColor = false;
            this.ListDelbtn.Click += new System.EventHandler(this.ListDelbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(34, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Sucession
            // 
            this.Sucession.BackColor = System.Drawing.Color.White;
            this.Sucession.Controls.Add(this.KickOkbtn);
            this.Sucession.Controls.Add(this.kickNobtn);
            this.Sucession.Controls.Add(this.dataGridView2);
            this.Sucession.Location = new System.Drawing.Point(4, 34);
            this.Sucession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sucession.Name = "Sucession";
            this.Sucession.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sucession.Size = new System.Drawing.Size(1418, 584);
            this.Sucession.TabIndex = 1;
            this.Sucession.Text = "회원탈퇴신청";
            this.Sucession.Enter += new System.EventHandler(this.Sucession_Enter);
            // 
            // KickOkbtn
            // 
            this.KickOkbtn.BackColor = System.Drawing.Color.LightGray;
            this.KickOkbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KickOkbtn.Location = new System.Drawing.Point(1223, 50);
            this.KickOkbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KickOkbtn.Name = "KickOkbtn";
            this.KickOkbtn.Size = new System.Drawing.Size(126, 56);
            this.KickOkbtn.TabIndex = 36;
            this.KickOkbtn.Text = "탈퇴승인";
            this.KickOkbtn.UseVisualStyleBackColor = false;
            this.KickOkbtn.Click += new System.EventHandler(this.KickOkbtn_Click);
            // 
            // kickNobtn
            // 
            this.kickNobtn.BackColor = System.Drawing.Color.LightGray;
            this.kickNobtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kickNobtn.Location = new System.Drawing.Point(1223, 125);
            this.kickNobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kickNobtn.Name = "kickNobtn";
            this.kickNobtn.Size = new System.Drawing.Size(126, 56);
            this.kickNobtn.TabIndex = 35;
            this.kickNobtn.Text = "탈퇴취소";
            this.kickNobtn.UseVisualStyleBackColor = false;
            this.kickNobtn.Click += new System.EventHandler(this.kickNo_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 38);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1143, 500);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // UserRank
            // 
            this.UserRank.BackColor = System.Drawing.Color.White;
            this.UserRank.Controls.Add(this.RankDown);
            this.UserRank.Controls.Add(this.RankUpbtn);
            this.UserRank.Controls.Add(this.dataGridView3);
            this.UserRank.Location = new System.Drawing.Point(4, 34);
            this.UserRank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserRank.Name = "UserRank";
            this.UserRank.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserRank.Size = new System.Drawing.Size(1418, 584);
            this.UserRank.TabIndex = 2;
            this.UserRank.Text = "회원등급관리";
            this.UserRank.Enter += new System.EventHandler(this.UserRank_Load);
            // 
            // RankDown
            // 
            this.RankDown.BackColor = System.Drawing.Color.LightGray;
            this.RankDown.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RankDown.Location = new System.Drawing.Point(1223, 125);
            this.RankDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RankDown.Name = "RankDown";
            this.RankDown.Size = new System.Drawing.Size(126, 56);
            this.RankDown.TabIndex = 38;
            this.RankDown.Text = "등급내리기";
            this.RankDown.UseVisualStyleBackColor = false;
            this.RankDown.Click += new System.EventHandler(this.RankDown_Click);
            // 
            // RankUpbtn
            // 
            this.RankUpbtn.BackColor = System.Drawing.Color.LightGray;
            this.RankUpbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RankUpbtn.Location = new System.Drawing.Point(1223, 50);
            this.RankUpbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RankUpbtn.Name = "RankUpbtn";
            this.RankUpbtn.Size = new System.Drawing.Size(126, 56);
            this.RankUpbtn.TabIndex = 37;
            this.RankUpbtn.Text = "등급올리기";
            this.RankUpbtn.UseVisualStyleBackColor = false;
            this.RankUpbtn.Click += new System.EventHandler(this.RankUpbtn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(34, 38);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1143, 500);
            this.dataGridView3.TabIndex = 36;
            this.dataGridView3.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseClick);
            // 
            // Book
            // 
            this.Book.Controls.Add(this.Findbookpage);
            this.Book.Controls.Add(this.Returnbookpage);
            this.Book.Controls.Add(this.Mgrbookpage);
            this.Book.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Book.ItemSize = new System.Drawing.Size(50, 50);
            this.Book.Location = new System.Drawing.Point(5, 146);
            this.Book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Book.Name = "Book";
            this.Book.Padding = new System.Drawing.Point(22, 3);
            this.Book.SelectedIndex = 0;
            this.Book.Size = new System.Drawing.Size(1440, 688);
            this.Book.TabIndex = 25;
            // 
            // Findbookpage
            // 
            this.Findbookpage.BackColor = System.Drawing.Color.White;
            this.Findbookpage.Controls.Add(this.SrchDatetxt);
            this.Findbookpage.Controls.Add(this.rntBookBtn);
            this.Findbookpage.Controls.Add(this.SrchBookbtn);
            this.Findbookpage.Controls.Add(this.label8);
            this.Findbookpage.Controls.Add(this.SrchPublishertxt);
            this.Findbookpage.Controls.Add(this.label6);
            this.Findbookpage.Controls.Add(this.Srchauthortxt);
            this.Findbookpage.Controls.Add(this.label7);
            this.Findbookpage.Controls.Add(this.label5);
            this.Findbookpage.Controls.Add(this.SrchISBNtxt);
            this.Findbookpage.Controls.Add(this.label2);
            this.Findbookpage.Controls.Add(this.SrchTitletxt);
            this.Findbookpage.Controls.Add(this.FindGridView);
            this.Findbookpage.Location = new System.Drawing.Point(4, 54);
            this.Findbookpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Findbookpage.Name = "Findbookpage";
            this.Findbookpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Findbookpage.Size = new System.Drawing.Size(1432, 630);
            this.Findbookpage.TabIndex = 0;
            this.Findbookpage.Text = "도서검색";
            this.Findbookpage.Enter += new System.EventHandler(this.Findbookpage_Enter);
            // 
            // SrchDatetxt
            // 
            this.SrchDatetxt.BackColor = System.Drawing.Color.White;
            this.SrchDatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrchDatetxt.Location = new System.Drawing.Point(1141, 344);
            this.SrchDatetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SrchDatetxt.Name = "SrchDatetxt";
            this.SrchDatetxt.Size = new System.Drawing.Size(245, 26);
            this.SrchDatetxt.TabIndex = 14;
            // 
            // rntBookBtn
            // 
            this.rntBookBtn.BackColor = System.Drawing.Color.LightGray;
            this.rntBookBtn.Location = new System.Drawing.Point(1259, 475);
            this.rntBookBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rntBookBtn.Name = "rntBookBtn";
            this.rntBookBtn.Size = new System.Drawing.Size(126, 56);
            this.rntBookBtn.TabIndex = 12;
            this.rntBookBtn.Text = "도서대여";
            this.rntBookBtn.UseVisualStyleBackColor = false;
            this.rntBookBtn.Click += new System.EventHandler(this.rntBookBtn_Click);
            // 
            // SrchBookbtn
            // 
            this.SrchBookbtn.BackColor = System.Drawing.Color.LightGray;
            this.SrchBookbtn.Location = new System.Drawing.Point(1120, 475);
            this.SrchBookbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SrchBookbtn.Name = "SrchBookbtn";
            this.SrchBookbtn.Size = new System.Drawing.Size(126, 56);
            this.SrchBookbtn.TabIndex = 11;
            this.SrchBookbtn.Text = "도서검색";
            this.SrchBookbtn.UseVisualStyleBackColor = false;
            this.SrchBookbtn.Click += new System.EventHandler(this.SrchBookbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1017, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "ISBN:";
            // 
            // SrchPublishertxt
            // 
            this.SrchPublishertxt.BackColor = System.Drawing.Color.White;
            this.SrchPublishertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrchPublishertxt.Location = new System.Drawing.Point(1141, 194);
            this.SrchPublishertxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SrchPublishertxt.Name = "SrchPublishertxt";
            this.SrchPublishertxt.Size = new System.Drawing.Size(245, 26);
            this.SrchPublishertxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1017, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "발행일:";
            // 
            // Srchauthortxt
            // 
            this.Srchauthortxt.BackColor = System.Drawing.Color.White;
            this.Srchauthortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Srchauthortxt.Location = new System.Drawing.Point(1141, 269);
            this.Srchauthortxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Srchauthortxt.Name = "Srchauthortxt";
            this.Srchauthortxt.Size = new System.Drawing.Size(245, 26);
            this.Srchauthortxt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1017, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "저자:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1017, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "출판사:";
            // 
            // SrchISBNtxt
            // 
            this.SrchISBNtxt.BackColor = System.Drawing.Color.White;
            this.SrchISBNtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrchISBNtxt.Location = new System.Drawing.Point(1141, 419);
            this.SrchISBNtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SrchISBNtxt.Name = "SrchISBNtxt";
            this.SrchISBNtxt.Size = new System.Drawing.Size(245, 26);
            this.SrchISBNtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1017, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "제목:";
            // 
            // SrchTitletxt
            // 
            this.SrchTitletxt.BackColor = System.Drawing.Color.White;
            this.SrchTitletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrchTitletxt.Location = new System.Drawing.Point(1141, 119);
            this.SrchTitletxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SrchTitletxt.Name = "SrchTitletxt";
            this.SrchTitletxt.Size = new System.Drawing.Size(245, 26);
            this.SrchTitletxt.TabIndex = 1;
            // 
            // FindGridView
            // 
            this.FindGridView.AllowUserToAddRows = false;
            this.FindGridView.AllowUserToDeleteRows = false;
            this.FindGridView.AllowUserToResizeRows = false;
            this.FindGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FindGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FindGridView.BackgroundColor = System.Drawing.Color.White;
            this.FindGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindGridView.Location = new System.Drawing.Point(0, 0);
            this.FindGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FindGridView.Name = "FindGridView";
            this.FindGridView.ReadOnly = true;
            this.FindGridView.RowHeadersWidth = 51;
            this.FindGridView.RowTemplate.Height = 23;
            this.FindGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FindGridView.Size = new System.Drawing.Size(995, 638);
            this.FindGridView.TabIndex = 0;
            this.FindGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FindGridView_CellMouseClick);
            // 
            // Returnbookpage
            // 
            this.Returnbookpage.BackColor = System.Drawing.Color.White;
            this.Returnbookpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Returnbookpage.Controls.Add(this.Longbtn);
            this.Returnbookpage.Controls.Add(this.Rtnbtn);
            this.Returnbookpage.Controls.Add(this.label11);
            this.Returnbookpage.Controls.Add(this.RtnDatetxt);
            this.Returnbookpage.Controls.Add(this.label12);
            this.Returnbookpage.Controls.Add(this.RtnPublishertxt);
            this.Returnbookpage.Controls.Add(this.label10);
            this.Returnbookpage.Controls.Add(this.RtnAuthortxt);
            this.Returnbookpage.Controls.Add(this.label9);
            this.Returnbookpage.Controls.Add(this.RtnTitletxt);
            this.Returnbookpage.Controls.Add(this.RtnGridView);
            this.Returnbookpage.Location = new System.Drawing.Point(4, 54);
            this.Returnbookpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbookpage.Name = "Returnbookpage";
            this.Returnbookpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbookpage.Size = new System.Drawing.Size(1432, 630);
            this.Returnbookpage.TabIndex = 1;
            this.Returnbookpage.Text = "도서반납";
            this.Returnbookpage.Enter += new System.EventHandler(this.Returnbookpage_Enter);
            // 
            // Longbtn
            // 
            this.Longbtn.BackColor = System.Drawing.Color.LightGray;
            this.Longbtn.Location = new System.Drawing.Point(1120, 475);
            this.Longbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Longbtn.Name = "Longbtn";
            this.Longbtn.Size = new System.Drawing.Size(126, 56);
            this.Longbtn.TabIndex = 12;
            this.Longbtn.Text = "연장하기";
            this.Longbtn.UseVisualStyleBackColor = false;
            this.Longbtn.Click += new System.EventHandler(this.Longbtn_Click);
            // 
            // Rtnbtn
            // 
            this.Rtnbtn.BackColor = System.Drawing.Color.LightGray;
            this.Rtnbtn.Location = new System.Drawing.Point(1257, 475);
            this.Rtnbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rtnbtn.Name = "Rtnbtn";
            this.Rtnbtn.Size = new System.Drawing.Size(126, 56);
            this.Rtnbtn.TabIndex = 11;
            this.Rtnbtn.Text = "반납하기";
            this.Rtnbtn.UseVisualStyleBackColor = false;
            this.Rtnbtn.Click += new System.EventHandler(this.Rtnbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1017, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "반납예정일:";
            // 
            // RtnDatetxt
            // 
            this.RtnDatetxt.BackColor = System.Drawing.Color.White;
            this.RtnDatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtnDatetxt.Location = new System.Drawing.Point(1141, 344);
            this.RtnDatetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RtnDatetxt.Name = "RtnDatetxt";
            this.RtnDatetxt.Size = new System.Drawing.Size(245, 26);
            this.RtnDatetxt.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1017, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "출판사:";
            // 
            // RtnPublishertxt
            // 
            this.RtnPublishertxt.BackColor = System.Drawing.Color.White;
            this.RtnPublishertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtnPublishertxt.Location = new System.Drawing.Point(1141, 269);
            this.RtnPublishertxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RtnPublishertxt.Name = "RtnPublishertxt";
            this.RtnPublishertxt.Size = new System.Drawing.Size(245, 26);
            this.RtnPublishertxt.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1017, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "저자:";
            // 
            // RtnAuthortxt
            // 
            this.RtnAuthortxt.BackColor = System.Drawing.Color.White;
            this.RtnAuthortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtnAuthortxt.Location = new System.Drawing.Point(1141, 194);
            this.RtnAuthortxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RtnAuthortxt.Name = "RtnAuthortxt";
            this.RtnAuthortxt.Size = new System.Drawing.Size(245, 26);
            this.RtnAuthortxt.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1017, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "제목:";
            // 
            // RtnTitletxt
            // 
            this.RtnTitletxt.BackColor = System.Drawing.Color.White;
            this.RtnTitletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtnTitletxt.Location = new System.Drawing.Point(1141, 119);
            this.RtnTitletxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RtnTitletxt.Name = "RtnTitletxt";
            this.RtnTitletxt.Size = new System.Drawing.Size(245, 26);
            this.RtnTitletxt.TabIndex = 3;
            // 
            // RtnGridView
            // 
            this.RtnGridView.AllowUserToAddRows = false;
            this.RtnGridView.AllowUserToDeleteRows = false;
            this.RtnGridView.AllowUserToResizeColumns = false;
            this.RtnGridView.AllowUserToResizeRows = false;
            this.RtnGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RtnGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RtnGridView.BackgroundColor = System.Drawing.Color.White;
            this.RtnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RtnGridView.Location = new System.Drawing.Point(0, 0);
            this.RtnGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RtnGridView.Name = "RtnGridView";
            this.RtnGridView.ReadOnly = true;
            this.RtnGridView.RowHeadersWidth = 51;
            this.RtnGridView.RowTemplate.Height = 23;
            this.RtnGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RtnGridView.Size = new System.Drawing.Size(995, 638);
            this.RtnGridView.TabIndex = 1;
            this.RtnGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RtnGridView_CellMouseClick);
            // 
            // Mgrbookpage
            // 
            this.Mgrbookpage.BackColor = System.Drawing.Color.White;
            this.Mgrbookpage.Controls.Add(this.ListBookbtn);
            this.Mgrbookpage.Controls.Add(this.PutBookbtn);
            this.Mgrbookpage.Controls.Add(this.DelBookbtn);
            this.Mgrbookpage.Controls.Add(this.label17);
            this.Mgrbookpage.Controls.Add(this.MgrISBNtxt);
            this.Mgrbookpage.Controls.Add(this.label18);
            this.Mgrbookpage.Controls.Add(this.MgrPublishertxt);
            this.Mgrbookpage.Controls.Add(this.label13);
            this.Mgrbookpage.Controls.Add(this.MgrAuthortxt);
            this.Mgrbookpage.Controls.Add(this.label14);
            this.Mgrbookpage.Controls.Add(this.MgrDatetxt);
            this.Mgrbookpage.Controls.Add(this.label16);
            this.Mgrbookpage.Controls.Add(this.MgrTitletxt);
            this.Mgrbookpage.Controls.Add(this.MgrGridView);
            this.Mgrbookpage.Location = new System.Drawing.Point(4, 54);
            this.Mgrbookpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mgrbookpage.Name = "Mgrbookpage";
            this.Mgrbookpage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mgrbookpage.Size = new System.Drawing.Size(1432, 630);
            this.Mgrbookpage.TabIndex = 2;
            this.Mgrbookpage.Text = "도서관리";
            this.Mgrbookpage.Enter += new System.EventHandler(this.Mgrbookpage_Enter);
            // 
            // ListBookbtn
            // 
            this.ListBookbtn.BackColor = System.Drawing.Color.LightGray;
            this.ListBookbtn.Location = new System.Drawing.Point(1257, 538);
            this.ListBookbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBookbtn.Name = "ListBookbtn";
            this.ListBookbtn.Size = new System.Drawing.Size(126, 56);
            this.ListBookbtn.TabIndex = 25;
            this.ListBookbtn.Text = "신청목록";
            this.ListBookbtn.UseVisualStyleBackColor = false;
            this.ListBookbtn.Click += new System.EventHandler(this.ListBookbtn_Click);
            // 
            // PutBookbtn
            // 
            this.PutBookbtn.BackColor = System.Drawing.Color.LightGray;
            this.PutBookbtn.Location = new System.Drawing.Point(1120, 475);
            this.PutBookbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PutBookbtn.Name = "PutBookbtn";
            this.PutBookbtn.Size = new System.Drawing.Size(126, 56);
            this.PutBookbtn.TabIndex = 24;
            this.PutBookbtn.Text = "도서등록";
            this.PutBookbtn.UseVisualStyleBackColor = false;
            this.PutBookbtn.Click += new System.EventHandler(this.PutBookbtn_Click);
            // 
            // DelBookbtn
            // 
            this.DelBookbtn.BackColor = System.Drawing.Color.LightGray;
            this.DelBookbtn.Location = new System.Drawing.Point(1257, 475);
            this.DelBookbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelBookbtn.Name = "DelBookbtn";
            this.DelBookbtn.Size = new System.Drawing.Size(126, 56);
            this.DelBookbtn.TabIndex = 23;
            this.DelBookbtn.Text = "도서삭제";
            this.DelBookbtn.UseVisualStyleBackColor = false;
            this.DelBookbtn.Click += new System.EventHandler(this.DelBookbtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1017, 426);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "ISBN:";
            // 
            // MgrISBNtxt
            // 
            this.MgrISBNtxt.BackColor = System.Drawing.Color.White;
            this.MgrISBNtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrISBNtxt.Location = new System.Drawing.Point(1141, 420);
            this.MgrISBNtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MgrISBNtxt.Name = "MgrISBNtxt";
            this.MgrISBNtxt.Size = new System.Drawing.Size(245, 26);
            this.MgrISBNtxt.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1017, 351);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 16);
            this.label18.TabIndex = 20;
            this.label18.Text = "출판사:";
            // 
            // MgrPublishertxt
            // 
            this.MgrPublishertxt.BackColor = System.Drawing.Color.White;
            this.MgrPublishertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrPublishertxt.Location = new System.Drawing.Point(1141, 345);
            this.MgrPublishertxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MgrPublishertxt.Name = "MgrPublishertxt";
            this.MgrPublishertxt.Size = new System.Drawing.Size(245, 26);
            this.MgrPublishertxt.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1017, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "저자:";
            // 
            // MgrAuthortxt
            // 
            this.MgrAuthortxt.BackColor = System.Drawing.Color.White;
            this.MgrAuthortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrAuthortxt.Location = new System.Drawing.Point(1141, 270);
            this.MgrAuthortxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MgrAuthortxt.Name = "MgrAuthortxt";
            this.MgrAuthortxt.Size = new System.Drawing.Size(245, 26);
            this.MgrAuthortxt.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1017, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "발행일:";
            // 
            // MgrDatetxt
            // 
            this.MgrDatetxt.BackColor = System.Drawing.Color.White;
            this.MgrDatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrDatetxt.Location = new System.Drawing.Point(1141, 195);
            this.MgrDatetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MgrDatetxt.Name = "MgrDatetxt";
            this.MgrDatetxt.Size = new System.Drawing.Size(245, 26);
            this.MgrDatetxt.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1017, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "제목:";
            // 
            // MgrTitletxt
            // 
            this.MgrTitletxt.BackColor = System.Drawing.Color.White;
            this.MgrTitletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrTitletxt.Location = new System.Drawing.Point(1141, 120);
            this.MgrTitletxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MgrTitletxt.Name = "MgrTitletxt";
            this.MgrTitletxt.Size = new System.Drawing.Size(245, 26);
            this.MgrTitletxt.TabIndex = 11;
            // 
            // MgrGridView
            // 
            this.MgrGridView.AllowUserToAddRows = false;
            this.MgrGridView.AllowUserToDeleteRows = false;
            this.MgrGridView.AllowUserToResizeColumns = false;
            this.MgrGridView.AllowUserToResizeRows = false;
            this.MgrGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MgrGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MgrGridView.BackgroundColor = System.Drawing.Color.White;
            this.MgrGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MgrGridView.Location = new System.Drawing.Point(0, 0);
            this.MgrGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MgrGridView.Name = "MgrGridView";
            this.MgrGridView.ReadOnly = true;
            this.MgrGridView.RowHeadersWidth = 51;
            this.MgrGridView.RowTemplate.Height = 23;
            this.MgrGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MgrGridView.Size = new System.Drawing.Size(995, 638);
            this.MgrGridView.TabIndex = 2;
            this.MgrGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MgrGridView_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1445, 851);
            this.Controls.Add(this.Loginpnl);
            this.Controls.Add(this.Verlbl);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Joinlbl);
            this.Controls.Add(this.Findlbl);
            this.Controls.Add(this.FindIDPasswordlbl);
            this.Controls.Add(this.PWtxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.MemberMenubtn);
            this.Controls.Add(this.BookMenubtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "메인화면";
            this.Loginpnl.ResumeLayout(false);
            this.Loginpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Seedptr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leafptr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Treeptr)).EndInit();
            this.User.ResumeLayout(false);
            this.UserData.ResumeLayout(false);
            this.UserData.PerformLayout();
            this.UserDataUpdatepnl.ResumeLayout(false);
            this.UserDataUpdatepnl.PerformLayout();
            this.OrderBook.ResumeLayout(false);
            this.OrderBook.PerformLayout();
            this.MgrOrder.ResumeLayout(false);
            this.Order.ResumeLayout(false);
            this.OrderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Sucession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.UserRank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Book.ResumeLayout(false);
            this.Findbookpage.ResumeLayout(false);
            this.Findbookpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindGridView)).EndInit();
            this.Returnbookpage.ResumeLayout(false);
            this.Returnbookpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RtnGridView)).EndInit();
            this.Mgrbookpage.ResumeLayout(false);
            this.Mgrbookpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MgrGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BookMenubtn;
        private System.Windows.Forms.Button MemberMenubtn;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox PWtxt;
        private System.Windows.Forms.Label FindIDPasswordlbl;
        private System.Windows.Forms.LinkLabel Findlbl;
        private System.Windows.Forms.LinkLabel Joinlbl;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label Verlbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Loginpnl;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Ranklbl;
        private System.Windows.Forms.PictureBox Treeptr;
        private System.Windows.Forms.Label Nimlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TabControl Book;
        private System.Windows.Forms.TabPage Findbookpage;
        private System.Windows.Forms.TabPage Returnbookpage;
        private System.Windows.Forms.TabPage Mgrbookpage;
        private System.Windows.Forms.Button SrchBookbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SrchPublishertxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Srchauthortxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SrchISBNtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SrchTitletxt;
        private System.Windows.Forms.DataGridView FindGridView;
        private System.Windows.Forms.DataGridView RtnGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RtnDatetxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RtnPublishertxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RtnAuthortxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RtnTitletxt;
        private System.Windows.Forms.Button Longbtn;
        private System.Windows.Forms.Button Rtnbtn;
        private System.Windows.Forms.DataGridView MgrGridView;
        private System.Windows.Forms.Button ListBookbtn;
        private System.Windows.Forms.Button PutBookbtn;
        private System.Windows.Forms.Button DelBookbtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox MgrISBNtxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox MgrPublishertxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MgrAuthortxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MgrDatetxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MgrTitletxt;
        private System.Windows.Forms.TabControl User;
        private System.Windows.Forms.TabPage UserData;
        private System.Windows.Forms.TabPage OrderBook;
        private System.Windows.Forms.Button Orderbtn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox OrderDatetxt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox OrderPublishertxt;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox OrderAuthortxt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox OrderTitletxt;
        private System.Windows.Forms.TextBox CheckPWtxt;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel UserDataUpdatepnl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox UpdatePW2txt;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox UpdatePW1txt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox EmailCbx;
        private System.Windows.Forms.Button UserDelbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button Googlebtn;
        private System.Windows.Forms.TabPage MgrOrder;
        private System.Windows.Forms.TabControl Order;
        private System.Windows.Forms.TabPage OrderList;
        private System.Windows.Forms.Button BookPutbtn;
        private System.Windows.Forms.Button ListDelbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Sucession;
        private System.Windows.Forms.TabPage UserRank;
        private System.Windows.Forms.Button KickOkbtn;
        private System.Windows.Forms.Button kickNobtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button RankDown;
        private System.Windows.Forms.Button RankUpbtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button rntBookBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox Leafptr;
        private System.Windows.Forms.PictureBox Seedptr;
        private System.Windows.Forms.TextBox Teltxt;
        private System.Windows.Forms.TextBox SrchDatetxt;
        private System.Windows.Forms.Label Logintmr;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button extTimerbtn;
    }
}

