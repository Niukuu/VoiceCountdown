using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace CountdownWithVoice
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= count; i++)
            {
                Console.WriteLine(i);
                string yes = Convert.ToString(i);
                s.Speak(yes);
            }
            Console.ReadKey();
        }
    }
}
