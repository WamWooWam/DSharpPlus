using System;
using System.Collections.Generic;
using System.Text;
using DSharpPlus.Entities;

namespace DSharpPlus.EventArgs
{
    public class ChannelUnreadUpdateEventArgs : DiscordEventArgs
    {
        public ulong? GuildId { get; internal set; }

        /// <summary>
        /// Gets a collection containing the read states in the received chunk.
        /// </summary>
        public IReadOnlyDictionary<ulong, DiscordReadState> ReadStates { get; internal set; }

        internal ChannelUnreadUpdateEventArgs(DiscordClient client) : base(client) { }
    }
}
