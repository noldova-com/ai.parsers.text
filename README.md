# Noldova.AI.Parsers.Text  

This repository contains the text parser for NoldovaAI

This package is part of NoldovaAI. Use it separately only if you want to parse a given text into a list of unique names.

[![Latest Version](https://img.shields.io/nuget/v/Noldova.AI.Parsers.Text)](https://www.nuget.org/packages/Noldova.AI.Parsers.Text) [![Preview Version](https://img.shields.io/nuget/vpre/Noldova.AI.Parsers.Text)](https://www.nuget.org/packages/Noldova.AI.Parsers.Text/absoluteLatest) [![Downloads](https://img.shields.io/nuget/dt/Noldova.AI.Parsers.Text)](https://www.nuget.org/packages/Noldova.AI.Parsers.Text)


### Installation

Noldova.AI.Parsers.Text is available on [NuGet](https://www.nuget.org/packages/noldova.ai.parsers.text): 

```sh
dotnet add package Noldova.AI.Parsers.Text
```
Use the `--version` option to specify a [preview version](https://www.nuget.org/packages/noldova.ai.parsers.text/absoluteLatest) to install.

### How to use

The following code demonstrates the usage of Noldova.AI.Parsers.Text.

```cs
using Noldova.AI.Parsers.Text;

var parser = new Parser("Hello World");
var result = textParser.Parse();
```

The Parse() method will return a sorted array of unique values:

| Index  | Value        |
| ------ | ------------ |
| 0      | (whitespace) |
| 1      | d            |
| 2      | e            |
| 3      | H            |
| 4      | Hello        |
| 5      | l            |
| 6      | o            |
| 7      | r            |
| 8      | W            |
| 9      | World        |