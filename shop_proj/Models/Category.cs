using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop_proj.Models
{
    public class Category : IValidatableObject
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name = "Назва")]
        [Required]
        public string Name { get; set; }
        [ScaffoldColumn(false)]
        public List<Tovar> Tovars { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.Name))
            {
                errors.Add(new ValidationResult("Введите имя!"));
            }
            return errors;

        }
    }
}
