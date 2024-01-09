using RasuliEEndpoints.Services;
using RasuliEEndpoints.Services.Questions;
using RasuliEEndpoints.Services.Sums;
using RasuliEEndpoints.Services.Sums.Results;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IQuestionsService, QuestionService>();
builder.Services.AddScoped<IResultsService, ResultsService>();
builder.Services.AddScoped<ISumService, SumsService>();

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
