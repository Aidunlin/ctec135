using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Theater_RP.Models;

namespace Theater_RP.Pages
{
	public class ConfirmationModel : PageModel
	{
		[BindProperty]
		public Reservation ReservationData { get; set; }

		public void OnPost()
		{
			// Serialize and store in session data
			string strReservation = JsonConvert.SerializeObject(ReservationData);
			HttpContext.Session.SetString("StrReservation", strReservation);
		}
	}
}
