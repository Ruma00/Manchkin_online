using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manchkin_online
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        Image[] DataSingleList = new Image[8];

        private void Init()
        {
            dataGridView1.RowCount = 4;
            dataGridView1.MultiSelect = true;
            pictureBox1.Image = Image.FromFile("Source//test.png");
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewCell[] cell = new DataGridViewCell[8];
            //dataGridView1[0, 2].Value = Image.FromFile("Source//test2.jpg");
        }
    }
}
