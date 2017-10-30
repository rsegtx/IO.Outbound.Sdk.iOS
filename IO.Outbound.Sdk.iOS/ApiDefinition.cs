using Foundation;

namespace IO.Outbound.Sdk
{
	// @interface Outbound
	[BaseType(typeof(NSObject))]
    interface Outbound
    {
		// +(void)initWithPrivateKey:(NSString *)apiKey;
		[Static]
		[Export("initWithPrivateKey:")]
		void InitWithPrivateKey(string apiKey);

		// +(void)setDebug:(BOOL)debug;
		[Static]
		[Export("setDebug:")]
		void SetDebug(bool debug);

		// +(void)identifyUserWithId:(NSString *)userId attributes:(NSDictionary *)attributes;
		[Static]
		[Export("identifyUserWithId:attributes:")]
		void IdentifyUserWithId(string userId, NSDictionary attributes);

		// +(void)alias:(NSString *)newUserId;
		[Static]
		[Export("alias:")]
		void Alias(string newUserId);

		// +(void)trackEvent:(NSString *)event withProperties:(NSDictionary *)properties;
		[Static]
		[Export("trackEvent:withProperties:")]
		void TrackEvent(string @event, NSDictionary properties);

		// +(void)registerDeviceToken:(NSData *)deviceToken;
		[Static]
		[Export("registerDeviceToken:")]
		void RegisterDeviceToken(NSData deviceToken);

		// +(void)disableDeviceToken;
		[Static]
		[Export("disableDeviceToken")]
		void DisableDeviceToken();

		// +(void)identifyGroupWithId:(NSString *)groupId userId:(NSString *)userId groupAttributes:(NSDictionary *)groupAttributes andUserAttributes:(NSDictionary *)userAttributes;
		[Static]
		[Export("identifyGroupWithId:userId:groupAttributes:andUserAttributes:")]
		void IdentifyGroupWithId(string groupId, string userId, NSDictionary groupAttributes, NSDictionary userAttributes);

		// +(_Bool)isUninstallTracker:(NSDictionary *)userInfo;
		[Static]
		[Export("isUninstallTracker:")]
		bool IsUninstallTracker(NSDictionary userInfo);

		// +(void)logout;
		[Static]
		[Export("logout")]
		void Logout();

	}
}