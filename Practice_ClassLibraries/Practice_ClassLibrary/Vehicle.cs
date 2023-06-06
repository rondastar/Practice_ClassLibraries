using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ClassLibrary
{
    public class Vehicle
    {
        //    fields
        // string color
        protected string _color;

        //constructor and property for all
        public Vehicle(string color)
        {
            _color = color;
        }
        public string Color { get => _color; set => _color = value; }

        //override tostring(this.gettype() - color ) ex: shape - red
        public override string ToString()
        {
            return $"{this.GetType()} - Color: {Color}";
        }
    } // class
} // namespace
