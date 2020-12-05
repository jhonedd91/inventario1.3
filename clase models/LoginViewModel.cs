public class LoginViewModel
{
    [Display(Name = "Correo electr�nico")]
     [Required(ErrorMessage = "Este campo es requerido.")]
    [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
        ErrorMessage = "Direcci�n de Correo electr�nico incorrecta.")]
    [StringLength(100, ErrorMessage = "Longitud m�xima 100")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Display(Name = "Contrase�a")]
    [Required(ErrorMessage = "Este campo es requerido.")]
    [StringLength(15, ErrorMessage = "Longitud entre 6 y 15 caracteres.",
                  MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Recordarme")]
    public bool RememberMe { get; set; }
}