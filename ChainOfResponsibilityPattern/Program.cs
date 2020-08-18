namespace ChainOfResponsibilityPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Handler redHandler = new RedHandler();
            Handler greenHandler = new GreenHandler();
            Handler blueHandler = new BlueHandler();

            redHandler.SetNextHandler(greenHandler);
            greenHandler.SetNextHandler(blueHandler);


            // Requests

            Request request = null;

            request = new Request("001", "Red");
            redHandler.ProcessRequest(request);

            request = new Request("002", "Green");
            redHandler.ProcessRequest(request);

            request = new Request("003", "Blue");
            redHandler.ProcessRequest(request);

            request = new Request("999", "White");
            redHandler.ProcessRequest(request);
        }
    }
}