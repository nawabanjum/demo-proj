using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumApp
{
    public class PhotoService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://jsonplaceholder.typicode.com/photos";

        public PhotoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Photo>> GetPhotosByAlbumIdAsync(int albumId)
        {
            var response = await _httpClient.GetStringAsync($"{BaseUrl}?albumId={albumId}");
            return JsonConvert.DeserializeObject<List<Photo>>(response);
        }
    }
}
