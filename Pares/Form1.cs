using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            double result = 0;

            x = Convert.ToDouble(txtX.Text );
            y = Convert.ToDouble(txtY.Text );

            if(x<0 && y< 0)
            {
                result = (x * x) + (y * y);
                txtResultado.Text = Convert.ToString(result);
            }
            if (x < 0 && y > 0)
            {
                result = y - x;
                txtResultado.Text = Convert.ToString(result);
            }
            if (x > 0 && y < 0)
            {
                result = x/y;
                txtResultado.Text = Convert.ToString(result);
            }
            if (x > 0 && y > 0)
            {
                if (x >  y)
                {
                    result = x / +y;
                    txtResultado.Text = Convert.ToString(result);
                }
                else
                {
                    result = x * x;
                    txtResultado.Text = Convert.ToString(result);
                }
                   
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
