namespace indigyTestProject.Model.Model.DTOs.Request
{
    public class ListRequsetDTO
    {
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 10;
        public string column { get; set; } = "Id";
        public string order { get; set; } = "desc";
        public string keyword { get; set; } = "";
    }
}
