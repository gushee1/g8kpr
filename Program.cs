using g8kpr.services;   

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGrpcService<TrackManagerService>();

app.Run();
