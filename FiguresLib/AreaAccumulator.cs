using System;

namespace FiguresLib
{
    [Serializable]
    public class AreaAccumulator
    {
        public static double CircleArea { get; set; }
        public static double RectangleArea { get; set; }
        public static double SquareArea { get; set; }
        public static double TriangleArea { get; set; }

        public static void accumulateArea(double figureArea, FiguresEnum figureType)
        {
            switch (figureType)
            {
                case FiguresEnum.Square:
                    {
                        SquareArea += figureArea;
                        break;
                    }
                case FiguresEnum.Rectangle:
                    {
                        RectangleArea += figureArea;
                        break;
                    }
                case FiguresEnum.Circle:
                    {
                        CircleArea += figureArea;
                        break;
                    }
                case FiguresEnum.Triangle:
                    {
                        TriangleArea += figureArea;
                        break;
                    }
                case FiguresEnum.RandomFigure:
                    {                        
                        if (RandomFigure.InnerFigureType.Equals(FiguresEnum.Circle))
                            CircleArea += figureArea;
                        if (RandomFigure.InnerFigureType.Equals(FiguresEnum.Square))
                            SquareArea += figureArea;
                        if (RandomFigure.InnerFigureType.Equals(FiguresEnum.Rectangle))
                            RectangleArea += figureArea;
                        if (RandomFigure.InnerFigureType.Equals(FiguresEnum.Triangle))
                            TriangleArea += figureArea;
                        break;
                    }
            }
        }

        public static void resetArea(FiguresEnum figureType)
        {
            switch (figureType)
            {
                case FiguresEnum.Square:
                    {
                        SquareArea = 0;
                        break;
                    }
                case FiguresEnum.Rectangle:
                    {
                        RectangleArea = 0;
                        break;
                    }
                case FiguresEnum.Circle:
                    {
                        CircleArea = 0;
                        break;
                    }
                case FiguresEnum.Triangle:
                    {
                        TriangleArea = 0;
                        break;
                    }
            }
        }
    }
}
