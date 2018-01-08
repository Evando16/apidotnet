using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(mapper =>
            {
                mapper.CreateMap<ClienteViewModel, Cliente>();
                mapper.CreateMap<ProdutoViewModel, Produto>();

                mapper.CreateMap<Cliente, ClienteViewModel>();
                mapper.CreateMap<Produto, ProdutoViewModel>();
            });
        }
    }
}