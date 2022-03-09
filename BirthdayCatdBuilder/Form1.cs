using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BirthdayCatdBuilder
{
    public partial class Form1 : Form
    {
        const string searchPattern = "*.png|*.jpg|*.jpeg|*.bmp";
        List<string> backgroundList = new List<string>();
        int currentImg = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getBackgroundList();
            foreach (var s in backgroundList)
            {
            }
            ShowImage();
        }
        private void getBackgroundList()
        {
            foreach (string pattern in searchPattern.Split("|"))
            {
                backgroundList.AddRange(Directory.GetFiles(@"..\..\..\..\..\background", pattern));
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (++currentImg >= backgroundList.Count)
            {
                currentImg = 0;
            }
            ShowImage();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (--currentImg <= -1)
            {
                currentImg = backgroundList.Count - 1;
            }
            ShowImage();
        }
        private void ShowImage()
        {
            pic_display.BackgroundImage = new Bitmap(backgroundList[currentImg]);
        }
    }
}
