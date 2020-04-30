// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The save url result object</para>
    /// </summary>
    public class SaveUrlResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SaveUrlResult> Encoder = new SaveUrlResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SaveUrlResult> Decoder = new SaveUrlResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SaveUrlResult" /> class.</para>
        /// </summary>
        public SaveUrlResult()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Complete</para>
        /// </summary>
        public bool IsComplete
        {
            get
            {
                return this is Complete;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Complete, or <c>null</c>.</para>
        /// </summary>
        public Complete AsComplete
        {
            get
            {
                return this as Complete;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AsyncJobId</para>
        /// </summary>
        public bool IsAsyncJobId
        {
            get
            {
                return this is AsyncJobId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AsyncJobId, or <c>null</c>.</para>
        /// </summary>
        public AsyncJobId AsAsyncJobId
        {
            get
            {
                return this as AsyncJobId;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SaveUrlResult" />.</para>
        /// </summary>
        private class SaveUrlResultEncoder : enc.StructEncoder<SaveUrlResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SaveUrlResult value, enc.IJsonWriter writer)
            {
                if (value is Complete)
                {
                    WriteProperty(".tag", "complete", writer, enc.StringEncoder.Instance);
                    Complete.Encoder.EncodeFields((Complete)value, writer);
                    return;
                }
                if (value is AsyncJobId)
                {
                    WriteProperty(".tag", "async_job_id", writer, enc.StringEncoder.Instance);
                    AsyncJobId.Encoder.EncodeFields((AsyncJobId)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SaveUrlResult" />.</para>
        /// </summary>
        private class SaveUrlResultDecoder : enc.UnionDecoder<SaveUrlResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SaveUrlResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SaveUrlResult Create()
            {
                return new SaveUrlResult();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SaveUrlResult Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "complete":
                        return Complete.Decoder.DecodeFields(reader);
                    case "async_job_id":
                        return AsyncJobId.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Metadata of the file where the URL is saved to.</para>
        /// </summary>
        public sealed class Complete : SaveUrlResult
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Complete> Encoder = new CompleteEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Complete> Decoder = new CompleteDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Complete" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Complete(FileMetadata value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Complete" /> class.</para>
            /// </summary>
            private Complete()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public FileMetadata Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Complete" />.</para>
            /// </summary>
            private class CompleteEncoder : enc.StructEncoder<Complete>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Complete value, enc.IJsonWriter writer)
                {
                    WriteProperty("complete", value.Value, writer, global::Dropbox.Api.Files.FileMetadata.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Complete" />.</para>
            /// </summary>
            private class CompleteDecoder : enc.StructDecoder<Complete>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Complete" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Complete Create()
                {
                    return new Complete();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Complete DecodeFields(enc.IJsonReader reader)
                {
                    return new Complete(global::Dropbox.Api.Files.FileMetadata.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>This response indicates that the processing is asynchronous. The string is an
        /// id that can be used to obtain the status of the asynchronous job.</para>
        /// </summary>
        public sealed class AsyncJobId : SaveUrlResult
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AsyncJobId> Encoder = new AsyncJobIdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AsyncJobId> Decoder = new AsyncJobIdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AsyncJobId" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public AsyncJobId(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AsyncJobId" /> class.</para>
            /// </summary>
            private AsyncJobId()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AsyncJobId" />.</para>
            /// </summary>
            private class AsyncJobIdEncoder : enc.StructEncoder<AsyncJobId>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AsyncJobId value, enc.IJsonWriter writer)
                {
                    WriteProperty("async_job_id", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AsyncJobId" />.</para>
            /// </summary>
            private class AsyncJobIdDecoder : enc.StructDecoder<AsyncJobId>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AsyncJobId" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AsyncJobId Create()
                {
                    return new AsyncJobId();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(AsyncJobId value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "async_job_id":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
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
}