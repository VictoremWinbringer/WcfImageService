using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Web.Configuration;
using Dapper;

namespace WcfApi
{
    internal sealed class ImageService : IImageService
    {
        private readonly string _connection;

        public ImageService()
        {
            _connection = WebConfigurationManager.ConnectionStrings["main"].ConnectionString;
        }

        private SqlConnection CreateConnection()
        {
            return new SqlConnection(_connection);
        }

        public Image[] GetAll()
        {
            using (var connection = CreateConnection())
            {
                return connection.Query<Image>("SELECT * FROM Images;")
                    .ToArray();
            }
        }

        public Image Get(int id)
        {
            using (var connection = CreateConnection())
            {
                return connection.QuerySingleOrDefault<Image>("SELECT * FROM Images WHERE Id=@Id;",
                    new { Id = id });
            }
        }

        public void Update(Image image)
        {
            using (var connection = CreateConnection())
            {
                connection.Execute(
                     $"UPDATE Images SET Title=@{nameof(Image.Title)},Description= @{nameof(Image.Description)} WHERE Id=@Id;",
                     image);
            }
        }

        public void Create(Image image)
        {
            using (var connection = CreateConnection())
            {
                connection.Execute(
                    $"INSERT INTO Images(Title,Description,Data) VALUES(@{nameof(Image.Title)},@{nameof(Image.Description)},@{nameof(Image.Data)});",
                    image);
            }
        }

        public void Delete(int id)
        {
            using (var connection = CreateConnection())
            {
                connection.Execute("DELETE FROM Images WHERE Id=@Id;",
                    new { Id = id });
            }
        }
       
    }
}
