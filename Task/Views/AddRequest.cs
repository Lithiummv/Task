using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Task.Models;

namespace Task.Views
{
    public partial class AddRequest : Form
    {
        List<Car> cars = new List<Car>();
        List<ErrorProvider> errorProviders;
        private Controller controller;

        public AddRequest()
        {
            InitializeComponent();
            controller = new Controller();
            errorProviders = new List<ErrorProvider>();

            using (TaskContext bd = new TaskContext())
            {
                cars = bd.Database.SqlQuery<Car>("SELECT * FROM Cars").ToList();
                carComboBox.Items.Clear();

                foreach (var car in cars)
                {
                    carComboBox.Items.Add(car.StateRegistrationNumber);
                }

                carComboBox.Refresh();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (errorProviders.Count == 0)
            {
                controller.AddRequest(Convert.ToDateTime(dateTextBox.Text), Convert.ToDateTime(timeTextBox.Text),
                    cars.Find(x => x.StateRegistrationNumber == carComboBox.Text), waybillNumberTextBox.Text);
                Close();
                MessageBox.Show("Данные добавлены.", "Добавить заявку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Некорректный ввод.", "Добавить заявку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
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

        private void ValidatingForEmptyString(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.Text == "")
            {
                errorProvider.SetError(comboBox, "Заполните поле.");
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

        private void dateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(dateTextBox, errorProvider1);
        }

        private void timeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(timeTextBox, errorProvider2);
        }

        private void carComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(carComboBox, errorProvider3);
        }

        private void waybillNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatingForEmptyString(waybillNumberTextBox, errorProvider4);
        }
    }
}
