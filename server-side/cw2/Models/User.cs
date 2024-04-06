using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace cw2;

public class User
{
    
    public int Id { get; set; }
    
    [DisplayName("Podaj imię")]
    [Required(ErrorMessage = "Podaj poprawne imię")]
    public string? Firstname { get; set; }
    
    [DisplayName("Podaj nazwisko")]
    [Required(ErrorMessage = "Podaj poprawne nazwisko")]
    public string? Lastname { get; set; }
    
    [DisplayName("Podaj wiek")]
    [Required(ErrorMessage = "Podaj poprawny wiek")]   
    public int? Age { get; set; }
}
