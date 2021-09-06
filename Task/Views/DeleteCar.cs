using System;
using System.Windows.Forms;
using Task.Models;

namespace Task.Views
{
    public partial class DeleteCar : Form
    {
        private Controller controller;
        private Car car;

        public DeleteCar(Car car)
        {
            InitializeComponent();
            controller = new Controller();
            this.car = car;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            controller.DeleteCar(car.CarId);
            Close();
            MessageBox.Show("Данные удалены.", "Удалить автомобиль", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
