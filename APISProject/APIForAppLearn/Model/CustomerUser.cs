using System.ComponentModel.DataAnnotations.Schema;

namespace APIForAppLearn.Model
{
	public class CustomerUser
	{
		public long ApplicationUserId { get; private set; }

		public string FirstName { get; private set; }

		public string LastName { get; private set; }

		public string ProfilePictureStoragePath { get; private set; }

		//public CustomerUserStatus Status { get; private set; }

		//public CustomerUserVerificationStatus VerificationStatus { get; private set; }

		public string EmailVerificationCode { get; private set; }

		public string PhoneNumberVerificationCode { get; private set; }

		public string ForgotPasswordCode { get; private set; }

		public string PanCardNumber { get; private set; }

		public string PanCardStoragePath { get; private set; }

		// Billing Details
		public string BillingName { get; private set; }

		public string BillingGSTNumber { get; private set; }

		public string BillingAddress { get; private set; }

		public string BillingAddress2 { get; private set; }

		public string BillingCity { get; private set; }

		public string BillingState { get; private set; }

		public int? BillingPinCode { get; private set; }

		public string Source { get; private set; }

		public string DeviceModel { get; private set; }

		public DateTime CreatedDateTimeUtc { get; private set; }

		public DateTime UpdatedDateTimeUtc { get; private set; }

		// Id Proof Details

		public bool? IsDeleted { get; private set; }

		public string IDProofStoragePath { get; private set; }

		public string CustomerDocumentType { get; private set; }

		public string IDProofNumber { get; private set; }


		[ForeignKey(nameof(ApplicationUserId))]
		public virtual ApplicationUser ApplicationUser { get; set; }

	}
}
