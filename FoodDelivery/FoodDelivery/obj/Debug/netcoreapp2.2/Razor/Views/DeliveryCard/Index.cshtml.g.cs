#pragma checksum "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "186e946793781234183afdc37e6f72d059407e2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeliveryCard_Index), @"mvc.1.0.view", @"/Views/DeliveryCard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DeliveryCard/Index.cshtml", typeof(AspNetCore.Views_DeliveryCard_Index))]
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
#line 1 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\_ViewImports.cshtml"
using FoodDelivery.ViewModels;

#line default
#line hidden
#line 2 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\_ViewImports.cshtml"
using FoodDelivery.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186e946793781234183afdc37e6f72d059407e2e", @"/Views/DeliveryCard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147cf64a10d930d7b39a7e34c1c186443ec87a1a", @"/Views/_ViewImports.cshtml")]
    public class Views_DeliveryCard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliveryCardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 20, true);
            WriteLiteral("\r\n<html lang=\"ru\">\r\n");
            EndContext();
            BeginContext(50, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "186e946793781234183afdc37e6f72d059407e2e5815", async() => {
                BeginContext(56, 132, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width initial-scale=1, shrink-to-fit=no\">\r\n    <title>");
                EndContext();
                BeginContext(189, 13, false);
#line 7 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(202, 14, true);
                WriteLiteral("</title>\r\n    ");
                EndContext();
                BeginContext(216, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "186e946793781234183afdc37e6f72d059407e2e6701", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(288, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(294, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "186e946793781234183afdc37e6f72d059407e2e8120", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(358, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(367, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(371, 2868, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "186e946793781234183afdc37e6f72d059407e2e10340", async() => {
                BeginContext(377, 85, true);
                WriteLiteral("\r\n    <section class=\"delivery-card\">\r\n        <h2 class=\"block-title\">Корзина</h2>\r\n");
                EndContext();
#line 15 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
           if (Model.deliveryCard.listDeliveryItems.Count <= 0)
            {

#line default
#line hidden
                BeginContext(542, 316, true);
                WriteLiteral(@"                <p class=""text-center black"">
                    <span>В Вашей</span> корзине отсутствуют товары!
                </p>
                <div class=""row mt-5 mb-2"">
                    <img src=""../img/Icons/cart.png"" alt=""cart"" style=""margin:auto; padding-top: 20px;"" />
                </div>
");
                EndContext();
#line 23 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(906, 46, true);
                WriteLiteral("                <div class=\"container mt-5\">\r\n");
                EndContext();
#line 27 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
                      int allprice = 0;
                        foreach (var el in Model.deliveryCard.listDeliveryItems)
                        {
                            {
                                allprice = allprice + @el.dish.price;
                            }

#line default
#line hidden
                BeginContext(1235, 176, true);
                WriteLiteral("                            <div class=\"alert alert-warning\" style=\"background-color: #fcf693; padding-bottom: 30px;\">\r\n                                <img class=\"order-image\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1411, "\"", 1429, 1);
#line 34 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
WriteAttributeValue("", 1417, el.dish.img, 1417, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1430, 133, true);
                WriteLiteral(">\r\n                                <div class=\"order-desc\">\r\n                                    <p><b>Наименование:</b> <span-black>");
                EndContext();
                BeginContext(1564, 12, false);
#line 36 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
                                                                   Write(el.dish.name);

#line default
#line hidden
                EndContext();
                BeginContext(1576, 70, true);
                WriteLiteral("</span-black></p>\r\n                                    <p><b>Вес:</b> ");
                EndContext();
                BeginContext(1647, 14, false);
#line 37 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
                                              Write(el.dish.weight);

#line default
#line hidden
                EndContext();
                BeginContext(1661, 73, true);
                WriteLiteral(" гр.<br /><p>\r\n                                    <p><b>Цена:</b> <span>");
                EndContext();
                BeginContext(1735, 13, false);
#line 38 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
                                                     Write(el.dish.price);

#line default
#line hidden
                EndContext();
                BeginContext(1748, 93, true);
                WriteLiteral(" руб.</span><p>\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 41 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1868, 172, true);
                WriteLiteral("                        <hr />\r\n                        <b class=\"order-price\" style=\"font-size: 20px; font-family: MontserratBold, sans-serif;\">Сумма заказа: &ensp; <span>");
                EndContext();
                BeginContext(2041, 8, false);
#line 43 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
                                                                                                                                       Write(allprice);

#line default
#line hidden
                EndContext();
                BeginContext(2049, 141, true);
                WriteLiteral(" руб.</span></b> <br />\r\n                        <button class=\"main-btn\" style=\"font-family: MontserratBold, sans-serif; margin-top: 20px\"> ");
                EndContext();
                BeginContext(2190, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "186e946793781234183afdc37e6f72d059407e2e15594", async() => {
                    BeginContext(2238, 8, true);
                    WriteLiteral("Оформить");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2250, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
                BeginContext(2284, 24, true);
                WriteLiteral("                </div>\r\n");
                EndContext();
#line 47 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\DeliveryCard\Index.cshtml"
            }
        

#line default
#line hidden
                BeginContext(2334, 898, true);
                WriteLiteral(@"    </section>

    <section class=""footer"" id=""footer"">
        <div class=""phone-contact"" style=""margin-top: 55px"">
            <a href=""tel:+375447473028"">+375 44 747 30 28</a>
            <p class=""text-phone"" style=""font-size: 20px""><span>Проблемы с добавлением в корзину?</span> - звони, мы всегда готовы помочь!</p>
        </div>
    </section>

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""a.nav-link"").click(function () {
                $(""html, body"").animate({
                    scrollTop: $($(this).attr(""href"")).offset().top + ""px""
                }, {
                    duration: 1000,
                    easing: ""swing""
                });
                return false;
            });
        });
    </script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3239, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryCardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
