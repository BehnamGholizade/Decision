﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Decision.Web.Views.Applicant
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Decision.Framework.HtmlHelpers;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Applicant/_ListAjax.cshtml")]
    public partial class _ListAjax : System.Web.Mvc.WebViewPage<Decision.ViewModel.Applicant.ApplicantListViewModel>
    {
        public _ListAjax()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\Applicant\_ListAjax.cshtml"
 foreach (var Applicant in Model.Applicants)
{
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Applicant\_ListAjax.cshtml"
Write(Html.Partial(MVC.Applicant.Views._ApplicantItem, Applicant));

            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Applicant\_ListAjax.cshtml"
                                                                
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
