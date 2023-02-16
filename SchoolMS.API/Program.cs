using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolMS.Core.Data;
using SchoolMS.Core.Repository.Repositories.Implement;
using SchoolMS.Core.Repository.Repositories.Interfaces;
using SchoolMS.Core.Repository.UnitOfWork;
using SchoolMS.Core.Services;
using SchoolMS.Core.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// AutoMapper
builder.Services.AddAutoMapper(typeof(Program));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// add newton
builder.Services.AddControllers().AddNewtonsoftJson(op =>
op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
//mediatR
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

// add lifecircle
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IClassInforRepository, ClassRepository>();
builder.Services.AddScoped<IClassService, ClassService>();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();

//identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
//db
builder.Services.AddDbContext<AppDbContext>(c=>c.UseSqlServer(builder.Configuration.GetConnectionString("SchoolMSConnStr")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
