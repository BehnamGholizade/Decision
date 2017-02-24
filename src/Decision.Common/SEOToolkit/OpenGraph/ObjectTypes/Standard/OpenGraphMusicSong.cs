﻿using System;
using System.Collections.Generic;
using System.Text;
using Decision.Common.SEOToolkit.OpenGraph.Enums;
using Decision.Common.SEOToolkit.OpenGraph.Media;
using NTierMvcFramework.Common.Extensions;

namespace Decision.Common.SEOToolkit.OpenGraph.ObjectTypes.Standard
{
    /// <summary>
    ///     This object represents a single song. This object type is part of the Open Graph standard.
    ///     See http://ogp.me/
    ///     https://developers.facebook.com/docs/reference/opengraph/object-type/music.song/
    /// </summary>
    public class OpenGraphMusicSong : OpenGraphMetadata
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenGraphMusicSong" /> class.
        /// </summary>
        /// <param name="title">The title of the object as it should appear in the graph.</param>
        /// <param name="image">The default image.</param>
        /// <param name="albumUrls">
        ///     The URL's to the pages about the album the song comes from. This URL's must contain profile
        ///     meta tags <see cref="OpenGraphMusicAlbum" />.
        /// </param>
        /// <param name="url">The canonical URL of the object, used as its ID in the graph.</param>
        public OpenGraphMusicSong(string title, OpenGraphImage image, IEnumerable<string> albumUrls, string url = null)
            : base(title, image, url)
        {
            if (albumUrls == null)
            {
                throw new ArgumentNullException(nameof(albumUrls));
            }

            AlbumUrls = albumUrls;
            AlbumDisc = 1;
            AlbumTrack = 1;
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Appends a HTML-encoded string representing this instance to the <paramref name="stringBuilder" /> containing the
        ///     Open Graph meta tags.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        public override void ToString(StringBuilder stringBuilder)
        {
            base.ToString(stringBuilder);

            stringBuilder.AppendMetaPropertyContentIfNotNull("music:duration", Duration);
            stringBuilder.AppendMetaPropertyContentIfNotNull("music:album", AlbumUrls);
            stringBuilder.AppendMetaPropertyContent("music:album:disc", AlbumDisc);
            stringBuilder.AppendMetaPropertyContent("music:album:track", AlbumTrack);
            stringBuilder.AppendMetaPropertyContentIfNotNull("music:musician", MusicianUrls);
            stringBuilder.AppendMetaPropertyContentIfNotNull("music:isrc", ISRC);
            stringBuilder.AppendMetaPropertyContentIfNotNull("music:release_date", ReleaseDate);

            if (ReleaseType.HasValue)
            {
                stringBuilder.AppendMetaPropertyContent("music:release_type", ReleaseType.Value.ToLowercaseString());
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets which disc in the album the song is from.
        /// </summary>
        public int AlbumDisc { get; set; }

        /// <summary>
        ///     Gets or sets which track in the album the song is from.
        /// </summary>
        public int AlbumTrack { get; set; }

        /// <summary>
        ///     Gets the URL's to the pages about the album the song comes from. This URL's must contain profile meta tags
        ///     <see cref="OpenGraphMusicAlbum" />.
        /// </summary>
        public IEnumerable<string> AlbumUrls { get; }

        /// <summary>
        ///     Gets or sets the duration of the song in seconds.
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        ///     Gets or sets the International Standard Recording Code (ISRC) for the song. This is a Facebook specific property
        ///     and is not specified in the
        ///     Open Graph standard.
        /// </summary>
        public string ISRC { get; set; }

        /// <summary>
        ///     Gets the namespace of this open graph type.
        /// </summary>
        public override string Namespace => "music: http://ogp.me/ns/music#";

        /// <summary>
        ///     Gets or sets the URL's to the pages about the musicians who wrote the song. This URL's must contain profile meta
        ///     tags <see cref="OpenGraphProfile" />.
        /// </summary>
        public IEnumerable<string> MusicianUrls { get; set; }

        /// <summary>
        ///     Gets or sets the release date of the song. This is a Facebook specific property and is not specified in the Open
        ///     Graph standard.
        /// </summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        ///     Gets or sets the type of the release of the song. This is a Facebook specific property and not specified by the
        ///     Open Graph standard.
        /// </summary>
        public OpenGraphMusicReleaseType? ReleaseType { get; set; }

        /// <summary>
        ///     Gets the type of your object. Depending on the type you specify, other properties may also be required.
        /// </summary>
        public override OpenGraphType Type => OpenGraphType.MusicSong;

        #endregion
    }
}