﻿using System;
using Magento.RestApi.Core;
using Magento.RestApi.Json;
using Newtonsoft.Json;

namespace Magento.RestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(GroupPriceConverter))]
    public class GroupPrice : ChangeTracking<GroupPrice>
    {
        public GroupPrice()
        {
            StartTracking();
        }

        /// <summary>
        /// Website ID
        /// </summary>
        /// <remarks>optional</remarks>
        public int? website_id
        {
            get { return GetValue(x => x.website_id); }
            set { SetValue(x => x.website_id, value); }
        }
        /// <summary>
        /// Customer group
        /// </summary>
        /// <remarks>optional</remarks>
        public int? cust_group
        {
            get { return GetValue(x => x.cust_group); }
            set { SetValue(x => x.cust_group, value); }
        }
        /// <summary>
        /// Tier price
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DoubleConverter))]
        public double? price
        {
            get { return GetValue(x => x.price); }
            set { SetValue(x => x.price, value); }
        }
    }
}
