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
    /// A base / value business entity used to represent a period of time between two timepoints.
    /// </summary>
    [DataContract]
    public partial class TimePeriod : IEquatable<TimePeriod>
    { 
        /// <summary>
        /// An instant of time, ending at the TimePeriod.
        /// </summary>
        /// <value>An instant of time, ending at the TimePeriod.</value>
        [DataMember(Name="endDateTime")]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// An instant of time, starting at the TimePeriod
        /// </summary>
        /// <value>An instant of time, starting at the TimePeriod</value>
        [DataMember(Name="startDateTime")]
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimePeriod {\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimePeriod)obj);
        }

        /// <summary>
        /// Returns true if TimePeriod instances are equal
        /// </summary>
        /// <param name="other">Instance of TimePeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimePeriod other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EndDateTime == other.EndDateTime ||
                    EndDateTime != null &&
                    EndDateTime.Equals(other.EndDateTime)
                ) && 
                (
                    StartDateTime == other.StartDateTime ||
                    StartDateTime != null &&
                    StartDateTime.Equals(other.StartDateTime)
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
                    if (EndDateTime != null)
                    hashCode = hashCode * 59 + EndDateTime.GetHashCode();
                    if (StartDateTime != null)
                    hashCode = hashCode * 59 + StartDateTime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimePeriod left, TimePeriod right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimePeriod left, TimePeriod right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
