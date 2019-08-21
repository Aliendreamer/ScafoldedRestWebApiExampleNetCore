/*
 * CustomerManagement
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.4.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    ///  Skipped properties: id,href
    /// </summary>
    [DataContract]
    public partial class CustomerCreate : IEquatable<CustomerCreate>
    { 
        /// <summary>
        /// A word, term, or phrase by which the PartyRole is known and distinguished from other PartyRoles.
        /// </summary>
        /// <value>A word, term, or phrase by which the PartyRole is known and distinguished from other PartyRoles.</value>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Used to track the lifecycle status of the party role.
        /// </summary>
        /// <value>Used to track the lifecycle status of the party role.</value>
        [DataMember(Name="status")]
        public string Status { get; set; }

        /// <summary>
        /// A string providing an explanation on the value of the status lifecycle. For instance if the status is Rejected, statusReason will provide the reason for rejection.
        /// </summary>
        /// <value>A string providing an explanation on the value of the status lifecycle. For instance if the status is Rejected, statusReason will provide the reason for rejection.</value>
        [DataMember(Name="statusReason")]
        public string StatusReason { get; set; }

        /// <summary>
        /// The time period that the PartyRole is valid for.
        /// </summary>
        /// <value>The time period that the PartyRole is valid for.</value>
        [DataMember(Name="validFor")]
        public TimePeriod ValidFor { get; set; }

        /// <summary>
        /// Gets or Sets EngagedParty
        /// </summary>
        [DataMember(Name="engagedParty")]
        public PartyRef EngagedParty { get; set; }

        /// <summary>
        /// The role type - useful only in the context of a partnership defining more than one role type.
        /// </summary>
        /// <value>The role type - useful only in the context of a partnership defining more than one role type.</value>
        [DataMember(Name="partyRoleType")]
        public RoleTypeRef PartyRoleType { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account")]
        public List<AccountRef> Account { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod")]
        public List<PaymentMethodRef> PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets ContactMedium
        /// </summary>
        [DataMember(Name="contactMedium")]
        public List<ContactMedium> ContactMedium { get; set; }

        /// <summary>
        /// Describes the characteristic of a party role.
        /// </summary>
        /// <value>Describes the characteristic of a party role.</value>
        [DataMember(Name="characteristic")]
        public List<Characteristic> Characteristic { get; set; }

        /// <summary>
        /// Gets or Sets CreditProfile
        /// </summary>
        [DataMember(Name="creditProfile")]
        public List<CreditProfile> CreditProfile { get; set; }

        /// <summary>
        /// Gets or Sets Agreement
        /// </summary>
        [DataMember(Name="agreement")]
        public List<AgreementRef> Agreement { get; set; }

        /// <summary>
        /// Gets or Sets RelatedParty
        /// </summary>
        [DataMember(Name="relatedParty")]
        public List<RelatedPartyRef> RelatedParty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
            sb.Append("  ValidFor: ").Append(ValidFor).Append("\n");
            sb.Append("  EngagedParty: ").Append(EngagedParty).Append("\n");
            sb.Append("  PartyRoleType: ").Append(PartyRoleType).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  ContactMedium: ").Append(ContactMedium).Append("\n");
            sb.Append("  Characteristic: ").Append(Characteristic).Append("\n");
            sb.Append("  CreditProfile: ").Append(CreditProfile).Append("\n");
            sb.Append("  Agreement: ").Append(Agreement).Append("\n");
            sb.Append("  RelatedParty: ").Append(RelatedParty).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CustomerCreate)obj);
        }

        /// <summary>
        /// Returns true if CustomerCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerCreate other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    StatusReason == other.StatusReason ||
                    StatusReason != null &&
                    StatusReason.Equals(other.StatusReason)
                ) && 
                (
                    ValidFor == other.ValidFor ||
                    ValidFor != null &&
                    ValidFor.Equals(other.ValidFor)
                ) && 
                (
                    EngagedParty == other.EngagedParty ||
                    EngagedParty != null &&
                    EngagedParty.Equals(other.EngagedParty)
                ) && 
                (
                    PartyRoleType == other.PartyRoleType ||
                    PartyRoleType != null &&
                    PartyRoleType.Equals(other.PartyRoleType)
                ) && 
                (
                    Account == other.Account ||
                    Account != null &&
                    Account.SequenceEqual(other.Account)
                ) && 
                (
                    PaymentMethod == other.PaymentMethod ||
                    PaymentMethod != null &&
                    PaymentMethod.SequenceEqual(other.PaymentMethod)
                ) && 
                (
                    ContactMedium == other.ContactMedium ||
                    ContactMedium != null &&
                    ContactMedium.SequenceEqual(other.ContactMedium)
                ) && 
                (
                    Characteristic == other.Characteristic ||
                    Characteristic != null &&
                    Characteristic.SequenceEqual(other.Characteristic)
                ) && 
                (
                    CreditProfile == other.CreditProfile ||
                    CreditProfile != null &&
                    CreditProfile.SequenceEqual(other.CreditProfile)
                ) && 
                (
                    Agreement == other.Agreement ||
                    Agreement != null &&
                    Agreement.SequenceEqual(other.Agreement)
                ) && 
                (
                    RelatedParty == other.RelatedParty ||
                    RelatedParty != null &&
                    RelatedParty.SequenceEqual(other.RelatedParty)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (StatusReason != null)
                    hashCode = hashCode * 59 + StatusReason.GetHashCode();
                    if (ValidFor != null)
                    hashCode = hashCode * 59 + ValidFor.GetHashCode();
                    if (EngagedParty != null)
                    hashCode = hashCode * 59 + EngagedParty.GetHashCode();
                    if (PartyRoleType != null)
                    hashCode = hashCode * 59 + PartyRoleType.GetHashCode();
                    if (Account != null)
                    hashCode = hashCode * 59 + Account.GetHashCode();
                    if (PaymentMethod != null)
                    hashCode = hashCode * 59 + PaymentMethod.GetHashCode();
                    if (ContactMedium != null)
                    hashCode = hashCode * 59 + ContactMedium.GetHashCode();
                    if (Characteristic != null)
                    hashCode = hashCode * 59 + Characteristic.GetHashCode();
                    if (CreditProfile != null)
                    hashCode = hashCode * 59 + CreditProfile.GetHashCode();
                    if (Agreement != null)
                    hashCode = hashCode * 59 + Agreement.GetHashCode();
                    if (RelatedParty != null)
                    hashCode = hashCode * 59 + RelatedParty.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CustomerCreate left, CustomerCreate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CustomerCreate left, CustomerCreate right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}