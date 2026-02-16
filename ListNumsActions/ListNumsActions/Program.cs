using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins":
                        int insertIndex = int.Parse(cmd[1]);
                        int insertNumber = int.Parse(cmd[2]);

                        if (insertIndex >= 0 && insertIndex < nums.Count)
                        {
                            nums.Insert(insertIndex, insertNumber);
                        }
                        break;

                    case "del":
                        int deleteIndex = int.Parse(cmd[1]);

                        if (deleteIndex >= 0 && deleteIndex < nums.Count)
                        {
                            nums.RemoveAt(deleteIndex);
                        }
                        break;

                    case "contains":
                        int numberToCheck = int.Parse(cmd[1]);

                        if (nums.Contains(numberToCheck))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }
                        break;
                        
                    case "remove":
                        int numberToRemove = int.Parse(cmd[1]);
                        nums.Remove(numberToRemove);
                        break;


                    case "add":
                        int num1 = int.Parse(cmd[1]);
                        int num2 = int.Parse(cmd[2]);
                        nums.Add(num1 + num2);
                        break;

                    case "large":
                        int numberLarge = int.Parse(cmd[1]);
                        Console.WriteLine(string.Join(" ", nums.Where(x => x > numberLarge)));
                        break;

                }
            }
        }
    }
}
