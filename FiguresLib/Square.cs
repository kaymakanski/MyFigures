using System;
using System.Drawing;


namespace FiguresLib
{
    [Serializable]
    public class Square : Figures
    {
        public int Side { get; set; }
        public override double Area
        {
            get
            {
                return Side * Side;
            }
        }
        private static Color squareBaseColor = Color.Green;
        private static Square square = new Square();

        public override FiguresEnum FigureType => FiguresEnum.Square;
        public override void Paint(Graphics graphics)
        {
            using (var brush = new SolidBrush(Color.FromArgb(
               Math.Min(byte.MaxValue, Color.R + 50),
               Math.Min(byte.MaxValue, Color.G + 50),
               Math.Min(byte.MaxValue, Color.B + 50))))
                graphics.FillRectangle(brush, Location.X - Side / 2, Location.Y - Side / 2, Side, Side);

            using(var pen = new Pen(Color, 2))
                graphics.DrawRectangle(pen, Location.X - Side / 2, Location.Y - Side / 2, Side, Side);

        }

        public static Color getBaseColor
        {
            get
            {
                return square.BaseColor = squareBaseColor;
            }
        }
    }
}
