namespace BCP.Business.Models
{
    public class IResponse<T>
    {
        public T Data { get; set; }
        public string State { get; set; }
        public string Message { get; set; }
    }
}
