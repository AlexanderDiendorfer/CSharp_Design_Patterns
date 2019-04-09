using System;
using System.Collections.Generic;
using System.Text;

namespace Factory {
    class Bus : IVehicle {
        public void Move(string to) {
            Console.WriteLine("Bus is moving to " + to);
        }
    }
}
