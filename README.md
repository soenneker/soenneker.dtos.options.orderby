[![](https://img.shields.io/nuget/v/soenneker.dtos.options.orderby.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.options.orderby/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.options.orderby/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.options.orderby/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.options.orderby.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.options.orderby/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.options.orderby/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.options.orderby/actions/workflows/codeql.yml)

# Soenneker.Dtos.Options.OrderBy

Defines one field and direction used to order an API query result set.

## Install

```bash
dotnet add package Soenneker.Dtos.Options.OrderBy
```

## What you get

- `OrderByOption` — Defines one field and direction used to order an API query result set.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `OrderByOption.Field` | Serializable field name used for sorting; supported names are determined by the queried resource. | Serializable field name used for sorting; supported names are determined by the queried resource. |
| `OrderByOption.Direction` | Sort direction for the field; when omitted, the API applies its documented default direction. | Sort direction for the field; when omitted, the API applies its documented default direction. |
