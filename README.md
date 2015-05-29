Stripe SDK binding for Xamarin
==========

This is a MonoTouch / MonoDroid binding for the oficial Stripe SDK that can be found at:

     https://github.com/stripe/stripe-ios

The current version of this binding is **iOS SDK 4.0.3** and **Android SDK 1.0.1**

Building
---------

Run `make` in the binding directory to build Stripe.iOS.dll and Stripe.Droid.dll.

If you want to build only the iOS or the Android binding, run `make ios` or `make droid`.


Using this Stripe binding with your app
---------------------------------------

Simply add `Stripe.*.dll` to your project's References.

You can also download this binding via NuGet.
