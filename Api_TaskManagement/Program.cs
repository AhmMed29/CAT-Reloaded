using Api_TaskManagement.Controllers;

var builder = WebApplication.CreateBuilder(args);

// بنضيف الخدمات الأساسية بس
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

// تشغيل الكنترولرز
app.MapControllers();
app.Run();