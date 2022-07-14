/* 
 * Library API
 *
 * Through this API you can access authors and their books.
 *
 * OpenAPI spec version: 1.0
 * Contact: kevin.dockx@gmail.com
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// BookForCreationWithAmountOfPages
    /// </summary>
    [DataContract]
        public partial class BookForCreationWithAmountOfPages :  IEquatable<BookForCreationWithAmountOfPages>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookForCreationWithAmountOfPages" /> class.
        /// </summary>
        /// <param name="amountOfPages">amountOfPages.</param>
        /// <param name="title">title (required).</param>
        /// <param name="description">description (required).</param>
        public BookForCreationWithAmountOfPages(int? amountOfPages = default(int?), string title = default(string), string description = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for BookForCreationWithAmountOfPages and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for BookForCreationWithAmountOfPages and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            this.AmountOfPages = amountOfPages;
        }
        
        /// <summary>
        /// Gets or Sets AmountOfPages
        /// </summary>
        [DataMember(Name="amountOfPages", EmitDefaultValue=false)]
        public int? AmountOfPages { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BookForCreationWithAmountOfPages {\n");
            sb.Append("  AmountOfPages: ").Append(AmountOfPages).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as BookForCreationWithAmountOfPages);
        }

        /// <summary>
        /// Returns true if BookForCreationWithAmountOfPages instances are equal
        /// </summary>
        /// <param name="input">Instance of BookForCreationWithAmountOfPages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BookForCreationWithAmountOfPages input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmountOfPages == input.AmountOfPages ||
                    (this.AmountOfPages != null &&
                    this.AmountOfPages.Equals(input.AmountOfPages))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.AmountOfPages != null)
                    hashCode = hashCode * 59 + this.AmountOfPages.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
