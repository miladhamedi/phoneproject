#pragma checksum "E:\PhoneBookApp\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2e238718afdfdadca8f1ba9b0cb9a287a330ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagContact_ListPhoneContact), @"mvc.1.0.view", @"/Views/ManagContact/ListPhoneContact.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\PhoneBookApp\PhoneBookApp\Views\_ViewImports.cshtml"
using PhoneBookApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PhoneBookApp\PhoneBookApp\Views\_ViewImports.cshtml"
using PhoneBookApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\PhoneBookApp\PhoneBookApp\Views\_ViewImports.cshtml"
using PhoneBookApp.Domains;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e238718afdfdadca8f1ba9b0cb9a287a330ca6", @"/Views/ManagContact/ListPhoneContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a58705dde5cc3c9cce663aed6ec9ee60ca9254", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagContact_ListPhoneContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PhoneContact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\PhoneBookApp\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
  
    ViewData["Title"] = "  لیست شماره تماس  ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">شماره موبایل</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "E:\PhoneBookApp\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 21 "E:\PhoneBookApp\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
               Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n                <td>\r\n\r\n                    <a onclick=\"return confirm( \'ایا مایل ب حذف شماره تلفن هستید؟\')\"");
            BeginWriteAttribute("href", " href=\"", 895, "\"", 963, 2);
            WriteAttributeValue("", 902, "/ManagContact/DeletePhone?phonecontactid=", 902, 41, true);
#nullable restore
#line 43 "E:\PhoneBookApp\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
WriteAttributeValue("", 943, item.PhoneContactId, 943, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\"> حذف شماره تلفن</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1038, "\"", 1106, 2);
            WriteAttributeValue("", 1045, "/ManagContact/UpdatePhone?phonecontactid=", 1045, 41, true);
#nullable restore
#line 44 "E:\PhoneBookApp\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
WriteAttributeValue("", 1086, item.PhoneContactId, 1086, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">ویرایش شماره تلفن</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1184, "\"", 1248, 2);
            WriteAttributeValue("", 1191, "/ManagContact/CreatePhoneNumber?contactid=", 1191, 42, true);
#nullable restore
#line 45 "E:\PhoneBookApp\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
WriteAttributeValue("", 1233, item.ContactId, 1233, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">افزودن شماره تلفن</a>\r\n\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 50 "E:\PhoneBookApp\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PhoneContact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
