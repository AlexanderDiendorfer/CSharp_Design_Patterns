using System;
using System.Collections.Generic;
using System.Text;

namespace Observer {
    class DisplayObserver : IObserver {
        public void Update(float value) {
            Console.WriteLine("Update Display. Value " + value);
        }
    }
}
