using System;
using System.Drawing;


namespace FiguresLib
{
    [Serializable]
    public class RandomFigure : Figures
    {
        private static Random random = new Random();
       
        public override FiguresEnum FigureType { get; set; }

     /*   private static Color getRandomColor()
        {
            var allColors = Enum.GetValues(typeof(ColorsEnum));
            ColorsEnum randomColor = (ColorsEnum)allColors.GetValue(random.Next(allColors.Length));
            return Color.FromName(randomColor.ToString());
        }

        public static Figures generateRandomFigure()
        {
            int figureType = random.Next(4);
            Figures randomFigure = null;
            switch (figureType)
            {
                case 0:
                    randomFigure = new Circle();
                    ((Circle)randomFigure).Diameter = random.Next(250);
                    ((Circle)randomFigure).FigureType = FiguresEnum.Circle;
                    break;
                case 1:
                    randomFigure = new Rectangle();
                    ((Rectangle)randomFigure).Height = random.Next(250);
                    ((Rectangle)randomFigure).Width = random.Next(250);
                    ((Rectangle)randomFigure).FigureType = FiguresEnum.Rectangle;
                    break;
                case 2:
                    randomFigure = new Square();
                    ((Square)randomFigure).Side = random.Next(250);
                    ((Square)randomFigure).FigureType = FiguresEnum.Square;
                    break;
                case 3:
                    randomFigure = new Triangle();
                    ((Triangle)randomFigure).SideAB = random.Next(250);
                    ((Triangle)randomFigure).SideAC = random.Next(250);
                    ((Triangle)randomFigure).FigureType = FiguresEnum.Triangle;
                    break;
            }
            randomFigure.Location = new Point(random.Next(1400), random.Next(700));
            randomFigure.Color = getRandomColor();
            return randomFigure;
        }*/

        protected int randomColor = random.Next(9);
        protected int figureType = random.Next(4);
        protected int x = random.Next(1400);
        private int y = random.Next(700);
        private int width = random.Next(250);
        private int height = random.Next(250);
        public static FiguresEnum InnerFigureType { get; set; }
        public override double Area { get; set; }
        public override Color Color
        {
            get
            {
                switch (randomColor)
                {
                    case 0:
                        return Color.Red;
                    case 1:
                        return Color.Blue;
                    case 2:
                        return Color.Yellow;
                    case 3:
                        return Color.Green;
                    case 4:
                        return Color.Purple;
                    case 5:
                        return Color.Tan;
                    case 6:
                        return Color.Brown;
                    case 7:
                        return Color.Teal;
                    case 8:
                        return Color.Coral;
                }
                return default;
            }
        }
        public override void Paint(Graphics graphics)
        {
            using (var brush = new SolidBrush(Color))
            {
                switch (figureType)
                {
                    case 0:
                        {
                            graphics.FillEllipse(brush, x, y, width, width);
                            InnerFigureType = FiguresEnum.Circle;
                            FigureType = FiguresEnum.Circle;
                            Area = Math.PI * width * width;
                            break;
                        }
                    case 1:
                        {
                            graphics.FillRectangle(brush, x, y, width, height);
                            InnerFigureType = FiguresEnum.Rectangle;
                            FigureType = FiguresEnum.Rectangle;
                            Area = width * height;
                            break;
                        }
                    case 2:
                        {
                            graphics.FillRectangle(brush, x, y, width, width);
                            InnerFigureType = FiguresEnum.Square;
                            FigureType = FiguresEnum.Square;
                            Area = width * width;
                            break;
                        }
                    case 3:
                        {
                            Point[] points = new Point[]
                            {
                                    new Point(x, y),
                                    new Point(x, y + width),
                                    new Point(x + height, y + width)
                            };
                            graphics.FillPolygon(brush, points);
                            InnerFigureType = FiguresEnum.Triangle;
                            FigureType = FiguresEnum.Triangle;
                            Area = width * height / 2;
                            break;
                        }
                }
            }
        }
    }
}
