using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ClassLibrary
{
    public class Helicopter : Air
    {
        protected int _numberOfPropellers;

        public Helicopter(string color, int numberOfPropellers) : base(color)
        {
            _color = color;
            _numberOfPropellers = numberOfPropellers;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Number of Propellers: {_numberOfPropellers}";
        }
    } // class
} // namespace
