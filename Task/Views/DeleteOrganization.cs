using System;
using System.Windows.Forms;
using Task.Models;

namespace Task.Views
{
    public partial class DeleteOrganization : Form
    {
        private Controller controller;
        private Organization organization;

        public DeleteOrganization(Organization organization)
        {
            InitializeComponent();
            controller = new Controller();
            this.organization = organization;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            controller.DeleteOrganization(organization.OrganizationId);
            Close();

            MessageBox.Show("Данные удалены.", "Удалить организацию", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
