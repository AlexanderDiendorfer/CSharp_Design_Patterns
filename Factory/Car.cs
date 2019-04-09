using System;
using System.Collections.Generic;
using System.Text;

namespace Factory {
    class Car : IVehicle {
        public void Move(string to) {
            Console.WriteLine("Car is moving to" + to);
        }
    }
}
