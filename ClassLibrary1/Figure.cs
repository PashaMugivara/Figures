using System;

namespace ClassLibrary1
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public Figure (string name)
        {
            Name = name;
        }
        public abstract double Square();

    }
}
