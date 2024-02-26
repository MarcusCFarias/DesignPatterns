using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class WheaterProvider : IObservable<Wheater>
    {
        List<IObserver<Wheater>> observers;

        public WheaterProvider()
        {
            observers = new List<IObserver<Wheater>>();
        }
        public IDisposable Subscribe(IObserver<Wheater> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }

        public void GetWheater()
        {
            var wheater = this.SetWheater();

            foreach (var observer in observers)
            {
                observer.OnNext(wheater);
                observer.OnCompleted();
                wheater = this.SetWheater();
            }
        }

        private decimal GetRandomNumber()
        {
            var random = new Random();
            return random.Next(5, 35);
        }

        private Wheater SetWheater()
        {
            decimal temperature = GetRandomNumber();
            decimal humidity = GetRandomNumber();
            decimal pressure = GetRandomNumber();

            var weather = new Wheater(temperature, pressure, humidity);

            return weather;
        }
    }
}
