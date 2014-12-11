using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDBase
{
    public abstract class A_Component
    {
        private string _name;
        private string _system;
        private int _year;


        public A_Component(string name, string system, int year)
        {
            _name = name;
            _system = system;
            _year = year;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string System
        {
            get { return _system; }
            set { _system = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        
    }
}
