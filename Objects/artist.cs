using System.Collections.Generic;

namespace CdOrganizer.Objects
{
  public class Artist
  {
    private string _name;
    private static List<Artist> _instances = new List<Artist> {};
    private int _id;
    private List<Cd> _cds;

    public Artist(string artistName)
    {
      _name = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      _cds = new List<Cd>{};
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
    public List<Cd> GetCds()
    {
      return _cds;
    }
    public Artist FindById(int idNumber)
    {
      return _instances[idNumber-1];
    }
  }
}
