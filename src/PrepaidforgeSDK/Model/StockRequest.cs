/* 
 * Prepaidforge API
 *
 * The public api for prepaidforge
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = PrepaidforgeSDK.Client.OpenAPIDateConverter;

namespace PrepaidforgeSDK.Model
{
    /// <summary>
    /// StockRequest
    /// </summary>
    [DataContract]
    public partial class StockRequest :  IEquatable<StockRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Types
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypesEnum
        {
            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            [EnumMember(Value = "TEXT")]
            TEXT = 1,

            /// <summary>
            /// Enum SCAN for value: SCAN
            /// </summary>
            [EnumMember(Value = "SCAN")]
            SCAN = 2,

            /// <summary>
            /// Enum FULLSCAN for value: FULLSCAN
            /// </summary>
            [EnumMember(Value = "FULLSCAN")]
            FULLSCAN = 3,

            /// <summary>
            /// Enum OCR for value: OCR
            /// </summary>
            [EnumMember(Value = "OCR")]
            OCR = 4,

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 5

        }


        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<TypesEnum> Types { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StockRequest" /> class.
        /// </summary>
        /// <param name="types">types.</param>
        /// <param name="skus">skus.</param>
        /// <param name="merchantName">merchantName.</param>
        public StockRequest(List<TypesEnum> types = default(List<TypesEnum>), List<string> skus = default(List<string>), string merchantName = default(string))
        {
            this.Types = types;
            this.Skus = skus;
            this.MerchantName = merchantName;
        }
        

        /// <summary>
        /// Gets or Sets Skus
        /// </summary>
        [DataMember(Name="skus", EmitDefaultValue=false)]
        public List<string> Skus { get; set; }

        /// <summary>
        /// Gets or Sets MerchantName
        /// </summary>
        [DataMember(Name="merchantName", EmitDefaultValue=false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockRequest {\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  Skus: ").Append(Skus).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StockRequest);
        }

        /// <summary>
        /// Returns true if StockRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StockRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    input.Types != null &&
                    this.Types.SequenceEqual(input.Types)
                ) && 
                (
                    this.Skus == input.Skus ||
                    this.Skus != null &&
                    input.Skus != null &&
                    this.Skus.SequenceEqual(input.Skus)
                ) && 
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
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
                int hashCode = 41;
                if (this.Types != null)
                    hashCode = hashCode * 59 + this.Types.GetHashCode();
                if (this.Skus != null)
                    hashCode = hashCode * 59 + this.Skus.GetHashCode();
                if (this.MerchantName != null)
                    hashCode = hashCode * 59 + this.MerchantName.GetHashCode();
                return hashCode;
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
