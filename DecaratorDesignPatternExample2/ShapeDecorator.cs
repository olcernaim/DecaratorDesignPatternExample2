using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorDesignPatternExample2
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape _decoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            _decoratedShape = decoratedShape;
        }
        public virtual void draw()
        {
            _decoratedShape.draw();
        }
    }
}
