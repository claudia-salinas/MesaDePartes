# MesaDePartes

Prototipo de consola en C# para la gestión de expedientes de la Mesa de Partes de la Municipalidad Distrital de Víctor Larco Herrera (Trujillo, Perú).

Proyecto del curso Fundamentos de Programación (CIIN1205P), Universidad Privada del Norte (UPN), Facultad de Ingeniería.

## Descripción

Hoy la Mesa de Partes registra los trámites a mano en cuadernos de cargo, lo que genera demoras, errores de legibilidad y búsquedas de 15 a 30 minutos por consulta. Este prototipo reemplaza ese registro manual por uno digital.

## Funcionalidades

- Registro de expedientes (código, solicitante, DNI y trámite)
- Validación del DNI: debe tener exactamente 8 caracteres
- Listado general de expedientes
- Búsqueda secuencial por código
- Inserción y eliminación de expedientes
- Ordenamiento por código con el método burbuja

## Solución elegida

Los datos se guardan en **4 arreglos unidimensionales paralelos** (códigos, solicitantes, DNIs y trámites). Cada expediente ocupa la misma posición en los cuatro arreglos.

## Estructura del proyecto

| Archivo | Función |
|---|---|
| Program.cs | Método Main: declara los arreglos y llama a los módulos en orden |
| Validacion.cs | LeerEntero: valida que la entrada sea un número entero |
| Registro.cs | LlenarArreglos, EscribirArreglos, InsertarExpediente y EliminarExpediente |
| Busqueda.cs | BuscarExpediente: búsqueda secuencial por código |
| Ordenamiento.cs | OrdenarBurbuja: ordena por código manteniendo sincronizados los 4 arreglos |

## Tecnologías

- C# (proyecto de consola)
- Visual Studio
- Git y GitHub para el control de versiones

## Cómo ejecutarlo

**Requisito:** Visual Studio con la carga de trabajo de desarrollo de escritorio con .NET.

1. Clona el repositorio: `git clone https://github.com/claudia-salinas/MesaDePartes.git`
2. Abre la solución `MesaDePartes.sln` con Visual Studio.
3. Presiona **F5** para ejecutar.
4. En la consola, ingresa los datos de los 5 expedientes. Luego el programa muestra el listado, busca un expediente por código, inserta uno nuevo, elimina otro y muestra la lista ordenada.

## Estado del avance

- Implementado: validación, registro, búsqueda y ordenamiento.
- Pendiente: persistencia de datos en archivos (versión final).

## Integrantes

- Claudia Marycielo Salinas Cesías
- Francesca Valentina Yepez Valdivieso
- Johan Leonardo Vidal Sandoval
- Anderson Daniel Ninaquispe Loyola
- Franklin Danilo Barboza Rengifo

**Docente:** Jorge Ricardo Perez Vigil
