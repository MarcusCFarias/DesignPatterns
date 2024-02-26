using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Unsubscriber : IDisposable
    {
        private List<IObserver<Wheater>> _observers;
        private IObserver<Wheater> _observer;

        public Unsubscriber(List<IObserver<Wheater>> observers, IObserver<Wheater> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer)) 
                _observers.Remove(_observer);
        }
    }
}
