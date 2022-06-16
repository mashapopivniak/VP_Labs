using Newtonsoft.Json;
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private ICollection<Model> Model = new List<Model>();
        private ICollection<Good> goods = new List<Good>();
        private readonly XmlSchemaSet Schema = new XmlSchemaSet();

        private const string categoriesPath = "C:\\Users\\M\\Desktop\\Візуальне програмування\\lab5\\Lab6\\categories.json";

        public Form1()
        {
            InitializeComponent();

            LoadXmlSchema();
            InitializeCategories();
        }

        private void LoadXmlSchema()
        {
            Schema.Add("", @"C:\Users\M\Desktop\Візуальне програмування\lab5\Lab6\MoviesXMLSchema.xsd");
        }

        private void InitializeCategories()
        {
            Model = ReadCategories(categoriesPath);
            GoodTypeComboBox.Items.AddRange(Model.Select(x => x.Name).ToArray());
        }

        private ICollection<Model> ReadCategories(string path)
        {
            string json = File.ReadAllText(path);
            var categories = JsonConvert.DeserializeObject<List<Model>>(json);

            return categories;
        }

        private void CleanControls()
        {
            NameAndSurnameTextBox.Text = string.Empty;
            ModelTextBox.Text = string.Empty;
            ModelTextBox.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            success.Checked = false;
            GoodTypeComboBox.SelectedIndex = -1;
        }

        private void UpdateCarsDataGridView()
        {
            carDataGridView.Rows.Clear();
            for (var i = 0; i < goods.Count(); i++)
            {
                carDataGridView.Rows.Add();

                carDataGridView.Rows[i].Cells[0].Value = goods.ElementAt(i)?.Id;
                carDataGridView.Rows[i].Cells[1].Value = goods.ElementAt(i)?.type?.Name;
                carDataGridView.Rows[i].Cells[2].Value = goods.ElementAt(i)?.modelName;
                carDataGridView.Rows[i].Cells[3].Value = goods.ElementAt(i)?.date;
                carDataGridView.Rows[i].Cells[4].Value = goods.ElementAt(i)?.executionTime;
                carDataGridView.Rows[i].Cells[5].Value = goods.ElementAt(i)?.result;
                carDataGridView.Rows[i].Cells[6].Value = goods.ElementAt(i)?.nameAndSurname;
            }
        }

        private void SaveCarsToXmlFile()
        {
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog.Title = "Please select file with data.";
            saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Good>));
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        xs.Serialize(fs, goods);
                    }
                    MessageBox.Show("Receipts were successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unabled to save receipts\n Message: {ex.Message}", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCarsFromXmlFile()
        {
            fileDialog.Filter = "XML files (*.xml)|*.xml";
            fileDialog.Title = "Please select file with data.";
            fileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            bool validationErrors = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XDocument xmlDocument = XDocument.Load(fileDialog.FileName);

                    xmlDocument.Validate(Schema, (s, e) =>
                    {
                        Console.WriteLine(e.Message);
                        MessageBox.Show($"Unabled to load receipts\n Message: {e.Message}", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validationErrors = true;
                    });

                    if (validationErrors)
                    {
                        return;
                    }

                    XmlSerializer xs = new XmlSerializer(typeof(List<Good>));
                    using (var reader = xmlDocument.CreateReader())
                    {
                        goods = xs.Deserialize(reader) as List<Good>;
                    }

                    MessageBox.Show("Receipts were successfully loaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unabled to load goods\n Message: {ex.Message}", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            var modelIndex = GoodTypeComboBox.SelectedIndex;
            var nameAndSurname = NameAndSurnameTextBox.Text;
            var modelName = ModelTextBox.Text;
            var date = dateTimePicker1.Text;
            var isSuccess = success.Checked;
            var executionTime = dateTimePicker2.Text;

            if (modelIndex < 0)
            {
                MessageBox.Show("Wrong input parameters", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanControls();
                return;
            }

            var model = Model.ElementAt(modelIndex);



            var good = new Good()
            {
                Id = goods.LastOrDefault()?.Id + 1 ?? 1,
                type = model,
                nameAndSurname = nameAndSurname,
                modelName = modelName,
                result= isSuccess, 
                date = date,
                executionTime = executionTime
            };

            goods.Add(good);
            UpdateCarsDataGridView();
            MessageBox.Show("Receipt was successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanControls();
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            if(goods.Count() > 0)
            {
                SaveCarsToXmlFile();
            } 
            else
            {
                MessageBox.Show("Nothing to save", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadFromFileButton_Click(object sender, EventArgs e)
        {
            LoadCarsFromXmlFile();
            UpdateCarsDataGridView();
        }

        private void movieNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void carDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker3.Text;

            var text = "";

            foreach(var test in Model)
            {

                var elements = goods.Where((element) => element.type.Name == test.Name && element.date == date);
                int success = 0;
                int notSuccess = 0;
                foreach(var el in elements)
                {
                    success += el.result == true ? 1 : 0;
                    notSuccess += el.result == false ? 1 : 0;
                }

                text += $"{test.Name} {success} {notSuccess} \n";
            }


            label5.Text = text;

        }
    }
}
