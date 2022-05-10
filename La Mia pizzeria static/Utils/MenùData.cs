using La_Mia_pizzeria_static.Models;

namespace La_Mia_pizzeria_static.Utils
{
    public static class MenùData
    {
        private static List<Pizza> pizze;

        public static List<Pizza> GetPizze()
        {
            if(MenùData.pizze != null)
            {
                return MenùData.pizze;
            }

            List<Pizza> nuovaListaPizza = new List<Pizza>();

            for(int i = 0; i < 5; i++)
            {
                Pizza pizza = new Pizza();
            }


        }
    }
}
