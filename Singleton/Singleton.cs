namespace Singleton
{
    public class Singleton
    {
        /// <summary>
        /// Object of the class.
        /// </summary>
        private static Singleton instance;

        /// <summary>
        /// Constructor made private. To stop new object creations from outside world.
        /// </summary>
        private Singleton()
        {
            this.Counter = 1;
        }

        /// <summary>
        /// A static method to create instance of an object.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static Singleton CreateInstance()
        {
            if (Singleton.instance == null) Singleton.instance = new Singleton();
            return Singleton.instance;
        }

        /// <summary>
        /// A counter to check the number of times this class is initialized adn called.
        /// </summary>
        private int Counter;

        /// <summary>
        /// To call this method is to increment the counter.
        /// </summary>
        public void IncrementOnCall()
        {
            this.Counter++;
        }

        /// <summary>
        /// Gets the current value of the counter.
        /// </summary>
        /// <returns>int.</returns>
        public int GetCounter()
        {
            return this.Counter;
        }
    }
}