#!/usr/bin/env dotnet run
#:property LangVersion preview

#:property UseWindowsForms true
#:property TargetFramework net10.0-windows
#:property OutputType WinExe

var name = args.Length > 0 ? args[0] : "world";

Application.Run(
    new Form
    {
        Text = $"Hello, {name}!",
        Width = 800,
        Height = 600,
        StartPosition = FormStartPosition.CenterScreen
    }
);
