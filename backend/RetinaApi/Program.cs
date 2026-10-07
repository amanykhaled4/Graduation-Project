var builder = WebApplication.CreateBuilder(args);

// ===== الخدمات (Services) =====

builder.Services.AddControllers();

// Swagger: صفحة بتعرض كل الـ APIs وتقدري تجربيها من المتصفح
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS: بيسمح لصفحات الداشبورد (Live Server على بورت 5500) تكلم الـ API
builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
        policy.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500")
              .AllowAnyHeader()
              .AllowAnyMethod());
});

var app = builder.Build();

// ===== ترتيب تشغيل الطلبات (Pipeline) =====

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Frontend");

app.UseAuthorization();

app.MapControllers();

app.Run();
