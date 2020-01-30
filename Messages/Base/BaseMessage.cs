using System;

namespace LogManager.Messages.Base
{
    public abstract class BaseMessage
    {
        public long IdCorrelationKey { get; set; }        
        private DateTime TimeStamp { get; set; }

        public BaseMessage(long idCorrelationKey)
        {
            this.IdCorrelationKey = idCorrelationKey;            
            this.TimeStamp = DateTime.Now;
        }
    }
}
