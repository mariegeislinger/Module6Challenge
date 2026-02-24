using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models; 

namespace Portfolio.Pages;

public class IndexModel : PageModel


{
    public Project[] Projects { get; set; } = Array.Empty<Project>();
        public Skill[] Skills { get; set; } = Array.Empty<Skill>();
    public void OnGet()
    {
        //Create Arrays 3 Projects 
         Projects = new Project[]
        {
            new Project("Food Truck Festival", "Organized and managed food truck festival", 2022),
            new Project("CRM Implementation", "Led implementation of new CRM system", 2023),
            new Project("Run-a-Mile-athon in Louis Vuitton", "Organized a fun run in high heels", 2024)
            
        };

        //Create Arrays 5 Skills
        Skills = new Skill[]
        {
            new Skill("SQL", 4),
            new Skill("Project Management",  4),
            new Skill("C#", 3),
            new Skill("Database Design", 4),
            new Skill("Coffee Button Pusher", 5)
        };
    }
}

