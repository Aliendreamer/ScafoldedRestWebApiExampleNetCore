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
    /// Party reference. A party represents an organization or an individual.
    /// </summary>
    [DataContract]
    public partial class PartyRef : IEquatable<PartyRef>
    { 
        /// <summary>
        /// Generic attribute indicating the name of the class type of the referred resource entity.
        /// </summary>
        /// <value>Generic attribute indicating the name of the class type of the referred resource entity.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PartyRefTypeEnum
        {
            
            /// <summary>
            /// Enum IndividualEnum for Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            IndividualEnum = 1,
            
            /// <summary>
            /// Enum OrganizationEnum for Organization
            /// </summary>
            [EnumMember(Value = "Organization")]
            OrganizationEnum = 2
        }

        /// <summary>
        /// Generic attribute indicating the name of the class type of the referred resource entity.
        /// </summary>
        /// <value>Generic attribute indicating the name of the class type of the referred resource entity.</value>
        [DataMember(Name="partyRefType")]
        public PartyRefTypeEnum? PartyRefType { get; set; }

        /// <summary>
        /// Text describing the referred party
        /// </summary>
        /// <value>Text describing the referred party</value>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Reference of the referred party (such as a partner or any other party role).
        /// </summary>
        /// <value>Reference of the referred party (such as a partner or any other party role).</value>
        [DataMember(Name="href")]
        public string Href { get; set; }

        /// <summary>
        /// Unique identifier of the referred party
        /// </summary>
        /// <value>Unique identifier of the referred party</value>
        [Required]
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the referred party (such as a partner or any other party role)
        /// </summary>
        /// <value>Name of the referred party (such as a partner or any other party role)</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Individual
        /// </summary>
        [DataMember(Name="individual")]
        public List<Individual> Individual { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization")]
        public List<Organization> Organization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartyRef {\n");
            sb.Append("  PartyRefType: ").Append(PartyRefType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Individual: ").Append(Individual).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PartyRef)obj);
        }

        /// <summary>
        /// Returns true if PartyRef instances are equal
        /// </summary>
        /// <param name="other">Instance of PartyRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartyRef other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PartyRefType == other.PartyRefType ||
                    PartyRefType != null &&
                    PartyRefType.Equals(other.PartyRefType)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Href == other.Href ||
                    Href != null &&
                    Href.Equals(other.Href)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Individual == other.Individual ||
                    Individual != null &&
                    Individual.SequenceEqual(other.Individual)
                ) && 
                (
                    Organization == other.Organization ||
                    Organization != null &&
                    Organization.SequenceEqual(other.Organization)
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
                    if (PartyRefType != null)
                    hashCode = hashCode * 59 + PartyRefType.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Href != null)
                    hashCode = hashCode * 59 + Href.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Individual != null)
                    hashCode = hashCode * 59 + Individual.GetHashCode();
                    if (Organization != null)
                    hashCode = hashCode * 59 + Organization.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PartyRef left, PartyRef right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PartyRef left, PartyRef right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
