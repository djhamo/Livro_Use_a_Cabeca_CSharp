using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadWriteStream
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"D:\Processar\secret_plan.txt");
            StreamWriter writer = new StreamWriter(@"D:\Processar\emailToCaptainAmazing.txt");

            writer.WriteLine("To: CaptainAmazing@objectville.net");
            writer.WriteLine("From: Commissioner@objectville.net");
            writer.WriteLine("Subject: Can you save the Day... Again ?");
            writer.WriteLine();
            writer.WriteLine("We've discovered the Swindler's plan");
            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("The plan -> " + lineFromThePlan);
            }
            writer.WriteLine();
            writer.WriteLine("Can you help us ?");
            writer.Close();
            reader.Close();
        }
    }
}
