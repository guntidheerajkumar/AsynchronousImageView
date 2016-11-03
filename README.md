# AsynchronousImageView

This is a Obj-C binding project based on https://github.com/nicklockwood/AsyncImageView.

### Usage

```
AsyncImageView imageView = new AsyncImageView();
imageView.Frame = new CGRect(10, 60, this.View.Frame.Width - 20, 200);
imageView.ContentMode = UIViewContentMode.ScaleAspectFill;
imageView.ClipsToBounds = true;
imageView.ImageURL = NSUrl.FromString("http://www.psdexplorer.com/wp-content/uploads/2015/04/free-psd-macbook-space-gray-gold-silver-mockup.jpg");
this.View.AddSubview(imageView);
```


### Instructions

Add the following key in Info.Plist.

```
<key>NSAppTransportSecurity</key>
	<dict>
		<key>NSAllowsArbitraryLoads</key>
	<true/>
</dict>
```

### Thread Safety

AsyncImageView uses threading internally, but none of the AsyncImageView external interfaces are thread safe, and you should not call any methods or set any properties on any of the AsyncImageView classes except on the main thread.
