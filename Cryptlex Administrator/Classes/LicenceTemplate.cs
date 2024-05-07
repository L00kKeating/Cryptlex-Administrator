using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cryptlex_Administrator.Classes
{
    internal class LicenceTemplate
    {
        public LicenceTemplate() { }
        public LicenceTemplate(string responseContent)
        {

            var liscenceTemplate = System.Text.Json.JsonSerializer.Deserialize<LicenceTemplate>(responseContent);

            validity = liscenceTemplate.validity;
            expirationStrategy = liscenceTemplate.expirationStrategy;
            fingerprintMatchingStrategy = liscenceTemplate.fingerprintMatchingStrategy;
            allowedActivations = liscenceTemplate.allowedActivations;
            allowedDeactivations = liscenceTemplate.allowedDeactivations;
            type = liscenceTemplate.type;
            keyPattern = liscenceTemplate.keyPattern;
            leaseDuration = liscenceTemplate.leaseDuration;
            allowClientLeaseDuration = liscenceTemplate.allowClientLeaseDuration;
            leasingStrategy = liscenceTemplate.leasingStrategy;
            allowedFloatingClients = liscenceTemplate.allowedFloatingClients;
            serverSyncGracePeriod = liscenceTemplate.serverSyncGracePeriod;
            serverSyncInterval = liscenceTemplate.serverSyncInterval;
            allowedClockOffset = liscenceTemplate.allowedClockOffset;
            disableClockValidation = liscenceTemplate.disableClockValidation;
            expiringSoonEventOffset = liscenceTemplate.expiringSoonEventOffset;
            requireAuthentication = liscenceTemplate.requireAuthentication;
            requiredMetadataKeys = liscenceTemplate.requiredMetadataKeys;
            requiredMeterAttributes = liscenceTemplate.requiredMeterAttributes;
            name = liscenceTemplate.name;
            allowVmActivation = liscenceTemplate.allowVmActivation;
            allowContainerActivation = liscenceTemplate.allowContainerActivation;
            userLocked = liscenceTemplate.userLocked;
            disableGeoLocation = liscenceTemplate.disableGeoLocation;
            allowedIpRange = liscenceTemplate.allowedIpRange;
            allowedIpRanges = liscenceTemplate.allowedIpRanges;
            allowedCountries = liscenceTemplate.allowedCountries;
            disallowedCountries = liscenceTemplate.disallowedCountries;
            allowedIpAddresses = liscenceTemplate.allowedIpAddresses;
            disallowedIpAddresses = liscenceTemplate.disallowedIpAddresses;
            id = liscenceTemplate.id;
            createdAt = liscenceTemplate.createdAt;
            updatedAt = liscenceTemplate.updatedAt;

        }

        public int validity { get; set; }
        public string expirationStrategy { get; set; }
        public string fingerprintMatchingStrategy { get; set; }
        public int allowedActivations { get; set; }
        public int allowedDeactivations { get; set; }
        public string type { get; set; }
        public string keyPattern { get; set; }
        public int leaseDuration { get; set; }
        public bool allowClientLeaseDuration { get; set; }
        public string leasingStrategy { get; set; }
        public int allowedFloatingClients { get; set; }
        public int serverSyncGracePeriod { get; set; }
        public int serverSyncInterval { get; set; }
        public int allowedClockOffset { get; set; }
        public bool disableClockValidation { get; set; }
        public int expiringSoonEventOffset { get; set; }
        public bool requireAuthentication { get; set; }
        public List<object> requiredMetadataKeys { get; set; }
        public List<object> requiredMeterAttributes { get; set; }
        public string name { get; set; }
        public bool allowVmActivation { get; set; }
        public bool allowContainerActivation { get; set; }
        public bool userLocked { get; set; }
        public bool disableGeoLocation { get; set; }
        public string allowedIpRange { get; set; }
        public List<string> allowedIpRanges { get; set; }
        public List<string> allowedCountries { get; set; }
        public List<string> disallowedCountries { get; set; }
        public List<string> allowedIpAddresses { get; set; }
        public List<string> disallowedIpAddresses { get; set; }
        public string id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    internal class LiscenceTemplates : List<LicenceTemplate>
    {
        public LiscenceTemplates() { }
        public LiscenceTemplates(string responseContent)
        {
            var result = System.Text.Json.JsonSerializer.Deserialize<LiscenceTemplates>(responseContent);

            AddRange(result);

        }
    }
}
