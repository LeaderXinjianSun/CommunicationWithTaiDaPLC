using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leader.DeltaDMT;

namespace CommunicationWithTaiDaPLC
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RD = new Random();
            DeltaDMT eltaDVP28SVModubsSerial = new DeltaDMT();
            eltaDVP28SVModubsSerial.Init("COM3",0);
            while (true)
            {
                eltaDVP28SVModubsSerial.WriteDWORD("D200", RD.Next(0, 60000));
                var ss = eltaDVP28SVModubsSerial.ReadDWORD("D200");
                Console.WriteLine(ss.ToString());
                System.Threading.Thread.Sleep(10);
            }

            //Console.ReadKey();
        }
    }
}
