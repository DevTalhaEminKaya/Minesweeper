namespace Minesweeper
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            btnIconSize = new Button();
            btnClose = new Button();
            lbl1 = new Label();
            txtUserName = new TextBox();
            lbl2 = new Label();
            lbl3 = new Label();
            btnOk = new Button();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Silver;
            pnlTop.Controls.Add(btnIconSize);
            pnlTop.Controls.Add(btnClose);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(450, 40);
            pnlTop.TabIndex = 1;
            // 
            // btnIconSize
            // 
            btnIconSize.Dock = DockStyle.Right;
            btnIconSize.FlatAppearance.BorderSize = 0;
            btnIconSize.FlatStyle = FlatStyle.Flat;
            btnIconSize.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIconSize.ForeColor = Color.Black;
            btnIconSize.Location = new Point(370, 0);
            btnIconSize.Name = "btnIconSize";
            btnIconSize.Size = new Size(40, 40);
            btnIconSize.TabIndex = 2;
            btnIconSize.Text = "―";
            btnIconSize.UseVisualStyleBackColor = true;
            btnIconSize.Click += btnIconSize_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(410, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Vivaldi", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(108, 100);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(235, 57);
            lbl1.TabIndex = 3;
            lbl1.Text = "Minesweeper";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.WhiteSmoke;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Location = new Point(75, 281);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(300, 16);
            txtUserName.TabIndex = 5;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl2
            // 
            lbl2.BackColor = Color.Black;
            lbl2.Location = new Point(75, 300);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(300, 3);
            lbl2.TabIndex = 6;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl3.Location = new Point(182, 260);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(86, 18);
            lbl3.TabIndex = 8;
            lbl3.Text = "User Name : ";
            // 
            // btnOk
            // 
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOk.Location = new Point(175, 397);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 40);
            btnOk.TabIndex = 10;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(450, 490);
            Controls.Add(btnOk);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(txtUserName);
            Controls.Add(lbl1);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Button btnIconSize;
        private Button btnClose;
        private Label lbl1;
        private TextBox txtUserName;
        private Label lbl2;
        private Label lbl3;
        private Button btnOk;
    }
}