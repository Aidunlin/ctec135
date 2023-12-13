using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace Theater_RP.Pages
{
	public class ReservationModel : PageModel
	{
		[BindProperty(SupportsGet = true)]
		public Models.Reservation? ReservationData { get; set; } = null;

		public void OnGet()
		{
			string? strReservation = HttpContext.Session.GetString("StrReservation");
			if (strReservation != null)
			{
				ReservationData = JsonConvert.DeserializeObject<Models.Reservation>(strReservation);
			}
		}

		public SqlDataReader PerformanceReader()
		{
			SqlCommand cmdPerformance = new SqlCommand();
			cmdPerformance.Connection = new SqlConnection();
			cmdPerformance.Connection.ConnectionString = $@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = {Path.GetFullPath(@"App_Data\Theater.mdf")}";
			cmdPerformance.CommandText = "SELECT PerformanceName,BasePrice FROM Performance";
			cmdPerformance.Connection.Open();

			SqlDataReader drPerformance = cmdPerformance.ExecuteReader();
			return drPerformance;
		}

		public SqlDataReader ZoneNameReader()
		{
			SqlCommand cmdPerformance = new SqlCommand();
			cmdPerformance.Connection = new SqlConnection();
			cmdPerformance.Connection.ConnectionString = $@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = {Path.GetFullPath(@"App_Data\Theater.mdf")}";
			cmdPerformance.CommandText = "SELECT ZoneName FROM Zone";
			cmdPerformance.Connection.Open();

			SqlDataReader drPerformance = cmdPerformance.ExecuteReader();
			return drPerformance;
		}
	}
}
