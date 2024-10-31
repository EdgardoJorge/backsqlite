using FibertelData.Sources.BaseDeDatos.Tables;
using FibertelData.Sources.BaseDeDatos.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibertelDomain.Store.Models;

namespace FibertelData.Sources.BaseDeDatos
{
    public class FibertelDbContext : DbContext 
    {
        public FibertelDbContext( DbContextOptions<FibertelDbContext> opts ) : base(opts) 
        { 


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            //Uno a Muchos -------------------------------------

            //Categoria A Productos
            modelBuilder.Entity<CategoriaTable>()
                .HasMany<ProductoTable>()
                .WithOne()
                .HasForeignKey(p => p.idCategoria)
                .IsRequired();

            //Marca a Productos
            modelBuilder.Entity<MarcaTable>()
                .HasMany<ProductoTable>()
                .WithOne()
                .HasForeignKey(p => p.idMarca)
                .IsRequired();

            //Personal a Pedido
            modelBuilder.Entity<PersonalTable>()
                .HasMany<PedidoTable>()
                .WithOne()
                .HasForeignKey(p => p.idPersonal)
                .IsRequired(false);

            //Personal a Envio 
            modelBuilder.Entity<PersonalTable>()
                .HasMany<EnvioTable>()
                .WithOne()
                .HasForeignKey(e => e.idPersonal)
                .IsRequired(false);

            //DetallePedido a Producto
            modelBuilder.Entity<DetallePedidoTable>()
                .HasOne(dp => dp.Producto)
                .WithMany(p => p.DetallePedidos)
                .HasForeignKey(dp => dp.idProducto)
                .IsRequired();

            //DetallePedido a Pedido 
            modelBuilder.Entity<DetallePedidoTable>()
                .HasOne(dp => dp.Pedido)
                .WithMany(p => p.DetallePedidos)
                .HasForeignKey(dp => dp.idPedido)
                .IsRequired();

            //Uno a Uno ------------------------------------

            //Cliente a Pedido
            //modelBuilder.Entity<ClienteTable>()
            //    .HasOne<PedidoTable>()
            //    .WithOne()
            //    .HasForeignKey<PedidoTable>(p => p.idCliente)
            //    .IsRequired();

            modelBuilder.Entity<PedidoTable>()
                .HasOne(p => p.Cliente)
                .WithOne(c => c.Pedido)
                .HasForeignKey<PedidoTable>(p => p.idCliente)
                .IsRequired();

            //Envio a Pedido
            modelBuilder.Entity<PedidoTable>()
                .HasOne(p => p.Envio)
                .WithOne(e => e.Pedido)
                .HasForeignKey<PedidoTable>(p => p.idEnvio)
                .IsRequired(false);

            modelBuilder.Entity<PedidoTable>()
               .HasOne(p => p.Recojo)
               .WithOne(e => e.Pedido)
               .HasForeignKey<PedidoTable>(p => p.idRecojo)
               .IsRequired(false);

            //Pedido a Comprobante
            modelBuilder.Entity<PedidoTable>()
                .HasOne<ComprobanteTable>()
                .WithOne()
                .HasForeignKey<ComprobanteTable>(c => c.idPedido)
                .IsRequired();
        }

        #region Tables Tienda 
        public DbSet<ProductoTable> productos { get; set; }
        public DbSet<CategoriaTable> categorias { get; set; }
        public DbSet<MarcaTable> marcas { get; set; }
        public DbSet<AdministradorTable> administradors { get; set; }
        public DbSet<BannerTable> banners { get; set; }
        #endregion Tables Tienda

        #region Tables Movimientos 
        public DbSet<DetallePedidoTable> detallePedidos { get; set; }
        public DbSet<EnvioTable> envios { get; set; }
        public DbSet<PedidoTable> pedidos { get; set; }
        public DbSet<RecojoTable> recojos { get; set; }
        public DbSet<ClienteTable> clientes { get; set; }
        public DbSet<ComprobanteTable> comprobantes { get; set; }
        public DbSet<PersonalTable> personals { get; set; }
        #endregion Tables Movimientos

    }
}
