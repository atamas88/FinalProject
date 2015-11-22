using LifeInEsbjergDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInEsbjergDAL.Context
{
    public class LifeInContextInitializer : DropCreateDatabaseAlways<LifeInContext>
    {

        protected override void Seed(LifeInContext context)
        {
            IList<Company> companies = new List<Company>();


            Category category1 = context.Categories.Add(new Category() { Id = 1, Name = "Bank" });
            Category category2 = context.Categories.Add(new Category() { Id = 2, Name = "Plumber" });
            Category category3 = context.Categories.Add(new Category() { Id = 3, Name = "Electrician" });

            Rating rating1 = context.Ratings.Add(new Rating() { Id = 1, CustomerService = 1, Quality = 2, Price = 3, OverAll = 2 });
            Rating rating2 = context.Ratings.Add(new Rating() { Id = 2, CustomerService = 2, Quality = 4, Price = 3, OverAll = 3 });

            Review rev1 = context.Reviews.Add(new Review() { Id = 1, Title = "Great Stuff", Text = "I like the overall experience", Date = DateTime.Now });
            Review rev2 = context.Reviews.Add(new Review() { Id = 2, Title = "Awfull", Text = "Very very bad experience", Date = DateTime.Now });

            //Customer customer1 = context.Customers.Add(new Customer() { Id = 1, Name = "Kim Cormen", Email = "Google@google.tinfoil", Password = "1234abcd" });

            companies.Add(new Company()
            {
                Name = "JensBank",
                ImageUrl = "www.image.com/vkld",
                Address = "Stormgade66",
                WebSite = "www.jensbank.dk",
                Tel = "+45959595",
                OpenHours = "9-10",
                MinPrice = 500,
                MaxPrice = 1000,
                Description = "Small local bank",
                Category = category1,
                Ratings = new List<Rating>() { rating1, rating2 },
                Reviews = new List<Review>() { rev1, rev2 }

            });

            foreach (Company com in companies)
                context.Companies.Add(com);



            base.Seed(context);
        }
    }
}
