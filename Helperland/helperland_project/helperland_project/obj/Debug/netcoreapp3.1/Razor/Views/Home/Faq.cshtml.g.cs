#pragma checksum "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\Home\Faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "678e8694289452a2394e478853adb83fa317202c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Faq), @"mvc.1.0.view", @"/Views/Home/Faq.cshtml")]
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
#line 1 "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\_ViewImports.cshtml"
using helperland_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\_ViewImports.cshtml"
using helperland_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678e8694289452a2394e478853adb83fa317202c", @"/Views/Home/Faq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df425dc63dc6103c2fe5675393a852b16fa182f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Faq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\pci140\Desktop\Project\Helperland\helperland_project\helperland_project\Views\Home\Faq.cshtml"
  
    ViewData["Title"] = "Faq";
    Layout = "~/Views/Shared/publicpagelayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section class=""faq-banner-section"">
        <div class=""faq-img var-align hidden-xs"">
            <img src=""/images/faq-banner.png"" class=""responsive"">
        </div>
    </section>

    <section class=""faq-details"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-8"">
                    <div class="" text-center "">
                        <h2 class=""content-title"">FAQs</h2>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-12 d-flex justify-content-center align-items-center"">
                    <hr class=""line-hr"">
                    <img src=""/images/forma-1-copy-5.png"" class=""faq-separator mx-2""");
            BeginWriteAttribute("alt", " alt=\"", 892, "\"", 898, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <hr class=""line-hr"">
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-12 d-flex justify-content-center align-items-center text-center"">
                    <p class=""faq-para about-para"">
                        Whether you are Customer or Service provider, <br> We have tried our
                        best to solve all your queries and questions.
                    </p>
                </div>
            </div>
            <div class=""accordion-faq"">
                <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                    <li class=""nav-item"" role=""presentation"">
                        <button class=""nav-link active"" id=""forcustom"" data-bs-toggle=""tab""
                                data-bs-target=""#for-customer"" type=""button"" role=""tab"" aria-controls=""for-customer""
                                aria-selected=""true"">
                            For Customer
                        </button>");
            WriteLiteral(@"
                    </li>
                    <li class=""nav-item"" role=""presentation"">
                        <button class=""nav-link"" id=""forservice"" data-bs-toggle=""tab"" data-bs-target=""#for-service""
                                type=""button"" role=""tab"" aria-controls=""for-service"" aria-selected=""false"">
                            For Service
                            Provider
                        </button>
                    </li>
                </ul>
                <div class=""tab-content"" id=""myTabContent"">
                    <div class=""tab-pane fade show active"" id=""for-customer"" role=""tabpanel""
                         aria-labelledby=""forcustom"">

                        <div class=""accordion"" id=""accordionone"">
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                                    data-bs-target=""#fc-1"">
                                ");
            WriteLiteral("    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 2985, "\"", 2993, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Cusomer
                                </h2>
                                <div id=""fc-1"" class=""accordion-collapse collapse"" data-bs-parent=""#accordionone"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint odit dolor
                                            error eveniet, aspernatur molestias dignissimos itaque beatae maxime
                                            architecto unde illum?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                            ");
            WriteLiteral("        data-bs-target=\"#fc-2\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 4121, "\"", 4129, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Cusomer
                                </h2>
                                <div id=""fc-2"" class=""accordion-collapse collapse"" data-bs-parent=""#accordionone"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut quod, quisquam
                                            cupiditate culpa obcaecati expedita consequatur maiores, perferendis
                                            deleniti quidem quos corrupti?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                 ");
            WriteLiteral("                   data-bs-target=\"#fc-3\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 5268, "\"", 5276, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Cusomer
                                </h2>
                                <div id=""fc-3"" class=""accordion-collapse collapse"" data-bs-parent=""#accordionone"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut quod, quisquam
                                            cupiditate culpa obcaecati expedita consequatur maiores, perferendis
                                            deleniti quidem quos corrupti?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                 ");
            WriteLiteral("                   data-bs-target=\"#fc-4\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 6415, "\"", 6423, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Cusomer
                                </h2>
                                <div id=""fc-4"" class=""accordion-collapse collapse"" data-bs-parent=""#accordionone"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut quod, quisquam
                                            cupiditate culpa obcaecati expedita consequatur maiores, perferendis
                                            deleniti quidem quos corrupti?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                 ");
            WriteLiteral("                   data-bs-target=\"#fc-5\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 7562, "\"", 7570, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Cusomer
                                </h2>
                                <div id=""fc-5"" class=""accordion-collapse collapse"" data-bs-parent=""#accordionone"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut quod, quisquam
                                            cupiditate culpa obcaecati expedita consequatur maiores, perferendis
                                            deleniti quidem quos corrupti?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                 ");
            WriteLiteral("                   data-bs-target=\"#fc-6\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 8709, "\"", 8717, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Cusomer
                                </h2>
                                <div id=""fc-6"" class=""accordion-collapse collapse"" data-bs-parent=""#accordionone"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut quod, quisquam
                                            cupiditate culpa obcaecati expedita consequatur maiores, perferendis
                                            deleniti quidem quos corrupti?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                 ");
            WriteLiteral("                   data-bs-target=\"#fc-7\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 9856, "\"", 9864, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Cusomer
                                </h2>
                                <div id=""fc-7"" class=""accordion-collapse collapse"" data-bs-parent=""#accordionone"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut quod, quisquam
                                            cupiditate culpa obcaecati expedita consequatur maiores, perferendis
                                            deleniti quidem quos corrupti?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                 ");
            WriteLiteral("                   data-bs-target=\"#fc-8\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 11003, "\"", 11011, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Cusomer
                                </h2>
                                <div id=""fc-8"" class=""accordion-collapse collapse"" data-bs-parent=""#accordionone"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut quod, quisquam
                                            cupiditate culpa obcaecati expedita consequatur maiores, perferendis
                                            deleniti quidem quos corrupti?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                 ");
            WriteLiteral("                   data-bs-target=\"#fc-9\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 12150, "\"", 12158, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Cusomer
                                </h2>
                                <div id=""fc-9"" class=""accordion-collapse collapse"" data-bs-parent=""#accordionone"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut quod, quisquam
                                            cupiditate culpa obcaecati expedita consequatur maiores, perferendis
                                            deleniti quidem quos corrupti?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                 ");
            WriteLiteral("                   data-bs-target=\"#fc-10\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 13298, "\"", 13306, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Cusomer
                                </h2>
                                <div id=""fc-10"" class=""accordion-collapse collapse"" data-bs-parent=""#accordionone"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut quod, quisquam
                                            cupiditate culpa obcaecati expedita consequatur maiores, perferendis
                                            deleniti quidem quos corrupti?
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""for-service"" role=""tabpanel"" aria-labelledby=""forservice"">
               ");
            WriteLiteral(@"         <div class=""accordion"" id=""accordiontwo"">
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
                                    data-bs-target=""#fsp-1"">
                                    <img src=""/images/right-arrow.png""");
            BeginWriteAttribute("class", " class=\"", 14685, "\"", 14693, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Service Provider
                                </h2>
                                <div id=""fsp-1"" class=""accordion-collapse collapse"" data-bs-parent=""#accordiontwo"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum, dolor sit amet consectetur adipisicing elit. Suscipit aut
                                            blanditiis tenetur eveniet cum et fugit saepe optio tempore cupiditate.
                                            Eligendi, quibusdam ducimus.
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
           ");
            WriteLiteral("                         data-bs-target=\"#fsp-2\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 15839, "\"", 15847, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Service Provider
                                </h2>
                                <div id=""fsp-2"" class=""accordion-collapse collapse"" data-bs-parent=""#accordiontwo"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Maiores distinctio
                                            magnam inventore temporibus quae, neque error! Qui quos impedit mollitia
                                            aliquid officiis vel?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
           ");
            WriteLiteral("                         data-bs-target=\"#fsp-3\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 16993, "\"", 17001, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Service Provider
                                </h2>
                                <div id=""fsp-3"" class=""accordion-collapse collapse"" data-bs-parent=""#accordiontwo"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Maiores distinctio
                                            magnam inventore temporibus quae, neque error! Qui quos impedit mollitia
                                            aliquid officiis vel?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
           ");
            WriteLiteral("                         data-bs-target=\"#fsp-4\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 18147, "\"", 18155, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Service Provider
                                </h2>
                                <div id=""fsp-4"" class=""accordion-collapse collapse"" data-bs-parent=""#accordiontwo"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Maiores distinctio
                                            magnam inventore temporibus quae, neque error! Qui quos impedit mollitia
                                            aliquid officiis vel?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
           ");
            WriteLiteral("                         data-bs-target=\"#fsp-5\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 19301, "\"", 19309, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Service Provider
                                </h2>
                                <div id=""fsp-5"" class=""accordion-collapse collapse"" data-bs-parent=""#accordiontwo"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Maiores distinctio
                                            magnam inventore temporibus quae, neque error! Qui quos impedit mollitia
                                            aliquid officiis vel?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
           ");
            WriteLiteral("                         data-bs-target=\"#fsp-6\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 20455, "\"", 20463, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Service Provider
                                </h2>
                                <div id=""fsp-6"" class=""accordion-collapse collapse"" data-bs-parent=""#accordiontwo"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Maiores distinctio
                                            magnam inventore temporibus quae, neque error! Qui quos impedit mollitia
                                            aliquid officiis vel?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
           ");
            WriteLiteral("                         data-bs-target=\"#fsp-7\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 21609, "\"", 21617, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Service Provider
                                </h2>
                                <div id=""fsp-7"" class=""accordion-collapse collapse"" data-bs-parent=""#accordiontwo"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Maiores distinctio
                                            magnam inventore temporibus quae, neque error! Qui quos impedit mollitia
                                            aliquid officiis vel?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
           ");
            WriteLiteral("                         data-bs-target=\"#fsp-8\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 22763, "\"", 22771, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Service Provider
                                </h2>
                                <div id=""fsp-8"" class=""accordion-collapse collapse"" data-bs-parent=""#accordiontwo"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Maiores distinctio
                                            magnam inventore temporibus quae, neque error! Qui quos impedit mollitia
                                            aliquid officiis vel?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
           ");
            WriteLiteral("                         data-bs-target=\"#fsp-9\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 23917, "\"", 23925, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Service Provider
                                </h2>
                                <div id=""fsp-9"" class=""accordion-collapse collapse"" data-bs-parent=""#accordiontwo"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Maiores distinctio
                                            magnam inventore temporibus quae, neque error! Qui quos impedit mollitia
                                            aliquid officiis vel?
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class=""accordion_item"">
                                <h2 class=""accordion-header accordion_btn collapsed"" data-bs-toggle=""collapse""
           ");
            WriteLiteral("                         data-bs-target=\"#fsp-10\">\r\n                                    <img src=\"/images/right-arrow.png\"");
            BeginWriteAttribute("class", " class=\"", 25072, "\"", 25080, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""right-arrow"">
                                    Lorem ipsum dolor sit amet. Service Provider
                                </h2>
                                <div id=""fsp-10"" class=""accordion-collapse collapse"" data-bs-parent=""#accordiontwo"">
                                    <div class=""accordion-body"">
                                        <p>
                                            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Maiores distinctio
                                            magnam inventore temporibus quae, neque error! Qui quos impedit mollitia
                                            aliquid officiis vel?
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class=""our-news-letter our-ne");
            WriteLiteral(@"ws-letter-bg"">
        <div class=""container text-center"">
            <a href=""#"" class=""scroll-top""><img src=""/images/up-arrow.png"" alt=""up-arrow""></a>
            <a href=""#"" class=""message-boat""><img src=""/images/message-boat.png"" alt=""message-boat""></a>
            <h2>GET OUR NEWSLETTER</h2>
            <div class=""form-row d-flex justify-content-center align-items-center"">
                <div class=""form-group"">
                    <label for=""email"" style=""display: none;"">YOUR EMAIL</label>
                    <input type=""text"" placeholder=""YOUR EMAIL"" id=""email"" class=""form-control"">
                </div>
                <div class=""btn-wrapper"">
                    <button class=""red-btn"">Submit</button>
                </div>
            </div>
        </div>
    </section>

</main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591