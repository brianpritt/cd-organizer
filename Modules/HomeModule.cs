using Nancy;
using System.Collections.Generic;
using CdOrganizer.Objects;

namespace CdOrganizer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Get["/artists"] = _ =>{
        return View["artists.cshtml", Artist.GetAll()];
      };
      Get["/artists/{id}"] = parameters =>{
        Artist currentArtist = Artist.FindById(parameters.id);
        return View["artist.cshtml", currentArtist];
      };
      Get["/artists/{id}/new_album"] = parameters =>{
        Artist currentArtist = Artist.FindById(parameters.id);
        return View["new_album_form.cshtml", currentArtist];
      };

      Post["/artists"] = _ =>{
        string artistName = Request.Form["name"];
        Artist newArtist = new Artist(artistName);
        var allArtists = Artist.GetAll();
        return View["artists.cshtml", allArtists];
      };
    }
  }
}
