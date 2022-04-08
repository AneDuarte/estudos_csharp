using System.Text;
using System.Globalization;

namespace MiniEcommerce.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Product}, {Price}, Qauntity: {Quantity}, Subtotal {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}