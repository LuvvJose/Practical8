using Practical8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical8.Models
{
    public class Triangle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int BaseLength { get; set; }
        public int Height { get; set; }

        public Triangle() { }

        public Triangle(string description, string fill, string strokeColour, double strokeWidth,
                        int x, int y, int baseLength, int height)
            : base(description, fill, strokeColour, strokeWidth)
        {
            X = x;
            Y = y;
            BaseLength = baseLength;
            Height = height;
        }

        public override double getArea()
        {
            return 0.5 * BaseLength * Height;
        }

        public override string getSVG()
        {
            int x1 = X;
            int y1 = Y;
            int x2 = X + BaseLength;
            int y2 = Y;
            int x3 = X + (BaseLength / 2);
            int y3 = Y - Height;

            return $"<svg width='{SvgWidth}' height='{SvgHeight}'>" +
                   $"<polygon points='{x1},{y1} {x2},{y2} {x3},{y3}' " +
                   $"fill='{Fill}' stroke='{StrokeColour}' stroke-width='{StrokeWidth}' />" +
                   $"</svg>";
        }
    }

}