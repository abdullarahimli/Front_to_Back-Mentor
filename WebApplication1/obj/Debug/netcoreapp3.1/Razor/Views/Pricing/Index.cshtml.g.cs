#pragma checksum "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d7a9babf3540996af1d1cf8e75b648b0800d6ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pricing_Index), @"mvc.1.0.view", @"/Views/Pricing/Index.cshtml")]
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
#line 2 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d7a9babf3540996af1d1cf8e75b648b0800d6ea", @"/Views/Pricing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d84b04bdf0e5ab555df43e3b8fe96c988c5c501", @"/Views/_ViewImports.cshtml")]
    public class Views_Pricing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PricingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ======= Breadcrumbs ======= -->
<div class=""breadcrumbs"" data-aos=""fade-in"">
    <div class=""container"">
        <h2>Pricing</h2>
        <p>Est dolorum ut non facere possimus quibusdam eligendi voluptatem. Quia id aut similique quia voluptas sit quaerat debitis. Rerum omnis ipsam aperiam consequatur laboriosam nemo harum praesentium. </p>
    </div>
</div><!-- End Breadcrumbs -->
<!-- ======= Pricing Section ======= -->
<section id=""pricing"" class=""pricing"">
    <div class=""container"" data-aos=""fade-up"">

        <div class=""row"">

");
#nullable restore
#line 19 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
             foreach (Pricing pricing in Model.Pricings)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 mt-4 mt-md-0\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 784, "\"", 834, 2);
            WriteAttributeValue("", 792, "box", 792, 3, true);
#nullable restore
#line 22 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
WriteAttributeValue(" ", 795, pricing.IsFeature ? "featured" : "", 796, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 23 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
                         if (pricing.IsUltimate == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"advanced\">Advanced</span>\r\n");
#nullable restore
#line 26 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>");
#nullable restore
#line 27 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
                       Write(pricing.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <h4><sup>$</sup>");
#nullable restore
#line 28 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
                                   Write(pricing.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> / month</span></h4>\r\n                        <ul>\r\n");
#nullable restore
#line 30 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
                             foreach (FeatureItems featureItems in Model.FeatureItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1332, "\"", 1457, 1);
#nullable restore
#line 32 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
WriteAttributeValue("", 1340, pricing.PricingFeatureItems.Any(f => f.FeatureItemsId == featureItems.Id) ? "" : "na text-decoration-line-through", 1340, 117, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 33 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
                               Write(featureItems.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 35 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                        <div class=\"btn-wrap\">\r\n                            <a href=\"#\" class=\"btn-buy\">Buy Now</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 43 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Mentor\WebApplication1\Views\Pricing\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</section><!-- End Pricing Section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PricingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591