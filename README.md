# Proyecto de invetariado hecho con Blazor Server
Pequeño ejemplo CRUD de inventario realizado con Blazor .NET. Simula las entradas y salidas de productos almacenados en bodegas. Estos productos a su vez están clasificados en categorías.

Los puntos tratados en el ejemplo son:
* Desglose de la arquitectura en capas
* Uso en EF Core
* Razor: uso de Componentes y páginas Razor
* Pasos de parámetros, validaciones, uso de injección de dependencias, combos en cascada, y todo lo necesario para un CRUD básico.

## Comenzando 🚀

Proyecto de ejemplo realizado con Blazor Server .NET
Si quieres saber más acerca de esta tecnología, puede consultar [la página oficial de Microsoft - Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor).

Por otro lado, es importante conocer las [diferencias entre Blazor Server y Blazor Web Assembly](https://www.programmingwithwolfgang.com/blazor-server-vs-blazor-webassembly/)

### Pre-requisitos 📋

Como herramientas de desarrollo necesitarás:
* Visual Studio 2019
* SQL Server (con la versión Express es suficiente)

```
Nota: Visual Studio Code también valdría
```

### Instalación 🔧

* Una vez descargado el código, el primer paso es configurar la base de datos. Para ello, sigue las instrucciones del fichero MigracionesInstrucciones.txt, ubicado en el proyecto DataAccess
* Si las instrucciones se han realizado correctamente, ya podrás lanzar la aplicación.
* Deberás poner el proyecto _Inventory_ como inicial

## Ejecutando la aplicación ⚙️

Si todo ha ido bien, en la parte izquierda de la pantalla tendrás un menú con los siguientes apartados:
* **Home:** Bienvenida, nada importante* 
* **Lista de categorías:** Podrás visualizar las categorías de productos, así como dar de alta o modificarlas.
* **Lista de productos:** En función de una categoría, podrás visualizar los productos, así como dar de alta o modificarlos.
* **Crear almacenamiento:** Una bodega podrá almacenar productos
* **Crear entradas / salidas:** Una vez configurados los productos que hay en cada bodega (almacenamiento), se podrá hacer un ingreso o retirada de los mismos

### ¿Qué falta? 🔩

Muchísimas cosas. Sólo es un acercamiento. De hecho, el CRUD realmente es un "CRU", ya que no hace el borrado. Se podría hacer un borrado físico o lógico, a demanda.

## Construido con 🛠️

* [Microsoft Visual Studio Community 2019](https://visualstudio.microsoft.com/es/vs/) - IDE  de desarrollo
* [SQL Server Management Studio](https://docs.microsoft.com/es-es/sql/?view=sql-server-ver15/) - IDE de base de datos
* [Resharper](https://www.jetbrains.com/es-es/resharper/) - Extensión del IDE VS para optimizar el desarrollo

## Versionado 📌

Usado [Git](https://git-scm.com//) para el versionado. Por ahora, no existen diferentes versiones disponibles. Si en un futuro existieran, estarían en los diferentes tags que se crearían.

## Autores ✒️

* **David Santesteban** - *Trabajo Inicial* - [davidsantes](https://github.com/davidsantes)

## Agradecimientos 🎁

* Plataforma de aprendizaje online [Platzi](https://platzi.com/)
* A cualquiera que me invite a una cerveza 🍺. 
