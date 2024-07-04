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
    public partial class LevelForm : Form
    {
        private readonly GameForm _gameForm;

        public LevelForm(GameForm gameForm)
        {
            InitializeComponent();
            _gameForm = gameForm;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            _gameForm.difficulty = Enums.Difficulty.Easy;
            _gameForm.InitializeGame();
            _gameForm.Show();
            this.Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            _gameForm.difficulty = Enums.Difficulty.Medium;
            _gameForm.InitializeGame();
            _gameForm.Show();
            this.Close();

        }

        private void btnDifficult_Click(object sender, EventArgs e)
        {
            _gameForm.difficulty = Enums.Difficulty.Difficult;
            _gameForm.InitializeGame();
            _gameForm.Show();
            this.Close();
        }
    }
}
