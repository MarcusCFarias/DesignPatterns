using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class WheaterMonitor : IObserver<Wheater>
    {
        private IDisposable unsubscriber;

        public virtual void Subscribe(IObservable<Wheater> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
        public void OnCompleted()
        {
            Console.WriteLine("Metrics received.\n");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.Message.ToString());
        }

        public void OnNext(Wheater value)
        {
            if (value is null)
                this.OnError(new NullReferenceException("No value for weather"));
            else
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("Wheater today: ");
                sb.AppendLine(value.DateTime.ToString());
                sb.Append("Temperature: ");
                sb.AppendLine(value.Temperature.ToString());
                sb.Append("Pressure: ");
                sb.AppendLine(value.Pressure.ToString());
                sb.Append("Humidity: ");
                sb.Append(value.Humidity.ToString());

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
