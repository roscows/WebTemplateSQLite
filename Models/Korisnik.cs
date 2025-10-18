namespace WebTemplate.Models;

public class Korisnik
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Ime { get; set; }
    
    [Required]
    public string Email { get; set; }
}