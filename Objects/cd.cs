using System.Collections.Generic;

namespace CdOrganizer.Objects
{
  public class Cd
  {
    private string _artist;
    private string _title;
    private string _genre;
    private int _id;

    private static List<Cd> _allCds = new List<Cd> {};

    public Cd(string cdArtist, string cdTitle, string cdGenre = "none")
    {
      _artist = cdArtist;
      _title = cdTitle;
      _genre = cdGenre;
      _allCds.Add(this);
      _id = _allCds.Count;
    }

    public static List<Cd> GetAll()
    {
      return _allCds;
    }

    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }
    public string GetArtist()
    {
      return _artist;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetTitle()
    {
      return _title;
    }

    public void SetGenre(string newGenre)
    {
      _genre = newGenre;
    }
    public string GetGenre()
    {
      return _genre;
    }

    public Cd FindById(int idNumber)
    {
      return _allCds[idNumber-1];
    }
    
  }
}
