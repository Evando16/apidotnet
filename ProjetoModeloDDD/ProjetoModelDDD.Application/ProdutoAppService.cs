using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            this.produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return this.produtoService.BuscarPorNome(nome);
        }
    }
}
