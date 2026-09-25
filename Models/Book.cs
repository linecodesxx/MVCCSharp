using System.ComponentModel.DataAnnotations;

namespace mvcapp.Models;

public class Book
{
    [Required(ErrorMessage = "Введите название книги.")]
    [StringLength(200, ErrorMessage = "Название книги не должно превышать 200 символов.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Введите автора книги.")]
    [StringLength(200, ErrorMessage = "Имя автора не должно превышать 200 символов.")]
    public string Author { get; set; } = string.Empty;
}
