using System;
using System.Drawing;


namespace FiguresLib
{
    [Serializable]
    public class Rectangle : Figures
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
        private static Color rectangleBaseColor = Color.Blue;
        private static Rectangle rectangle = new Rectangle();

        public override FiguresEnum FigureType => FiguresEnum.Rectangle;
        public override void Paint(Graphics graphics)
        {
            using (var brush = new SolidBrush(Color.FromArgb(
               Math.Min(byte.MaxValue, Color.R + 50),
               Math.Min(byte.MaxValue, Color.G + 50),
               Math.Min(byte.MaxValue, Color.B + 50))))
                graphics.FillRectangle(brush, Location.X - Width / 2, Location.Y - Height / 2, Width, Height);
            
            using (var pen = new Pen(Color, 2))
                graphics.DrawRectangle(pen, Location.X - Width/2, Location.Y - Height/2, Width, Height);
        }
        public static Color getBaseColor
        {
            get
            {
                return rectangle.BaseColor = rectangleBaseColor;
            }
        }
    }
}
