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
    /// 
    /// </summary>
    [DataContract]
    public partial class Individual : IEquatable<Individual>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets GivenName
        /// </summary>
        [DataMember(Name="givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or Sets FamilyName
        /// </summary>
        [DataMember(Name="familyName")]
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name="middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets PlaceOfBirth
        /// </summary>
        [DataMember(Name="placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets CountryOfBirth
        /// </summary>
        [DataMember(Name="countryOfBirth")]
        public string CountryOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name="nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets MaritalStatus
        /// </summary>
        [DataMember(Name="maritalStatus")]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name="birthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets FormattedName
        /// </summary>
        [DataMember(Name="formattedName")]
        public string FormattedName { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status")]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Individual {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  PlaceOfBirth: ").Append(PlaceOfBirth).Append("\n");
            sb.Append("  CountryOfBirth: ").Append(CountryOfBirth).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  FormattedName: ").Append(FormattedName).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Individual)obj);
        }

        /// <summary>
        /// Returns true if Individual instances are equal
        /// </summary>
        /// <param name="other">Instance of Individual to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Individual other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    GivenName == other.GivenName ||
                    GivenName != null &&
                    GivenName.Equals(other.GivenName)
                ) && 
                (
                    FamilyName == other.FamilyName ||
                    FamilyName != null &&
                    FamilyName.Equals(other.FamilyName)
                ) && 
                (
                    MiddleName == other.MiddleName ||
                    MiddleName != null &&
                    MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    Href == other.Href ||
                    Href != null &&
                    Href.Equals(other.Href)
                ) && 
                (
                    Gender == other.Gender ||
                    Gender != null &&
                    Gender.Equals(other.Gender)
                ) && 
                (
                    PlaceOfBirth == other.PlaceOfBirth ||
                    PlaceOfBirth != null &&
                    PlaceOfBirth.Equals(other.PlaceOfBirth)
                ) && 
                (
                    CountryOfBirth == other.CountryOfBirth ||
                    CountryOfBirth != null &&
                    CountryOfBirth.Equals(other.CountryOfBirth)
                ) && 
                (
                    Nationality == other.Nationality ||
                    Nationality != null &&
                    Nationality.Equals(other.Nationality)
                ) && 
                (
                    MaritalStatus == other.MaritalStatus ||
                    MaritalStatus != null &&
                    MaritalStatus.Equals(other.MaritalStatus)
                ) && 
                (
                    BirthDate == other.BirthDate ||
                    BirthDate != null &&
                    BirthDate.Equals(other.BirthDate)
                ) && 
                (
                    FullName == other.FullName ||
                    FullName != null &&
                    FullName.Equals(other.FullName)
                ) && 
                (
                    FormattedName == other.FormattedName ||
                    FormattedName != null &&
                    FormattedName.Equals(other.FormattedName)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (GivenName != null)
                    hashCode = hashCode * 59 + GivenName.GetHashCode();
                    if (FamilyName != null)
                    hashCode = hashCode * 59 + FamilyName.GetHashCode();
                    if (MiddleName != null)
                    hashCode = hashCode * 59 + MiddleName.GetHashCode();
                    if (Href != null)
                    hashCode = hashCode * 59 + Href.GetHashCode();
                    if (Gender != null)
                    hashCode = hashCode * 59 + Gender.GetHashCode();
                    if (PlaceOfBirth != null)
                    hashCode = hashCode * 59 + PlaceOfBirth.GetHashCode();
                    if (CountryOfBirth != null)
                    hashCode = hashCode * 59 + CountryOfBirth.GetHashCode();
                    if (Nationality != null)
                    hashCode = hashCode * 59 + Nationality.GetHashCode();
                    if (MaritalStatus != null)
                    hashCode = hashCode * 59 + MaritalStatus.GetHashCode();
                    if (BirthDate != null)
                    hashCode = hashCode * 59 + BirthDate.GetHashCode();
                    if (FullName != null)
                    hashCode = hashCode * 59 + FullName.GetHashCode();
                    if (FormattedName != null)
                    hashCode = hashCode * 59 + FormattedName.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Individual left, Individual right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Individual left, Individual right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
