using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace checkpoint2
{
    //First class to Implement the list
    class Listed
    {
        public Listed(string category, string modelname, int price)
        {
            Category = category;
            Modelname = modelname;
            Price = price;
        }

        public string Category { get; set; }
        public string Modelname { get; set; }
        public int Price { get; set; }

    }
    //Second Class for Error Handling
    class Errorcheck
    {
        public Errorcheck(int error)
        {
            Arithmaticerror = error;
        }
        public int Arithmaticerror { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the list of Items");
            List<Listed> items = new List<Listed>();

            var teams = new List<string>();
            Console.WriteLine("Enter the number of products to be listed");
            int x = Convert.ToInt32(Console.ReadLine());

            while (x != 0)
            {
                //Get input from user and store it in list
                Console.WriteLine("Enter the category, product name and price");
                for (int i = 0; i < 3; i++)
                {
                    var value = Console.ReadLine();
                    if (value.ToLower().Trim() == "q")
                    {
                        break;
                    }
                    teams.Add(value);
                    int num = teams.Count;
                    if (num == 3)
                    {
                        int cost = Convert.ToInt32(teams[2]);
                        Listed paper = new Listed(teams[0], teams[1], cost);
                        items.Add(paper);
                        teams.Clear();
                    }

                }

                x--;

            }
            //To get the sorted list and print the output
            List<Listed> SortedList = items.OrderBy(paper => paper.Price).ToList();
            Console.WriteLine("category".PadRight(10) + "Modelname".PadRight(10) + "Price".PadRight(10));
            foreach (Listed paper in SortedList)
            {
                Console.WriteLine(paper.Category.PadRight(10) + paper.Modelname.PadRight(10) + paper.Price);
            }
            //Sum of product cost and print the output
            int sum = items.Sum(paper => paper.Price);
            Console.WriteLine("Sum:".PadRight(20) + sum);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press Enter to add more entries");



        }

    }
}
