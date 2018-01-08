using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity: class
    {
        private readonly IServiceBase<TEntity> serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            this.serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            this.serviceBase.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return this.serviceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            this.serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            this.serviceBase.Update(obj);
        }

        public void Dispose()
        {
            this.serviceBase.Dispose();
        }
    }
}
