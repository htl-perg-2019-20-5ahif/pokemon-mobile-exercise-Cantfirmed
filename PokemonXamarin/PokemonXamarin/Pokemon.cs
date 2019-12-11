using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PokemonXamarin
{
    public partial class GetPokemonList
    {
        [JsonPropertyName("count")]
        public long Count { get; set; }

        [JsonPropertyName("next")]
        public Uri Next { get; set; }

        [JsonPropertyName("previous")]
        public object Previous { get; set; }

        [JsonPropertyName("results")]
        public Pokemon[] Results { get; set; }
    }

    public partial class Pokemon
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        public PokemonDetails Details { get; set; }
    }

    public partial class ListOfPokemon
    {
        [JsonPropertyName("results")]
        public ObservableCollection<Pokemon> Results { get; set; }
    }
    
    public partial class PokemonDetails
    {
        [JsonPropertyName("abilities")]
        public Ability[] Abilities { get; set; }

        [JsonPropertyName("base_experience")]
        public long BaseExperience { get; set; }

        [JsonPropertyName("forms")]
        public AbilityDetails[] Forms { get; set; }

        [JsonPropertyName("game_indices")]
        public GameIndex[] GameIndices { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("held_items")]
        public HeldItem[] HeldItems { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("location_area_encounters")]
        public Uri LocationAreaEncounters { get; set; }

        [JsonPropertyName("moves")]
        public Move[] Moves { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("order")]
        public long Order { get; set; }

        [JsonPropertyName("species")]
        public AbilityDetails Species { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites Sprites { get; set; }

        [JsonPropertyName("stats")]
        public Stat[] Stats { get; set; }

        [JsonPropertyName("types")]
        public TypeElement[] Types { get; set; }

        [JsonPropertyName("weight")]
        public long Weight { get; set; }
    }

    public partial class Ability
    {
        [JsonPropertyName("ability")]
        public AbilityDetails AbilityDetails { get; set; }

        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonPropertyName("slot")]
        public long Slot { get; set; }
    }

    public partial class AbilityDetails
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }

    public partial class GameIndex
    {
        [JsonPropertyName("game_index")]
        public long GameIndexGameIndex { get; set; }

        [JsonPropertyName("version")]
        public AbilityDetails Version { get; set; }
    }

    public partial class HeldItem
    {
        [JsonPropertyName("item")]
        public AbilityDetails Item { get; set; }

        [JsonPropertyName("version_details")]
        public VersionDetail[] VersionDetails { get; set; }
    }

    public partial class VersionDetail
    {
        [JsonPropertyName("rarity")]
        public long Rarity { get; set; }

        [JsonPropertyName("version")]
        public AbilityDetails Version { get; set; }
    }

    public partial class Move
    {
        [JsonPropertyName("move")]
        public AbilityDetails MoveMove { get; set; }

        [JsonPropertyName("version_group_details")]
        public VersionGroupDetail[] VersionGroupDetails { get; set; }
    }

    public partial class VersionGroupDetail
    {
        [JsonPropertyName("level_learned_at")]
        public long LevelLearnedAt { get; set; }

        [JsonPropertyName("move_learn_method")]
        public AbilityDetails MoveLearnMethod { get; set; }

        [JsonPropertyName("version_group")]
        public AbilityDetails VersionGroup { get; set; }
    }

    public partial class Sprites
    {
        [JsonPropertyName("back_default")]
        public Uri BackDefault { get; set; }

        [JsonPropertyName("back_female")]
        public object BackFemale { get; set; }

        [JsonPropertyName("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public partial class Stat
    {
        [JsonPropertyName("base_stat")]
        public long BaseStat { get; set; }

        [JsonPropertyName("effort")]
        public long Effort { get; set; }

        [JsonPropertyName("stat")]
        public AbilityDetails StatStat { get; set; }
    }

    public partial class TypeElement
    {
        [JsonPropertyName("slot")]
        public long Slot { get; set; }

        [JsonPropertyName("type")]
        public AbilityDetails Type { get; set; }
    }
    
   
    
}
