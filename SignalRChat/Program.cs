using SignalRChat.Hubs;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();

//**依賴項注入
builder.Services.AddSignalR();

var app = builder.Build();
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI(
        options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            options.RoutePrefix = "swagger";
        }
    );    
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()){
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles();

    app.UseHsts();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

//**配置路由
app.MapHub<ChatHub>("/chatHub");
app.MapControllers();
app.Run();


