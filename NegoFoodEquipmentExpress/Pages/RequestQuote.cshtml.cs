using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace NegoFoodEquipmentExpress.Pages
{
    public class RequestQuoteModel : PageModel
    {
        [BindProperty]
        public string ProductName { get; set; }

        [BindProperty]
        public string CustomerName { get; set; }

        [BindProperty]
        [EmailAddress]
        public string Email { get; set; }

        [BindProperty]
        public string Message { get; set; }

        public IActionResult OnPost()
        {
            // Handle form submission here (e.g., send email, save to database)
            // You can access the form data using this.ProductName, this.CustomerName, etc.
            // Redirect to a thank you page or return a message
            return RedirectToPage("/RequestQuoteConfirmation");
        }
    }
}
