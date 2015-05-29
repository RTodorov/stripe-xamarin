using System;
using ObjCRuntime;

namespace Stripe.iOS
{
	public enum STPErrorCode : int /* nint */ {
		STPConnectionError = 40,
		STPInvalidRequestError = 50,
		STPAPIError = 60,
		STPCardError = 70,
		STPCheckoutError = 80
	}

	[Native]
	public enum STPCardFundingType : long /* nint */ {
		Debit,
		Credit,
		Prepaid,
		Other
	}

	[Native]
	public enum STPCardBrand : long /* nint */ {
		Visa,
		Amex,
		MasterCard,
		Discover,
		JCB,
		DinersClub,
		Unknown
	}

	[Native]
	public enum STPPaymentStatus : long /* nint */ {
		Success,
		Error,
		UserCancelled
	}

	[Native]
	public enum STPBackendChargeResult : long /* nint */ {
		Success,
		Failure
	}
}
