using Domain.Services;
using Dominio.Model;
using Dominio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

//Actualmente estamos usando los objetos del Domain Model, deberiamos usar ViewModels o DTOs         


app.MapGet("/clientes/{id}", (int id) =>
{
    ClienteService clienteService = new ClienteService();

    return clienteService.Get(id);
})
.WithName("GetCliente")
.WithOpenApi();

app.MapGet("/clientes", () =>
{
    ClienteService clienteService = new ClienteService();

    return clienteService.GetAll();
})
.WithName("GetAllClientes")
.WithOpenApi();

app.MapPost("/clientes", (Cliente cliente) =>
{
    ClienteService clienteService = new ClienteService();

    clienteService.Add(cliente);
})
.WithName("AddCliente")
.WithOpenApi();

app.MapPut("/clientes", (Cliente cliente) =>
{
    ClienteService clienteService = new ClienteService();

    clienteService.Update(cliente);
})
.WithName("UpdateCliente")
.WithOpenApi();

app.MapDelete("/clientes/{id}", (int id) =>
{
    ClienteService clienteService = new ClienteService();

    clienteService.Delete(id);
})
.WithName("DeleteCliente")
.WithOpenApi();

app.MapGet("/tecnicos/{id}", (int id) =>
{
    TecnicoService tecnicoService = new TecnicoService();

    return tecnicoService.Get(id);
})
.WithName("GetTecnico")
.WithOpenApi();

app.MapGet("/tecnicos", () =>
{
    TecnicoService tecnicoService = new TecnicoService();

    return tecnicoService.GetAll();
})
.WithName("GetAllTecnicos")
.WithOpenApi();

app.MapPost("/tecnicos", (Tecnico tecnico) =>
{
    TecnicoService tecnicoService = new TecnicoService();

    tecnicoService.Add(tecnico);
})
.WithName("AddTecnico")
.WithOpenApi();

app.MapPut("/tecnicos", (Tecnico tecnico) =>
{
    TecnicoService tecnicoService = new TecnicoService();

    tecnicoService.Update(tecnico);
})
.WithName("UpdateTecnico")
.WithOpenApi();

app.MapDelete("/tecnicos/{id}", (int id) =>
{
   TecnicoService tecnicoService = new TecnicoService();

    tecnicoService.Delete(id);
})
.WithName("DeleteTecnico")
.WithOpenApi();

app.MapGet("/tiposmateriales/{id}", (int id) =>
{
    TipoMaterialService tipoMaterialService = new TipoMaterialService();

    return tipoMaterialService.Get(id);
})
.WithName("GetTiposMateriales")
.WithOpenApi();

app.MapGet("/tiposmateriales", () =>
{
    TipoMaterialService tipoMaterialService = new TipoMaterialService();

    return tipoMaterialService.GetAll();
})
.WithName("GetAllTiposMateriales")
.WithOpenApi();

app.MapPost("/tiposmateriales", (TipoMaterial tipoMaterial) =>
{
    TipoMaterialService tipoMaterialService = new TipoMaterialService();

    tipoMaterialService.Add(tipoMaterial);
})
.WithName("AddTiposMateriales")
.WithOpenApi();

app.MapPut("/tiposmateriales", (TipoMaterial tipoMaterial) =>
{
    TipoMaterialService tipoMaterialService = new TipoMaterialService();

    tipoMaterialService.Update(tipoMaterial);
})
.WithName("UpdateTiposMateriales")
.WithOpenApi();

app.MapDelete("/tiposmateriales/{id}", (int id) =>
{
    TipoMaterialService tipoMaterialService = new TipoMaterialService();

    tipoMaterialService.Delete(id);
})
.WithName("DeleteTiposMateriales")
.WithOpenApi();

app.Run();