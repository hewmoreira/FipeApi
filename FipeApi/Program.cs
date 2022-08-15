using System;

namespace FipeApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carFipeCode = "004502-0";
            var fipeWS = new FipeWS();
            var result = fipeWS.GetFipeInfo(carFipeCode);
        }
    }
}
