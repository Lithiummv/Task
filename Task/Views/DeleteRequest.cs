using System;
using System.Windows.Forms;
using Task.Models;

namespace Task.Views
{
    public partial class DeleteRequest : Form
    {
        private Controller controller;
        private Request request;

        public DeleteRequest(Request request)
        {
            InitializeComponent();
            controller = new Controller();
            this.request = request;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            controller.DeleteRequest(request.RequestId);
            Close();
            MessageBox.Show("Данные удалены.", "Удалить заявку", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
