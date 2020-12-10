using System;
using System.Collections.Generic;
using System.IO;

namespace BoxOffice
{
    class Program
    {
        class Movie
        {
            int id;
            string title;
            long lifeTimeGross;

            public Movie(int _id, string  _title, long _lifeTimeGross)
            {
                id = _id;
                title = _title;
                lifeTimeGross = _lifeTimeGross;
            }

            public int Id { get { return id; } }
            public string Title { get { return title; } }
            public long LifeTimeGross { get { return lifeTimeGross;  } }

        }

        class MovieList
        {
            List<Movie> movies;
            long totalLifeGross = 0;

            public MovieList()
            {
                movies = new List<Movie>();
                totalLifeGross = 0;
            }

            public void AddMoviesToList(int id, string title, long gross)
            {
                Movie newMovie = new Movie(id, title, gross);
                movies.Add(newMovie);
            }

            public void PrintAllMovies()
            {
                foreach(Movie movie in movies)
                {
                    Console.WriteLine($"{movie.Id}. {movie.Title} has earned {movie.LifeTimeGross}");
                }

            }

        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"BoxOffice.txt";
            string fullFilePath = Path.Combine(filePath, fileName);
            
            //create an arry of records from file
            string[] linesFromfile = File.ReadAllLines(fullFilePath);

            //create a list of movies to store the movie objects from file
            foreach(string line in linesFromfile)
            {
                //split the line to get the movie data
                string[] tempArry = line.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                int moviesd = int.Parse(tempArry[0]);
                string movieTitle = tempArry[1];
                string totalGrossTemp = tempArry[2].Substring(1);
                Console.WriteLine(totalGrossTemp);
            }
        }
        


       
    }
}
