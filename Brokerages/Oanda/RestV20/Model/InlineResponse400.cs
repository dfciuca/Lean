/* 
 * OANDA v20 REST API
 *
 * The full OANDA v20 REST API Specification. This specification defines how to interact with v20 Accounts, Trades, Orders, Pricing and more.
 *
 * OpenAPI spec version: 3.0.15
 * Contact: api@oanda.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Oanda.RestV20.Model
{
    /// <summary>
    /// InlineResponse400
    /// </summary>
    [DataContract]
    public partial class InlineResponse400 :  IEquatable<InlineResponse400>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse400" /> class.
        /// </summary>
        /// <param name="ClientConfigureRejectTransaction">ClientConfigureRejectTransaction.</param>
        /// <param name="LastTransactionID">The ID of the last Transaction created for the Account..</param>
        /// <param name="ErrorCode">The code of the error that has occurred. This field may not be returned for some errors..</param>
        /// <param name="ErrorMessage">The human-readable description of the error that has occurred..</param>
        public InlineResponse400(ClientConfigureRejectTransaction ClientConfigureRejectTransaction = default(ClientConfigureRejectTransaction), string LastTransactionID = default(string), string ErrorCode = default(string), string ErrorMessage = default(string))
        {
            this.ClientConfigureRejectTransaction = ClientConfigureRejectTransaction;
            this.LastTransactionID = LastTransactionID;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
        }
        
        /// <summary>
        /// Gets or Sets ClientConfigureRejectTransaction
        /// </summary>
        [DataMember(Name="clientConfigureRejectTransaction", EmitDefaultValue=false)]
        public ClientConfigureRejectTransaction ClientConfigureRejectTransaction { get; set; }
        /// <summary>
        /// The ID of the last Transaction created for the Account.
        /// </summary>
        /// <value>The ID of the last Transaction created for the Account.</value>
        [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
        public string LastTransactionID { get; set; }
        /// <summary>
        /// The code of the error that has occurred. This field may not be returned for some errors.
        /// </summary>
        /// <value>The code of the error that has occurred. This field may not be returned for some errors.</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        /// <summary>
        /// The human-readable description of the error that has occurred.
        /// </summary>
        /// <value>The human-readable description of the error that has occurred.</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse400 {\n");
            sb.Append("  ClientConfigureRejectTransaction: ").Append(ClientConfigureRejectTransaction).Append("\n");
            sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse400);
        }

        /// <summary>
        /// Returns true if InlineResponse400 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse400 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse400 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientConfigureRejectTransaction == other.ClientConfigureRejectTransaction ||
                    this.ClientConfigureRejectTransaction != null &&
                    this.ClientConfigureRejectTransaction.Equals(other.ClientConfigureRejectTransaction)
                ) && 
                (
                    this.LastTransactionID == other.LastTransactionID ||
                    this.LastTransactionID != null &&
                    this.LastTransactionID.Equals(other.LastTransactionID)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ClientConfigureRejectTransaction != null)
                    hash = hash * 59 + this.ClientConfigureRejectTransaction.GetHashCode();
                if (this.LastTransactionID != null)
                    hash = hash * 59 + this.LastTransactionID.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
