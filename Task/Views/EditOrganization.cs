using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Task.Models;

namespace Task.Views
{
    public partial class EditOrganization : Form
    {
        private Controller controller;
        private Organization organization;
        List<ErrorProvider> errorProviders;

        public EditOrganization(Organization organization)
        {
            InitializeComponent();
            this.organization = organization;
            controller = new Controller();
            errorProviders = new List<ErrorProvider>();
            nameOrganizationTextBox.Text = this.organization.NameOrganization;
            contractTextBox.Text = organization.ContractNumber;
            dateTextBox.Text = organization.ContractDate.ToString("dd.MM.yyyy");
        }

        private void addOrganizationButton_Click(object sender, EventArgs e)
        {
            if (errorProviders.Count == 0)
            {
                controller.EditOrganization(organization.OrganizationId, nameOrganizationTextBox.Text, contractTextBox.Text,
                    Convert.ToDateTime(dateTextBox.Text));
                Close();
                MessageBox.Show("Данные обновлены.", "Редактировать организацию", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Некорректный ввод.", "Редактировать организацию", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ValidatingForEmptyString(TextBox textBox, ErrorProvider errorProvider)
        {
            if (textBox.Text == "")
            {
                errorProvider.SetError(textBox, "Заполните поле.");
                errorProviders.Add(errorProvider);
            }
            else
            {
                errorProvider.Clear();
                errorProviders.Remove(errorProvider);
            }
        }

        private void ValidatingForEmptyString(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            char[] charsTextBox = textBox.Text.ToCharArray();
            foreach (char element in charsTextBox)
            {
                if (!char.IsDigit(element))
                {
                    errorProvider.SetError(textBox, "Заполните поле.");
                    errorProviders.Add(errorProvider);
                }
                else
                {
                    errorProvider.Clear();
                    errorProviders.Remove(errorProvider);
                }
            }
        }

        private void nameOrganizationTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(nameOrganizationTextBox, errorProvider1);
        }

        private void contractTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(contractTextBox, errorProvider2);
        }

        private void dateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(dateTextBox, errorProvider3);
        }
    }
}
