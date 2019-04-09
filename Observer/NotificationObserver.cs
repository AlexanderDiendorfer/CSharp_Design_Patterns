using System;
using System.Collections.Generic;
using System.Text;

namespace Observer {
    class NotificationObserver : IObserver {
        public void Update(float value) {
            Console.WriteLine("Sending Notification: " + value);
        }
    }
}
