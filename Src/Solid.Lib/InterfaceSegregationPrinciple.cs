using System;

namespace Solid.Lib
{
    public class InterfaceSegregationPrinciple
    {
        public string Principle = " No client should be forced to implement methods which it does not use";
    }

    public interface IOrder
    {
        void AddToCart();
    }

    public interface IOnlineOrder
    {
        void CCProcess();
    }

    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }

        public void CCProcess()
        {
            //process through credit card
        }
    }

    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
    }
}
