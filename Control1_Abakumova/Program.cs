using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1_Abakumova
{
    class Program
    {

        struct City
        {
            public string Name;
            public int Population;
            public int Square;
        }

        struct Info
        {
            public City[] Cities;
        }

        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();


            string tempN = string.Empty;
            string tempP = string.Empty;
            string tempS = string.Empty;

            char currentChar = ' ';
            int index = 0;
            int indexcity = 0;
            int citycounter = 0;

            for (int a = 0; a < c.Length; a++)
            {
                if (c[a] == '=') citycounter++;
            }

            Info Info = new Info();
            Info.Cities = new City[citycounter];

            while (indexcity != citycounter)
            {

                for (int i = index; i < c.Length; i++)
                {
                    currentChar = c[i];

                    if (currentChar != '=')
                    {
                        tempN = tempN + currentChar.ToString();
                    }
                    else
                    {
                        index = i + 1;
                        break;
                    }

                }

                Info.Cities[indexcity].Name = tempN;
                tempN = string.Empty;

                for (int j = index; j < c.Length; j++)
                {
                    currentChar = c[j];

                    if (currentChar != ',')
                    {
                        tempP = tempP + currentChar.ToString();
                    }
                    else
                    {
                        index = j + 1;
                        break;
                    }

                }

                Info.Cities[indexcity].Population = Int32.Parse(tempP);
                tempP = string.Empty;

                for (int z = index; z < c.Length; z++)
                {
                    currentChar = c[z];

                    if (currentChar != ';')
                    {
                        tempS = tempS + currentChar.ToString();
                    }
                    else
                    {
                        index = z + 1;
                        break;
                    }

                }

                Info.Cities[indexcity].Square = Int32.Parse(tempS);
                tempS = string.Empty;

                indexcity++;

            }


            int maxP = 0;
            int indexP = 0;
            int maxL = 0;
            int indexL = 0;

            for (int y = 0; y < citycounter; y++)
            {
                if (Info.Cities[y].Population > maxP)
                {
                    maxP = Info.Cities[y].Population;
                    indexP = y;
                }

                if (Info.Cities[y].Name.Length > maxL)
                {
                    maxL = Info.Cities[y].Name.Length;
                    indexL = y;
                }

            }

            Console.WriteLine("-------");
            Console.WriteLine("Most populated: " + Info.Cities[indexP].Name + " (" + maxP + " people)");
            Console.WriteLine("Longest name: " + Info.Cities[indexL].Name + " (" + maxL + " letters)");
            Console.WriteLine("Density: ");

            for (int i = 0; i < citycounter; i++)
            {
                Console.WriteLine(Info.Cities[i].Name + " - " + (float)Info.Cities[i].Population / Info.Cities[i].Square);
            }
        }
    }
}
