using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Task.Models;

namespace Task.Views
{
    public partial class AddCar : Form
    {
        private Controller controller;
        private Organization organization;
        List<ErrorProvider> errorProviders;

        public AddCar(Organization organization)
        {
            InitializeComponent();
            controller = new Controller();
            this.organization = organization;
            errorProviders = new List<ErrorProvider>();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            if (errorProviders.Count == 0)
            {
                controller.AddCar(carBrandTextBox.Text, carModelTextBox.Text,
                    stateRegistrationNumberTextBox.Text, Convert.ToDouble(bodyCapacityTextBox.Text), organization);
                Close();
                MessageBox.Show("Данные добавлены.", "Добавить автомобиль", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Некорректный ввод.", "Добавить автомобиль", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ValidatingForDigit(TextBox textBox, ErrorProvider errorProvider)
        {
            char[] charsTextBox = textBox.Text.ToCharArray();
            foreach (char element in charsTextBox)
            {
                if (!char.IsDigit(element) && element != ',')
                {
                    errorProvider.SetError(textBox, "Некорректный ввод.");
                    errorProviders.Add(errorProvider);
                }
                else
                {
                    errorProvider.Clear();
                    errorProviders.Remove(errorProvider);
                }
            }
        }

        private void carBrandTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(carBrandTextBox, errorProvider1);
        }

        private void carModelTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(carModelTextBox, errorProvider2);
        }

        private void stateRegistrationNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(stateRegistrationNumberTextBox, errorProvider3);
        }

        private void bodyCapacityTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(bodyCapacityTextBox, errorProvider4);
            ValidatingForDigit(bodyCapacityTextBox, errorProvider4);
        }
    }
}
