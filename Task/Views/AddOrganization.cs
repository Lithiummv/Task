using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Task.Views
{
    public partial class AddOrganization : Form
    {
        private Controller controller;
        List<ErrorProvider> errorProviders;

        public AddOrganization()
        {
            InitializeComponent();
            controller = new Controller();
            errorProviders = new List<ErrorProvider>();
        }

        private void addOrganizationButton_Click(object sender, EventArgs e)
        {
            if (errorProviders.Count == 0)
            {
                controller.AddOrganization(nameOrganizationTextBox.Text, contractTextBox.Text,
                    Convert.ToDateTime(dateTextBox.Text));
                Close();
                MessageBox.Show("Данные добавлены.", "Добавить организацию", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Некорректный ввод.", "Добавить организацию", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ValidatingForDigit(MaskedTextBox textBox, ErrorProvider errorProvider)
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
            ValidatingForDigit(dateTextBox, errorProvider3);
        }
    }
}
