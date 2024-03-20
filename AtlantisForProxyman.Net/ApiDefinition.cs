using Foundation;

namespace AtlantisForProxyman.Net
{
    // @interface Atlantis : NSObject
    [BaseType (typeof(NSObject), Name = "_TtC8Atlantis8Atlantis")]
    [DisableDefaultCtor]
    interface Atlantis
    {
        // +(void)startWithHostName:(NSString * _Nullable)hostName shouldCaptureWebSocketTraffic:(BOOL)shouldCaptureWebSocketTraffic;
        [Static]
        [Export ("startWithHostName:shouldCaptureWebSocketTraffic:")]
        void Start ([NullAllowed] string hostName = null, bool shouldCaptureWebSocketTraffic = true);

        // +(void)stop;
        [Static]
        [Export ("stop")]
        void Stop ();
    }
}