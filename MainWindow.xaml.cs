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
using Lib_14;
using LibMas;
using System.IO;
using Microsoft.Win32;


namespace Практическая_работа_2
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
        int [] mas;
        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            int indexColumn = e.Column.DisplayIndex;
            mas[indexColumn] = Convert.ToInt32(((TextBox)e.EditingElement).Text);

        }
        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Создать_Click(object sender, RoutedEventArgs e)
        {
            int count = Convert.ToInt32(ColumnCount.Text);
            Class2.CreateArray(out mas, count);
            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;

        }

        private void Заполнить_Click(object sender, RoutedEventArgs e)
        {
            int randMax = Convert.ToInt32(diapazon.Text);
            int count = Convert.ToInt32(ColumnCount.Text);
            Class2.InitArray(out mas, count, randMax);
            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void Решение_Click(object sender, RoutedEventArgs e)
        {
            Class1.Sumik(mas, out int sum);
            rez.Text = Convert.ToString(sum);
        }

        private void Очистить_Click(object sender, RoutedEventArgs e)
        {
            Class2.ArrayOchist(ref mas);
            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }
        private void Сброс_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            mas = null;
            rez.Clear();
            diapazon.Clear();
            ColumnCount.Clear();
        }

        private void Сохранить_Click(object sender, RoutedEventArgs e)
        {
            Class2.ArraySave(mas);
        }

        private void Открыть_Click(object sender, RoutedEventArgs e)
        {
            Class2.ArrayOpen(out mas);
            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void Опрограмме_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Лейбович М.В ИСП-31\n + Ввести n целых чисел. Найти сумму чисел < 8. Результат вывести на экран\n");
        }
    }
}
