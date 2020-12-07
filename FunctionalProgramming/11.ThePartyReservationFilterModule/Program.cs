using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invited = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> filters = new List<string>();
            string input = Console.ReadLine();
            while (input != "Print")
            {
                var cmdArgs = input.Split(";");
                string command = cmdArgs[0];
                string filter = cmdArgs[1];
                string param = cmdArgs[2];

                if (command == "Add filter")
                {
                    filters.Add(filter + " " + param);
                }
                else if (command == "Remove filter")
                {
                    if (filters.Contains(filter + " " + param))
                    {
                        filters.Remove(filter + " " + param);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in filters)
            {
                string[] filterArgs = item.Split();
                string filter = "";
                string param = "";
                if (filterArgs.Length == 3)
                {
                    filter = filterArgs[0] + " " + filterArgs[1];
                    param = filterArgs[2];
                }
                else if (filterArgs.Length < 3)
                {
                    filter = filterArgs[0];
                    param = filterArgs[1];
                }

                Predicate<string> predicate = GetPredicate(filter, param);
                invited.RemoveAll(predicate);
            }

            if (invited.Any())
            {
                Console.WriteLine(string.Join(" ", invited));
            }

            
        }
        static Predicate<string> GetPredicate(string filter, string param)
        {

            Predicate<string> predicate = filter switch
            {
                "Starts with" => predicate = new Predicate<string>(name =>
                  name.StartsWith(param)),
                "Ends with" => predicate = new Predicate<string>(name =>
                 name.EndsWith(param)),
                "Length" => predicate = new Predicate<string>(name =>
                 name.Length == int.Parse(param)),
                "Contains" => predicate = new Predicate<string>(name =>
                  name.Contains(param)),
                _ => null
            };

            return predicate;
        }
    }
}

