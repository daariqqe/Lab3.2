using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class fPlane : Form
    {
        public Plane ThePlane;
        public fPlane(Plane t)
        {
            ThePlane = t;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chbHasNotCombatSystem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePlane.Name = tbName.Text.Trim();
            ThePlane.MaxSpeed = int.Parse(tbMaxSpeed.Text.Trim());
            ThePlane.Length = int.Parse(tbLength.Text.Trim());
            ThePlane.Wingspan = int.Parse(tbWingspan.Text.Trim());
            ThePlane.Weight = int.Parse(tbWeight.Text.Trim());
            ThePlane.FuelCapacity = int.Parse(tbFuelCapacity.Text.Trim());

            DialogResult = DialogResult.OK;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fPlane_Load(object sender, EventArgs e)
        {
            if (ThePlane != null)
            {
                tbName.Text = ThePlane.Name;
                tbMaxSpeed.Text = ThePlane.MaxSpeed.ToString();
                tbLength.Text = ThePlane.Length.ToString();
                tbWingspan.Text = ThePlane.Wingspan.ToString();
                tbWeight.Text = ThePlane.Weight.ToString();
                tbFuelCapacity.Text = ThePlane.FuelCapacity.ToString();
                chbHasCombatSystem.Checked = ThePlane.HasCombatSystem;
                chbHasNotCombatSystem.Checked = !ThePlane.HasCombatSystem;
            }

        }
    }
}
