using Nancy;
using System;
using System.Collections.Generic;
using AlbumOrganizer.Objects;

namespace AlbumOrganizer
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
      Get["/artists/new"] = _ =>{
        return View["new_artist_form.cshtml"];
      };
      Post["/artists"] = _ =>{
        string artistName = Request.Form["artist"];
        Artist newArtist = new Artist(artistName);
        List<Artist> allArtists = Artist.GetAll();
        return View["artists.cshtml", allArtists];
      };
      Get["/artists/{id}"] = parameters =>{
        var currentArtist = Artist.FindById(parameters.id);
        return View["artist.cshtml", currentArtist];
      };
      Get["/artists/{id}/new_album"] = parameters =>{
        var currentArtist = Artist.FindById(parameters.id);
        return View["new_album_form.cshtml", currentArtist];
      };
      Get["/search_by_artist"]= _ =>{
        return View["search_form.cshtml"];
      };
      Post["/search_results"] = _ =>{
        string search = Request.Form["artist"];
        var searchResults = Artist.SearchArtists(search);
        return View["search_results.cshtml", searchResults];
      };
      Post["/artist"] = _ =>{
        int artistId = Request.Form["artist-id"];
        string albumName = Request.Form["album"];
        var currentArtist = Artist.FindById(artistId);
        var currentAlbum = new Album(currentArtist.GetName(), albumName);
        currentArtist.AddAlbum(currentAlbum);
        return View["artist.cshtml", currentArtist];
      };

    }
  }
}
