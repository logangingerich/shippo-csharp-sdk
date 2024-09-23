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
    using System.Collections.Generic;
    
    public class BatchCreateRequest
    {

        /// <summary>
        /// ID of the Carrier Account object to use as the default for all shipments in this Batch. <br/>
        /// 
        /// <remarks>
        /// The carrier account can be changed on a per-shipment basis by changing the carrier_account in the <br/>
        /// corresponding BatchShipment object.
        /// </remarks>
        /// </summary>
        [JsonProperty("default_carrier_account")]
        public string DefaultCarrierAccount { get; set; } = default!;

        /// <summary>
        /// Token of the service level to use as the default for all shipments in this Batch. <br/>
        /// 
        /// <remarks>
        /// The servicelevel can be changed on a per-shipment basis by changing the servicelevel_token in the <br/>
        /// corresponding BatchShipment object. &lt;a href=&quot;#tag/Service-Levels&quot;&gt;Servicelevel tokens can be found here.&lt;/a&gt;
        /// </remarks>
        /// </summary>
        [JsonProperty("default_servicelevel_token")]
        public string DefaultServicelevelToken { get; set; } = default!;

        /// <summary>
        /// Print format of the &lt;a href=&quot;https://docs.goshippo.com/docs/shipments/shippinglabelsizes/&quot;&gt;label&lt;/a&gt;. If empty, will use the default format set from <br/>
        /// 
        /// <remarks>
        /// &lt;a href=&quot;https://apps.goshippo.com/settings/labels&quot;&gt;the Shippo dashboard.&lt;/a&gt;
        /// </remarks>
        /// </summary>
        [JsonProperty("label_filetype")]
        public LabelFileTypeEnum? LabelFiletype { get; set; }

        /// <summary>
        /// A string of up to 100 characters that can be filled with any additional information you want to attach to the object.
        /// </summary>
        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Array of BatchShipment objects. The response keeps the same order as in the request array.
        /// </summary>
        [JsonProperty("batch_shipments")]
        public List<BatchShipmentCreateRequest> BatchShipments { get; set; } = default!;
    }
}