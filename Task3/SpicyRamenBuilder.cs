using BuilderAssignment.Enums;
using BuilderAssignment.Models;


namespace BuilderAssignment.Builders
{
    internal class SpicyRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();
        public void settingBroth()
        {
            ramen.Broth = BrothType.SpicyTonkotsu;
        }

        public void settingNoodle()
        {
            ramen.Noodle = NoodleType.Thin;
        }
        public void addTopping()
        {
            ramen.Topping.Add(Topping.ChashuPork);
            ramen.Topping.Add(Topping.GreenOnions);
        }
        public void addExtra()
        {
            ramen.Extra.Add(Extra.ExtraSpice);
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}