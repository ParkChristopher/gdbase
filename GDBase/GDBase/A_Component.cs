using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GDBase
{
    public abstract class A_Component
    {
        private string _name;
        private string _system;
        private int _year;
        private String _coverPath;



        public A_Component(string name, string system, int year, string cover)
        {
            _name = name;
            _system = system;
            _year = year;
            _coverPath = cover;
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

        public String CoverPath
        {
            get { return _coverPath;  }
            set { _coverPath = value; }
        }
        
    }
}
