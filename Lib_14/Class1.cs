using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace Lib_14
{
    
    public class Class1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas"- массив></param>
        /// <param name="sum" - переменная для вывода суммы></param>
        public static void Sumik (int [] mas,out int sum)
        {
            int i;
            sum = 0;
            
            for ( i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 8)
                {
                    sum = sum + mas[i];
                    
                }
            }
        }

    }
}
