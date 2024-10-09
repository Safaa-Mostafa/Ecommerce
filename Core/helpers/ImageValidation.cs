using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.helpers
{
    public class ImageValidation:ValidationAttribute
    {
        private readonly int _maxLength;
        public ImageValidation(int maxLength)
        {
            _maxLength = maxLength;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var Collection = value as ICollection<Image>;
                if(Collection != null)
            {
                foreach(var image in Collection)
                {
                    if (image.Url.Length > _maxLength)
                    {
                        return new ValidationResult($"Image URL cannot exceed {_maxLength} characters.");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}
