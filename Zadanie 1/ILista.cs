using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumZadanie1
{
    public interface ILista<T>
    {
        void push(T v);
        T pop(int position);
    }
}
