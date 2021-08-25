using Customer_Pagination.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer_Pagination.Services
{
   public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
