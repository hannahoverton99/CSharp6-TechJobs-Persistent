using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{

    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name of job is required.")]
        public string? Name {get; set; }
        public int SelectedId {get; set; }
        public List<SelectListItem>? Employers {get; set;}

        public AddJobViewModel(List<Employer>employers)
        {
            Employers= new List<SelectListItem>();

            foreach (var employer in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value=employer.Id.ToString(),
                        Text = employer.Name
                    });
            }
        }
    public AddJobViewModel()
    {

    }
}
}




