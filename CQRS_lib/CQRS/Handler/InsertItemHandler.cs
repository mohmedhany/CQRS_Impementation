using CQRS_lib.CQRS.Commands;
using CQRS_lib.Data;
using CQRS_lib.Data.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_lib.CQRS.Handler
{
    public class InsertItemHandler : IRequestHandler<InsertItemCommand ,Items>
    {
        App_Db_Context _dbContext;
        public InsertItemHandler(App_Db_Context dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Items> Handle(InsertItemCommand request, CancellationToken cancellationToken)
        {
            await _dbContext.Items.AddAsync(request.item);
              _dbContext.SaveChanges();
            return await Task.FromResult(request.item);
        }
    }
}
