# pymes-retail-redis-ia

Prototipo de plataforma para PyMEs retail usando .NET + Redis + IA.  
Objetivo: construir un POS simple que use Redis como capa de datos en tiempo real y siente las bases para futuras integraciones de IA.

## Primer flujo completo implementado

- El cliente (POS o herramienta como curl/Postman) llama `POST /api/pos/escaneo`.
- El controller `PosController` construye un objeto `EventoEscaneo`.
- El controller llama a `IVentasService` (implementado por `VentasServiceRedis` en el proyecto `PymesRetail.Redis`).
- `VentasServiceRedis` serializa el evento a JSON y lo guarda en la lista `eventos:escaneo` de Redis mediante `LPUSH`.

## Cómo probar que todo está “vivo”

1. Asegúrate de que Redis está corriendo en `localhost:6379` (Redis nativo para Windows).
2. Desde `src/backend-dotnet/PymesRetail.Api` ejecutar:
   ```bash
   dotnet run
   ```
3. En otra terminal, enviar un escaneo de prueba (ajustar puerto si es necesario):
   ```bash
   curl -X POST http://localhost:5000/api/pos/escaneo ^
     -H "Content-Type: application/json" ^
     -d "{\"SucursalId\":\"S1\",\"CajaId\":\"C1\",\"Gtin\":\"7501234567890\",\"Cantidad\":1,\"Usuario\":\"cajero1\"}"
   ```
4. Verificar en Redis que se registró el evento:
   ```bash
   redis-cli
   LRANGE eventos:escaneo 0 10
   ```

Deberías ver el JSON del evento en la lista `eventos:escaneo`.
