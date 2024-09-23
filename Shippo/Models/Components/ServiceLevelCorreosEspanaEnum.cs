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
    using Shippo.Utils;
    using System;
    
    /// <summary>
    /// |Token | Service name|<br/>
    /// 
    /// <remarks>
    /// |:---|:---|<br/>
    /// | correos_standard_home| Paquete Estándar|<br/>
    /// | correos_premium_home | Paquete Premium|<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum ServiceLevelCorreosEspanaEnum
    {
        [JsonProperty("correos_standard_home")]
        CorreosStandardHome,
        [JsonProperty("correos_premium_home")]
        CorreosPremiumHome,
    }

    public static class ServiceLevelCorreosEspanaEnumExtension
    {
        public static string Value(this ServiceLevelCorreosEspanaEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServiceLevelCorreosEspanaEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ServiceLevelCorreosEspanaEnum).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is ServiceLevelCorreosEspanaEnum)
                    {
                        return (ServiceLevelCorreosEspanaEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServiceLevelCorreosEspanaEnum");
        }
    }

}