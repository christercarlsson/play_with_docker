// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var contact = Contact.FromJson(jsonString);

namespace tinywebapp.Models
{
    using Newtonsoft.Json;

    public partial class ContactResults
    {
        [JsonProperty("results")]
        public Contact[] Results { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }
    }
}
