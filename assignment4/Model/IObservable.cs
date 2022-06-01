using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public interface IObservable
    {
        void NieuweMeting();

        void Add(IObserver observer);

        void Delete(IObserver observer);
    }
}
