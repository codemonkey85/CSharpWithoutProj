#!/usr/bin/env dotnet run

var name = args.Length > 0 ? args[0] : "world";

Console.WriteLine($"Hello, {name}!");
