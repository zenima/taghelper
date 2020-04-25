# Zenima.TagHelpers library

This library provides additional [TagHelpers](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/intro) for [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core) that can be used to write cleaner code in Razor.

![GitHub tag (latest SemVer)](https://img.shields.io/github/v/tag/zenima/taghelpers?sort=semver&style=flat-square)
![GitHub](https://img.shields.io/github/license/zenima/taghelpers?style=flat-square)

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
