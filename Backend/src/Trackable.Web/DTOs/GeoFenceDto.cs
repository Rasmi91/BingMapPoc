// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Trackable.Models;

namespace Trackable.Web.Dtos
{
    public class GeoFenceDto
    {
        /// <summary>
        /// Geofence id, Autogenerated or Specified
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Geofence Name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// List of emails to notify when geofence is triggered
        /// </summary>
        public IEnumerable<string> EmailsToNotify { get; set; }

        /// <summary>
        /// List of webhooks to invoke when geofence is triggered
        /// </summary>
        public IEnumerable<string> WebhooksToNotify { get; set; }

        /// <summary>
        /// Cooldown in minutes before geofence can be triggered again
        /// </summary>
        public long Cooldown { get; set; }

        /// <summary>
        /// Geofence triggering type: Inbound or Outbound
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public FenceType FenceType { get; set; }

        /// <summary>
        /// Geofence area type: Circular or Polygon
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public GeoFenceAreaType AreaType { get; set; }

        /// <summary>
        /// Required if geoefence area type is Polygon
        /// </summary>
        public IEnumerable<Point> FencePolygon { get; set; }

        /// <summary>
        /// Required if geoefence area type is Circular
        /// </summary>
        public Point FenceCenter { get; set; }

        /// <summary>
        /// Required if geoefence area type is Circular
        /// </summary>
        public double? RadiusInMeters { get; set; }

        /// <summary>
        /// List of ids of the assets to be checked by this geofence
        /// </summary>
        public IEnumerable<string> AssetIds { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        public IEnumerable<string> Tags { get; set; }
    }
}
