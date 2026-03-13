( ANTECEDENTES. TODO ESTE HILO VIENE DE 
  Plataforma Redis io Investigcion.txt )
  (Proy-redis PerplexityPrompts-01.md)
-------------------------------------------------------------
ETAPA 02. MANOS A LA OBRA C:\ALS\SW_DVLP\pymes-retail-redis-ia
-------------------------------------------------------------

Asumo ya como una hoja de ruta concreta tu anterior respuesta. 
Te informo que elijo ir por Opción A: Redis nativo para Windows

Ya estoy concretando la creacion de la estructura de carpetas minirepo en mi Lap W11. Una precision: He creado La raiz del proyecto en:
C:\ALS\SW_DVLP\pymes-retail-redis-ia

Apenas me encuentro en el punto
### 5.1 Inicializar proyectos .NET

He logrado dar los primeros pasos de .NET
cd src\backend-dotnet

dotnet new webapi -n PymesRetail.Api
dotnet new classlib -n PymesRetail.Core
dotnet new classlib -n PymesRetail.Redis
dotnet new xunit   -n PymesRetail.Tests

Pero Me he atorado en el siguiente paso:

C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet>dotnet sln ..\..\pymes-retail-redis-ia.sln add PymesRetail.Api

No se encuentra la solución o el directorio "..\..\pymes-retail-redis-ia.sln".

En algun punto he cometio un error, PARA EVITAR CONFUSIONES TE ANEXO LA ESTRUCTURA:

C:\ALS\SW_DVLP\pymes-retail-redis-ia\docs
C:\ALS\SW_DVLP\pymes-retail-redis-ia\estructura.txt
C:\ALS\SW_DVLP\pymes-retail-redis-ia\infra
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src
C:\ALS\SW_DVLP\pymes-retail-redis-ia\infra\redis
C:\ALS\SW_DVLP\pymes-retail-redis-ia\infra\redis\docker-compose.yml
C:\ALS\SW_DVLP\pymes-retail-redis-ia\infra\redis\redis.conf
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\clients
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\services-python
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Tests
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\appsettings.Development.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\appsettings.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\obj
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\Program.cs
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\Properties
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\PymesRetail.Api.csproj
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\PymesRetail.Api.http
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\obj\project.assets.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\obj\project.nuget.cache
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\obj\PymesRetail.Api.csproj.nuget.dgspec.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\obj\PymesRetail.Api.csproj.nuget.g.props
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\obj\PymesRetail.Api.csproj.nuget.g.targets
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\Properties\launchSettings.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core\Class1.cs
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core\obj
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core\PymesRetail.Core.csproj
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core\obj\project.assets.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core\obj\project.nuget.cache
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core\obj\PymesRetail.Core.csproj.nuget.dgspec.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core\obj\PymesRetail.Core.csproj.nuget.g.props
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core\obj\PymesRetail.Core.csproj.nuget.g.targets
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\Class1.cs
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\obj
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\PymesRetail.Redis.csproj
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\obj\project.assets.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\obj\project.nuget.cache
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\obj\PymesRetail.Redis.csproj.nuget.dgspec.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\obj\PymesRetail.Redis.csproj.nuget.g.props
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\obj\PymesRetail.Redis.csproj.nuget.g.targets
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Tests\obj
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Tests\PymesRetail.Tests.csproj
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Tests\UnitTest1.cs
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Tests\obj\project.assets.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Tests\obj\project.nuget.cache
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Tests\obj\PymesRetail.Tests.csproj.nuget.dgspec.json
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Tests\obj\PymesRetail.Tests.csproj.nuget.g.props
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Tests\obj\PymesRetail.Tests.csproj.nuget.g.targets
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\clients\admin-web
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\clients\pos-desktop
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\services-python\embeddings_service
C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\services-python\tools

requiero tu apoyo Para poder continuar a partir de:
dotnet sln pymes-retail-redis-ia.sln add PymesRetail.Api
para hacerlo desde la carpeta que corresponda
---------------------------------------------------------------------

El problema es simple: aún no existe el archivo de solución `.sln`, por eso el comando `dotnet sln ..\..\pymes-retail-redis-ia.sln add ...` falla. Vamos a crearlo y a agregar los proyectos con rutas correctas.

## 1. Crear la solución en la carpeta raíz correcta

Tu raíz es:

`C:\ALS\SW_DVLP\pymes-retail-redis-ia`

Haz esto:

1. Abre una terminal en esa ruta (importante):

```powershell
cd C:\ALS\SW_DVLP\pymes-retail-redis-ia
```

2. Crea la solución:

```powershell
dotnet new sln --name pymes-retail-redis-ia
```

Esto crea un archivo `pymes-retail-redis-ia.sln` en esa carpeta. [learn.microsoft](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)

## 2. Agregar los proyectos existentes a la solución

Ahora agrega los proyectos desde la raíz (no desde `backend-dotnet`):

```powershell
cd C:\ALS\SW_DVLP\pymes-retail-redis-ia

dotnet sln pymes-retail-redis-ia.sln add .\src\backend-dotnet\PymesRetail.Api\PymesRetail.Api.csproj

dotnet sln pymes-retail-redis-ia.sln add .\src\backend-dotnet\PymesRetail.Core\PymesRetail.Core.csproj

dotnet sln pymes-retail-redis-ia.sln add .\src\backend-dotnet\PymesRetail.Redis\PymesRetail.Redis.csproj

dotnet sln pymes-retail-redis-ia.sln add .\src\backend-dotnet\PymesRetail.Tests\PymesRetail.Tests.csproj
```

El comando `dotnet sln` admite especificar explícitamente el archivo `.sln` y luego las rutas a los `.csproj`. [linkedin](https://www.linkedin.com/pulse/managing-net-solution-files-dotnet-sln-sukhpinder-singh-arqvc)

Si quieres simplificar aún más, estando en la raíz puedes hacer:

```powershell
dotnet sln add .\src\backend-dotnet\PymesRetail.Api\PymesRetail.Api.csproj
dotnet sln add .\src\backend-dotnet\PymesRetail.Core\PymesRetail.Core.csproj
dotnet sln add .\src\backend-dotnet\PymesRetail.Redis\PymesRetail.Redis.csproj
dotnet sln add .\src\backend-dotnet\PymesRetail.Tests\PymesRetail.Tests.csproj
```

Cuando no especificas el `.sln`, el comando busca uno en el directorio actual y lo usa. [learn.microsoft](https://learn.microsoft.com/es-es/dotnet/core/tools/dotnet-sln)

## 3. Verificar

Desde la raíz:

```powershell
dotnet sln list
```

Deberías ver los cuatro proyectos listados dentro de `pymes-retail-redis-ia.sln`. [learn.microsoft](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)

Con esto ya quedas listo para el siguiente paso: agregar las referencias entre proyectos y empezar a implementar la capa Redis y los endpoints del POS.
---------------------------------------------------------------------

---------------------------------------------------------------------
---------------------------------------------------------------------
ALS: (DE MI PARA MI)
HE CONTINUADO LAS INSTRUCCIONES DADAS A PARTIR DE 
Plataforma Redis io Investigcion.txt :
LINEA. 540-546 OK
LINEA. 551 ok
Lineas 557, 559 OK cambia el prompt de la terminal anteponiedo (venv)C:\

(venv) C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\services-python\embeddings_service>

LINEA. 562..577 ok
se queda la terminal dentro de un bucle de proceso sin prompt:
INFO:     Application startup complete.
---------------------------------------------------------------------
---------------------------------------------------------------------

Bueno he seguido las instrucciones, gran parte no se bien a bien lo que estoy haciendo todavía, pero l¿confío lo comprenderé y dominaré con la práctica. No me he querido detener a investigar para qué sirve cada paso de manera de no dejar cosas pendientes.
Te comento Mis avances:

Instalar paquetes Redis >>(Ok)

### 5.2 Estructura mínima del microservicio Python
En `src\services-python\embeddings_service` >> OK
( en este punto el prompt de la terminal se ha quedado como 
(venv) C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\services-python\embeddings_service>
y luego posterior a crear el punto de entrada `app.py` y hacer 
uvicorn app:app --reload
se ha quedado un bucle de proceso en ejecución en la terminal,
mostrando:
INFO:     Application startup complete.

lo cual supongo es algo normal, es como un servicio atendiendo.
Todo sin problemas aparentes hasta ahí.
Pero Me he detenido por una duda en el siguiente punto:

### 6.1 PymesRetail.Core (dominio)
tu indicacion dice:
En `PymesRetail.Core`, podrías definir:


Pero en PymesRetail.Core.csproj
yo tengo el siguiente código:

<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>

Ignoro dónde definir:
```csharp
namespace PymesRetail.Core.Entities;

public class Producto
{
    public string Gtin { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public decimal Iva { get; set; }
}

public class EventoEscaneo
{
    public DateTime FechaHora { get; set; }
    public string SucursalId { get; set; } = string.Empty;
    public string CajaId { get; set; } = string.Empty;
    public string Gtin { get; set; } = string.Empty;
    public int Cantidad { get; set; }
    public string Usuario { get; set; } = string.Empty;
}
```

Así que ahí me he detenido. Necesito un poc a¿de ayuda adcional antes de continuar 
----------------------------------------------------------------

Todo lo que describes va perfecto: el servidor FastAPI en “bucle” es normal (se queda atendiendo peticiones) y el progreso en .NET va en muy buena ruta.

Aquí el punto clave: **el código C# de las entidades NO va en el `.csproj`**, va en archivos `.cs` dentro del proyecto `PymesRetail.Core`.

## 1. Dónde poner las clases `Producto` y `EventoEscaneo`

Pasos (desde tu estructura actual):

1. Abre el proyecto en tu editor/IDE  
   - Idealmente Visual Studio o VS Code.  
   - Abre el archivo de solución:  
     `C:\ALS\SW_DVLP\pymes-retail-redis-ia\pymes-retail-redis-ia.sln`

2. Dentro del proyecto **PymesRetail.Core**:

   - Verás un archivo generado por defecto: `Class1.cs`.  
   - Puedes:
     - O renombrarlo y reutilizarlo,  
     - O borrarlo y crear nuevos archivos.

3. Crea la carpeta y archivos:

   - Crea una carpeta llamada `Entities` dentro de `PymesRetail.Core`.  
     Ruta en disco:  
     `C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core\Entities`

   - Dentro de `Entities`, crea un archivo `Producto.cs` con este contenido:

     ```csharp
     namespace PymesRetail.Core.Entities;

     public class Producto
     {
         public string Gtin { get; set; } = string.Empty;
         public string Descripcion { get; set; } = string.Empty;
         public string Categoria { get; set; } = string.Empty;
         public decimal Precio { get; set; }
         public decimal Iva { get; set; }
     }
     ```

   - Crea otro archivo `EventoEscaneo.cs` en la misma carpeta:

     ```csharp
     namespace PymesRetail.Core.Entities;

     public class EventoEscaneo
     {
         public DateTime FechaHora { get; set; }
         public string SucursalId { get; set; } = string.Empty;
         public string CajaId { get; set; } = string.Empty;
         public string Gtin { get; set; } = string.Empty;
         public int Cantidad { get; set; }
         public string Usuario { get; set; } = string.Empty;
     }
     ```

4. El archivo `PymesRetail.Core.csproj` está bien como está; no tienes que tocarlo para esto. Ese archivo solo describe el proyecto (target framework, etc.), no contiene clases.

## 2. Qué hacer con el `Class1.cs` original

En `PymesRetail.Core` tienes un `Class1.cs` que creó `dotnet new classlib`. Opciones:

- Opción rápida: bórralo.  
- Opción alternativa: déjalo por ahora, no estorba; simplemente no lo usaremos.

## 3. Sobre el servidor FastAPI “en bucle”

Lo que viste:

```txt
INFO:     Application startup complete.
```

es exactamente lo esperado: el servidor está corriendo y esperando peticiones en `http://127.0.0.1:8000`.  
Para recuperar la terminal, puedes:

- Presionar `Ctrl + C` en esa ventana para detener el servidor, o  
- Dejar esa terminal “ocupada” y abrir otra para seguir con .NET.

No hay error ahí.

***

Si quieres, el siguiente paso que podemos hacer es:

- Crear la carpeta `Services` en `PymesRetail.Core` y definir las interfaces `IInventarioService` e `IVentasService`.  
- Luego pasar a `PymesRetail.Redis` y escribir el `RedisConnectionProvider` y el primer repositorio (productos) con `StackExchange.Redis + NRedisStack`.
--------------------------------------------------------------------------

Estoy regresando para que demos continuidad a pymes-retail-redis-ia después de haber hecho una pausa ya que no es ésta la única actividad que vengo realizando.

Antes de continuar necesito ACLARARTE cómo estoy trabajando. Todo esto lo estoy haciendo de la siguiente manera:

- manualmente creo las carpetas en Windows explorer y/o en terminal de windows.

- edito los archivos de código con Notepad++

- No me siento cómodo con el IDE de VS Code debido a que no me resulta intuitiva la manera de buscar texto dentro del código de los archivos ni de navegar dentro de las soluciones, tal vez porque nunca he tomado un tutorial de VS Code.

Por lo mismo cuando me has indicado que abra el archivo de solución:  
     `C:\ALS\SW_DVLP\pymes-retail-redis-ia\pymes-retail-redis-ia.sln`
Simplemente no hice nada dentro del mismo, como te he explicado todo lo he realizado por fuera y pues antes de continuar necesito me revises este aspeco de mi manera de trabajar para ver si puedo seguir de esa forma o debo de aplicarme dentro de algún IDE.

Una vez aclarado esto te comento en qué paso supongo que me encuentro:

Ya hice por mi cuenta lo de Crear la carpeta `Services` en `PymesRetail.Core` y definir las interfaces `IInventarioService` e `IVentasService`
Lo hice Imitando la manera en que me guiaste para crear Entities .

Efectivamente a partir de aqui todavia me faltará crear:
- RedisConnectionProvider
- Repositorio de productos (ejemplo de firma)
- ### 6.3 PymesRetail.Api (endpoints POS mínimos)
- registrar ProductoRepository
- Controller POS
etc..

Para lo cual requeriré tu ayuda pero con un poco más de detalles tal como me indicaste al crear Entities.

----------------------------------------------------------------------

Puedes seguir perfectamente como vas: carpetas a mano, Notepad++, CLI de .NET y Python. No es obligatorio usar VS Code o Visual Studio; la solución `.sln` solo la necesita `dotnet` para compilar todo junto, no tú para editar.

Sigo el mismo estilo detallado que usamos con `Entities`.

***

## 1. Confirmar estructura actual en PymesRetail.Core

Dentro de:

`C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Core\`

deberías tener algo así:

```text
PymesRetail.Core\
  PymesRetail.Core.csproj
  Entities\
    Producto.cs
    EventoEscaneo.cs
  Services\
    IInventarioService.cs
    IVentasService.cs
```

Si quieres, en otro mensaje puedes pegar el contenido de `IInventarioService.cs` e `IVentasService.cs` para revisarlos, pero por ahora asumiré algo como esto:

```csharp
// Services/IInventarioService.cs
namespace PymesRetail.Core.Services;

public interface IInventarioService
{
    Task<int> ObtenerStockAsync(string gtin, string sucursalId);
    Task AjustarStockAsync(string gtin, string sucursalId, int delta);
}

// Services/IVentasService.cs
using PymesRetail.Core.Entities;

namespace PymesRetail.Core.Services;

public interface IVentasService
{
    Task RegistrarEscaneoAsync(EventoEscaneo evento);
}
```

Si se parecen a esto, vamos bien.

***

## 2. PymesRetail.Redis: RedisConnectionProvider

Ruta del proyecto:

`C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\`

### 2.1 Instalar paquetes (si no lo hiciste)

En la terminal, desde esa carpeta:

```powershell
cd C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis
dotnet add package StackExchange.Redis
dotnet add package NRedisStack
```

La guía oficial muestra que StackExchange.Redis es el cliente base. [redis](https://redis.io/tutorials/develop/dotnet/)
NRedisStack añade helpers para Redis Stack (que luego usaremos para vectores/JSON). [redis](https://redis.io/docs/latest/develop/clients/dotnet/)

### 2.2 Crear `RedisConnectionProvider.cs`

Crea un archivo nuevo:

`C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\RedisConnectionProvider.cs`

Contenido:

```csharp
using StackExchange.Redis;

namespace PymesRetail.Redis;

public class RedisConnectionProvider
{
    private readonly ConnectionMultiplexer _muxer;

    // Por ahora asumimos Redis en localhost:6379 sin password para desarrollo
    public RedisConnectionProvider(string connectionString = "localhost:6379")
    {
        _muxer = ConnectionMultiplexer.Connect(connectionString);
    }

    public IDatabase GetDatabase()
    {
        return _muxer.GetDatabase();
    }
}
```

Esto encapsula la conexión compartida a Redis usando `ConnectionMultiplexer`, que es la recomendación habitual para .NET. [github](https://github.com/StackExchange/StackExchange.Redis)

***

## 3. PymesRetail.Redis: repositorio de productos

Vamos a crear un repositorio simple que lea/escriba `Producto` usando hashes en Redis.

### 3.1 Crear carpeta `Repositories`

Crea la carpeta:

`C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Redis\Repositories`

### 3.2 Crear `ProductoRepository.cs`

Archivo:

`...PymesRetail.Redis\Repositories\ProductoRepository.cs`

Contenido:

```csharp
using PymesRetail.Core.Entities;
using StackExchange.Redis;

namespace PymesRetail.Redis.Repositories;

public class ProductoRepository
{
    private readonly IDatabase _db;

    public ProductoRepository(IDatabase db)
    {
        _db = db;
    }

    private static string GetKey(string gtin) => $"producto:{gtin}";

    public async Task<Producto?> GetProductoPorGtinAsync(string gtin)
    {
        var key = GetKey(gtin);
        var hash = await _db.HashGetAllAsync(key);

        if (hash.Length == 0)
        {
            return null;
        }

        // Helpers para extraer campos
        string GetString(string field) =>
            hash.FirstOrDefault(x => x.Name == field).Value.HasValue
                ? hash.First(x => x.Name == field).Value.ToString()
                : string.Empty;

        decimal GetDecimal(string field)
        {
            var entry = hash.FirstOrDefault(x => x.Name == field);
            if (!entry.Value.HasValue) return 0m;
            if (decimal.TryParse(entry.Value.ToString(), out var value))
                return value;
            return 0m;
        }

        return new Producto
        {
            Gtin        = gtin,
            Descripcion = GetString("descripcion"),
            Categoria   = GetString("categoria"),
            Precio      = GetDecimal("precio"),
            Iva         = GetDecimal("iva")
        };
    }

    public async Task GuardarProductoAsync(Producto p)
    {
        var key = GetKey(p.Gtin);

        var entries = new HashEntry[]
        {
            new("descripcion", p.Descripcion),
            new("categoria",   p.Categoria),
            new("precio",      p.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture)),
            new("iva",         p.Iva.ToString(System.Globalization.CultureInfo.InvariantCulture))
        };

        await _db.HashSetAsync(key, entries);
    }
}
```

Idea: usamos `HASH` en Redis para almacenar los campos de `Producto`. Esto es consistente con muchos ejemplos de uso de Redis en aplicaciones .NET. [einfochips](https://www.einfochips.com/blog/redis-cache-and-its-use-cases-for-modern-application/)

***

## 4. Implementación mínima de IVentasService usando una LIST en Redis

Queremos que cada escaneo se registre en una lista `eventos:escaneo`.

### 4.1 Crear `VentasServiceRedis.cs` en PymesRetail.Redis

Archivo:

`...PymesRetail.Redis\Services\VentasServiceRedis.cs`

Primero crea la carpeta `Services` dentro de `PymesRetail.Redis`, luego el archivo.

Contenido:

```csharp
using System.Text.Json;
using PymesRetail.Core.Entities;
using PymesRetail.Core.Services;
using StackExchange.Redis;

namespace PymesRetail.Redis.Services;

public class VentasServiceRedis : IVentasService
{
    private readonly IDatabase _db;

    public VentasServiceRedis(IDatabase db)
    {
        _db = db;
    }

    private const string ListaEventosKey = "eventos:escaneo";

    public async Task RegistrarEscaneoAsync(EventoEscaneo evento)
    {
        // Convertimos el evento a JSON simple
        var json = JsonSerializer.Serialize(evento);

        // LPUSH eventos:escaneo "json..."
        await _db.ListLeftPushAsync(ListaEventosKey, json);
    }
}
```

Aquí usamos `JsonSerializer` de .NET para guardar el evento como JSON en una lista; luego podremos hacer `LRANGE` para leer eventos recientes. Ese patrón (listas para colas/eventos) es muy común en ejemplos de Redis para integración de procesos. [geeksforgeeks](https://www.geeksforgeeks.org/system-design/redis-and-its-role-in-system-design/)

***

## 5. Conectar todo en PymesRetail.Api (Program.cs)

Queremos que la API pueda:

- Crear una instancia de `RedisConnectionProvider`.  
- Obtener `IDatabase`.  
- Registrar `ProductoRepository` y `VentasServiceRedis`.  
- Exponer el endpoint `/api/pos/escaneo`.

### 5.1 Modificar `Program.cs` de PymesRetail.Api

Ruta:

`C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\Program.cs`

Reemplaza el contenido por algo como:

```csharp
using PymesRetail.Core.Services;
using PymesRetail.Redis;
using PymesRetail.Redis.Repositories;
using PymesRetail.Redis.Services;

var builder = WebApplication.CreateBuilder(args);

// Redis
builder.Services.AddSingleton<RedisConnectionProvider>();
builder.Services.AddSingleton(sp =>
{
    var provider = sp.GetRequiredService<RedisConnectionProvider>();
    return provider.GetDatabase();
});

// Repositorios y servicios de dominio
builder.Services.AddSingleton<ProductoRepository>();
builder.Services.AddSingleton<IVentasService, VentasServiceRedis>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
```

Esto sigue el patrón recomendado de inyección de dependencias en .NET: registras servicios en `builder.Services`, y los controllers los reciben en el constructor. [learn.microsoft](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)

***

## 6. Controller POS mínimo

Creamos el endpoint que el POS (o Postman) usará para registrar un escaneo.

### 6.1 Crear carpeta `Controllers` si no existe

Ruta:

`C:\ALS\SW_DVLP\pymes-retail-redis-ia\src\backend-dotnet\PymesRetail.Api\Controllers`

### 6.2 Crear `PosController.cs`

Contenido:

```csharp
using Microsoft.AspNetCore.Mvc;
using PymesRetail.Core.Entities;
using PymesRetail.Core.Services;

namespace PymesRetail.Api.Controllers;

[ApiController]
[Route("api/pos")]
public class PosController : ControllerBase
{
    private readonly IVentasService _ventasService;

    public PosController(IVentasService ventasService)
    {
        _ventasService = ventasService;
    }

    public class EscaneoRequest
    {
        public string SucursalId { get; set; } = string.Empty;
        public string CajaId { get; set; } = string.Empty;
        public string Gtin { get; set; } = string.Empty;
        public int Cantidad { get; set; } = 1;
        public string Usuario { get; set; } = string.Empty;
    }

    [HttpPost("escaneo")]
    public async Task<IActionResult> RegistrarEscaneo([FromBody] EscaneoRequest request)
    {
        var evento = new EventoEscaneo
        {
            FechaHora = DateTime.UtcNow,
            SucursalId = request.SucursalId,
            CajaId = request.CajaId,
            Gtin = request.Gtin,
            Cantidad = request.Cantidad,
            Usuario = request.Usuario
        };

        await _ventasService.RegistrarEscaneoAsync(evento);

        return Ok(new { status = "ok" });
    }
}
```

Con esto ya tienes el primer flujo completo:

- El cliente llama `POST /api/pos/escaneo`.  
- El controller construye `EventoEscaneo`.  
- Llama a `IVentasService` (implementado por `VentasServiceRedis`).  
- Éste guarda el evento en la lista `eventos:escaneo` de Redis.

***
-------------------------------------------------------------------------

** PROMPTS Continua en
  >>> Proy-redis PerplexityPrompts-03.md
-------------------------------------------------------------------------
