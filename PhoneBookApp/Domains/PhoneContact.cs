using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Domains
{
    public class PhoneContact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PhoneContactId { get; set; }

        [Display(Name = "شماره موبایل")]
        [StringLength(11, ErrorMessage = "{0} شماره موبایل راصحیح وارد کنید", MinimumLength = 11)]
        [Required(ErrorMessage = "{0} مقدار اجباری می باشد")]

        public string PhoneNumber { get; set; }
        public Guid ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
