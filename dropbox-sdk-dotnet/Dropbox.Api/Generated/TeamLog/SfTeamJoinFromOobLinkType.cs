// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The sf team join from oob link type object</para>
    /// </summary>
    public class SfTeamJoinFromOobLinkType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SfTeamJoinFromOobLinkType> Encoder = new SfTeamJoinFromOobLinkTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SfTeamJoinFromOobLinkType> Decoder = new SfTeamJoinFromOobLinkTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SfTeamJoinFromOobLinkType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public SfTeamJoinFromOobLinkType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SfTeamJoinFromOobLinkType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SfTeamJoinFromOobLinkType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the sf team join from oob link type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SfTeamJoinFromOobLinkType" />.</para>
        /// </summary>
        private class SfTeamJoinFromOobLinkTypeEncoder : enc.StructEncoder<SfTeamJoinFromOobLinkType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SfTeamJoinFromOobLinkType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SfTeamJoinFromOobLinkType" />.</para>
        /// </summary>
        private class SfTeamJoinFromOobLinkTypeDecoder : enc.StructDecoder<SfTeamJoinFromOobLinkType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SfTeamJoinFromOobLinkType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SfTeamJoinFromOobLinkType Create()
            {
                return new SfTeamJoinFromOobLinkType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SfTeamJoinFromOobLinkType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}