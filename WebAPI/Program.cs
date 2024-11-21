using Domain.Services;
using Dominio.Model;
using Dominio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });
builder.Services.AddCors( options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});//PARA BLAZOR
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

app.UseCors("AllowAllOrigins");//PARA BLAZOR
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

app.MapGet("/solicitudes/{id}", (int id) =>
{
    SolicitudService solicitudService = new SolicitudService();

    return solicitudService.Get(id);
})
.WithName("GetSolicitud")
.WithOpenApi();

app.MapGet("/solicitudes", () =>
{
    SolicitudService solicitudService = new SolicitudService();

    return solicitudService.GetAll();
})
.WithName("GetAllSolicitudes")
.WithOpenApi();

app.MapPost("/solicitudes", (Solicitud solicitud) =>
{
    SolicitudService solicitudService = new SolicitudService();

    solicitudService.Add(solicitud);
})
.WithName("AddSolicitud")
.WithOpenApi();

app.MapPut("/solicitudes", (Solicitud solicitud) =>
{
    SolicitudService solicitudService = new SolicitudService();

    solicitudService.Update(solicitud);
})
.WithName("UpdateSolicitud")
.WithOpenApi();

app.MapDelete("/solicitudes/{id}", (int id) =>
{
    SolicitudService solicitudService = new SolicitudService();

    solicitudService.Delete(id);
})
.WithName("DeleteSolicitud")
.WithOpenApi();

app.MapGet("/tiposolicitudes/{id}", (int id) =>
{
    TipoSolicitudService tipoSolicitudService = new TipoSolicitudService();

    return tipoSolicitudService.Get(id);
})
.WithName("GetTipoSolicitud")
.WithOpenApi();

app.MapGet("/tiposolicitudes", () =>
{
    TipoSolicitudService tipoSolicitudService = new TipoSolicitudService();

    return tipoSolicitudService.GetAll();
})
.WithName("GetAllTipoSolicitudes")
.WithOpenApi();

app.MapPost("/tiposolicitudes", (TipoSolicitud tipoSolicitud) =>
{
    TipoSolicitudService tipoSolicitudService = new TipoSolicitudService();

    tipoSolicitudService.Add(tipoSolicitud);
})
.WithName("AddTipoSolicitud")
.WithOpenApi();

app.MapPut("/tiposolicitudes", (TipoSolicitud tipoSolicitud) =>
{
    TipoSolicitudService tipoSolicitudService = new TipoSolicitudService();

    tipoSolicitudService.Update(tipoSolicitud);
})
.WithName("UpdateTipoSolicitud")
.WithOpenApi();

app.MapDelete("/tiposolicitudes/{id}", (int id) =>
{
    TipoSolicitudService tipoSolicitudService = new TipoSolicitudService();

    tipoSolicitudService.Delete(id);
})
.WithName("DeleteTipoSolicitud")
.WithOpenApi();

app.MapGet("/visitas/{id}", (int id) =>
{
    VisitaService visitaService = new VisitaService();

    return visitaService.Get(id);
})
.WithName("GetVisita")
.WithOpenApi();

app.MapGet("/visitas", () =>
{
    VisitaService visitaService = new VisitaService();

    return visitaService.GetAll();
})
.WithName("GetAllVisitas")
.WithOpenApi();

app.MapPost("/visitas", (Visita visita) =>
{
    VisitaService visitaService = new VisitaService();

    return visitaService.Add(visita);
})
.WithName("AddVisita")
.WithOpenApi();

app.MapPut("/visitas", (Visita visita) =>
{
    VisitaService visitaService = new VisitaService();

    visitaService.Update(visita);
})
.WithName("UpdateVisita")
.WithOpenApi();

app.MapDelete("/visitas/{id}", (int id) =>
{
    VisitaService visitaService = new VisitaService();

    visitaService.Delete(id);
})
.WithName("DeleteVisita")
.WithOpenApi();

app.MapGet("/materiales/{id}", (int id) =>
{
    MaterialService materialService = new MaterialService();

    return materialService.Get(id);
})
.WithName("GetMateriales")
.WithOpenApi();

app.MapGet("/materiales", () =>
{
    MaterialService materialService = new MaterialService();

    return materialService.GetAll();
})
.WithName("GetAllMateriales")
.WithOpenApi();

app.MapPost("/materiales", (Material material) =>
{
    MaterialService materialService = new MaterialService();

    materialService.Add(material);
})
.WithName("AddMateriales")
.WithOpenApi();

app.MapPost("/listamateriales/{id}", (List<Material> materiales, int id) =>
{
    MaterialService materialService = new MaterialService();

    materialService.AddLista(materiales, id);
})
.WithName("AddListaMateriales")
.WithOpenApi();

app.MapGet("/listamateriales/{id}", (int id) =>
{
    MaterialService materialService = new MaterialService();

    return materialService.GetAllPorVisita(id);
})
.WithName("GetVisitaMateriales")
.WithOpenApi();

app.MapPut("/materiales", (Material material) =>
{
    MaterialService materialService = new MaterialService();

    materialService.Update(material);
})
.WithName("UpdateMateriales")
.WithOpenApi();

app.MapDelete("/materiales/{id}", (int id) =>
{
    MaterialService materialService = new MaterialService();

    materialService.Delete(id);
})
.WithName("DeleteMateriales")
.WithOpenApi();

app.MapPost("/login", (Tecnico tecnico) =>
{
    TecnicoService tecnicoService = new TecnicoService();
    Tecnico? tecnicoObtenido = tecnicoService.GetMail(tecnico.Email);

    if(tecnicoObtenido != null)
    {
        if(tecnicoObtenido.Password == tecnico.Password)
        {
            tecnicoObtenido.Password = "";
            return tecnicoObtenido;
        }
    }

    return null;
})
.WithName("LoginTecnico")
.WithOpenApi();

app.MapGet("/roles/{rol}", (int rol) =>
{
    RolService rolService = new RolService();

    return rolService.Get(rol);
})
.WithName("GetRol")
.WithOpenApi();

app.MapGet("/roles", () =>
{
    RolService rolService = new RolService();

    return rolService.GetAll();
})
.WithName("GetAllRol")
.WithOpenApi();

app.MapGet("/repportipo", () =>
{
    ReporteService reporteService = new ReporteService();

    return reporteService.PorTipo();
})
.WithName("GetRepPorTipo")
.WithOpenApi();

app.Run();