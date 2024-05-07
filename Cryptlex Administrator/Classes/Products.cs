using System;
using System.Collections.Generic;

namespace Cryptlex_Administrator.Classes
{
    internal class Product
    {
        public Product() { }
        public Product(string responseContent)
        {
            var product = System.Text.Json.JsonSerializer.Deserialize<Product>(responseContent.ToString());

            id = product.id;
            name = product.name;
            displayName = product.displayName;
            description = product.description;
            publicKey = product.publicKey;
            totalLicenses = product.totalLicenses;
            totalTrialActivations = product.totalTrialActivations;
            totalReleases = product.totalReleases;
            totalProductVersions = product.totalProductVersions;
            totalFeatureFlags = product.totalFeatureFlags;
            automatedEmails = product.automatedEmails;
            licenseTemplateId = product.licenseTemplateId;
            trialPolicyId = product.trialPolicyId;
            metaData = product.metaData;
        }

        public string id { get; set; }
        public string name { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string publicKey { get; set; }
        public int totalLicenses { get; set; }
        public int totalTrialActivations { get; set; }
        public int totalReleases { get; set; }
        public int totalProductVersions { get; set; }
        public int totalFeatureFlags { get; set; }
        public List<string> emailTemplates { get; set; }
        public List<string> automatedEmails { get; set; }
        public string licenseTemplateId { get; set; }
        public string trialPolicyId { get; set; }

        public MetaData metaData { get; set; }
    }
    internal class Products : List<Product>
    {
        public Products() { }
        public Products(string responseContent)
        {
            var result = System.Text.Json.JsonSerializer.Deserialize<Products>(responseContent.ToString());

            AddRange(result);
        }
    }

    internal class ProductLicense
    {
        public ProductLicense() { }
        public ProductLicense(string productID)
        {
            ProductID = productID;
        }

        public string ProductID { get; set; }
        public string Key { get; set; }
    }

    
    #region apiModels
    internal class NewProductModel
    {
        public NewProductModel() { }
        public NewProductModel(string Name, string DisplayName, string TemplateID, string Description)
        {
            description = Description;
            displayName = DisplayName;
            licenseTemplateId = TemplateID;
            name = Name;
        }

        public string description { get; set; }
        public string displayName { get; set; }
        public string licenseTemplateId { get; set; }
        public string name { get; set; }
        public string automatedEmails { get; set; }
        public string trialPolicyId { get; set; }
        public MetaData metaData { get; set; }

    }

    internal class newProductLiscenceModel
    {

        public newProductLiscenceModel() { }
            
        public newProductLiscenceModel(string responseContent)
        {
            var result = System.Text.Json.JsonSerializer.Deserialize<newProductLiscenceModel>(responseContent);

            key = result.key;
            revoked = result.revoked;
            suspended = result.suspended;
            totalActivations = result.totalActivations;
            totalDeactivations = result.totalDeactivations;
            validity = result.validity;
            expirationStrategy = result.expirationStrategy;
            fingerprintMatchingStrategy = result.fingerprintMatchingStrategy;
            allowedActivations = result.allowedActivations;
            allowedDeactivations = result.allowedDeactivations;
            type = result.type;
            allowedFloatingClients = result.allowedFloatingClients;
            serverSyncGracePeriod = result.serverSyncGracePeriod;
            serverSyncInterval = result.serverSyncInterval;
            allowedClockOffset = result.allowedClockOffset;
            disableClockValidation = result.disableClockValidation;
            expiringSoonEventOffset = result.expiringSoonEventOffset;
            leaseDuration = result.leaseDuration;
            leasingStrategy = result.leasingStrategy;
            expiresAt = result.expiresAt;
            allowVmActivation = result.allowVmActivation;
            allowContainerActivation = result.allowContainerActivation;
            allowClientLeaseDuration = result.allowClientLeaseDuration;
            userLocked = result.userLocked;
            requireAuthentication = result.requireAuthentication;
            disableGeoLocation = result.disableGeoLocation;
            notes = result.notes;
            productId = result.productId;
            productVersionId = result.productVersionId;
            maintenancePolicyId = result.maintenancePolicyId;
            maintenanceExpiresAt = result.maintenanceExpiresAt;
            currentReleaseVersion = result.currentReleaseVersion;
            maxAllowedReleaseVersion = result.maxAllowedReleaseVersion;
            organization = result.organization;
            user = result.user;
            reseller = result.reseller;
            additionalUserIds = result.additionalUserIds;
            allowedIpRange = result.allowedIpRange;
            allowedIpRanges = result.allowedIpRanges;
            allowedIpAddresses = result.allowedIpAddresses;
            disallowedIpAddresses = result.disallowedIpAddresses;
            allowedCountries = result.allowedCountries;
            disallowedCountries = result.disallowedCountries;
            metadata = result.metadata;
            meterAttributes = result.meterAttributes;
            tags = result.tags;
            externalUserIds = result.externalUserIds;
            id = result.id;
            createdAt = result.createdAt;
            updatedAt = result.updatedAt;

        }


        public string key { get; set; }
        public bool revoked { get; set; }
        public bool suspended { get; set; }
        public int totalActivations { get; set; }
        public int totalDeactivations { get; set; }
        public int validity { get; set; }
        public string expirationStrategy { get; set; }
        public string fingerprintMatchingStrategy { get; set; }
        public int allowedActivations { get; set; }
        public int allowedDeactivations { get; set; }
        public string type { get; set; }
        public int allowedFloatingClients { get; set; }
        public int serverSyncGracePeriod { get; set; }
        public int serverSyncInterval { get; set; }
        public int allowedClockOffset { get; set; }
        public bool disableClockValidation { get; set; }
        public int expiringSoonEventOffset { get; set; }
        public int leaseDuration { get; set; }
        public string leasingStrategy { get; set; }
        public object expiresAt { get; set; }
        public bool allowVmActivation { get; set; }
        public bool allowContainerActivation { get; set; }
        public bool allowClientLeaseDuration { get; set; }
        public bool userLocked { get; set; }
        public bool requireAuthentication { get; set; }
        public bool disableGeoLocation { get; set; }
        public object notes { get; set; }
        public string productId { get; set; }
        public object productVersionId { get; set; }
        public object maintenancePolicyId { get; set; }
        public object maintenanceExpiresAt { get; set; }
        public object currentReleaseVersion { get; set; }
        public object maxAllowedReleaseVersion { get; set; }
        public object organization { get; set; }
        public object user { get; set; }
        public object reseller { get; set; }
        public List<object> additionalUserIds { get; set; }
        public object allowedIpRange { get; set; }
        public List<object> allowedIpRanges { get; set; }
        public List<object> allowedIpAddresses { get; set; }
        public List<object> disallowedIpAddresses { get; set; }
        public List<object> allowedCountries { get; set; }
        public List<object> disallowedCountries { get; set; }
        public List<object> metadata { get; set; }
        public List<object> meterAttributes { get; set; }
        public List<object> tags { get; set; }
        public List<object> externalUserIds { get; set; }
        public string id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
    #endregion

}

