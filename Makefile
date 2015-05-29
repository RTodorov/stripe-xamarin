all: Stripe.iOS.dll Stripe.Droid.dll

ios: Stripe.iOS.dll

droid: Stripe.Droid.dll

Stripe.iOS.dll:
	cd Stripe.iOS && $(MAKE)
	cp Stripe.iOS/bin/Release/Stripe.iOS.dll Stripe.iOS.dll

Stripe.Droid.dll:
	cd Stripe.Droid && $(MAKE)
	cp Stripe.Droid/bin/Release/Stripe.Droid.dll Stripe.Droid.dll

clean:
	cd Stripe.iOS && $(MAKE) clean
	rm -rf Stripe.iOS.dll
	rm -rf Stripe.Droid.dll

