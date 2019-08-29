using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllFirearms();
        }

        private void GetAllFirearms()
        {
            List<Firearms> firearms = FirearmDB.GetFirearms();

            lstFirearms.DataSource = firearms;
            lstFirearms.DisplayMember = nameof(Firearms.Manufacturer);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddFirearm addFirearm = new frmAddFirearm();
            //Pulls up the new form after clicking on Add
            DialogResult result = addFirearm.ShowDialog();
            //This will refresh the firearm list box upon each new addition.
            GetAllFirearms();
        }
    }
}
