using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Title { get; set; }
    public int Id { get; }
    public string Format { get; set; }
    private static List<Album> _instances = new List<Album> { };

    public Album(string title, string format)
    {
      Title = title;
      Format = format;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Album Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}