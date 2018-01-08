using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Context;
using ProjetoModeloDDD.Infra.Data.Repositories;
using SimpleInjector;

namespace ProjetoModelDDD.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ProjetoModeloContext>(Lifestyle.Scoped);

            container.Register<IProdutoRepository, ProdutoRepository>(Lifestyle.Scoped);
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);

        }
    }
}
