Developing Microservice with ASP.NET Core 6.0
C# language version 10.0

#Installed package:
    1. Microsoft.EntityFrameworkCore (Version 6.0.4)
    2. Microsoft.EntityFrameworkCore.SqlServer (Version 6.0.4)
    3. Microsoft.EntityFrameworkCore.Design (Version 6.0.4)

#Install dotnet entity framework
    .Net CLI(for Local)
        >dotnet new tool-manifest # if you are setting up this repo
        >dotnet tool install --local dotnet-ef --version 6.0.4

    .Net CLI(for Global)**
        >dotnet tool install --global dotnet-ef --version 6.0.4

#Can invoke the tool using the following command: >dotnet-ef

#To Add migration
    >dotnet ef database update
    >dotnet ef migrations add initialDb
    >dotnet ef database update