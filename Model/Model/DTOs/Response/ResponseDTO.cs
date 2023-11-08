namespace indigyTestProject.Model.Model.DTOs.Response
{
    public class ResponseDTO<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public T Result { get; set;}

        public ResponseDTO(int code , string message, T result) 
        { 
            Code = code; 
            Message = message; 
            Result = result;
        }
    }
}
