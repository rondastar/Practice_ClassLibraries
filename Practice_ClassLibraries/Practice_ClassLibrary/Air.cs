using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ClassLibrary
{
    public class Air : Vehicle
    {
        //Class Air takes no additional information
        public Air(string color) : base(color)
        {
            _color = color;
        }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
