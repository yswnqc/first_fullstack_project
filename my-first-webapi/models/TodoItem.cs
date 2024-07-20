using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_first_webapi.models
{
    public class TodoItemDTO
    {
        public string Title { get; set; }//= string.Empty; 就不会报错了
        public bool IsDone { get; set; }
    }
}