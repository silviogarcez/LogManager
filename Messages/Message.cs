using LogManager.Messages.Base;

namespace LogManager.Messages
{
    public class Message : BaseMessage
    {
        public Message(long idCorrelationKey = 0) : base(idCorrelationKey)
        {

        }
        public string StackTrace { get; set; }
        public string Msg { get; set; }
        public string MethodName { get; set; }
    }
}
