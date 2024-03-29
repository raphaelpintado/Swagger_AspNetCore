/*
 * ByteBank Api
 *
 * Administra a movimentação bancária do correntista e controla o acesso através de CPF e senha.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: suporte@bytebankapi.com
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
    public partial class Transacao : IEquatable<Transacao>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TipoEnum
        {
            
            /// <summary>
            /// Enum DebitoEnum for debito
            /// </summary>
            [EnumMember(Value = "debito")]
            DebitoEnum = 1,
            
            /// <summary>
            /// Enum DepositoEnum for deposito
            /// </summary>
            [EnumMember(Value = "deposito")]
            DepositoEnum = 2
        }

        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        [DataMember(Name="tipo")]
        public TipoEnum? Tipo { get; set; }

        /// <summary>
        /// Gets or Sets Valor
        /// </summary>
        [DataMember(Name="valor")]
        public double? Valor { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data")]
        public DateTime? Data { get; set; }

        /// <summary>
        /// Gets or Sets Conta
        /// </summary>
        [DataMember(Name="conta")]
        public Conta Conta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transacao {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Conta: ").Append(Conta).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Transacao)obj);
        }

        /// <summary>
        /// Returns true if Transacao instances are equal
        /// </summary>
        /// <param name="other">Instance of Transacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transacao other)
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
                    Tipo == other.Tipo ||
                    Tipo != null &&
                    Tipo.Equals(other.Tipo)
                ) && 
                (
                    Valor == other.Valor ||
                    Valor != null &&
                    Valor.Equals(other.Valor)
                ) && 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
                ) && 
                (
                    Conta == other.Conta ||
                    Conta != null &&
                    Conta.Equals(other.Conta)
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
                    if (Tipo != null)
                    hashCode = hashCode * 59 + Tipo.GetHashCode();
                    if (Valor != null)
                    hashCode = hashCode * 59 + Valor.GetHashCode();
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                    if (Conta != null)
                    hashCode = hashCode * 59 + Conta.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Transacao left, Transacao right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Transacao left, Transacao right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
