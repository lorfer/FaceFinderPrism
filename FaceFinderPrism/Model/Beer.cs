using Newtonsoft.Json;
using System;
using System.Globalization;
    using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace FaceFinderPrism.ViewModels
{
    public partial class Beer
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("first_brewed")]
        public string FirstBrewed { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("abv")]
        public double Abv { get; set; }

        [JsonProperty("ibu")]
        public long Ibu { get; set; }

        [JsonProperty("target_fg")]
        public long TargetFg { get; set; }

        [JsonProperty("target_og")]
        public long TargetOg { get; set; }

        [JsonProperty("ebc")]
        public long Ebc { get; set; }

        [JsonProperty("srm")]
        public long Srm { get; set; }

        [JsonProperty("ph")]
        public double Ph { get; set; }

        [JsonProperty("attenuation_level")]
        public long AttenuationLevel { get; set; }

        [JsonProperty("volume")]
        public BoilVolume Volume { get; set; }

        [JsonProperty("boil_volume")]
        public BoilVolume BoilVolume { get; set; }

        [JsonProperty("method")]
        public Method Method { get; set; }

        [JsonProperty("ingredients")]
        public Ingredients Ingredients { get; set; }

        [JsonProperty("food_pairing")]
        public List<string> FoodPairing { get; set; }

        [JsonProperty("brewers_tips")]
        public string BrewersTips { get; set; }

        [JsonProperty("contributed_by")]
        public string ContributedBy { get; set; }
    }

    public partial class BoilVolume
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public partial class Ingredients
    {
        [JsonProperty("malt")]
        public List<Malt> Malt { get; set; }

        [JsonProperty("hops")]
        public List<Hop> Hops { get; set; }

        [JsonProperty("yeast")]
        public string Yeast { get; set; }
    }

    public partial class Hop
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public BoilVolume Amount { get; set; }

        [JsonProperty("add")]
        public string Add { get; set; }

        [JsonProperty("attribute")]
        public string Attribute { get; set; }
    }

    public partial class Malt
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public BoilVolume Amount { get; set; }
    }

    public partial class Method
    {
        [JsonProperty("mash_temp")]
        public List<MashTemp> MashTemp { get; set; }

        [JsonProperty("fermentation")]
        public Fermentation Fermentation { get; set; }

        [JsonProperty("twist")]
        public object Twist { get; set; }
    }

    public partial class Fermentation
    {
        [JsonProperty("temp")]
        public BoilVolume Temp { get; set; }
    }

    public partial class MashTemp
    {
        [JsonProperty("temp")]
        public BoilVolume Temp { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }
    }


}
