using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace TencentOpenAPI
{
    // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
    // to the project by right-clicking (or Control-clicking) the folder containing this source
    // file and clicking "Add files..." and then simply select the native library (or libraries)
    // that you want to bind.
    //
    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
    // native library which will contain a [LinkWith] attribute. VisualStudio auto-detects the
    // architectures that the native library supports and fills in that information for you,
    // however, it cannot auto-detect any Frameworks or other system libraries that the
    // native library may depend on, so you'll need to fill in that information yourself.
    //
    // Once you've done that, you're ready to move on to binding the API...
    //
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //
    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {
    //     }
    //
    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
    //
    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     IntPtr Constructor (ElmoMuppet elmo);
    //
    // For more information, see https://aka.ms/ios-binding
    //

    // typedef void (^QQApiLogBolock)(NSString *);

    delegate void QQApiLogBolock(string arg0);

    // @interface QQApiObject : NSObject
    [BaseType(typeof(NSObject))]
    interface QQApiObject
    {
        // @property (retain, nonatomic) NSString * title;
        [Export("title", ArgumentSemantic.Retain)]
        string Title { get; set; }

        // @property (retain, nonatomic) NSString * description;
        [Export("description", ArgumentSemantic.Retain)]
        string Description { get; set; }

        // @property (retain, nonatomic) NSString * universalLink;
        [Export("universalLink", ArgumentSemantic.Retain)]
        string UniversalLink { get; set; }

        // @property (assign, nonatomic) uint64_t cflag;
        [Export("cflag")]
        ulong Cflag { get; set; }

        // @property (retain, nonatomic) NSString * tagName;
        [Export("tagName", ArgumentSemantic.Retain)]
        string TagName { get; set; }

        // @property (retain, nonatomic) NSString * messageExt;
        [Export("messageExt", ArgumentSemantic.Retain)]
        string MessageExt { get; set; }

        // @property (assign, nonatomic) ShareDestType shareDestType;
        [Export("shareDestType", ArgumentSemantic.Assign)]
        ShareDestType ShareDestType { get; set; }
    }

    // @interface ArkObject : NSObject
    [BaseType(typeof(NSObject))]
    interface ArkObject
    {
        // @property (retain, nonatomic) NSString * arkData;
        [Export("arkData", ArgumentSemantic.Retain)]
        string ArkData { get; set; }

        // @property (assign, nonatomic) QQApiObject * qqApiObject;
        [Export("qqApiObject", ArgumentSemantic.Assign)]
        QQApiObject QqApiObject { get; set; }

        // -(id)initWithData:(NSString *)arkData qqApiObject:(QQApiObject *)qqApiObject;
        [Export("initWithData:qqApiObject:")]
        IntPtr Constructor(string arkData, QQApiObject qqApiObject);

        // +(id)objectWithData:(NSString *)arkData qqApiObject:(QQApiObject *)qqApiObject;
        [Static]
        [Export("objectWithData:qqApiObject:")]
        NSObject ObjectWithData(string arkData, QQApiObject qqApiObject);
    }

    // @interface QQApiMiniProgramObject : NSObject
    [BaseType(typeof(NSObject))]
    interface QQApiMiniProgramObject
    {
        // @property (retain, nonatomic) QQApiObject * qqApiObject;
        [Export("qqApiObject", ArgumentSemantic.Retain)]
        QQApiObject QqApiObject { get; set; }

        // @property (retain, nonatomic) NSString * miniAppID;
        [Export("miniAppID", ArgumentSemantic.Retain)]
        string MiniAppID { get; set; }

        // @property (retain, nonatomic) NSString * miniPath;
        [Export("miniPath", ArgumentSemantic.Retain)]
        string MiniPath { get; set; }

        // @property (retain, nonatomic) NSString * webpageUrl;
        [Export("webpageUrl", ArgumentSemantic.Retain)]
        string WebpageUrl { get; set; }

        // @property (assign, nonatomic) MiniProgramType miniprogramType;
        [Export("miniprogramType", ArgumentSemantic.Assign)]
        MiniProgramType MiniprogramType { get; set; }
    }

    // @interface QQApiLaunchMiniProgramObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiLaunchMiniProgramObject
    {
        // @property (retain, nonatomic) NSString * miniAppID;
        [Export("miniAppID", ArgumentSemantic.Retain)]
        string MiniAppID { get; set; }

        // @property (retain, nonatomic) NSString * miniPath;
        [Export("miniPath", ArgumentSemantic.Retain)]
        string MiniPath { get; set; }

        // @property (assign, nonatomic) MiniProgramType miniprogramType;
        [Export("miniprogramType", ArgumentSemantic.Assign)]
        MiniProgramType MiniprogramType { get; set; }
    }

    // @interface QQApiMiniProgramLaunchObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiMiniProgramLaunchObject
    {
        // @property (copy, nonatomic) NSString * appParameter;
        [Export("appParameter")]
        string AppParameter { get; set; }

        // +(instancetype)newWithAppParameter:(NSString *)parameter;
        [Static]
        [Export("newWithAppParameter:")]
        QQApiMiniProgramLaunchObject NewWithAppParameter(string parameter);
    }

    // @interface QQApiResultObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiResultObject
    {
        // @property (retain, nonatomic) NSString * error;
        [Export("error", ArgumentSemantic.Retain)]
        string Error { get; set; }

        // @property (retain, nonatomic) NSString * errorDescription;
        [Export("errorDescription", ArgumentSemantic.Retain)]
        string ErrorDescription { get; set; }

        // @property (retain, nonatomic) NSString * extendInfo;
        [Export("extendInfo", ArgumentSemantic.Retain)]
        string ExtendInfo { get; set; }
    }

    // @interface QQApiTextObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiTextObject
    {
        // @property (retain, nonatomic) NSString * text;
        [Export("text", ArgumentSemantic.Retain)]
        string Text { get; set; }

        // -(id)initWithText:(NSString *)text;
        [Export("initWithText:")]
        IntPtr Constructor(string text);

        // +(id)objectWithText:(NSString *)text;
        [Static]
        [Export("objectWithText:")]
        NSObject ObjectWithText(string text);
    }

    // @interface QQApiURLObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiURLObject
    {
        // @property (nonatomic) QQApiURLTargetType targetContentType;
        [Export("targetContentType", ArgumentSemantic.Assign)]
        QQApiURLTargetType TargetContentType { get; set; }

        // @property (retain, nonatomic) NSURL * url;
        [Export("url", ArgumentSemantic.Retain)]
        NSUrl Url { get; set; }

        // @property (retain, nonatomic) NSData * previewImageData;
        [Export("previewImageData", ArgumentSemantic.Retain)]
        NSData PreviewImageData { get; set; }

        // @property (retain, nonatomic) NSURL * previewImageURL;
        [Export("previewImageURL", ArgumentSemantic.Retain)]
        NSUrl PreviewImageURL { get; set; }

        // -(id)initWithURL:(NSURL *)url title:(NSString *)title description:(NSString *)description previewImageData:(NSData *)data targetContentType:(QQApiURLTargetType)targetContentType;
        [Export("initWithURL:title:description:previewImageData:targetContentType:")]
        IntPtr Constructor(NSUrl url, string title, string description, NSData data, QQApiURLTargetType targetContentType);

        // -(id)initWithURL:(NSURL *)url title:(NSString *)title description:(NSString *)description previewImageURL:(NSURL *)previewURL targetContentType:(QQApiURLTargetType)targetContentType;
        [Export("initWithURL:title:description:previewImageURL:targetContentType:")]
        IntPtr Constructor(NSUrl url, string title, string description, NSUrl previewURL, QQApiURLTargetType targetContentType);

        // +(id)objectWithURL:(NSURL *)url title:(NSString *)title description:(NSString *)description previewImageData:(NSData *)data targetContentType:(QQApiURLTargetType)targetContentType;
        [Static]
        [Export("objectWithURL:title:description:previewImageData:targetContentType:")]
        NSObject ObjectWithURL(NSUrl url, string title, string description, NSData data, QQApiURLTargetType targetContentType);

        // +(id)objectWithURL:(NSURL *)url title:(NSString *)title description:(NSString *)description previewImageURL:(NSURL *)previewURL targetContentType:(QQApiURLTargetType)targetContentType;
        [Static]
        [Export("objectWithURL:title:description:previewImageURL:targetContentType:")]
        NSObject ObjectWithURL(NSUrl url, string title, string description, NSUrl previewURL, QQApiURLTargetType targetContentType);
    }

    // @interface QQApiExtendObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiExtendObject
    {
        // @property (retain, nonatomic) NSData * data;
        [Export("data", ArgumentSemantic.Retain)]
        NSData Data { get; set; }

        // @property (retain, nonatomic) NSData * previewImageData;
        [Export("previewImageData", ArgumentSemantic.Retain)]
        NSData PreviewImageData { get; set; }

        // @property (retain, nonatomic) NSArray * imageDataArray;
        [Export("imageDataArray", ArgumentSemantic.Retain)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] ImageDataArray { get; set; }

        // -(id)initWithData:(NSData *)data previewImageData:(NSData *)previewImageData title:(NSString *)title description:(NSString *)description;
        [Export("initWithData:previewImageData:title:description:")]
        IntPtr Constructor(NSData data, NSData previewImageData, string title, string description);

        // -(id)initWithData:(NSData *)data previewImageData:(NSData *)previewImageData title:(NSString *)title description:(NSString *)description imageDataArray:(NSArray *)imageDataArray;
        [Export("initWithData:previewImageData:title:description:imageDataArray:")]
        [Verify(StronglyTypedNSArray)]
        IntPtr Constructor(NSData data, NSData previewImageData, string title, string description, NSObject[] imageDataArray);

        // +(id)objectWithData:(NSData *)data previewImageData:(NSData *)previewImageData title:(NSString *)title description:(NSString *)description;
        [Static]
        [Export("objectWithData:previewImageData:title:description:")]
        NSObject ObjectWithData(NSData data, NSData previewImageData, string title, string description);

        // +(id)objectWithData:(NSData *)data previewImageData:(NSData *)previewImageData title:(NSString *)title description:(NSString *)description imageDataArray:(NSArray *)imageDataArray;
        [Static]
        [Export("objectWithData:previewImageData:title:description:imageDataArray:")]
        [Verify(StronglyTypedNSArray)]
        NSObject ObjectWithData(NSData data, NSData previewImageData, string title, string description, NSObject[] imageDataArray);
    }

    // @interface QQApiImageObject : QQApiExtendObject
    [BaseType(typeof(QQApiExtendObject))]
    interface QQApiImageObject
    {
    }

    // @interface QQApiImageForQQAvatarObject : QQApiExtendObject
    [BaseType(typeof(QQApiExtendObject))]
    interface QQApiImageForQQAvatarObject
    {
    }

    // @interface QQApiVideoForQQAvatarObject : QQApiExtendObject
    [BaseType(typeof(QQApiExtendObject))]
    interface QQApiVideoForQQAvatarObject
    {
        // @property (retain, nonatomic) NSString * assetURL;
        [Export("assetURL", ArgumentSemantic.Retain)]
        string AssetURL { get; set; }
    }

    // @interface QQApiAuthObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiAuthObject
    {
    }

    // @interface QQApiImageArrayForFaceCollectionObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiImageArrayForFaceCollectionObject
    {
        // @property (retain, nonatomic) NSArray * imageDataArray;
        [Export("imageDataArray", ArgumentSemantic.Retain)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] ImageDataArray { get; set; }

        // -(id)initWithImageArrayData:(NSArray *)imageDataArray;
        [Export("initWithImageArrayData:")]
        [Verify(StronglyTypedNSArray)]
        IntPtr Constructor(NSObject[] imageDataArray);

        // +(id)objectWithimageDataArray:(NSArray *)imageDataArray;
        [Static]
        [Export("objectWithimageDataArray:")]
        [Verify(StronglyTypedNSArray)]
        NSObject ObjectWithimageDataArray(NSObject[] imageDataArray);
    }

    // @interface QQApiImageArrayForQZoneObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiImageArrayForQZoneObject
    {
        // @property (retain, nonatomic) NSArray * imageDataArray;
        [Export("imageDataArray", ArgumentSemantic.Retain)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] ImageDataArray { get; set; }

        // @property (retain, nonatomic) NSDictionary * extMap;
        [Export("extMap", ArgumentSemantic.Retain)]
        NSDictionary ExtMap { get; set; }

        // -(id)initWithImageArrayData:(NSArray *)imageDataArray title:(NSString *)title extMap:(NSDictionary *)extMap;
        [Export("initWithImageArrayData:title:extMap:")]
        [Verify(StronglyTypedNSArray)]
        IntPtr Constructor(NSObject[] imageDataArray, string title, NSDictionary extMap);

        // +(id)objectWithimageDataArray:(NSArray *)imageDataArray title:(NSString *)title extMap:(NSDictionary *)extMap;
        [Static]
        [Export("objectWithimageDataArray:title:extMap:")]
        [Verify(StronglyTypedNSArray)]
        NSObject ObjectWithimageDataArray(NSObject[] imageDataArray, string title, NSDictionary extMap);
    }

    // @interface QQApiVideoForQZoneObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiVideoForQZoneObject
    {
        // @property (retain, nonatomic) NSString * assetURL;
        [Export("assetURL", ArgumentSemantic.Retain)]
        string AssetURL { get; set; }

        // @property (retain, nonatomic) NSDictionary * extMap;
        [Export("extMap", ArgumentSemantic.Retain)]
        NSDictionary ExtMap { get; set; }

        // @property (retain, nonatomic) NSData * videoData;
        [Export("videoData", ArgumentSemantic.Retain)]
        NSData VideoData { get; set; }

        // -(id)initWithAssetURL:(NSString *)assetURL title:(NSString *)title extMap:(NSDictionary *)extMap;
        [Export("initWithAssetURL:title:extMap:")]
        IntPtr Constructor(string assetURL, string title, NSDictionary extMap);

        // +(id)objectWithAssetURL:(NSString *)assetURL title:(NSString *)title extMap:(NSDictionary *)extMap;
        [Static]
        [Export("objectWithAssetURL:title:extMap:")]
        NSObject ObjectWithAssetURL(string assetURL, string title, NSDictionary extMap);

        // -(id)initWithVideoData:(NSData *)videoData title:(NSString *)title extMap:(NSDictionary *)extMap;
        [Export("initWithVideoData:title:extMap:")]
        IntPtr Constructor(NSData videoData, string title, NSDictionary extMap);

        // +(id)objectWithVideoData:(NSData *)videoData title:(NSString *)title extMap:(NSDictionary *)extMap;
        [Static]
        [Export("objectWithVideoData:title:extMap:")]
        NSObject ObjectWithVideoData(NSData videoData, string title, NSDictionary extMap);
    }

    // @interface QQApiWebImageObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiWebImageObject
    {
        // @property (retain, nonatomic) NSURL * previewImageURL;
        [Export("previewImageURL", ArgumentSemantic.Retain)]
        NSUrl PreviewImageURL { get; set; }

        // -(id)initWithPreviewImageURL:(NSURL *)previewImageURL title:(NSString *)title description:(NSString *)description;
        [Export("initWithPreviewImageURL:title:description:")]
        IntPtr Constructor(NSUrl previewImageURL, string title, string description);

        // +(id)objectWithPreviewImageURL:(NSURL *)previewImageURL title:(NSString *)title description:(NSString *)description;
        [Static]
        [Export("objectWithPreviewImageURL:title:description:")]
        NSObject ObjectWithPreviewImageURL(NSUrl previewImageURL, string title, string description);
    }

    // @interface QQApiFileObject : QQApiExtendObject
    [BaseType(typeof(QQApiExtendObject))]
    interface QQApiFileObject
    {
        // @property (retain, nonatomic) NSString * fileName;
        [Export("fileName", ArgumentSemantic.Retain)]
        string FileName { get; set; }
    }

    // @interface QQApiAudioObject : QQApiURLObject
    [BaseType(typeof(QQApiURLObject))]
    interface QQApiAudioObject
    {
        // @property (retain, nonatomic) NSURL * flashURL;
        [Export("flashURL", ArgumentSemantic.Retain)]
        NSUrl FlashURL { get; set; }

        // +(id)objectWithURL:(NSURL *)url title:(NSString *)title description:(NSString *)description previewImageData:(NSData *)data;
        [Static]
        [Export("objectWithURL:title:description:previewImageData:")]
        NSObject ObjectWithURL(NSUrl url, string title, string description, NSData data);

        // +(id)objectWithURL:(NSURL *)url title:(NSString *)title description:(NSString *)description previewImageURL:(NSURL *)previewURL;
        [Static]
        [Export("objectWithURL:title:description:previewImageURL:")]
        NSObject ObjectWithURL(NSUrl url, string title, string description, NSUrl previewURL);
    }

    // @interface QQApiVideoObject : QQApiURLObject
    [BaseType(typeof(QQApiURLObject))]
    interface QQApiVideoObject
    {
        // @property (retain, nonatomic) NSURL * flashURL;
        [Export("flashURL", ArgumentSemantic.Retain)]
        NSUrl FlashURL { get; set; }

        // +(id)objectWithURL:(NSURL *)url title:(NSString *)title description:(NSString *)description previewImageData:(NSData *)data;
        [Static]
        [Export("objectWithURL:title:description:previewImageData:")]
        NSObject ObjectWithURL(NSUrl url, string title, string description, NSData data);

        // +(id)objectWithURL:(NSURL *)url title:(NSString *)title description:(NSString *)description previewImageURL:(NSURL *)previewURL;
        [Static]
        [Export("objectWithURL:title:description:previewImageURL:")]
        NSObject ObjectWithURL(NSUrl url, string title, string description, NSUrl previewURL);
    }

    // @interface QQApiNewsObject : QQApiURLObject
    [BaseType(typeof(QQApiURLObject))]
    interface QQApiNewsObject
    {
        // +(id)objectWithURL:(NSURL *)url title:(NSString *)title description:(NSString *)description previewImageData:(NSData *)data;
        [Static]
        [Export("objectWithURL:title:description:previewImageData:")]
        NSObject ObjectWithURL(NSUrl url, string title, string description, NSData data);

        // +(id)objectWithURL:(NSURL *)url title:(NSString *)title description:(NSString *)description previewImageURL:(NSURL *)previewURL;
        [Static]
        [Export("objectWithURL:title:description:previewImageURL:")]
        NSObject ObjectWithURL(NSUrl url, string title, string description, NSUrl previewURL);
    }

    // @interface QQApiCommonContentObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiCommonContentObject
    {
        // @property (assign, nonatomic) unsigned int layoutType;
        [Export("layoutType")]
        uint LayoutType { get; set; }

        // @property (assign, nonatomic) NSData * previewImageData;
        [Export("previewImageData", ArgumentSemantic.Assign)]
        NSData PreviewImageData { get; set; }

        // @property (retain, nonatomic) NSArray * textArray;
        [Export("textArray", ArgumentSemantic.Retain)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] TextArray { get; set; }

        // @property (retain, nonatomic) NSArray * pictureDataArray;
        [Export("pictureDataArray", ArgumentSemantic.Retain)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] PictureDataArray { get; set; }

        // +(id)objectWithLayoutType:(int)layoutType textArray:(NSArray *)textArray pictureArray:(NSArray *)pictureArray previewImageData:(NSData *)data;
        [Static]
        [Export("objectWithLayoutType:textArray:pictureArray:previewImageData:")]
        [Verify(StronglyTypedNSArray), Verify(StronglyTypedNSArray)]
        NSObject ObjectWithLayoutType(int layoutType, NSObject[] textArray, NSObject[] pictureArray, NSData data);

        // +(id)objectWithDictionary:(NSDictionary *)dic;
        [Static]
        [Export("objectWithDictionary:")]
        NSObject ObjectWithDictionary(NSDictionary dic);

        // -(NSDictionary *)toDictionary;
        [Export("toDictionary")]
        [Verify(MethodToProperty)]
        NSDictionary ToDictionary { get; }
    }

    // @interface QQApiExtraServiceObject : QQApiObject
    [BaseType(typeof(QQApiObject))]
    interface QQApiExtraServiceObject
    {
        // @property (retain, nonatomic) NSString * serviceID;
        [Export("serviceID", ArgumentSemantic.Retain)]
        string ServiceID { get; set; }

        // @property (retain, nonatomic) NSString * openID;
        [Export("openID", ArgumentSemantic.Retain)]
        string OpenID { get; set; }

        // @property (retain, nonatomic) NSString * toUin;
        [Export("toUin", ArgumentSemantic.Retain)]
        string ToUin { get; set; }

        // @property (retain, nonatomic) NSDictionary * extraInfo;
        [Export("extraInfo", ArgumentSemantic.Retain)]
        NSDictionary ExtraInfo { get; set; }

        // -(id)initWithOpenID:(NSString *)openID serviceID:(NSString *)serviceID;
        [Export("initWithOpenID:serviceID:")]
        IntPtr Constructor(string openID, string serviceID);

        // +(id)objecWithOpenID:(NSString *)openID serviceID:(NSString *)serviceID;
        [Static]
        [Export("objecWithOpenID:serviceID:")]
        NSObject ObjecWithOpenID(string openID, string serviceID);
    }

    // @interface QQApiAdItem : NSObject
    [BaseType(typeof(NSObject))]
    interface QQApiAdItem
    {
        // @property (retain, nonatomic) NSString * title;
        [Export("title", ArgumentSemantic.Retain)]
        string Title { get; set; }

        // @property (retain, nonatomic) NSString * description;
        [Export("description", ArgumentSemantic.Retain)]
        string Description { get; set; }

        // @property (retain, nonatomic) NSData * imageData;
        [Export("imageData", ArgumentSemantic.Retain)]
        NSData ImageData { get; set; }

        // @property (retain, nonatomic) NSURL * target;
        [Export("target", ArgumentSemantic.Retain)]
        NSUrl Target { get; set; }
    }

    // @interface QQBaseReq : NSObject
    [BaseType(typeof(NSObject))]
    interface QQBaseReq
    {
        // @property (assign, nonatomic) int type;
        [Export("type")]
        int Type { get; set; }
    }

    // @interface QQBaseResp : NSObject
    [BaseType(typeof(NSObject))]
    interface QQBaseResp
    {
        // @property (copy, nonatomic) NSString * result;
        [Export("result")]
        string Result { get; set; }

        // @property (copy, nonatomic) NSString * errorDescription;
        [Export("errorDescription")]
        string ErrorDescription { get; set; }

        // @property (assign, nonatomic) int type;
        [Export("type")]
        int Type { get; set; }

        // @property (assign, nonatomic) NSString * extendInfo;
        [Export("extendInfo")]
        string ExtendInfo { get; set; }
    }

    // @interface GetMessageFromQQReq : QQBaseReq
    [BaseType(typeof(QQBaseReq))]
    interface GetMessageFromQQReq
    {
        // +(GetMessageFromQQReq *)req;
        [Static]
        [Export("req")]
        [Verify(MethodToProperty)]
        GetMessageFromQQReq Req { get; }
    }

    // @interface SendMessageToQQReq : QQBaseReq
    [BaseType(typeof(QQBaseReq))]
    interface SendMessageToQQReq
    {
        // +(SendMessageToQQReq *)reqWithContent:(QQApiObject *)message;
        [Static]
        [Export("reqWithContent:")]
        SendMessageToQQReq ReqWithContent(QQApiObject message);

        // +(SendMessageToQQReq *)reqWithArkContent:(ArkObject *)message;
        [Static]
        [Export("reqWithArkContent:")]
        SendMessageToQQReq ReqWithArkContent(ArkObject message);

        // +(SendMessageToQQReq *)reqWithMiniContent:(QQApiMiniProgramObject *)miniMessage;
        [Static]
        [Export("reqWithMiniContent:")]
        SendMessageToQQReq ReqWithMiniContent(QQApiMiniProgramObject miniMessage);

        // @property (retain, nonatomic) QQApiObject * message;
        [Export("message", ArgumentSemantic.Retain)]
        QQApiObject Message { get; set; }

        // @property (retain, nonatomic) ArkObject * arkMessage;
        [Export("arkMessage", ArgumentSemantic.Retain)]
        ArkObject ArkMessage { get; set; }

        // @property (retain, nonatomic) QQApiMiniProgramObject * miniMessage;
        [Export("miniMessage", ArgumentSemantic.Retain)]
        QQApiMiniProgramObject MiniMessage { get; set; }
    }

    // @interface SendMessageToQQResp : QQBaseResp
    [BaseType(typeof(QQBaseResp))]
    interface SendMessageToQQResp
    {
        // +(SendMessageToQQResp *)respWithResult:(NSString *)result errorDescription:(NSString *)errDesp extendInfo:(NSString *)extendInfo;
        [Static]
        [Export("respWithResult:errorDescription:extendInfo:")]
        SendMessageToQQResp RespWithResult(string result, string errDesp, string extendInfo);
    }

    // @interface ShowMessageFromQQReq : QQBaseReq
    [BaseType(typeof(QQBaseReq))]
    interface ShowMessageFromQQReq
    {
        // +(ShowMessageFromQQReq *)reqWithContent:(QQApiObject *)message;
        [Static]
        [Export("reqWithContent:")]
        ShowMessageFromQQReq ReqWithContent(QQApiObject message);

        // @property (retain, nonatomic) QQApiObject * message;
        [Export("message", ArgumentSemantic.Retain)]
        QQApiObject Message { get; set; }
    }

    // typedef void (^sendResultBlock)(NSDictionary *);
    delegate void sendResultBlock(NSDictionary arg0);

    // @protocol QQApiInterfaceDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface QQApiInterfaceDelegate
    {
        // @required -(void)onReq:(QQBaseReq *)req;
        [Abstract]
        [Export("onReq:")]
        void OnReq(QQBaseReq req);

        // @required -(void)onResp:(QQBaseResp *)resp;
        [Abstract]
        [Export("onResp:")]
        void OnResp(QQBaseResp resp);

        // @required -(void)isOnlineResponse:(NSDictionary *)response;
        [Abstract]
        [Export("isOnlineResponse:")]
        void IsOnlineResponse(NSDictionary response);
    }

    // @interface QQApiInterface : NSObject
    [BaseType(typeof(NSObject))]
    interface QQApiInterface
    {
        // +(BOOL)handleOpenURL:(NSURL *)url delegate:(id<QQApiInterfaceDelegate>)delegate;
        [Static]
        [Export("handleOpenURL:delegate:")]
        bool HandleOpenURL(NSUrl url, QQApiInterfaceDelegate @delegate);

        // +(BOOL)handleOpenUniversallink:(NSURL *)universallink delegate:(id<QQApiInterfaceDelegate>)delegate;
        [Static]
        [Export("handleOpenUniversallink:delegate:")]
        bool HandleOpenUniversallink(NSUrl universallink, QQApiInterfaceDelegate @delegate);

        // +(QQApiSendResultCode)sendReq:(QQBaseReq *)req;
        [Static]
        [Export("sendReq:")]
        QQApiSendResultCode SendReq(QQBaseReq req);

        // +(QQApiSendResultCode)SendReqToQZone:(QQBaseReq *)req;
        [Static]
        [Export("SendReqToQZone:")]
        QQApiSendResultCode SendReqToQZone(QQBaseReq req);

        // +(QQApiSendResultCode)sendMessageToQQAvatarWithReq:(QQBaseReq *)req;
        [Static]
        [Export("sendMessageToQQAvatarWithReq:")]
        QQApiSendResultCode SendMessageToQQAvatarWithReq(QQBaseReq req);

        // +(QQApiSendResultCode)sendMessageToQQAuthWithReq:(QQBaseReq *)req;
        [Static]
        [Export("sendMessageToQQAuthWithReq:")]
        QQApiSendResultCode SendMessageToQQAuthWithReq(QQBaseReq req);

        // +(QQApiSendResultCode)sendMessageToFaceCollectionWithReq:(QQBaseReq *)req;
        [Static]
        [Export("sendMessageToFaceCollectionWithReq:")]
        QQApiSendResultCode SendMessageToFaceCollectionWithReq(QQBaseReq req);

        // +(BOOL)isQQInstalled;
        [Static]
        [Export("isQQInstalled")]
        [Verify(MethodToProperty)]
        bool IsQQInstalled { get; }

        // +(BOOL)isTIMInstalled;
        [Static]
        [Export("isTIMInstalled")]
        [Verify(MethodToProperty)]
        bool IsTIMInstalled { get; }

        // +(BOOL)isQQSupportApi;
        [Static]
        [Export("isQQSupportApi")]
        [Verify(MethodToProperty)]
        bool IsQQSupportApi { get; }

        // +(BOOL)isTIMSupportApi __attribute__((deprecated("已过期, 建议删除调用，调用地方用YES替代。")));
        [Static]
        [Export("isTIMSupportApi")]
        [Verify(MethodToProperty)]
        bool IsTIMSupportApi { get; }

        // +(BOOL)isSupportShareToQQ;
        [Static]
        [Export("isSupportShareToQQ")]
        [Verify(MethodToProperty)]
        bool IsSupportShareToQQ { get; }

        // +(BOOL)isSupportPushToQZone;
        [Static]
        [Export("isSupportPushToQZone")]
        [Verify(MethodToProperty)]
        bool IsSupportPushToQZone { get; }

        // +(BOOL)openQQ;
        [Static]
        [Export("openQQ")]
        [Verify(MethodToProperty)]
        bool OpenQQ { get; }

        // +(BOOL)openTIM;
        [Static]
        [Export("openTIM")]
        [Verify(MethodToProperty)]
        bool OpenTIM { get; }

        // +(NSString *)getQQInstallUrl;
        [Static]
        [Export("getQQInstallUrl")]
        [Verify(MethodToProperty)]
        string QQInstallUrl { get; }

        // +(NSString *)getTIMInstallUrl;
        [Static]
        [Export("getTIMInstallUrl")]
        [Verify(MethodToProperty)]
        string TIMInstallUrl { get; }

        // +(void)startLogWithBlock:(QQApiLogBolock)logBlock;
        [Static]
        [Export("startLogWithBlock:")]
        void StartLogWithBlock(QQApiLogBolock logBlock);

        // +(void)stopLog;
        [Static]
        [Export("stopLog")]
        void StopLog();

        // +(void)setSwitchPrintLogToFile:(BOOL)on;
        [Static]
        [Export("setSwitchPrintLogToFile:")]
        void SetSwitchPrintLogToFile(bool on);

        // +(NSString *)getLogFilePath;
        [Static]
        [Export("getLogFilePath")]
        [Verify(MethodToProperty)]
        string LogFilePath { get; }
    }

    // @interface APIResponse : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface APIResponse : INSSecureCoding
    {
        // @property (assign, nonatomic) int detailRetCode;
        [Export("detailRetCode")]
        int DetailRetCode { get; set; }

        // @property (assign, nonatomic) int retCode;
        [Export("retCode")]
        int RetCode { get; set; }

        // @property (assign, nonatomic) int seq;
        [Export("seq")]
        int Seq { get; set; }

        // @property (retain, nonatomic) NSString * errorMsg;
        [Export("errorMsg", ArgumentSemantic.Retain)]
        string ErrorMsg { get; set; }

        // @property (retain, nonatomic) NSDictionary * jsonResponse;
        [Export("jsonResponse", ArgumentSemantic.Retain)]
        NSDictionary JsonResponse { get; set; }

        // @property (retain, nonatomic) NSString * message;
        [Export("message", ArgumentSemantic.Retain)]
        string Message { get; set; }

        // @property (retain, nonatomic) id userData;
        [Export("userData", ArgumentSemantic.Retain)]
        NSObject UserData { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const PARAM_USER_DATA;
        [Field("PARAM_USER_DATA", "__Internal")]
        NSString PARAM_USER_DATA { get; }

        // extern NSString *const PARAM_APP_ICON;
        [Field("PARAM_APP_ICON", "__Internal")]
        NSString PARAM_APP_ICON { get; }

        // extern NSString *const PARAM_APP_DESC;
        [Field("PARAM_APP_DESC", "__Internal")]
        NSString PARAM_APP_DESC { get; }

        // extern NSString *const PARAM_APP_INVITED_OPENIDS;
        [Field("PARAM_APP_INVITED_OPENIDS", "__Internal")]
        NSString PARAM_APP_INVITED_OPENIDS { get; }

        // extern NSString *const PARAM_SENDSTORY_RECEIVER;
        [Field("PARAM_SENDSTORY_RECEIVER", "__Internal")]
        NSString PARAM_SENDSTORY_RECEIVER { get; }

        // extern NSString *const PARAM_SENDSTORY_TITLE;
        [Field("PARAM_SENDSTORY_TITLE", "__Internal")]
        NSString PARAM_SENDSTORY_TITLE { get; }

        // extern NSString *const PARAM_SENDSTORY_COMMENT;
        [Field("PARAM_SENDSTORY_COMMENT", "__Internal")]
        NSString PARAM_SENDSTORY_COMMENT { get; }

        // extern NSString *const PARAM_SENDSTORY_SUMMARY;
        [Field("PARAM_SENDSTORY_SUMMARY", "__Internal")]
        NSString PARAM_SENDSTORY_SUMMARY { get; }

        // extern NSString *const PARAM_SENDSTORY_IMAGE;
        [Field("PARAM_SENDSTORY_IMAGE", "__Internal")]
        NSString PARAM_SENDSTORY_IMAGE { get; }

        // extern NSString *const PARAM_SENDSTORY_URL;
        [Field("PARAM_SENDSTORY_URL", "__Internal")]
        NSString PARAM_SENDSTORY_URL { get; }

        // extern NSString *const PARAM_SENDSTORY_ACT;
        [Field("PARAM_SENDSTORY_ACT", "__Internal")]
        NSString PARAM_SENDSTORY_ACT { get; }

        // extern NSString *const PARAM_SETUSERHEAD_PIC;
        [Field("PARAM_SETUSERHEAD_PIC", "__Internal")]
        NSString PARAM_SETUSERHEAD_PIC { get; }

        // extern NSString *const PARAM_SETUSERHEAD_FILENAME;
        [Field("PARAM_SETUSERHEAD_FILENAME", "__Internal")]
        NSString PARAM_SETUSERHEAD_FILENAME { get; }

        // extern NSString *const PARAM_RETCODE;
        [Field("PARAM_RETCODE", "__Internal")]
        NSString PARAM_RETCODE { get; }

        // extern NSString *const PARAM_MESSAGE;
        [Field("PARAM_MESSAGE", "__Internal")]
        NSString PARAM_MESSAGE { get; }

        // extern NSString *const PARAM_DATA;
        [Field("PARAM_DATA", "__Internal")]
        NSString PARAM_DATA { get; }

        // extern NSString *const TCOpenSDKErrorKeyExtraInfo;
        [Field("TCOpenSDKErrorKeyExtraInfo", "__Internal")]
        NSString TCOpenSDKErrorKeyExtraInfo { get; }

        // extern NSString *const TCOpenSDKErrorKeyRetCode;
        [Field("TCOpenSDKErrorKeyRetCode", "__Internal")]
        NSString TCOpenSDKErrorKeyRetCode { get; }

        // extern NSString *const TCOpenSDKErrorKeyMsg;
        [Field("TCOpenSDKErrorKeyMsg", "__Internal")]
        NSString TCOpenSDKErrorKeyMsg { get; }

        // extern NSString *const TCOpenSDKErrorMsgUnsupportedAPI;
        [Field("TCOpenSDKErrorMsgUnsupportedAPI", "__Internal")]
        NSString TCOpenSDKErrorMsgUnsupportedAPI { get; }

        // extern NSString *const TCOpenSDKErrorMsgSuccess;
        [Field("TCOpenSDKErrorMsgSuccess", "__Internal")]
        NSString TCOpenSDKErrorMsgSuccess { get; }

        // extern NSString *const TCOpenSDKErrorMsgUnknown;
        [Field("TCOpenSDKErrorMsgUnknown", "__Internal")]
        NSString TCOpenSDKErrorMsgUnknown { get; }

        // extern NSString *const TCOpenSDKErrorMsgUserCancel;
        [Field("TCOpenSDKErrorMsgUserCancel", "__Internal")]
        NSString TCOpenSDKErrorMsgUserCancel { get; }

        // extern NSString *const TCOpenSDKErrorMsgReLogin;
        [Field("TCOpenSDKErrorMsgReLogin", "__Internal")]
        NSString TCOpenSDKErrorMsgReLogin { get; }

        // extern NSString *const TCOpenSDKErrorMsgOperationDeny;
        [Field("TCOpenSDKErrorMsgOperationDeny", "__Internal")]
        NSString TCOpenSDKErrorMsgOperationDeny { get; }

        // extern NSString *const TCOpenSDKErrorMsgNetwork;
        [Field("TCOpenSDKErrorMsgNetwork", "__Internal")]
        NSString TCOpenSDKErrorMsgNetwork { get; }

        // extern NSString *const TCOpenSDKErrorMsgURL;
        [Field("TCOpenSDKErrorMsgURL", "__Internal")]
        NSString TCOpenSDKErrorMsgURL { get; }

        // extern NSString *const TCOpenSDKErrorMsgDataParse;
        [Field("TCOpenSDKErrorMsgDataParse", "__Internal")]
        NSString TCOpenSDKErrorMsgDataParse { get; }

        // extern NSString *const TCOpenSDKErrorMsgParam;
        [Field("TCOpenSDKErrorMsgParam", "__Internal")]
        NSString TCOpenSDKErrorMsgParam { get; }

        // extern NSString *const TCOpenSDKErrorMsgTimeout;
        [Field("TCOpenSDKErrorMsgTimeout", "__Internal")]
        NSString TCOpenSDKErrorMsgTimeout { get; }

        // extern NSString *const TCOpenSDKErrorMsgSecurity;
        [Field("TCOpenSDKErrorMsgSecurity", "__Internal")]
        NSString TCOpenSDKErrorMsgSecurity { get; }

        // extern NSString *const TCOpenSDKErrorMsgIO;
        [Field("TCOpenSDKErrorMsgIO", "__Internal")]
        NSString TCOpenSDKErrorMsgIO { get; }

        // extern NSString *const TCOpenSDKErrorMsgServer;
        [Field("TCOpenSDKErrorMsgServer", "__Internal")]
        NSString TCOpenSDKErrorMsgServer { get; }

        // extern NSString *const TCOpenSDKErrorMsgWebPage;
        [Field("TCOpenSDKErrorMsgWebPage", "__Internal")]
        NSString TCOpenSDKErrorMsgWebPage { get; }

        // extern NSString *const TCOpenSDKErrorMsgUserHeadPicLarge;
        [Field("TCOpenSDKErrorMsgUserHeadPicLarge", "__Internal")]
        NSString TCOpenSDKErrorMsgUserHeadPicLarge { get; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const kOPEN_PERMISSION_ADD_TOPIC;
        [Field("kOPEN_PERMISSION_ADD_TOPIC", "__Internal")]
        NSString kOPEN_PERMISSION_ADD_TOPIC { get; }

        // extern NSString *const kOPEN_PERMISSION_ADD_ALBUM;
        [Field("kOPEN_PERMISSION_ADD_ALBUM", "__Internal")]
        NSString kOPEN_PERMISSION_ADD_ALBUM { get; }

        // extern NSString *const kOPEN_PERMISSION_UPLOAD_PIC;
        [Field("kOPEN_PERMISSION_UPLOAD_PIC", "__Internal")]
        NSString kOPEN_PERMISSION_UPLOAD_PIC { get; }

        // extern NSString *const kOPEN_PERMISSION_LIST_ALBUM;
        [Field("kOPEN_PERMISSION_LIST_ALBUM", "__Internal")]
        NSString kOPEN_PERMISSION_LIST_ALBUM { get; }

        // extern NSString *const kOPEN_PERMISSION_CHECK_PAGE_FANS;
        [Field("kOPEN_PERMISSION_CHECK_PAGE_FANS", "__Internal")]
        NSString kOPEN_PERMISSION_CHECK_PAGE_FANS { get; }

        // extern NSString *const kOPEN_PERMISSION_GET_INFO;
        [Field("kOPEN_PERMISSION_GET_INFO", "__Internal")]
        NSString kOPEN_PERMISSION_GET_INFO { get; }

        // extern NSString *const kOPEN_PERMISSION_GET_OTHER_INFO;
        [Field("kOPEN_PERMISSION_GET_OTHER_INFO", "__Internal")]
        NSString kOPEN_PERMISSION_GET_OTHER_INFO { get; }

        // extern NSString *const kOPEN_PERMISSION_GET_VIP_INFO;
        [Field("kOPEN_PERMISSION_GET_VIP_INFO", "__Internal")]
        NSString kOPEN_PERMISSION_GET_VIP_INFO { get; }

        // extern NSString *const kOPEN_PERMISSION_GET_VIP_RICH_INFO;
        [Field("kOPEN_PERMISSION_GET_VIP_RICH_INFO", "__Internal")]
        NSString kOPEN_PERMISSION_GET_VIP_RICH_INFO { get; }

        // extern NSString *const kOPEN_PERMISSION_GET_USER_INFO;
        [Field("kOPEN_PERMISSION_GET_USER_INFO", "__Internal")]
        NSString kOPEN_PERMISSION_GET_USER_INFO { get; }

        // extern NSString *const kOPEN_PERMISSION_GET_SIMPLE_USER_INFO;
        [Field("kOPEN_PERMISSION_GET_SIMPLE_USER_INFO", "__Internal")]
        NSString kOPEN_PERMISSION_GET_SIMPLE_USER_INFO { get; }
    }

    // @interface TCAPIRequest : NSMutableDictionary
    [BaseType(typeof(NSMutableDictionary))]
    interface TCAPIRequest
    {
        // @property (readonly, nonatomic) NSURL * apiURL;
        [Export("apiURL")]
        NSUrl ApiURL { get; }

        // @property (readonly, nonatomic) NSString * method;
        [Export("method")]
        string Method { get; }

        // @property (retain, nonatomic) TCRequiredId paramUserData;
        [Export("paramUserData", ArgumentSemantic.Retain)]
        NSObject ParamUserData { get; set; }

        // @property (readonly, nonatomic) APIResponse * response;
        [Export("response")]
        APIResponse Response { get; }

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();
    }

    // @protocol TCAPIRequestDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface TCAPIRequestDelegate
    {
        // @optional -(void)cgiRequest:(TCAPIRequest *)request didResponse:(APIResponse *)response;
        [Export("cgiRequest:didResponse:")]
        void DidResponse(TCAPIRequest request, APIResponse response);
    }

    // @interface TencentOAuth : NSObject
    [BaseType(typeof(NSObject))]
    interface TencentOAuth
    {
        // @property (copy, nonatomic) NSString * accessToken;
        [Export("accessToken")]
        string AccessToken { get; set; }

        // @property (copy, nonatomic) NSDate * expirationDate;
        [Export("expirationDate", ArgumentSemantic.Copy)]
        NSDate ExpirationDate { get; set; }

        [Wrap("WeakSessionDelegate")]
        TencentSessionDelegate SessionDelegate { get; set; }

        // @property (assign, nonatomic) id<TencentSessionDelegate> sessionDelegate;
        [NullAllowed, Export("sessionDelegate", ArgumentSemantic.Assign)]
        NSObject WeakSessionDelegate { get; set; }

        // @property (copy, nonatomic) NSString * localAppId;
        [Export("localAppId")]
        string LocalAppId { get; set; }

        // @property (copy, nonatomic) NSString * openId;
        [Export("openId")]
        string OpenId { get; set; }

        // @property (copy, nonatomic) NSString * redirectURI;
        [Export("redirectURI")]
        string RedirectURI { get; set; }

        // @property (retain, nonatomic) NSString * appId;
        [Export("appId", ArgumentSemantic.Retain)]
        string AppId { get; set; }

        // @property (retain, nonatomic) NSString * universalLink;
        [Export("universalLink", ArgumentSemantic.Retain)]
        string UniversalLink { get; set; }

        // @property (retain, nonatomic) NSString * uin;
        [Export("uin", ArgumentSemantic.Retain)]
        string Uin { get; set; }

        // @property (retain, nonatomic) NSString * skey;
        [Export("skey", ArgumentSemantic.Retain)]
        string Skey { get; set; }

        // @property (copy, nonatomic) NSDictionary * passData;
        [Export("passData", ArgumentSemantic.Copy)]
        NSDictionary PassData { get; set; }

        // @property (assign, nonatomic) TencentAuthMode authMode;
        [Export("authMode", ArgumentSemantic.Assign)]
        TencentAuthMode AuthMode { get; set; }

        // @property (retain, nonatomic) NSString * unionid;
        [Export("unionid", ArgumentSemantic.Retain)]
        string Unionid { get; set; }

        // @property (assign, nonatomic) TencentAuthShareType authShareType;
        [Export("authShareType", ArgumentSemantic.Assign)]
        TencentAuthShareType AuthShareType { get; set; }

        // -(NSString *)getCachedToken;
        [Export("getCachedToken")]
        [Verify(MethodToProperty)]
        string CachedToken { get; }

        // -(NSString *)getCachedOpenID;
        [Export("getCachedOpenID")]
        [Verify(MethodToProperty)]
        string CachedOpenID { get; }

        // -(NSDate *)getCachedExpirationDate;
        [Export("getCachedExpirationDate")]
        [Verify(MethodToProperty)]
        NSDate CachedExpirationDate { get; }

        // -(BOOL)isCachedTokenValid;
        [Export("isCachedTokenValid")]
        [Verify(MethodToProperty)]
        bool IsCachedTokenValid { get; }

        // -(BOOL)deleteCachedToken;
        [Export("deleteCachedToken")]
        [Verify(MethodToProperty)]
        bool DeleteCachedToken { get; }

        // +(NSString *)sdkVersion;
        [Static]
        [Export("sdkVersion")]
        [Verify(MethodToProperty)]
        string SdkVersion { get; }

        // +(NSString *)sdkSubVersion;
        [Static]
        [Export("sdkSubVersion")]
        [Verify(MethodToProperty)]
        string SdkSubVersion { get; }

        // +(BOOL)isLiteSDK;
        [Static]
        [Export("isLiteSDK")]
        [Verify(MethodToProperty)]
        bool IsLiteSDK { get; }

        // +(TencentAuthorizeState *)authorizeState;
        [Static]
        [Export("authorizeState")]
        [Verify(MethodToProperty)]
        unsafe TencentAuthorizeState* AuthorizeState { get; }

        // -(id)initWithAppId:(NSString *)appId andDelegate:(id<TencentSessionDelegate>)delegate;
        [Export("initWithAppId:andDelegate:")]
        IntPtr Constructor(string appId, TencentSessionDelegate @delegate);

        // -(id)initWithAppId:(NSString *)appId andUniversalLink:(NSString *)universalLink andDelegate:(id<TencentSessionDelegate>)delegate;
        [Export("initWithAppId:andUniversalLink:andDelegate:")]
        IntPtr Constructor(string appId, string universalLink, TencentSessionDelegate @delegate);

        // -(id)initWithAppId:(NSString *)appId enableUniveralLink:(BOOL)enabled universalLink:(NSString *)universalLink delegate:(id<TencentSessionDelegate>)delegate;
        [Export("initWithAppId:enableUniveralLink:universalLink:delegate:")]
        IntPtr Constructor(string appId, bool enabled, string universalLink, TencentSessionDelegate @delegate);

        // +(BOOL)iphoneQQInstalled;
        [Static]
        [Export("iphoneQQInstalled")]
        [Verify(MethodToProperty)]
        bool IphoneQQInstalled { get; }

        // +(BOOL)iphoneTIMInstalled;
        [Static]
        [Export("iphoneTIMInstalled")]
        [Verify(MethodToProperty)]
        bool IphoneTIMInstalled { get; }

        // -(BOOL)authorize:(NSArray *)permissions;
        [Export("authorize:")]
        [Verify(StronglyTypedNSArray)]
        bool Authorize(NSObject[] permissions);

        // -(BOOL)authorize:(NSArray *)permissions localAppId:(NSString *)localAppId;
        [Export("authorize:localAppId:")]
        [Verify(StronglyTypedNSArray)]
        bool Authorize(NSObject[] permissions, string localAppId);

        // -(BOOL)authorizeWithQRlogin:(NSArray *)permissions;
        [Export("authorizeWithQRlogin:")]
        [Verify(StronglyTypedNSArray)]
        bool AuthorizeWithQRlogin(NSObject[] permissions);

        // -(BOOL)incrAuthWithPermissions:(NSArray *)permissions;
        [Export("incrAuthWithPermissions:")]
        [Verify(StronglyTypedNSArray)]
        bool IncrAuthWithPermissions(NSObject[] permissions);

        // -(BOOL)reauthorizeWithPermissions:(NSArray *)permissions;
        [Export("reauthorizeWithPermissions:")]
        [Verify(StronglyTypedNSArray)]
        bool ReauthorizeWithPermissions(NSObject[] permissions);

        // -(BOOL)RequestUnionId;
        [Export("RequestUnionId")]
        [Verify(MethodToProperty)]
        bool RequestUnionId { get; }

        // +(BOOL)HandleOpenURL:(NSURL *)url;
        [Static]
        [Export("HandleOpenURL:")]
        bool HandleOpenURL(NSUrl url);

        // +(BOOL)CanHandleOpenURL:(NSURL *)url;
        [Static]
        [Export("CanHandleOpenURL:")]
        bool CanHandleOpenURL(NSUrl url);

        // +(BOOL)HandleUniversalLink:(NSURL *)url;
        [Static]
        [Export("HandleUniversalLink:")]
        bool HandleUniversalLink(NSUrl url);

        // +(BOOL)CanHandleUniversalLink:(NSURL *)url;
        [Static]
        [Export("CanHandleUniversalLink:")]
        bool CanHandleUniversalLink(NSUrl url);

        // +(NSString *)getLastErrorMsg;
        [Static]
        [Export("getLastErrorMsg")]
        [Verify(MethodToProperty)]
        string LastErrorMsg { get; }

        // -(NSString *)getServerSideCode;
        [Export("getServerSideCode")]
        [Verify(MethodToProperty)]
        string ServerSideCode { get; }

        // -(void)logout:(id<TencentSessionDelegate>)delegate;
        [Export("logout:")]
        void Logout(TencentSessionDelegate @delegate);

        // -(BOOL)isSessionValid;
        [Export("isSessionValid")]
        [Verify(MethodToProperty)]
        bool IsSessionValid { get; }

        // -(BOOL)getUserInfo;
        [Export("getUserInfo")]
        [Verify(MethodToProperty)]
        bool UserInfo { get; }

        // -(BOOL)cancel:(id)userData;
        [Export("cancel:")]
        bool Cancel(NSObject userData);

        // -(TCAPIRequest *)cgiRequestWithURL:(NSURL *)apiURL method:(NSString *)method params:(NSDictionary *)params callback:(id<TCAPIRequestDelegate>)callback;
        [Export("cgiRequestWithURL:method:params:callback:")]
        TCAPIRequest CgiRequestWithURL(NSUrl apiURL, string method, NSDictionary @params, TCAPIRequestDelegate callback);

        // -(BOOL)sendAPIRequest:(TCAPIRequest *)request callback:(id<TCAPIRequestDelegate>)callback;
        [Export("sendAPIRequest:callback:")]
        bool SendAPIRequest(TCAPIRequest request, TCAPIRequestDelegate callback);

        // -(NSString *)getUserOpenID;
        [Export("getUserOpenID")]
        [Verify(MethodToProperty)]
        string UserOpenID { get; }
    }

    // @protocol TencentLoginDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface TencentLoginDelegate
    {
        // @required -(void)tencentDidLogin;
        [Abstract]
        [Export("tencentDidLogin")]
        void TencentDidLogin();

        // @required -(void)tencentDidNotLogin:(BOOL)cancelled;
        [Abstract]
        [Export("tencentDidNotLogin:")]
        void TencentDidNotLogin(bool cancelled);

        // @required -(void)tencentDidNotNetWork;
        [Abstract]
        [Export("tencentDidNotNetWork")]
        void TencentDidNotNetWork();

        // @optional -(NSArray *)getAuthorizedPermissions:(NSArray *)permissions withExtraParams:(NSDictionary *)extraParams __attribute__((deprecated("该接口已过期, 建议删除调用")));
        [Export("getAuthorizedPermissions:withExtraParams:")]
        [Verify(StronglyTypedNSArray), Verify(StronglyTypedNSArray)]
        NSObject[] GetAuthorizedPermissions(NSObject[] permissions, NSDictionary extraParams);

        // @optional -(void)didGetUnionID;
        [Export("didGetUnionID")]
        void DidGetUnionID();

        // @optional -(BOOL)forceWebLogin;
        [Export("forceWebLogin")]
        [Verify(MethodToProperty)]
        bool ForceWebLogin { get; }
    }

    // @protocol TencentSessionDelegate <NSObject, TencentLoginDelegate, TencentWebViewDelegate>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface TencentSessionDelegate : ITencentLoginDelegate, ITencentWebViewDelegate
    {
        // @optional -(void)tencentDidLogout;
        [Export("tencentDidLogout")]
        void TencentDidLogout();

        // @optional -(BOOL)tencentNeedPerformIncrAuth:(TencentOAuth *)tencentOAuth withPermissions:(NSArray *)permissions;
        [Export("tencentNeedPerformIncrAuth:withPermissions:")]
        [Verify(StronglyTypedNSArray)]
        bool TencentNeedPerformIncrAuth(TencentOAuth tencentOAuth, NSObject[] permissions);

        // @optional -(BOOL)tencentNeedPerformReAuth:(TencentOAuth *)tencentOAuth;
        [Export("tencentNeedPerformReAuth:")]
        bool TencentNeedPerformReAuth(TencentOAuth tencentOAuth);

        // @optional -(void)tencentDidUpdate:(TencentOAuth *)tencentOAuth;
        [Export("tencentDidUpdate:")]
        void TencentDidUpdate(TencentOAuth tencentOAuth);

        // @optional -(void)tencentFailedUpdate:(UpdateFailType)reason;
        [Export("tencentFailedUpdate:")]
        void TencentFailedUpdate(UpdateFailType reason);

        // @optional -(void)getUserInfoResponse:(APIResponse *)response;
        [Export("getUserInfoResponse:")]
        void GetUserInfoResponse(APIResponse response);

        // @optional -(void)responseDidReceived:(APIResponse *)response forMessage:(NSString *)message;
        [Export("responseDidReceived:forMessage:")]
        void ResponseDidReceived(APIResponse response, string message);

        // @optional -(void)tencentOAuth:(TencentOAuth *)tencentOAuth didSendBodyData:(NSInteger)bytesWritten totalBytesWritten:(NSInteger)totalBytesWritten totalBytesExpectedToWrite:(NSInteger)totalBytesExpectedToWrite userData:(id)userData;
        [Export("tencentOAuth:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:userData:")]
        void TencentOAuth(TencentOAuth tencentOAuth, nint bytesWritten, nint totalBytesWritten, nint totalBytesExpectedToWrite, NSObject userData);

        // @optional -(void)tencentOAuth:(TencentOAuth *)tencentOAuth doCloseViewController:(UIViewController *)viewController;
        [Export("tencentOAuth:doCloseViewController:")]
        void TencentOAuth(TencentOAuth tencentOAuth, UIViewController viewController);
    }

    // @protocol TencentWebViewDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface TencentWebViewDelegate
    {
        // @optional -(BOOL)tencentWebViewShouldAutorotateToInterfaceOrientation:(UIInterfaceOrientation)toInterfaceOrientation;
        [Export("tencentWebViewShouldAutorotateToInterfaceOrientation:")]
        bool TencentWebViewShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation);

        // @optional -(NSUInteger)tencentWebViewSupportedInterfaceOrientationsWithWebkit;
        [Export("tencentWebViewSupportedInterfaceOrientationsWithWebkit")]
        [Verify(MethodToProperty)]
        nuint TencentWebViewSupportedInterfaceOrientationsWithWebkit { get; }

        // @optional -(BOOL)tencentWebViewShouldAutorotateWithWebkit;
        [Export("tencentWebViewShouldAutorotateWithWebkit")]
        [Verify(MethodToProperty)]
        bool TencentWebViewShouldAutorotateWithWebkit { get; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern double StaticLibraryModuleVersionNumber;
        [Field("StaticLibraryModuleVersionNumber", "__Internal")]
        double StaticLibraryModuleVersionNumber { get; }

        // extern const unsigned char [] StaticLibraryModuleVersionString;
        [Field("StaticLibraryModuleVersionString", "__Internal")]
        byte[] StaticLibraryModuleVersionString { get; }
    }
}