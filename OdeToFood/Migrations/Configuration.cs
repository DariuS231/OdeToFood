namespace OdeToFood.Migrations
{
    using OdeToFood.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToFood.Models.OdeToFoodDb";
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant
                {
                    Name = "Temples",
                    City = "London",
                    Country = "United Kingdom",
                    Reviews = new List<RestaurantReview> { 
                        new RestaurantReview{ Rating = 2, Body="Bad!", ReviewerName="Linda Bower"} ,
                        new RestaurantReview{ Rating = 5, Body="Good food!", ReviewerName="Maria Lopez"} 
                    }
                },
                new Restaurant
                {
                    Name = "Paknyo",
                    City = "Madrid",
                    Country = "Spain",
                    Reviews = new List<RestaurantReview> { 
                        new RestaurantReview{ Rating = 9, Body="Great!", ReviewerName="John Owen"} 
                    }
                },
                new Restaurant { Name = "Henrics", City = "Barcelona", Country = "Spain" });
        }
    }
}
