using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Inventa.Order.Domain.Entities
{
    public class Ordering
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? CustomerId { get; set; }
        public List<OrderItem>? OrderItems { get; set; } = new();
        public ShippingAddress ShippingAddress { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public OrderStatus Status{ get; set; } = OrderStatus.Pending;

        public enum OrderStatus
        {
            Pending,
            Processing,
            Shipped,
            Delivered,
            Cancelled
        }
    }
}
