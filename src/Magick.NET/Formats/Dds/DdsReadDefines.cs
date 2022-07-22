﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System.Collections.Generic;

namespace ImageMagick.Formats
{
    /// <summary>
    /// Class for defines that are used when a <see cref="MagickFormat.Dds"/> image is read.
    /// </summary>
    public sealed class DdsReadDefines : IReadDefines
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DdsReadDefines"/> class.
        /// </summary>
        public DdsReadDefines()
        {
        }

        /// <summary>
        /// Gets the format where the defines are for.
        /// </summary>
        public MagickFormat Format
            => MagickFormat.Dds;

        /// <summary>
        /// Gets or sets a value indicating wether mipmaps should be skipped (dds:skip-mipmaps).
        /// </summary>
        public bool? SkipMipmaps { get; set; }

        /// <summary>
        /// Gets the defines that should be set as a define on an image.
        /// </summary>
        public IEnumerable<IDefine> Defines
        {
            get
            {
                if (SkipMipmaps.HasValue)
                    yield return new MagickDefine(Format, "skip-mipmaps", SkipMipmaps.Value);
            }
        }
    }
}
