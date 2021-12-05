using Builder.Example1.Builder;

namespace Builder.Example1
{
    public class Director
    {
        public House house;

        /// <summary>
        /// Construct a Simple House.
        /// </summary>
        /// <param name="simpleHouse">SimpleHouse Builder object.</param>
        public  void ConstructSimpleHouse(SimpleHouse simpleHouse)
        {
            simpleHouse.BuildFoundation();
            simpleHouse.BuildBasicInfrastructure();
            simpleHouse.BuildAdditionalSystems();
        }

        /// <summary>
        /// Construct a Fancy House.
        /// </summary>
        /// <param name="simpleHouse">SimpleHouse Builder object.</param>
        public  void ConstructFancyHouse(FancyGlassHouse fancyGlassHouse)
        {

            fancyGlassHouse.BuildFoundation();
            fancyGlassHouse.BuildBasicInfrastructure();
            fancyGlassHouse.BuildAdditionalSystems();
        }

        /// <summary>
        /// Construct a more expensive gold House. (Which does not implement the standard interface.
        /// </summary>
        /// <param name="simpleHouse">SimpleHouse Builder object.</param>
        public  void ConstructGoldHouse(GoldHouse goldHouse)
        {
            goldHouse.BuildGoldFoundation();
            goldHouse.BuildExpensiveInfrastructure();
            goldHouse.BuildGoldSystems();


        }
    }
}