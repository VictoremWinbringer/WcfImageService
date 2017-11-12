using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfApi
{
    [ServiceContract]
    public interface IImageService
    {
        [OperationContract]
        Image[] GetAll();

        [OperationContract]
        Image Get(int id);

        [OperationContract]
        void Update(Image image);

        [OperationContract]
        void Create(Image image);

        [OperationContract]
        void Delete(int id);
    }

    [DataContract]
    public class Image
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public byte[] Data { get; set; }
    }
}
