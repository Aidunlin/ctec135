/*
Author: Aidan Linerud and Keziah Njoroge
Date: 11/18/2023
Assignment: Final Project
*/

using AutoRental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace AutoRental.Pages
{
	public class ConfirmationModel : PageModel
	{
		[BindProperty]
		public Rentals RentalsData { get; set; }

		public void OnPost()
		{
			// Serialize and store in session data
			HttpContext.Session.SetString(
				"RentalsData",
				JsonConvert.SerializeObject(RentalsData)
			);
		}
	}
}
