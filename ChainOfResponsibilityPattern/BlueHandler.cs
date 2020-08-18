using System;

namespace ChainOfResponsibilityPattern
{
    public class BlueHandler : Handler
    {
        public override void ProcessRequest(Request request)
        {
            if (request.Color == "Blue")
                Console.WriteLine($"{this.GetType().Name} approved request {request.Code} as {request.Color}");
            else 
                Console.WriteLine($"{this.GetType().Name} denied {request.Code} as {request.Color}");
        }
    }
}