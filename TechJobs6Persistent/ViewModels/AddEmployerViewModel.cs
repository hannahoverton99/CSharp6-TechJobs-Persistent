using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels{

public class AddEmployerViewModel
{
        [Required(ErrorMessage = "Name of employer is required.")]
        public string? Name {get; set;}

        [Required(ErrorMessage = "Location of employer is required.")]
        public string? Location {get; set;}
}
}