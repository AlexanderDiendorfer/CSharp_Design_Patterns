using System;
using System.Collections.Generic;
using System.Text;

namespace Observer {
    class TemperatureSubject {
        List<IObserver> registeredObservers = new List<IObserver>();
        float temp;

        public float Temperature {
            get => temp;
            set {
                if (temp != value) {
                    temp = value;
                    Update();

                }
            } }


        public void Register(IObserver observer) {
            if (observer != null) {
                lock (registeredObservers) {
                    registeredObservers.Add(observer);
                }
            }

        }
        public void UnRegister(IObserver observer) {
            if (observer != null) {
                lock (registeredObservers) {
                    registeredObservers.Remove(observer);
                }

            }   
        }

        void Update() {
            List<IObserver> workingList = new List<IObserver>(registeredObservers.Count);
            lock(registeredObservers) {
                workingList.AddRange(registeredObservers);
            }
                foreach (IObserver observer in workingList) {
                    observer.Update(this.Temperature);
                }
            
        }
    }
}
