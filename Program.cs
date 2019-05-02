using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Lists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> mainList = new List<int>();
            List<int> subList = new List<int>();

            Random random = new Random();

            Console.WriteLine("Both Main List and Sub List items:");

            mainList = CreateLists(mainList, subList, random);

            PrintLists(mainList);

            Console.WriteLine();

            UI(mainList);

            Console.WriteLine();

            SwapListsItems(mainList, subList);
            PrintLists(mainList);

            Console.WriteLine();

            AddItems(mainList);
            PrintLists(mainList);

            Console.WriteLine();

            Console.WriteLine(SumOfSpecificListItems(mainList, subList));

            Console.ReadLine();
        }

        public static List<int> CreateLists(List<int> mainList, List<int> subList, Random random)
        {
            mainList.Add(random.Next(0, 100));

            if (mainList.Count == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    subList.Add(random.Next(0, 100));
                }

                mainList.AddRange(subList);
            }

            if (mainList.Count == 6)
            {
                return mainList;
            }

            return CreateLists(mainList, subList, random);
        }

        public static List<int> SortLists(List<int> mainList)
        {
            mainList.Sort();

            return mainList;
        }

        public static void UI(List<int> mainList)
        {
            Console.WriteLine("Would You like to sort these Lists?");
            Console.WriteLine("Y/N");
            Console.WriteLine();

            string userInput = Console.ReadLine();
            Console.WriteLine();

            if (userInput == "Y")
            {
                Console.WriteLine("Ascending or Descending order?");
                Console.WriteLine("A - Ascending Order");
                Console.WriteLine("D - Descending Order");
                Console.WriteLine();

                string userInputAorD = Console.ReadLine();
                Console.WriteLine();

                if (userInputAorD == "A")
                {
                    SortLists(mainList);

                    PrintLists(mainList);
                }

                else if (userInputAorD == "D")
                {
                    SortLists(mainList);
                    mainList.Reverse();

                    PrintLists(mainList);
                }
            }

            else if (userInput == "N")
            {
                Console.WriteLine("You chose not to sort these Lists!");
            }
        }

        public static int SumOfSpecificListItems(List<int> mainList, List<int> subList)
        {
            Console.WriteLine("Which List items would You like to add?");
            Console.WriteLine("1 - Main List");
            Console.WriteLine("2 - Sub List");
            Console.WriteLine();

            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int sum = 0;

            if (userInput == 1)
            {
                for (int i = 0; i < mainList.Count; i++)
                {
                    sum += mainList[i];
                }
            }

            else if (userInput == 2)
            {
                for (int i = 0; i < subList.Count; i++)
                {
                    sum += subList[i];
                }
            }

            return sum;
        }

        public static List<int> SwapListsItems(List<int> mainList, List<int> subList)
        {
            Console.WriteLine("Would You like to swap the specific items in the Lists?");
            Console.WriteLine("Y/N");
            Console.WriteLine();

            string userInputForSwapping = Console.ReadLine();
            Console.WriteLine();

            if (userInputForSwapping == "Y")
            {
                Console.WriteLine("Choose the indexes of the Lists Items You would like to swap:");
                Console.WriteLine();

                int indexA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                int indexB = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                int temp = mainList[indexA];
                mainList[indexA] = mainList[indexB];
                mainList[indexB] = temp;

                return mainList;
            }

            else if (userInputForSwapping == "N")
            {
                Console.WriteLine("You chose not to swap the specific items in the Lists!");
                Console.WriteLine();

                return mainList;
            }

            return mainList;
        }

        public static void PrintLists(List<int> mainList)
        {
            foreach (object o in mainList)
            {
                Console.WriteLine(o);
            }
        }

        public static List<int> AddItems(List<int> mainList)
        {
            Console.WriteLine("Do You wish to add more items to the List?");
            Console.WriteLine("Y/N");
            Console.WriteLine();

            string userInputForAdding = Console.ReadLine();
            Console.WriteLine();

            if (userInputForAdding == "Y")
            {
                Console.WriteLine("Enter a new item that You wish to add to the List!");
                Console.WriteLine();

                int newItem = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                mainList.Add(newItem);

                return mainList;
            }

            else if (userInputForAdding == "N")
            {
                Console.WriteLine("You chose not to add any items to the List!");
                Console.WriteLine();

                return mainList;
            }

            return mainList;
        }
    }
}