using Microsoft.AspNetCore.Mvc;

namespace registration_form.Models.Home
{
    public class FormModel
    {
        [FromForm(Name = "signup-username")]
        public String UserName { get; set; }

        [FromForm(Name = "signup-email")]
        public String UserEmail { get; set; }
    }
}
