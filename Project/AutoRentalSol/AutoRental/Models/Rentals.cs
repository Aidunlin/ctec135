/*
Author: Aidan Linerud and Keziah Njoroge
Date: 11/15/2023
Assignment: Final Project
*/

using System.Data.SqlClient;

namespace AutoRental.Models
{
	public class Rentals
	{
		// Properties
		public string AutoType { get; set; }
		public DateTime StartDate { get; set; }
		public string Category { get; set; }
		public bool InsuranceStatus { get; set; }
		public int Days { get; set; }

		// methods
		public decimal DailyRate()
		{
			decimal dailyRate = 0;
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = new SqlConnection();
			cmd.Connection.ConnectionString = $@"Data Source = (localDB)\MSSQLLocalDB;AttachDBFilename = {Path.GetFullPath(@"App_Data\AutoRental.mdf")}";
			cmd.CommandText = $"SELECT DailyRate FROM AutoTypes WHERE AutoType = '{AutoType}'";
			cmd.Connection.Open();

			// use executescalar to get daily rate
			if (cmd.ExecuteScalar() != null)
			{
				dailyRate = (decimal)cmd.ExecuteScalar();
			}
			return dailyRate;
		}

		public decimal Discount()
		{
			return Category switch
			{
				"BestRate" => 0.05m,
				"Government" => 0.15m,
				"Business" => 0.10m,
				"Senior" => 0.20m,
				_ => 0m
			};
		}

		public decimal Insurance()
		{
			return InsuranceStatus ? 10 : 0;
		}

		public decimal CostPerDay()
		{
			return DailyRate() + Insurance() - (Discount() * DailyRate());
		}

		public decimal TotalCost()
		{
			return CostPerDay() * Days;
		}
	}
}
