using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokItog
{
    internal class Program
    {
        
            




        static void Main(string[] args)
        {
            // Программа из массива строк создает новый массив из элементов, длина которых <=3

            string [] GetNewArray(string[] array)
            {
                int index = 0;

                string str = string.Empty;

                for (int i = 0; i < array.Length; i++) // вычисляем длину нового массива
                {
                    str = array[i];
                    if (str.Length <= 3)
                        index++;                                        
                }

                string[] arrayNew = new string[index]; // создаем новый массив
                int indexNew = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    str = array[i];
                    
                    if (str.Length <= 3)
                    {
                        arrayNew[indexNew] = array[i];
                            indexNew++;
                    }
                       
                }
                return arrayNew;

            }


            string[] myArray = new string[] {"helloworld", "peace", "123", "16", "Jenifer", "cat"};

            Console.WriteLine("Первый массив");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "\t");
            }
            Console.WriteLine();

            myArray = GetNewArray(myArray);

            Console.WriteLine("Второй массив");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
