namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpMenu = new GroupBox();
            grpOption = new GroupBox();
            lstOrder = new ListBox();
            groupBox1 = new GroupBox();
            lblTotal = new Label();
            btnOrder = new Button();
            btnInit = new Button();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpMenu.SuspendLayout();
            grpOption.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(38, 46);
            label1.Name = "label1";
            label1.Size = new Size(595, 86);
            label1.TabIndex = 4;
            label1.Text = "버거 주문 키오스크";
            label1.Click += label1_Click;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 16.125F);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(38, 49);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(185, 63);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 16.125F);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(47, 230);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(271, 63);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 16.125F);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(47, 433);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(228, 63);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(356, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(356, 433);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 174);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 13.875F);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(34, 77);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(202, 54);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 13.875F);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(34, 176);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(128, 54);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 13.875F);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(34, 271);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(215, 54);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 13.875F);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(34, 364);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(215, 54);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.FromArgb(255, 192, 255);
            grpMenu.Location = new Point(38, 147);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(571, 627);
            grpMenu.TabIndex = 2;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkPotato);
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCola);
            grpOption.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.FromArgb(255, 192, 255);
            grpOption.Location = new Point(686, 147);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(294, 466);
            grpOption.TabIndex = 3;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(23, 65);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(484, 274);
            lstOrder.TabIndex = 0;
            lstOrder.SelectedIndexChanged += lstOrder_SelectedIndexChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(lstOrder);
            groupBox1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.ForeColor = Color.FromArgb(255, 192, 255);
            groupBox1.Location = new Point(1087, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 466);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "주문 내역";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTotal.ForeColor = Color.Cyan;
            lblTotal.Location = new Point(23, 376);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(180, 59);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "총 금액:";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.IndianRed;
            btnOrder.Font = new Font("맑은 고딕", 14F, FontStyle.Bold);
            btnOrder.Location = new Point(1087, 580);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(245, 123);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.Chartreuse;
            btnInit.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnInit.Location = new Point(1369, 580);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(252, 123);
            btnInit.TabIndex = 1;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblMessage.ForeColor = Color.Cyan;
            lblMessage.Location = new Point(1110, 722);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(471, 45);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "⚠️ 메뉴를 먼저 선택해 주세요!";
            lblMessage.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1860, 786);
            Controls.Add(lblMessage);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(groupBox1);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private ListBox lstOrder;
        private GroupBox groupBox1;
        private Label lblTotal;
        private Button btnOrder;
        private Button btnInit;
        private Label lblMessage;
    }
}
