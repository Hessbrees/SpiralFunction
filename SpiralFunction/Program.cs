using System;

namespace SpiralFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            SpiralFunction(100);
        }

        static void SpiralFunction(float startingDistanse)
        {
            // starting pos (max x , 0) 90 degrees;
            float x = startingDistanse;
            float y = 0;
            
            float r = startingDistanse;
            float theta = 0;
            int thetaCounter = 0;
            int counter = 0;


            // main changing loop
            while (counter <360)
            {
                // calculating new range every loop
                r = 0.997f * r;
                // calculating new degree (0-360 thetaCounter value)
                theta = (float)(thetaCounter * 0.5 * Math.PI)/90;

                y = (float)Math.Sin(theta)*r;
                x = (float)Math.Cos(theta)*r;
                
                Console.WriteLine("theta: {0} x: {1} y: {2} ", thetaCounter.ToString("0.00") , x.ToString("00"), y.ToString("00"));

                thetaCounter++;
                counter++;
            }

        }
    }
}
