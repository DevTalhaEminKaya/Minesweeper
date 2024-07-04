namespace Minesweeper
{
    partial class LevelForm
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
            btnEasy = new Button();
            btnMedium = new Button();
            btnDifficult = new Button();
            SuspendLayout();
            // 
            // btnEasy
            // 
            btnEasy.FlatAppearance.BorderSize = 0;
            btnEasy.FlatStyle = FlatStyle.Flat;
            btnEasy.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEasy.Location = new Point(40, 92);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(120, 35);
            btnEasy.TabIndex = 1;
            btnEasy.Text = "Easy";
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnMedium
            // 
            btnMedium.FlatAppearance.BorderSize = 0;
            btnMedium.FlatStyle = FlatStyle.Flat;
            btnMedium.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnMedium.Location = new Point(40, 133);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(120, 35);
            btnMedium.TabIndex = 2;
            btnMedium.Text = "Medium";
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Click += btnMedium_Click;
            // 
            // btnDifficult
            // 
            btnDifficult.FlatAppearance.BorderSize = 0;
            btnDifficult.FlatStyle = FlatStyle.Flat;
            btnDifficult.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDifficult.Location = new Point(40, 174);
            btnDifficult.Name = "btnDifficult";
            btnDifficult.Size = new Size(120, 35);
            btnDifficult.TabIndex = 3;
            btnDifficult.Text = "Difficult";
            btnDifficult.UseVisualStyleBackColor = true;
            btnDifficult.Click += btnDifficult_Click;
            // 
            // LevelForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(200, 300);
            Controls.Add(btnDifficult);
            Controls.Add(btnMedium);
            Controls.Add(btnEasy);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LevelForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEasy;
        private Button btnMedium;
        private Button btnDifficult;
    }
}