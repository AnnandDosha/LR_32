using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_32
{
    public partial class SquareCircle : Form
    {
        public SquareCircle()
        {
            InitializeComponent();
        }

        private void radiusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double radius = new double();
            radius = Convert.ToDouble(radiusNumericUpDown.Value);
            double result = Math.PI * radius * radius;
            resultLabel.Text = string.Format("{0: .00}", result);

        }
    }
}
