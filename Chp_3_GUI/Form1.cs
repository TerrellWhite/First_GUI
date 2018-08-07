using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chp_3_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int width, length;
            double price,roomCost;
            width = int.Parse(txtWidth.Text);
            length = int.Parse(txtLength.Text);
            price = Convert.ToDouble(txtPrice.Text);

            roomCost = length * width * price;

            lbRoomCost.Text = roomCost.ToString("c");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbRoomArea.Text = "";
            lbRoomCost.Text = "";
        
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            int width, length, area;
            width = int.Parse(txtWidth.Text);
            length = int.Parse(txtLength.Text);
            area = width * length;

            lbRoomArea.Text = area.ToString("n");
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
