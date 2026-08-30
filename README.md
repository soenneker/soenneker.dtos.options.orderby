[![](https://img.shields.io/nuget/v/soenneker.dtos.options.orderby.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.options.orderby/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.options.orderby/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.options.orderby/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.options.orderby.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.options.orderby/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.options.orderby/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.options.orderby/actions/workflows/codeql.yml)

# Soenneker.Dtos.Options.OrderBy

A transport model for expressing a single sort field and optional direction in an API request.

## Install

```bash
dotnet add package Soenneker.Dtos.Options.OrderBy
```

## Usage

```csharp
using Soenneker.Dtos.Options.OrderBy;
using Soenneker.Enums.SortDirections;

var orderBy = new OrderByOption
{
    Field = "createdAt",
    Direction = SortDirection.Desc
};
```

The JSON property names are `field` and `direction` with both `System.Text.Json` and Newtonsoft.Json. `Field` is required during object initialization. `Direction` accepts `SortDirection.Asc`, `SortDirection.Desc`, or `null` when the receiving API should choose its default.

This DTO does not verify that a field is sortable. If `Field` comes from an untrusted request, map it through an allow-list before using it to build SQL, expressions, or provider-specific query text; do not pass the string directly into a query engine.
