using MiniDemo.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//app.MapGet("/employee", (Func<Employee>)(() =>
//{
//    return new Employee()
//    {
//        EmployeeId = "1",
//        Name = "Faizul",
//        Sitizenship = "Bangladesh"
//    };
//}));

app.MapGet("/employee", (Func<List<Employee>>)(() =>
    {
        return new EmployeeCollection().GetEmployees();
    }
));

app.MapGet("/employee/{id}", async (http) =>
{
    if (!http.Request.RouteValues.TryGetValue("id", out var id))
    {
        http.Response.StatusCode = 400;
        return;
    }
    else
    {
        await http.Response.WriteAsJsonAsync(new EmployeeCollection()
                .GetEmployees()
                .FirstOrDefault(x => x.EmployeeId == (string)id)
            );
    }
});

app.Run();
