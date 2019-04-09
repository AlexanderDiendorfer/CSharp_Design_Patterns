using System;

namespace Observer {
    class Program {
        static void Main(string[] args) {
            TemperatureSubject sensor = new TemperatureSubject();
            IObserver observer1 = new NotificationObserver();
            IObserver observer2 = new DisplayObserver();

            sensor.Register(observer1);
            sensor.Register(observer2);

            sensor.Temperature = 13.5F;

            sensor.Temperature = 20.0F;

            Console.ReadKey();
        }
    }
}
