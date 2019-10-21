using Microsoft.EntityFrameworkCore;
using Rx.Core.Data;
using S2CDataMigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2CDataMigration.Web.Domain
{
    
    public class GentuUow : CoreUnitOfWork, IGentuUow
    {
        public GentuUow(IGentuContext gentuContext, IRepositoryProvider repositoryProvider)
        {
            base.SetContextRepository(gentuContext, repositoryProvider);
        }

        protected override void StateChange<TEntity>(TEntity entity, EntityState entityState)
        {
            base.StateChange<TEntity>(entity, entityState);
        }
    }

    public interface IGentuUow : ICoreUnitOfWork
    {
    }
}
