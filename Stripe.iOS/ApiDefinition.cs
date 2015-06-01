using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using PassKit;

namespace Stripe.iOS
{
	// @interface Stripe : NSObject
	[BaseType (typeof (NSObject))]
	interface Stripe {

		// +(void)setDefaultPublishableKey:(NSString *)publishableKey;
		[Static, Export ("setDefaultPublishableKey:")]
		void SetDefaultPublishableKey (string publishableKey);

		// +(NSString *)defaultPublishableKey;
		[Static, Export ("defaultPublishableKey")]
		string DefaultPublishableKey ();
	}

	// @interface STPAPIClient : NSObject
	[BaseType (typeof (NSObject))]
	interface STPAPIClient {

		// -(instancetype)initWithPublishableKey:(NSString *)publishableKey;
		[Export ("initWithPublishableKey:")]
		IntPtr Constructor (string publishableKey);

		// @property (copy, nonatomic) NSString * publishableKey;
		[Export ("publishableKey")]
		string PublishableKey { get; set; }

		// @property (nonatomic) NSOperationQueue * operationQueue;
		[Export ("operationQueue")]
		NSOperationQueue OperationQueue { get; set; }

		// +(instancetype)sharedClient;
		[Static, Export ("sharedClient")]
		STPAPIClient SharedClient ();
	}

	// @interface BankAccounts (STPAPIClient)
	[Category]
	[BaseType (typeof (STPAPIClient))]
	interface BankAccounts {

		// -(void)createTokenWithBankAccount:(STPBankAccount *)bankAccount completion:(STPCompletionBlock)completion;
		[Export ("createTokenWithBankAccount:completion:")]
		void CreateTokenWithBankAccount (STPBankAccount bankAccount, Action<STPToken, NSError> completion);
	}

	// @interface CreditCards (STPAPIClient)
	[Category]
	[BaseType (typeof (STPAPIClient))]
	interface CreditCards {

		// -(void)createTokenWithCard:(STPCard *)card completion:(STPCompletionBlock)completion;
		[Export ("createTokenWithCard:completion:")]
		void CreateTokenWithCard (STPCard card, Action<STPToken, NSError> completion);
	}

	// @interface PrivateMethods (STPAPIClient)
//	[Category]
//	[BaseType (typeof (STPAPIClient))]
//	interface PrivateMethods {
//		// -(instancetype)initWithAttributeDictionary:(NSDictionary *)attributeDictionary;
//		[Export ("initWithAttributeDictionary:")]
//		IntPtr Constructor (NSDictionary attributeDictionary);
//
//		// -(void)createTokenWithData:(NSData *)data completion:(STPCompletionBlock)completion;
//		[Export ("createTokenWithData:completion:")]
//		void CreateTokenWithData (NSData data, Action<STPToken, NSError> completion);
//	}

	// @interface STPBankAccount : NSObject
	[BaseType (typeof (NSObject))]
	interface STPBankAccount {

		// @property (copy, nonatomic) NSString * accountNumber;
		[Export ("accountNumber")]
		string AccountNumber { get; set; }

		// @property (copy, nonatomic) NSString * routingNumber;
		[Export ("routingNumber")]
		string RoutingNumber { get; set; }

		// @property (copy, nonatomic) NSString * country;
		[Export ("country")]
		string Country { get; set; }

		// @property (readonly, nonatomic) NSString * bankAccountId;
		[Export ("bankAccountId")]
		string BankAccountId { get; }

		// @property (readonly, nonatomic) NSString * last4;
		[Export ("last4")]
		string Last4 { get; }

		// @property (readonly, nonatomic) NSString * bankName;
		[Export ("bankName")]
		string BankName { get; }

		// @property (readonly, nonatomic) NSString * fingerprint;
		[Export ("fingerprint")]
		string Fingerprint { get; }

		// @property (readonly, nonatomic) NSString * currency;
		[Export ("currency")]
		string Currency { get; set; }

		// @property (readonly, nonatomic) BOOL validated;
		[Export ("validated")]
		bool Validated { get; }

		// @property (readonly, nonatomic) BOOL disabled;
		[Export ("disabled")]
		bool Disabled { get; }
	}

	// @interface STPCard : NSObject
	[BaseType (typeof (NSObject))]
	interface STPCard {

		// @property (copy, nonatomic) NSString * number;
		[Export ("number")]
		string Number { get; set; }

		// @property (readonly, nonatomic) NSString * last4;
		[Export ("last4")]
		string Last4 { get; }

		// @property (nonatomic) NSUInteger expMonth;
		[Export ("expMonth")]
		nuint ExpMonth { get; set; }

		// @property (nonatomic) NSUInteger expYear;
		[Export ("expYear")]
		nuint ExpYear { get; set; }

		// @property (copy, nonatomic) NSString * cvc;
		[Export ("cvc")]
		string Cvc { get; set; }

		// @property (copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * addressLine1;
		[Export ("addressLine1")]
		string AddressLine1 { get; set; }

		// @property (copy, nonatomic) NSString * addressLine2;
		[Export ("addressLine2")]
		string AddressLine2 { get; set; }

		// @property (copy, nonatomic) NSString * addressCity;
		[Export ("addressCity")]
		string AddressCity { get; set; }

		// @property (copy, nonatomic) NSString * addressState;
		[Export ("addressState")]
		string AddressState { get; set; }

		// @property (copy, nonatomic) NSString * addressZip;
		[Export ("addressZip")]
		string AddressZip { get; set; }

		// @property (copy, nonatomic) NSString * addressCountry;
		[Export ("addressCountry")]
		string AddressCountry { get; set; }

		// @property (readonly, nonatomic) NSString * cardId;
		[Export ("cardId")]
		string CardId { get; }

		// @property (readonly, nonatomic) STPCardBrand brand;
		[Export ("brand")]
		STPCardBrand Brand { get; }

		// @property (readonly, nonatomic) NSString * type;
		[Export ("type")]
		string Type { get; }

		// @property (readonly, nonatomic) STPCardFundingType funding;
		[Export ("funding")]
		STPCardFundingType Funding { get; }

		// @property (readonly, nonatomic) NSString * fingerprint;
		[Export ("fingerprint")]
		string Fingerprint { get; }

		// @property (readonly, nonatomic) NSString * country;
		[Export ("country")]
		string Country { get; }

		// -(BOOL)validateNumber:(id *)ioValue error:(NSError **)outError;
		[Export ("validateNumber:error:")]
		bool ValidateNumber (out NSObject ioValue, out NSError outError);

		// -(BOOL)validateCvc:(id *)ioValue error:(NSError **)outError;
		[Export ("validateCvc:error:")]
		bool ValidateCvc (out NSObject ioValue, out NSError outError);

		// -(BOOL)validateExpMonth:(id *)ioValue error:(NSError **)outError;
		[Export ("validateExpMonth:error:")]
		bool ValidateExpMonth (out NSObject ioValue, out NSError outError);

		// -(BOOL)validateExpYear:(id *)ioValue error:(NSError **)outError;
		[Export ("validateExpYear:error:")]
		bool ValidateExpYear (out NSObject ioValue, out NSError outError);

		// -(BOOL)validateCardReturningError:(NSError **)outError;
		[Export ("validateCardReturningError:")]
		bool ValidateCardReturningError (out NSError outError);
	}

	// @interface STPToken : NSObject
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface STPToken {

		// @property (readonly, nonatomic) NSString * tokenId;
		[Export ("tokenId")]
		string TokenId { get; }

		// @property (readonly, nonatomic) BOOL livemode;
		[Export ("livemode")]
		bool Livemode { get; }

		// @property (readonly, nonatomic) STPCard * card;
		[Export ("card")]
		STPCard Card { get; }

		// @property (readonly, nonatomic) STPBankAccount * bankAccount;
		[Export ("bankAccount")]
		STPBankAccount BankAccount { get; }

		// @property (readonly, nonatomic) NSDate * created;
		[Export ("created")]
		NSDate Created { get; }

		// -(void)postToURL:(NSURL *)url withParams:(NSDictionary *)params completion:(STPCardServerResponseCallback)handler;
		[Export ("postToURL:withParams:completion:")]
		void PostToURL (NSUrl url, NSDictionary parameters, Action<NSUrlResponse, NSData, NSError> handler);
	}

	// @interface STPCheckoutOptions : NSObject <NSCopying>
	[BaseType (typeof (NSObject))]
	interface STPCheckoutOptions : INSCopying {

		// -(instancetype)initWithPublishableKey:(NSString *)publishableKey;
		[Export ("initWithPublishableKey:")]
		IntPtr Constructor (string publishableKey);

		// @property (copy, nonatomic) NSString * publishableKey;
		[Export ("publishableKey")]
		string PublishableKey { get; set; }

		// @property (copy, nonatomic) NSURL * logoURL;
		[Export ("logoURL", ArgumentSemantic.Copy)]
		NSUrl LogoURL { get; set; }

		// @property (nonatomic) UIImage * logoImage;
		[Export ("logoImage")]
		UIImage LogoImage { get; set; }

		// @property (copy, nonatomic) UIColor * logoColor;
		[Export ("logoColor", ArgumentSemantic.Copy)]
		UIColor LogoColor { get; set; }

		// @property (copy, nonatomic) NSString * companyName;
		[Export ("companyName")]
		string CompanyName { get; set; }

		// @property (copy, nonatomic) NSString * purchaseDescription;
		[Export ("purchaseDescription")]
		string PurchaseDescription { get; set; }

		// @property (nonatomic) NSUInteger purchaseAmount;
		[Export ("purchaseAmount")]
		nuint PurchaseAmount { get; set; }

		// @property (copy, nonatomic) NSString * customerEmail;
		[Export ("customerEmail")]
		string CustomerEmail { get; set; }

		// @property (copy, nonatomic) NSString * purchaseLabel;
		[Export ("purchaseLabel")]
		string PurchaseLabel { get; set; }

		// @property (copy, nonatomic) NSString * purchaseCurrency;
		[Export ("purchaseCurrency")]
		string PurchaseCurrency { get; set; }

		// @property (copy, nonatomic) NSNumber * enableRememberMe;
		[Export ("enableRememberMe", ArgumentSemantic.Copy)]
		NSNumber EnableRememberMe { get; set; }

		// @property (copy, nonatomic) NSNumber * enablePostalCode;
		[Export ("enablePostalCode", ArgumentSemantic.Copy)]
		NSNumber EnablePostalCode { get; set; }

		// @property (copy, nonatomic) NSNumber * requireBillingAddress;
		[Export ("requireBillingAddress", ArgumentSemantic.Copy)]
		NSNumber RequireBillingAddress { get; set; }

		// -(NSString *)stringifiedJSONRepresentation;
		[Export ("stringifiedJSONRepresentation")]
		string StringifiedJSONRepresentation ();
	}

	// @interface STPCheckoutViewController : UINavigationController
	[BaseType (typeof (UINavigationController))]
	interface STPCheckoutViewController {

		// -(instancetype)initWithOptions:(STPCheckoutOptions *)options;
		[Export ("initWithOptions:")]
		IntPtr Constructor (STPCheckoutOptions options);

		// @property (readonly, copy, nonatomic) STPCheckoutOptions * options;
		[Export ("options", ArgumentSemantic.Copy)]
		STPCheckoutOptions Options { get; }

		// @property (nonatomic, weak) id<STPCheckoutViewControllerDelegate> checkoutDelegate;
		[Export ("checkoutDelegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakCheckoutDelegate { get; set; }

		// @property (nonatomic, weak) id<STPCheckoutViewControllerDelegate> checkoutDelegate;
		[Wrap ("WeakCheckoutDelegate")]
		STPCheckoutViewControllerDelegate CheckoutDelegate { get; set; }
	}

	// @protocol STPCheckoutViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface STPCheckoutViewControllerDelegate {

		// @required -(void)checkoutController:(STPCheckoutViewController *)controller didFinishWithStatus:(STPPaymentStatus)status error:(NSError *)error;
		[Export ("checkoutController:didFinishWithStatus:error:")]
		[Abstract]
		void DidFinishWithStatus (STPCheckoutViewController controller, STPPaymentStatus status, NSError error);

		// @required -(void)checkoutController:(STPCheckoutViewController *)controller didCreateToken:(STPToken *)token completion:(STPTokenSubmissionHandler)completion;
		[Export ("checkoutController:didCreateToken:completion:")]
		[Abstract]
		void DidCreateToken (STPCheckoutViewController controller, STPToken token, Action<STPBackendChargeResult, NSError> completion);
	}

	// @interface ApplePay (STPAPIClient)
	[Category]
	[BaseType (typeof (STPAPIClient))]
	interface ApplePay {

		// -(void)createTokenWithPayment:(PKPayment *)payment completion:(STPCompletionBlock)completion;
		[Export ("createTokenWithPayment:completion:")]
		void CreateTokenWithPayment (PKPayment payment, Action<STPToken, NSError> completion);

		// +(NSData *)formEncodedDataForPayment:(PKPayment *)payment;
		[Static, Export ("formEncodedDataForPayment:")]
		NSData FormEncodedDataForPayment (PKPayment payment);

		// +(BOOL)canSubmitPaymentRequest:(PKPaymentRequest *)paymentRequest;
		[Static, Export ("canSubmitPaymentRequest:")]
		bool CanSubmitPaymentRequest (PKPaymentRequest paymentRequest);

		// +(PKPaymentRequest *)paymentRequestWithMerchantIdentifier:(NSString *)merchantIdentifier;
		[Static, Export ("paymentRequestWithMerchantIdentifier:")]
		PKPaymentRequest PaymentRequestWithMerchantIdentifier (string merchantIdentifier);

		// +(void)createTokenWithPayment:(PKPayment *)payment completion:(STPCompletionBlock)handler;
//		[Availability (Deprecated = Platform.iOS | Platform.Mac)]
//		[Static, Export ("createTokenWithPayment:completion:")]
//		void CreateTokenWithPayment (PKPayment payment, Action<STPToken, NSError> handler);

		// +(void)createTokenWithPayment:(PKPayment *)payment operationQueue:(NSOperationQueue *)queue completion:(STPCompletionBlock)handler;
		[Static, Export ("createTokenWithPayment:operationQueue:completion:")]
		void CreateTokenWithPayment (PKPayment payment, NSOperationQueue queue, Action<STPToken, NSError> handler);
	}
}
