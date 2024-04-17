using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11alb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trainsTextBox.Multiline = true;
            sortedTrainsTextBox.Multiline = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Train> trains = GenerateTrains(10);
            WriteTrainsToFile(trains, "trains.txt");
            MessageBox.Show("Данные успешно сгенерированы и записаны в файл trains.txt");
        }
        private void WriteTrainsToFile(List<Train> trains, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var train in trains)
                {
                    writer.WriteLine($"{train.Destination},{train.Number},{train.DepartureTime}");
                }
            }
        }
        private List<Train> GenerateTrains(int count)
        {
            List<Train> trains = new List<Train>();
            Random rand = new Random();
            string[] destinations = { "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Красноярск", "Томск", "Сочи", "Кастрома", "Тюмень", "Сургут" };

            for (int i = 0; i < count; i++)
            {
                Train train = new Train();
                train.Destination = destinations[i % destinations.Length];
                train.Number = rand.Next(1000, 9999);
                train.DepartureTime = DateTime.Today.AddHours(rand.Next(0, 24)).AddMinutes(rand.Next(0, 60));
                trains.Add(train);
            }

            return trains;
        }
        public class Train
        {
            public string Destination { get; set; }
            public int Number { get; set; }
            public DateTime DepartureTime { get; set; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SortAndWriteTrainsByDepartureTime(ReadTrainsFromFile("trains.txt"), "sorted_trains.txt");
        }

        private void SortAndWriteTrainsByDepartureTime(List<Train> trains, string fileName)
        {
            List<Train> sortedTrains = trains.OrderBy(train => train.DepartureTime).ToList();

            if (sortedTrains.Count > 0)
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (var train in sortedTrains)
                    {
                        writer.WriteLine($"{train.Destination},{train.Number},{train.DepartureTime}");
                    }
                }
                MessageBox.Show($"Отсортированные данные успешно записаны в файл {fileName}");
            }
            else
            {
                MessageBox.Show("Нет данных для сортировки.");
            }
        }
        private List<Train> ReadTrainsFromFile(string fileName)
        {
            List<Train> trains = new List<Train>();

            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            Train train = new Train();
                            train.Destination = parts[0];
                            train.Number = int.Parse(parts[1]);
                            train.DepartureTime = DateTime.Parse(parts[2]);
                            trains.Add(train);
                        }
                    }
                }
            }

            return trains;
        }
        private void ClearFile(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearFile("trains.txt");
            ClearFile("sorted_trains.txt");
            ShowFileContent("trains.txt", trainsTextBox);
            ShowFileContent("sorted_trains.txt", sortedTrainsTextBox);
            MessageBox.Show("Файлы успешно очищены.");

        }
        private void ShowFileContent(string fileName, TextBox textBox)
        {
            if (File.Exists(fileName))
            {
                textBox.Text = File.ReadAllText(fileName);
            }
            else
            {
                textBox.Text = "Файл не найден.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFileContent("trains.txt", trainsTextBox);
            ShowFileContent("sorted_trains.txt", sortedTrainsTextBox);
        }

        private void trainsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ShowFileContent(string fileName, RichTextBox richTextBox)
        {
            if (File.Exists(fileName))
            {
                richTextBox.Text = File.ReadAllText(fileName);
            }
            else
            {
                richTextBox.Text = "Файл не найден.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string destination = destinationTextBox.Text; // Предполагается, что у вас есть TextBox с именем destinationTextBox, куда пользователь вводит название пункта назначения

            List<Train> trains = ReadTrainsFromFile("trains.txt");
            List<Train> matchingTrains = trains.Where(train => train.Destination == destination).ToList();

            if (matchingTrains.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var train in matchingTrains)
                {
                    sb.AppendLine($"Поезд №{train.Number} отправляется в {train.Destination} в {train.DepartureTime}.");
                }
                MessageBox.Show(sb.ToString(), "Информация о поездах");
            }
            else
            {
                MessageBox.Show("Нет поездов, отправляющихся в указанный пункт.", "Информация о поездах");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void destinationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
