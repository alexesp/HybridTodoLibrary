using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace RazorLibrary.Models
{
    public class TodoModel
    {
        [SupplyParameterFromForm]
        public string TodoItem { get; set; } = string.Empty;
        public bool IsComplete { get; set; }
    }
}
