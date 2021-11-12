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
        Runner runner = new Runner();

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
            string [,] matrix = new string [8,3];
            matrix = runner.FillMatrix(matrix);
            dataGrid.ItemsSource = VisualArray.ToDataTable(matrix).DefaultView;
            dataGrid.Columns[0].Header = "Номер";
            dataGrid.Columns[1].Header = "ФИО";
            dataGrid.Columns[2].Header = "Результат";
            result.Text = runner.AverageValue(matrix);
        }
    }
}
