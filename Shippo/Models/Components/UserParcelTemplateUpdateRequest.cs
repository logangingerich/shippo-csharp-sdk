//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Components
{
    using Newtonsoft.Json;
    using Shippo.Models.Components;
    using Shippo.Utils;
    
    public class UserParcelTemplateUpdateRequest
    {

        /// <summary>
        /// The measure unit used for length, width and height.
        /// </summary>
        [JsonProperty("distance_unit")]
        public DistanceUnitEnum DistanceUnit { get; set; } = default!;

        /// <summary>
        /// The height of the package, in units specified by the `distance_unit` attribute. Required, but if using a preset carrier template then this field must be empty.
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; } = default!;

        /// <summary>
        /// The length of the package, in units specified by the `distance_unit` attribute. Required, but if using a preset carrier template then this field must be empty.
        /// </summary>
        [JsonProperty("length")]
        public string Length { get; set; } = default!;

        /// <summary>
        /// The name of the User Parcel Template
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The weight of the package, in units specified by the weight_unit attribute.
        /// </summary>
        [JsonProperty("weight")]
        public string? Weight { get; set; }

        /// <summary>
        /// The unit used for weight.
        /// </summary>
        [JsonProperty("weight_unit")]
        public WeightUnitEnum? WeightUnit { get; set; }

        /// <summary>
        /// The width of the package, in units specified by the `distance_unit` attribute. Required, but if using a preset carrier template then this field must be empty.
        /// </summary>
        [JsonProperty("width")]
        public string Width { get; set; } = default!;
    }
}