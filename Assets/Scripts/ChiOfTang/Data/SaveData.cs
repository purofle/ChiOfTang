using System;
using Newtonsoft.Json;

namespace ChiOfTang.Data
{
    [Serializable]
    public class SaveData
    {
        [JsonProperty("player_name")] public string PlayerName { get; set; }
        [JsonProperty("player_level")] public PlayerLevel PlayerLevel { get; set; }
    }

    [Serializable]
    public class PlayerLevel
    {
        [JsonProperty("level")] public int Level { get; set; }
        [JsonProperty("score")] public int Score { get; set; }
        [JsonProperty("acc")] public float Acc { get; set; }
    }
}