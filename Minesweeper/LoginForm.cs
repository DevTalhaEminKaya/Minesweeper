using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            LevelForm levelForm = new LevelForm(gameForm);
            gameForm.name = txtUserName.Text;
            this.Hide();
            levelForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(projectDirectory, "Config.mswp");

            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("difficulty,rows,cols,mineCount,flags,time");
                    sw.WriteLine("Easy,10,10,10,10,120");
                    sw.WriteLine("Medium,12,12,15,15,120");
                    sw.WriteLine("Difficult,15,15,20,20,120");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIconSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
