﻿using System.Collections.Generic;

namespace Discord.WebSocket.Data
{
    public interface IDataStore
    {
        IEnumerable<Channel> Channels { get; }
        IEnumerable<Guild> Guilds { get; }
        IEnumerable<Role> Roles { get; }
        IEnumerable<User> Users { get; }

        Channel GetChannel(ulong id);
        void AddChannel(Channel channel);
        Channel RemoveChannel(ulong id);

        Guild GetGuild(ulong id);
        void AddGuild(Guild guild);
        Guild RemoveGuild(ulong id);

        Role GetRole(ulong id);
        void AddRole(Role role);
        Role RemoveRole(ulong id);

        User GetUser(ulong id);
        void AddUser(User user);
        User RemoveUser(ulong id);
    }
}
