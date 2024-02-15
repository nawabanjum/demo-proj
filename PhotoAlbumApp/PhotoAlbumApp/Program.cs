
using PhotoAlbumApp;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new HttpClient();
        var photoService = new PhotoService(client);

        var albumId = 3;
        var photos = await photoService.GetPhotosByAlbumIdAsync(albumId);

        Console.WriteLine($"photo-album {albumId}");

        foreach (var photo in photos)
        {
            Console.WriteLine($"[{photo.Id}] {photo.Title}");
        }
    }
}