#pragma checksum "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdb3d71f55df19104aba299d93cfe80a7a9dcc1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_RestaurantsList), @"mvc.1.0.view", @"/Views/Restaurants/RestaurantsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/RestaurantsList.cshtml", typeof(AspNetCore.Views_Restaurants_RestaurantsList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdb3d71f55df19104aba299d93cfe80a7a9dcc1d", @"/Views/Restaurants/RestaurantsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147cf64a10d930d7b39a7e34c1c186443ec87a1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurants_RestaurantsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"ru\">\r\n");
            EndContext();
            BeginContext(37, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdb3d71f55df19104aba299d93cfe80a7a9dcc1d5143", async() => {
                BeginContext(43, 132, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width initial-scale=1, shrink-to-fit=no\">\r\n    <title>");
                EndContext();
                BeginContext(176, 13, false);
#line 7 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(189, 14, true);
                WriteLiteral("</title>\r\n    ");
                EndContext();
                BeginContext(203, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cdb3d71f55df19104aba299d93cfe80a7a9dcc1d6038", async() => {
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
                BeginContext(275, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(281, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cdb3d71f55df19104aba299d93cfe80a7a9dcc1d7457", async() => {
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
                BeginContext(345, 2, true);
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
            BeginContext(354, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(358, 2401, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdb3d71f55df19104aba299d93cfe80a7a9dcc1d9677", async() => {
                BeginContext(364, 75, true);
                WriteLiteral("\r\n\r\n    <section class=\"restaurant-list\">\r\n        <h2 class=\"block-title\">");
                EndContext();
                BeginContext(440, 18, false);
#line 15 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
                           Write(Model.FoodCategory);

#line default
#line hidden
                EndContext();
                BeginContext(458, 7, true);
                WriteLiteral("</h2>\r\n");
                EndContext();
#line 16 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
          
            if (@Model.FoodCategory == "Все рестораны")
            {

#line default
#line hidden
                BeginContext(549, 145, true);
                WriteLiteral("                <p class=\"text-center black\">\r\n                    <span>У нас</span> действительно есть из чего выбрать!\r\n                </p>\r\n");
                EndContext();
#line 22 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
            }
            else if (@Model.FoodCategory == "Суши")
            {

#line default
#line hidden
                BeginContext(777, 131, true);
                WriteLiteral("                <p class=\"text-center black\">\r\n                    <span>СУШИ</span> - прямиком из Японии! \r\n                </p>\r\n");
                EndContext();
#line 28 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
            }
            else if (@Model.FoodCategory == "Пицца")
            {

#line default
#line hidden
                BeginContext(992, 136, true);
                WriteLiteral("                <p class=\"text-center black\">\r\n                    <span>ПИЦЦА</span> - мать итальянской кухни! \r\n                </p>\r\n");
                EndContext();
#line 34 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
            }
            else if (@Model.FoodCategory == "Бургеры")
            {

#line default
#line hidden
                BeginContext(1214, 147, true);
                WriteLiteral("                <p class=\"text-center black\">\r\n                    <span>БУРГЕРЫ</span> - американская классика ждёт тебя! \r\n                </p>\r\n");
                EndContext();
#line 40 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
            }
            else if (@Model.FoodCategory == "Другое")
            {

#line default
#line hidden
                BeginContext(1446, 138, true);
                WriteLiteral("                <p class=\"text-center black\">\r\n                    <span>Здесь</span> ты точно найдешь, что искал!\r\n                </p>\r\n");
                EndContext();
#line 46 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
            }
        

#line default
#line hidden
                BeginContext(1610, 37, true);
                WriteLiteral("        <div class=\"row mt-5 mb-2\">\r\n");
                EndContext();
#line 49 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
              
                foreach (Restaurant rest in Model.AllRestaurants)
                {
                    

#line default
#line hidden
                BeginContext(1770, 36, false);
#line 52 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
               Write(Html.Partial("AllRestaurants", rest));

#line default
#line hidden
                EndContext();
#line 52 "E:\Дипломный проект МКП 2021\FoodDelivery\FoodDelivery\Views\Restaurants\RestaurantsList.cshtml"
                                                         
                }
            

#line default
#line hidden
                BeginContext(1842, 910, true);
                WriteLiteral(@"        </div>
    </section>

    <section class=""footer"" id=""footer"">
        <div class=""phone-contact"" style=""margin-top: 55px"">
            <a href=""tel:+375447473028"">+375 44 747 30 28</a>
            <p class=""text-phone"" style=""font-size: 20px""><span>Иногда бывает сложно</span> определиться с выбором - звони и мы поможем!</p>
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
            BeginContext(2759, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591