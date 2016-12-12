using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    abstract public class AbstractClass
    {
        public virtual void TemplateMethod()
        {
            Atakuj();
            Obrona();
        }

        public abstract double Atakuj();
        public abstract double Obrona();
    }
}
