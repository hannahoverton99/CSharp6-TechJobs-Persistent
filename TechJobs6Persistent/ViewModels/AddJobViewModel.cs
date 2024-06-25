using System;
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace TechJobs6Persistent.ViewModels{


public class AddJobViewModel
{
        [Required(ErrorMessage = "Name of job is required.")]
        public string? JobName {get; set;}

        public int? SelectedId {get; set;}

        public List<SelectListItem>? Employers { get; set; }
}
}