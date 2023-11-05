namespace APIForAppLearn.Model
{
	public class ApplicationUser
	{
		public DateTime? LastLoginDateTimeUtc { get; set; }

		public DateTime CreatedDateTimeUtc { get; set; }

		public DateTime UpdatedDateTimeUtc { get; set; }
		public string UserReferralCode { get; set; }
		public string Password { get; set; }
		public string ResetPasswordCode { get; set; }
		public string DeviceType { get; set; }
		public string FCMToken { get; set; }
		public string UserType { get; set; }
	}
}
