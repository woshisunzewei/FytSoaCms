#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminToRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84cd61ea240f06d5ff43f01bfe5eacc07e8b3e7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_AdminToRole), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sys/AdminToRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sys/AdminToRole.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_AdminToRole), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sys
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84cd61ea240f06d5ff43f01bfe5eacc07e8b3e7d", @"/Pages/FytAdmin/Sys/AdminToRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sys_AdminToRole : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/ztree/css/metroStyle/metroStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminToRole.cshtml"
  
    ViewData["Title"] = "为用户分配角色";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(154, 707, true);
            WriteLiteral(@"<style>
    .layui-table-view {
        margin-top: 0px;
    }

    .layui-col-220 {
        width: 200px;
    }

    .right-col-body {
        left: 200px;
    }

    .list-wall {
        padding-top: 0px;
    }

    .fyt-center {
        text-align: center;
    }

    #tree {
        height: 350px;
        overflow: auto;
    }

    .layui-layer-loading {
        box-shadow: 0 0px 0px rgba(0,0,0,.3) !important;
    }
</style>
<div class=""layui-col-220"">
    <ul id=""tree"" class=""ztree layui-tree-cus""></ul>
</div>
<div class=""right-col-body"">
    <div class=""list-wall"">
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
</div>
");
            EndContext();
            BeginContext(861, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3c12f6388a034fa7be6c165642d4ab43", async() => {
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
            BeginContext(952, 490, true);
            WriteLiteral(@"
<script>
    layui.config({
        base: '/themes/js/modules/'
    }).use(['table', 'layer', 'jquery', 'ztree', 'common'],
        function () {
            var table = layui.table,
                layer = layui.layer,
                $ = layui.jquery,
                ztree = layui.ztree,
                os = layui.common,
                form = layui.form;
            table.render({
                elem: '#tablist',
                url: '/api/role/torolelist?adminGuid=");
            EndContext();
            BeginContext(1443, 16, false);
#line 59 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminToRole.cshtml"
                                                Write(Model.adminGuids);

#line default
#line hidden
            EndContext();
            BeginContext(1459, 1868, true);
            WriteLiteral(@"',
                cols: [
                    [
                        { type: 'checkbox', fixed: 'left' },
                        { field: 'name', title: '角色名称', fixed: 'left' },
                        { field: 'codes', title: '编号' },
                        { width: 100, title: '操作', templet: '#tool' }
                    ]
                ],
                page: true,
                id: 'tables'
            });
            var setting = {
                async: {
                    enable: true,
                    url: ""/api/organize/gettree""
                },
                callback: {
                    onClick: onClick
                }
            };
            var guid = '', typeName = '', active = {
                reload: function () {
                    table.reload('tables',
                        {
                            page: {
                                curr: 1
                            },
                            where: {
              ");
            WriteLiteral(@"                  key: guid
                            }
                        });
                }
            };
            $.fn.zTree.init($(""#tree""), setting);
            $('.list-search .layui-btn').on('click', function () {
                var type = $(this).data('type');
                active[type] ? active[type].call(this) : '';
            });
            function onClick(event, treeId, treeNode, clickFlag) {
                guid = treeNode.guid;
                active.reload();
            }
            //监听授权操作
            form.on('switch(torole)', function (obj) {
                var strRole = this.value;
                //开始提交信息
                var index = layer.load(1, {
                    shade: [0.1, '#fff']
                });
                os.ajax(""api/rolemenu/torole"", { AdminGuid: """);
            EndContext();
            BeginContext(3328, 16, false);
#line 109 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\AdminToRole.cshtml"
                                                        Write(Model.adminGuids);

#line default
#line hidden
            EndContext();
            BeginContext(3344, 770, true);
            WriteLiteral(@""", RoleGuid: strRole, Types: 2, status: obj.elem.checked }, function (res) {
                    layer.close(index);
                    if (res.statusCode === 200) {
                        if (obj.elem.checked) {
                            os.success('授权成功~');
                        }
                        else {
                            os.success('取消授权~');
                        }
                     } else {
                         os.error(res.message);
                     }
                });
            });
        });
</script>
<script type=""text/html"" id=""tool"">
    <input type=""checkbox"" name=""status"" value=""{{d.guid}}"" lay-skin=""switch"" lay-text=""取消|授权"" lay-filter=""torole"" {{ d.status ? 'checked' : '' }}>
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sys.AdminToRoleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.AdminToRoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.AdminToRoleModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sys.AdminToRoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
