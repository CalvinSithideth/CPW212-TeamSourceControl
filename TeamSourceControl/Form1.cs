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

        /// <summary>
        /// Upon the form load the list of firearms will be refreshed and displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllFirearms();
        }

        /// <summary>
        /// This method will contact the database and get all firearms that are registered in
        /// there and return the values in a list form to be displayed.
        /// </summary>
        private void GetAllFirearms()
        {
            List<Firearms> firearms = FirearmDB.GetFirearms();

            lstFirearms.DataSource = firearms;
            lstFirearms.DisplayMember = nameof(Firearms.Manufacturer);
        }

        /// <summary>
        /// Upon click this method will open up a new form 'frmAddFirearm'
        /// This form will be used everytime a new gun is entered into the DB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddFirearm addFirearm = new FrmAddFirearm();
            //Pulls up the new form after clicking on Add
            DialogResult result = addFirearm.ShowDialog();
            //This will refresh the firearm list box upon each new addition.
            GetAllFirearms();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Check that a firearm is selected and if it is open new form
            DisplayUpdateForm();
            GetAllFirearms();
        }

        private void DisplayUpdateForm()
        {
            Firearms selectedFirearm = lstFirearms.SelectedItem as Firearms;
            var updateForm = new FrmUpdateFirearm(selectedFirearm);

            //Opens the update form
            updateForm.ShowDialog();
        }
    }
}
