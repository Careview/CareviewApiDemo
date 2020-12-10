using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels
{
    public class PaginatedResult<T>
    {
        public List<T> Result { get; set; }

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
    }
}
