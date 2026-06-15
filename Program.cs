using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using user_management_ef.Common;
using user_management_ef.Data;

var builder = WebApplication.CreateBuilder(args);

// 1) Controllers
builder.Services.AddControllers();

// 2) Entity Framework Core
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBUserManagementEF"));
});

// 3) Swagger UI (cài lại Swashbuckle vì .NET 9+ đã gỡ khỏi template)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 4) Trả lỗi validate (400) theo đúng cấu trúc ApiResponse thống nhất
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        var errors = context.ModelState
            .Where(e => e.Value is not null && e.Value.Errors.Count > 0)
            .ToDictionary(
                e => e.Key,
                e => e.Value!.Errors.Select(x => x.ErrorMessage).ToArray()
            );

        var response = new ApiResponse<object>(400, "Dữ liệu không hợp lệ", errors);
        return new BadRequestObjectResult(response);
    };
});

var app = builder.Build();

// 5) Bật Swagger UI ở môi trường Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();



