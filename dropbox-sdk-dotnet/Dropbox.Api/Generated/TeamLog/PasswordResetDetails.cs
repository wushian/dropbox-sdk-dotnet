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
    /// <para>Reset password.</para>
    /// </summary>
    public class PasswordResetDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PasswordResetDetails> Encoder = new PasswordResetDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PasswordResetDetails> Decoder = new PasswordResetDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PasswordResetDetails" />
        /// class.</para>
        /// </summary>
        public PasswordResetDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PasswordResetDetails" />.</para>
        /// </summary>
        private class PasswordResetDetailsEncoder : enc.StructEncoder<PasswordResetDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PasswordResetDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PasswordResetDetails" />.</para>
        /// </summary>
        private class PasswordResetDetailsDecoder : enc.StructDecoder<PasswordResetDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PasswordResetDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PasswordResetDetails Create()
            {
                return new PasswordResetDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PasswordResetDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}