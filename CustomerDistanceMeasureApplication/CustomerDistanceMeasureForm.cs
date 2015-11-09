using CustomerDistanceMeasure;
using CustomerDistanceMeasure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDistanceMeasureApplication
{
    public partial class CustomerDistanceMeasureForm : Form
    {
        public CustomerDistanceMeasureForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dResult = ofdFileDialog.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    txtFilePath.Text = ofdFileDialog.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateDistance_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFilePath.Text))
                {
                    MessageBox.Show("You need to choose a file to continue", "File Not Chosen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<Customer> nearCustomerList = GetNearCustomers(File.ReadAllLines(txtFilePath.Text));
                dgvNearCustomers.DataSource = nearCustomerList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Customer> GetNearCustomers(string[] jsonList)
        {
            OfficeMeasure intercomMeasure = new OfficeMeasure(53.3381985, -6.2592576);
            intercomMeasure.InvitationRange = 100;

            return jsonList.Select(json => Customer.LoadCustomer(json)).Where(cust => intercomMeasure.isCustomerInRange(cust)).OrderBy(cust => cust.user_id).ToList();
        }
    }
}
