using Moq;
using Moq.Protected;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace PhotoAlbumApp.Tests
{
    public class PhotoServiceTests
    {
        [Fact]
        public async Task GetPhotosByAlbumIdAsync_ReturnsPhotos()
        {
            // Arrange
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("[{\"albumId\": 3, \"id\": 1, \"title\": \"Test Title\", \"url\": \"http://example.com\", \"thumbnailUrl\": \"http://example.com/thumb\"}]"),
                });

            var httpClient = new HttpClient(mockHttpMessageHandler.Object)
            {
                BaseAddress = new Uri("http://example.com/"), // This should match your PhotoService BaseUrl
            };

            var photoService = new PhotoService(httpClient);

            // Act
            var result = await photoService.GetPhotosByAlbumIdAsync(3);

            // Assert
            Assert.Single(result);
            Assert.Equal(3, result[0].AlbumId);
            Assert.Equal(1, result[0].Id);
            Assert.Equal("Test Title", result[0].Title);
        }
    }
}
