using MatBlazor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.ViewModel
{
    public class CommodityModel
    {
        [Required] public string Name { get; set; }
        [Required] public string Category { get; set; }
        public string Url { get; set; }
        [Required] public Import Import {get; set;} // 등록목적
       
        [Required] public IMatFileUploadEntry MatFile { get; set; }
       

        public static ValidationResult ValidateMFA(string mfa, ValidationContext vc)
        {
            return string.Equals("654321", mfa)
                ? ValidationResult.Success
                : new ValidationResult("Incorrect MFA OTP", new[] { vc.MemberName });
        }

        public static ValidationResult RequiredDateTime(DateTime value, ValidationContext vc)
        {
            return value > DateTime.MinValue
                ? ValidationResult.Success
                : new ValidationResult($"The {vc.MemberName} field is required.", new[] { vc.MemberName });
        }
    }
    
   public enum Import { Import = 0, Agency = 1 }

}
