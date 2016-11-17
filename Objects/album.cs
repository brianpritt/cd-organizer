using System.Collections.Generic;

namespace AlbumOrganizer.Objects
{
  public class Album
  {
    private string _artist;
    private string _title;
    private string _genre;
    private int _id;

    private static List<Album> _allAlbums = new List<Album> {};

    public Album(string albumArtist, string albumTitle, string albumGenre = "none")
    {
      _artist = albumArtist;
      _title = albumTitle;
      _genre = albumGenre;
      _allAlbums.Add(this);
      _id = _allAlbums.Count;
    }

    public static List<Album> GetAll()
    {
      return _allAlbums;
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

    public Album FindById(int idNumber)
    {
      return _allAlbums[idNumber-1];
    }

  }
}
