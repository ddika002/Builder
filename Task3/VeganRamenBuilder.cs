using BuilderAssignment.Enums;
using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    internal class VeganRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();
        public void settingBroth()
        {
            ramen.Broth = BrothType.Vegan;
        }

        public void settingNoodle()
        {
            ramen.Noodle = NoodleType.Soba;
        }
        public void addTopping()
        {
            ramen.Topping.Add(Topping.BambooShoots);
            ramen.Topping.Add(Topping.Seaweed);
        }
        public void addExtra()
        {
            ramen.Extra = null;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }

    }
}