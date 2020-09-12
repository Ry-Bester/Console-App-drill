using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //string[] names = { "Bob", "Joe", "Mary", "Sue" };
        //Console.WriteLine("Please type some text");
        //string text =(Console.ReadLine());

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j] + text); 
        //}
        //Console.ReadLine();

        //   int[] testScores = { 98, 99, 85, 82, 34, 91, 90, 94 };

        //for (int f = 0; f < testScores.Length; f++)

        //{
        //    if (testScores[f] < 85)
        //    {
        //        Console.WriteLine("Failing test score: " + testScores[f]);
        //    }
        //}
        //Console.ReadLine();

        //int[] testScores2 = { 98, 99, 85, 82, 34, 91, 90, 94 };

        //for (int l = 0; l < testScores2.Length; l++)

        //{
        //    if (testScores2[l] <= 85)
        //    {
        //        Console.WriteLine("Failing test score: " + testScores2[l]);
        //    }
        //}

        //List<string> names2 = new List<string>() { "Final Fantasy 7", "God of War", "Jak and Daxter", "Dark Souls" };
        //Console.WriteLine("Please enter a game name");
        //    string gname = (Console.ReadLine());
        //for (int g = 0; g < names2.Count; g++)
        //{
        //    if (names2.Contains(gname))
        //    {
        //        if (gname == names2[g])
        //        {
        //            Console.WriteLine(g);
        //            break;
        //        }
              
        //    }
        //    else
        //    {
        //        Console.WriteLine("that name does not exist in this list");
        //        break;
        //    }

        //}

        //List<string> names3 = new List<string>() { "apple", "orange", "melon", "cherry", "grape", "apple" };
        //Console.WriteLine("Please enter a fruit name");
        //string fname = (Console.ReadLine());
        //for (int fn = 0; fn < names3.Count; fn++)
        //{
        //    if (names3.Contains(fname))
        //    {
        //        if (fname == names3[fn])
        //        {
        //            Console.WriteLine(fn);
                    
        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine("that name does not exist in this list");
        //        break;
        //    }

        //}

        List<string> names4 = new List<string>() { "Mazda", "FourRunner", "Jeep", "Tundra", "Infinity", "Mazda" };
        List<string> names4backup = new List<string>();
         foreach(string name in names4)
        {
            foreach (string namebackup in names4backup)
            {
                if (name == namebackup)
                {
                    Console.WriteLine(name + " is in there twice.");
                }
               
            }
            Console.WriteLine("your car name is " + name);
            names4backup.Add(name);
        }

            
       



        Console.ReadLine();


    }
}

