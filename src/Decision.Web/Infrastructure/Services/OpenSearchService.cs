﻿using System.Text;
using System.Web.Mvc;
using System.Xml.Linq;
using Decision.Framework.Extensions;
using Decision.Framework.MvcToolkit.Extensions;
using Decision.Web.Infrastructure.Services.Contracts;

namespace Decision.Web.Infrastructure.Services
{
    public sealed class OpenSearchService : IOpenSearchService
    {
        private readonly UrlHelper urlHelper;

        public OpenSearchService(UrlHelper urlHelper)
        {
            this.urlHelper = urlHelper;
        }

        /// <summary>
        ///     Gets the Open Search XML for the current site. You can customize the contents of this XML here. See
        ///     http://www.hanselman.com/blog/CommentView.aspx?guid=50cc95b1-c043-451f-9bc2-696dc564766d
        ///     http://www.opensearch.org
        /// </summary>
        /// <returns>The Open Search XML for the current site.</returns>
        public string GetOpenSearchXml()
        {
            // Short name must be less than or equal to 16 characters.
            const string shortName = "Search";
            var description = "Search the ASP.NET MVC Boilerplate Site";
            // The link to the search page with the query string set to 'searchTerms' which gets replaced with a user 
            // defined query.
            var searchUrl = urlHelper.AbsoluteAction(
                MVC.Home.ActionNames.Search, MVC.Home.Name,
                new {query = "{searchTerms}"});
            // The link to the page with the search form on it. The home page has the search form on it.
            var searchFormUrl = urlHelper.ActionAbsolute(MVC.Home.Index());
            // The link to the favicon.ico file for the site.
            var favicon16Url = UrlHelperExtensions.AbsoluteContent(urlHelper, "~/Content/icons/favicon.ico");
            // The link to the favicon.png file for the site.
            var favicon32Url = UrlHelperExtensions.AbsoluteContent(urlHelper, "~/Content/icons/favicon-32x32.png");
            // The link to the favicon.png file for the site.
            var favicon96Url = UrlHelperExtensions.AbsoluteContent(urlHelper, "~/Content/icons/favicon-96x96.png");

            XNamespace ns = "http://a9.com/-/spec/opensearch/1.1";
            var document = new XDocument(
                new XElement(
                    ns + "OpenSearchDescription",
                    new XElement(ns + "ShortName", shortName),
                    new XElement(ns + "Description", description),
                    new XElement(
                        ns + "Url",
                        new XAttribute("type", "text/html"),
                        new XAttribute("method", "get"),
                        new XAttribute("template", searchUrl)),
                    // Search results can also be returned as RSS. Here, our start index is zero for the first result.
                    // new XElement(ns + "Url",
                    //     new XAttribute("type", "application/rss+xml"),
                    //     new XAttribute("indexOffset", "0"),
                    //     new XAttribute("rel", "results"),
                    //     new XAttribute("template", "http://example.com/?q={searchTerms}&amp;start={startIndex?}&amp;format=rss")),
                    // Search suggestions can also be returned as JSON.
                    // new XElement(ns + "Url",
                    //     new XAttribute("type", "application/json"),
                    //     new XAttribute("indexOffset", "0"),
                    //     new XAttribute("rel", "suggestions"),
                    //     new XAttribute("template", "http://example.com/suggest?q={searchTerms}")),
                    new XElement(
                        ns + "Image",
                        favicon16Url,
                        new XAttribute("height", "16"),
                        new XAttribute("width", "16"),
                        new XAttribute("type", "image/x-icon")),
                    new XElement(
                        ns + "Image",
                        favicon32Url,
                        new XAttribute("height", "32"),
                        new XAttribute("width", "32"),
                        new XAttribute("type", "image/png")),
                    new XElement(
                        ns + "Image",
                        favicon96Url,
                        new XAttribute("height", "96"),
                        new XAttribute("width", "96"),
                        new XAttribute("type", "image/png")),
                    new XElement(ns + "InputEncoding", "UTF-8"),
                    new XElement(ns + "SearchForm", searchFormUrl)));

            return document.ToString(Encoding.UTF8);
        }
    }
}