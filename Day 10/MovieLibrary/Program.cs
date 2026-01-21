using System;
namespace MovieLibrary
{
    public class Program
    {
        public static void Main()
        {
            IFilmLibrary library=new FilmLibrary();
            library.AddFilm(new Film("Inception","Christopher Nolan",2014));
            library.AddFilm(new Film("Fight Club","David Fincher",1999));
            library.AddFilm(new Film("Lord of the Rings","Peter Jackson",2001));
            library.AddFilm(new Film("Avatar","James Cameron",2004));
            library.AddFilm(new Film("Baahubali","Rajamouli",2015));

            System.Console.Write("Enter a Film to remove: ");
            string rem=Console.ReadLine()!;
            library.RemoveFilm(rem);

            System.Console.WriteLine("Total Movies in the Library: ");
            List<IFilm> movielist=library.GetFilms();
            foreach(var item in movielist)
            {
                System.Console.WriteLine($"\t{item.Title} - {item.Director} - {item.Year}");
            }

            System.Console.Write("Enter a movie you want to search: ");
            string que=Console.ReadLine()!;
            List<IFilm> searchlist=library.SearchFilms(que);
            foreach(var item in searchlist)
            {
                System.Console.WriteLine($"\t{item.Title} - {item.Director} - {item.Year}");
            }

            System.Console.WriteLine($"Total no. of Films in Library: {library.GetTotalFilmCount()}");
        }
    }
}
