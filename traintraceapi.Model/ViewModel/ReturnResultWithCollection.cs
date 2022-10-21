namespace traintraceapi.Model.ViewModel
{
    public class ReturnResultWithCollection<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<T> Values { get; set; }
    }
}
