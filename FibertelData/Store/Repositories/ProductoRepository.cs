using FibertelDomain.Auth.Services;
using FibertelDomain.Store.Repositories;
using FibertelDomain.Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibertelData.Store.Repositories
{
    public class ProductoRepositoryImpl : IProductoRepository
    {
        private readonly IProductoService _producto;
        private readonly ICategoriaService _categoria;
        private readonly IMarcaService _marca;
        private readonly IAdministradorService _administrador;
        private readonly IBannerService _banner;

        public ProductoRepositoryImpl (
            ICategoriaService categoria,
            IMarcaService marca,
            IProductoService producto,
            IAdministradorService administrador,
            IBannerService banner
        )
        {
            _producto = producto;
            _categoria = categoria;
            _marca = marca;
            _administrador = administrador;
            _banner = banner;
        }

        public IMarcaService marca()
        {
            return _marca;
        }

        public ICategoriaService categoria()
        {
            return _categoria;
        }

        public IProductoService producto()
        {
            return _producto;
        }

        public IAdministradorService administrador()
        {
            return _administrador;
        }

        public IBannerService banner()
        {
            return _banner;
        }

    }
}
