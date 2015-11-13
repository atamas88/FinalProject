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
                CategoryId = 1

            });

            foreach (Company com in companies)
                context.Companies.Add(com);



            base.Seed(context);
        }
    }
}
