

namespace FiguresLib
{
    public  class FiguresBuilder
    {
        private FiguresEnum figuresEnum;

        private FiguresBuilder() { }
        
        private int squareSide;
        private int rectangleWidth, rectangleHeight;
        private int circleDiameter;
        private int triangleSideAB, triangleSideAC;
        
        public static FiguresBuilder createSquare(int side)
        {
            FiguresBuilder squareBuilder = new FiguresBuilder();
            squareBuilder.figuresEnum = FiguresEnum.Square;
            squareBuilder.squareSide = side;

            return squareBuilder;
        }

        public static FiguresBuilder createRectangle(int width, int height)
        {
            FiguresBuilder rectangleBuilder = new FiguresBuilder();
            rectangleBuilder.figuresEnum = FiguresEnum.Rectangle;
            rectangleBuilder.rectangleWidth = width;
            rectangleBuilder.rectangleHeight = height;

            return rectangleBuilder;
        }

        public static FiguresBuilder createTriangle(int sideAB, int sideAC)
        {
            FiguresBuilder triangleBuilder = new FiguresBuilder();
            triangleBuilder.figuresEnum = FiguresEnum.Triangle;
            triangleBuilder.triangleSideAB = sideAB;
            triangleBuilder.triangleSideAC = sideAC;

            return triangleBuilder;
        }

        public static FiguresBuilder createCircle(int diameter)
        {
            FiguresBuilder circleBuilder = new FiguresBuilder();
            circleBuilder.figuresEnum = FiguresEnum.Circle;
            circleBuilder.circleDiameter = diameter;

            return circleBuilder;
        }

        public Figures build()
        {
            switch (figuresEnum)
            {
                case FiguresEnum.Square:
                    {
                        Square square = new Square();
                        square.Side = squareSide;
                        return square;
                    }
                case FiguresEnum.Rectangle:
                    {
                        Rectangle rectangle = new Rectangle();
                        rectangle.Width = rectangleWidth;
                        rectangle.Height = rectangleHeight;
                        return rectangle;
                    }
                case FiguresEnum.Circle:
                    {
                        Circle circle = new Circle();
                        circle.Diameter = circleDiameter;
                        return circle;
                    }
                case FiguresEnum.Triangle:
                    {
                        Triangle triangle = new Triangle();
                        triangle.SideAB = triangleSideAB;
                        triangle.SideAC = triangleSideAC;
                        return triangle;
                    }                    
            }
            return null;
        }
    }
}
