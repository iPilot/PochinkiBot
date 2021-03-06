﻿using Microsoft.Extensions.Configuration;

namespace PochinkiBot.Configuration
{
    public class BotConfig
    {
        private readonly IConfiguration _configuration;

        public string Token { get; }
        public RedisConfiguration RedisConfiguration { get; }
        public DailyPidorConfiguration DailyPidor { get; }
        public RussianRouletteConfiguration RussianRoulette { get; }
        
        public BotConfig() : this("config.json")
        {
        }

        public BotConfig(string fileName)
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile(fileName)
                .Build();

            Token = _configuration["Token"];
            RedisConfiguration = Get<RedisConfiguration>("Redis");
            DailyPidor = Get<DailyPidorConfiguration>(nameof(DailyPidor));
            RussianRoulette = Get<RussianRouletteConfiguration>(nameof(RussianRoulette));
        }
        
        public T Get<T>(string key) => _configuration.GetSection(key).Get<T>();
    }
}