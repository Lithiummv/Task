using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Task.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace Task.Views
{
    public partial class Form1 : Form
    {
        private List<Organization> organizations;
        private List<Car> cars;
        private List<Tariff> tariffs;
        private List<Request> requests;
        private Controller controller;
        private TaskContext bd;
        private Tariff tariff;
        private List<string> months;
        private List<string> months1;
        DataGridViewComboBoxCell comboBoxColumn;
        private string path1;
        private string path2;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
            bd = new TaskContext();
            //bd.Cars.RemoveRange(bd.Cars);
            //bd.Organizations.RemoveRange(bd.Organizations);
            //bd.Requests.RemoveRange(bd.Requests);
            /*
            Tariff tariff1 = new Tariff
            {
                TariffOrder = 2,
                VATOrder = 20
            };
            bd.Tariffs.Add(tariff1);*/
            //bd.SaveChanges();
            tariff = bd.Tariffs.Find(1);
            tariffs = bd.Database.SqlQuery<Tariff>("SELECT * FROM Tariffs").ToList();
            requests = bd.Database.SqlQuery<Request>("SELECT * FROM Requests").ToList();
            tariffTextBox.Text = tariffs[0].TariffOrder.ToString();
            vatTextBox.Text = tariffs[0].VATOrder.ToString();
            UpdateFormOrganization();
            CultureInfo culInf = new CultureInfo("ru-RU");
            System.Threading.Thread.CurrentThread.CurrentCulture = culInf;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culInf;
            months = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();
            months1 = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();
            monthComboBox.DataSource = months;
            month1ComboBox.DataSource = months1;
            comboBoxColumn = new DataGridViewComboBoxCell
            {
                DataSource = carBindingSource1
            };
        }

        private void organizationComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Organization organization = organizations.Find(x => x.NameOrganization == organizationComboBox.Text);
            contractLabel.Text = organization.ContractNumber;
            dateLabel.Text = organization.ContractDate.ToString("dd.MM.yyyy");
            UpdateDataGridView(organization);
        }
        
        private void UpdateDataGridView(Organization organization)
        {
            using (TaskContext context = new TaskContext())
            {
                List<Car> cars = context.Organizations.Find(organization.OrganizationId).Cars.ToList();
                carBindingSource.DataSource = cars;
            }
        }

        private void UpdateFormOrganization()
        {
            organizations = bd.Database.SqlQuery<Organization>("SELECT * FROM Organizations").ToList();
            cars = bd.Database.SqlQuery<Car>("SELECT * FROM Cars").ToList();
            organizationComboBox.Items.Clear();

            foreach (var organization in organizations)
            {
                organizationComboBox.Items.Add(organization.NameOrganization);
            }

            organizationComboBox.Refresh();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrganization addOrganization = new AddOrganization();
            addOrganization.ShowDialog();
            UpdateFormOrganization();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Organization organization = organizations.Find(x => x.NameOrganization == organizationComboBox.Text);
            EditOrganization editOrganization = new EditOrganization(organization);
            editOrganization.ShowDialog();
            UpdateFormOrganization();
            organizationComboBox.SelectedItem = organizations.Find(x => x.OrganizationId == organization.OrganizationId).NameOrganization;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteOrganization deleteOrganization =
                new DeleteOrganization(organizations.Find(x => x.NameOrganization == organizationComboBox.Text));
            deleteOrganization.ShowDialog();
            UpdateFormOrganization();
            organizationComboBox.Text = "";
            contractLabel.Text = "";
            dateLabel.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            if (organizationComboBox.Text != "")
            {
                AddCar addCar = new AddCar(organizations.Find(x => x.NameOrganization == organizationComboBox.Text));
                addCar.ShowDialog();
                UpdateDataGridView(organizations.Find(x => x.NameOrganization == organizationComboBox.Text));
            }
            else
            {
                MessageBox.Show("Выберите организацию.", "Добавить автомобиль", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int id = Convert.ToInt32(dataGridView1[4, e.RowIndex].Value.ToString());
                controller.EditCar(id, dataGridView1[0, e.RowIndex].Value.ToString(),
                    dataGridView1[1, e.RowIndex].Value.ToString(),
                    dataGridView1[2, e.RowIndex].Value.ToString(),
                    Convert.ToDouble(dataGridView1[3, e.RowIndex].Value.ToString()));
            }
            else
            {
                UpdateDataGridView(organizations.Find(x => x.NameOrganization == organizationComboBox.Text));
                MessageBox.Show("Некорректный ввод.", "Редактировать автомобиль", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некорректный ввод.", "Редактировать автомобиль", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateDataGridView(organizations.Find(x => x.NameOrganization == organizationComboBox.Text));
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DeleteCar deleteCar = new DeleteCar(bd.Cars.Find(Convert.ToInt32(dataGridView1[4, e.Row.Index].Value)));
            deleteCar.ShowDialog();
        }

        private void addRequestButton_Click(object sender, EventArgs e)
        {
            AddRequest addRequest = new AddRequest();
            addRequest.ShowDialog();
            UpdateDataGridView2();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                controller.EditRequest(Convert.ToInt32(dataGridView2[0, e.RowIndex].Value),
                    Convert.ToDateTime(dataGridView2[1, e.RowIndex].Value),
                    Convert.ToDateTime(dataGridView2[2, e.RowIndex].Value),
                    cars.Find(x => x.StateRegistrationNumber == dataGridView2[7, e.RowIndex].Value.ToString()),
                    dataGridView2[3, e.RowIndex].Value.ToString());
                UpdateDataGridView2();
            }
            else
            {
                UpdateDataGridView2();
                MessageBox.Show("Некорректный ввод.", "Редактировать заявку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некорректный ввод.", "Редактировать заявку", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateDataGridView2();
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DeleteRequest deleteRequest =
                new DeleteRequest(bd.Requests.Find(Convert.ToInt32(dataGridView2[0, e.Row.Index].Value)));
            deleteRequest.ShowDialog();
        }

        private void UpdateCarsComboBox()
        {
            using (TaskContext context = new TaskContext())
            {
                List<Car> cars = bd.Database.SqlQuery<Car>("SELECT * FROM Cars").ToList();
                List<string> numbers = new List<string>();

                foreach (Car car in cars)
                {
                    numbers.Add(car.StateRegistrationNumber);
                }

                carBindingSource1.DataSource = numbers;
            }
        }

        private void tariffTextBox_Leave(object sender, EventArgs e)
        {
            if (tariffTextBox.Text != "")
            {
                tariff.TariffOrder = Convert.ToDouble(tariffTextBox.Text);
                bd.Entry(tariff).State = EntityState.Modified;
                bd.SaveChanges();
            }
            else
            {
                tariffTextBox.Text = tariffs[0].TariffOrder.ToString();
                MessageBox.Show("Некорректный ввод.", "Редактировать тариф", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vatTextBox_Leave(object sender, EventArgs e)
        {
            if (vatTextBox.Text != "")
            {
                tariff.VATOrder = Convert.ToDouble(vatTextBox.Text);
                bd.Entry(tariff).State = EntityState.Modified;
                bd.SaveChanges();
            }
            else
            {
                vatTextBox.Text = tariffs[0].VATOrder.ToString();
                MessageBox.Show("Некорректный ввод.", "Редактировать НДС", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void month1ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateDataGridView2();
        }

        public void UpdateDataGridView2()
        {
            using (TaskContext context = new TaskContext())
            {
                UpdateCarsComboBox();
                List<Heeelp> heeelps = new List<Heeelp>();
                int number = months.IndexOf(months.Find(x => x.ToString() == month1ComboBox.Text)) + 1;
                DateTime fromDateTime = new DateTime(DateTime.Now.Year, number, 1);
                DateTime toDateTime = new DateTime();

                if (number == 12)
                {
                    toDateTime = new DateTime(DateTime.Now.Year + 1, 1, 1);
                }
                else
                {
                    toDateTime = new DateTime(DateTime.Now.Year, number + 1, 1);
                }

                List<Request> requests = context.Database.SqlQuery<Request>("SELECT * FROM Requests").ToList();
                requests = requests.FindAll(x => x.DateRequest >= fromDateTime && x.DateRequest < toDateTime);

                foreach (var request in requests)
                {
                    Car car = context.Cars.Find(request.CarId);
                    Heeelp heeelp = new Heeelp
                    {
                        RequestId = request.RequestId,
                        DateRequest = request.DateRequest,
                        TimeRequest = request.TimeRequest,
                        WaybillNumber = request.WaybillNumber,
                        CarId = request.CarId,
                        Car = car,
                        CarBrand = car.CarBrand + car.CarModel,
                        StateRegistrationNumber = car.StateRegistrationNumber,
                        BodyCapacity = car.BodyCapacity
                    };
                    heeelps.Add(heeelp);
                }

                requestBindingSource.DataSource = heeelps;
                dataGridView2.Columns["requestIdDataGridViewTextBoxColumn"].Visible = false;
            }
        }

        private void toExcelButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            path1 = openFileDialog1.FileName;
            using (TaskContext context = new TaskContext())
            {
                List<Organization> organizations =
                    bd.Database.SqlQuery<Organization>("SELECT * FROM Organizations").ToList();
                List<Car> cars = bd.Database.SqlQuery<Car>("SELECT * FROM Cars").ToList();
                List<Request> requests = bd.Database.SqlQuery<Request>("SELECT * FROM Requests").ToList();

                Excel.Application ex = new Excel.Application { Visible = false };
                Excel.Workbook receptionWorkbook = ex.Workbooks.Open(path1, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                Excel.Sheets receptionSheets = receptionWorkbook.Sheets;
                Excel.Worksheet receptionWorksheet = receptionSheets.Add();
                receptionWorksheet.Name = monthComboBox.Text + " " + DateTime.Now.Year;
                receptionWorksheet.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                receptionWorksheet.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                Excel.Range range = receptionWorksheet.Range[receptionWorksheet.Cells[1, 1], receptionWorksheet.Cells[2, 1]].Cells;
                range.Merge(Type.Missing);
                range.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Borders.Weight = Excel.XlBorderWeight.xlMedium;
                receptionWorksheet.Cells[1, 1] = "Дата";
                int number = months.IndexOf(months.Find(x => x.ToString() == monthComboBox.Text)) + 1;
                DateTime fromDateTime = new DateTime(DateTime.Now.Year, number, 1);
                DateTime toDateTime = new DateTime();

                if (number == 12)
                {
                    toDateTime = new DateTime(DateTime.Now.Year + 1, 1, 1);
                }
                else
                {
                    toDateTime = new DateTime(DateTime.Now.Year, number + 1, 1);
                }

                requests = requests.FindAll(x => x.DateRequest >= fromDateTime && x.DateRequest < toDateTime);
                int k = DateTime.DaysInMonth(DateTime.Now.Year, number);
                int i = 2;
                double[] totalVolumeByDate = new double[31];
                int[] totalCountByDate = new int[31];

                foreach (Organization organization in organizations)
                {
                    double totalVolume = 0;
                    int totalCount = 0;

                    Excel.Range range1 = receptionWorksheet
                        .Range[receptionWorksheet.Cells[1, i++], receptionWorksheet.Cells[1, i++]].Cells;
                    range1.Merge(Type.Missing);
                    range1.WrapText = true;
                    range1.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                    range1.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    range1.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                    range1.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                    range1.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                    receptionWorksheet.Cells[1, i - 2] = organization.NameOrganization;

                    Excel.Range range2 = receptionWorksheet.Range[receptionWorksheet.Cells[2, i - 2], receptionWorksheet.Cells[2, i - 1]].Cells;
                    range2.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                    range2.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    range2.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                    range2.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                    range2.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;
                    receptionWorksheet.Cells[2, i - 2] = "куб. м.";
                    receptionWorksheet.Cells[2, i - 1] = "ед. тех.";

                    for (int j = 1; j < k + 1; j++)
                    {
                        List<Request> requestsByDate = new List<Request>();
                        double volumeSnow = 0;
                        DateTime dateTime = new DateTime(DateTime.Now.Year, number, j);

                        foreach (Car car in cars.FindAll(x => x.OrganizationId == organization.OrganizationId))
                        {
                            requestsByDate.AddRange(requests.FindAll(x => x.CarId == car.CarId).FindAll(y => y.DateRequest == dateTime));
                        }

                        foreach (Request request in requestsByDate)
                        {
                            volumeSnow += cars.Find(x => x.CarId == request.CarId).BodyCapacity;
                            totalVolume += cars.Find(x => x.CarId == request.CarId).BodyCapacity;
                        }

                        receptionWorksheet.Cells[j + 2, 1] = dateTime.ToString("dd.MM.yyyy");
                        receptionWorksheet.Cells[j + 2, i - 2] = volumeSnow;
                        receptionWorksheet.Cells[j + 2, i - 1] = requestsByDate.Count();
                        totalCount += requestsByDate.Count();
                        totalCountByDate[j - 1] += requestsByDate.Count();
                        totalVolumeByDate[j - 1] += volumeSnow;
                    }

                    Excel.Range range6 = receptionWorksheet.Range[receptionWorksheet.Cells[3, i - 2], receptionWorksheet.Cells[k + 2, i - 2]].Cells;
                    range6.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                    range6.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    Excel.Range range7 = receptionWorksheet.Range[receptionWorksheet.Cells[3, i - 1], receptionWorksheet.Cells[k + 2, i - 1]].Cells;
                    range7.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                    range7.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    range7.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;

                    Excel.Range range12 = receptionWorksheet.Range[receptionWorksheet.Cells[k + 3, 1], receptionWorksheet.Cells[k + 3, 1]].Cells;
                    range12.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                    range12.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    range12.Borders.Weight = Excel.XlBorderWeight.xlMedium;
                    receptionWorksheet.Cells[k + 3, 1] = "ИТОГО";

                    Excel.Range range10 = receptionWorksheet.Range[receptionWorksheet.Cells[k + 3, i - 2], receptionWorksheet.Cells[k + 3, i - 1]].Cells;
                    range10.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                    range10.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    range10.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                    range10.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;
                    receptionWorksheet.Cells[k + 3, i - 2] = totalVolume;
                    receptionWorksheet.Cells[k + 3, i - 1] = totalCount;
                }

                Excel.Range range3 = receptionWorksheet
                        .Range[receptionWorksheet.Cells[1, i++], receptionWorksheet.Cells[1, i++]].Cells;
                range3.Merge(Type.Missing);
                range3.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                range3.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                range3.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                range3.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                range3.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                receptionWorksheet.Cells[1, i - 2] = "ВСЕГО";

                Excel.Range range4 = receptionWorksheet
                        .Range[receptionWorksheet.Cells[2, i - 2], receptionWorksheet.Cells[2, i - 1]].Cells;
                range4.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                range4.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                range4.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                range4.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                range4.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;
                receptionWorksheet.Cells[2, i - 2] = "куб. м.";
                receptionWorksheet.Cells[2, i - 1] = "ед. тех.";

                double totalVolumeSnow = 0;
                int totalCountCars = 0;

                for (int j = 0; j < k; j++)
                {
                    receptionWorksheet.Cells[j + 3, i - 2] = totalVolumeByDate[j];
                    receptionWorksheet.Cells[j + 3, i - 1] = totalCountByDate[j];
                    totalVolumeSnow += totalVolumeByDate[j];
                    totalCountCars += totalCountByDate[j];
                }

                Excel.Range range8 = receptionWorksheet
                        .Range[receptionWorksheet.Cells[3, i - 2], receptionWorksheet.Cells[k + 2, i - 2]].Cells;
                range8.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                range8.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                Excel.Range range9 = receptionWorksheet
                        .Range[receptionWorksheet.Cells[3, i - 1], receptionWorksheet.Cells[k + 2, i - 1]].Cells;
                range9.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                range9.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                range9.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;

                Excel.Range range11 = receptionWorksheet
                        .Range[receptionWorksheet.Cells[k + 3, i - 2], receptionWorksheet.Cells[k + 3, i - 1]].Cells;
                range11.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                range11.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                range11.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                range11.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;
                receptionWorksheet.Cells[k + 3, i - 2] = totalVolumeSnow;
                receptionWorksheet.Cells[k + 3, i - 1] = totalCountCars;

                Excel.Range range5 = receptionWorksheet
                        .Range[receptionWorksheet.Cells[3, 1], receptionWorksheet.Cells[k + 2, 1]].Cells;
                range5.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                range5.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                range5.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                range5.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                range5.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                Excel.Range range13 = receptionWorksheet.UsedRange;
                range13.Columns.AutoFit();

                receptionWorkbook.Save();
                receptionWorkbook.Close();
                ex.Quit();
            }
            Excel.Application excel = new Excel.Application { Visible = true };
            Excel.Workbook workbook = excel.Workbooks.Open(path1);
        }

        private void registryToExcelButton_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            path2 = openFileDialog2.FileName;
            using (TaskContext context = new TaskContext())
            {
                List<Organization> organizations =
                        context.Database.SqlQuery<Organization>("SELECT * FROM Organizations").ToList();
                List<Car> cars = context.Database.SqlQuery<Car>("SELECT * FROM Cars").ToList();
                List<Request> requests = context.Database.SqlQuery<Request>("SELECT * FROM Requests").ToList();

                Excel.Application ex = new Excel.Application { Visible = false };
                Excel.Workbook registryWorkbook = ex.Workbooks.Open(path2, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                Excel.Sheets registrySheets = registryWorkbook.Sheets;
                Excel.Worksheet registryWorksheet = registrySheets.Add();
                registryWorksheet.Name = monthComboBox.Text + DateTime.Now.Year;
                registryWorksheet.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                registryWorksheet.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                for (int i = 1; i < 5; i++)
                {
                    Excel.Range newCellRange = registryWorksheet
                            .Range[registryWorksheet.Cells[i, 1], registryWorksheet.Cells[i, 3]].Cells;
                    newCellRange.Merge(Type.Missing);
                    newCellRange = registryWorksheet
                            .Range[registryWorksheet.Cells[i, 4], registryWorksheet.Cells[i, 6]].Cells;
                    newCellRange.Merge(Type.Missing);
                    newCellRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                }

                for (int i = 5; i < 11; i++)
                {
                    Excel.Range newCellRange = registryWorksheet
                            .Range[registryWorksheet.Cells[i, 1], registryWorksheet.Cells[i, 6]].Cells;
                    newCellRange.Merge(Type.Missing);
                }

                registryWorksheet.Cells[1, 4] = "УТВЕРЖДАЮ";
                registryWorksheet.Cells[2, 4] = "Начальника производства \"Минскчиствод\"";
                registryWorksheet.Cells[3, 4] = "А.В. Герасименчик";
                registryWorksheet.Cells[4, 4] = "\"____\"__________ 2021 г.";
                registryWorksheet.Cells[6, 1] = "РЕЕСТР";
                registryWorksheet.Cells[7, 1] = "актов выполненных работ по оказанию услуг сторонним организациям";
                registryWorksheet.Cells[8, 1] = "по приему и плавлению снега на снегоплавном пункте";
                registryWorksheet.Cells[9, 1] = "участка НС №3 производства \"Минскчиствод\" в марте 2021 года";
                registryWorksheet.Cells[11, 1] = "№ п/п";
                registryWorksheet.Cells[11, 2] = "Наименование организации";
                registryWorksheet.Cells[11, 3] = "Договор (№, дата)";
                registryWorksheet.Cells[11, 4] = "Стоимость услуг, руб.";
                registryWorksheet.Cells[11, 5] = "НДС, руб.";
                registryWorksheet.Cells[11, 6] = "Всего, руб.";
                registryWorksheet.Cells[11, 8] = "Машины";
                registryWorksheet.Cells[11, 9] = "Снег";
                registryWorksheet.Cells[11, 10] = "Вода";
                Excel.Range range1 = registryWorksheet
                            .Range[registryWorksheet.Cells[11, 1], registryWorksheet.Cells[11, 6]].Cells;
                range1.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                range1.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                range1.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                range1.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                range1.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                range1.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                int number = months.IndexOf(months.Find(x => x.ToString() == monthComboBox.Text)) + 1;
                DateTime fromDateTime = new DateTime(DateTime.Now.Year, number, 1);
                DateTime toDateTime = new DateTime();

                if (number == 12)
                {
                    toDateTime = new DateTime(DateTime.Now.Year + 1, 1, 1);
                }
                else
                {
                    toDateTime = new DateTime(DateTime.Now.Year, number + 1, 1);
                }

                requests = requests.FindAll(x => x.DateRequest >= fromDateTime && x.DateRequest < toDateTime);
                List<Organization> organizationsUnique = new List<Organization>();
                List<Car> carsByMonth = new List<Car>();

                foreach (Request request in requests)
                {
                    carsByMonth.Add(cars.Find(x => x.CarId == request.CarId));
                    organizationsUnique.Add(organizations.Find(y => y.OrganizationId == cars.Find(x => x.CarId == request.CarId).OrganizationId));
                }

                organizationsUnique = organizationsUnique.Distinct().ToList();
                int k = 1;
                double totalTariff = 0;
                double totalVAT = 0;
                double totalTariffPlusVAT = 0;
                int totalCars = 0;
                double totalSnow = 0;
                double totalWater = 0;

                foreach (Organization organization in organizationsUnique)
                {
                    registryWorksheet.Cells[k + 11, 1] = k;
                    registryWorksheet.Cells[k + 11, 2] = organization.NameOrganization;
                    registryWorksheet.Cells[k + 11, 3] = "№ " + organization.ContractNumber + " от " + organization.ContractDate.ToString("dd.MM.yyyy");
                    List<Car> carsByOrganization = new List<Car>();
                    carsByOrganization.AddRange(carsByMonth.FindAll(x => x.OrganizationId == organization.OrganizationId));
                    registryWorksheet.Cells[k + 11, 8] = carsByOrganization.Count();
                    double totalVolumeSnow = 0;

                    foreach (Car car in carsByOrganization)
                    {
                        totalVolumeSnow += car.BodyCapacity;
                    }

                    registryWorksheet.Cells[k + 11, 9] = totalVolumeSnow;
                    double totalVolumeWater = totalVolumeSnow / 2;
                    registryWorksheet.Cells[k + 11, 10] = totalVolumeWater;
                    double tariff = totalVolumeSnow * tariffs[0].TariffOrder;
                    registryWorksheet.Cells[k + 11, 4] = tariff;
                    double vat = tariff * tariffs[0].VATOrder / 100;
                    registryWorksheet.Cells[k + 11, 5] = vat;
                    double tariffPlusVAT = tariff + vat;
                    registryWorksheet.Cells[k + 11, 6] = tariffPlusVAT;
                    totalTariff += tariff;
                    totalVAT += vat;
                    totalTariffPlusVAT += tariffPlusVAT;
                    totalCars += carsByOrganization.Count();
                    totalSnow += totalVolumeSnow;
                    totalWater += totalVolumeWater;
                    k++;
                }
                registryWorksheet.Cells[k + 11, 3] = "ВСЕГО:";
                registryWorksheet.Cells[k + 11, 4] = totalTariff;
                registryWorksheet.Cells[k + 11, 5] = totalVAT;
                registryWorksheet.Cells[k + 11, 6] = totalTariffPlusVAT;
                registryWorksheet.Cells[k + 11, 8] = totalCars;
                registryWorksheet.Cells[k + 11, 9] = totalSnow;
                registryWorksheet.Cells[k + 11, 10] = totalWater;

                Excel.Range range2 = registryWorksheet
                            .Range[registryWorksheet.Cells[12, 1], registryWorksheet.Cells[k + 11, 6]].Cells;
                range2.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                range2.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                range2.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                range2.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                range2.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

                Excel.Range newCellRange1 = registryWorksheet
                            .Range[registryWorksheet.Cells[k + 13, 2], registryWorksheet.Cells[k + 13, 3]].Cells;
                newCellRange1.Merge(Type.Missing);
                newCellRange1 = registryWorksheet
                            .Range[registryWorksheet.Cells[k + 13, 5], registryWorksheet.Cells[k + 13, 6]].Cells;
                newCellRange1.Merge(Type.Missing);
                registryWorksheet.Cells[k + 13, 2] = "Начальник участка НС №3";
                registryWorksheet.Cells[k + 13, 5] = "А.В. Погребицкий";

                Excel.Range range = registryWorksheet.UsedRange;
                range.Columns.AutoFit();

                registryWorkbook.Save();
                registryWorkbook.Close();
                ex.Quit();
            }
            Excel.Application excel = new Excel.Application { Visible = true };
            Excel.Workbook wb = excel.Workbooks.Open(path2);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView2();
        }
    }
}