using System;

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

        public override double getArea() => 0.5 * BaseLength * Height;

        public override string getSVG()
        {
            var points = $"{X},{Y} {X + BaseLength},{Y} {X + BaseLength / 2},{Y - Height}";
            return $"<svg width='{SvgWidth}' height='{SvgHeight}'>" +
                   $"<polygon points='{points}' fill='{Fill}' stroke='{StrokeColour}' stroke-width='{StrokeWidth}' />" +
                   $"</svg>";
        }
    }
}
