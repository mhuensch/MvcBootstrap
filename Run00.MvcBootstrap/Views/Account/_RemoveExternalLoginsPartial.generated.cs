﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Run00.MvcBootstrap.Views.Account
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/_RemoveExternalLoginsPartial.cshtml")]
    public partial class RemoveExternalLoginsPartial : System.Web.Mvc.WebViewPage<ICollection<Run00.MvcBootstrap.Models.ExternalLogin>>
    {
        public RemoveExternalLoginsPartial()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
 if (Model.Count > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <h3>Registered external logins</h3>\r\n");

WriteLiteral("    <table>\r\n        <tbody>\r\n");

            
            #line 8 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
        
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
         foreach (Run00.MvcBootstrap.Models.ExternalLogin externalLogin in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");

            
            #line 11 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
               Write(externalLogin.ProviderDisplayName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>\r\n");

            
            #line 13 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                     if (ViewBag.ShowRemoveButton)
                    {
                        using (Html.BeginForm("Disassociate", "Account"))
                        {
                            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                                                    

            
            #line default
            #line hidden
WriteLiteral("                            <div>\r\n");

WriteLiteral("                                ");

            
            #line 19 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                           Write(Html.Hidden("provider", externalLogin.Provider));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 20 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                           Write(Html.Hidden("providerUserId", externalLogin.ProviderUserId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Remove\"");

WriteAttribute("title", Tuple.Create(" title=\"", 864), Tuple.Create("\"", 947)
, Tuple.Create(Tuple.Create("", 872), Tuple.Create("Remove", 872), true)
, Tuple.Create(Tuple.Create(" ", 878), Tuple.Create("this", 879), true)
            
            #line 21 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
       , Tuple.Create(Tuple.Create(" ", 883), Tuple.Create<System.Object, System.Int32>(externalLogin.ProviderDisplayName
            
            #line default
            #line hidden
, 884), false)
, Tuple.Create(Tuple.Create(" ", 918), Tuple.Create("credential", 919), true)
, Tuple.Create(Tuple.Create(" ", 929), Tuple.Create("from", 930), true)
, Tuple.Create(Tuple.Create(" ", 934), Tuple.Create("your", 935), true)
, Tuple.Create(Tuple.Create(" ", 939), Tuple.Create("account", 940), true)
);

WriteLiteral(" />\r\n                            </div>\r\n");

            
            #line 23 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                        }
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral(" &nbsp;\r\n");

            
            #line 28 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 31 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");

            
            #line 34 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
