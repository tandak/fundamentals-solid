using FluentAssertions;
using Solid.Lib;
using Xunit;

namespace Solid.UnitTests
{
    public class LiskovSubstitutionPrincipleShould
    {
        /*
         * Formal Explanation: if S is a subtype of T, then objects of type T in a program may be replaced with objects of type S without altering any of the desirable
         * properties of that program 
         */

        [Fact]
        public void Return_Correct_Shape()
        {
            Shape shape = new CircleGood();
            shape.GetShape().Should().Be("Circle");

            shape = new TriangleGood();
            shape.GetShape().Should().Be("Triangle");
        }
    }
}
