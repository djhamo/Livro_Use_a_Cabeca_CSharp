using System;
using System.Windows.Forms;

namespace WindowPlay
{
    public class Talker
    {
        public Talker()
        {
        }

        public static int Blah(string thingToSay, int numberOfTimes)
        {
            string finalString = "";
            for (int count = 0; count < numberOfTimes; count++)
            {
                finalString = finalString + thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }

}