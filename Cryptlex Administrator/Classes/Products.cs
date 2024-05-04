using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cryptlex_Administrator.Classes
{
    internal class Product
    {
        public Product() { }
        public Product(HttpContent responseContent)
        {
            var product = System.Text.Json.JsonSerializer.Deserialize<Product>(responseContent.ToString());

            ID = product.ID;
            Name = product.Name;
            DisplayName = product.DisplayName;
            Description = product.Description;
            PublicKey = product.PublicKey;
            TotalLiscences = product.TotalLiscences;
            TotalTrialActivations = product.TotalTrialActivations;
            TotalReleases = product.TotalReleases;
            TotalProductVersions = product.TotalProductVersions;
            TotalFeatureFlags = product.TotalFeatureFlags;
            AutomatedEmails = product.AutomatedEmails;
            LicenseTemplateID = product.LicenseTemplateID;
            TrailPolicyID = product.TrailPolicyID;
            MetaData = product.MetaData;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string PublicKey { get; set; }
        public int TotalLiscences { get; set; }
        public int TotalTrialActivations { get; set; }
        public int TotalReleases { get; set; }
        public int TotalProductVersions { get; set; }
        public int TotalFeatureFlags { get; set; }
        public List<string> AutomatedEmails { get; set; }
        public string LicenseTemplateID { get; set; }
        public string TrailPolicyID { get; set; }

        public MetaData MetaData { get; set; }
    }

    internal class Products : List<Product>
    {
        public Products() { }
        public Products(HttpContent responseContent)
        {
            var result = System.Text.Json.JsonSerializer.Deserialize<Products>(responseContent.ToString());

            AddRange(result);
        }
    }
}

