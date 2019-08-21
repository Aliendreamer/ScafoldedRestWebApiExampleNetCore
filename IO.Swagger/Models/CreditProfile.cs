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
    /// Credit profile for the party (containing credit scoring, ...). By default only the current credit profile  is retrieved. It can be used as a list to give the party credit profiles history, the first one in the list will be the current one.
    /// </summary>
    [DataContract]
    public partial class CreditProfile : IEquatable<CreditProfile>
    { 
        /// <summary>
        /// The date the profile was established
        /// </summary>
        /// <value>The date the profile was established</value>
        [Required]
        [DataMember(Name="creditProfileDate")]
        public DateTime? CreditProfileDate { get; set; }

        /// <summary>
        /// This is an integer\\string whose value is used to rate the risk
        /// </summary>
        /// <value>This is an integer\\string whose value is used to rate the risk</value>
        [DataMember(Name="creditRiskRating")]
        public string CreditRiskRating { get; set; }

        /// <summary>
        /// A measure of a person&#39;s or an organization&#39;s creditworthiness calculated on the basis of a combination of factors such as their income and credit history.
        /// </summary>
        /// <value>A measure of a person&#39;s or an organization&#39;s creditworthiness calculated on the basis of a combination of factors such as their income and credit history.</value>
        [DataMember(Name="creditScore")]
        public string CreditScore { get; set; }

        /// <summary>
        /// The period for which the profile is valid
        /// </summary>
        /// <value>The period for which the profile is valid</value>
        [Required]
        [DataMember(Name="validFor")]
        public TimePeriod ValidFor { get; set; }

        /// <summary>
        /// description of persons credit worthiness
        /// </summary>
        /// <value>description of persons credit worthiness</value>
        [DataMember(Name="tagCreditScoring")]
        public string TagCreditScoring { get; set; }

        /// <summary>
        /// credit limit
        /// </summary>
        /// <value>credit limit</value>
        [DataMember(Name="tagCreditLimit")]
        public int? TagCreditLimit { get; set; }

        /// <summary>
        /// account credit threshold
        /// </summary>
        /// <value>account credit threshold</value>
        [DataMember(Name="tagCreditThreshold")]
        public string TagCreditThreshold { get; set; }

        /// <summary>
        /// The date the profile was established
        /// </summary>
        /// <value>The date the profile was established</value>
        [DataMember(Name="tagCreditOnHold")]
        public string TagCreditOnHold { get; set; }

        /// <summary>
        /// daily credit limit second contract
        /// </summary>
        /// <value>daily credit limit second contract</value>
        [DataMember(Name="tagContractDailyCreditLimit")]
        public string TagContractDailyCreditLimit { get; set; }

        /// <summary>
        /// Periodic credit limit second contract
        /// </summary>
        /// <value>Periodic credit limit second contract</value>
        [DataMember(Name="tagContractPeriodicCreditLimit")]
        public string TagContractPeriodicCreditLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditProfile {\n");
            sb.Append("  CreditProfileDate: ").Append(CreditProfileDate).Append("\n");
            sb.Append("  CreditRiskRating: ").Append(CreditRiskRating).Append("\n");
            sb.Append("  CreditScore: ").Append(CreditScore).Append("\n");
            sb.Append("  ValidFor: ").Append(ValidFor).Append("\n");
            sb.Append("  TagCreditScoring: ").Append(TagCreditScoring).Append("\n");
            sb.Append("  TagCreditLimit: ").Append(TagCreditLimit).Append("\n");
            sb.Append("  TagCreditThreshold: ").Append(TagCreditThreshold).Append("\n");
            sb.Append("  TagCreditOnHold: ").Append(TagCreditOnHold).Append("\n");
            sb.Append("  TagContractDailyCreditLimit: ").Append(TagContractDailyCreditLimit).Append("\n");
            sb.Append("  TagContractPeriodicCreditLimit: ").Append(TagContractPeriodicCreditLimit).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreditProfile)obj);
        }

        /// <summary>
        /// Returns true if CreditProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditProfile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CreditProfileDate == other.CreditProfileDate ||
                    CreditProfileDate != null &&
                    CreditProfileDate.Equals(other.CreditProfileDate)
                ) && 
                (
                    CreditRiskRating == other.CreditRiskRating ||
                    CreditRiskRating != null &&
                    CreditRiskRating.Equals(other.CreditRiskRating)
                ) && 
                (
                    CreditScore == other.CreditScore ||
                    CreditScore != null &&
                    CreditScore.Equals(other.CreditScore)
                ) && 
                (
                    ValidFor == other.ValidFor ||
                    ValidFor != null &&
                    ValidFor.Equals(other.ValidFor)
                ) && 
                (
                    TagCreditScoring == other.TagCreditScoring ||
                    TagCreditScoring != null &&
                    TagCreditScoring.Equals(other.TagCreditScoring)
                ) && 
                (
                    TagCreditLimit == other.TagCreditLimit ||
                    TagCreditLimit != null &&
                    TagCreditLimit.Equals(other.TagCreditLimit)
                ) && 
                (
                    TagCreditThreshold == other.TagCreditThreshold ||
                    TagCreditThreshold != null &&
                    TagCreditThreshold.Equals(other.TagCreditThreshold)
                ) && 
                (
                    TagCreditOnHold == other.TagCreditOnHold ||
                    TagCreditOnHold != null &&
                    TagCreditOnHold.Equals(other.TagCreditOnHold)
                ) && 
                (
                    TagContractDailyCreditLimit == other.TagContractDailyCreditLimit ||
                    TagContractDailyCreditLimit != null &&
                    TagContractDailyCreditLimit.Equals(other.TagContractDailyCreditLimit)
                ) && 
                (
                    TagContractPeriodicCreditLimit == other.TagContractPeriodicCreditLimit ||
                    TagContractPeriodicCreditLimit != null &&
                    TagContractPeriodicCreditLimit.Equals(other.TagContractPeriodicCreditLimit)
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
                    if (CreditProfileDate != null)
                    hashCode = hashCode * 59 + CreditProfileDate.GetHashCode();
                    if (CreditRiskRating != null)
                    hashCode = hashCode * 59 + CreditRiskRating.GetHashCode();
                    if (CreditScore != null)
                    hashCode = hashCode * 59 + CreditScore.GetHashCode();
                    if (ValidFor != null)
                    hashCode = hashCode * 59 + ValidFor.GetHashCode();
                    if (TagCreditScoring != null)
                    hashCode = hashCode * 59 + TagCreditScoring.GetHashCode();
                    if (TagCreditLimit != null)
                    hashCode = hashCode * 59 + TagCreditLimit.GetHashCode();
                    if (TagCreditThreshold != null)
                    hashCode = hashCode * 59 + TagCreditThreshold.GetHashCode();
                    if (TagCreditOnHold != null)
                    hashCode = hashCode * 59 + TagCreditOnHold.GetHashCode();
                    if (TagContractDailyCreditLimit != null)
                    hashCode = hashCode * 59 + TagContractDailyCreditLimit.GetHashCode();
                    if (TagContractPeriodicCreditLimit != null)
                    hashCode = hashCode * 59 + TagContractPeriodicCreditLimit.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreditProfile left, CreditProfile right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreditProfile left, CreditProfile right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}