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
    public partial class FormUpdateFirearm : Form
    {
        //Set a private field
        private Firearms existingFirearm;

        public FormUpdateFirearm(Firearms f = null)
        {
            InitializeComponent();
            existingFirearm = f;
            if (f != null)
            {
                Text = "Updating firearm : " + f.SerialNumber;
                //Populate existing firearm on the update form with main form
                txtUpdateSerialNum.Text = existingFirearm.SerialNumber;
                txtUpdateManufacturer.Text = existingFirearm.Manufacturer;
                txtUpdateModel.Text = existingFirearm.ModelName;
                txtUpdateCaliber.Text = existingFirearm.Caliber;
                txtUpdatePrice.Text = Convert.ToString(existingFirearm.Price);
            }

        }

        private void btnUpdateFirearm_Click(object sender, EventArgs e)
        {
            Firearms gun = new Firearms();

            try
            {
                //Keep the ID of the gun the same because we are UPDATING
                gun.FirearmID = existingFirearm.FirearmID;
                FirearmDB.UpdateFirearm(gun);
                MessageBox.Show("Firearm has been updated!");
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was an issue contacting the Database, please try agian");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.GetType().ToString());
            }
        }
    }
}
