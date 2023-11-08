namespace indigyTestProject.Model.Model.DTOs.Response
{
    public class ResponseWithCountDTO<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public int Count { get; set; }
        public T Result { get; set; }

        public ResponseWithCountDTO(int code, string message, int count, T result)
        {
            Code = code;
            Message = message;
            Count = count;
            Result = result;
        }
    }
}
