using Microsoft.AspNetCore.Identity;

namespace Poznamky.Models
{
    public class Uzivatel : IdentityUser
    {
        public ICollection<Poznamka> Poznamky { get; set; }
    }
}