using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab6
{
    public partial class Form1 : Form
    {

        private ICollection<Passanger> passangers = new List<Passanger>();
        private ICollection<Passanger> passangersCopy = new List<Passanger>();
        private readonly XmlSchemaSet Schema = new XmlSchemaSet();

     

        public Form1()
        {
            InitializeComponent();

            LoadXmlSchema();
            
        }

        private void LoadXmlSchema()
        {
           Schema.Add("", @"C:\Users\M\Desktop\Візуальне програмування\lab3\Lab6\MoviesXMLSchema.xsd");
          
        }


        private void CleanControls()
        {
            nameTextBox.Text = string.Empty;
            weightTextBox.Text = string.Empty;
            flightNumberTextBox.Text = string.Empty;
            departureTimeTextBox.Text = string.Empty;
            destinationTextBox.Text = string.Empty;
            flightDurationTextBox.Text = string.Empty;
        }

        private void UpdateCarsDataGridView()
        {
            carDataGridView.Rows.Clear();
            for (var i = 0; i < passangers.Count(); i++)
            {
                carDataGridView.Rows.Add();

                carDataGridView.Rows[i].Cells[0].Value = passangers.ElementAt(i)?.Id;
                carDataGridView.Rows[i].Cells[1].Value = passangers.ElementAt(i)?.name;
                carDataGridView.Rows[i].Cells[2].Value = passangers.ElementAt(i)?.weight;
                carDataGridView.Rows[i].Cells[3].Value = passangers.ElementAt(i)?.time;
                carDataGridView.Rows[i].Cells[4].Value = passangers.ElementAt(i)?.flightNumber;
                carDataGridView.Rows[i].Cells[5].Value = passangers.ElementAt(i)?.departureTime;
                carDataGridView.Rows[i].Cells[6].Value = passangers.ElementAt(i)?.flightDuration;
                carDataGridView.Rows[i].Cells[7].Value = passangers.ElementAt(i)?.destination;

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
                    XmlSerializer xs = new XmlSerializer(typeof(List<Passanger>));
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        xs.Serialize(fs, passangers);
                    }
                    MessageBox.Show("Passengers were successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unabled to save \n Message: {ex.Message}", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show($"Unabled to load passengers\n Message: {e.Message}", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validationErrors = true;
                    });

                    if (validationErrors)
                    {
                        return;
                    }

                    XmlSerializer xs = new XmlSerializer(typeof(List<Passanger>));
                    using (var reader = xmlDocument.CreateReader())
                    {
                        passangers = xs.Deserialize(reader) as List<Passanger>;
                    }

                    MessageBox.Show("Passengers were successfully loaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unabled to load \n Message: {ex.Message}", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var weight = Double.Parse( weightTextBox.Text);
            var flightNumber = flightNumberTextBox.Text;
            var departureTime = departureTimeTextBox.Text;
            var destination = destinationTextBox.Text;
            var time = dateTimePicker1.Value;
            var flightDuration = Int32.Parse(flightDurationTextBox.Text);


            var passenger = new Passanger()
            {
                Id = new Random().Next(),
                name = name, 
                weight = weight,
                flightNumber = flightNumber,
                departureTime = departureTime,
                flightDuration = flightDuration,
                destination = destination,
                time = time.ToString()
            };

            passangers.Add(passenger);
            UpdateCarsDataGridView();
            MessageBox.Show("Passenger was successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanControls();
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            if(passangers.Count() > 0)
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

        private void movieDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void carDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carProdYearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            var flightNumber = textBox1.Text;

            passangersCopy = passangers;
            passangers = passangers.Where(passenger => passenger.flightNumber == flightNumber).ToList();

            double total = 0 ;

            foreach(var i in passangers)
            {
                total += i.weight;
            }

            label5.Text = "Total weight: " + total.ToString();
            UpdateCarsDataGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            passangers = passangersCopy;
            UpdateCarsDataGridView();
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
