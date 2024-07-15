using Minesweeper.Enums;
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
    public partial class TopScoreForm : Form
    {
        public TopScoreForm()
        {
            InitializeComponent();
        }

        // -----------------------------------------------------------------------------------------

        public Difficulty difficulty;

        private void TopScoreForm_Load(object sender, EventArgs e)
        {
            DataTable edt = new DataTable();
            DataTable mdt = new DataTable();
            DataTable ddt = new DataTable();

            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string configFilePath = Path.Combine(projectDirectory, "TopList.csv");

            bool isFirstLine = true;

            using (var reader = new StreamReader(configFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    switch (values[2])
                    {
                        case "Easy":
                            edt.Columns.Add("username", typeof(string));
                            edt.Columns.Add("time", typeof(int));
                            DataRow eRow = edt.NewRow();
                            eRow["username"] = values[0];
                            eRow["time"] = values[1];
                            edt.Rows.Add(eRow);
                            break;
                        case "Medium":
                            mdt.Columns.Add("username", typeof(string));
                            mdt.Columns.Add("time", typeof(int));
                            DataRow mRow = mdt.NewRow();
                            mRow["username"] = values[0];
                            mRow["time"] = values[1];
                            mdt.Rows.Add(mRow);
                            break;
                        case "Difficult":
                            ddt.Columns.Add("username", typeof(string));
                            ddt.Columns.Add("time", typeof(int));
                            DataRow dRow = ddt.NewRow();
                            dRow["username"] = values[0];
                            dRow["time"] = values[1];
                            ddt.Rows.Add(dRow);
                            break;
                        default:
                            break;
                    }
                }
            }

            dataGridView1.DataSource = edt;
            dataGridView2.DataSource = mdt;
            dataGridView3.DataSource = ddt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -----------------------------------------------------------------------------------------


    }
}
