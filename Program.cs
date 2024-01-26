using RasuliEEndpoints.Services;
using RasuliEEndpoints.Services.Questions;
using RasuliEEndpoints.Services.SayHello;
using RasuliEEndpoints.Services.Sums;
using RasuliEEndpoints.Services.Sums.Results;
using RasuliEEndpointsD2.Controllers;
using RasuliEEndpointsD2.Services;
using RasuliEEndpointsD2.Services.Madlib;
using RasuliEEndpointsD2.Services.OddOrEven;
using RasuliEEndpointsD2.Services.ReverseNum;
using RasuliEEndpointsD2.Services.ReverseString;
using RasuliEEndpointsD3.Services.MagicBall;
using RasuliEEndpointsD3.Services.Restauraunt;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IQuestionsService, QuestionService>();
builder.Services.AddScoped<IResultsService, ResultsService>();
builder.Services.AddScoped<ISumService, SumsService>();
builder.Services.AddScoped<IMadlibService, MadlibService>();
builder.Services.AddScoped<IOddEvenService, OddEvenService>();
builder.Services.AddScoped<iSayHelloService, SayHelloService>();
builder.Services.AddScoped<IReverseNumService, ReverseNumService>();
builder.Services.AddScoped<IReverseStringService, ReverseStringService>();
builder.Services.AddScoped<IMagicBallService, MagicBallService>();
builder.Services.AddScoped<IRestaurauntPicker, RestaurauntPicker>();

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
