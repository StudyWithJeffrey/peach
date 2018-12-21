﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hey.Protocol
{
    /// <summary>
    /// TODO:Completed
    /// </summary>
    /// <typeparam name="TMessage"></typeparam>
    public interface IProtocol<TMessage>
        where TMessage :  Messaging.IMessage
    {
        ProtocolMeta GetProtocolMeta();

        TMessage Parse(Buffer.IBufferReader reader);

        void Pack(Buffer.IBufferWriter writer, TMessage message);

        void PackHeartBeat(Buffer.IBufferWriter writer);
    }
}
