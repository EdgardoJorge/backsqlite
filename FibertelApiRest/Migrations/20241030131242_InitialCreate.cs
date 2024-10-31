using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FibertelApiRest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Tienda");

            migrationBuilder.EnsureSchema(
                name: "Movimientos");

            migrationBuilder.CreateTable(
                name: "administradors",
                schema: "Tienda",
                columns: table => new
                {
                    idAdministrador = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombres = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    telefonoMovil = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradors", x => x.idAdministrador);
                });

            migrationBuilder.CreateTable(
                name: "banners",
                schema: "Tienda",
                columns: table => new
                {
                    idBanner = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    imagen = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    enlace = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    estado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banners", x => x.idBanner);
                });

            migrationBuilder.CreateTable(
                name: "categorias",
                schema: "Tienda",
                columns: table => new
                {
                    idCategoria = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoriaNombre = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    imagen = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    estado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                schema: "Movimientos",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    razonSocial = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    telefonoMovil = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    tipoDocumento = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    numeroDocumento = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    direccionFiscal = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "marcas",
                schema: "Tienda",
                columns: table => new
                {
                    idMarca = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    marcaNombre = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    imagen = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    estado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.idMarca);
                });

            migrationBuilder.CreateTable(
                name: "personals",
                schema: "Movimientos",
                columns: table => new
                {
                    idPersonal = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombres = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    apellidos = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    rol = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    contacto = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    numeroDocumento = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    inicioOperacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    finOperacion = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personals", x => x.idPersonal);
                });

            migrationBuilder.CreateTable(
                name: "recojos",
                schema: "Movimientos",
                columns: table => new
                {
                    idRecojo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fechaListo = table.Column<DateTime>(type: "TEXT", nullable: true),
                    fechaEntrega = table.Column<DateTime>(type: "TEXT", nullable: true),
                    responsableEntrega = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recojos", x => x.idRecojo);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                schema: "Tienda",
                columns: table => new
                {
                    idProducto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    productoNombre = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    precio = table.Column<decimal>(type: "TEXT", precision: 6, scale: 2, nullable: false),
                    precioOferta = table.Column<decimal>(type: "TEXT", precision: 6, scale: 2, nullable: true),
                    cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    detalle = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    imagen01 = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    imagen02 = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    imagen03 = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true),
                    imagen04 = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true),
                    idCategoria = table.Column<int>(type: "INTEGER", nullable: false),
                    idMarca = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK_productos_categorias_idCategoria",
                        column: x => x.idCategoria,
                        principalSchema: "Tienda",
                        principalTable: "categorias",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productos_marcas_idMarca",
                        column: x => x.idMarca,
                        principalSchema: "Tienda",
                        principalTable: "marcas",
                        principalColumn: "idMarca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "envios",
                schema: "Movimientos",
                columns: table => new
                {
                    idEnvio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    region = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    provincia = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    distrito = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    localidad = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    calle = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    nDomicilio = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    codigoPostal = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    fechaEnvio = table.Column<DateTime>(type: "TEXT", nullable: true),
                    fechaEntrega = table.Column<DateTime>(type: "TEXT", nullable: true),
                    responsableEntrega = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    idPersonal = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_envios", x => x.idEnvio);
                    table.ForeignKey(
                        name: "FK_envios_personals_idPersonal",
                        column: x => x.idPersonal,
                        principalSchema: "Movimientos",
                        principalTable: "personals",
                        principalColumn: "idPersonal");
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                schema: "Movimientos",
                columns: table => new
                {
                    idPedido = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fechaPedido = table.Column<DateTime>(type: "TEXT", nullable: false),
                    fechaCancelado = table.Column<DateTime>(type: "TEXT", nullable: true),
                    tipoPedido = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    estado = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    total = table.Column<decimal>(type: "TEXT", precision: 6, scale: 2, nullable: false),
                    idCliente = table.Column<int>(type: "INTEGER", nullable: false),
                    idPersonal = table.Column<int>(type: "INTEGER", nullable: true),
                    idEnvio = table.Column<int>(type: "INTEGER", nullable: true),
                    idRecojo = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.idPedido);
                    table.ForeignKey(
                        name: "FK_pedidos_clientes_idCliente",
                        column: x => x.idCliente,
                        principalSchema: "Movimientos",
                        principalTable: "clientes",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedidos_envios_idEnvio",
                        column: x => x.idEnvio,
                        principalSchema: "Movimientos",
                        principalTable: "envios",
                        principalColumn: "idEnvio");
                    table.ForeignKey(
                        name: "FK_pedidos_personals_idPersonal",
                        column: x => x.idPersonal,
                        principalSchema: "Movimientos",
                        principalTable: "personals",
                        principalColumn: "idPersonal");
                    table.ForeignKey(
                        name: "FK_pedidos_recojos_idRecojo",
                        column: x => x.idRecojo,
                        principalSchema: "Movimientos",
                        principalTable: "recojos",
                        principalColumn: "idRecojo");
                });

            migrationBuilder.CreateTable(
                name: "comprobantes",
                schema: "Movimientos",
                columns: table => new
                {
                    idComprobante = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fechaEmision = table.Column<DateTime>(type: "TEXT", nullable: false),
                    tipoComprobante = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    idPedido = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comprobantes", x => x.idComprobante);
                    table.ForeignKey(
                        name: "FK_comprobantes_pedidos_idPedido",
                        column: x => x.idPedido,
                        principalSchema: "Movimientos",
                        principalTable: "pedidos",
                        principalColumn: "idPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detallePedidos",
                schema: "Movimientos",
                columns: table => new
                {
                    idDetallePedido = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    precioUnitario = table.Column<decimal>(type: "TEXT", precision: 6, scale: 2, nullable: false),
                    precioDescuento = table.Column<decimal>(type: "TEXT", precision: 6, scale: 2, nullable: true),
                    subTotal = table.Column<decimal>(type: "TEXT", precision: 6, scale: 2, nullable: false),
                    idProducto = table.Column<int>(type: "INTEGER", nullable: false),
                    idPedido = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detallePedidos", x => x.idDetallePedido);
                    table.ForeignKey(
                        name: "FK_detallePedidos_pedidos_idPedido",
                        column: x => x.idPedido,
                        principalSchema: "Movimientos",
                        principalTable: "pedidos",
                        principalColumn: "idPedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detallePedidos_productos_idProducto",
                        column: x => x.idProducto,
                        principalSchema: "Tienda",
                        principalTable: "productos",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Tienda",
                table: "administradors",
                columns: new[] { "idAdministrador", "email", "estado", "nombres", "password", "telefonoMovil" },
                values: new object[] { 1, "luis@fibertel.com", true, "Luis Rosales Rosales", "123456789", "983234873" });

            migrationBuilder.InsertData(
                schema: "Tienda",
                table: "banners",
                columns: new[] { "idBanner", "enlace", "estado", "imagen" },
                values: new object[,]
                {
                    { 1, "http://localhost:4200/categoria/1", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/banners%2FBannerPrincipal.png?alt=media&token=67c05c02-3c7f-4542-b556-fb29f2aaa50e" },
                    { 2, "http://localhost:4200/categoria/8", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/banners%2FBannerLaptops.png?alt=media&token=63ee6e5d-97bf-4456-b167-5593d6d5b5a9" },
                    { 3, "http://localhost:4200/marca/1", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/banners%2FBannerCelulares.png?alt=media&token=3710d7bc-3821-4402-b4be-31dd4a34a806" },
                    { 4, "http://localhost:4200/producto/1", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/banners%2FBannerLaptops.png?alt=media&token=63ee6e5d-97bf-4456-b167-5593d6d5b5a9" }
                });

            migrationBuilder.InsertData(
                schema: "Tienda",
                table: "categorias",
                columns: new[] { "idCategoria", "categoriaNombre", "estado", "imagen" },
                values: new object[,]
                {
                    { 1, "Monitores", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a" },
                    { 2, "Routers", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a" },
                    { 3, "Accesorios", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a" },
                    { 4, "Audio", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a" },
                    { 5, "Cables", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a" },
                    { 6, "Oficina", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a" },
                    { 7, "Celulares", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a" },
                    { 8, "Laptops", true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2Fcategory.png?alt=media&token=b47cd212-75ee-43bc-a0c3-de585b338b1e" }
                });

            migrationBuilder.InsertData(
                schema: "Movimientos",
                table: "clientes",
                columns: new[] { "idCliente", "direccionFiscal", "email", "numeroDocumento", "razonSocial", "telefonoMovil", "tipoDocumento" },
                values: new object[,]
                {
                    { 1, null, "maicolrosas@gmail.com", "23171287", "Maicol Linares Rosales", "902393648", "DNI" },
                    { 2, "Junin, Huancayo, Huancayo Jr Loreto 190", "anaflores@gmail.com", "201203944584544", "Ana Rosas Rosas", "902383983", "RUC" }
                });

            migrationBuilder.InsertData(
                schema: "Tienda",
                table: "marcas",
                columns: new[] { "idMarca", "estado", "imagen", "marcaNombre" },
                values: new object[,]
                {
                    { 1, true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", "Epson" },
                    { 2, true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", "Asus" },
                    { 3, true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", "Sony" },
                    { 4, true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", "Huawei" },
                    { 5, true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", "Lenovo" },
                    { 6, true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2Fjbl.png?alt=media&token=f5ac8d03-ca68-498c-9a7e-b38a1ead6314", "Jbl" },
                    { 7, true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2Fsamsung.png?alt=media&token=3cd77c5b-6e89-4ccb-9c28-6fc9f7cbae2e", "Samsung" },
                    { 8, true, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", "Generico" }
                });

            migrationBuilder.InsertData(
                schema: "Movimientos",
                table: "personals",
                columns: new[] { "idPersonal", "apellidos", "contacto", "finOperacion", "inicioOperacion", "nombres", "numeroDocumento", "rol" },
                values: new object[,]
                {
                    { 1, "Merino Zalasar", "982332873", null, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andy", "73123465", "Responsable de Envio" },
                    { 2, "Merino Rosas", "982332873", null, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luis Felipe", "70123465", "Responsable de Envio" }
                });

            migrationBuilder.InsertData(
                schema: "Movimientos",
                table: "recojos",
                columns: new[] { "idRecojo", "fechaEntrega", "fechaListo", "responsableEntrega" },
                values: new object[] { 1, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                schema: "Movimientos",
                table: "envios",
                columns: new[] { "idEnvio", "calle", "codigoPostal", "distrito", "fechaEntrega", "fechaEnvio", "idPersonal", "localidad", "nDomicilio", "provincia", "region", "responsableEntrega" },
                values: new object[] { 1, "Av Rosales", "202025", "Lima", null, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lima Lima Lima", "230", "Lima", "Lima", "Felipe Sarmiento - 72342312" });

            migrationBuilder.InsertData(
                schema: "Movimientos",
                table: "pedidos",
                columns: new[] { "idPedido", "estado", "fechaCancelado", "fechaPedido", "idCliente", "idEnvio", "idPersonal", "idRecojo", "tipoPedido", "total" },
                values: new object[] { 2, "Entregado", null, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1, 1, "Recojo en Tienda", 5010.90m });

            migrationBuilder.InsertData(
                schema: "Tienda",
                table: "productos",
                columns: new[] { "idProducto", "cantidad", "detalle", "estado", "idCategoria", "idMarca", "imagen01", "imagen02", "imagen03", "imagen04", "precio", "precioOferta", "productoNombre" },
                values: new object[,]
                {
                    { 1, 25, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 1, 1, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01", 201.90m, 180.90m, "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"" },
                    { 2, 10, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 2, 2, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", 7101.90m, 2000.90m, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" },
                    { 3, 25, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 3, 3, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01", 601.90m, null, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" },
                    { 4, 21, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 4, 4, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", 901.90m, 880.90m, "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"" },
                    { 5, 46, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 5, 5, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01", 201.90m, null, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" },
                    { 6, 67, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 6, 6, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", null, null, 1201.90m, 980.90m, "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"" },
                    { 7, 87, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 7, 4, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", 3201.90m, null, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" },
                    { 8, 45, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 8, 8, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", null, null, 7801.90m, 5680.90m, "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"" },
                    { 9, 23, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 1, 4, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", 1201.90m, null, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" },
                    { 10, 12, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 2, 2, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01", 3201.90m, 2980.90m, "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"" },
                    { 11, 11, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 3, 4, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", 5201.90m, null, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" },
                    { 12, 45, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 2, 4, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", null, null, 6201.90m, 4580.90m, "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"" },
                    { 13, 67, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 5, 5, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", 8301.90m, null, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" },
                    { 14, 98, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 6, 6, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01", 3201.90m, 2580.90m, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" },
                    { 15, 77, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 2, 7, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", 7901.90m, null, "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"" },
                    { 16, 54, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 8, 8, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01", 41.90m, 30.90m, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" },
                    { 17, 65, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 2, 1, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", 201.90m, null, "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"" },
                    { 18, 32, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 2, 2, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01", 9001.90m, 8580.90m, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" },
                    { 19, 14, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 3, 3, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20", null, null, 4201.90m, null, "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"" },
                    { 20, 25, "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo", true, 4, 4, "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629", "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01", 201.90m, 180.90m, "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS" }
                });

            migrationBuilder.InsertData(
                schema: "Movimientos",
                table: "comprobantes",
                columns: new[] { "idComprobante", "fechaEmision", "idPedido", "tipoComprobante" },
                values: new object[] { 2, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Factura" });

            migrationBuilder.InsertData(
                schema: "Movimientos",
                table: "detallePedidos",
                columns: new[] { "idDetallePedido", "cantidad", "idPedido", "idProducto", "precioDescuento", "precioUnitario", "subTotal" },
                values: new object[,]
                {
                    { 2, 5, 2, 12, 2000.90m, 2300.90m, 2000.90m },
                    { 3, 2, 2, 7, 2000.90m, 2300.90m, 2000.90m }
                });

            migrationBuilder.InsertData(
                schema: "Movimientos",
                table: "pedidos",
                columns: new[] { "idPedido", "estado", "fechaCancelado", "fechaPedido", "idCliente", "idEnvio", "idPersonal", "idRecojo", "tipoPedido", "total" },
                values: new object[] { 1, "Enviado", null, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, null, "Envio a Domicilio", 5010.90m });

            migrationBuilder.InsertData(
                schema: "Movimientos",
                table: "comprobantes",
                columns: new[] { "idComprobante", "fechaEmision", "idPedido", "tipoComprobante" },
                values: new object[] { 1, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Boleta" });

            migrationBuilder.InsertData(
                schema: "Movimientos",
                table: "detallePedidos",
                columns: new[] { "idDetallePedido", "cantidad", "idPedido", "idProducto", "precioDescuento", "precioUnitario", "subTotal" },
                values: new object[] { 1, 1, 1, 3, 2000.90m, 2300.90m, 2000.90m });

            migrationBuilder.CreateIndex(
                name: "IX_comprobantes_idPedido",
                schema: "Movimientos",
                table: "comprobantes",
                column: "idPedido",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_detallePedidos_idPedido",
                schema: "Movimientos",
                table: "detallePedidos",
                column: "idPedido");

            migrationBuilder.CreateIndex(
                name: "IX_detallePedidos_idProducto",
                schema: "Movimientos",
                table: "detallePedidos",
                column: "idProducto");

            migrationBuilder.CreateIndex(
                name: "IX_envios_idPersonal",
                schema: "Movimientos",
                table: "envios",
                column: "idPersonal");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_idCliente",
                schema: "Movimientos",
                table: "pedidos",
                column: "idCliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_idEnvio",
                schema: "Movimientos",
                table: "pedidos",
                column: "idEnvio",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_idPersonal",
                schema: "Movimientos",
                table: "pedidos",
                column: "idPersonal");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_idRecojo",
                schema: "Movimientos",
                table: "pedidos",
                column: "idRecojo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_productos_idCategoria",
                schema: "Tienda",
                table: "productos",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_productos_idMarca",
                schema: "Tienda",
                table: "productos",
                column: "idMarca");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradors",
                schema: "Tienda");

            migrationBuilder.DropTable(
                name: "banners",
                schema: "Tienda");

            migrationBuilder.DropTable(
                name: "comprobantes",
                schema: "Movimientos");

            migrationBuilder.DropTable(
                name: "detallePedidos",
                schema: "Movimientos");

            migrationBuilder.DropTable(
                name: "pedidos",
                schema: "Movimientos");

            migrationBuilder.DropTable(
                name: "productos",
                schema: "Tienda");

            migrationBuilder.DropTable(
                name: "clientes",
                schema: "Movimientos");

            migrationBuilder.DropTable(
                name: "envios",
                schema: "Movimientos");

            migrationBuilder.DropTable(
                name: "recojos",
                schema: "Movimientos");

            migrationBuilder.DropTable(
                name: "categorias",
                schema: "Tienda");

            migrationBuilder.DropTable(
                name: "marcas",
                schema: "Tienda");

            migrationBuilder.DropTable(
                name: "personals",
                schema: "Movimientos");
        }
    }
}
