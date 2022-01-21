using Microsoft.AspNetCore.Identity;

namespace TaskManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        //Navigation Properties
        public List<Comment>? Comments { get; set; }
        public List<Ticket>? Tickets { get; set; }
        public List<Project_ApplicationUser>? Project_ApplicationUser { get; set; }
    }
}
