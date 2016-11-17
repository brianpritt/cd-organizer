using System.Collections.Generic;

namespace AlbumOrganizer.Objects
{
  public class Artist
  {
    private string _name;
    private static List<Artist> _instances = new List<Artist> {};
    private int _id;
    private List<Album> _albums;

    public Artist(string artistName)
    {
      _name = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      _albums = new List<Album>{};
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public static List<Artist> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
    public List<Album> GetAlbums()
    {
      return _albums;
    }
    public static Artist FindById(int idNumber)
    {
      return _instances[idNumber-1];
    }
    public void AddAlbum(Album newAlbum)
    {
      _albums.Add(newAlbum);
    }
    public static List<Artist> SearchArtists(string searchInput)
    {
      List<Artist> searchList = new List<Artist> {};
      string searchInputLower = searchInput.ToLower();
      foreach (Artist artist in _instances)
      {
        string artistName = artist.GetName().ToLower();
        if (artistName.Contains(searchInputLower))
        {
          searchList.Add(artist);
        }
      }
      return searchList;
    }
  }
}
