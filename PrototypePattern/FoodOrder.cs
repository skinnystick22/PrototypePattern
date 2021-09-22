using System;

namespace PrototypePattern
{
    public class FoodOrder : Prototype
    {
        public string CustomerName { get; set; }
        public bool IsDelivery { get; set; }
        public string[] OrderContents { get; set; }
        public OrderInfo OrderInfo { get; set; }

        public FoodOrder(string customerName, bool isDelivery, string[] orderContents, OrderInfo orderInfo)
        {
            CustomerName = customerName;
            IsDelivery = isDelivery;
            OrderContents = orderContents;
            OrderInfo = orderInfo;
        }

        public override Prototype ShallowCopy()
        {
            return (Prototype)MemberwiseClone();
        }

        public override Prototype DeepCopy()
        {
            var clonedOrder = (FoodOrder)MemberwiseClone();
            clonedOrder.OrderInfo = new OrderInfo(OrderInfo.Id);

            return clonedOrder;
        }

        public override void Debug()
        {
            Console.WriteLine($"------ Prototype Food Order ------");
            Console.WriteLine($"Name: {CustomerName}");
            Console.WriteLine($"Delivery: {IsDelivery}");
            Console.WriteLine($"ID: {OrderInfo.Id}");
            Console.WriteLine($"Order Contents: {string.Join(',', OrderContents)}");
        }
    }
}