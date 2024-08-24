using System;
using System.Collections.Generic;
using System.Text;
using DSharpPlus.Entities;

namespace DSharpPlus.EventArgs
{
    public class ReadStateUpdatedEventArgs : DiscordEventArgs
    {
        public ReadStateUpdatedEventArgs(DiscordClient client, DiscordReadState readState) : base(client)
        {
            ReadState = readState;
        }

        public DiscordReadState ReadState { get; private set; }
    }
}
