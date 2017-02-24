﻿using System;
using System.Collections.Generic;
using System.Text;
using Decision.Common.Extensions;
using Decision.Common.SEO.OpenGraph.Enums;
using Decision.Common.SEO.OpenGraph.Media;
using Decision.Common.SEO.OpenGraph.Structs;

namespace Decision.Common.SEO.OpenGraph.ObjectTypes.Standard
{
    /// <summary>
    ///     This object type represents an episode of a TV show and contains references to the actors and other professionals
    ///     involved in its production.
    ///     An episode is defined by us as a full-length episode that is part of a series. This type must reference the series
    ///     this it is part of.
    ///     This object type is part of the Open Graph standard.
    ///     See http://ogp.me/
    ///     See https://developers.facebook.com/docs/reference/opengraph/object-type/video.episode/
    /// </summary>
    public class OpenGraphVideoEpisode : OpenGraphMetadata
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenGraphVideoEpisode" /> class.
        /// </summary>
        /// <param name="title">The title of the object as it should appear in the graph.</param>
        /// <param name="image">The default image.</param>
        /// <param name="url">The canonical URL of the object, used as its ID in the graph.</param>
        public OpenGraphVideoEpisode(string title, OpenGraphImage image, string url = null)
            : base(title, image, url)
        {
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

            if (Actors != null)
            {
                foreach (var actor in Actors)
                {
                    stringBuilder.AppendMetaPropertyContentIfNotNull("video:actor", actor.ActorUrl);
                    stringBuilder.AppendMetaPropertyContentIfNotNull("video:actor:role", actor.Role);
                }
            }

            stringBuilder.AppendMetaPropertyContentIfNotNull("video:director", DirectorUrls);
            stringBuilder.AppendMetaPropertyContentIfNotNull("video:writer", WriterUrls);
            stringBuilder.AppendMetaPropertyContentIfNotNull("video:duration", Duration);
            stringBuilder.AppendMetaPropertyContentIfNotNull("video:release_date", ReleaseDate);
            stringBuilder.AppendMetaPropertyContentIfNotNull("video:tag", Tags);
            stringBuilder.AppendMetaPropertyContentIfNotNull("video:series", SeriesUrl);
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the actors in the episode.
        /// </summary>
        public IEnumerable<OpenGraphActor> Actors { get; set; }

        /// <summary>
        ///     Gets or sets the URL's to the pages about the directors. This URL's must contain profile meta tags
        ///     <see cref="OpenGraphProfile" />.
        /// </summary>
        public IEnumerable<string> DirectorUrls { get; set; }

        /// <summary>
        ///     Gets or sets the duration of the episode in seconds.
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        ///     Gets the namespace of this open graph type.
        /// </summary>
        public override string Namespace => "video: http://ogp.me/ns/video#";

        /// <summary>
        ///     Gets or sets the release date of the episode.
        /// </summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        ///     Gets or sets the URL to the page about the television series. This URL's must contain television show meta tags
        ///     <see cref="OpenGraphVideoTvShow" />.
        /// </summary>
        public string SeriesUrl { get; set; }

        /// <summary>
        ///     Gets or sets the tag words associated with the episode.
        /// </summary>
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        ///     Gets the type of your object. Depending on the type you specify, other properties may also be required.
        /// </summary>
        public override OpenGraphType Type => OpenGraphType.VideoEpisode;

        /// <summary>
        ///     Gets or sets the URL's to the pages about the writers. This URL's must contain profile meta tags
        ///     <see cref="OpenGraphProfile" />.
        /// </summary>
        public IEnumerable<string> WriterUrls { get; set; }

        #endregion
    }
}