using System;

namespace ChainOfResponsibilityPattern
{
    public class GreenHandler : Handler
    {
        public override void ProcessRequest(Request request)
        {
            if (request.Color == "Green")
                Console.WriteLine($"{this.GetType().Name} approved request {request.Code} as {request.Color}");
            else if (NextHandler != null)
                NextHandler.ProcessRequest(request);
        }
    }
}