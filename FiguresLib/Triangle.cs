using System;
using System.Drawing;

namespace FiguresLib
{
    [Serializable]
     public class Triangle : Figures
    {

        public int SideAB { get; set; }
        public int SideAC { get; set; }

        public override double Area
        {
            get
            {
                return SideAB * SideAC / 2;
            }
        }
        private static Color triangleBaseColor = Color.Purple;
        private static Triangle triangle = new Triangle();
        
        public override FiguresEnum FigureType => FiguresEnum.Triangle;

        public override void Paint(Graphics graphics)
        {
            Point[] points = new Point[]
            {
                new Point(Location.X - SideAB/2, Location.Y - SideAC/2),
                new Point(Location.X - SideAB/2, Location.Y + SideAC/2),
                new Point(Location.X + SideAB/2, Location.Y + SideAC/2)
            };

            using (var brush = new SolidBrush(Color.FromArgb(
                  Math.Min(byte.MaxValue, Color.R + 50),
                  Math.Min(byte.MaxValue, Color.G + 50),
                  Math.Min(byte.MaxValue, Color.B + 50))))
                graphics.FillPolygon(brush, points);

            using (var pen = new Pen(Color, 2))
                graphics.DrawPolygon(pen, points);
        }
        public static Color getBaseColor
        {
            get
            {
                return triangle.BaseColor = triangleBaseColor;
            }
        }
    }
}
