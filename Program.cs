using Microsoft.EntityFrameworkCore;
using OnlineCV.Data;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Configure Database Context
builder.Services.AddDbContext<CVContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// 🔹 Add MVC Controllers & Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 🔹 Ensure Database is Created & Migrated
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<CVContext>();

    context.Database.Migrate(); // Apply any pending migrations
}

// 🔹 Configure HTTP Request Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// 🔹 Configure Default Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


app.Run();
