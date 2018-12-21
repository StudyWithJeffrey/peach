﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hey
{
    public abstract class AbsSocketService<TMessage> : ISocketService<TMessage> where TMessage : Messaging.IMessage
    {
        public virtual void OnConnected(ISocketContext<TMessage> context)
        {           
        }

        public virtual void OnDisconnected(ISocketContext<TMessage> context)
        {
        }

        public virtual void OnException(ISocketContext<TMessage> context, Exception ex)
        {
            throw new NotImplementedException();
        }

        public abstract void OnRecieve(ISocketContext<TMessage> context, TMessage msg);
       
    }
}
