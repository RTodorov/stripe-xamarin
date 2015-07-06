BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild

VERSION=1.0.1

all: Stripe.Droid.dll

Stripe_Droid_$(VERSION).zip:
	curl https://github.com/stripe/stripe-android/archive/v$(VERSION).zip -L -o $@
	rm -rf stripe-android-$(VERSION)
	unzip $@

stripe-java-1.12.0.jar: Stripe_Droid_$(VERSION).zip
	cp stripe-android-$(VERSION)/stripe/libs/* Jars/

Stripe.Droid.dll: stripe-java-1.12.0.jar
	$(MONOXBUILD) /p:Configuration=Release Stripe.Droid.csproj
	cp bin/Release/Stripe.Droid.dll Stripe.Droid.dll

clean:
	-rm -rf bin obj *.a *.dll
	rm -rf stripe-android*
	rm -rf Stripe_Droid_$(VERSION).zip
	rm -rf Jars/*
	rm -rf stripe-android-1.0.1
