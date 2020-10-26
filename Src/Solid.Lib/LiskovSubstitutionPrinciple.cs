namespace Solid.Lib
{
    public class LiskovSubstitutionPrinciple
    {
        public string Principle =
            "extends the Open/Closed principle and enables you to replace objects of a parent class with objects of a subclass without breaking the application. This requires all subclasses to behave in the same way as the parent class. ";
    }

    public class TriangleBad
    {
        public virtual string GetShape()
        {
            return "Triangle";
        }
    }

    public class CircleBad : TriangleBad
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }

    public abstract class Shape
    {
        public abstract string GetShape();
    }

    public class TriangleGood : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }

    public class CircleGood : TriangleGood
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}
