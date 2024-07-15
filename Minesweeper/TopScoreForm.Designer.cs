namespace Minesweeper
{
    partial class TopScoreForm
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            pnlTop = new Panel();
            btnIconSize = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 311);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(282, 127);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(240, 311);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(548, 127);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(240, 311);
            dataGridView3.TabIndex = 2;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Silver;
            pnlTop.Controls.Add(btnIconSize);
            pnlTop.Controls.Add(btnClose);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 40);
            pnlTop.TabIndex = 3;
            // 
            // btnIconSize
            // 
            btnIconSize.Dock = DockStyle.Right;
            btnIconSize.FlatAppearance.BorderSize = 0;
            btnIconSize.FlatStyle = FlatStyle.Flat;
            btnIconSize.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIconSize.ForeColor = Color.Black;
            btnIconSize.Location = new Point(720, 0);
            btnIconSize.Name = "btnIconSize";
            btnIconSize.Size = new Size(40, 40);
            btnIconSize.TabIndex = 2;
            btnIconSize.Text = "―";
            btnIconSize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(760, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(93, 70);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 4;
            label1.Text = "Easy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(354, 70);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 5;
            label2.Text = "Medium";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(613, 70);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 6;
            label3.Text = "Difficult";
            // 
            // TopScoreForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlTop);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TopScoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += TopScoreForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Panel pnlTop;
        private Button btnIconSize;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}