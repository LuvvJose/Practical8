using System;

namespace Practical8.Models
{
    public class Ellipse : Shape
    {
        public int Cx { get; set; }
        public int Cy { get; set; }
        public int Rx { get; set; }
        public int Ry { get; set; }

        public Ellipse() { }

        public Ellipse(string description, string fill, string strokeColour, double strokeWidth,
                       int cx, int cy, int rx, int ry)
            : base(description, fill, strokeColour, strokeWidth)
        {
            Cx = cx;
            Cy = cy;
            Rx = rx;
            Ry = ry;
        }

        public override double getArea() => Math.PI * Rx * Ry;

        public override string getSVG() =>
            $"<svg width='{SvgWidth}' height='{SvgHeight}'>" +
            $"<ellipse cx='{Cx}' cy='{Cy}' rx='{Rx}' ry='{Ry}' " +
            $"fill='{Fill}' stroke='{StrokeColour}' stroke-width='{StrokeWidth}' />" +
            $"</svg>";
    }
}
