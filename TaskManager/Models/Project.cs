using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Project Name")]
        [Required(ErrorMessage = "Project Name is required.")]
        [StringLength(TaskManagerConstants.MAX_PROJ_NAME_LENGTH, ErrorMessage = "Project Name must be less than 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Project Description")]
        [Required(ErrorMessage = "Project Description is required.")]
        [StringLength(TaskManagerConstants.MAX_PROJ_DESCRIPTION_LENGTH, ErrorMessage = "Project Description must be less than 500 characters")]
        public string? Description { get; set; }

        public bool IsActive { get; set; }

        //Navigation Properties
        [Display(Name = "Project Manager UserId")]
        [Required(ErrorMessage = "Project Manager UserId is required")]
        [ForeignKey("ApplicationUserId")]
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public List<Ticket?> Tickets { get; set; }
        //This is list all users who have access to the project
        public List<Project_ApplicationUser> Project_ApplicationUser { get; set; }
    }
}
