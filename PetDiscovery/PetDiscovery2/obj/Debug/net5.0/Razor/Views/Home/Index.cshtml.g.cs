#pragma checksum "C:\Users\eltia\Desktop\PetFinder\PetFinder\PetDiscovery\PetDiscovery2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb3bb656efd95e4130d83e627837afba7f4138d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\eltia\Desktop\PetFinder\PetFinder\PetDiscovery\PetDiscovery2\Views\_ViewImports.cshtml"
using PetDiscovery2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eltia\Desktop\PetFinder\PetFinder\PetDiscovery\PetDiscovery2\Views\_ViewImports.cshtml"
using PetDiscovery2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb3bb656efd95e4130d83e627837afba7f4138d0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8647142f71e526405fd53787b4c0da44b7ac3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PetDiscovery.Model.LogedUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\eltia\Desktop\PetFinder\PetFinder\PetDiscovery\PetDiscovery2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bem Vindo!</h1>\r\n    <p>teste ");
#nullable restore
#line 9 "C:\Users\eltia\Desktop\PetFinder\PetFinder\PetDiscovery\PetDiscovery2\Views\Home\Index.cshtml"
        Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@".</p>

    <div class=""row"">
        <div class=""col-md-4"">
            <h2>Perdeu Seu Pet?</h2>
            <p>
                Se voc?? perdeu seu Pet, fique calmo e deixa com a gente, clique no bot??o abaixo, insira os dados do cadastro e deixe com o nosso algoritimo!
            </p>
            <p><a class=""btn btn-default"" href=""/Customer/"">Acesse aqui &raquo;</a></p>
        </div>
        <div class=""col-md-4"">
            <h2>Encontrou um Pet?</h2>
            <p>Se voc?? encontrou algum Pet n??o tem problema, clique no bot??o abaixo, cadastre o Pet no nosso sistema e deixe que nosso algoritimo encontre o seu dono!</p>
            <p><a class=""btn btn-default"" href=""/Customer/Index"">Learn more &raquo;</a></p>
        </div>
        <div class=""col-md-4"">
            <h2>Consulte Aqui seus Pet??s cadastrados!</h2>
            <p>Caso voc?? queira ver seus Pet??s cadastrados clique no bot??o abaixo e confira!</p>
            <p><a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?");
            WriteLiteral("LinkId=301867\">Learn more &raquo;</a></p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetDiscovery.Model.LogedUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
