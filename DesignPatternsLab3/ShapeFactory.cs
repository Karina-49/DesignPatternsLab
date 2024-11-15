using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsLab3;

public abstract class ShapeFactory
{
    public abstract Shape CreateShape(); // Фабричный метод
}

public class CircleFactory : ShapeFactory
{
    public override Shape CreateShape()
    {
        return new Circle();
    }
}

public class SquareFactory : ShapeFactory
{
    public override Shape CreateShape()
    {
        return new Square();
    }
}

