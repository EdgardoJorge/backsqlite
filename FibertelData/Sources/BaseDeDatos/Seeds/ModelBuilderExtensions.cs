using FibertelData.Sources.BaseDeDatos.Tables;
using Microsoft.EntityFrameworkCore;

namespace FibertelData.Sources.BaseDeDatos.Seeds
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            //TIENDA -----------------
            #region Tienda 
            //Marca 
            modelBuilder.Entity<MarcaTable>().HasData(
                new MarcaTable { idMarca = 1, marcaNombre = "Epson", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", estado = true },
                new MarcaTable { idMarca = 2, marcaNombre = "Asus", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", estado = true },
                new MarcaTable { idMarca = 3, marcaNombre = "Sony", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", estado = true },
                new MarcaTable { idMarca = 4, marcaNombre = "Huawei", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", estado = true },
                new MarcaTable { idMarca = 5, marcaNombre = "Lenovo", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", estado = true },
                new MarcaTable { idMarca = 6, marcaNombre = "Jbl", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2Fjbl.png?alt=media&token=f5ac8d03-ca68-498c-9a7e-b38a1ead6314", estado = true },
                new MarcaTable { idMarca = 7, marcaNombre = "Samsung", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2Fsamsung.png?alt=media&token=3cd77c5b-6e89-4ccb-9c28-6fc9f7cbae2e", estado = true },
                new MarcaTable { idMarca = 8, marcaNombre = "Generico", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/marcas%2FMarca.png?alt=media&token=bd0aa8ae-7e2a-4370-b0d9-7c690f001881", estado = true }
            );

            //Categoria
            modelBuilder.Entity<CategoriaTable>().HasData(
                new CategoriaTable { idCategoria = 1, categoriaNombre = "Monitores", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a", estado = true },
                new CategoriaTable { idCategoria = 2, categoriaNombre = "Routers", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a", estado = true },
                new CategoriaTable { idCategoria = 3, categoriaNombre = "Accesorios", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a", estado = true },
                new CategoriaTable { idCategoria = 4, categoriaNombre = "Audio", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a", estado = true },
                new CategoriaTable { idCategoria = 5, categoriaNombre = "Cables", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a", estado = true },
                new CategoriaTable { idCategoria = 6, categoriaNombre = "Oficina", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a", estado = true },
                new CategoriaTable { idCategoria = 7, categoriaNombre = "Celulares", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2FCategoria.png?alt=media&token=afb9e781-18e6-4152-b38d-29e009fe788a", estado = true },
                new CategoriaTable { idCategoria = 8, categoriaNombre = "Laptops", imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/categorias%2Fcategory.png?alt=media&token=b47cd212-75ee-43bc-a0c3-de585b338b1e", estado = true }
            );

            //Producto
            modelBuilder.Entity<ProductoTable>().HasData(
                new ProductoTable { idProducto = 1, productoNombre = "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"", precio = 201.90m, precioOferta = 180.90m,
                    cantidad = 25, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b", 
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629", 
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01",
                    idCategoria = 1, idMarca = 1 },

                new ProductoTable { idProducto = 2, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 7101.90m, precioOferta = 2000.90m,
                    cantidad = 10, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    idCategoria = 2, idMarca = 2 },

                new ProductoTable { idProducto = 3, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 601.90m, precioOferta = null,
                    cantidad = 25, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01",
                    idCategoria = 3, idMarca = 3 },

                new ProductoTable { idProducto = 4, productoNombre = "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"", precio = 901.90m, precioOferta = 880.90m,
                    cantidad = 21, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    idCategoria = 4, idMarca = 4 },

                new ProductoTable { idProducto = 5, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 201.90m, precioOferta = null,
                    cantidad = 46, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01",
                    idCategoria = 5, idMarca = 5 },

                new ProductoTable { idProducto = 6, productoNombre = "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"", precio = 1201.90m, precioOferta = 980.90m,
                    cantidad = 67, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b",
                    imagen03 = null,
                    imagen04 = null,
                    idCategoria = 6, idMarca = 6 },

                new ProductoTable { idProducto = 7, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 3201.90m, precioOferta = null,
                    cantidad = 87, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    idCategoria = 7, idMarca = 4 },

                new ProductoTable { idProducto = 8, productoNombre = "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"", precio = 7801.90m, precioOferta = 5680.90m,
                    cantidad = 45, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b",
                    imagen03 = null,
                    imagen04 = null,
                    idCategoria = 8, idMarca = 8 },

                new ProductoTable { idProducto = 9, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 1201.90m, precioOferta = null,
                    cantidad = 23, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    idCategoria = 1, idMarca = 4 },

                new ProductoTable { idProducto = 10, productoNombre = "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"", precio = 3201.90m, precioOferta = 2980.90m,
                    cantidad = 12, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01",
                    idCategoria = 2, idMarca = 2 },

                new ProductoTable { idProducto = 11, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 5201.90m, precioOferta = null,
                    cantidad = 11, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    idCategoria = 3, idMarca = 4 },

                new ProductoTable { idProducto = 12, productoNombre = "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"", precio = 6201.90m, precioOferta = 4580.90m,
                    cantidad = 45, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b",
                    imagen03 = null,
                    imagen04 = null,
                    idCategoria = 2, idMarca = 4 },

                new ProductoTable { idProducto = 13, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 8301.90m, precioOferta = null,
                    cantidad = 67, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    idCategoria = 5, idMarca = 5 },

                new ProductoTable { idProducto = 14, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 3201.90m, precioOferta = 2580.90m,
                    cantidad = 98, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01",
                    idCategoria = 6, idMarca = 6 },

                new ProductoTable { idProducto = 15, productoNombre = "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"", precio = 7901.90m, precioOferta = null,
                    cantidad = 77, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    idCategoria = 2, idMarca = 7 },

                new ProductoTable { idProducto = 16, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 41.90m, precioOferta = 30.90m,
                    cantidad = 54, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01",
                    idCategoria = 8, idMarca = 8 },

                new ProductoTable { idProducto = 17, productoNombre = "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"", precio = 201.90m, precioOferta = null,
                    cantidad = 65, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    idCategoria = 2, idMarca = 1, },

                new ProductoTable { idProducto = 18, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 9001.90m, precioOferta = 8580.90m,
                    cantidad = 32, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01",
                    idCategoria = 2, idMarca = 2 },

                new ProductoTable { idProducto = 19, productoNombre = "LAPTOP HP 15-FB2002LA AMD RYZEN 5 8645HS 8GB 512GB SSD RTX 3050 15.6\"", precio = 4201.90m, precioOferta = null,
                    cantidad = 14, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto32.png?alt=media&token=066fef94-966c-436a-b888-5e03447a9ad8",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2FProducto31.png?alt=media&token=e9913773-a042-4aa9-baff-45715bf47d20",
                    imagen03 = null,
                    imagen04 = null,
                    idCategoria = 3, idMarca = 3 },

                new ProductoTable { idProducto = 20, productoNombre = "MONITOR CAIXUN 22' C22X3F PLANA FULL HD PANEL IPS 75HZ 14MS", precio = 201.90m, precioOferta = 180.90m,
                    cantidad = 25, estado = true,
                    detalle = "Procesador: AMD Ryzen Tamaño de la pantalla: 15 Disco duro: 512GB SSD Disco duro sólido: 512GB SSD Núcleos del procesador: Quad core Memoria total: 16GB Velocidad del procesador: 2.8 GHz Velocidad máxima del procesador: 4.3 GHz Modelo del procesador: AMD Ryzen 5 7520U Generación del procesador: Serie 7000 Memoria RAM: 16GB RAM expandible: No Tarjeta de video: No Aplica Capacidad de la tarjeta de video: No aplica Tipo de pantalla: LCD Marca: Lenovo Modelo: 82VG00GWLM Tipo: Notebook Nombre comercial: IdeaPad 1 15AMN7 Hecho en: China Garantía del proveedor: 1 Año Condición del producto: Nuevo",
                    imagen01 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct01.png?alt=media&token=854dd6ba-432a-4283-87c7-dd5e695e4831",
                    imagen02 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct22.png?alt=media&token=1b3f7141-c5eb-4120-a3b9-01f4cc12ed8b",
                    imagen03 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct23.png?alt=media&token=a3397a80-18ef-4419-b9e4-8d3f62836629",
                    imagen04 = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/productos%2Fproduct24.png?alt=media&token=1ea70b03-b2a0-4638-9524-e44574dffd01",
                    idCategoria = 4, idMarca = 4 }

            );

            //Banners 
            modelBuilder.Entity<BannerTable>().HasData(
                new BannerTable { idBanner = 1, imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/banners%2FBannerPrincipal.png?alt=media&token=67c05c02-3c7f-4542-b556-fb29f2aaa50e", enlace = "http://localhost:4200/categoria/1", estado = true },
                new BannerTable { idBanner = 2, imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/banners%2FBannerLaptops.png?alt=media&token=63ee6e5d-97bf-4456-b167-5593d6d5b5a9", enlace = "http://localhost:4200/categoria/8", estado = true },
                new BannerTable { idBanner = 3, imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/banners%2FBannerCelulares.png?alt=media&token=3710d7bc-3821-4402-b4be-31dd4a34a806", enlace = "http://localhost:4200/marca/1", estado = true },
                new BannerTable { idBanner = 4, imagen = "https://firebasestorage.googleapis.com/v0/b/image-upload-458ca.appspot.com/o/banners%2FBannerLaptops.png?alt=media&token=63ee6e5d-97bf-4456-b167-5593d6d5b5a9", enlace = "http://localhost:4200/producto/1", estado = true }
            );

            //Administrador -----------------------
            modelBuilder.Entity<AdministradorTable>().HasData(
                new AdministradorTable
                {
                    idAdministrador = 1,
                    nombres = "Luis Rosales Rosales",
                    telefonoMovil = "983234873",
                    estado = true,
                    email = "luis@fibertel.com",
                    password = "123456789"
                }
            );

            #endregion Tienda

            // MOVIMIENTOS -----------------
            #region Movimientos

            //Cliente 
            modelBuilder.Entity<ClienteTable>().HasData(
                new ClienteTable { idCliente = 1, razonSocial = "Maicol Linares Rosales", email = "maicolrosas@gmail.com", 
                    telefonoMovil = "902393648", tipoDocumento = "DNI", numeroDocumento = "23171287",
                    direccionFiscal = null },

                new ClienteTable { idCliente = 2, razonSocial = "Ana Rosas Rosas", email = "anaflores@gmail.com", 
                    telefonoMovil = "902383983", tipoDocumento = "RUC", numeroDocumento = "201203944584544",
                    direccionFiscal = "Junin, Huancayo, Huancayo Jr Loreto 190"}
            );

            //Personal 
            modelBuilder.Entity<PersonalTable>().HasData(
                new PersonalTable { idPersonal = 1, nombres = "Andy", apellidos = "Merino Zalasar", numeroDocumento = "73123465",
                rol = "Responsable de Envio", contacto = "982332873", inicioOperacion = new DateTime(2024, 09, 20), finOperacion = null },  
                
                new PersonalTable { idPersonal = 2, nombres = "Luis Felipe", apellidos = "Merino Rosas", numeroDocumento = "70123465",
                rol = "Responsable de Envio", contacto = "982332873", inicioOperacion = new DateTime(2024, 09, 20), finOperacion = null
                }    
                
            );

            //Recojo 
            modelBuilder.Entity<RecojoTable>().HasData(
                new RecojoTable { idRecojo = 1, fechaListo = new DateTime(2024, 09, 20),
                fechaEntrega = new DateTime(2024, 09, 22), responsableEntrega = null }
            );

            //Envio
            modelBuilder.Entity<EnvioTable>().HasData(
                new EnvioTable { idEnvio = 1, region = "Lima", provincia = "Lima", distrito = "Lima", localidad = "Lima Lima Lima",
                    calle = "Av Rosales", nDomicilio = "230", codigoPostal = "202025", 
                    fechaEnvio = new DateTime(2024, 09, 20), fechaEntrega = null, responsableEntrega = "Felipe Sarmiento - 72342312", idPersonal = 1 }
            );

            //Pedido
            modelBuilder.Entity<PedidoTable>().HasData(
                new PedidoTable { idPedido = 1, fechaPedido = new DateTime(2024, 09, 24), fechaCancelado = null, 
                tipoPedido = "Envio a Domicilio", estado = "Enviado", total = 5010.90m, idCliente = 1, idPersonal = 1,
                idEnvio = 1, idRecojo = null},

                new PedidoTable { idPedido = 2, fechaPedido = new DateTime(2024, 09, 24), fechaCancelado = null, 
                tipoPedido = "Recojo en Tienda", estado = "Entregado", total = 5010.90m, idCliente = 2, idPersonal = 1,
                idEnvio = null, idRecojo = 1}
            );

            //Detalle Pedido
            modelBuilder.Entity<DetallePedidoTable>().HasData(
                new DetallePedidoTable { idDetallePedido = 1, cantidad = 1, precioUnitario = 2300.90m, 
                    precioDescuento = 2000.90m, subTotal = 2000.90m, idProducto = 3, idPedido = 1 },

                new DetallePedidoTable { idDetallePedido = 2, cantidad = 5, precioUnitario = 2300.90m, 
                    precioDescuento = 2000.90m, subTotal = 2000.90m, idProducto = 12, idPedido = 2 },

                new DetallePedidoTable { idDetallePedido = 3, cantidad = 2, precioUnitario = 2300.90m, 
                    precioDescuento = 2000.90m, subTotal = 2000.90m, idProducto = 7, idPedido = 2 }
            );

            //Comprobante
            modelBuilder.Entity<ComprobanteTable>().HasData(
                new ComprobanteTable { idComprobante = 1, tipoComprobante = "Boleta", fechaEmision = new DateTime(2024, 09, 24), idPedido = 1},
                new ComprobanteTable { idComprobante = 2, tipoComprobante = "Factura", fechaEmision = new DateTime(2024, 09, 25), idPedido = 2 }
            );

            #endregion Movimientos

        }   
    }
}
