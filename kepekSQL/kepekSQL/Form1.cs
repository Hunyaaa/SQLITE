using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kepekSQL
{
    public partial class Form1 : Form
    {
        private string fileLocation = string.Empty;
        private bool isSucces = false;
        private int maxImageSize = 2097152;

        private string FileLocation
        {
            get { return fileLocation; }
            set
            {
                fileLocation = value;
            }
        }
        public Boolean GetSucces()
        {
            return isSucces;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BetöltBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Válaszd ki a betöltendő képet");
            openFileDialog1.Filter = "Select image (*.JpG; *.png; *.Gif) |* .JpG *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void adatbevitelBTN_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["imagefilename"].Value = képnév.Text + comboBox1.SelectedItem.ToString();
                }
            }

            if (dataGridView1.Rows.Count > 0)
            {
                Image img = pictureBox1.Image;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["ImageFileSizeBytes"].Value = img.Width * img.Height + " Kb";
                }
            }

            Random r = new Random();
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["ID"].Value = r.Next(100);
                }
            }
        }
    }
}
