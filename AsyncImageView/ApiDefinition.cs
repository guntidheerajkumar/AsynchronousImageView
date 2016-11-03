using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace AsyncImageViews
{
	[Static]
	partial interface Constants
	{
		// extern NSString *const _Nonnull AsyncImageLoaderErrorDomain;
		[Field("AsyncImageLoaderErrorDomain", "__Internal")]
		NSString AsyncImageLoaderErrorDomain { get; }

		// extern NSString *const _Nonnull AsyncImageLoadDidFinish;
		[Field("AsyncImageLoadDidFinish", "__Internal")]
		NSString AsyncImageLoadDidFinish { get; }

		// extern NSString *const _Nonnull AsyncImageLoadDidFail;
		[Field("AsyncImageLoadDidFail", "__Internal")]
		NSString AsyncImageLoadDidFail { get; }

		// extern NSString *const _Nonnull AsyncImageImageKey;
		[Field("AsyncImageImageKey", "__Internal")]
		NSString AsyncImageImageKey { get; }

		// extern NSString *const _Nonnull AsyncImageURLKey;
		[Field("AsyncImageURLKey", "__Internal")]
		NSString AsyncImageURLKey { get; }

		// extern NSString *const _Nonnull AsyncImageCacheKey;
		[Field("AsyncImageCacheKey", "__Internal")]
		NSString AsyncImageCacheKey { get; }

		// extern NSString *const _Nonnull AsyncImageErrorKey;
		[Field("AsyncImageErrorKey", "__Internal")]
		NSString AsyncImageErrorKey { get; }
	}

	// @interface AsyncImageLoader : NSObject
	[BaseType(typeof(NSObject))]
	interface AsyncImageLoader
	{
		// +(AsyncImageLoader * _Nonnull)sharedLoader;
		[Static]
		[Export("sharedLoader")]
		AsyncImageLoader SharedLoader { get; }

		// +(NSCache * _Nonnull)defaultCache;
		[Static]
		[Export("defaultCache")]
		NSCache DefaultCache { get; }

		// @property (nonatomic, strong) NSCache * _Nullable cache;
		[NullAllowed, Export("cache", ArgumentSemantic.Strong)]
		NSCache Cache { get; set; }

		// @property (assign, nonatomic) NSUInteger concurrentLoads;
		[Export("concurrentLoads")]
		nuint ConcurrentLoads { get; set; }

		// @property (assign, nonatomic) NSTimeInterval loadingTimeout;
		[Export("loadingTimeout")]
		double LoadingTimeout { get; set; }

		// -(void)loadImageWithURL:(NSURL * _Nullable)URL target:(id _Nullable)target success:(SEL _Nullable)success failure:(SEL _Nullable)failure;
		[Export("loadImageWithURL:target:success:failure:")]
		void LoadImageWithURL([NullAllowed] NSUrl URL, [NullAllowed] NSObject target, [NullAllowed] Selector success, [NullAllowed] Selector failure);

		// -(void)loadImageWithURL:(NSURL * _Nullable)URL target:(id _Nullable)target action:(SEL _Nullable)action;
		[Export("loadImageWithURL:target:action:")]
		void LoadImageWithURL([NullAllowed] NSUrl URL, [NullAllowed] NSObject target, [NullAllowed] Selector action);

		// -(void)loadImageWithURL:(NSURL * _Nullable)URL;
		[Export("loadImageWithURL:")]
		void LoadImageWithURL([NullAllowed] NSUrl URL);

		// -(void)cancelLoadingURL:(NSURL * _Nullable)URL target:(id _Nullable)target action:(SEL _Nullable)action;
		[Export("cancelLoadingURL:target:action:")]
		void CancelLoadingURL([NullAllowed] NSUrl URL, [NullAllowed] NSObject target, [NullAllowed] Selector action);

		// -(void)cancelLoadingURL:(NSURL * _Nullable)URL target:(id _Nullable)target;
		[Export("cancelLoadingURL:target:")]
		void CancelLoadingURL([NullAllowed] NSUrl URL, [NullAllowed] NSObject target);

		// -(void)cancelLoadingURL:(NSURL * _Nullable)URL;
		[Export("cancelLoadingURL:")]
		void CancelLoadingURL([NullAllowed] NSUrl URL);

		// -(void)cancelLoadingImagesForTarget:(id _Nullable)target action:(SEL _Nullable)action;
		[Export("cancelLoadingImagesForTarget:action:")]
		void CancelLoadingImagesForTarget([NullAllowed] NSObject target, [NullAllowed] Selector action);

		// -(void)cancelLoadingImagesForTarget:(id _Nullable)target;
		[Export("cancelLoadingImagesForTarget:")]
		void CancelLoadingImagesForTarget([NullAllowed] NSObject target);

		// -(NSURL * _Nonnull)URLForTarget:(id _Nullable)target action:(SEL _Nullable)action;
		[Export("URLForTarget:action:")]
		NSUrl URLForTarget([NullAllowed] NSObject target, [NullAllowed] Selector action);

		// -(NSURL * _Nonnull)URLForTarget:(id _Nullable)target;
		[Export("URLForTarget:")]
		NSUrl URLForTarget([NullAllowed] NSObject target);
	}

	// @interface AsyncImageView : UIImageView
	[BaseType(typeof(UIImageView))]
	interface AsyncImageView
	{
		// @property (assign, nonatomic) BOOL showActivityIndicator;
		[Export("showActivityIndicator")]
		bool ShowActivityIndicator { get; set; }

		// @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorStyle;
		[Export("activityIndicatorStyle", ArgumentSemantic.Assign)]
		UIActivityIndicatorViewStyle ActivityIndicatorStyle { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable activityIndicatorColor;
		[NullAllowed, Export("activityIndicatorColor", ArgumentSemantic.Strong)]
		UIColor ActivityIndicatorColor { get; set; }

		// @property (assign, nonatomic) NSTimeInterval crossfadeDuration;
		[Export("crossfadeDuration")]
		double CrossfadeDuration { get; set; }

		// @property (nonatomic, strong) NSURL * _Nullable imageURL;
		[NullAllowed, Export("imageURL", ArgumentSemantic.Strong)]
		NSUrl ImageURL { get; set; }
	}
}
