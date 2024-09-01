using CQRS_lib.CQRS.Queries;
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
    public class GetItemsListHandler : IRequestHandler<GetAllItemsQuery, List<Items>> 
    {
        App_Db_Context _db;
        public GetItemsListHandler(App_Db_Context db)
        {
            _db = db;
        }
        public async Task<List<Items>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_db.Items.ToList());
        }
    }
}
