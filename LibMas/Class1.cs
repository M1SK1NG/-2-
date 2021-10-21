using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace LibMas
{
    
    public class Class2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas"- массив></param>
        /// <param name="column"- переменная количества колонок></param>
        /// <param name="randMax" - максимальное рандомное число></param>
        public static void InitArray(out int[] mas, int column, int randMax)
        {
            Random Rnd; Rnd = new Random();
            mas = new Int32[column];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = Rnd.Next(randMax);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas" - массив></param>
        /// <param name="column" - количество колонок></param>
        public static void CreateArray(out int[] mas, int column)
        {
            mas = new int[column];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas"- массив></param>
        public static void ArraySave(int[] mas)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";
            DialogResult dialogResult = save.ShowDialog();
            bool t = Convert.ToBoolean(dialogResult);
            if (t == true)
            {
                StreamWriter file = new StreamWriter(save.FileName);
                file.WriteLine(Convert.ToString(mas.Length));
                for (int i = 0; i < mas.Length; i++)
                {
                    file.WriteLine(mas[i]);
                }
                file.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas" - массив></param>
        public static void ArrayOpen(out int[] mas)
        {
            mas = new int[1];
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            open.FilterIndex = 2;
            open.Title = "Открыть таблицы";
            DialogResult dialogResult = open.ShowDialog();
            bool t = Convert.ToBoolean(dialogResult);
            if (t == true)
            {
                StreamReader file = new StreamReader(open.FileName);
                int column = Convert.ToInt32(file.ReadLine());
                mas = new Int32[column];
                for (int i = 0; i < column; i++)
                {
                    mas[i] = Convert.ToInt32(file.ReadLine());
                }
                file.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas" - массив></param>
        public static void ArrayOchist(ref int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = 0;
            }
        }
    }
}