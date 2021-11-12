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

namespace pract9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Runner[] runner;

        private void справка_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31\nПеревезенцева Полина\n\nЗадание:\nЗаполнить таблицу участников забега на 100 метров на 8 человек с полями: ФИО, номер, результат. Вывести результат на экран. Вывести средний результат.");
        }

        private void выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            runner = new Runner[8];
            Random rnd = new Random();
            double counter = 0;
            for (int i = 0; i < 8; i++)
            {
                runner[i]._result = rnd.Next(1, 30);
                runner[i]._name = "Имя " + (i + 1);
                runner[i]._counter = (i + 1);
                counter += runner[i]._result;
            }
            counter /= 8;
            string[,] matrix = new string[8, 3];
            for (int j=0; j<3; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    switch (j)
                    {
                        case 0: matrix[i, j] = runner[i]._counter.ToString(); break;
                        case 1: matrix[i, j] = runner[i]._name; break;
                        case 2: matrix[i, j] = runner[i]._result.ToString(); break;
                    }
                }
            }
            dataGrid.ItemsSource = VisualArray.ToDataTable(matrix).DefaultView;
            dataGrid.Columns[0].Header = "Номер";
            dataGrid.Columns[1].Header = "ФИО";
            dataGrid.Columns[2].Header = "Результат (сек)";
            result.Text = counter.ToString();
        }
    }
}
