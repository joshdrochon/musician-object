using System;
using System.Collections.Generic;

public class Musician
{
  public string Name;
  public string Instrument;
  public string Genre;
}

public class Program
{
  public static void Main()
  {
    Musician hendrix = new Musician();
    hendrix.Name = "Jimi Hendrix";
    hendrix.Instrument = "Guitar";
    hendrix.Genre = "Rock";

    Musician bellamy = new Musician();
    bellamy.Name = "Matthew Bellamy";
    bellamy.Instrument = "Guitar";
    bellamy.Genre = "Space Rock";

    Musician stirling = new Musician();
    stirling.Name = "Lindsey Stirling";
    stirling.Instrument = "Violin";
    stirling.Genre = "Electronica";


    List<Musician> InfoBook = new List<Musician>() { hendrix, bellamy, stirling};

    Musician jackson = new Musician();
    jackson.Name = "Michael Jackson";
    jackson.Instrument = "Vocals";
    jackson.Genre = "Pop";

    InfoBook.Add(jackson);


    foreach (Musician element in InfoBook)
    {
      Console.WriteLine("Name: " + element.Name);
      Console.WriteLine("Instrument: " + element.Instrument);
      Console.WriteLine("Genre: " + element.Genre);
    }


  }
}
