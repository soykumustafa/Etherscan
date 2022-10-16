
namespace Soyku.Etherscan.Core.Common
{
    public class ApiResponse<T> where T : class
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
