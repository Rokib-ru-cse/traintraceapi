namespace traintraceapi.Model.ViewModel
{
    public class ReturnResultWithClass<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Value { get; set; }
    }
}
