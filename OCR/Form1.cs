using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap image = new Bitmap("moti_ocr.png");
        private void selectfiles(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = new Bitmap(file.FileName);
                pictureBox1.Image = image;
            }


        }

        private void extractText(object sender, EventArgs e)
        {
            var ocr = new AutoOcr();
            result_text.Text=ocr.Read(image).ToString();
        }
    }
}
