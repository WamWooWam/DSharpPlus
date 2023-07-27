using DSharpPlus.Entities;

namespace DSharpPlus.EventArgs
{
    public class RelationshipAddedEventArgs : AsyncEventArgs
    {
        public DiscordRelationship Relationship { get; internal set; }
    }

    public class RelationshipRemovedEventArgs : AsyncEventArgs
    {
        public DiscordRelationship Relationship { get; internal set; }
    }
}