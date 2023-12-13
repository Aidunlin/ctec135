/*
Author: Aidan Linerud and Keziah Njoroge
Date: 11/15/2023
Assignment: Final Project
*/

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace AutoRental.Pages
{
	public class ReservationModel : PageModel
	{
		[BindProperty(SupportsGet = true)]
		public Models.Rentals? Rentals { get; set; } = null;

		public void OnGet()
		{
			string? rentals = HttpContext.Session.GetString("RentalsData");
			if (rentals?.Length > 0)
			{
				Rentals = JsonConvert.DeserializeObject<Models.Rentals>(rentals);
			}
			else
			{
				Rentals = null;
			}
		}

		public SqlDataReader AutoTypesReader()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = new SqlConnection();
			cmd.Connection.ConnectionString = $@"Data Source = (localDB)\MSSQLLocalDB;AttachDBFilename = {Path.GetFullPath(@"App_Data\AutoRental.mdf")}";
			cmd.CommandText = "SELECT AutoType, DailyRate FROM AutoTypes";
			cmd.Connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			return reader;
		}

		public SqlDataReader DiscountReader()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = new SqlConnection();
			cmd.Connection.ConnectionString = $@"Data Source = (localDB)\MSSQLLocalDB;AttachDBFilename = {Path.GetFullPath(@"App_Data\AutoRental.mdf")}";
			cmd.CommandText = "SELECT Category, DiscountPercent FROM Discont";
			cmd.Connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			return reader;
		}
	}
}
