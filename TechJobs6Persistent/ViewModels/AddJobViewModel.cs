using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{

    public class AddJobViewModel
    {
        public string Name {get; set; }
        public int SelectedId {get; set; }
        public List<SelectListItem> Employers {get; set;}
    
}
}


