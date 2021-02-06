﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            this.MessageType = GetType().Name;
        }
    }
}