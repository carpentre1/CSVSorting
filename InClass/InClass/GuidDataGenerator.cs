using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace InClass
{
    public class GuidDataGenerator
    {
        public List<int> MyInts;
        public List<Guid> MyGuids;
        public List<Double> MyDoubles;

        string filePath = "C:\\Newfolder\\database.csv";

        public GuidDataGenerator()
        {
            MyInts = new List<int>();
            MyGuids = new List<Guid>();
            MyDoubles = new List<Double>();

        }
        public void Write()
        {
            //File.Create(@"C:\Users\Public\database.txt");
            var csv = new StringBuilder();
            for(int x = 0; x < 1000000; x++)
            {
                MyInts.Add(x);

                Random random = new Random();
                double nextDouble = random.Next(0, 100);
                MyDoubles.Add(nextDouble);

                Guid nextGuid = Guid.NewGuid();
                MyGuids.Add(nextGuid);

                var newLine = string.Format(MyInts[x] + "," + MyGuids[x] + "," + MyDoubles[x]);
                csv.AppendLine(newLine);

            }
            File.WriteAllText(filePath, csv.ToString());
            //for (int x = 0; x < 1000000; x++)
            //{
            //    File.OpenWrite("database.txt");
            //    using (System.IO.StreamWriter writer = new System.IO.StreamWriter("database.txt", true))
            //    {
            //        writer.WriteLine(MyInts[x] + " , " + MyGuids[x] + " , " + MyDoubles[x]);
            //        writer.Close();
            //    }
                
            //}
        }
        public void Read()
        {
            for (int x = 0; x < 1000000; x++)
            {
                File.OpenRead(filePath);
                using (System.IO.StreamReader reader = new System.IO.StreamReader("database.txt", true))
                {
                    System.Console.WriteLine(reader.ReadLine());
                    reader.Close();
                }

            }
        }
    }
}
