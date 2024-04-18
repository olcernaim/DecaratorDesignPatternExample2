using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorDesignPatternExample2
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {

        }

        public override void draw()
        {
            _decoratedShape.draw();
            this.SetBorder(_decoratedShape);
        }

        private void SetBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color : Red");
        }
    }
}
