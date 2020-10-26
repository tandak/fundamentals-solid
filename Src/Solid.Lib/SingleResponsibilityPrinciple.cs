namespace Solid.Lib
{
    public class SingleResponsibilityPrinciple
    {
        public string Principle = "A class should have ONE SINGLE RESPONSIBILITY";
    }

    public class ChickenShop //Bad example (Chicken Shop class is has too much responsibility)
    {
        public void TakeOrder(string order)
        {
            // Order Logic
        }

        public void CookFood(string order)
        {
            // Cooking Logic
        }
    }

    public class ChickenShopGood //Better example (Chicken Shop has moved the cooking responsibility out of the shop)
    {
        private readonly ICooker _cooker;

        public ChickenShopGood(ICooker cooker)
        {
            _cooker = cooker;
        }

        public void TakeOrder(string order)
        {
            _cooker.CookChicken(order);
        }
    }

    public interface ICooker
    {
        void CookChicken(string order);
    }
}
