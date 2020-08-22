using System;
using System.Drawing;


namespace FiguresLib
{
    [Serializable]
    public abstract class Figures
    {
        public virtual Color Color { get; set; }
        public virtual double Area { get; set; }
        public virtual Point Location { get; set; }
        public abstract void Paint(Graphics graphics);
        public virtual FiguresEnum FigureType { get; set; }
        protected Color BaseColor { get; set; }
        public override string ToString()
        {
            return $"|  {FigureType,-15}\t |  {Color.Name,-10}\t |  {Area:0.00} {"",-35}\t |";
        }
    }
}
