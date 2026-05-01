using System;

public enum SearchType
{
    Exit = 0,
    Linear  = 1,
    Binary = 2,
    Jump = 3,
    Interpolation = 4,
    Exponential = 5
}

public class RunAlgo
{
    public static void Main()
    {
        int[] numbers = { 5, 15, 31, 45, 51, 55, 60, 67, 79, 82, 97, 100, 111, 120, 150 };

        while (true)
        {
            Console.WriteLine("\n=== SEARCH MENU ===");
            Console.WriteLine("1 - Linear Search");
            Console.WriteLine("2 - Binary Search");
            Console.WriteLine("3 - Jump Search");
            Console.WriteLine("4 - Interpolation Search");
            Console.WriteLine("5 - Exponential Search");
            Console.WriteLine("0 - Exit");
            Console.Write("Select algorithm: ");

             if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice!");
                continue;
            }

            SearchType selected = (SearchType)choice;

            if (selected == SearchType.Exit)
            {
                Console.WriteLine("Program closed");
                break;
            }

            Console.Write("Enter target number: ");
            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Invalid number");
                continue;
            }

            int result = -1;

            switch (selected)
            {
                case SearchType.Linear:
                    result = LinearSearchAlgo.LinearSearch(numbers, target);
                    break;
                case SearchType.Binary:
                    result = BinarySearchAlgo.BinarySearch(numbers, target);
                    break;    
                case SearchType.Jump:
                    result = JumpSearchAlgo.JumpSearch(numbers, target);
                    break;
                case SearchType.Interpolation:
                    result = InterpolationSearchAlgo.InterpolationSearch(numbers, target);
                    break;
                case SearchType.Exponential:
                    result = ExponentialSearchAlgo.ExponentialSearch(numbers, target);
                    break;    

                default:
                    Console.WriteLine("Invalid Selection");
                    continue;
            }

            if (result != -1)
            {
                Console.WriteLine($"Found at index: {result}");
            }
            else
            {
                Console.WriteLine("Number not found.");
            }


        }



    }

}