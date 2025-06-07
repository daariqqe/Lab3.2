using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void btnAddPlane_Click(object sender, EventArgs e)
        {
            Plane plane = new Plane();
            fPlane f = new fPlane(plane);
            if (f.ShowDialog() == DialogResult.OK)
            {
                tbPlaneInfo.Text += 
                    string.Format("Назва літаку: {0}. Максимальна швидкість: {1} км/год. Довжина {2} м. " +
                    "Розмах крила {3} м. Маса {4} кг. Ємність бака {5} л. [ {6} ]\r\n",
                    plane.Name, plane.MaxSpeed, plane.Length, plane.Wingspan, plane.Weight, plane.FuelCapacity,
                    plane.HasCombatSystem ? "Оснащений бойовою системою" : "Без бойової системи");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Припинити роботу застосунку", "Припинити роботу",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
