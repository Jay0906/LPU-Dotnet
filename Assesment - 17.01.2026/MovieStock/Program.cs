using System;
using System.Runtime.InteropServices.Marshalling;
namespace MovieStock
{
    public class Program
    {
        public static void Main()
        {
            // System.Console.WriteLine("Enter the Movie details in-order: ");
            // System.Console.WriteLine("Title , Artist , Genre , Ratings");
            // var details=Console.ReadLine();

            MoviesList mv=new MoviesList();
            mv.AddMovie("Varanasi,MaheshBabu,Action,5");
            mv.AddMovie("Spirit,prabhas,Drama,5");
            mv.AddMovie("Kalki,Prabhas,Fantasy,4");
            mv.AddMovie("Salaar,Prabhas,Action-Drama,4");
            mv.AddMovie("RajaSaab,Prabhas,Horror,2");

            System.Console.Write("Enter the Genre you want to search: ");
            var gen=Console.ReadLine();
            List<Movie> genrelist=mv.ViewMoviesByGenre(gen);
            if (genrelist.Count==0)
            {
                System.Console.WriteLine($"No movies found in Genre - {gen}");
            }
            else
            {
                foreach(var item in genrelist)
                {
                    System.Console.WriteLine($"\t{item.Title} - {item.Genre}");
                }
            }

            List<Movie> sortedMovies=mv.ViewMoviesByRatings();
            System.Console.WriteLine("Movies by Ratings: ");
            foreach(var item in sortedMovies)
            {
                System.Console.WriteLine($"\t{item.Title} - {item.Ratings}");
            }
        }
    }
}
