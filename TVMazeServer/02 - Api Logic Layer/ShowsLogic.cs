using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace TVMaze
{
    public class ShowsLogic
    {
        public List<Series> GetShowBySearchText(string searchText)
        {
            var client = new RestClient($"http://api.tvmaze.com/search/shows?q={searchText}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            List<FullShow> fullShows = JsonConvert.DeserializeObject<List<FullShow>>(response.Content);
            List<Series> shows = new List<Series>();
            foreach (var show in fullShows)
            {
                shows.Add(new Series
                {
                    ID = show.Show.id,
                    Url = show.Show.url,
                    Rating = show.Show.rating,
                    Image=show.Show.image,
                    Name=show.Show.name,
                    OfficialSite=show.Show.officialSite
                });
            }
            return shows;
        }
    }
}
