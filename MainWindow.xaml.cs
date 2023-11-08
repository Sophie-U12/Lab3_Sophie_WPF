using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3_Sophie_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbN.Text, out int sizeN) && sizeN > 0 && sizeN <= 10)
            {
                Random rnd = new Random();
                List<Dog> dogs = new List<Dog>();
                lbDogs.Items.Clear();

                double min = double.MaxValue;

                for(int i = 0; i < sizeN; i++)
                {
                    int dogType = rnd.Next(0, 2);

                    if(dogType == 0)
                    {
                        dogs.Add(new Dachshund("Такса", rnd.Next(10, 100), rnd.Next(1, 10)));
                    }
                    else
                    {
                        dogs.Add(new Alabai("Алабай", rnd.Next(10, 100), rnd.Next(10, 100)));
                    }
                    lbDogs.Items.Add(dogs[i]);

                    double foodPerDay = dogs[i].GetAmountFoodPerDay();
                    if (min > foodPerDay)
                    {
                        min = foodPerDay;
                    }
                }


                MessageBox.Show($"Результат: {min}");
            }
            else
            {
                MessageBox.Show("Помилка! Введіть правильний розмір(n > 0 and n <= 10)!");
            }


        }
    }
}
