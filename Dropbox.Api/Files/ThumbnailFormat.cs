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
    /// <para>The thumbnail format object</para>
    /// </summary>
    public class ThumbnailFormat
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ThumbnailFormat> Encoder = new ThumbnailFormatEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ThumbnailFormat> Decoder = new ThumbnailFormatDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ThumbnailFormat" />
        /// class.</para>
        /// </summary>
        public ThumbnailFormat()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Jpeg</para>
        /// </summary>
        public bool IsJpeg
        {
            get
            {
                return this is Jpeg;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Jpeg, or <c>null</c>.</para>
        /// </summary>
        public Jpeg AsJpeg
        {
            get
            {
                return this as Jpeg;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Png</para>
        /// </summary>
        public bool IsPng
        {
            get
            {
                return this is Png;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Png, or <c>null</c>.</para>
        /// </summary>
        public Png AsPng
        {
            get
            {
                return this as Png;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ThumbnailFormat" />.</para>
        /// </summary>
        private class ThumbnailFormatEncoder : enc.StructEncoder<ThumbnailFormat>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ThumbnailFormat value, enc.IJsonWriter writer)
            {
                if (value is Jpeg)
                {
                    WriteProperty(".tag", "jpeg", writer, enc.StringEncoder.Instance);
                    Jpeg.Encoder.EncodeFields((Jpeg)value, writer);
                    return;
                }
                if (value is Png)
                {
                    WriteProperty(".tag", "png", writer, enc.StringEncoder.Instance);
                    Png.Encoder.EncodeFields((Png)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ThumbnailFormat" />.</para>
        /// </summary>
        private class ThumbnailFormatDecoder : enc.UnionDecoder<ThumbnailFormat>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ThumbnailFormat" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ThumbnailFormat Create()
            {
                return new ThumbnailFormat();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ThumbnailFormat Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "jpeg":
                        return Jpeg.Decoder.DecodeFields(reader);
                    case "png":
                        return Png.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The jpeg object</para>
        /// </summary>
        public sealed class Jpeg : ThumbnailFormat
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Jpeg> Encoder = new JpegEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Jpeg> Decoder = new JpegDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Jpeg" /> class.</para>
            /// </summary>
            private Jpeg()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Jpeg</para>
            /// </summary>
            public static readonly Jpeg Instance = new Jpeg();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Jpeg" />.</para>
            /// </summary>
            private class JpegEncoder : enc.StructEncoder<Jpeg>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Jpeg value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Jpeg" />.</para>
            /// </summary>
            private class JpegDecoder : enc.StructDecoder<Jpeg>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Jpeg" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Jpeg Create()
                {
                    return new Jpeg();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Jpeg DecodeFields(enc.IJsonReader reader)
                {
                    return Jpeg.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The png object</para>
        /// </summary>
        public sealed class Png : ThumbnailFormat
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Png> Encoder = new PngEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Png> Decoder = new PngDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Png" /> class.</para>
            /// </summary>
            private Png()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Png</para>
            /// </summary>
            public static readonly Png Instance = new Png();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Png" />.</para>
            /// </summary>
            private class PngEncoder : enc.StructEncoder<Png>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Png value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Png" />.</para>
            /// </summary>
            private class PngDecoder : enc.StructDecoder<Png>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Png" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Png Create()
                {
                    return new Png();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Png DecodeFields(enc.IJsonReader reader)
                {
                    return Png.Instance;
                }
            }

            #endregion
        }
    }
}