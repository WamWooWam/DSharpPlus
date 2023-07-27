namespace DSharpPlus
{
    /// <summary>
    /// Represents a channel's type.
    /// </summary>
    public enum ChannelType : int
    {
        /// <summary>
        /// Indicates that this is a text channel.
        /// </summary>
        Text = 0,

        /// <summary>
        /// Indicates that this is a private channel.
        /// </summary>
        Private = 1,

        /// <summary>
        /// Indicates that this is a voice channel.
        /// </summary>
        Voice = 2,

        /// <summary>
        /// Indicates that this is a group direct message channel.
        /// </summary>
        Group = 3,

        /// <summary>
        /// Indicates that this is a channel category.
        /// </summary>
        Category = 4,

        /// <summary>
        /// Indicates that this is a news channel.
        /// </summary>
        Announcement = 5,

        /// <summary>
        /// Indicates that this is a store channel.
        /// </summary>
        Store = 6,

        /// <summary>
        /// Indicates that this is a stage channel.
        /// </summary>
        Stage = 13,

        /// <summary>
        /// a temporary sub-channel within a <see cref="Announcement"/> channel
        /// </summary>
        AnouncementThread = 10,

        /// <summary>
        /// a temporary sub-channel within a <see cref="Text"/> or <see cref="GuildForum"/> channel
        /// </summary>
        PublicThread = 11,

        /// <summary>
        /// a temporary sub-channel within a <see cref="Text"/> channel that is only viewable by those invited and those with the <see cref="Permissions.ManageThreads"/> permission
        /// </summary>
        PrivateThread = 12,

        /// <summary>
        /// the channel in a hub containing the listed servers
        /// </summary>
        GuildDirectory = 14,

        /// <summary>
        /// Channel that can only contain threads.
        /// </summary>
        GuildForum = 15,

        /// <summary>
        /// Indicates unknown channel type.
        /// </summary>
        Unknown = int.MaxValue
    }
}
