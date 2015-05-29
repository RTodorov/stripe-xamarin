BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild

VERSION=4.0.3

all: Stripe.iOS.dll

Stripe_iOS_$(VERSION).zip:
	curl https://github.com/stripe/stripe-ios/releases/download/v$(VERSION)/StripeiOS.zip -L -o $@
	rm -rf StripeiOS
	unzip $@

libStripe.a: Stripe_iOS_$(VERSION).zip
	cp StripeiOS/Stripe.framework/Stripe libStripe.a

Stripe.iOS.dll: libStripe.a
	$(MONOXBUILD) /p:Configuration=Release Stripe.iOS.csproj
	cp bin/Release/Stripe.iOS.dll Stripe.iOS.dll

clean:
	-rm -rf bin obj *.a *.dll
	rm -rf StripeiOS*
	rm -rf Stripe_iOS_$(VERSION).zip

