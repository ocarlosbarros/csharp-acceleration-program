class Program
{
    public static void Main(string[] args)
    {
        var movie = new Movie("Matrix", "Ficção Científica");
        var secondMovie = new Movie("Senhor dos Anéis: A sociedade do anel", "Fantasia");

        Console.WriteLine(movie.Title);
        Console.WriteLine(secondMovie.Category);

        movie.Title = "Matrix Revolution";

        Console.WriteLine(movie.Title);

        //movie.Category = "Action";//Unhandled exception. System.Exception: Category not allowed
        movie.Category = "Fantasia";
        Console.WriteLine(movie.Category);
    }
}