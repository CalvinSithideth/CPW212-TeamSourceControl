using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceControl
{
    public partial class FormAddFirearm : Form
    {
        public FormAddFirearm()
        {
            InitializeComponent();
        }

        private void btnAddFirearm_Click(object sender, EventArgs e)
        {
            Firearms f = new Firearms()
            {
                SerialNumber = txtSerialNumber.Text,
                Manufacturer = txtManufacturer.Text,
                ModelName = txtModel.Text,
                Caliber = txtCaliper.Text,
                Price = Convert.ToDecimal(txtPrice.Text)
            };

            try
            {
                FirearmDB.AddFirearm(f);
                MessageBox.Show("Firearm was added!");
                Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error", "There was an issue when trying to add to the DB");
            }
        }
    }
}
