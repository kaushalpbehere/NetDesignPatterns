namespace Prototype.Example1
{
    public class Circle : Shape
    {
        public Circle(int radius) : base(radius, radius)
        {

        }

        /// <summary>
        /// Creates a shallow copy of the current
        /// </summary>
        /// <returns>Shape Type of object.</returns>
        public override Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }
    }
}
