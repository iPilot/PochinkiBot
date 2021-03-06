﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PochinkiBot.Repositories.Interfaces
{
    public interface IPidorStore
    {
        Task<ulong?> GetCurrentGuildPidor(ulong guildId);
        Task<TimeSpan> SetGuildPidor(ulong guildId, ulong userId);
        Task<bool> AddGuildPidorParticipant(ulong guildId, ulong userId);
        Task RemoveGuildPidorParticipant(ulong guildId, ulong userId);
        Task<List<ulong>> ListGuildPidorParticipants(ulong guildId);
        Task<List<(ulong User, int Count)>> GetGuildTop(ulong guildId, int count);
    }
}