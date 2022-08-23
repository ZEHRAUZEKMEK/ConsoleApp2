using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int say1 = 10;
            int say2 = 30;
            say1 = say2;
            say2 = 64;
            //bu durumda say1=30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //bu durumda sayilar1[0]=999
        }
    }
}
