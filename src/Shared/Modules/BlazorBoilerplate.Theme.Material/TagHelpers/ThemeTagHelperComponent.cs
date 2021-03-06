﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Theme.Material.TagHelpers
{
    public class ThemeTagHelperComponent : TagHelperComponent
    {
        public override int Order => 1;
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var path = typeof(Module).Namespace;

            if (string.Equals(context.TagName, "head", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml(@$"
<link rel=""shortcut icon"" type=""image/x-icon"" href=""_content/{path}/images/favicon.ico"">
<link rel=""icon"" type=""image/x-icon"" href=""_content/{path}/images/favicon.ico"">
<link href=""https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" />
<link href=""_content/{path}/css/bootstrap/bootstrap.min.css"" rel=""stylesheet"" />
<link href=""_content/MatBlazor/dist/matBlazor.css"" rel=""stylesheet"" />
<link href=""_content/{path}/css/site.css"" rel=""stylesheet"" />");
            }
            else if (string.Equals(context.TagName, "body", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml(@$"
<script src=""_content/MatBlazor/dist/matBlazor.js""></script>");
            }

            return Task.CompletedTask;
        }
    }
}
