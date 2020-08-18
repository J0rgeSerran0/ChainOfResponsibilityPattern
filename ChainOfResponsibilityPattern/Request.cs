namespace ChainOfResponsibilityPattern
{
    public class Request
    {
        public Request(string code, string color)
        {
            Code = code;
            Color = color;
        }

        public string Code { get; set; }
        public string Color { get; set; }
    }
}