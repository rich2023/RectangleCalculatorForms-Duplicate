using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleCalculatorForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double length = Convert.ToDouble(txtLength.Text);
                double width = Convert.ToDouble(txtWidth.Text);

                Rectangle rectangle = new Rectangle();
                rectangle.SetLength(length);
                rectangle.SetWidth(width);

                double area = rectangle.CalculateArea();
                double perimeter = rectangle.CalculatePerimeter();

                lblArea.Text = $"Area: {area}";
                lblPerimeter.Text = $"Perimeter: {perimeter}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for length and width.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
