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

        }
    }
}
