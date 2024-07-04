using Minesweeper.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Minesweeper
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        // -----------------------------------------------------------------------------------------

        private Button[,] buttons;
        private int[,] mines;
        private int rows;
        private int cols;
        private int mineCount;
        private int flags;
        private int time;

        public string name;
        public Difficulty difficulty;

        // -----------------------------------------------------------------------------------------

        private void btnToScore_Click(object sender, EventArgs e)
        {
            TopScoreForm topScoreForm = new TopScoreForm();
            topScoreForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIconSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelForm levelForm = new LevelForm(this);
            levelForm.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time--;
            lblTime.Text = $"Time : {time}";

            if (time <= 0)
            {
                timer.Enabled = false;

                DialogResult result = MessageBox.Show("Nice try, do you want to try again.", "Minesweeper", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LevelForm levelForm = new LevelForm(this);
                    levelForm.ShowDialog();
                }
                else if (result == DialogResult.No)
                {
                    this.Hide();
                    TopScoreForm topScoreForm = new TopScoreForm();
                    topScoreForm.difficulty = difficulty;
                    topScoreForm.Show();
                }
            }
        }

        // -----------------------------------------------------------------------------------------

        public void InitializeGame()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string configFilePath = Path.Combine(projectDirectory, "config.mswp");

            if (File.Exists(configFilePath))
            {
                using (var reader = new StreamReader(configFilePath))
                {
                    bool isThatOk = false;
                    while (!isThatOk)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values[0] == difficulty.ToString())
                        {
                            rows = Convert.ToInt32(values[1]);
                            cols = Convert.ToInt32(values[2]);
                            mineCount = Convert.ToInt32(values[3]);
                            flags = Convert.ToInt32(values[4]);
                            time = Convert.ToInt32(values[5]);

                            isThatOk = true;
                        }
                    }
                }
            }

            this.Size = new Size(cols * 40, ++rows * 40);

            lblDifficulty.Text = difficulty.ToString();

            buttons = new Button[rows, cols];
            mines = new int[rows, cols];

            Random rand = new Random();
            for (int i = 0; i < mineCount; i++)
            {
                int r, c;
                do
                {
                    r = rand.Next(rows);
                    c = rand.Next(cols);
                } while (mines[r, c] == 1);
                mines[r, c] = 1;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Button button = new Button();
                    button.Width = 40;
                    button.Height = 40;
                    button.Location = new Point(r * button.Height, c * button.Width);
                    button.Tag = new Point(r, c);
                    button.BackColor = Color.Green;
                    button.MouseUp += Button_MouseUp;
                    this.panel1.Controls.Add(button);
                    buttons[r, c] = button;
                }
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            Point p = (Point)button.Tag;
            if (e.Button == MouseButtons.Left && button.BackColor != Color.Red)
            {
                Reveal(p.X, p.Y);
            }
            else if (e.Button == MouseButtons.Right && flags > 0)
            {
                if (button.BackColor == Color.Green)
                {
                    button.BackColor = Color.Red;
                }
                else if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.Green;
                }
            }

            if (CheckWin())
            {
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string configFilePath = Path.Combine(projectDirectory, "TopList.csv");

                if (!File.Exists(configFilePath))
                {
                    File.Create(configFilePath);
                }

                MessageBox.Show("Congratulations, you won!");
                timer.Enabled = false;
            }
        }

        private void Reveal(int row, int col)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols)
                return;

            Button button = buttons[row, col];
            if (button.Enabled == false)
                return;

            button.Enabled = false;

            if (mines[row, col] == 1)
            {
                button.BackColor = Color.Black;
                timer.Enabled = false;

                DialogResult result = MessageBox.Show("Nice try, do you want to try again.", "Minesweeper", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    LevelForm levelForm = new LevelForm(this);
                    levelForm.Show();
                }
                else if (result == DialogResult.No)
                {
                    TopScoreForm topScoreForm = new TopScoreForm();
                    topScoreForm.difficulty = difficulty;
                    topScoreForm.Show();
                    this.Hide();
                }
                return;
            }

            int mineCount = CountMines(row, col);
            if (mineCount > 0)
            {
                button.Text = mineCount.ToString();
            }
            else
            {
                button.BackColor = Color.LightGray;

                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        Reveal(row + i, col + j);
                    }
                }
            }
        }

        private int CountMines(int row, int col)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int r = row + i;
                    int c = col + j;
                    if (r >= 0 && r < rows && c >= 0 && c < cols && mines[r, c] == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private bool CheckWin()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (mines[r, c] == 0 && buttons[r, c].Enabled)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
