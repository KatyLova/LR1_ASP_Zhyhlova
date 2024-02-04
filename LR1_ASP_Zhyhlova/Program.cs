using LR1_ASP_Zhyhlova;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var company = new Company
{
    Name = "Ameno",
    YearFounded = 2024,
    Location = "Mykolaiv",
    EmployeeCount = 108,
};

app.MapGet("/", () =>
{
    string companyInfo = $"Company name: {company.Name}\nFounded in: {company.YearFounded}\nLocation: {company.Location}\nEmployees: {company.EmployeeCount}";
    string randomInfo = $"Random Number: {new Random().Next(0, 101)}";

    return $"{companyInfo}\n{randomInfo}";
});

app.Run();