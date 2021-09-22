using System;
namespace Catalog.Models
{
    public record Item
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public int Price { get; init; }
        public DateTimeOffset CreateDate { get; init; }
    }
}
