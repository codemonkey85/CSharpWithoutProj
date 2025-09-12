#!/usr/bin/env dotnet run
#:property LangVersion=preview

var name = args.Length > 0 ? args[0] : "world";

Console.WriteLine($"Hello, {name}!");
