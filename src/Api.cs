#!/usr/bin/env dotnet run
#:sdk Microsoft.NET.Sdk.Web

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var name = args.Length > 0 ? args[0] : "world";

app.MapGet("/", () => $"Hello, {name}!");
app.MapGet("/{message}", (string message) => $"Hello, {message}");

app.Run();
