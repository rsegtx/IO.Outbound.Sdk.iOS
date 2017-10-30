using Foundation;

// @interface Outbound
interface Outbound
{
	// +(void)initWithPrivateKey:(id)apiKey;
	[Static]
	[Export ("initWithPrivateKey:")]
	void InitWithPrivateKey (NSObject apiKey);

	// +(void)setDebug:(id)debug;
	[Static]
	[Export ("setDebug:")]
	void SetDebug (NSObject debug);

	// +(void)identifyUserWithId:(id)userId attributes:(id)attributes;
	[Static]
	[Export ("identifyUserWithId:attributes:")]
	void IdentifyUserWithId (NSObject userId, NSObject attributes);

	// +(void)alias:(id)newUserId;
	[Static]
	[Export ("alias:")]
	void Alias (NSObject newUserId);

	// +(void)trackEvent:(id)event withProperties:(id)properties;
	[Static]
	[Export ("trackEvent:withProperties:")]
	void TrackEvent (NSObject @event, NSObject properties);

	// +(void)registerDeviceToken:(id)deviceToken;
	[Static]
	[Export ("registerDeviceToken:")]
	void RegisterDeviceToken (NSObject deviceToken);

	// +(void)disableDeviceToken;
	[Static]
	[Export ("disableDeviceToken")]
	void DisableDeviceToken ();

	// +(void)identifyGroupWithId:(id)groupId userId:(id)userId groupAttributes:(id)groupAttributes andUserAttributes:(id)userAttributes;
	[Static]
	[Export ("identifyGroupWithId:userId:groupAttributes:andUserAttributes:")]
	void IdentifyGroupWithId (NSObject groupId, NSObject userId, NSObject groupAttributes, NSObject userAttributes);

	// +(id)isUninstallTracker:(id)userInfo;
	[Static]
	[Export ("isUninstallTracker:")]
	NSObject IsUninstallTracker (NSObject userInfo);

	// +(void)logout;
	[Static]
	[Export ("logout")]
	void Logout ();
}
