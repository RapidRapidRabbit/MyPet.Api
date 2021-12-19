﻿using MyPet.Api.SignalRHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPet.Api.SignalRHub.Clients
{
   public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}