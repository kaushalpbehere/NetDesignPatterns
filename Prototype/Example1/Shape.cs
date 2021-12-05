namespace Prototype.Example1
{
    public abstract class Shape
    {
        /// <summary>
        /// Private field.
        /// </summary>
        readonly int x;

        /// <summary>
        /// Private field.
        /// </summary>
        readonly int y;

        /// <summary>
        /// Property to interact with x.
        /// </summary>
        public int X { get { return x; } }

        /// <summary>
        /// Property to interact with y.
        /// </summary>
        public int Y { get { return y; } }

        /// <summary>
        /// Constructor for the class.
        /// </summary>
        /// <param name="id"></param>
        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Provision to clone the object.
        /// </summary>
        /// <returns></returns>
        public abstract Shape Clone();
    }
}