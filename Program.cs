using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Midnight Blue";

            Zero fx = new Zero ();
            fx.MainColor = "Black";

            Tesla modelS= new Tesla();
            modelS.MainColor = "Burgundy";

            Ram truck = new Ram ();
            truck.MainColor = "Silver";

            Cessna mx410 = new Cessna ();
            mx410.MainColor = "White";

            fxs.Drive();
            fx.Drive();
            modelS.Drive();
            truck.Drive();
            mx410.Drive(); 
            
        }
    }
}