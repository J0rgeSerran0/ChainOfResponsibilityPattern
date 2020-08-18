namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        protected Handler NextHandler;

        public void SetNextHandler(Handler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public abstract void ProcessRequest(Request request);
    }
}