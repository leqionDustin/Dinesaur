using Dinesaur.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class ReviewsSeeding : IEntityTypeConfiguration<Review>
    {

        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    ReviewTitle = "Excellent Service",
                    ReviewID = 1,
                    Date = DateTime.Now,
                    Rating = 4.5,
                    Description = "Friendly staff and quick service. Will come again.",
                    RestaurantID = 1,
                    CustomerID = "2"
                },

            new Review
            {
                ReviewTitle = "Average Experience",
                ReviewID = 2,
                Date = DateTime.Now,
                Rating = 3.0,
                Description = "Food was okay, but waiting time was a bit long.",
                RestaurantID = 2,
                CustomerID = "8"
            },

            new Review
            {
                ReviewTitle = "Great Food",
                ReviewID = 3,
                Date = DateTime.Now,
                Rating = 4.0,
                Description = "Food quality was great and portions were generous.",
                RestaurantID = 3,
                CustomerID = "10"
            }
            );
        }
    }
}
