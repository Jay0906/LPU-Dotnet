using System;
using System.Runtime.ConstrainedExecution;
namespace RealEstateListingManagement
{
    public class Program
    {
        public static void Main()
        {
            RealEstateApp app=new RealEstateApp();

            app.AddListing(new RealEstateListing(1,"2BHK Apartment","Near IT Park",5000000,"Bengaluru"));
            app.AddListing(new RealEstateListing(2,"Villa","Near High-Tech City",5000000,"Hyderabad"));
            app.AddListing(new RealEstateListing(3,"Studio Apartment","T Nagar",5000000,"Chennai"));


            System.Console.WriteLine("All Listings: ");

            foreach(var item in app.GetListings())
            {
                System.Console.WriteLine($"{item.ID} - {item.Title} - {item.Description} - {item.Price} - {item.Location}");
            }


            System.Console.Write("Enter a Location: ");
            string Location=Console.ReadLine()!;
            foreach(var item in app.GetListingsbyLocation(Location))
            {
                System.Console.WriteLine($"{item.ID} - {item.Title} - {item.Description} - {item.Price} - {item.Location}");
            }


            System.Console.Write("Enter minPrice: ");
            int minPrice=int.Parse(Console.ReadLine()!);

            System.Console.Write("Enter maxPrice: ");
            int maxPrice=int.Parse(Console.ReadLine()!);

            foreach(var item in app.GetListingsByPriceRange(minPrice,maxPrice))
            {
                System.Console.WriteLine($"{item.ID} - {item.Title} - {item.Description} - {item.Price} - {item.Location}");
            }


            app.UpdateListing(new RealEstateListing(2,"3BHK Apartment","Near KPHB",6000000,"Hyderabad"));

            app.RemoveListing(3);
            
            System.Console.WriteLine("Final Listings: ");
            foreach(var item in app.GetListings())
            {
                System.Console.WriteLine($"{item.ID} - {item.Title} - {item.Description} - {item.Price} - {item.Location}");
            }
        }
    }
}
