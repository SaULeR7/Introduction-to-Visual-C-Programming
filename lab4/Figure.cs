using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal abstract class Figure
    {
        public abstract double Area();
    }

    class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(double _radius) {
            this.radius = _radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Figure
    {
        private double length;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public Rectangle(double _length, double _width)
        {
            this.length = _length;
            this.width = _width;
        }
        public override double Area()
        {
            return length * width;
        }
    }

    class Cylinder : Figure
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Cylinder(double _radius, double _height)
        {
            this.radius = _radius;
            this.height = _height;
        }
        public override double Area()
        {
            return (2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius,2));
        }
    }
}
