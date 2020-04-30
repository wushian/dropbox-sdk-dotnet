// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The paper doc create error object</para>
    /// </summary>
    public class PaperDocCreateError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperDocCreateError> Encoder = new PaperDocCreateErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperDocCreateError> Decoder = new PaperDocCreateErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperDocCreateError" />
        /// class.</para>
        /// </summary>
        public PaperDocCreateError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ContentMalformed</para>
        /// </summary>
        public bool IsContentMalformed
        {
            get
            {
                return this is ContentMalformed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ContentMalformed, or <c>null</c>.</para>
        /// </summary>
        public ContentMalformed AsContentMalformed
        {
            get
            {
                return this as ContentMalformed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is FolderNotFound</para>
        /// </summary>
        public bool IsFolderNotFound
        {
            get
            {
                return this is FolderNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FolderNotFound, or <c>null</c>.</para>
        /// </summary>
        public FolderNotFound AsFolderNotFound
        {
            get
            {
                return this as FolderNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DocLengthExceeded</para>
        /// </summary>
        public bool IsDocLengthExceeded
        {
            get
            {
                return this is DocLengthExceeded;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DocLengthExceeded, or <c>null</c>.</para>
        /// </summary>
        public DocLengthExceeded AsDocLengthExceeded
        {
            get
            {
                return this as DocLengthExceeded;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ImageSizeExceeded</para>
        /// </summary>
        public bool IsImageSizeExceeded
        {
            get
            {
                return this is ImageSizeExceeded;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ImageSizeExceeded, or <c>null</c>.</para>
        /// </summary>
        public ImageSizeExceeded AsImageSizeExceeded
        {
            get
            {
                return this as ImageSizeExceeded;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// InsufficientPermissions</para>
        /// </summary>
        public bool IsInsufficientPermissions
        {
            get
            {
                return this is InsufficientPermissions;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InsufficientPermissions, or <c>null</c>.</para>
        /// </summary>
        public InsufficientPermissions AsInsufficientPermissions
        {
            get
            {
                return this as InsufficientPermissions;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PaperDocCreateError" />.</para>
        /// </summary>
        private class PaperDocCreateErrorEncoder : enc.StructEncoder<PaperDocCreateError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperDocCreateError value, enc.IJsonWriter writer)
            {
                if (value is ContentMalformed)
                {
                    WriteProperty(".tag", "content_malformed", writer, enc.StringEncoder.Instance);
                    ContentMalformed.Encoder.EncodeFields((ContentMalformed)value, writer);
                    return;
                }
                if (value is FolderNotFound)
                {
                    WriteProperty(".tag", "folder_not_found", writer, enc.StringEncoder.Instance);
                    FolderNotFound.Encoder.EncodeFields((FolderNotFound)value, writer);
                    return;
                }
                if (value is DocLengthExceeded)
                {
                    WriteProperty(".tag", "doc_length_exceeded", writer, enc.StringEncoder.Instance);
                    DocLengthExceeded.Encoder.EncodeFields((DocLengthExceeded)value, writer);
                    return;
                }
                if (value is ImageSizeExceeded)
                {
                    WriteProperty(".tag", "image_size_exceeded", writer, enc.StringEncoder.Instance);
                    ImageSizeExceeded.Encoder.EncodeFields((ImageSizeExceeded)value, writer);
                    return;
                }
                if (value is InsufficientPermissions)
                {
                    WriteProperty(".tag", "insufficient_permissions", writer, enc.StringEncoder.Instance);
                    InsufficientPermissions.Encoder.EncodeFields((InsufficientPermissions)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PaperDocCreateError" />.</para>
        /// </summary>
        private class PaperDocCreateErrorDecoder : enc.UnionDecoder<PaperDocCreateError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PaperDocCreateError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperDocCreateError Create()
            {
                return new PaperDocCreateError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override PaperDocCreateError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "content_malformed":
                        return ContentMalformed.Decoder.DecodeFields(reader);
                    case "folder_not_found":
                        return FolderNotFound.Decoder.DecodeFields(reader);
                    case "doc_length_exceeded":
                        return DocLengthExceeded.Decoder.DecodeFields(reader);
                    case "image_size_exceeded":
                        return ImageSizeExceeded.Decoder.DecodeFields(reader);
                    case "insufficient_permissions":
                        return InsufficientPermissions.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The provided content was malformed and cannot be imported to Paper.</para>
        /// </summary>
        public sealed class ContentMalformed : PaperDocCreateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ContentMalformed> Encoder = new ContentMalformedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ContentMalformed> Decoder = new ContentMalformedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ContentMalformed" />
            /// class.</para>
            /// </summary>
            private ContentMalformed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ContentMalformed</para>
            /// </summary>
            public static readonly ContentMalformed Instance = new ContentMalformed();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ContentMalformed" />.</para>
            /// </summary>
            private class ContentMalformedEncoder : enc.StructEncoder<ContentMalformed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ContentMalformed value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ContentMalformed" />.</para>
            /// </summary>
            private class ContentMalformedDecoder : enc.StructDecoder<ContentMalformed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ContentMalformed" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ContentMalformed Create()
                {
                    return ContentMalformed.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The specified Paper folder is cannot be found.</para>
        /// </summary>
        public sealed class FolderNotFound : PaperDocCreateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<FolderNotFound> Encoder = new FolderNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<FolderNotFound> Decoder = new FolderNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FolderNotFound" />
            /// class.</para>
            /// </summary>
            private FolderNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of FolderNotFound</para>
            /// </summary>
            public static readonly FolderNotFound Instance = new FolderNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="FolderNotFound" />.</para>
            /// </summary>
            private class FolderNotFoundEncoder : enc.StructEncoder<FolderNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(FolderNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="FolderNotFound" />.</para>
            /// </summary>
            private class FolderNotFoundDecoder : enc.StructDecoder<FolderNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="FolderNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override FolderNotFound Create()
                {
                    return FolderNotFound.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The newly created Paper doc would be too large. Please split the content into
        /// multiple docs.</para>
        /// </summary>
        public sealed class DocLengthExceeded : PaperDocCreateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DocLengthExceeded> Encoder = new DocLengthExceededEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DocLengthExceeded> Decoder = new DocLengthExceededDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DocLengthExceeded" />
            /// class.</para>
            /// </summary>
            private DocLengthExceeded()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DocLengthExceeded</para>
            /// </summary>
            public static readonly DocLengthExceeded Instance = new DocLengthExceeded();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DocLengthExceeded" />.</para>
            /// </summary>
            private class DocLengthExceededEncoder : enc.StructEncoder<DocLengthExceeded>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DocLengthExceeded value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DocLengthExceeded" />.</para>
            /// </summary>
            private class DocLengthExceededDecoder : enc.StructDecoder<DocLengthExceeded>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DocLengthExceeded"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DocLengthExceeded Create()
                {
                    return DocLengthExceeded.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The imported document contains an image that is too large. The current limit
        /// is 1MB. This only applies to HTML with data URI.</para>
        /// </summary>
        public sealed class ImageSizeExceeded : PaperDocCreateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ImageSizeExceeded> Encoder = new ImageSizeExceededEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ImageSizeExceeded> Decoder = new ImageSizeExceededDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ImageSizeExceeded" />
            /// class.</para>
            /// </summary>
            private ImageSizeExceeded()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ImageSizeExceeded</para>
            /// </summary>
            public static readonly ImageSizeExceeded Instance = new ImageSizeExceeded();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ImageSizeExceeded" />.</para>
            /// </summary>
            private class ImageSizeExceededEncoder : enc.StructEncoder<ImageSizeExceeded>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ImageSizeExceeded value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ImageSizeExceeded" />.</para>
            /// </summary>
            private class ImageSizeExceededDecoder : enc.StructDecoder<ImageSizeExceeded>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ImageSizeExceeded"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ImageSizeExceeded Create()
                {
                    return ImageSizeExceeded.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Your account does not have permissions to perform this action. This may be
        /// due to it only having access to Paper as files in the Dropbox filesystem. For more
        /// information, refer to the <a
        /// href="https://www.dropbox.com/lp/developers/reference/paper-migration-guide">Paper
        /// Migration Guide</a>.</para>
        /// </summary>
        public sealed class InsufficientPermissions : PaperDocCreateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InsufficientPermissions> Encoder = new InsufficientPermissionsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InsufficientPermissions> Decoder = new InsufficientPermissionsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InsufficientPermissions" />
            /// class.</para>
            /// </summary>
            private InsufficientPermissions()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InsufficientPermissions</para>
            /// </summary>
            public static readonly InsufficientPermissions Instance = new InsufficientPermissions();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InsufficientPermissions" />.</para>
            /// </summary>
            private class InsufficientPermissionsEncoder : enc.StructEncoder<InsufficientPermissions>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InsufficientPermissions value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InsufficientPermissions" />.</para>
            /// </summary>
            private class InsufficientPermissionsDecoder : enc.StructDecoder<InsufficientPermissions>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InsufficientPermissions"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InsufficientPermissions Create()
                {
                    return InsufficientPermissions.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : PaperDocCreateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}