namespace Minesweeper
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            pnlTop = new Panel();
            btnToScore = new Button();
            lblDifficulty = new Label();
            lblFlag = new Label();
            btnLevel = new Button();
            lblTime = new Label();
            btnIconSize = new Button();
            btnClose = new Button();
            timer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Silver;
            pnlTop.Controls.Add(btnToScore);
            pnlTop.Controls.Add(lblDifficulty);
            pnlTop.Controls.Add(lblFlag);
            pnlTop.Controls.Add(btnLevel);
            pnlTop.Controls.Add(lblTime);
            pnlTop.Controls.Add(btnIconSize);
            pnlTop.Controls.Add(btnClose);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(600, 40);
            pnlTop.TabIndex = 0;
            // 
            // btnToScore
            // 
            btnToScore.Dock = DockStyle.Right;
            btnToScore.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnToScore.ForeColor = Color.Black;
            btnToScore.Location = new Point(240, 0);
            btnToScore.Name = "btnToScore";
            btnToScore.Size = new Size(100, 40);
            btnToScore.TabIndex = 11;
            btnToScore.Text = "Top Score";
            btnToScore.UseVisualStyleBackColor = true;
            btnToScore.Click += btnToScore_Click;
            // 
            // lblDifficulty
            // 
            lblDifficulty.Dock = DockStyle.Right;
            lblDifficulty.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDifficulty.ForeColor = Color.Black;
            lblDifficulty.Location = new Point(340, 0);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(100, 40);
            lblDifficulty.TabIndex = 10;
            lblDifficulty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFlag
            // 
            lblFlag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblFlag.AutoSize = true;
            lblFlag.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFlag.ForeColor = Color.Black;
            lblFlag.Location = new Point(140, 10);
            lblFlag.Name = "lblFlag";
            lblFlag.Size = new Size(63, 23);
            lblFlag.TabIndex = 9;
            lblFlag.Text = "Flag : ";
            // 
            // btnLevel
            // 
            btnLevel.Dock = DockStyle.Right;
            btnLevel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLevel.ForeColor = Color.Black;
            btnLevel.Location = new Point(440, 0);
            btnLevel.Name = "btnLevel";
            btnLevel.Size = new Size(80, 40);
            btnLevel.TabIndex = 6;
            btnLevel.Text = "Level";
            btnLevel.UseVisualStyleBackColor = true;
            btnLevel.Click += btnLevel_Click;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(10, 10);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(67, 23);
            lblTime.TabIndex = 3;
            lblTime.Text = "Time : ";
            // 
            // btnIconSize
            // 
            btnIconSize.Dock = DockStyle.Right;
            btnIconSize.FlatAppearance.BorderSize = 0;
            btnIconSize.FlatStyle = FlatStyle.Flat;
            btnIconSize.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIconSize.ForeColor = Color.Black;
            btnIconSize.Location = new Point(520, 0);
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
            btnClose.Location = new Point(560, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 2;
            // 
            // GameForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(600, 640);
            Controls.Add(panel1);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnIconSize;
        private Button btnClose;
        private Label lblTime;
        private Button btnLevel;
        private System.Windows.Forms.Timer timer;
        private Label lblDifficulty;
        private Label lblFlag;
        private Panel panel1;
        private Button btnToScore;
    }
}