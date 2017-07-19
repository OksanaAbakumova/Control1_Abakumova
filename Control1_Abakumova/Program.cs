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
            Info Info = new Info();
            Info.Cities = new City[3];

            string input = Console.ReadLine();
            char[] c = input.ToCharArray();


            string tempN = string.Empty;
            string tempP = string.Empty;
            string tempS = string.Empty;


            char currentChar = ' ';
            int index = 0;
            int indexcity = 0;

            while (indexcity != 3)
            {

                for (int i = index; i < c.Length - index; i++)
                {
                    currentChar = c[i];

                    if (currentChar != '=')
                    {
                        tempN = tempN + currentChar.ToString();

                    }

                    else
                    { index = i + 1; break; };

                }


                Info.Cities[indexcity].Name = tempN;

                tempN = string.Empty;
                for (int j = index; j < c.Length - index; j++)
                {
                    currentChar = c[j];

                    if (currentChar != ',')
                    {
                        tempP = tempP + currentChar.ToString();

                    }
                    else
                    { index = j + 1; break; };

                }

                Info.Cities[indexcity].Population = int.Parse(tempP);

                tempP = string.Empty;

                for (int z = index; z < c.Length - index; z++)
                {
                    currentChar = c[z];

                    if (currentChar != ';')
                    {
                        tempS = tempS + currentChar.ToString();

                    }
                    else
                    { index = z + 1; break; };

                }


                Info.Cities[indexcity].Square = int.Parse(tempS);
                tempS = string.Empty;

                indexcity++;
        
            }




            for (int i = 0; i < 3; i++)
            {


                Console.WriteLine(Info.Cities[i].Name);
                Console.WriteLine(Info.Cities[i].Population);
                Console.WriteLine(Info.Cities[i].Square);
                Console.WriteLine("-------");
            }



        }
    }
}
