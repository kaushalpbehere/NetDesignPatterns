namespace Prototype.Example1
{
    public class Reactangle : Shape
    {
        public Reactangle(int length, int breadth) : base(length, breadth)
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
