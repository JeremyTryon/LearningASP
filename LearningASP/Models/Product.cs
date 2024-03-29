﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace LearningASP.Models
{
    public class Product
    {
        /// <summary>
        /// these following properties are created to convert the Json data in the data folder to C#
        /// </summary>
        //prop tab tab to shortcut create properties
        public string Id { get; set; }
        public string Maker { get; set;}

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public string URL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
