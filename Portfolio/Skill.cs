using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
public class Skill
{
    [Range(1,5)]
    public string Name { get; set; }
    public int ProficiencyLevel{ get; set; }
    

    public Skill(string name, int proficiencylevel)
    {
        Name = name;
        ProficiencyLevel = proficiencylevel;
        
    }
}
}