# Zenima.TagHelpers library

This library provides additional [TagHelpers](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/intro) for [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core) that can be used to write cleaner code in Razor.

[![Build Status](https://dev.azure.com/zenima/Zenima.Helpers/_apis/build/status/Zenima.TagHelpers?branchName=master)](https://dev.azure.com/zenima/Zenima.Helpers/_build/latest?definitionId=30&branchName=master)
[![Zenima.TagHelpers package in Zenima.Helpers@Release feed in Azure Artifacts](https://feeds.dev.azure.com/zenima/_apis/public/Packaging/Feeds/edcdba04-7b15-47c2-9efc-917fd7a3f5cf%4088a8d40c-4f0f-4147-ba40-06e121c7fe9f/Packages/027e171d-4f5e-40c7-8a35-0760b9707ca0/Badge)](https://dev.azure.com/zenima/Zenima.Helpers/_packaging?_a=package&feed=edcdba04-7b15-47c2-9efc-917fd7a3f5cf%4088a8d40c-4f0f-4147-ba40-06e121c7fe9f&package=027e171d-4f5e-40c7-8a35-0760b9707ca0&preferRelease=true)
[![The MIT License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](http://opensource.org/licenses/MIT)

## Usage

You can install the TagHelpers using the following command.

```dotnetcli
dotnet add package Zenima.TagHelpers
```

To be able to use it in your Razor views, you have to reference it in the `_ViewImports.cshtml` file by adding the following line:

```cshtml
@addTagHelper *, Zenima.TagHelpers
```

## New TagHelpers

### DisplayTagHelper

Can be used on any existing tag.

| Attribute  | Functionality  |
|---|---|
|  `display` | Enable/disable tag visibility  |
|  `display-wrapper` | Enable/disable wrapper tag visibility  |

#### display

Example:

```cshtml
<div display="@User.LoggedIn()">
  <span>Welcome @User.Name</span>
</div>
```

#### display-wrapper

Example:

```cshtml
<a href="@item.Url" display-wrapper="@item.ShowLink">
  <span>@item.Name</span>
</a>
```
