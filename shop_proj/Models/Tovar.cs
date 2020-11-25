using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop_proj.Models
{
    public class Tovar
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введіть назву")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Довжина рядка повинна бути від 3 до 30 символів")]
        public string Name { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required(ErrorMessage = "Введіть бренд")]
        public string Brend { get; set; }
        [Required(ErrorMessage = "Введіть матеріал")]
        public string Material { get; set; }

        [Required(ErrorMessage = "Введіть ціну")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Введіть модель")]
        public string Model { get; set; }//худі, пуловер,(види кофт)
        public List<Kind> Kinds { get; set; }

     /*   public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.Name))
            {
                errors.Add(new ValidationResult("Введіть назву товару"));
            }
            if (string.IsNullOrWhiteSpace(this.Brend))
            {
                errors.Add(new ValidationResult("Введіть бренд товару!"));
            }
            if (string.IsNullOrWhiteSpace(this.Material))
            {
                errors.Add(new ValidationResult("Введіть матеріал товару!"));
            }
            if (string.IsNullOrWhiteSpace(this.Model))
            {
                errors.Add(new ValidationResult("Введіть модель товару!"));
            }
            if (double.IsNaN(this.Price))
            {
                errors.Add(new ValidationResult("Введіть ціну!"));
            }
            if (this.CategoryId < 0 || this.CategoryId > 120)
            {
                errors.Add(new ValidationResult("Недопустимый возраст!"));
            }

            return errors;
        }*/
    }
    
}
