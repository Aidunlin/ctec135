/**
 * Author: Aidan Linerud
 * Date: 11/19/2023
 * Assignment: Razor Pages Tutorial
 */

using System.Data.SqlClient;

namespace Theater_RP.Models
{
	public class Reservation
	{
		public string Performance { get; set; } = "";
		public DateTime PerformDate { get; set; }
		public string Zone { get; set; } = "";
		public bool MemberStatus { get; set; }
		public int Tickets { get; set; }
		public int Snacks { get; set; }

		public decimal BasePrice()
		{
			decimal basePrice = 0;

			SqlCommand cmdPerformance = new SqlCommand();
			cmdPerformance.Connection = new SqlConnection();
			cmdPerformance.Connection.ConnectionString = $@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = {Path.GetFullPath(@"App_Data\Theater.mdf")}";
			cmdPerformance.CommandText = $"SELECT BasePrice FROM Performance WHERE PerformanceName='{Performance}'";
			cmdPerformance.Connection.Open();

			if (cmdPerformance.ExecuteScalar() != null)
				basePrice = (decimal)cmdPerformance.ExecuteScalar();

			return basePrice;
		}

		public decimal ZonePrice()
		{
			decimal zonePrice = 0;

			switch (Zone.ToLower())
			{
				case "suite":
					zonePrice = 40;
					break;
				case "premium":
					zonePrice = 25;
					break;
				case "circle":
					zonePrice = 10;
					break;
				case "balcony":
					zonePrice = 0;
					break;
				case "orchestra":
					zonePrice = 22;
					break;
				default:
					break;
			}

			return zonePrice;
		}

		public decimal Discount()
		{
			return MemberStatus ? 10 : 0;
		}

		public decimal SnackCost()
		{
			return Snacks * 5;
		}

		public decimal TotalCost()
		{
			return (BasePrice() + ZonePrice() - Discount()) * Tickets + SnackCost();
		}
	}
}
