using System;
using System.Drawing;

namespace FiguresLib
{
    [Serializable]
    public class Circle : Figures
    {
        public int Diameter { get; set; }
        public override double Area
        {
            get
            {
                return Math.PI * Diameter/2 * Diameter/2;
            }
        }

        private static Color circleBaseColor = Color.Red;
        private static Circle circle = new Circle();
        
        public override FiguresEnum FigureType => FiguresEnum.Circle;

        public override void Paint(Graphics graphics)
        {
            using (var brush = new SolidBrush(Color.FromArgb(
                Math.Min(byte.MaxValue, Color.R + 50),
                Math.Min(byte.MaxValue, Color.G + 50),
                Math.Min(byte.MaxValue, Color.B + 50))))
                graphics.FillEllipse(brush, Location.X - Diameter / 2, Location.Y - Diameter / 2, Diameter, Diameter);

            using(var pen = new Pen(Color, 2))
                graphics.DrawEllipse(pen, Location.X - Diameter/2, Location.Y - Diameter/2, Diameter, Diameter);                          
        }
        
        public static Color getBaseColor
        {          
            get
            {
                return circle.BaseColor = circleBaseColor;
            }
        }
    }
}
