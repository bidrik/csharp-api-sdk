using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace FortnoxAPILibrary.Entities
{
    /// <remarks/>
    [Entity(SingularName = "Account", PluralName = "Accounts")]
    public class Account 
	{
        /// <remarks/>
		[JsonProperty]
		public string Active { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string BalanceBroughtForward { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly]
		[JsonProperty]
		public string BalanceCarriedForward { get; private set; }

        /// <remarks/>
        [JsonProperty]
        public string CostCenter { get; set; }

        /// <remarks/>
        [JsonProperty]
        public CostCenterSettingsValue? CostCenterSettings { get; set; }

		/// <remarks/>
		[JsonProperty]
		public string Description { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Number { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Project { get; set; }

        /// <remarks/>
        [JsonProperty]
        public ProjectSettingsValue? ProjectSettings { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string SRU { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string TransactionInformation { get; set; }

        /// <remarks/>
        [JsonProperty]
        public TransactionInfoSettingsValue? TransactionInformationSettings { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string VATCode { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly]
		[JsonProperty]
		public string Year { get; private set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
		[ReadOnly]
		[JsonProperty(PropertyName = "@url")]
		public string Url { get; private set; }
    }

    /// <remarks/>
    [Entity(SingularName = "Account", PluralName = "Accounts")]
    public class AccountSubset
    {
        /// <remarks/>
        [JsonProperty]
        public string Active { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Description { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Number { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string SRU { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Year { get; set; }

        /// <remarks/>
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; set; }
    }

    /// <remarks/>
    public enum CostCenterSettingsValue
    {
        /// <remarks/>
        ALLOWED,
        /// <remarks/>
        NOTALLOWED,
        /// <remarks/>
        MANDATORY
    }

    /// <remarks/>
    public enum ProjectSettingsValue
    {
        /// <remarks/>
        ALLOWED,
        /// <remarks/>
        NOTALLOWED,
        /// <remarks/>
        MANDATORY
    }

    /// <remarks/>
    public enum TransactionInfoSettingsValue
    {
        /// <remarks/>
        ALLOWED,
        /// <remarks/>
        NOTALLOWED,
        /// <remarks/>
        MANDATORY
    }
}
