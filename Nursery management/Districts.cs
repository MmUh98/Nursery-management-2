using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nursery_management
{
    public partial class DistrictsForm1 : Form
    {
        public DistrictsForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Orakzai_button_Click(object sender, EventArgs e)
        {

        }

        private void NorthWaziristan_button_Click(object sender, EventArgs e)
        {

        }

        private void DistrictsForm1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Area_and_FNFs af = new Area_and_FNFs();
            af.Show();

        }

        private void Abbottabad_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            FNF_Abbottabad fa = new FNF_Abbottabad();
            fa.Show();

        }
    }
}
