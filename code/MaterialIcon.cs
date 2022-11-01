namespace IconBrowserTool;

public static partial class MaterialIconUtility
{
	public static MaterialIcon Lookup( string name )
	{
		if ( ValueToIcon.TryGetValue( name, out var icon ) )
			return (MaterialIcon)icon;

		return default;
	}

	public static string Lookup( MaterialIcon icon )
	{
		if ( IconToValue.TryGetValue( (int)icon, out var name ) )
			return name;

		return "null";
	}
}

public enum MaterialIcon
{
	InvalidIcon = 0,

	/// <summary>10000, 10K, alphabet, character, digit, display, font, letter, number, pixel, pixels, resolution, symbol, text, type, video</summary>
	/// <value>10k</value>
	TenK = 59729,

	/// <summary>10, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>10mp</value>
	TenMp = 59730,

	/// <summary>11, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>11mp</value>
	ElevenMp = 59731,

	/// <summary></summary>
	/// <value>123</value>
	OneTwoThree = 60301,

	/// <summary>12, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>12mp</value>
	TwelveMp = 59732,

	/// <summary>13, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>13mp</value>
	ThirteenMp = 59733,

	/// <summary>14, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>14mp</value>
	FourteenMp = 59734,

	/// <summary>15, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>15mp</value>
	FifteenMp = 59735,

	/// <summary>16, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>16mp</value>
	SixteenMp = 59736,

	/// <summary>17, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>17mp</value>
	SeventeenMp = 59737,

	/// <summary>18, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>18mp</value>
	EighteenMp = 59738,

	/// <summary>19, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>19mp</value>
	NineteenMp = 59739,

	/// <summary>1000, 1K, alphabet, character, digit, display, font, letter, number, pixel, pixels, resolution, symbol, text, type, video</summary>
	/// <value>1k</value>
	OneK = 59740,

	/// <summary>+, 1000, 1K, alphabet, character, digit, display, font, letter, number, pixel, pixels, plus, resolution, symbol, text, type, video</summary>
	/// <value>1k_plus</value>
	OneKPlus = 59741,

	/// <summary>1x, alphabet, cellular, character, digit, font, letter, mobile, mobiledata, network, number, phone, signal, speed, symbol, text, type, wifi</summary>
	/// <value>1x_mobiledata</value>
	OneXMobileData = 61389,

	/// <summary>20, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>20mp</value>
	TwentyMp = 59742,

	/// <summary>21, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>21mp</value>
	TwentyOneMp = 59743,

	/// <summary>22, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>22mp</value>
	TwentyTwoMp = 59744,

	/// <summary>23, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>23mp</value>
	TwentyThreeMp = 59745,

	/// <summary>24, camera, digits, font, image, letters, megapixel, megapixels, mp, numbers, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>24mp</value>
	TwentyFourMp = 59746,

	/// <summary>2000, 2K, alphabet, character, digit, display, font, letter, number, pixel, pixels, resolution, symbol, text, type, video</summary>
	/// <value>2k</value>
	TwoK = 59747,

	/// <summary>+, 2k, alphabet, character, digit, font, letter, number, plus, symbol, text, type</summary>
	/// <value>2k_plus</value>
	TwoKPlus = 59748,

	/// <summary>2, camera, digit, font, image, letters, megapixel, megapixels, mp, number, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>2mp</value>
	TwoMp = 59749,

	/// <summary>30fps, alphabet, camera, character, digit, font, fps, frames, letter, number, symbol, text, type, video</summary>
	/// <value>30fps</value>
	ThirtyFps = 61390,

	/// <summary>30, camera, digits, fps, frame, frequency, image, numbers, per, rate, second, seconds, select, video</summary>
	/// <value>30fps_select</value>
	ThirtyFpsSelect = 61391,

	/// <summary>360, arrow, av, camera, direction, rotate, rotation, vr</summary>
	/// <value>360</value>
	ThreeHundredAndSixty = 58743,

	/// <summary>3, 3d, D, alphabet, arrow, arrows, av, camera, character, digit, font, letter, number, rotation, symbol, text, type, vr</summary>
	/// <value>3d_rotation</value>
	Rotation3D = 59469,

	/// <summary>3g, alphabet, cellular, character, digit, font, letter, mobile, mobiledata, network, number, phone, signal, speed, symbol, text, type, wifi</summary>
	/// <value>3g_mobiledata</value>
	MobileData3G = 61392,

	/// <summary>3000, 3K, alphabet, character, digit, display, font, letter, number, pixel, pixels, resolution, symbol, text, type, video</summary>
	/// <value>3k</value>
	ThreeK = 59750,

	/// <summary>+, 3000, 3K, alphabet, character, digit, display, font, letter, number, pixel, pixels, plus, resolution, symbol, text, type, video</summary>
	/// <value>3k_plus</value>
	ThreeKPlus = 59751,

	/// <summary>3, camera, digit, font, image, letters, megapixel, megapixels, mp, number, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>3mp</value>
	ThreeMp = 59752,

	/// <summary>3, 3p, account, avatar, bubble, chat, comment, communicate, face, human, message, party, people, person, profile, speech, user</summary>
	/// <value>3p</value>
	ThreeG = 61393,

	/// <summary>4g, alphabet, cellular, character, digit, font, letter, mobile, mobiledata, network, number, phone, signal, speed, symbol, text, type, wifi</summary>
	/// <value>4g_mobiledata</value>
	MobileData4G = 61394,

	/// <summary>4g, alphabet, cellular, character, digit, font, letter, mobile, mobiledata, network, number, phone, plus, signal, speed, symbol, text, type, wifi</summary>
	/// <value>4g_plus_mobiledata</value>
	MobileData4GPlus = 61395,

	/// <summary>4000, 4K, alphabet, character, digit, display, font, letter, number, pixel, pixels, resolution, symbol, text, type, video</summary>
	/// <value>4k</value>
	FourK = 57458,

	/// <summary>+, 4000, 4K, alphabet, character, digit, display, font, letter, number, pixel, pixels, plus, resolution, symbol, text, type, video</summary>
	/// <value>4k_plus</value>
	FourKPlus = 59753,

	/// <summary>4, camera, digit, font, image, letters, megapixel, megapixels, mp, number, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>4mp</value>
	FourMp = 59754,

	/// <summary>5g, alphabet, cellular, character, data, digit, font, letter, mobile, network, number, phone, signal, speed, symbol, text, type, wifi</summary>
	/// <value>5g</value>
	FiveG = 61240,

	/// <summary>5000, 5K, alphabet, character, digit, display, font, letter, number, pixel, pixels, resolution, symbol, text, type, video</summary>
	/// <value>5k</value>
	FiveK = 59755,

	/// <summary>+, 5000, 5K, alphabet, character, digit, display, font, letter, number, pixel, pixels, plus, resolution, symbol, text, type, video</summary>
	/// <value>5k_plus</value>
	FivePlus = 59756,

	/// <summary>5, camera, digit, font, image, letters, megapixel, megapixels, mp, number, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>5mp</value>
	FiveMp = 59757,

	/// <summary>60fps, camera, digit, fps, frames, number, symbol, video</summary>
	/// <value>60fps</value>
	SixtyFps = 61396,

	/// <summary>60, camera, digits, fps, frame, frequency, numbers, per, rate, second, seconds, select, video</summary>
	/// <value>60fps_select</value>
	SixtyFpsSelect = 61397,

	/// <summary>6, apart, body, covid, distance, feet, ft, human, people, person, social</summary>
	/// <value>6_ft_apart</value>
	SixFeetApart = 61982,

	/// <summary>6000, 6K, alphabet, character, digit, display, font, letter, number, pixel, pixels, resolution, symbol, text, type, video</summary>
	/// <value>6k</value>
	SixK = 59758,

	/// <summary>+, 6000, 6K, alphabet, character, digit, display, font, letter, number, pixel, pixels, plus, resolution, symbol, text, type, video</summary>
	/// <value>6k_plus</value>
	SixKPlus = 59759,

	/// <summary>6, camera, digit, font, image, letters, megapixel, megapixels, mp, number, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>6mp</value>
	SixMp = 59760,

	/// <summary>7000, 7K, alphabet, character, digit, display, font, letter, number, pixel, pixels, resolution, symbol, text, type, video</summary>
	/// <value>7k</value>
	SevenK = 59761,

	/// <summary>+, 7000, 7K, alphabet, character, digit, display, font, letter, number, pixel, pixels, plus, resolution, symbol, text, type, video</summary>
	/// <value>7k_plus</value>
	SevenKPlus = 59762,

	/// <summary>7, camera, digit, font, image, letters, megapixel, megapixels, mp, number, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>7mp</value>
	SevenMp = 59763,

	/// <summary>8000, 8K, alphabet, character, digit, display, font, letter, number, pixel, pixels, resolution, symbol, text, type, video</summary>
	/// <value>8k</value>
	Eight = 59764,

	/// <summary>+, 7000, 8K, alphabet, character, digit, display, font, letter, number, pixel, pixels, plus, resolution, symbol, text, type, video</summary>
	/// <value>8k_plus</value>
	EightK = 59765,

	/// <summary>8, camera, digit, font, image, letters, megapixel, megapixels, mp, number, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>8mp</value>
	EightMp = 59766,

	/// <summary>9000, 9K, alphabet, character, digit, display, font, letter, number, pixel, pixels, resolution, symbol, text, type, video</summary>
	/// <value>9k</value>
	Nine = 59767,

	/// <summary>+, 9000, 9K, alphabet, character, digit, display, font, letter, number, pixel, pixels, plus, resolution, symbol, text, type, video</summary>
	/// <value>9k_plus</value>
	NinePlus = 59768,

	/// <summary>9, camera, digit, font, image, letters, megapixel, megapixels, mp, number, pixel, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>9mp</value>
	NineMp = 59769,

	/// <summary></summary>
	/// <value>abc</value>
	Abc = 60308,

	/// <summary>ac, air, cold, conditioner, flake, snow, temperature, unit, weather, winter</summary>
	/// <value>ac_unit</value>
	AcUnit = 60219,

	/// <summary></summary>
	/// <value>access_alarm</value>
	AccessAlarm = 57744,

	/// <summary></summary>
	/// <value>access_alarms</value>
	AccessAlarms = 57745,

	/// <summary></summary>
	/// <value>access_time</value>
	AccessTime = 57746,

	/// <summary></summary>
	/// <value>access_time_filled</value>
	AccessTimeFilled = 61398,

	/// <summary>accessibility, accessible, body, handicap, help, human, people, person</summary>
	/// <value>accessibility</value>
	Accessibility = 59470,

	/// <summary>accessibility, accessible, body, handicap, help, human, people, person</summary>
	/// <value>accessibility_new</value>
	AccessibilityNew = 59692,

	/// <summary>accessibility, accessible, body, handicap, help, human, people, person, wheelchair</summary>
	/// <value>accessible</value>
	Accessible = 59668,

	/// <summary>accessibility, accessible, body, forward, handicap, help, human, people, person, wheelchair</summary>
	/// <value>accessible_forward</value>
	AccessibleForward = 59700,

	/// <summary>account, balance, bank, bill, card, cash, coin, commerce, credit, currency, dollars, finance, money, online, pay, payment</summary>
	/// <value>account_balance</value>
	AccountBalance = 59471,

	/// <summary>account, balance, bank, bill, card, cash, coin, commerce, credit, currency, dollars, finance, money, online, pay, payment, wallet</summary>
	/// <value>account_balance_wallet</value>
	AccountBalanceWallet = 59472,

	/// <summary>account, avatar, box, face, human, people, person, profile, square, thumbnail, user</summary>
	/// <value>account_box</value>
	AccountBox = 59473,

	/// <summary>account, avatar, circle, face, human, people, person, profile, thumbnail, user</summary>
	/// <value>account_circle</value>
	AccountCircle = 59475,

	/// <summary>account, analytics, chart, connect, data, diagram, flow, graph, infographic, measure, metrics, process, square, statistics, structure, tracking, tree</summary>
	/// <value>account_tree</value>
	AccountTree = 59770,

	/// <summary>Android, OS, ad, banner, cell, device, hardware, iOS, mobile, notification, notifications, phone, tablet, top, units</summary>
	/// <value>ad_units</value>
	AdUnits = 61241,

	/// <summary>adb, android, bridge, debug</summary>
	/// <value>adb</value>
	Adb = 58894,

	/// <summary>+, add, create, new, new symbol, plus, symbol</summary>
	/// <value>add</value>
	Add = 57669,

	/// <summary>+, a photo, add, camera, lens, new, photography, picture, plus, symbol</summary>
	/// <value>add_a_photo</value>
	AddAPhoto = 58425,

	/// <summary></summary>
	/// <value>add_alarm</value>
	AddAlarm = 57747,

	/// <summary>+, active, add, alarm, alert, bell, chime, new, notifications, notify, plus, reminder, ring, sound, symbol</summary>
	/// <value>add_alert</value>
	AddAlert = 57347,

	/// <summary>add, box, new square, plus, symbol</summary>
	/// <value>add_box</value>
	AddBox = 57670,

	/// <summary>+, add, business, market, plus, retail, shop, shopping, store, storefront</summary>
	/// <value>add_business</value>
	AddBusiness = 59177,

	/// <summary></summary>
	/// <value>add_card</value>
	AddCard = 60294,

	/// <summary>+, add, analytics, bar, bars, chart, data, diagram, graph, infographic, measure, metrics, new, plus, statistics, symbol, tracking</summary>
	/// <value>add_chart</value>
	AddChart = 59771,

	/// <summary>+, add, circle, create, new, plus</summary>
	/// <value>add_circle</value>
	AddCircle = 57671,

	/// <summary>+, add, circle, create, new, outline, plus</summary>
	/// <value>add_circle_outline</value>
	AddCircleOutline = 57672,

	/// <summary>+, add, bubble, chat, comment, communicate, feedback, message, new, plus, speech, symbol</summary>
	/// <value>add_comment</value>
	AddComment = 57958,

	/// <summary>+, add, call, cell, contact, device, hardware, ic, mobile, new, phone, plus, symbol, telephone</summary>
	/// <value>add_ic_call</value>
	AddIcCall = 59772,

	/// <summary>add, attach, clip, link, new, plus, symbol</summary>
	/// <value>add_link</value>
	AddLink = 57720,

	/// <summary>+, add, destination, direction, location, maps, new, pin, place, plus, stop, symbol</summary>
	/// <value>add_location</value>
	AddLocation = 58727,

	/// <summary>+, add, alt, destination, direction, location, maps, new, pin, place, plus, stop, symbol</summary>
	/// <value>add_location_alt</value>
	AddLocationAlt = 61242,

	/// <summary>+, add, certified, moderator, new, plus, privacy, private, protect, protection, security, shield, symbol, verified</summary>
	/// <value>add_moderator</value>
	AddModerator = 59773,

	/// <summary>+, add, alternate, image, landscape, mountain, mountains, new, photo, photography, picture, plus, symbol</summary>
	/// <value>add_photo_alternate</value>
	AddPhotoAlternate = 58430,

	/// <summary></summary>
	/// <value>add_reaction</value>
	AddReaction = 57811,

	/// <summary>+, add, destination, direction, highway, maps, new, plus, road, stop, street, symbol, traffic</summary>
	/// <value>add_road</value>
	AddRoad = 61243,

	/// <summary>add, card, cart, cash, checkout, coin, commerce, credit, currency, dollars, money, online, pay, payment, plus, shopping</summary>
	/// <value>add_shopping_cart</value>
	AddShoppingCart = 59476,

	/// <summary>+, add, approve, check, circle, completed, increase, mark, ok, plus, select, task, tick, yes</summary>
	/// <value>add_task</value>
	AddTask = 62010,

	/// <summary>+, add, app, backup, cloud, drive, files, folders, gdrive, google, plus, storage, to</summary>
	/// <value>add_to_drive</value>
	AddToDrive = 58972,

	/// <summary>Android, OS, add to, arrow, cell, device, hardware, home, iOS, mobile, phone, screen, tablet, up</summary>
	/// <value>add_to_home_screen</value>
	AddToHomeScreen = 57854,

	/// <summary>add, collection, image, landscape, mountain, mountains, photo, photography, photos, picture, plus, to</summary>
	/// <value>add_to_photos</value>
	AddToPhotos = 58269,

	/// <summary>+, Android, OS, add, chrome, desktop, device, display, hardware, iOS, mac, monitor, new, plus, queue, screen, symbol, to, web, window</summary>
	/// <value>add_to_queue</value>
	AddToQueue = 57436,

	/// <summary>add, analytics, bar, bars, chart, data, diagram, graph, infographic, measure, metrics, plus, statistics, tracking</summary>
	/// <value>addchart</value>
	Addchart = 61244,

	/// <summary></summary>
	/// <value>adf_scanner</value>
	AdfScanner = 60122,

	/// <summary>adjust, alter, center, circle, circles, control, dot, edit, filter, fix, image, mix, move, setting, slider, sort, switch, target, tune</summary>
	/// <value>adjust</value>
	Adjust = 58270,

	/// <summary>account, admin, avatar, certified, face, human, panel, people, person, privacy, private, profile, protect, protection, security, settings, shield, user, verified</summary>
	/// <value>admin_panel_settings</value>
	AdminPanelSettings = 61245,

	/// <summary></summary>
	/// <value>ads_click</value>
	AdsClick = 59234,

	/// <summary>agriculture, automobile, car, cars, cultivation, farm, harvest, maps, tractor, transport, travel, truck, vehicle</summary>
	/// <value>agriculture</value>
	Agriculture = 60025,

	/// <summary>air, blowing, breeze, flow, wave, weather, wind</summary>
	/// <value>air</value>
	Air = 61400,

	/// <summary>airline, body, business, class, first, flat, human, people, person, rest, seat, sleep, travel</summary>
	/// <value>airline_seat_flat</value>
	AirlineSeatFlat = 58928,

	/// <summary>airline, angled, body, business, class, first, flat, human, people, person, rest, seat, sleep, travel</summary>
	/// <value>airline_seat_flat_angled</value>
	AirlineSeatFlatAngled = 58929,

	/// <summary>airline, body, business, class, first, human, individual, people, person, rest, seat, sleep, suite, travel</summary>
	/// <value>airline_seat_individual_suite</value>
	AirlineSeatIndividualSuite = 58930,

	/// <summary>airline, body, extra, feet, human, leg, legroom, people, person, seat, sitting, space, travel</summary>
	/// <value>airline_seat_legroom_extra</value>
	AirlineSeatLegroomExtra = 58931,

	/// <summary>airline, body, feet, human, leg, legroom, normal, people, person, seat, sitting, space, travel</summary>
	/// <value>airline_seat_legroom_normal</value>
	AirlineSeatLegroomNormal = 58932,

	/// <summary>airline, body, feet, human, leg, legroom, people, person, reduced, seat, sitting, space, travel</summary>
	/// <value>airline_seat_legroom_reduced</value>
	AirlineSeatLegroomReduced = 58933,

	/// <summary>airline, body, extra, feet, human, leg, legroom, people, person, seat, sitting, space, travel</summary>
	/// <value>airline_seat_recline_extra</value>
	AirlineSeatReclineExtra = 58934,

	/// <summary>airline, body, extra, feet, human, leg, legroom, normal, people, person, recline, seat, sitting, space, travel</summary>
	/// <value>airline_seat_recline_normal</value>
	AirlineSeatReclineNormal = 58935,

	/// <summary></summary>
	/// <value>airline_stops</value>
	AirlineStops = 59344,

	/// <summary></summary>
	/// <value>airlines</value>
	Airlines = 59338,

	/// <summary>airplane, airport, boarding, flight, fly, maps, pass, ticket, transportation, travel</summary>
	/// <value>airplane_ticket</value>
	AirplaneTicket = 61401,

	/// <summary>active, airplane, airplanemode, flight, mode, on, signal</summary>
	/// <value>airplanemode_active</value>
	AirplanemodeActive = 57749,

	/// <summary>airplane, airplanemode, airport, disabled, enabled, flight, fly, inactive, maps, mode, off, offline, on, slash, transportation, travel</summary>
	/// <value>airplanemode_inactive</value>
	AirplanemodeInactive = 57748,

	/// <summary>airplay, apple, arrow, cast, connect, control, desktop, device, display, monitor, screen, signal, tv</summary>
	/// <value>airplay</value>
	Airplay = 57429,

	/// <summary>airport, automobile, car, cars, commercial, delivery, direction, maps, mini, public, shuttle, transport, transportation, travel, truck, van, vehicle</summary>
	/// <value>airport_shuttle</value>
	AirportShuttle = 60220,

	/// <summary>alarm, alart, bell, clock, countdown, date, notification, schedule, time</summary>
	/// <value>alarm</value>
	Alarm = 59477,

	/// <summary>+, add, alarm, alart, bell, clock, countdown, date, new, notification, plus, schedule, symbol, time</summary>
	/// <value>alarm_add</value>
	AlarmAdd = 59478,

	/// <summary>alarm, alart, bell, clock, disabled, duration, enabled, notification, off, on, slash, time, timer, watch</summary>
	/// <value>alarm_off</value>
	AlarmOff = 59479,

	/// <summary>alarm, alart, bell, clock, disabled, duration, enabled, notification, off, on, slash, time, timer, watch</summary>
	/// <value>alarm_on</value>
	AlarmOn = 59480,

	/// <summary>album, artist, audio, bvb, cd, computer, data, disk, file, music, record, sound, storage, track, vinyl</summary>
	/// <value>album</value>
	Album = 57369,

	/// <summary>align, alignment, center, format, horizontal, layout, lines, paragraph, rule, rules, style, text</summary>
	/// <value>align_horizontal_center</value>
	AlignHorizontalCenter = 57359,

	/// <summary>align, alignment, format, horizontal, layout, left, lines, paragraph, rule, rules, style, text</summary>
	/// <value>align_horizontal_left</value>
	AlignHorizontalLeft = 57357,

	/// <summary>align, alignment, format, horizontal, layout, lines, paragraph, right, rule, rules, style, text</summary>
	/// <value>align_horizontal_right</value>
	AlignHorizontalRight = 57360,

	/// <summary>align, alignment, bottom, format, layout, lines, paragraph, rule, rules, style, text, vertical</summary>
	/// <value>align_vertical_bottom</value>
	AlignVerticalBottom = 57365,

	/// <summary>align, alignment, center, format, layout, lines, paragraph, rule, rules, style, text, vertical</summary>
	/// <value>align_vertical_center</value>
	AlignVerticalCenter = 57361,

	/// <summary>align, alignment, format, layout, lines, paragraph, rule, rules, style, text, top, vertical</summary>
	/// <value>align_vertical_top</value>
	AlignVerticalTop = 57356,

	/// <summary>Inbox, all, delivered, delivery, email, mail, message, send</summary>
	/// <value>all_inbox</value>
	AllInbox = 59775,

	/// <summary>all, endless, forever, inclusive, infinity, loop, mobius, neverending, strip, sustainability, sustainable</summary>
	/// <value>all_inclusive</value>
	AllInclusive = 60221,

	/// <summary>all, circle, out, shape</summary>
	/// <value>all_out</value>
	AllOut = 59659,

	/// <summary>alt, alternate, alternative, arrows, direction, maps, navigation, options, other, route, routes, split, symbol</summary>
	/// <value>alt_route</value>
	AltRoute = 61828,

	/// <summary>@, address, alternate, contact, email, tag</summary>
	/// <value>alternate_email</value>
	AlternateEmail = 57574,

	/// <summary>analytics, assessment, bar, chart, data, diagram, graph, infographic, measure, metrics, statistics, tracking</summary>
	/// <value>analytics</value>
	Analytics = 61246,

	/// <summary>anchor, google, logo</summary>
	/// <value>anchor</value>
	Anchor = 61901,

	/// <summary>android, character, logo, mascot, toy</summary>
	/// <value>android</value>
	Android = 59481,

	/// <summary>animation, circles, motion, movie, moving, video</summary>
	/// <value>animation</value>
	Animation = 59164,

	/// <summary>!, alert, announcement, attention, bubble, caution, chat, comment, communicate, danger, error, exclamation, feedback, important, mark, message, notification, speech, symbol, warning</summary>
	/// <value>announcement</value>
	Announcement = 59482,

	/// <summary>Android, OS, always, aod, device, display, hardware, homescreen, iOS, mobile, on, phone, tablet</summary>
	/// <value>aod</value>
	Aod = 61402,

	/// <summary>accommodation, apartment, architecture, building, city, company, estate, flat, home, house, office, places, real, residence, residential, shelter, units, workplace</summary>
	/// <value>apartment</value>
	Apartment = 59968,

	/// <summary>api, developer, development, enterprise, software</summary>
	/// <value>api</value>
	Api = 61879,

	/// <summary>Android, OS, app, applications, cancel, cell, device, hardware, iOS, mobile, phone, stop, tablet</summary>
	/// <value>app_blocking</value>
	AppBlocking = 61247,

	/// <summary>app, apps, edit, pencil, register, registration</summary>
	/// <value>app_registration</value>
	AppRegistration = 61248,

	/// <summary>Android, OS, app, applications, cell, device, gear, hardware, iOS, mobile, phone, setting, settings, tablet</summary>
	/// <value>app_settings_alt</value>
	AppSettingsAlt = 61249,

	/// <summary></summary>
	/// <value>app_shortcut</value>
	AppShortcut = 60132,

	/// <summary>apply, approval, approvals, approve, certificate, certification, disapproval, drive, file, impression, ink, mark, postage, stamp</summary>
	/// <value>approval</value>
	Approval = 59778,

	/// <summary>all, applications, apps, circles, collection, dots, grid, squares</summary>
	/// <value>apps</value>
	Apps = 58819,

	/// <summary></summary>
	/// <value>apps_outage</value>
	AppsOutage = 59340,

	/// <summary>architecture, art, compass, design, draw, drawing, engineering, geometric, tool</summary>
	/// <value>architecture</value>
	Architecture = 59963,

	/// <summary>archive, inbox, mail, store</summary>
	/// <value>archive</value>
	Archive = 57673,

	/// <summary></summary>
	/// <value>area_chart</value>
	AreaChart = 59248,

	/// <summary>app, application, arrow, back, components, direction, interface, left, navigation, previous, screen, site, ui, ux, web, website</summary>
	/// <value>arrow_back</value>
	ArrowBack = 58820,

	/// <summary>app, application, arrow, back, chevron, components, direction, interface, ios, left, navigation, previous, screen, site, ui, ux, web, website</summary>
	/// <value>arrow_back_ios</value>
	ArrowBackIos = 58848,

	/// <summary>app, application, arrow, back, chevron, components, direction, interface, ios, left, navigation, new, previous, screen, site, ui, ux, web, website</summary>
	/// <value>arrow_back_ios_new</value>
	ArrowBackIosNew = 58090,

	/// <summary>arrow, circle, direction, down, navigation</summary>
	/// <value>arrow_circle_down</value>
	ArrowCircleDown = 61825,

	/// <summary></summary>
	/// <value>arrow_circle_left</value>
	ArrowCircleLeft = 60071,

	/// <summary></summary>
	/// <value>arrow_circle_right</value>
	ArrowCircleRight = 60074,

	/// <summary>arrow, circle, direction, navigation, up</summary>
	/// <value>arrow_circle_up</value>
	ArrowCircleUp = 61826,

	/// <summary>app, application, arrow, components, direction, down, downward, interface, navigation, screen, site, ui, ux, web, website</summary>
	/// <value>arrow_downward</value>
	ArrowDownward = 58843,

	/// <summary>app, application, arrow, components, direction, down, drop, interface, navigation, screen, site, ui, ux, web, website</summary>
	/// <value>arrow_drop_down</value>
	ArrowDropDown = 58821,

	/// <summary>app, application, arrow, circle, components, direction, down, drop, interface, navigation, screen, site, ui, ux, web, website</summary>
	/// <value>arrow_drop_down_circle</value>
	ArrowDropDownCircle = 58822,

	/// <summary>app, application, arrow, components, direction, drop, interface, navigation, screen, site, ui, up, ux, web, website</summary>
	/// <value>arrow_drop_up</value>
	ArrowDropUp = 58823,

	/// <summary>app, application, arrow, arrows, components, direction, forward, interface, navigation, right, screen, site, ui, ux, web, website</summary>
	/// <value>arrow_forward</value>
	ArrowForward = 58824,

	/// <summary>app, application, arrow, chevron, components, direction, forward, interface, ios, navigation, next, right, screen, site, ui, ux, web, website</summary>
	/// <value>arrow_forward_ios</value>
	ArrowForwardIos = 58849,

	/// <summary>app, application, arrow, back, backstack, backward, components, direction, interface, left, navigation, previous, screen, site, ui, ux, web, website</summary>
	/// <value>arrow_left</value>
	ArrowLeft = 58846,

	/// <summary>app, application, arrow, components, continue, direction, forward, interface, navigation, right, screen, site, ui, ux, web, website</summary>
	/// <value>arrow_right</value>
	ArrowRight = 58847,

	/// <summary>alt, arrow, arrows, direction, east, navigation, pointing, right</summary>
	/// <value>arrow_right_alt</value>
	ArrowRightAlt = 59713,

	/// <summary>app, application, arrow, components, direction, interface, navigation, screen, site, ui, up, upward, ux, web, website</summary>
	/// <value>arrow_upward</value>
	ArrowUpward = 58840,

	/// <summary>album, art, artist, audio, image, music, photo, photography, picture, sound, track, tracks</summary>
	/// <value>art_track</value>
	ArtTrack = 57440,

	/// <summary>article, clarify, doc, document, file, news, page, paper, text, writing</summary>
	/// <value>article</value>
	Article = 61250,

	/// <summary>aspect, expand, image, ratio, resize, scale, size, square</summary>
	/// <value>aspect_ratio</value>
	AspectRatio = 59483,

	/// <summary>analytics, assessment, bar, chart, data, diagram, graph, infographic, measure, metrics, statistics, tracking</summary>
	/// <value>assessment</value>
	Assessment = 59484,

	/// <summary>assignment, clipboard, doc, document, text, writing</summary>
	/// <value>assignment</value>
	Assignment = 59485,

	/// <summary>account, assignment, clipboard, doc, document, face, ind, people, person, profile, user</summary>
	/// <value>assignment_ind</value>
	AssignmentInd = 59486,

	/// <summary>!, alert, assignment, attention, caution, clipboard, danger, doc, document, error, exclamation, important, late, mark, notification, symbol, warning</summary>
	/// <value>assignment_late</value>
	AssignmentLate = 59487,

	/// <summary>arrow, assignment, back, clipboard, doc, document, left, retun</summary>
	/// <value>assignment_return</value>
	AssignmentReturn = 59488,

	/// <summary>arrow, assignment, clipboard, doc, document, down, returned</summary>
	/// <value>assignment_returned</value>
	AssignmentReturned = 59489,

	/// <summary>approve, assignment, check, clipboard, complete, doc, document, done, in, mark, ok, select, tick, turn, validate, verified, yes</summary>
	/// <value>assignment_turned_in</value>
	AssignmentTurnedIn = 59490,

	/// <summary>assistant, bubble, chat, comment, communicate, feedback, message, recommendation, speech, star, suggestion, twinkle</summary>
	/// <value>assistant</value>
	Assistant = 58271,

	/// <summary>assistant, destination, direction, location, maps, navigate, navigation, pin, place, right, stop</summary>
	/// <value>assistant_direction</value>
	AssistantDirection = 59784,

	/// <summary>assistant, flag, photo, recommendation, smart, star, suggestion</summary>
	/// <value>assistant_photo</value>
	AssistantPhoto = 58272,

	/// <summary></summary>
	/// <value>assured_workload</value>
	AssuredWorkload = 60271,

	/// <summary>alphabet, atm, automated, bill, card, cart, cash, character, coin, commerce, credit, currency, dollars, font, letter, machine, money, online, pay, payment, shopping, symbol, teller, text, type</summary>
	/// <value>atm</value>
	Atm = 58739,

	/// <summary>attach, attachment, clip, compose, email, envelop, letter, link, mail, message, send</summary>
	/// <value>attach_email</value>
	AttachEmail = 59998,

	/// <summary>add, attach, clip, file, link, mail, media</summary>
	/// <value>attach_file</value>
	AttachFile = 57894,

	/// <summary>attach, bill, card, cash, coin, commerce, cost, credit, currency, dollars, finance, money, online, pay, payment, symbol</summary>
	/// <value>attach_money</value>
	AttachMoney = 57895,

	/// <summary>attach, attachment, clip, compose, file, image, link</summary>
	/// <value>attachment</value>
	Attachment = 58044,

	/// <summary>amusement, attractions, entertainment, ferris, fun, maps, park, places, wheel</summary>
	/// <value>attractions</value>
	Attractions = 59986,

	/// <summary>attribute, attribution, body, copyright, copywriter, human, people, person</summary>
	/// <value>attribution</value>
	Attribution = 61403,

	/// <summary></summary>
	/// <value>audio_file</value>
	AudioFile = 60290,

	/// <summary>audio, audiotrack, key, music, note, sound, track</summary>
	/// <value>audiotrack</value>
	Audiotrack = 58273,

	/// <summary>auto, awesome, edit, editing, enhance, filter, image, photography, photos, setting, stars</summary>
	/// <value>auto_awesome</value>
	AutoAwesome = 58975,

	/// <summary>auto, awesome, edit, editing, filter, grid, image, layout, mosaic, photographs, photography, photos, pictures, setting</summary>
	/// <value>auto_awesome_mosaic</value>
	AutoAwesomeMosaic = 58976,

	/// <summary>animation, auto, awesome, edit, editing, filter, image, live, motion, photographs, photography, photos, pictures, setting, video</summary>
	/// <value>auto_awesome_motion</value>
	AutoAwesomeMotion = 58977,

	/// <summary>auto, bin, can, clock, date, delete, garbage, remove, schedule, time, trash</summary>
	/// <value>auto_delete</value>
	AutoDelete = 59980,

	/// <summary>auto, edit, erase, fix, high, magic, modify, star, stars, wand</summary>
	/// <value>auto_fix_high</value>
	AutoFixHigh = 58979,

	/// <summary>auto, edit, erase, fix, magic, modify, normal, star, stars, wand</summary>
	/// <value>auto_fix_normal</value>
	AutoFixNormal = 58980,

	/// <summary>auto, disabled, edit, enabled, erase, fix, magic, modify, off, on, slash, star, stars, wand</summary>
	/// <value>auto_fix_off</value>
	AutoFixOff = 58981,

	/// <summary>analytics, auto, chart, data, diagram, graph, infographic, line, measure, metrics, stars, statistics, tracking</summary>
	/// <value>auto_graph</value>
	AutoGraph = 58619,

	/// <summary>audiobook, auto, book, page, reading, stories, story</summary>
	/// <value>auto_stories</value>
	AutoStories = 58982,

	/// <summary>A, alphabet, auto, character, font, fps, frame, frequency, letter, per, rate, second, seconds, select, symbol, text, type</summary>
	/// <value>autofps_select</value>
	AutofpsSelect = 61404,

	/// <summary>around, arrow, arrows, autorenew, cache, cached, direction, inprogress, load, loading refresh, navigation, renew, rotate, turn</summary>
	/// <value>autorenew</value>
	Autorenew = 59491,

	/// <summary>av, clock, countdown, duration, minutes, seconds, time, timer, watch</summary>
	/// <value>av_timer</value>
	AvTimer = 57371,

	/// <summary>babies, baby, bathroom, body, changing, child, children, father, human, infant, kids, mother, newborn, people, person, station, toddler, wc, young</summary>
	/// <value>baby_changing_station</value>
	BabyChangingStation = 61851,

	/// <summary></summary>
	/// <value>back_hand</value>
	BackHand = 59236,

	/// <summary>back, backpack, bag, book, bookbag, knapsack, pack, storage, travel</summary>
	/// <value>backpack</value>
	Backpack = 61852,

	/// <summary>arrow, back, backspace, cancel, clear, correct, delete, erase, remove</summary>
	/// <value>backspace</value>
	Backspace = 57674,

	/// <summary>arrow, backup, cloud, data, drive, files folders, storage, up, upload</summary>
	/// <value>backup</value>
	Backup = 59492,

	/// <summary>backup, drive, files folders, format, layout, stack, storage, table</summary>
	/// <value>backup_table</value>
	BackupTable = 61251,

	/// <summary>account, avatar, badge, card, certified, employee, face, human, identification, name, people, person, profile, security, user, work</summary>
	/// <value>badge</value>
	Badge = 60007,

	/// <summary>bakery, bread, breakfast, brunch, croissant, dining, food</summary>
	/// <value>bakery_dining</value>
	BakeryDining = 59987,

	/// <summary></summary>
	/// <value>balance</value>
	Balance = 60150,

	/// <summary>architecture, balcony, doors, estate, home, house, maps, out, outside, place, real, residence, residential, stay, terrace, window</summary>
	/// <value>balcony</value>
	Balcony = 58767,

	/// <summary>ballot, bulllet, election, list, point, poll, vote</summary>
	/// <value>ballot</value>
	Ballot = 57714,

	/// <summary>analytics, bar, chart, data, diagram, graph, infographic, measure, metrics, statistics, tracking</summary>
	/// <value>bar_chart</value>
	BarChart = 57963,

	/// <summary>batch, bulb, idea, light, prediction</summary>
	/// <value>batch_prediction</value>
	BatchPrediction = 61685,

	/// <summary>bath, bathroom, closet, home, house, place, plumbing, room, shower, sprinkler, wash, water, wc</summary>
	/// <value>bathroom</value>
	Bathroom = 61405,

	/// <summary>bath, bathing, bathroom, bathtub, home, hotel, human, person, shower, travel, tub</summary>
	/// <value>bathtub</value>
	Bathtub = 59969,

	/// <summary>!, alert, attention, battery, caution, cell, charge, danger, error, exclamation, important, mark, mobile, notification, power, symbol, warning</summary>
	/// <value>battery_alert</value>
	BatteryAlert = 57756,

	/// <summary>battery, bolt, cell, charge, charging, full, lightening, mobile, power, thunderbolt</summary>
	/// <value>battery_charging_full</value>
	BatteryChargingFull = 57763,

	/// <summary>battery, cell, charge, full, mobile, power</summary>
	/// <value>battery_full</value>
	BatteryFull = 57764,

	/// <summary>+, add, battery, charge, charging, new, plus, power, saver, symbol</summary>
	/// <value>battery_saver</value>
	BatterySaver = 61406,

	/// <summary>battery, cell, charge, mobile, plus, power, standard, std</summary>
	/// <value>battery_std</value>
	BatteryStd = 57765,

	/// <summary>?, assistance, battery, cell, charge, help, info, information, mobile, power, punctuation, question mark, support, symbol, unknown</summary>
	/// <value>battery_unknown</value>
	BatteryUnknown = 57766,

	/// <summary>access, beach, places, summer, sunny, umbrella</summary>
	/// <value>beach_access</value>
	BeachAccess = 60222,

	/// <summary>bed, bedroom, double, full, furniture, home, hotel, house, king, night, pillows, queen, rest, room, size, sleep</summary>
	/// <value>bed</value>
	Bed = 61407,

	/// <summary>babies, baby, bedroom, child, children, home, horse, house, infant, kid, newborn, rocking, room, toddler, young</summary>
	/// <value>bedroom_baby</value>
	BedroomBaby = 61408,

	/// <summary>bed, bedroom, child, children, furniture, home, hotel, house, kid, night, pillows, rest, room, size, sleep, twin, young</summary>
	/// <value>bedroom_child</value>
	BedroomChild = 61409,

	/// <summary>bed, bedroom, double, full, furniture, home, hotel, house, king, night, parent, pillows, queen, rest, room, sizem master, sleep</summary>
	/// <value>bedroom_parent</value>
	BedroomParent = 61410,

	/// <summary></summary>
	/// <value>bedtime</value>
	Bedtime = 61252,

	/// <summary></summary>
	/// <value>bedtime_off</value>
	BedtimeOff = 60278,

	/// <summary>approve, archive, beenhere, bookmark, check, complete, done, favorite, label, library, mark, ok, read, reading, remember, ribbon, save, select, tag, tick, validate, verified, yes</summary>
	/// <value>beenhere</value>
	Beenhere = 58669,

	/// <summary>bento, box, dinner, food, lunch, meal, restaurant, takeout</summary>
	/// <value>bento</value>
	Bento = 61940,

	/// <summary>automobile, bike, car, cars, maps, scooter, transportation, vehicle, vespa</summary>
	/// <value>bike_scooter</value>
	BikeScooter = 61253,

	/// <summary>biotech, chemistry, laboratory, microscope, research, science, technology</summary>
	/// <value>biotech</value>
	Biotech = 59962,

	/// <summary>appliance, blender, cooking, electric, juicer, kitchen, machine, vitamix</summary>
	/// <value>blender</value>
	Blender = 61411,

	/// <summary>avoid, block, cancel, close, entry, exit, no, prohibited, quit, remove, stop</summary>
	/// <value>block</value>
	Block = 57675,

	/// <summary>blood, bloodtype, donate, droplet, emergency, hospital, medicine, negative, positive, type, water</summary>
	/// <value>bloodtype</value>
	Bloodtype = 61412,

	/// <summary>bluetooth, cast, connect, connection, device, paring, streaming, symbol, wireless</summary>
	/// <value>bluetooth</value>
	Bluetooth = 57767,

	/// <summary>audio, bluetooth, connect, connection, device, music, signal, sound, symbol</summary>
	/// <value>bluetooth_audio</value>
	BluetoothAudio = 58895,

	/// <summary>bluetooth, cast, connect, connection, device, paring, streaming, symbol, wireless</summary>
	/// <value>bluetooth_connected</value>
	BluetoothConnected = 57768,

	/// <summary>bluetooth, cast, connect, connection, device, disabled, enabled, off, offline, on, paring, slash, streaming, symbol, wireless</summary>
	/// <value>bluetooth_disabled</value>
	BluetoothDisabled = 57769,

	/// <summary>automobile, bluetooth, car, cars, cast, connect, connection, device, drive, maps, paring, streaming, symbol, transportation, travel, vehicle, wireless</summary>
	/// <value>bluetooth_drive</value>
	BluetoothDrive = 61413,

	/// <summary>bluetooth, connection, device, paring, search, searching, symbol</summary>
	/// <value>bluetooth_searching</value>
	BluetoothSearching = 57770,

	/// <summary>blur, circle, circular, dots, edit, editing, effect, enhance, filter</summary>
	/// <value>blur_circular</value>
	BlurCircular = 58274,

	/// <summary>blur, dots, edit, editing, effect, enhance, filter, linear</summary>
	/// <value>blur_linear</value>
	BlurLinear = 58275,

	/// <summary>blur, disabled, dots, edit, editing, effect, enabled, enhance, off, on, slash</summary>
	/// <value>blur_off</value>
	BlurOff = 58276,

	/// <summary>blur, disabled, dots, edit, editing, effect, enabled, enhance, filter, off, on, slash</summary>
	/// <value>blur_on</value>
	BlurOn = 58277,

	/// <summary>bolt, electric, energy, fast, flash, lightning, power, thunderbolt</summary>
	/// <value>bolt</value>
	Bolt = 59915,

	/// <summary>book, bookmark, favorite, label, library, read, reading, remember, ribbon, save, tag</summary>
	/// <value>book</value>
	Book = 59493,

	/// <summary>Android, OS, admission, appointment, book, cell, device, event, hardware, iOS, mobile, online, pass, phone, reservation, tablet, ticket</summary>
	/// <value>book_online</value>
	BookOnline = 61975,

	/// <summary>archive, bookmark, favorite, follow, label, library, read, reading, remember, ribbon, save, tag</summary>
	/// <value>bookmark</value>
	Bookmark = 59494,

	/// <summary>+, add, bookmark, favorite, plus, remember, ribbon, save, symbol</summary>
	/// <value>bookmark_add</value>
	BookmarkAdd = 58776,

	/// <summary>added, approve, bookmark, check, complete, done, favorite, mark, ok, remember, save, select, tick, validate, verified, yes</summary>
	/// <value>bookmark_added</value>
	BookmarkAdded = 58777,

	/// <summary>archive, bookmark, border, favorite, label, library, read, reading, remember, ribbon, save, tag</summary>
	/// <value>bookmark_border</value>
	BookmarkBorder = 59495,

	/// <summary>bookmark, delete, favorite, minus, remember, remove, ribbon, save, subtract</summary>
	/// <value>bookmark_remove</value>
	BookmarkRemove = 58778,

	/// <summary>bookmark, bookmarks, favorite, label, layers, library, multiple, read, reading, remember, ribbon, save, stack, tag</summary>
	/// <value>bookmarks</value>
	Bookmarks = 59787,

	/// <summary>all, border, doc, edit, editing, editor, sheet, spreadsheet, stroke, text, type, writing</summary>
	/// <value>border_all</value>
	BorderAll = 57896,

	/// <summary>border, bottom, doc, edit, editing, editor, sheet, spreadsheet, stroke, text, type, writing</summary>
	/// <value>border_bottom</value>
	BorderBottom = 57897,

	/// <summary>border, clear, doc, edit, editing, editor, sheet, spreadsheet, stroke, text, type, writing</summary>
	/// <value>border_clear</value>
	BorderClear = 57898,

	/// <summary>all, border, doc, edit, editing, editor, pen, pencil, sheet, spreadsheet, stroke, text, type, writing</summary>
	/// <value>border_color</value>
	BorderColor = 57899,

	/// <summary>border, doc, edit, editing, editor, horizontal, sheet, spreadsheet, stroke, text, type, writing</summary>
	/// <value>border_horizontal</value>
	BorderHorizontal = 57900,

	/// <summary>border, doc, edit, editing, editor, inner, sheet, spreadsheet, stroke, text, type, writing</summary>
	/// <value>border_inner</value>
	BorderInner = 57901,

	/// <summary>border, doc, edit, editing, editor, left, sheet, spreadsheet, stroke, text, type, writing</summary>
	/// <value>border_left</value>
	BorderLeft = 57902,

	/// <summary>border, doc, edit, editing, editor, outer, sheet, spreadsheet, stroke, text, type, writing</summary>
	/// <value>border_outer</value>
	BorderOuter = 57903,

	/// <summary>border, doc, edit, editing, editor, right, sheet, spreadsheet, stroke, text, type, writing</summary>
	/// <value>border_right</value>
	BorderRight = 57904,

	/// <summary>border, color, doc, edit, editing, editor, sheet, spreadsheet, stroke, style, text, type, writing</summary>
	/// <value>border_style</value>
	BorderStyle = 57905,

	/// <summary>border, doc, edit, editing, editor, sheet, spreadsheet, stroke, text, top, type, writing</summary>
	/// <value>border_top</value>
	BorderTop = 57906,

	/// <summary>border, doc, edit, editing, editor, sheet, spreadsheet, stroke, text, type, vertical, writing</summary>
	/// <value>border_vertical</value>
	BorderVertical = 57907,

	/// <summary></summary>
	/// <value>boy</value>
	Boy = 60263,

	/// <summary>branding, components, copyright, design, emblem, format, identity, interface, layout, logo, screen, site, stamp, ui, ux, watermark, web, website, window</summary>
	/// <value>branding_watermark</value>
	BrandingWatermark = 57451,

	/// <summary>bakery, bread, breakfast, butter, dining, food, toast</summary>
	/// <value>breakfast_dining</value>
	BreakfastDining = 59988,

	/// <summary>1, brightness, circle, control, cresent, level, moon, screen</summary>
	/// <value>brightness_1</value>
	Brightness1 = 58278,

	/// <summary>2, brightness, circle, control, cresent, level, moon, screen</summary>
	/// <value>brightness_2</value>
	Brightness2 = 58279,

	/// <summary>3, brightness, circle, control, cresent, level, moon, screen</summary>
	/// <value>brightness_3</value>
	Brightness3 = 58280,

	/// <summary>4, brightness, circle, control, cresent, level, moon, screen, sun</summary>
	/// <value>brightness_4</value>
	Brightness4 = 58281,

	/// <summary>5, brightness, circle, control, cresent, level, moon, screen, sun</summary>
	/// <value>brightness_5</value>
	Brightness5 = 58282,

	/// <summary>6, brightness, circle, control, cresent, level, moon, screen, sun</summary>
	/// <value>brightness_6</value>
	Brightness6 = 58283,

	/// <summary>7, brightness, circle, control, cresent, level, moon, screen, sun</summary>
	/// <value>brightness_7</value>
	Brightness7 = 58284,

	/// <summary>A, auto, brightness, control, display, level, mobile, monitor, phone, screen, sun</summary>
	/// <value>brightness_auto</value>
	BrightnessAuto = 57771,

	/// <summary>auto, brightness, control, high, mobile, monitor, phone, sun</summary>
	/// <value>brightness_high</value>
	BrightnessHigh = 57772,

	/// <summary>auto, brightness, control, low, mobile, monitor, phone, sun</summary>
	/// <value>brightness_low</value>
	BrightnessLow = 57773,

	/// <summary>auto, brightness, control, medium, mobile, monitor, phone, sun</summary>
	/// <value>brightness_medium</value>
	BrightnessMedium = 57774,

	/// <summary>broken, corrupt, error, image, landscape, mountain, mountains, photo, photography, picture, torn</summary>
	/// <value>broken_image</value>
	BrokenImage = 58285,

	/// <summary></summary>
	/// <value>browse_gallery</value>
	BrowseGallery = 60369,

	/// <summary>browser, disabled, enabled, internet, not, off, on, page, screen, site, slash, supported, web, website, www</summary>
	/// <value>browser_not_supported</value>
	BrowserNotSupported = 61255,

	/// <summary></summary>
	/// <value>browser_updated</value>
	BrowserUpdated = 59343,

	/// <summary>breakfast, brunch, champaign, dining, drink, food, lunch, meal</summary>
	/// <value>brunch_dining</value>
	BrunchDining = 60019,

	/// <summary>art, brush, design, draw, edit, editing, paint, painting, tool</summary>
	/// <value>brush</value>
	Brush = 58286,

	/// <summary>analytics, bar, bars, bubble, chart, data, diagram, graph, infographic, measure, metrics, statistics, tracking</summary>
	/// <value>bubble_chart</value>
	BubbleChart = 59101,

	/// <summary>animal, bug, fix, insect, issue, problem, report, testing, virus, warning</summary>
	/// <value>bug_report</value>
	BugReport = 59496,

	/// <summary>adjust, build, fix, repair, tool, wrench</summary>
	/// <value>build</value>
	Build = 59497,

	/// <summary>adjust, build, circle, fix, repair, tool, wrench</summary>
	/// <value>build_circle</value>
	BuildCircle = 61256,

	/// <summary>architecture, bungalow, cottage, estate, home, house, maps, place, real, residence, residential, stay, traveling</summary>
	/// <value>bungalow</value>
	Bungalow = 58769,

	/// <summary>burst, image, landscape, mode, mountain, mountains, multiple, photo, photography, picture</summary>
	/// <value>burst_mode</value>
	BurstMode = 58428,

	/// <summary>!, alert, attention, automobile, bus, car, cars, caution, danger, error, exclamation, important, maps, mark, notification, symbol, transportation, vehicle, warning</summary>
	/// <value>bus_alert</value>
	BusAlert = 59791,

	/// <summary>apartment, architecture, building, business, company, estate, home, place, real, residence, residential, shelter</summary>
	/// <value>business</value>
	Business = 57519,

	/// <summary>bag, baggage, briefcase, business, case, center, places, purse, suitcase, work</summary>
	/// <value>business_center</value>
	BusinessCenter = 60223,

	/// <summary>architecture, cabin, camping, cottage, estate, home, house, log, maps, place, real, residence, residential, stay, traveling, wood</summary>
	/// <value>cabin</value>
	Cabin = 58761,

	/// <summary>cable, connect, connection, device, electronics, usb, wire</summary>
	/// <value>cable</value>
	Cable = 61414,

	/// <summary>around, arrows, cache, cached, inprogress, load, loading refresh, renew, rotate</summary>
	/// <value>cached</value>
	Cached = 59498,

	/// <summary>baked, birthday, cake, candles, celebration, dessert, food, frosting, party, pastries, pastry, social, sweet</summary>
	/// <value>cake</value>
	Cake = 59369,

	/// <summary>+, -, =, calculate, count, finance calculator, math</summary>
	/// <value>calculate</value>
	Calculate = 59999,

	/// <summary></summary>
	/// <value>calendar_month</value>
	CalendarMonth = 60364,

	/// <summary>calendar, date, day, event, month, schedule, today</summary>
	/// <value>calendar_today</value>
	CalendarToday = 59701,

	/// <summary>calendar, date, day, event, format, grid, layout, month, schedule, today, view, week</summary>
	/// <value>calendar_view_day</value>
	CalendarViewDay = 59702,

	/// <summary>calendar, date, day, event, format, grid, layout, month, schedule, today, view</summary>
	/// <value>calendar_view_month</value>
	CalendarViewMonth = 61415,

	/// <summary>calendar, date, day, event, format, grid, layout, month, schedule, today, view, week</summary>
	/// <value>calendar_view_week</value>
	CalendarViewWeek = 61416,

	/// <summary>call, cell, contact, device, hardware, mobile, phone, telephone</summary>
	/// <value>call</value>
	Call = 57520,

	/// <summary>call, cell, contact, device, end, hardware, mobile, phone, telephone</summary>
	/// <value>call_end</value>
	CallEnd = 57521,

	/// <summary>arrow, call, device, made, mobile</summary>
	/// <value>call_made</value>
	CallMade = 57522,

	/// <summary>arrow, call, device, merge, mobile</summary>
	/// <value>call_merge</value>
	CallMerge = 57523,

	/// <summary>arrow, call, device, missed, mobile</summary>
	/// <value>call_missed</value>
	CallMissed = 57524,

	/// <summary>arrow, call, device, missed, mobile, outgoing</summary>
	/// <value>call_missed_outgoing</value>
	CallMissedOutgoing = 57572,

	/// <summary>arrow, call, device, mobile, received</summary>
	/// <value>call_received</value>
	CallReceived = 57525,

	/// <summary>arrow, call, device, mobile, split</summary>
	/// <value>call_split</value>
	CallSplit = 57526,

	/// <summary>action, alert, bar, call, components, cta, design, info, information, interface, layout, message, notification, screen, site, to, ui, ux, web, website, window</summary>
	/// <value>call_to_action</value>
	CallToAction = 57452,

	/// <summary>album, aperture, camera, lens, photo, photography, picture, record, screenshot, shutter</summary>
	/// <value>camera</value>
	Camera = 58287,

	/// <summary>alt, camera, image, photo, photography, picture</summary>
	/// <value>camera_alt</value>
	CameraAlt = 58288,

	/// <summary>camera, enhance, important, lens, photo, photography, picture, quality, special, star</summary>
	/// <value>camera_enhance</value>
	CameraEnhance = 59644,

	/// <summary>body, camera, front, human, lens, mobile, person, phone, photography, portrait, selfie</summary>
	/// <value>camera_front</value>
	CameraFront = 58289,

	/// <summary>architecture, building, camera, estate, film, filming, home, house, image, indoor, inside, motion, nest, picture, place, real, residence, residential, shelter, video, videography</summary>
	/// <value>camera_indoor</value>
	CameraIndoor = 61417,

	/// <summary>architecture, building, camera, estate, film, filming, home, house, image, motion, nest, outdoor, outside, picture, place, real, residence, residential, shelter, video, videography</summary>
	/// <value>camera_outdoor</value>
	CameraOutdoor = 61418,

	/// <summary>camera, front, lens, mobile, phone, photo, photography, picture, portrait, rear, selfie</summary>
	/// <value>camera_rear</value>
	CameraRear = 58290,

	/// <summary>camera, film, image, library, photo, photography, roll</summary>
	/// <value>camera_roll</value>
	CameraRoll = 58291,

	/// <summary>arrows, camera, cameraswitch, flip, rotate, swap, switch, view</summary>
	/// <value>cameraswitch</value>
	Cameraswitch = 61419,

	/// <summary>alert, announcement, campaign, loud, megaphone, microphone, notification, speaker</summary>
	/// <value>campaign</value>
	Campaign = 61257,

	/// <summary>cancel, circle, close, exit, stop, x</summary>
	/// <value>cancel</value>
	Cancel = 58825,

	/// <summary>cancel, close, device, exit, no, present, presentation, quit, remove, screen, slide, stop, website, window, x</summary>
	/// <value>cancel_presentation</value>
	CancelPresentation = 57577,

	/// <summary>cancel, email, mail, no, quit, remove, schedule, send, share, stop, x</summary>
	/// <value>cancel_schedule_send</value>
	CancelScheduleSend = 59961,

	/// <summary></summary>
	/// <value>candlestick_chart</value>
	CandlestickChart = 60116,

	/// <summary>automobile, car, cars, key, maps, rental, transportation, vehicle</summary>
	/// <value>car_rental</value>
	CarRental = 59989,

	/// <summary>automobile, car, cars, maps, repair, transportation, vehicle</summary>
	/// <value>car_repair</value>
	CarRepair = 59990,

	/// <summary>account, balance, bill, card, cart, cash, certificate, coin, commerce, credit, currency, dollars, gift, giftcard, money, online, pay, payment, present, shopping</summary>
	/// <value>card_giftcard</value>
	CardGiftcard = 59638,

	/// <summary>bill, bookmark, card, cash, certificate, coin, commerce, cost, credit, currency, dollars, inance, loyalty, membership, money, online, pay, payment, shopping, subscription</summary>
	/// <value>card_membership</value>
	CardMembership = 59639,

	/// <summary>bill, card, cash, coin, commerce, cost, credit, currency, dollars, inance, membership, miles, money, online, pay, payment, travel, trip</summary>
	/// <value>card_travel</value>
	CardTravel = 59640,

	/// <summary>building, carpenter, construction, cutting, handyman, repair, saw, tool</summary>
	/// <value>carpenter</value>
	Carpenter = 61944,

	/// <summary>bag, baggage, briefcase, business, case, cases, purse, suitcase</summary>
	/// <value>cases</value>
	Cases = 59794,

	/// <summary>casino, dice, dots, entertainment, gamble, gambling, game, games, luck, places</summary>
	/// <value>casino</value>
	Casino = 60224,

	/// <summary>Android, OS, airplay, cast, chrome, connect, desktop, device, display, hardware, iOS, mac, monitor, screen, screencast, streaming, television, tv, web, window, wireless</summary>
	/// <value>cast</value>
	Cast = 58119,

	/// <summary>Android, OS, airplay, cast, chrome, connect, desktop, device, display, hardware, iOS, mac, monitor, screen, screencast, streaming, television, tv, web, window, wireless</summary>
	/// <value>cast_connected</value>
	CastConnected = 58120,

	/// <summary>Android, OS, airplay, cast, chrome, connect, desktop, device, display, education, for, hardware, iOS, learning, lessons teaching, mac, monitor, screen, screencast, streaming, television, tv, web, window, wireless</summary>
	/// <value>cast_for_education</value>
	CastForEducation = 61420,

	/// <summary></summary>
	/// <value>castle</value>
	Castle = 60081,

	/// <summary>catching, go, pokemon, pokestop, travel</summary>
	/// <value>catching_pokemon</value>
	CatchingPokemon = 58632,

	/// <summary>categories, category, circle, collection, items, product, sort, square, triangle</summary>
	/// <value>category</value>
	Category = 58740,

	/// <summary>activity, birthday, celebration, event, fun, party</summary>
	/// <value>celebration</value>
	Celebration = 60005,

	/// <summary></summary>
	/// <value>cell_tower</value>
	CellTower = 60346,

	/// <summary>cell, connection, data, internet, mobile, network, phone, service, signal, wifi, wireless</summary>
	/// <value>cell_wifi</value>
	CellWifi = 57580,

	/// <summary>camera, center, focus, image, lens, photo, photography, strong, zoom</summary>
	/// <value>center_focus_strong</value>
	CenterFocusStrong = 58292,

	/// <summary>camera, center, focus, image, lens, photo, photography, weak, zoom</summary>
	/// <value>center_focus_weak</value>
	CenterFocusWeak = 58293,

	/// <summary>chair, comfort, couch, decoration, furniture, home, house, living, lounging, loveseat, room, seat, seating, sofa</summary>
	/// <value>chair</value>
	Chair = 61421,

	/// <summary>cahir, furniture, home, house, kitchen, lounging, seating, table</summary>
	/// <value>chair_alt</value>
	ChairAlt = 61422,

	/// <summary>architecture, chalet, cottage, estate, home, house, maps, place, real, residence, residential, stay, traveling</summary>
	/// <value>chalet</value>
	Chalet = 58757,

	/// <summary>around, arrows, change, circle, direction, navigation, rotate</summary>
	/// <value>change_circle</value>
	ChangeCircle = 58087,

	/// <summary>change, history, shape, triangle</summary>
	/// <value>change_history</value>
	ChangeHistory = 59499,

	/// <summary>Android, OS, battery, bolt, cell, charging, device, electric, hardware, iOS, lightning, mobile, phone, station, tablet, thunderbolt</summary>
	/// <value>charging_station</value>
	ChargingStation = 61853,

	/// <summary>bubble, chat, comment, communicate, feedback, message, speech</summary>
	/// <value>chat</value>
	Chat = 57527,

	/// <summary>bubble, chat, comment, communicate, feedback, message, speech</summary>
	/// <value>chat_bubble</value>
	ChatBubble = 57546,

	/// <summary>bubble, chat, comment, communicate, feedback, message, outline, speech</summary>
	/// <value>chat_bubble_outline</value>
	ChatBubbleOutline = 57547,

	/// <summary>check, complete, confirm, correct, done, enter, mark, ok, okay, purchased, select, success, tick, yes</summary>
	/// <value>check</value>
	Check = 58826,

	/// <summary>approved, box, button, check, component, control, form, mark, ok, select, selected, selection, tick, toggle, ui, yes</summary>
	/// <value>check_box</value>
	CheckBox = 59444,

	/// <summary>blank, box, button, check, component, control, deselected, empty, form, outline, select, selection, square, tick, toggle, ui</summary>
	/// <value>check_box_outline_blank</value>
	CheckBoxOutlineBlank = 59445,

	/// <summary>approve, check, circle, complete, done, download, mark, ok, select, success, tick, upload, validate, verified, yes</summary>
	/// <value>check_circle</value>
	CheckCircle = 59500,

	/// <summary>approve, check, circle, complete, done, finished, mark, ok, outline, select, tick, validate, verified, yes</summary>
	/// <value>check_circle_outline</value>
	CheckCircleOutline = 59693,

	/// <summary></summary>
	/// <value>checklist</value>
	Checklist = 59057,

	/// <summary></summary>
	/// <value>checklist_rtl</value>
	ChecklistRtl = 59059,

	/// <summary>checkroom, closet, clothes, coat check, hanger</summary>
	/// <value>checkroom</value>
	Checkroom = 61854,

	/// <summary>arrow, arrows, back, chevron, direction, left, triangle</summary>
	/// <value>chevron_left</value>
	ChevronLeft = 58827,

	/// <summary>arrow, arrows, chevron, direction, forward, right, triangle</summary>
	/// <value>chevron_right</value>
	ChevronRight = 58828,

	/// <summary>babies, baby, care, child, children, face, infant, kids, newborn, toddler, young</summary>
	/// <value>child_care</value>
	ChildCare = 60225,

	/// <summary>baby, care, carriage, child, children, friendly, infant, kid, newborn, stroller, toddler, young</summary>
	/// <value>child_friendly</value>
	ChildFriendly = 60226,

	/// <summary>chrome, mode, read, reader, text</summary>
	/// <value>chrome_reader_mode</value>
	ChromeReaderMode = 59501,

	/// <summary></summary>
	/// <value>church</value>
	Church = 60078,

	/// <summary>button, circle, full, geometry, moon, radio</summary>
	/// <value>circle</value>
	Circle = 61258,

	/// <summary>active, alarm, alert, bell, chime, circle, notifications, notify, reminder, ring, sound</summary>
	/// <value>circle_notifications</value>
	CircleNotifications = 59796,

	/// <summary>archive, book, bookmark, class, favorite, label, library, read, reading, remember, ribbon, save, tag</summary>
	/// <value>class</value>
	Class = 59502,

	/// <summary>bacteria, clean, disinfect, germs, gesture, hand, hands, sanitize, sanitizer</summary>
	/// <value>clean_hands</value>
	CleanHands = 61983,

	/// <summary>clean, cleaning, dust, services, sweep</summary>
	/// <value>cleaning_services</value>
	CleaningServices = 61695,

	/// <summary>back, cancel, clear, correct, delete, erase, exit, x</summary>
	/// <value>clear</value>
	Clear = 57676,

	/// <summary>all, clear, doc, document, format, lines, list</summary>
	/// <value>clear_all</value>
	ClearAll = 57528,

	/// <summary>cancel, close, exit, stop, x</summary>
	/// <value>close</value>
	Close = 58829,

	/// <summary>action, arrow, arrows, close, collapse, direction, full, fullscreen, minimize, screen</summary>
	/// <value>close_fullscreen</value>
	CloseFullscreen = 61903,

	/// <summary>accessible, alphabet, caption, cc, character, closed, decoder, font, language, letter, media, movies, subtitle, subtitles, symbol, text, tv, type</summary>
	/// <value>closed_caption</value>
	ClosedCaption = 57372,

	/// <summary>accessible, alphabet, caption, cc, character, closed, decoder, disabled, enabled, font, language, letter, media, movies, off, on, slash, subtitle, subtitles, symbol, text, tv, type</summary>
	/// <value>closed_caption_disabled</value>
	ClosedCaptionDisabled = 61916,

	/// <summary>accessible, alphabet, caption, cc, character, closed, decoder, font, language, letter, media, movies, off, outline, subtitle, subtitles, symbol, text, tv, type</summary>
	/// <value>closed_caption_off</value>
	ClosedCaptionOff = 59798,

	/// <summary>cloud, connection, internet, network, sky, upload</summary>
	/// <value>cloud</value>
	Cloud = 58045,

	/// <summary>app, application, backup, circle, cloud, connection, drive, files, folders, internet, network, sky, storage, upload</summary>
	/// <value>cloud_circle</value>
	CloudCircle = 58046,

	/// <summary>app, application, approve, backup, check, cloud, complete, connection, done, drive, files, folders, internet, mark, network, ok, select, sky, storage, tick, upload, validate, verified, yes</summary>
	/// <value>cloud_done</value>
	CloudDone = 58047,

	/// <summary>app, application, arrow, backup, cloud, connection, down, download, drive, files, folders, internet, network, sky, storage, upload</summary>
	/// <value>cloud_download</value>
	CloudDownload = 58048,

	/// <summary>app, application, backup, cloud, connection, disabled, drive, enabled, files, folders, internet, network, off, offline, on, sky, slash, storage, upload</summary>
	/// <value>cloud_off</value>
	CloudOff = 58049,

	/// <summary>cloud, connection, internet, network, queue, sky, upload</summary>
	/// <value>cloud_queue</value>
	CloudQueue = 58050,

	/// <summary></summary>
	/// <value>cloud_sync</value>
	CloudSync = 60250,

	/// <summary>app, application, arrow, backup, cloud, connection, download, drive, files, folders, internet, network, sky, storage, up, upload</summary>
	/// <value>cloud_upload</value>
	CloudUpload = 58051,

	/// <summary></summary>
	/// <value>co2</value>
	Co2 = 59312,

	/// <summary></summary>
	/// <value>co_present</value>
	CoPresent = 60144,

	/// <summary>brackets, code, css, develop, developer, engineer, engineering, html, platform</summary>
	/// <value>code</value>
	Code = 59503,

	/// <summary>brackets, code, css, develop, developer, disabled, enabled, engineer, engineering, html, off, on, platform, slash</summary>
	/// <value>code_off</value>
	CodeOff = 58611,

	/// <summary>beverage, coffee, cup, drink, mug, plate, set, tea</summary>
	/// <value>coffee</value>
	Coffee = 61423,

	/// <summary>appliances, beverage, coffee, cup, drink, machine, maker, mug</summary>
	/// <value>coffee_maker</value>
	CoffeeMaker = 61424,

	/// <summary>album, collections, gallery, image, landscape, library, mountain, mountains, photo, photography, picture, stack</summary>
	/// <value>collections</value>
	Collections = 58294,

	/// <summary>album, archive, bookmark, collections, favorite, gallery, label, library, read, reading, remember, ribbon, save, stack, tag</summary>
	/// <value>collections_bookmark</value>
	CollectionsBookmark = 58417,

	/// <summary>art, color, lens, paint, pallet</summary>
	/// <value>color_lens</value>
	ColorLens = 58295,

	/// <summary>color, colorize, dropper, extract, eye, picker, tool</summary>
	/// <value>colorize</value>
	Colorize = 58296,

	/// <summary>bubble, chat, comment, communicate, feedback, message, outline, speech</summary>
	/// <value>comment</value>
	Comment = 57529,

	/// <summary>archive, bank, bookmark, bubble, cchat, comment, communicate, favorite, label, library, message, remember, ribbon, save, speech, tag</summary>
	/// <value>comment_bank</value>
	CommentBank = 59982,

	/// <summary></summary>
	/// <value>comments_disabled</value>
	CommentsDisabled = 59298,

	/// <summary></summary>
	/// <value>commit</value>
	Commit = 60149,

	/// <summary>automobile, car, commute, direction, maps, public, train, transportation, trip, vehicle</summary>
	/// <value>commute</value>
	Commute = 59712,

	/// <summary>adjust, adjustment, compare, edit, editing, edits, enhance, fix, image, images, photo, photography, photos, scan, settings</summary>
	/// <value>compare</value>
	Compare = 58297,

	/// <summary>arrow, arrows, collide, compare, direction, left, pressure, push, right, together</summary>
	/// <value>compare_arrows</value>
	CompareArrows = 59669,

	/// <summary>calibration, compass, connection, internet, location, maps, network, refresh, service, signal, wifi, wireless</summary>
	/// <value>compass_calibration</value>
	CompassCalibration = 58748,

	/// <summary></summary>
	/// <value>compost</value>
	Compost = 59233,

	/// <summary>arrow, arrows, collide, compress, pressure, push, together</summary>
	/// <value>compress</value>
	Compress = 59725,

	/// <summary>Android, OS, chrome, computer, desktop, device, hardware, iOS, mac, monitor, web, window</summary>
	/// <value>computer</value>
	Computer = 58122,

	/// <summary>admission, confirmation, entertainment, event, number, ticket</summary>
	/// <value>confirmation_number</value>
	ConfirmationNumber = 58936,

	/// <summary>communicating, connect, contact, distance, people, signal, social, socialize, without</summary>
	/// <value>connect_without_contact</value>
	ConnectWithoutContact = 61987,

	/// <summary>Android, OS, airplay, chrome, connect, connected, desktop, device, display, hardware, iOS, mac, monitor, screen, screencast, streaming, television, tv, web, window, wireless</summary>
	/// <value>connected_tv</value>
	ConnectedTv = 59800,

	/// <summary></summary>
	/// <value>connecting_airports</value>
	ConnectingAirports = 59337,

	/// <summary>build, carpenter, construction, equipment, fix, hammer, improvement, industrial, industry, repair, tools, wrench</summary>
	/// <value>construction</value>
	Construction = 59964,

	/// <summary>account, address, avatar, communicate, contact, email, face, human, info, information, mail, message, people, person, profile, user</summary>
	/// <value>contact_mail</value>
	ContactMail = 57552,

	/// <summary>account, avatar, contact, data, doc, document, drive, face, file, folder, folders, human, page, people, person, profile, sheet, slide, storage, user, writing</summary>
	/// <value>contact_page</value>
	ContactPage = 61998,

	/// <summary>account, avatar, call, communicate, contact, face, human, info, information, message, mobile, people, person, phone, profile, user</summary>
	/// <value>contact_phone</value>
	ContactPhone = 57551,

	/// <summary>?, bubble, chat, comment, communicate, contact, help, info, information, mark, message, punctuation, question, speech, support, symbol, vquestion mark</summary>
	/// <value>contact_support</value>
	ContactSupport = 59724,

	/// <summary>bluetooth, cash, connect, connection, connectivity, contact, contactless, credit, device, finance, pay, payment, signal, transaction, wifi, wireless</summary>
	/// <value>contactless</value>
	Contactless = 60017,

	/// <summary>account, avatar, call, cell, contacts, face, human, info, information, mobile, people, person, phone, profile, user</summary>
	/// <value>contacts</value>
	Contacts = 57530,

	/// <summary>content, copy, cut, doc, document, duplicate, file, multiple, past</summary>
	/// <value>content_copy</value>
	ContentCopy = 57677,

	/// <summary>content, copy, cut, doc, document, file, past, scissors, trim</summary>
	/// <value>content_cut</value>
	ContentCut = 57678,

	/// <summary>clipboard, content, copy, cut, doc, document, file, multiple, past</summary>
	/// <value>content_paste</value>
	ContentPaste = 57679,

	/// <summary></summary>
	/// <value>content_paste_go</value>
	ContentPasteGo = 60046,

	/// <summary>clipboard, content, disabled, doc, document, enabled, file, off, on, paste, slash</summary>
	/// <value>content_paste_off</value>
	ContentPasteOff = 58616,

	/// <summary></summary>
	/// <value>content_paste_search</value>
	ContentPasteSearch = 60059,

	/// <summary></summary>
	/// <value>contrast</value>
	Contrast = 60215,

	/// <summary>adjust, arrow, arrows, camera, center, control, direction, left, move, right</summary>
	/// <value>control_camera</value>
	ControlCamera = 57460,

	/// <summary>+, add, circle, control, plus, point</summary>
	/// <value>control_point</value>
	ControlPoint = 58298,

	/// <summary>+, add, circle, control, duplicate, multiple, new, plus, point, symbol</summary>
	/// <value>control_point_duplicate</value>
	ControlPointDuplicate = 58299,

	/// <summary></summary>
	/// <value>cookie</value>
	Cookie = 60076,

	/// <summary>all, content, copy, cut, doc, document, file, multiple, page, paper, past</summary>
	/// <value>copy_all</value>
	CopyAll = 58092,

	/// <summary>alphabet, c, character, circle, copyright, emblem, font, legal, letter, owner, symbol, text</summary>
	/// <value>copyright</value>
	Copyright = 59660,

	/// <summary>19, bacteria, coronavirus, covid, disease, germs, illness, sick, social</summary>
	/// <value>coronavirus</value>
	Coronavirus = 61985,

	/// <summary>architecture, building, business, corporate, estate, fare, organization, place, real, residence, residential, shelter</summary>
	/// <value>corporate_fare</value>
	CorporateFare = 61904,

	/// <summary>architecture, beach, cottage, estate, home, house, lake, lodge, maps, place, real, residence, residential, stay, traveling</summary>
	/// <value>cottage</value>
	Cottage = 58759,

	/// <summary>counter, countertops, home, house, kitchen, sink, table, tops</summary>
	/// <value>countertops</value>
	Countertops = 61943,

	/// <summary>compose, create, edit, editing, input, new, pen, pencil, write, writing</summary>
	/// <value>create</value>
	Create = 57680,

	/// <summary>+, add, create, data, doc, document, drive, file, folder, new, plus, sheet, slide, storage, symbol</summary>
	/// <value>create_new_folder</value>
	CreateNewFolder = 58060,

	/// <summary>bill, card, cash, coin, commerce, cost, credit, currency, dollars, finance, money, online, pay, payment, price, shopping, symbol</summary>
	/// <value>credit_card</value>
	CreditCard = 59504,

	/// <summary>card, charge, commerce, cost, credit, disabled, enabled, finance, money, off, online, pay, payment, slash</summary>
	/// <value>credit_card_off</value>
	CreditCardOff = 58612,

	/// <summary>approve, bill, card, cash, check, coin, commerce, complete, cost, credit, currency, dollars, done, finance, loan, mark, money, ok, online, pay, payment, score, select, symbol, tick, validate, verified, yes</summary>
	/// <value>credit_score</value>
	CreditScore = 61425,

	/// <summary>babies, baby, bassinet, bed, child, children, cradle, crib, infant, kid, newborn, sleeping, toddler</summary>
	/// <value>crib</value>
	Crib = 58760,

	/// <summary>adjust, adjustments, area, crop, edit, editing, frame, image, images, photo, photos, rectangle, settings, size, square</summary>
	/// <value>crop</value>
	Crop = 58302,

	/// <summary>16, 9, adjust, adjustments, area, by, crop, edit, editing, frame, image, images, photo, photos, rectangle, settings, size, square</summary>
	/// <value>crop_16_9</value>
	Crop169 = 58300,

	/// <summary>2, 3, adjust, adjustments, area, by, crop, edit, editing, frame, image, images, photo, photos, rectangle, settings, size, square</summary>
	/// <value>crop_3_2</value>
	Crop32 = 58301,

	/// <summary>4, 5, adjust, adjustments, area, by, crop, edit, editing settings, frame, image, images, photo, photos, rectangle, size, square</summary>
	/// <value>crop_5_4</value>
	Crop54 = 58303,

	/// <summary>5, 7, adjust, adjustments, area, by, crop, editing, frame, image, images, photo, photos, rectangle, settings, size, square</summary>
	/// <value>crop_7_5</value>
	Crop75 = 58304,

	/// <summary>adjust, adjustments, area, crop, din, edit, editing, frame, image, images, photo, photos, rectangle, settings, size, square</summary>
	/// <value>crop_din</value>
	CropDin = 58305,

	/// <summary>adjust, adjustments, crop, edit, editing, focus, frame, free, image, photo, photos, settings, size, zoom</summary>
	/// <value>crop_free</value>
	CropFree = 58306,

	/// <summary>adjust, adjustments, area, crop, edit, editing, frame, image, images, landscape, photo, photos, settings, size</summary>
	/// <value>crop_landscape</value>
	CropLandscape = 58307,

	/// <summary>adjust, adjustments, area, crop, edit, editing, frame, image, images, original, photo, photos, picture, settings, size</summary>
	/// <value>crop_original</value>
	CropOriginal = 58308,

	/// <summary>adjust, adjustments, area, crop, edit, editing, frame, image, images, photo, photos, portrait, rectangle, settings, size, square</summary>
	/// <value>crop_portrait</value>
	CropPortrait = 58309,

	/// <summary>adjust, adjustments, area, arrow, arrows, crop, edit, editing, frame, image, images, photo, photos, rotate, settings, size, turn</summary>
	/// <value>crop_rotate</value>
	CropRotate = 58423,

	/// <summary>adjust, adjustments, area, crop, edit, editing, frame, image, images, photo, photos, rectangle, settings, size, square</summary>
	/// <value>crop_square</value>
	CropSquare = 58310,

	/// <summary></summary>
	/// <value>cruelty_free</value>
	CrueltyFree = 59289,

	/// <summary></summary>
	/// <value>css</value>
	Css = 60307,

	/// <summary></summary>
	/// <value>currency_bitcoin</value>
	CurrencyBitcoin = 60357,

	/// <summary></summary>
	/// <value>currency_exchange</value>
	CurrencyExchange = 60272,

	/// <summary></summary>
	/// <value>currency_franc</value>
	CurrencyFranc = 60154,

	/// <summary></summary>
	/// <value>currency_lira</value>
	CurrencyLira = 60143,

	/// <summary></summary>
	/// <value>currency_pound</value>
	CurrencyPound = 60145,

	/// <summary></summary>
	/// <value>currency_ruble</value>
	CurrencyRuble = 60140,

	/// <summary></summary>
	/// <value>currency_rupee</value>
	CurrencyRupee = 60151,

	/// <summary></summary>
	/// <value>currency_yen</value>
	CurrencyYen = 60155,

	/// <summary></summary>
	/// <value>currency_yuan</value>
	CurrencyYuan = 60153,

	/// <summary>broken, danger, dangerous, fix, no, sign, stop, update, warning, wrong, x</summary>
	/// <value>dangerous</value>
	Dangerous = 59802,

	/// <summary>app, application, dark, device, interface, mode, moon, night, silent, theme, ui, ux, website</summary>
	/// <value>dark_mode</value>
	DarkMode = 58652,

	/// <summary>cards, dashboard, format, layout, rectangle, shapes, square, web, website</summary>
	/// <value>dashboard</value>
	Dashboard = 59505,

	/// <summary>cards, customize, dashboard, format, layout, rectangle, shapes, square, web, website</summary>
	/// <value>dashboard_customize</value>
	DashboardCustomize = 59803,

	/// <summary></summary>
	/// <value>data_array</value>
	DataArray = 60113,

	/// <summary></summary>
	/// <value>data_exploration</value>
	DataExploration = 59247,

	/// <summary></summary>
	/// <value>data_object</value>
	DataObject = 60115,

	/// <summary>analytics, bar, bars, chart, data, diagram, donut, graph, infographic, measure, metrics, off, on, ring, saver, statistics, tracking</summary>
	/// <value>data_saver_off</value>
	DataSaverOff = 61426,

	/// <summary>+, add, analytics, chart, data, diagram, graph, infographic, measure, metrics, new, on, plus, ring, saver, statistics, symbol, tracking</summary>
	/// <value>data_saver_on</value>
	DataSaverOn = 61427,

	/// <summary></summary>
	/// <value>data_thresholding</value>
	DataThresholding = 60319,

	/// <summary>analytics, chart, data, diagram, graph, infographic, measure, metrics, statistics, tracking, usage</summary>
	/// <value>data_usage</value>
	DataUsage = 57775,

	/// <summary>calendar, date, day, event, month, range, remember, reminder, schedule, time, today, week</summary>
	/// <value>date_range</value>
	DateRange = 59670,

	/// <summary></summary>
	/// <value>deblur</value>
	Deblur = 60279,

	/// <summary>chairs, deck, home, house, outdoors, outside, patio, social, terrace, umbrella, yard</summary>
	/// <value>deck</value>
	Deck = 59970,

	/// <summary>adjust, dehaze, edit, editing, enhance, haze, image, lines, photo, photography, remove</summary>
	/// <value>dehaze</value>
	Dehaze = 58311,

	/// <summary>bin, can, delete, garbage, remove, trash</summary>
	/// <value>delete</value>
	Delete = 59506,

	/// <summary>bin, can, cancel, delete, exit, forever, garbage, remove, trash, x</summary>
	/// <value>delete_forever</value>
	DeleteForever = 59691,

	/// <summary>bin, can, delete, garbage, outline, remove, trash</summary>
	/// <value>delete_outline</value>
	DeleteOutline = 59694,

	/// <summary>bin, can, delete, garbage, remove, sweep, trash</summary>
	/// <value>delete_sweep</value>
	DeleteSweep = 57708,

	/// <summary>delivery, dining, food, meal, restaurant, scooter, takeout, transportation, vehicle, vespa</summary>
	/// <value>delivery_dining</value>
	DeliveryDining = 60018,

	/// <summary></summary>
	/// <value>density_large</value>
	DensityLarge = 60329,

	/// <summary></summary>
	/// <value>density_medium</value>
	DensityMedium = 60318,

	/// <summary></summary>
	/// <value>density_small</value>
	DensitySmall = 60328,

	/// <summary>automobile, board, bus, car, cars, clock, departure, maps, public, schedule, time, transportation, travel, vehicle</summary>
	/// <value>departure_board</value>
	DepartureBoard = 58742,

	/// <summary>article, data, description, doc, document, drive, file, folder, folders, notes, page, paper, sheet, slide, text, writing</summary>
	/// <value>description</value>
	Description = 59507,

	/// <summary></summary>
	/// <value>deselect</value>
	Deselect = 60342,

	/// <summary></summary>
	/// <value>design_services</value>
	DesignServices = 61706,

	/// <summary>Android, OS, access, chrome, desktop, device, disabled, display, enabled, hardware, iOS, mac, monitor, off, offline, on, screen, slash, web, window</summary>
	/// <value>desktop_access_disabled</value>
	DesktopAccessDisabled = 59805,

	/// <summary>Android, OS, chrome, desktop, device, display, hardware, iOS, mac, monitor, screen, web, window</summary>
	/// <value>desktop_mac</value>
	DesktopMac = 58123,

	/// <summary>Android, OS, chrome, desktop, device, display, hardware, iOS, mac, monitor, screen, television, tv, web, window, windows</summary>
	/// <value>desktop_windows</value>
	DesktopWindows = 58124,

	/// <summary>details, edit, editing, enhance, image, photo, photography, sharpen, triangle</summary>
	/// <value>details</value>
	Details = 58312,

	/// <summary>board, chip, computer, developer, development, hardware, microchip, processor</summary>
	/// <value>developer_board</value>
	DeveloperBoard = 58125,

	/// <summary>board, chip, computer, developer, development, disabled, enabled, hardware, microchip, off, on, processor, slash</summary>
	/// <value>developer_board_off</value>
	DeveloperBoardOff = 58623,

	/// <summary>Android, OS, bracket, cell, code, developer, development, device, engineer, hardware, iOS, mobile, mode, phone, tablet</summary>
	/// <value>developer_mode</value>
	DeveloperMode = 57776,

	/// <summary>Android, OS, circle, computer, desktop, device, hardware, hub, iOS, laptop, mobile, monitor, phone, square, tablet, triangle, watch, wearable, web</summary>
	/// <value>device_hub</value>
	DeviceHub = 58165,

	/// <summary>celsius, device, fahrenheit, meter, temp, temperature, thermometer, thermostat</summary>
	/// <value>device_thermostat</value>
	DeviceThermostat = 57855,

	/// <summary>?, Android, OS, assistance, cell, device, hardware, help, iOS, info, information, mobile, phone, punctuation, question mark, support, symbol, tablet, unknown</summary>
	/// <value>device_unknown</value>
	DeviceUnknown = 58169,

	/// <summary>Android, OS, computer, desktop, device, hardware, iOS, laptop, mobile, monitor, phone, tablet, watch, wearable, web</summary>
	/// <value>devices</value>
	Devices = 57777,

	/// <summary>Android, OS, ar, cell, chrome, desktop, device, gadget, hardware, iOS, ipad, mac, mobile, monitor, other, phone, tablet, vr, watch, wearables, window</summary>
	/// <value>devices_other</value>
	DevicesOther = 58167,

	/// <summary>alphabet, call, cell, character, contact, device, dialer, font, hardware, initiation, internet, letter, mobile, over, phone, protocol, routing, session, sip, symbol, telephone, text, type, voice</summary>
	/// <value>dialer_sip</value>
	DialerSip = 57531,

	/// <summary>buttons, call, contact, device, dial, dialpad, dots, mobile, numbers, pad, phone</summary>
	/// <value>dialpad</value>
	Dialpad = 57532,

	/// <summary></summary>
	/// <value>diamond</value>
	Diamond = 60117,

	/// <summary></summary>
	/// <value>difference</value>
	Difference = 60285,

	/// <summary>cafe, cafeteria, cutlery, diner, dining, eat, eating, fork, room, spoon</summary>
	/// <value>dining</value>
	Dining = 61428,

	/// <summary>breakfast, dining, dinner, food, fork, lunch, meal, restaurant, spaghetti, utensils</summary>
	/// <value>dinner_dining</value>
	DinnerDining = 59991,

	/// <summary>arrow, directions, maps, right, route, sign, traffic</summary>
	/// <value>directions</value>
	Directions = 58670,

	/// <summary>bicycle, bike, direction, directions, human, maps, person, public, route, transportation</summary>
	/// <value>directions_bike</value>
	DirectionsBike = 58671,

	/// <summary>automobile, boat, car, cars, direction, directions, ferry, maps, public, transportation, vehicle</summary>
	/// <value>directions_boat</value>
	DirectionsBoat = 58674,

	/// <summary>automobile, boat, car, cars, direction, directions, ferry, filled, maps, public, transportation, vehicle</summary>
	/// <value>directions_boat_filled</value>
	DirectionsBoatFilled = 61429,

	/// <summary>automobile, bus, car, cars, directions, maps, public, transportation, vehicle</summary>
	/// <value>directions_bus</value>
	DirectionsBus = 58672,

	/// <summary>automobile, bus, car, cars, direction, directions, filled, maps, public, transportation, vehicle</summary>
	/// <value>directions_bus_filled</value>
	DirectionsBusFilled = 61430,

	/// <summary>automobile, car, cars, direction, directions, maps, public, transportation, vehicle</summary>
	/// <value>directions_car</value>
	DirectionsCar = 58673,

	/// <summary>automobile, car, cars, direction, directions, filled, maps, public, transportation, vehicle</summary>
	/// <value>directions_car_filled</value>
	DirectionsCarFilled = 61431,

	/// <summary>arrow, directions, disabled, enabled, maps, off, on, right, route, sign, slash, traffic</summary>
	/// <value>directions_off</value>
	DirectionsOff = 61711,

	/// <summary>automobile, car, cars, direction, directions, maps, public, railway, train, transportation, vehicle</summary>
	/// <value>directions_railway</value>
	DirectionsRailway = 58676,

	/// <summary>automobile, car, cars, direction, directions, filled, maps, public, railway, train, transportation, vehicle</summary>
	/// <value>directions_railway_filled</value>
	DirectionsRailwayFilled = 61432,

	/// <summary>body, directions, human, jogging, maps, people, person, route, run, running, walk</summary>
	/// <value>directions_run</value>
	DirectionsRun = 58726,

	/// <summary>automobile, car, cars, direction, directions, maps, public, rail, subway, train, transportation, vehicle</summary>
	/// <value>directions_subway</value>
	DirectionsSubway = 58675,

	/// <summary>automobile, car, cars, direction, directions, filled, maps, public, rail, subway, train, transportation, vehicle</summary>
	/// <value>directions_subway_filled</value>
	DirectionsSubwayFilled = 61433,

	/// <summary>automobile, car, cars, direction, directions, maps, public, rail, subway, train, transit, transportation, vehicle</summary>
	/// <value>directions_transit</value>
	DirectionsTransit = 58677,

	/// <summary>automobile, car, cars, direction, directions, filled, maps, public, rail, subway, train, transit, transportation, vehicle</summary>
	/// <value>directions_transit_filled</value>
	DirectionsTransitFilled = 61434,

	/// <summary>body, direction, directions, human, jogging, maps, people, person, route, run, walk</summary>
	/// <value>directions_walk</value>
	DirectionsWalk = 58678,

	/// <summary>camera, dirty, lens, photo, photography, picture, splat</summary>
	/// <value>dirty_lens</value>
	DirtyLens = 61259,

	/// <summary>box, by, cancel, close, default, disabled, exit, no, quit, remove, square, stop, x</summary>
	/// <value>disabled_by_default</value>
	DisabledByDefault = 62000,

	/// <summary></summary>
	/// <value>disabled_visible</value>
	DisabledVisible = 59246,

	/// <summary>!, alert, attention, caution, cd, danger, disc, error, exclamation, full, important, mark, music, notification, storage, symbol, warning</summary>
	/// <value>disc_full</value>
	DiscFull = 58896,

	/// <summary></summary>
	/// <value>discount</value>
	Discount = 60361,

	/// <summary></summary>
	/// <value>display_settings</value>
	DisplaySettings = 60311,

	/// <summary>address, bars, dns, domain, information, ip, list, lookup, name, server, system</summary>
	/// <value>dns</value>
	Dns = 59509,

	/// <summary>cancel, close, denied, deny, disturb, do, remove, silence, stop</summary>
	/// <value>do_disturb</value>
	DoDisturb = 61580,

	/// <summary>cancel, close, denied, deny, disturb, do, remove, silence, stop</summary>
	/// <value>do_disturb_alt</value>
	DoDisturbAlt = 61581,

	/// <summary>cancel, close, denied, deny, disabled, disturb, do, enabled, off, on, remove, silence, slash, stop</summary>
	/// <value>do_disturb_off</value>
	DoDisturbOff = 61582,

	/// <summary>cancel, close, denied, deny, disabled, disturb, do, enabled, off, on, remove, silence, slash, stop</summary>
	/// <value>do_disturb_on</value>
	DoDisturbOn = 61583,

	/// <summary>cancel, close, denied, deny, disturb, do, remove, silence, stop</summary>
	/// <value>do_not_disturb</value>
	DoNotDisturb = 58898,

	/// <summary>cancel, close, denied, deny, disturb, do, remove, silence, stop</summary>
	/// <value>do_not_disturb_alt</value>
	DoNotDisturbAlt = 58897,

	/// <summary>cancel, close, denied, deny, disabled, disturb, do, enabled, off, on, remove, silence, slash, stop</summary>
	/// <value>do_not_disturb_off</value>
	DoNotDisturbOff = 58947,

	/// <summary>cancel, close, denied, deny, disabled, disturb, do, enabled, off, on, remove, silence, slash, stop</summary>
	/// <value>do_not_disturb_on</value>
	DoNotDisturbOn = 58948,

	/// <summary>busy, disturb, do, mute, no, not, on total, quiet, silence</summary>
	/// <value>do_not_disturb_on_total_silence</value>
	DoNotDisturbOnTotalSilence = 61435,

	/// <summary>boot, disabled, do, enabled, feet, foot, not, off, on, shoe, slash, sneaker, step</summary>
	/// <value>do_not_step</value>
	DoNotStep = 61855,

	/// <summary>disabled, do, enabled, fingers, gesture, hand, not, off, on, slash, touch</summary>
	/// <value>do_not_touch</value>
	DoNotTouch = 61872,

	/// <summary>Android, OS, cell, charging, connector, device, dock, hardware, iOS, mobile, phone, power, station, tablet</summary>
	/// <value>dock</value>
	Dock = 58126,

	/// <summary></summary>
	/// <value>document_scanner</value>
	DocumentScanner = 58874,

	/// <summary>apartment, architecture, building, business, domain, estate, home, place, real, residence, residential, shelter, web, www</summary>
	/// <value>domain</value>
	Domain = 59374,

	/// <summary></summary>
	/// <value>domain_add</value>
	DomainAdd = 60258,

	/// <summary>apartment, architecture, building, business, company, disabled, domain, enabled, estate, home, internet, maps, off, office, offline, on, place, real, residence, residential, slash, web, website</summary>
	/// <value>domain_disabled</value>
	DomainDisabled = 57583,

	/// <summary>app, application desktop, approve, check, complete, design, domain, done, interface, internet, layout, mark, ok, screen, select, site, tick, ui, ux, validate, verification, verified, web, website, window, www, yes</summary>
	/// <value>domain_verification</value>
	DomainVerification = 61260,

	/// <summary>approve, check, complete, done, mark, ok, select, tick, validate, verified, yes</summary>
	/// <value>done</value>
	Done = 59510,

	/// <summary>all, approve, check, complete, done, layers, mark, multiple, ok, select, stack, tick, validate, verified, yes</summary>
	/// <value>done_all</value>
	DoneAll = 59511,

	/// <summary>all, approve, check, complete, done, mark, ok, outline, select, tick, validate, verified, yes</summary>
	/// <value>done_outline</value>
	DoneOutline = 59695,

	/// <summary>analytics, chart, data, diagram, donut, graph, infographic, inprogress, large, measure, metrics, pie, statistics, tracking</summary>
	/// <value>donut_large</value>
	DonutLarge = 59671,

	/// <summary>analytics, chart, data, diagram, donut, graph, infographic, inprogress, measure, metrics, pie, small, statistics, tracking</summary>
	/// <value>donut_small</value>
	DonutSmall = 59672,

	/// <summary>back, closed, door, doorway, entrance, exit, home, house, way</summary>
	/// <value>door_back</value>
	DoorBack = 61436,

	/// <summary>closed, door, doorway, entrance, exit, front, home, house, way</summary>
	/// <value>door_front</value>
	DoorFront = 61437,

	/// <summary>auto, automatic, door, doorway, double, entrance, exit, glass, home, house, sliding, two</summary>
	/// <value>door_sliding</value>
	DoorSliding = 61438,

	/// <summary>alarm, bell, door, doorbell, home, house, ringing</summary>
	/// <value>doorbell</value>
	Doorbell = 61439,

	/// <summary>arrow, arrows, direction, double, multiple, navigation, right</summary>
	/// <value>double_arrow</value>
	DoubleArrow = 59984,

	/// <summary>athlete, athletic, body, downhill, entertainment, exercise, hobby, human, people, person, ski social, skiing, snow, sports, travel, winter</summary>
	/// <value>downhill_skiing</value>
	DownhillSkiing = 58633,

	/// <summary>arrow, down, download, downloads, drive, install, upload</summary>
	/// <value>download</value>
	Download = 61584,

	/// <summary>arrow, arrows, check, done, down, download, downloads, drive, install, installed, ok, tick, upload</summary>
	/// <value>download_done</value>
	DownloadDone = 61585,

	/// <summary>arrow, circle, down, download, for offline, install, upload</summary>
	/// <value>download_for_offline</value>
	DownloadForOffline = 61440,

	/// <summary>arrow, circle, down, download, downloading, downloads, install, pending, progress, upload</summary>
	/// <value>downloading</value>
	Downloading = 61441,

	/// <summary>document, draft, drafts, email, file, letter, mail, message, read</summary>
	/// <value>drafts</value>
	Drafts = 57681,

	/// <summary>app, application ui, components, design, drag, handle, interface, layout, menu, move, screen, site, ui, ux, web, website, window</summary>
	/// <value>drag_handle</value>
	DragHandle = 57949,

	/// <summary>app, application, circles, components, design, dots, drag, drop, indicator, interface, layout, mobile, monitor, move, phone, screen, shape, shift, site, tablet, ui, ux, web, website, window</summary>
	/// <value>drag_indicator</value>
	DragIndicator = 59717,

	/// <summary></summary>
	/// <value>draw</value>
	Draw = 59206,

	/// <summary>automobile, car, cars, destination, direction, drive, estimate, eta, maps, public, transportation, travel, trip, vehicle</summary>
	/// <value>drive_eta</value>
	DriveEta = 58899,

	/// <summary>arrow, arrows, data, direction, doc, document, drive, file, folder, folders, move, right, sheet, side, slide, storage</summary>
	/// <value>drive_file_move</value>
	DriveFileMove = 58997,

	/// <summary>drive, file, move</summary>
	/// <value>drive_file_move_rtl</value>
	DriveFileMoveRtl = 59245,

	/// <summary>compose, create, draft, drive, edit, editing, file, input, pen, pencil, rename, write, writing</summary>
	/// <value>drive_file_rename_outline</value>
	DriveFileRenameOutline = 59810,

	/// <summary>arrow, data, doc, document, drive, file, folder, sheet, slide, storage, up, upload</summary>
	/// <value>drive_folder_upload</value>
	DriveFolderUpload = 59811,

	/// <summary>air, bathroom, dry, dryer, fingers, gesture, hand, wc</summary>
	/// <value>dry</value>
	Dry = 61875,

	/// <summary>cleaning, dry, hanger, hotel, laundry, places, service, towel</summary>
	/// <value>dry_cleaning</value>
	DryCleaning = 59992,

	/// <summary>call, chat, conference, device, duo, video</summary>
	/// <value>duo</value>
	Duo = 59813,

	/// <summary>Android, OS, audio, chrome, computer, desktop, device, display, dvr, electronic, hardware, iOS, list, mac, monitor, record, recorder, screen, tv, video, web, window</summary>
	/// <value>dvr</value>
	Dvr = 57778,

	/// <summary>dynamic, feed, layer, multiple, post</summary>
	/// <value>dynamic_feed</value>
	DynamicFeed = 59924,

	/// <summary>bolt, code, dynamic, electric, fast, form, lightning, lists, questionnaire, thunderbolt</summary>
	/// <value>dynamic_form</value>
	DynamicForm = 61887,

	/// <summary>alphabet, data, e, font, letter, mobile, mobiledata, text, type</summary>
	/// <value>e_mobiledata</value>
	EMobiledata = 61442,

	/// <summary>accessory, audio, earbuds, earphone, headphone, listen, music, sound</summary>
	/// <value>earbuds</value>
	Earbuds = 61443,

	/// <summary>accessory, audio, battery, charging, earbuds, earphone, headphone, listen, music, sound</summary>
	/// <value>earbuds_battery</value>
	EarbudsBattery = 61444,

	/// <summary>arrow, directional, east, maps, navigation, right</summary>
	/// <value>east</value>
	East = 61919,

	/// <summary>Android, OS, cell, device, edge, hardware, high, iOS, mobile, move, phone, sensitivity, sensor, tablet, vibrate</summary>
	/// <value>edgesensor_high</value>
	EdgesensorHigh = 61445,

	/// <summary>Android, cell, device, edge, hardware, iOS, low, mobile, move, phone, sensitivity, sensor, tablet, vibrate</summary>
	/// <value>edgesensor_low</value>
	EdgesensorLow = 61446,

	/// <summary>compose, create, edit, editing, input, new, pen, pencil, write, writing</summary>
	/// <value>edit</value>
	Edit = 58313,

	/// <summary>approve, attribution, check, complete, done, edit, mark, ok, select, tick, validate, verified, yes</summary>
	/// <value>edit_attributes</value>
	EditAttributes = 58744,

	/// <summary></summary>
	/// <value>edit_calendar</value>
	EditCalendar = 59202,

	/// <summary>destination, direction, edit, location, maps, pen, pencil, pin, place, stop</summary>
	/// <value>edit_location</value>
	EditLocation = 58728,

	/// <summary>alt, edit, location, pen, pencil, pin</summary>
	/// <value>edit_location_alt</value>
	EditLocationAlt = 57797,

	/// <summary></summary>
	/// <value>edit_note</value>
	EditNote = 59205,

	/// <summary>active, alarm, alert, bell, chime, compose, create, draft, edit, editing, input, new, notifications, notify, pen, pencil, reminder, ring, sound, write, writing</summary>
	/// <value>edit_notifications</value>
	EditNotifications = 58661,

	/// <summary>compose, create, disabled, draft, edit, editing, enabled, input, new, off, offline, on, pen, pencil, slash, write, writing</summary>
	/// <value>edit_off</value>
	EditOff = 59728,

	/// <summary>destination, direction, edit, highway, maps, pen, pencil, road, street, traffic</summary>
	/// <value>edit_road</value>
	EditRoad = 61261,

	/// <summary></summary>
	/// <value>egg</value>
	Egg = 60108,

	/// <summary></summary>
	/// <value>egg_alt</value>
	EggAlt = 60104,

	/// <summary>disc, drive, dvd, eject, remove, triangle, usb</summary>
	/// <value>eject</value>
	Eject = 59643,

	/// <summary>body, cane, elderly, human, old, people, person, senior</summary>
	/// <value>elderly</value>
	Elderly = 61978,

	/// <summary></summary>
	/// <value>elderly_woman</value>
	ElderlyWoman = 60265,

	/// <summary>automobile, bike, car, cars, maps, scooter, transportation, vehicle, vespa</summary>
	/// <value>electric_bike</value>
	ElectricBike = 60187,

	/// <summary>automobile, car, cars, electric, electricity, maps, transportation, vehicle</summary>
	/// <value>electric_car</value>
	ElectricCar = 60188,

	/// <summary>automobile, bike, car, cars, maps, scooter, transportation, vehicle, vespa</summary>
	/// <value>electric_moped</value>
	ElectricMoped = 60189,

	/// <summary>automobile, car, cars, india, maps, transportation, vehicle</summary>
	/// <value>electric_rickshaw</value>
	ElectricRickshaw = 60190,

	/// <summary>automobile, bike, car, cars, maps, scooter, transportation, vehicle, vespa</summary>
	/// <value>electric_scooter</value>
	ElectricScooter = 60191,

	/// <summary>charge, cord, electric, electrical, plug, power, services, wire</summary>
	/// <value>electrical_services</value>
	ElectricalServices = 61698,

	/// <summary>body, down, elevator, human, people, person, up</summary>
	/// <value>elevator</value>
	Elevator = 61856,

	/// <summary>email, envelop, letter, mail, message, send</summary>
	/// <value>email</value>
	Email = 57534,

	/// <summary></summary>
	/// <value>emergency</value>
	Emergency = 57835,

	/// <summary>emoji, emotions, expressions, face, feelings, glad, happiness, happy, like, mood, person, pleased, smile, smiling, social, survey</summary>
	/// <value>emoji_emotions</value>
	EmojiEmotions = 59938,

	/// <summary>achievement, award, chalice, champion, cup, emoji, events, first, prize, reward, sport, trophy, winner</summary>
	/// <value>emoji_events</value>
	EmojiEvents = 59939,

	/// <summary>beverage, coffee, cup, drink, emoji, mug, plate, set, tea</summary>
	/// <value>emoji_food_beverage</value>
	EmojiFoodBeverage = 59931,

	/// <summary>animal, bee, bug, daisy, emoji, flower, insect, ladybug, nature, petals, spring, summer</summary>
	/// <value>emoji_nature</value>
	EmojiNature = 59932,

	/// <summary>bulb, creative, emoji, idea, light, objects, solution, thinking</summary>
	/// <value>emoji_objects</value>
	EmojiObjects = 59940,

	/// <summary>arm, body, emoji, greeting, human, people, person, social, waving</summary>
	/// <value>emoji_people</value>
	EmojiPeople = 59933,

	/// <summary>ampersand, character, emoji, hieroglyph, music, note, percent, sign, symbols</summary>
	/// <value>emoji_symbols</value>
	EmojiSymbols = 59934,

	/// <summary>architecture, automobile, building, car, cars, direction, emoji, estate, maps, place, public, real, residence, residential, shelter, transportation, travel, vehicle</summary>
	/// <value>emoji_transportation</value>
	EmojiTransportation = 59935,

	/// <summary>body, cogs, cogwheel, construction, engineering, fixing, gears, hat, helmet, human, maintenance, people, person, setting, worker</summary>
	/// <value>engineering</value>
	Engineering = 59965,

	/// <summary>+, add, encryption, enhanced, lock, locked, new, password, plus, privacy, private, protection, safety, secure, security, symbol</summary>
	/// <value>enhanced_encryption</value>
	EnhancedEncryption = 58943,

	/// <summary>adjustment, analytics, chart, data, equalizer, graph, measure, metrics, music, noise, sound, static, statistics, tracking, volume</summary>
	/// <value>equalizer</value>
	Equalizer = 57373,

	/// <summary>!, alert, attention, caution, circle, danger, error, exclamation, important, mark, notification, symbol, warning</summary>
	/// <value>error</value>
	Error = 57344,

	/// <summary>!, alert, attention, caution, circle, danger, error, exclamation, important, mark, notification, outline, symbol, warning</summary>
	/// <value>error_outline</value>
	ErrorOutline = 57345,

	/// <summary>down, escalator, staircase, up</summary>
	/// <value>escalator</value>
	Escalator = 61857,

	/// <summary>body, child, escalator, human, kid, parent, people, person, warning</summary>
	/// <value>escalator_warning</value>
	EscalatorWarning = 61868,

	/// <summary>bill, card, cash, coin, commerce, cost, credit, currency, dollars, euro, euros, finance, money, online, pay, payment, price, shopping, symbol</summary>
	/// <value>euro</value>
	Euro = 59925,

	/// <summary>bill, card, cash, coin, commerce, cost, credit, currency, dollars, euro, finance, money, online, pay, payment, symbol</summary>
	/// <value>euro_symbol</value>
	EuroSymbol = 59686,

	/// <summary>automobile, car, cars, charging, electric, electricity, ev, maps, places, station, transportation, vehicle</summary>
	/// <value>ev_station</value>
	EvStation = 58733,

	/// <summary>calendar, date, day, event, mark, month, range, remember, reminder, today, week</summary>
	/// <value>event</value>
	Event = 59512,

	/// <summary>approve, available, calendar, check, complete, date, done, event, mark, ok, schedule, select, tick, time, validate, verified, yes</summary>
	/// <value>event_available</value>
	EventAvailable = 58900,

	/// <summary>busy, calendar, cancel, close, date, event, exit, no, remove, schedule, stop, time, unavailable, x</summary>
	/// <value>event_busy</value>
	EventBusy = 58901,

	/// <summary>calendar, date, event, note, schedule, text, time, writing</summary>
	/// <value>event_note</value>
	EventNote = 58902,

	/// <summary></summary>
	/// <value>event_repeat</value>
	EventRepeat = 60283,

	/// <summary>assign, assigned, chair, event, furniture, reservation, row, seat, section, sit</summary>
	/// <value>event_seat</value>
	EventSeat = 59651,

	/// <summary>app, application, arrow, components, design, exit, export, interface, layout, leave, mobile, monitor, move, phone, screen, site, tablet, to, ui, ux, web, website, window</summary>
	/// <value>exit_to_app</value>
	ExitToApp = 59513,

	/// <summary>arrow, arrows, compress, enlarge, expand, grow, move, push, together</summary>
	/// <value>expand</value>
	Expand = 59727,

	/// <summary></summary>
	/// <value>expand_circle_down</value>
	ExpandCircleDown = 59341,

	/// <summary>arrow, arrows, chevron, collapse, direction, expand, expandable, less, list, up</summary>
	/// <value>expand_less</value>
	ExpandLess = 58830,

	/// <summary>arrow, arrows, chevron, collapse, direction, down, expand, expandable, list, more</summary>
	/// <value>expand_more</value>
	ExpandMore = 58831,

	/// <summary>adult, alphabet, character, content, e, explicit, font, language, letter, media, movies, music, parent, rating, supervision, symbol, text, type</summary>
	/// <value>explicit</value>
	Explicit = 57374,

	/// <summary>compass, destination, direction, east, explore, location, maps, needle, north, south, travel, west</summary>
	/// <value>explore</value>
	Explore = 59514,

	/// <summary>compass, destination, direction, disabled, east, enabled, explore, location, maps, needle, north, off, on, slash, south, travel, west</summary>
	/// <value>explore_off</value>
	ExploreOff = 59816,

	/// <summary>add, brightness, contrast, edit, editing, effect, exposure, image, minus, photo, photography, picture, plus, settings, subtract</summary>
	/// <value>exposure</value>
	Exposure = 58314,

	/// <summary>1, brightness, contrast, digit, edit, editing, effect, exposure, image, neg, negative, number, photo, photography, settings, symbol</summary>
	/// <value>exposure_neg_1</value>
	ExposureNeg1 = 58315,

	/// <summary>2, brightness, contrast, digit, edit, editing, effect, exposure, image, neg, negative, number, photo, photography, settings, symbol</summary>
	/// <value>exposure_neg_2</value>
	ExposureNeg2 = 58316,

	/// <summary>1, add, brightness, contrast, digit, edit, editing, effect, exposure, image, number, photo, photography, plus, settings, symbol</summary>
	/// <value>exposure_plus_1</value>
	ExposurePlus1 = 58317,

	/// <summary>2, add, brightness, contrast, digit, edit, editing, effect, exposure, image, number, photo, photography, plus, settings, symbol</summary>
	/// <value>exposure_plus_2</value>
	ExposurePlus2 = 58318,

	/// <summary>0, brightness, contrast, digit, edit, editing, effect, exposure, image, number, photo, photography, settings, symbol, zero</summary>
	/// <value>exposure_zero</value>
	ExposureZero = 58319,

	/// <summary>app, extended, extension, game, jigsaw, plugin add, puzzle, shape</summary>
	/// <value>extension</value>
	Extension = 59515,

	/// <summary>disabled, enabled, extended, extension, jigsaw, off, on, piece, puzzle, shape, slash</summary>
	/// <value>extension_off</value>
	ExtensionOff = 58613,

	/// <summary>account, emoji, eyes, face, human, lock, log, login, logout, people, person, profile, recognition, security, social, thumbnail, unlock, user</summary>
	/// <value>face</value>
	Face = 59516,

	/// <summary>edit, editing, effect, emoji, emotion, face, faces, image, natural, photo, photography, retouch, retouching, settings, star, tag</summary>
	/// <value>face_retouching_natural</value>
	FaceRetouchingNatural = 61262,

	/// <summary>disabled, edit, editing, effect, emoji, emotion, enabled, face, faces, image, natural, off, on, photo, photography, retouch, retouching, settings, slash, tag</summary>
	/// <value>face_retouching_off</value>
	FaceRetouchingOff = 61447,

	/// <summary>approve, check, complete, done, fact, list, mark, ok, select, tick, validate, verified, yes</summary>
	/// <value>fact_check</value>
	FactCheck = 61637,

	/// <summary></summary>
	/// <value>factory</value>
	Factory = 60348,

	/// <summary>bathroom, child, children, family, father, kids, mother, parents, restroom, wc</summary>
	/// <value>family_restroom</value>
	FamilyRestroom = 61858,

	/// <summary>control, fast, ff, forward, media, music, play, speed, time, tv, video</summary>
	/// <value>fast_forward</value>
	FastForward = 57375,

	/// <summary>back, control, fast, media, music, play, rewind, speed, time, tv, video</summary>
	/// <value>fast_rewind</value>
	FastRewind = 57376,

	/// <summary>drink, fastfood, food, hamburger, maps, meal, places</summary>
	/// <value>fastfood</value>
	Fastfood = 58746,

	/// <summary>appreciate, favorite, heart, like, love, remember, save, shape</summary>
	/// <value>favorite</value>
	Favorite = 59517,

	/// <summary>border, favorite, heart, like, love, outline, remember, save, shape</summary>
	/// <value>favorite_border</value>
	FavoriteBorder = 59518,

	/// <summary></summary>
	/// <value>fax</value>
	Fax = 60120,

	/// <summary>collection, featured, highlighted, list, music, play, playlist, recommended</summary>
	/// <value>featured_play_list</value>
	FeaturedPlayList = 57453,

	/// <summary>advertised, advertisment, featured, highlighted, recommended, video, watch</summary>
	/// <value>featured_video</value>
	FeaturedVideo = 57454,

	/// <summary>article, feed, headline, information, news, newspaper, paper, public, social, timeline</summary>
	/// <value>feed</value>
	Feed = 61449,

	/// <summary>!, alert, announcement, attention, bubble, caution, chat, comment, communicate, danger, error, exclamation, feedback, important, mark, message, notification, speech, symbol, warning</summary>
	/// <value>feedback</value>
	Feedback = 59519,

	/// <summary>female, gender, girl, lady, social, symbol, woman, women</summary>
	/// <value>female</value>
	Female = 58768,

	/// <summary>backyard, barrier, boundaries, boundary, fence, home, house, protection, yard</summary>
	/// <value>fence</value>
	Fence = 61942,

	/// <summary>circus, event, festival, local, maps, places, tent, tour, travel</summary>
	/// <value>festival</value>
	Festival = 60008,

	/// <summary>alphabet, character, digital, dvr, electronics, fiber, font, letter, network, record, recorder, symbol, text, tv, type, video</summary>
	/// <value>fiber_dvr</value>
	FiberDvr = 57437,

	/// <summary>circle, dot, fiber, manual, play, record, watch</summary>
	/// <value>fiber_manual_record</value>
	FiberManualRecord = 57441,

	/// <summary>alphabet, character, fiber, font, letter, network, new, symbol, text, type</summary>
	/// <value>fiber_new</value>
	FiberNew = 57438,

	/// <summary>alphabet, character, fiber, font, letter, network, pin, symbol, text, type</summary>
	/// <value>fiber_pin</value>
	FiberPin = 57450,

	/// <summary>circle, dot, fiber, play, record, smart, watch</summary>
	/// <value>fiber_smart_record</value>
	FiberSmartRecord = 57442,

	/// <summary>content, copy, cut, doc, document, duplicate, file, multiple, past</summary>
	/// <value>file_copy</value>
	FileCopy = 57715,

	/// <summary>arrow, arrows, down, download, downloads, drive, export, file, install, upload</summary>
	/// <value>file_download</value>
	FileDownload = 58052,

	/// <summary>arrow, arrows, check, done, down, download, downloads, drive, file, install, installed, tick, upload</summary>
	/// <value>file_download_done</value>
	FileDownloadDone = 59818,

	/// <summary>arrow, disabled, down, download, drive, enabled, export, file, install, off, on, save, slash, upload</summary>
	/// <value>file_download_off</value>
	FileDownloadOff = 58622,

	/// <summary></summary>
	/// <value>file_open</value>
	FileOpen = 60147,

	/// <summary>clip, data, doc, document, drive, file, folder, folders, note, paper, present, reminder, sheet, slide, storage, writing</summary>
	/// <value>file_present</value>
	FilePresent = 59918,

	/// <summary>arrow, arrows, download, drive, export, file, up, upload</summary>
	/// <value>file_upload</value>
	FileUpload = 58054,

	/// <summary>edit, editing, effect, filter, image, landscape, mountain, mountains, photo, photography, picture, settings</summary>
	/// <value>filter</value>
	Filter = 58323,

	/// <summary>1, digit, edit, editing, effect, filter, image, images, multiple, number, photography, picture, pictures, settings, stack, symbol</summary>
	/// <value>filter_1</value>
	Filter1 = 58320,

	/// <summary>2, digit, edit, editing, effect, filter, image, images, multiple, number, photography, picture, pictures, settings, stack, symbol</summary>
	/// <value>filter_2</value>
	Filter2 = 58321,

	/// <summary>3, digit, edit, editing, effect, filter, image, images, multiple, number, photography, picture, pictures, settings, stack, symbol</summary>
	/// <value>filter_3</value>
	Filter3 = 58322,

	/// <summary>4, digit, edit, editing, effect, filter, image, images, multiple, number, photography, picture, pictures, settings, stack, symbol</summary>
	/// <value>filter_4</value>
	Filter4 = 58324,

	/// <summary>5, digit, edit, editing, effect, filter, image, images, multiple, number, photography, picture, pictures, settings, stack, symbol</summary>
	/// <value>filter_5</value>
	Filter5 = 58325,

	/// <summary>6, digit, edit, editing, effect, filter, image, images, multiple, number, photography, picture, pictures, settings, stack, symbol</summary>
	/// <value>filter_6</value>
	Filter6 = 58326,

	/// <summary>7, digit, edit, editing, effect, filter, image, images, multiple, number, photography, picture, pictures, settings, stack, symbol</summary>
	/// <value>filter_7</value>
	Filter7 = 58327,

	/// <summary>8, digit, edit, editing, effect, filter, image, images, multiple, number, photography, picture, pictures, settings, stack, symbol</summary>
	/// <value>filter_8</value>
	Filter8 = 58328,

	/// <summary>9, digit, edit, editing, effect, filter, image, images, multiple, number, photography, picture, pictures, settings, stack, symbol</summary>
	/// <value>filter_9</value>
	Filter9 = 58329,

	/// <summary>+, 9, digit, edit, editing, effect, filter, image, images, multiple, number, photography, picture, pictures, plus, settings, stack, symbol</summary>
	/// <value>filter_9_plus</value>
	Filter9Plus = 58330,

	/// <summary>alt, edit, filter, funnel, options, refine, sift</summary>
	/// <value>filter_alt</value>
	FilterAlt = 61263,

	/// <summary></summary>
	/// <value>filter_alt_off</value>
	FilterAltOff = 60210,

	/// <summary>and, b, black, contrast, edit, editing, effect, filter, grayscale, image, images, photography, picture, pictures, settings, w, white</summary>
	/// <value>filter_b_and_w</value>
	FilterBAndW = 58331,

	/// <summary>camera, center, dot, edit, filter, focus, image, photo, photography, picture</summary>
	/// <value>filter_center_focus</value>
	FilterCenterFocus = 58332,

	/// <summary>cloud, drama, edit, editing, effect, filter, image, photo, photography, picture, sky camera</summary>
	/// <value>filter_drama</value>
	FilterDrama = 58333,

	/// <summary>boarders, border, camera, center, edit, editing, effect, filter, filters, focus, frame, frames, image, options, photo, photography, picture</summary>
	/// <value>filter_frames</value>
	FilterFrames = 58334,

	/// <summary>camera, edit, editing, effect, filter, hdr, image, mountain, mountains, photo, photography, picture</summary>
	/// <value>filter_hdr</value>
	FilterHdr = 58335,

	/// <summary>filter, lines, list, organize, sort</summary>
	/// <value>filter_list</value>
	FilterList = 57682,

	/// <summary></summary>
	/// <value>filter_list_off</value>
	FilterListOff = 60247,

	/// <summary>filter, multiple, none, stack</summary>
	/// <value>filter_none</value>
	FilterNone = 58336,

	/// <summary>blur, center, edit, editing, effect, filter, focus, image, images, photography, picture, pictures, shift, tilt</summary>
	/// <value>filter_tilt_shift</value>
	FilterTiltShift = 58338,

	/// <summary>edit, editing, effect, filter, flower, image, images, photography, picture, pictures, vintage</summary>
	/// <value>filter_vintage</value>
	FilterVintage = 58339,

	/// <summary>data, doc, document, drive, file, find, folder, folders, glass, in, look, magnify, magnifying, page, paper, search, see, sheet, slide, writing</summary>
	/// <value>find_in_page</value>
	FindInPage = 59520,

	/// <summary>around, arrows, find, glass, inprogress, load, loading refresh, look, magnify, magnifying, renew, replace, rotate, search, see</summary>
	/// <value>find_replace</value>
	FindReplace = 59521,

	/// <summary>finger, fingerprint, id, identification, identity, print, reader, thumbprint, verification</summary>
	/// <value>fingerprint</value>
	Fingerprint = 59661,

	/// <summary>emergency, extinguisher, fire, water</summary>
	/// <value>fire_extinguisher</value>
	FireExtinguisher = 61912,

	/// <summary>chimney, fire, fireplace, flame, home, house, living, pit, place, room, warm, winter</summary>
	/// <value>fireplace</value>
	Fireplace = 59971,

	/// <summary>arrow, back, chevron, first, left, page, rewind</summary>
	/// <value>first_page</value>
	FirstPage = 58844,

	/// <summary>enlarge, fit, format, layout, reduce, scale, screen, size</summary>
	/// <value>fit_screen</value>
	FitScreen = 59920,

	/// <summary></summary>
	/// <value>fitbit</value>
	Fitbit = 59435,

	/// <summary>athlete, center, dumbbell, exercise, fitness, gym, hobby, places, sport, weights, workout</summary>
	/// <value>fitness_center</value>
	FitnessCenter = 60227,

	/// <summary>country, flag, goal, mark, nation, report, start</summary>
	/// <value>flag</value>
	Flag = 57683,

	/// <summary></summary>
	/// <value>flag_circle</value>
	FlagCircle = 60152,

	/// <summary>approve, check, close, complete, contrast, done, exit, flaky, mark, no, ok, options, select, stop, tick, verified, x, yes</summary>
	/// <value>flaky</value>
	Flaky = 61264,

	/// <summary>bright, edit, editing, effect, flare, image, images, light, photography, picture, pictures, sparkle, sun</summary>
	/// <value>flare</value>
	Flare = 58340,

	/// <summary>a, auto, bolt, camera, electric, fast, flash, lightning, thunderbolt</summary>
	/// <value>flash_auto</value>
	FlashAuto = 58341,

	/// <summary>bolt, camera, disabled, electric, enabled, fast, flash, lightning, off, on, slash, thunderbolt</summary>
	/// <value>flash_off</value>
	FlashOff = 58342,

	/// <summary>bolt, camera, disabled, electric, enabled, fast, flash, lightning, off, on, slash, thunderbolt</summary>
	/// <value>flash_on</value>
	FlashOn = 58343,

	/// <summary>disabled, enabled, flash, flashlight, light, off, on, slash</summary>
	/// <value>flashlight_off</value>
	FlashlightOff = 61450,

	/// <summary>disabled, enabled, flash, flashlight, light, off, on, slash</summary>
	/// <value>flashlight_on</value>
	FlashlightOn = 61451,

	/// <summary>cafe, cafeteria, cutlery, diner, dining, eat, eating, fork, room, spoon</summary>
	/// <value>flatware</value>
	Flatware = 61452,

	/// <summary>air, airplane, airport, flight, plane, transportation, travel, trip</summary>
	/// <value>flight</value>
	Flight = 58681,

	/// <summary></summary>
	/// <value>flight_class</value>
	FlightClass = 59339,

	/// <summary>airport, arrival, arriving, flight, fly, land, landing, plane, transportation, travel</summary>
	/// <value>flight_land</value>
	FlightLand = 59652,

	/// <summary>airport, departed, departing, flight, fly, landing, plane, takeoff, transportation, travel</summary>
	/// <value>flight_takeoff</value>
	FlightTakeoff = 59653,

	/// <summary>edit, editing, flip, image, orientation, scan scanning</summary>
	/// <value>flip</value>
	Flip = 58344,

	/// <summary>android, camera, center, edit, editing, flip, image, mobile, orientation, rotate, turn</summary>
	/// <value>flip_camera_android</value>
	FlipCameraAndroid = 59959,

	/// <summary>android, camera, edit, editing, flip, image, ios, mobile, orientation, rotate, turn</summary>
	/// <value>flip_camera_ios</value>
	FlipCameraIos = 59960,

	/// <summary>arrange, arrangement, back, flip, format, front, layout, move, order, sort, to</summary>
	/// <value>flip_to_back</value>
	FlipToBack = 59522,

	/// <summary>arrange, arrangement, back, flip, format, front, layout, move, order, sort, to</summary>
	/// <value>flip_to_front</value>
	FlipToFront = 59523,

	/// <summary>bright, flourescent, lamp, light, lightbulb</summary>
	/// <value>flourescent</value>
	Flourescent = 61453,

	/// <summary>bird, dash, flutter</summary>
	/// <value>flutter_dash</value>
	FlutterDash = 57355,

	/// <summary>!, alert, attention, bad, caution, danger, destination, direction, error, exclamation, fmd, important, location, maps, mark, notification, pin, place, symbol, warning</summary>
	/// <value>fmd_bad</value>
	FmdBad = 61454,

	/// <summary>destination, direction, fmd, good, location, maps, pin, place, stop</summary>
	/// <value>fmd_good</value>
	FmdGood = 61455,

	/// <summary>data, doc, document, drive, file, folder, folders, sheet, slide, storage</summary>
	/// <value>folder</value>
	Folder = 58055,

	/// <summary></summary>
	/// <value>folder_copy</value>
	FolderCopy = 60349,

	/// <summary></summary>
	/// <value>folder_delete</value>
	FolderDelete = 60212,

	/// <summary></summary>
	/// <value>folder_off</value>
	FolderOff = 60291,

	/// <summary>data, doc, document, drive, file, folder, folders, open, sheet, slide, storage</summary>
	/// <value>folder_open</value>
	FolderOpen = 58056,

	/// <summary>account, collaboration, data, doc, document, drive, face, file, folder, human, people, person, profile, share, shared, sheet, slide, storage, team, user</summary>
	/// <value>folder_shared</value>
	FolderShared = 58057,

	/// <summary>bookmark, data, doc, document, drive, favorite, file, folder, highlight, important, marked, save, saved, shape, sheet, slide, special, star, storage</summary>
	/// <value>folder_special</value>
	FolderSpecial = 58903,

	/// <summary></summary>
	/// <value>folder_zip</value>
	FolderZip = 60204,

	/// <summary>arrow, body, directional, follow, human, people, person, right, signs, social, the</summary>
	/// <value>follow_the_signs</value>
	FollowTheSigns = 61986,

	/// <summary>A, alphabet, character, download, font, letter, square, symbol, text, type</summary>
	/// <value>font_download</value>
	FontDownload = 57703,

	/// <summary>alphabet, character, disabled, download, enabled, font, letter, off, on, slash, square, symbol, text, type</summary>
	/// <value>font_download_off</value>
	FontDownloadOff = 58617,

	/// <summary>architecture, bank, building, charity, eat, estate, food, fork, house, knife, meal, place, real, residence, residential, shelter, utensils</summary>
	/// <value>food_bank</value>
	FoodBank = 61938,

	/// <summary></summary>
	/// <value>forest</value>
	Forest = 60057,

	/// <summary></summary>
	/// <value>fork_left</value>
	ForkLeft = 60320,

	/// <summary></summary>
	/// <value>fork_right</value>
	ForkRight = 60332,

	/// <summary>align, alignment, center, doc, edit, editing, editor, format, sheet, spreadsheet, text, type, writing</summary>
	/// <value>format_align_center</value>
	FormatAlignCenter = 57908,

	/// <summary>align, alignment, doc, edit, editing, editor, format, justify, sheet, spreadsheet, text, type, writing</summary>
	/// <value>format_align_justify</value>
	FormatAlignJustify = 57909,

	/// <summary>align, alignment, doc, edit, editing, editor, format, left, sheet, spreadsheet, text, type, writing</summary>
	/// <value>format_align_left</value>
	FormatAlignLeft = 57910,

	/// <summary>align, alignment, doc, edit, editing, editor, format, right, sheet, spreadsheet, text, type, writing</summary>
	/// <value>format_align_right</value>
	FormatAlignRight = 57911,

	/// <summary>B, alphabet, bold, character, doc, edit, editing, editor, font, format, letter, sheet, spreadsheet, styles, symbol, text, type, writing</summary>
	/// <value>format_bold</value>
	FormatBold = 57912,

	/// <summary>T, alphabet, character, clear, disabled, doc, edit, editing, editor, enabled, font, format, letter, off, on, sheet, slash, spreadsheet, style, symbol, text, type, writing</summary>
	/// <value>format_clear</value>
	FormatClear = 57913,

	/// <summary>bucket, color, doc, edit, editing, editor, fill, format, paint, sheet, spreadsheet, style, text, type, writing</summary>
	/// <value>format_color_fill</value>
	FormatColorFill = 57914,

	/// <summary>clear, color, disabled, doc, droplet, edit, editing, editor, enabled, fill, format, off, on, paint, reset, sheet, slash, spreadsheet, style, text, type, water, writing</summary>
	/// <value>format_color_reset</value>
	FormatColorReset = 57915,

	/// <summary>color, doc, edit, editing, editor, fill, format, paint, sheet, spreadsheet, style, text, type, writing</summary>
	/// <value>format_color_text</value>
	FormatColorText = 57916,

	/// <summary>align, alignment, decrease, doc, edit, editing, editor, format, indent, indentation, paragraph, sheet, spreadsheet, text, type, writing</summary>
	/// <value>format_indent_decrease</value>
	FormatIndentDecrease = 57917,

	/// <summary>align, alignment, doc, edit, editing, editor, format, increase, indent, indentation, paragraph, sheet, spreadsheet, text, type, writing</summary>
	/// <value>format_indent_increase</value>
	FormatIndentIncrease = 57918,

	/// <summary>alphabet, character, doc, edit, editing, editor, font, format, italic, letter, sheet, spreadsheet, style, symbol, text, type, writing</summary>
	/// <value>format_italic</value>
	FormatItalic = 57919,

	/// <summary>align, alignment, doc, edit, editing, editor, format, line, sheet, spacing, spreadsheet, text, type, writing</summary>
	/// <value>format_line_spacing</value>
	FormatLineSpacing = 57920,

	/// <summary>align, alignment, bulleted, doc, edit, editing, editor, format, list, notes, sheet, spreadsheet, text, type, writing</summary>
	/// <value>format_list_bulleted</value>
	FormatListBulleted = 57921,

	/// <summary>align, alignment, digit, doc, edit, editing, editor, format, list, notes, number, numbered, sheet, spreadsheet, symbol, text, type, writing</summary>
	/// <value>format_list_numbered</value>
	FormatListNumbered = 57922,

	/// <summary>align, alignment, digit, doc, edit, editing, editor, format, list, notes, number, numbered, rtl, sheet, spreadsheet, symbol, text, type, writing</summary>
	/// <value>format_list_numbered_rtl</value>
	FormatListNumberedRtl = 57959,

	/// <summary></summary>
	/// <value>format_overline</value>
	FormatOverline = 60261,

	/// <summary>brush, color, doc, edit, editing, editor, fill, format, paint, roller, sheet, spreadsheet, style, text, type, writing</summary>
	/// <value>format_paint</value>
	FormatPaint = 57923,

	/// <summary>doc, edit, editing, editor, format, quotation, quote, sheet, spreadsheet, text, type, writing</summary>
	/// <value>format_quote</value>
	FormatQuote = 57924,

	/// <summary>alphabet, character, color, doc, edit, editing, editor, fill, font, format, letter, paint, shapes, sheet, spreadsheet, style, symbol, text, type, writing</summary>
	/// <value>format_shapes</value>
	FormatShapes = 57950,

	/// <summary>alphabet, character, color, doc, edit, editing, editor, fill, font, format, letter, paint, sheet, size, spreadsheet, style, symbol, text, type, writing</summary>
	/// <value>format_size</value>
	FormatSize = 57925,

	/// <summary>alphabet, character, doc, edit, editing, editor, font, format, letter, sheet, spreadsheet, strikethrough, style, symbol, text, type, writing</summary>
	/// <value>format_strikethrough</value>
	FormatStrikethrough = 57926,

	/// <summary>align, alignment, doc, edit, editing, editor, format, ltr, sheet, spreadsheet, text, textdirection, type, writing</summary>
	/// <value>format_textdirection_l_to_r</value>
	FormatTextdirectionLToR = 57927,

	/// <summary>align, alignment, doc, edit, editing, editor, format, rtl, sheet, spreadsheet, text, textdirection, type, writing</summary>
	/// <value>format_textdirection_r_to_l</value>
	FormatTextdirectionRToL = 57928,

	/// <summary>alphabet, character, doc, edit, editing, editor, font, format, letter, line, sheet, spreadsheet, style, symbol, text, type, under, underlined, writing</summary>
	/// <value>format_underlined</value>
	FormatUnderlined = 57929,

	/// <summary></summary>
	/// <value>fort</value>
	Fort = 60077,

	/// <summary>bubble, chat, comment, communicate, community, conversation, feedback, forum, hub, message, speech</summary>
	/// <value>forum</value>
	Forum = 57535,

	/// <summary>arrow, forward, mail, message, playback, right, sent</summary>
	/// <value>forward</value>
	Forward = 57684,

	/// <summary>10, arrow, control, controls, digit, fast, forward, music, number, play, seconds, symbol, video</summary>
	/// <value>forward_10</value>
	Forward10 = 57430,

	/// <summary>30, arrow, control, controls, digit, fast, forward, music, number, seconds, symbol, video</summary>
	/// <value>forward_30</value>
	Forward30 = 57431,

	/// <summary>10, 5, arrow, control, controls, digit, fast, forward, music, number, seconds, symbol, video</summary>
	/// <value>forward_5</value>
	Forward5 = 57432,

	/// <summary>arrow, email, envelop, forward, inbox, letter, mail, message, send, to</summary>
	/// <value>forward_to_inbox</value>
	ForwardToInbox = 61831,

	/// <summary>architecture, base, basis, building, construction, estate, foundation, home, house, real, residential</summary>
	/// <value>foundation</value>
	Foundation = 61952,

	/// <summary>beverage, breakfast, cafe, coffee, cup, drink, free, mug, tea</summary>
	/// <value>free_breakfast</value>
	FreeBreakfast = 60228,

	/// <summary></summary>
	/// <value>free_cancellation</value>
	FreeCancellation = 59208,

	/// <summary></summary>
	/// <value>front_hand</value>
	FrontHand = 59241,

	/// <summary>adjust, app, application, components, full, fullscreen, interface, screen, site, size, ui, ux, view, web, website</summary>
	/// <value>fullscreen</value>
	Fullscreen = 58832,

	/// <summary>adjust, app, application, components, exit, full, fullscreen, interface, screen, site, size, ui, ux, view, web, website</summary>
	/// <value>fullscreen_exit</value>
	FullscreenExit = 58833,

	/// <summary>average, calculate, count, doc, edit, editing, editor, functions, math, sheet, spreadsheet, style, sum, text, type, writing</summary>
	/// <value>functions</value>
	Functions = 57930,

	/// <summary>alphabet, character, data, font, g, letter, mobile, network, service, symbol, text, type</summary>
	/// <value>g_mobiledata</value>
	GMobiledata = 61456,

	/// <summary>emblem, g, google, language, logo, mark, speaking, speech, translate, translator, words</summary>
	/// <value>g_translate</value>
	GTranslate = 59687,

	/// <summary>buttons, console, controller, device, game, gamepad, gaming, playstation, video</summary>
	/// <value>gamepad</value>
	Gamepad = 58127,

	/// <summary>adjust, arrow, arrows, control, controller, direction, games, gaming, left, move, right</summary>
	/// <value>games</value>
	Games = 57377,

	/// <summary>automobile, automotive, car, cars, direction, garage, maps, transportation, travel, vehicle</summary>
	/// <value>garage</value>
	Garage = 61457,

	/// <summary>agreement, contract, court, document, gavel, government, judge, law, mallet, official, police, rule, rules, terms</summary>
	/// <value>gavel</value>
	Gavel = 59662,

	/// <summary></summary>
	/// <value>generating_tokens</value>
	GeneratingTokens = 59209,

	/// <summary>drawing, finger, gesture, gestures, hand, motion</summary>
	/// <value>gesture</value>
	Gesture = 57685,

	/// <summary>app, arrow, arrows, down, download, downloads, export, get, install, play, upload</summary>
	/// <value>get_app</value>
	GetApp = 59524,

	/// <summary>alphabet, animated, animation, bitmap, character, font, format, gif, graphics, interchange, letter, symbol, text, type</summary>
	/// <value>gif</value>
	Gif = 59656,

	/// <summary></summary>
	/// <value>gif_box</value>
	GifBox = 59299,

	/// <summary></summary>
	/// <value>girl</value>
	Girl = 60264,

	/// <summary>architecture, estate, gite, home, hostel, house, maps, place, real, residence, residential, stay, traveling</summary>
	/// <value>gite</value>
	Gite = 58763,

	/// <summary>athlete, athletic, ball, club, course, entertainment, flag, golf, golfer, golfing, hobby, hole, places, putt, sports</summary>
	/// <value>golf_course</value>
	GolfCourse = 60229,

	/// <summary>bad, cancel, certified, close, error, exit, gpp, no, privacy, private, protect, protection, remove, security, shield, sim, stop, verified, x</summary>
	/// <value>gpp_bad</value>
	GppBad = 61458,

	/// <summary>certified, check, good, gpp, ok, pass, security, shield, sim, tick</summary>
	/// <value>gpp_good</value>
	GppGood = 61459,

	/// <summary>!, alert, attention, caution, certified, danger, error, exclamation, gpp, important, mark, maybe, notification, privacy, private, protect, protection, security, shield, sim, symbol, verified, warning</summary>
	/// <value>gpp_maybe</value>
	GppMaybe = 61460,

	/// <summary>destination, direction, fixed, gps, location, maps, pin, place, pointer, stop, tracking</summary>
	/// <value>gps_fixed</value>
	GpsFixed = 57779,

	/// <summary>destination, direction, disabled, enabled, gps, location, maps, not fixed, off, on, online, place, pointer, slash, tracking</summary>
	/// <value>gps_not_fixed</value>
	GpsNotFixed = 57780,

	/// <summary>destination, direction, disabled, enabled, gps, location, maps, not fixed, off, offline, on, place, pointer, slash, tracking</summary>
	/// <value>gps_off</value>
	GpsOff = 57781,

	/// <summary>achievement, grade, important, marked, rate, reward, saved, shape, special, star</summary>
	/// <value>grade</value>
	Grade = 59525,

	/// <summary>color, edit, editing, effect, filter, gradient, image, images, photography, picture, pictures</summary>
	/// <value>gradient</value>
	Gradient = 58345,

	/// <summary>approve, check, complete, document, done, feedback, grade, grading, mark, ok, review, reviewed, select, tick, validate, verified, writing, yes</summary>
	/// <value>grading</value>
	Grading = 59983,

	/// <summary>dots, edit, editing, effect, filter, grain, image, images, photography, picture, pictures</summary>
	/// <value>grain</value>
	Grain = 58346,

	/// <summary>audio, eq, equalizer, graphic, music, recording, sound, voice</summary>
	/// <value>graphic_eq</value>
	GraphicEq = 57784,

	/// <summary>backyard, fodder, grass, ground, home, lawn, plant, turf, yard</summary>
	/// <value>grass</value>
	Grass = 61957,

	/// <summary>3, grid, layout, line, space</summary>
	/// <value>grid_3x3</value>
	Grid3x3 = 61461,

	/// <summary>4, by, grid, layout, lines, space</summary>
	/// <value>grid_4x4</value>
	Grid4x4 = 61462,

	/// <summary>golden, goldenratio, grid, layout, lines, ratio, space</summary>
	/// <value>grid_goldenratio</value>
	GridGoldenratio = 61463,

	/// <summary>collage, disabled, enabled, grid, image, layout, off, on, slash, view</summary>
	/// <value>grid_off</value>
	GridOff = 58347,

	/// <summary>collage, disabled, enabled, grid, image, layout, off, on, slash, view</summary>
	/// <value>grid_on</value>
	GridOn = 58348,

	/// <summary>app, application square, blocks, components, dashboard, design, grid, interface, layout, screen, site, tiles, ui, ux, view, web, website, window</summary>
	/// <value>grid_view</value>
	GridView = 59824,

	/// <summary>accounts, committee, face, family, friends, group, humans, network, people, persons, profiles, social, team, users</summary>
	/// <value>group</value>
	Group = 59375,

	/// <summary>accounts, add, committee, face, family, friends, group, humans, increase, more, network, people, persons, plus, profiles, social, team, users</summary>
	/// <value>group_add</value>
	GroupAdd = 59376,

	/// <summary></summary>
	/// <value>group_off</value>
	GroupOff = 59207,

	/// <summary></summary>
	/// <value>group_remove</value>
	GroupRemove = 59309,

	/// <summary>alliance, collaboration, group, partnership, team, teamwork, together, work</summary>
	/// <value>group_work</value>
	GroupWork = 59526,

	/// <summary>body, club, collaboration, crowd, gathering, groups, human, meeting, people, person, social, teams</summary>
	/// <value>groups</value>
	Groups = 62003,

	/// <summary>alphabet, character, data, font, h, letter, mobile, network, service, symbol, text, type</summary>
	/// <value>h_mobiledata</value>
	HMobiledata = 61464,

	/// <summary>+, alphabet, character, data, font, h, letter, mobile, network, plus, service, symbol, text, type</summary>
	/// <value>h_plus_mobiledata</value>
	HPlusMobiledata = 61465,

	/// <summary>body, hail, human, people, person, pick, public, stop, taxi, transportation</summary>
	/// <value>hail</value>
	Hail = 59825,

	/// <summary></summary>
	/// <value>handshake</value>
	Handshake = 60363,

	/// <summary>build, construction, fix, hammer, handyman, repair, screw, screwdriver, tools</summary>
	/// <value>handyman</value>
	Handyman = 61707,

	/// <summary>break, construction, hammer, hardware, nail, repair, tool</summary>
	/// <value>hardware</value>
	Hardware = 59993,

	/// <summary>alphabet, character, definition, display, font, hd, high, letter, movie, movies, quality, resolution, screen, symbol, text, tv, type, video</summary>
	/// <value>hd</value>
	Hd = 57426,

	/// <summary>A, alphabet, auto, camera, character, circle, dynamic, font, hdr, high, letter, photo, range, symbol, text, type</summary>
	/// <value>hdr_auto</value>
	HdrAuto = 61466,

	/// <summary>+, A, alphabet, auto, camera, character, circle, dynamic, font, hdr, high, letter, photo, range, select, symbol, text, type</summary>
	/// <value>hdr_auto_select</value>
	HdrAutoSelect = 61467,

	/// <summary>add, alphabet, character, dynamic, enhance, font, hdr, high, letter, plus, range, select, symbol, text, type</summary>
	/// <value>hdr_enhanced_select</value>
	HdrEnhancedSelect = 61265,

	/// <summary>alphabet, character, disabled, dynamic, enabled, enhance, font, hdr, high, letter, off, on, range, select, slash, symbol, text, type</summary>
	/// <value>hdr_off</value>
	HdrOff = 58349,

	/// <summary>alphabet, camera, character, circle, disabled, dynamic, enabled, font, hdr, high, letter, off, on, photo, range, select, slash, symbol, text, type</summary>
	/// <value>hdr_off_select</value>
	HdrOffSelect = 61468,

	/// <summary>add, alphabet, character, dynamic, enhance, font, hdr, high, letter, on, plus, range, select, symbol, text, type</summary>
	/// <value>hdr_on</value>
	HdrOn = 58350,

	/// <summary>+, alphabet, camera, character, circle, dynamic, font, hdr, high, letter, on, photo, range, select, symbol, text, type</summary>
	/// <value>hdr_on_select</value>
	HdrOnSelect = 61469,

	/// <summary>+, add, alphabet, character, circle, dynamic, enhance, font, hdr, high, letter, plus, range, select, symbol, text, type</summary>
	/// <value>hdr_plus</value>
	HdrPlus = 61470,

	/// <summary>circles, dots, dynamic, enhance, hdr, high, range, strong</summary>
	/// <value>hdr_strong</value>
	HdrStrong = 58353,

	/// <summary>circles, dots, dynamic, enhance, hdr, high, range, weak</summary>
	/// <value>hdr_weak</value>
	HdrWeak = 58354,

	/// <summary>accessory, audio, device, ear, earphone, headphones, headset, listen, music, sound</summary>
	/// <value>headphones</value>
	Headphones = 61471,

	/// <summary>accessory, audio, battery, charging, device, ear, earphone, headphones, headset, listen, music, sound</summary>
	/// <value>headphones_battery</value>
	HeadphonesBattery = 61472,

	/// <summary>accessory, audio, device, ear, earbuds, earphone, headphones, headset, listen, music, sound</summary>
	/// <value>headset</value>
	Headset = 58128,

	/// <summary>accessory, audio, chat, device, ear, earphone, headphones, headset, listen, mic, music, sound, talk</summary>
	/// <value>headset_mic</value>
	HeadsetMic = 58129,

	/// <summary>accessory, audio, chat, device, disabled, ear, earphone, enabled, headphones, headset, listen, mic, music, off, on, slash, sound, talk</summary>
	/// <value>headset_off</value>
	HeadsetOff = 58170,

	/// <summary>bandage, edit, editing, emergency, fix, healing, hospital, image, medicine</summary>
	/// <value>healing</value>
	Healing = 58355,

	/// <summary>+, add, and, certified, health, plus, privacy, private, protect, protection, safety, security, shield, symbol, verified</summary>
	/// <value>health_and_safety</value>
	HealthAndSafety = 57813,

	/// <summary>accessibility, accessible, aid, ear, handicap, hearing, help, impaired, listen, sound, volume</summary>
	/// <value>hearing</value>
	Hearing = 57379,

	/// <summary>accessibility, accessible, aid, disabled, ear, enabled, handicap, hearing, help, impaired, listen, off, on, slash, sound, volume</summary>
	/// <value>hearing_disabled</value>
	HearingDisabled = 61700,

	/// <summary></summary>
	/// <value>heart_broken</value>
	HeartBroken = 60098,

	/// <summary>arrow, color, doc, down, edit, editing, editor, fill, format, height, paint, sheet, spreadsheet, style, text, type, up, writing</summary>
	/// <value>height</value>
	Height = 59926,

	/// <summary>?, assistance, circle, help, info, information, punctuation, question mark, shape, support, symbol</summary>
	/// <value>help</value>
	Help = 59527,

	/// <summary>?, assistance, center, help, info, information, punctuation, question mark, support, symbol</summary>
	/// <value>help_center</value>
	HelpCenter = 61888,

	/// <summary>?, assistance, circle, help, info, information, outline, punctuation, question mark, shape, support, symbol</summary>
	/// <value>help_outline</value>
	HelpOutline = 59645,

	/// <summary>alphabet, character, coding, efficiency, font, hevc, high, letter, symbol, text, type, video</summary>
	/// <value>hevc</value>
	Hevc = 61473,

	/// <summary></summary>
	/// <value>hexagon</value>
	Hexagon = 60217,

	/// <summary>disabled, enabled, hide, image, landscape, mountain, mountains, off, on, photo, photography, picture, slash</summary>
	/// <value>hide_image</value>
	HideImage = 61474,

	/// <summary>circle, disabled, enabled, hide, off, offline, on, shape, slash, source</summary>
	/// <value>hide_source</value>
	HideSource = 61475,

	/// <summary>alphabet, character, definition, display, font, high, hq, letter, movie, movies, quality, resolution, screen, symbol, text, tv, type</summary>
	/// <value>high_quality</value>
	HighQuality = 57380,

	/// <summary>color, doc, edit, editing, editor, emphasize, fill, flash, format, highlight, light, paint, sheet, spreadsheet, style, text, type, writing</summary>
	/// <value>highlight</value>
	Highlight = 57951,

	/// <summary>alt, arrow, box, click, cursor, draw, focus, highlight, pointer, select, selection, target</summary>
	/// <value>highlight_alt</value>
	HighlightAlt = 61266,

	/// <summary>cancel, close, exit, highlight, no, off, quit, remove, stop, x</summary>
	/// <value>highlight_off</value>
	HighlightOff = 59528,

	/// <summary>backpacking, bag, climbing, duffle, hiking, mountain, social, sports, stick, trail, travel, walking</summary>
	/// <value>hiking</value>
	Hiking = 58634,

	/// <summary>arrow, back, backwards, clock, date, history, refresh, renew, reverse, rotate, schedule, time, turn</summary>
	/// <value>history</value>
	History = 59529,

	/// <summary>document, edu, education, feather, history, letter, paper, pen, quill, school, story, tools, write, writing</summary>
	/// <value>history_edu</value>
	HistoryEdu = 59966,

	/// <summary>clock, date, history, off, schedule, time, toggle</summary>
	/// <value>history_toggle_off</value>
	HistoryToggleOff = 61821,

	/// <summary></summary>
	/// <value>hive</value>
	Hive = 60070,

	/// <summary></summary>
	/// <value>hls</value>
	Hls = 60298,

	/// <summary></summary>
	/// <value>hls_off</value>
	HlsOff = 60300,

	/// <summary>architecture, beach, camping, cottage, estate, holiday, home, house, lake, lodge, maps, place, real, residence, residential, stay, traveling, vacation, village</summary>
	/// <value>holiday_village</value>
	HolidayVillage = 58762,

	/// <summary>address, app, application--house, architecture, building, components, design, estate, home, homepage, house, interface, layout, place, real, residence, residential, screen, shelter, site, structure, ui, unit, ux, web, website, window</summary>
	/// <value>home</value>
	Home = 59530,

	/// <summary>device, gadget, hardware, home, internet, iot, max, nest, smart, things</summary>
	/// <value>home_max</value>
	HomeMax = 61476,

	/// <summary>Internet, device, gadget, hardware, home, iot, mini, nest, smart, things</summary>
	/// <value>home_mini</value>
	HomeMini = 61477,

	/// <summary>box, equipment, fix, home, kit, mechanic, repair, repairing, service, tool, toolbox, tools, workshop</summary>
	/// <value>home_repair_service</value>
	HomeRepairService = 61696,

	/// <summary>architecture, building, estate, home, place, real, residence, residential, shelter, work</summary>
	/// <value>home_work</value>
	HomeWork = 59913,

	/// <summary>alignment, distribute, format, horizontal, layout, lines, paragraph, rule, rules, style, text</summary>
	/// <value>horizontal_distribute</value>
	HorizontalDistribute = 57364,

	/// <summary>gmail, horizontal, line, novitas, rule</summary>
	/// <value>horizontal_rule</value>
	HorizontalRule = 61704,

	/// <summary>bars, format, horizontal, layout, lines, split, stacked</summary>
	/// <value>horizontal_split</value>
	HorizontalSplit = 59719,

	/// <summary>bath, bathing, bathroom, bathtub, hot, hotel, human, jacuzzi, person, shower, spa, steam, travel, tub, water</summary>
	/// <value>hot_tub</value>
	HotTub = 60230,

	/// <summary>body, hotel, human, people, person, sleep, stay, travel, trip</summary>
	/// <value>hotel</value>
	Hotel = 58682,

	/// <summary></summary>
	/// <value>hotel_class</value>
	HotelClass = 59203,

	/// <summary>bottom, countdown, half, hourglass, loading, minute, minutes, time, wait, waiting</summary>
	/// <value>hourglass_bottom</value>
	HourglassBottom = 59996,

	/// <summary>clock, countdown, disabled, empty, enabled, hourglass, loading, minute, minutes, off, on, slash, time, wait, waiting</summary>
	/// <value>hourglass_disabled</value>
	HourglassDisabled = 61267,

	/// <summary>countdown, empty, hourglass, loading, minutes, time, wait, waiting</summary>
	/// <value>hourglass_empty</value>
	HourglassEmpty = 59531,

	/// <summary>countdown, full, hourglass, loading, minutes, time, wait, waiting</summary>
	/// <value>hourglass_full</value>
	HourglassFull = 59532,

	/// <summary>countdown, half, hourglass, loading, minute, minutes, time, top, wait, waiting</summary>
	/// <value>hourglass_top</value>
	HourglassTop = 59995,

	/// <summary>architecture, building, estate, family, home, homepage, house, place, places, real, residence, residential, shelter</summary>
	/// <value>house</value>
	House = 59972,

	/// <summary>architecture, building, construction, estate, exterior, facade, home, house, real, residential, siding</summary>
	/// <value>house_siding</value>
	HouseSiding = 61954,

	/// <summary>architecture, beach, boat, estate, floating, home, house, houseboat, maps, place, real, residence, residential, sea, stay, traveling, vacation</summary>
	/// <value>houseboat</value>
	Houseboat = 58756,

	/// <summary>approve, ballot, check, complete, done, election, how, mark, ok, poll, register, registration, select, tick, to reg, validate, verified, vote, yes</summary>
	/// <value>how_to_reg</value>
	HowToReg = 57716,

	/// <summary>ballot, election, how, poll, to, vote</summary>
	/// <value>how_to_vote</value>
	HowToVote = 57717,

	/// <summary></summary>
	/// <value>html</value>
	Html = 60286,

	/// <summary>alphabet, character, font, http, letter, symbol, text, transfer, type, url, website</summary>
	/// <value>http</value>
	Http = 59650,

	/// <summary>https, lock, locked, password, privacy, private, protection, safety, secure, security</summary>
	/// <value>https</value>
	Https = 59533,

	/// <summary></summary>
	/// <value>hub</value>
	Hub = 59892,

	/// <summary>air, conditioning, heating, hvac, ventilation</summary>
	/// <value>hvac</value>
	Hvac = 61710,

	/// <summary>athlete, athletic, entertainment, exercise, hobby, ice, shoe, skates, skating, social, sports, travel</summary>
	/// <value>ice_skating</value>
	IceSkating = 58635,

	/// <summary>cream, dessert, food, ice, icecream, snack</summary>
	/// <value>icecream</value>
	Icecream = 60009,

	/// <summary>frame, image, landscape, mountain, mountains, photo, photography, picture</summary>
	/// <value>image</value>
	Image = 58356,

	/// <summary>aspect, image, photo, photography, picture, ratio, rectangle, square</summary>
	/// <value>image_aspect_ratio</value>
	ImageAspectRatio = 58357,

	/// <summary>disabled, enabled, image, landscape, mountain, mountains, not, off, on, photo, photography, picture, slash, supported</summary>
	/// <value>image_not_supported</value>
	ImageNotSupported = 61718,

	/// <summary>find, glass, image, landscape, look, magnify, magnifying, mountain, mountains, photo, photography, picture, search, see</summary>
	/// <value>image_search</value>
	ImageSearch = 58431,

	/// <summary>art, image, imagesearch, paint, roller, search</summary>
	/// <value>imagesearch_roller</value>
	ImagesearchRoller = 59828,

	/// <summary>address, book, contacts, import, info, information, open</summary>
	/// <value>import_contacts</value>
	ImportContacts = 57568,

	/// <summary>arrow, arrows, direction, down, explort, import, up</summary>
	/// <value>import_export</value>
	ImportExport = 57539,

	/// <summary>Android, OS, desktop, devices, hardware, iOS, important, mobile, monitor, phone, star, tablet, web</summary>
	/// <value>important_devices</value>
	ImportantDevices = 59666,

	/// <summary>archive, email, inbox, incoming, mail, message</summary>
	/// <value>inbox</value>
	Inbox = 57686,

	/// <summary></summary>
	/// <value>incomplete_circle</value>
	IncompleteCircle = 59291,

	/// <summary>app, application, box, button, check, components, control, design, form, indeterminate, interface, screen, select, selected, selection, site, square, toggle, ui, undetermined, ux, web, website</summary>
	/// <value>indeterminate_check_box</value>
	IndeterminateCheckBox = 59657,

	/// <summary>alert, announcment, assistance, details, help, i, info, information, service, support</summary>
	/// <value>info</value>
	Info = 59534,

	/// <summary>arrow, box, download, input, login, move, right</summary>
	/// <value>input</value>
	Input = 59536,

	/// <summary>analytics, bar, bars, chart, data, diagram, graph, infographic, insert, measure, metrics, statistics, tracking</summary>
	/// <value>insert_chart</value>
	InsertChart = 57931,

	/// <summary>analytics, bar, bars, chart, data, diagram, graph, infographic, insert, measure, metrics, outlined, statistics, tracking</summary>
	/// <value>insert_chart_outlined</value>
	InsertChartOutlined = 57962,

	/// <summary>add, bubble, chat, comment, feedback, insert, message</summary>
	/// <value>insert_comment</value>
	InsertComment = 57932,

	/// <summary>doc, drive, file, format, insert, sheet, slide</summary>
	/// <value>insert_drive_file</value>
	InsertDriveFile = 57933,

	/// <summary>account, emoji, emoticon, face, happy, human, insert, people, person, profile, sentiment, smile, user</summary>
	/// <value>insert_emoticon</value>
	InsertEmoticon = 57934,

	/// <summary>calendar, date, day, event, insert, invitation, mark, month, range, remember, reminder, today, week</summary>
	/// <value>insert_invitation</value>
	InsertInvitation = 57935,

	/// <summary>add, attach, clip, file, insert, link, mail, media</summary>
	/// <value>insert_link</value>
	InsertLink = 57936,

	/// <summary></summary>
	/// <value>insert_page_break</value>
	InsertPageBreak = 60106,

	/// <summary>image, insert, landscape, mountain, mountains, photo, photography, picture</summary>
	/// <value>insert_photo</value>
	InsertPhoto = 57937,

	/// <summary>analytics, bar, bars, chart, data, diagram, graph, infographic, insights, measure, metrics, stars, statistics, tracking</summary>
	/// <value>insights</value>
	Insights = 61586,

	/// <summary></summary>
	/// <value>install_desktop</value>
	InstallDesktop = 60273,

	/// <summary></summary>
	/// <value>install_mobile</value>
	InstallMobile = 60274,

	/// <summary>brackets, clipboard, code, css, develop, developer, doc, document, engineer, engineering clipboard, html, instructions, integration, platform</summary>
	/// <value>integration_instructions</value>
	IntegrationInstructions = 61268,

	/// <summary></summary>
	/// <value>interests</value>
	Interests = 59336,

	/// <summary></summary>
	/// <value>interpreter_mode</value>
	InterpreterMode = 59451,

	/// <summary>buy, check, clipboard, commerce, e-commerce, inventory, list, purchase, shop, store</summary>
	/// <value>inventory</value>
	Inventory = 57721,

	/// <summary>archive, box, file, inventory, organize, packages, product, stock, storage, supply</summary>
	/// <value>inventory_2</value>
	Inventory2 = 57761,

	/// <summary>colors, drop, droplet, edit, editing, hue, invert, inverted, palette, tone, water</summary>
	/// <value>invert_colors</value>
	InvertColors = 59537,

	/// <summary>colors, disabled, drop, droplet, enabled, hue, invert, inverted, off, offline, on, opacity, palette, slash, tone, water</summary>
	/// <value>invert_colors_off</value>
	InvertColorsOff = 57540,

	/// <summary>arrow, arrows, button, direction, internet, ios, link, send, share, sharing, social, up, web, website</summary>
	/// <value>ios_share</value>
	IosShare = 59064,

	/// <summary>appliance, clothes, electric, iron, ironing, machine, object</summary>
	/// <value>iron</value>
	Iron = 58755,

	/// <summary>add, edit, editing, effect, image, iso, minus, photography, picture, plus, sensor, shutter, speed, subtract</summary>
	/// <value>iso</value>
	Iso = 58358,

	/// <summary></summary>
	/// <value>javascript</value>
	Javascript = 60284,

	/// <summary></summary>
	/// <value>join_full</value>
	JoinFull = 60139,

	/// <summary></summary>
	/// <value>join_inner</value>
	JoinInner = 60148,

	/// <summary></summary>
	/// <value>join_left</value>
	JoinLeft = 60146,

	/// <summary></summary>
	/// <value>join_right</value>
	JoinRight = 60138,

	/// <summary>athlete, athletic, body, canoe, entertainment, exercise, hobby, human, kayak, kayaking, lake, paddle, paddling, people, person, rafting, river, row, social, sports, summer, travel, water</summary>
	/// <value>kayaking</value>
	Kayaking = 58636,

	/// <summary></summary>
	/// <value>kebab_dining</value>
	KebabDining = 59458,

	/// <summary>blackout, restricted, secret, unlock</summary>
	/// <value>key</value>
	Key = 59196,

	/// <summary></summary>
	/// <value>key_off</value>
	KeyOff = 60292,

	/// <summary>computer, device, hardware, input, keyboard, keypad, letter, office, text, type</summary>
	/// <value>keyboard</value>
	Keyboard = 58130,

	/// <summary>alt, computer, device, hardware, input, keyboard, keypad, letter, office, text, type</summary>
	/// <value>keyboard_alt</value>
	KeyboardAlt = 61480,

	/// <summary>arrow, arrows, down, keyboard</summary>
	/// <value>keyboard_arrow_down</value>
	KeyboardArrowDown = 58131,

	/// <summary>arrow, arrows, keyboard, left</summary>
	/// <value>keyboard_arrow_left</value>
	KeyboardArrowLeft = 58132,

	/// <summary>arrow, arrows, keyboard, right</summary>
	/// <value>keyboard_arrow_right</value>
	KeyboardArrowRight = 58133,

	/// <summary>arrow, arrows, keyboard, up</summary>
	/// <value>keyboard_arrow_up</value>
	KeyboardArrowUp = 58134,

	/// <summary>arrow, back, backspace, keyboard, left</summary>
	/// <value>keyboard_backspace</value>
	KeyboardBackspace = 58135,

	/// <summary>arrow, capslock, keyboard, up</summary>
	/// <value>keyboard_capslock</value>
	KeyboardCapslock = 58136,

	/// <summary></summary>
	/// <value>keyboard_command_key</value>
	KeyboardCommandKey = 60135,

	/// <summary></summary>
	/// <value>keyboard_control_key</value>
	KeyboardControlKey = 60134,

	/// <summary></summary>
	/// <value>keyboard_double_arrow_down</value>
	KeyboardDoubleArrowDown = 60112,

	/// <summary></summary>
	/// <value>keyboard_double_arrow_left</value>
	KeyboardDoubleArrowLeft = 60099,

	/// <summary></summary>
	/// <value>keyboard_double_arrow_right</value>
	KeyboardDoubleArrowRight = 60105,

	/// <summary></summary>
	/// <value>keyboard_double_arrow_up</value>
	KeyboardDoubleArrowUp = 60111,

	/// <summary>arrow, computer, device, down, hardware, hide, input, keyboard, keypad, text</summary>
	/// <value>keyboard_hide</value>
	KeyboardHide = 58138,

	/// <summary></summary>
	/// <value>keyboard_option_key</value>
	KeyboardOptionKey = 60136,

	/// <summary>arrow, back, keyboard, left, return</summary>
	/// <value>keyboard_return</value>
	KeyboardReturn = 58139,

	/// <summary>arrow, keyboard, next, right, tab</summary>
	/// <value>keyboard_tab</value>
	KeyboardTab = 58140,

	/// <summary>keyboard, mic, microphone, noise, record, recorder, speaker, voice</summary>
	/// <value>keyboard_voice</value>
	KeyboardVoice = 58141,

	/// <summary>bed, bedroom, double, furniture, home, hotel, house, king, night, pillows, queen, rest, room, sleep</summary>
	/// <value>king_bed</value>
	KingBed = 59973,

	/// <summary>appliance, cold, food, fridge, home, house, ice, kitchen, places, refrigerator, storage</summary>
	/// <value>kitchen</value>
	Kitchen = 60231,

	/// <summary>athlete, athletic, beach, body, entertainment, exercise, hobby, human, kitesurfing, people, person, social, sports, surf, travel, water</summary>
	/// <value>kitesurfing</value>
	Kitesurfing = 58637,

	/// <summary>favorite, indent, label, library, mail, remember, save, stamp, sticker, tag</summary>
	/// <value>label</value>
	Label = 59538,

	/// <summary>favorite, important, indent, label, library, mail, remember, save, stamp, sticker, tag, wing</summary>
	/// <value>label_important</value>
	LabelImportant = 59703,

	/// <summary>disabled, enabled, favorite, indent, label, library, mail, off, on, remember, save, slash, stamp, sticker, tag, wing</summary>
	/// <value>label_off</value>
	LabelOff = 59830,

	/// <summary></summary>
	/// <value>lan</value>
	Lan = 60207,

	/// <summary>image, landscape, mountain, mountains, nature, photo, photography, picture</summary>
	/// <value>landscape</value>
	Landscape = 58359,

	/// <summary>globe, internet, language, planet, website, world, www</summary>
	/// <value>language</value>
	Language = 59540,

	/// <summary>Android, OS, chrome, computer, connect, desktop, device, display, hardware, iOS, laptop, link, mac, monitor, smart, tv, web, windows</summary>
	/// <value>laptop</value>
	Laptop = 58142,

	/// <summary>Android, OS, chrome, chromebook, device, display, hardware, iOS, laptop, mac chromebook, monitor, screen, web, window</summary>
	/// <value>laptop_chromebook</value>
	LaptopChromebook = 58143,

	/// <summary>Android, OS, chrome, device, display, hardware, iOS, laptop, mac, monitor, screen, web, window</summary>
	/// <value>laptop_mac</value>
	LaptopMac = 58144,

	/// <summary>Android, OS, chrome, device, display, hardware, iOS, laptop, mac, monitor, screen, web, window, windows</summary>
	/// <value>laptop_windows</value>
	LaptopWindows = 58145,

	/// <summary>app, application, arrow, chevron, components, end, forward, interface, last, page, right, screen, site, ui, ux, web, website</summary>
	/// <value>last_page</value>
	LastPage = 58845,

	/// <summary>app, application, arrow, box, components, core, interface, internal, launch, new, open, screen, site, ui, ux, web, website, window</summary>
	/// <value>launch</value>
	Launch = 59541,

	/// <summary>arrange, disabled, enabled, interaction, layers, maps, off, on, overlay, pages, slash, stack</summary>
	/// <value>layers</value>
	Layers = 58683,

	/// <summary>arrange, clear, delete, disabled, enabled, interaction, layers, maps, off, on, overlay, pages, slash</summary>
	/// <value>layers_clear</value>
	LayersClear = 58684,

	/// <summary>analytics, bar, bars, chart, data, diagram, graph, infographic, leaderboard, measure, metrics, statistics, tracking</summary>
	/// <value>leaderboard</value>
	Leaderboard = 61964,

	/// <summary>add, connection, data, leak, link, network, service, signals, synce, wireless</summary>
	/// <value>leak_add</value>
	LeakAdd = 58360,

	/// <summary>connection, data, disabled, enabled, leak, link, network, off, offline, on, remove, service, signals, slash, synce, wireless</summary>
	/// <value>leak_remove</value>
	LeakRemove = 58361,

	/// <summary>analytics, chart, data, diagram, graph, infographic, legend, measure, metrics, monitoring, stackdriver, statistics, toggle, tracking</summary>
	/// <value>legend_toggle</value>
	LegendToggle = 61723,

	/// <summary>circle, full, geometry, lens, moon</summary>
	/// <value>lens</value>
	Lens = 58362,

	/// <summary>blur, camera, dim, dot, effect, foggy, fuzzy, image, lens, photo, soften</summary>
	/// <value>lens_blur</value>
	LensBlur = 61481,

	/// <summary>+, add, collection, layers, library, multiple, music, new, plus, save, stacked, symbol, video</summary>
	/// <value>library_add</value>
	LibraryAdd = 57390,

	/// <summary>add, approve, check, collection, complete, done, layers, library, mark, multiple, music, ok, select, stacked, tick, validate, verified, video, yes</summary>
	/// <value>library_add_check</value>
	LibraryAddCheck = 59831,

	/// <summary>add, album, audio, book, books, collection, library, read, reading</summary>
	/// <value>library_books</value>
	LibraryBooks = 57391,

	/// <summary>add, album, audio, collection, library, music, song, sounds</summary>
	/// <value>library_music</value>
	LibraryMusic = 57392,

	/// <summary>bulb, ceiling, hanging, inside, interior, lamp, light, lighting, pendent, room</summary>
	/// <value>light</value>
	Light = 61482,

	/// <summary>bright, brightness, day, device, light, lighting, mode, mornng, sky, sun, sunny</summary>
	/// <value>light_mode</value>
	LightMode = 58648,

	/// <summary>alert, announcement, idea, info, information, learning, light, lightbulb, mode, on</summary>
	/// <value>lightbulb</value>
	Lightbulb = 57584,

	/// <summary></summary>
	/// <value>line_axis</value>
	LineAxis = 60058,

	/// <summary>dash, dotted, line, rule, spacing, style</summary>
	/// <value>line_style</value>
	LineStyle = 59673,

	/// <summary>height, line, size, spacing, style, thickness, weight</summary>
	/// <value>line_weight</value>
	LineWeight = 59674,

	/// <summary>app, application, components, design, interface, layout, linear, measure, menu, scale, screen, site, slider, ui, ux, web, website, window</summary>
	/// <value>linear_scale</value>
	LinearScale = 57952,

	/// <summary>chain, clip, connection, external, hyperlink, link, linked, links, multimedia, unlisted, url</summary>
	/// <value>link</value>
	Link = 57687,

	/// <summary>attached, chain, clip, connection, disabled, enabled, link, linked, links, multimedia, off, on, slash, unlink, url</summary>
	/// <value>link_off</value>
	LinkOff = 57711,

	/// <summary>camera, connect, connection, lens, linked, network, photo, photography, picture, signal, signals, sync, wireless</summary>
	/// <value>linked_camera</value>
	LinkedCamera = 58424,

	/// <summary>alcohol, bar, bottle, club, cocktail, drink, food, liquor, party, store, wine</summary>
	/// <value>liquor</value>
	Liquor = 60000,

	/// <summary>file, format, index, list, menu, options</summary>
	/// <value>list</value>
	List = 59542,

	/// <summary>alt, box, contained, format, lines, list, order, reorder, stacked, title</summary>
	/// <value>list_alt</value>
	ListAlt = 57582,

	/// <summary>?, assistance, bubble, chat, comment, communicate, help, info, information, live, message, punctuation, question mark, speech, support, symbol</summary>
	/// <value>live_help</value>
	LiveHelp = 57542,

	/// <summary>Android, OS, antennas hardware, chrome, desktop, device, iOS, live, mac, monitor, movie, play, stream, television, tv, web, window</summary>
	/// <value>live_tv</value>
	LiveTv = 58937,

	/// <summary>chair, comfort, couch, decoration, furniture, home, house, living, lounging, loveseat, room, seat, seating, sofa</summary>
	/// <value>living</value>
	Living = 61483,

	/// <summary>activity, event, local, star, things, ticket</summary>
	/// <value>local_activity</value>
	LocalActivity = 58687,

	/// <summary>air, airplane, airport, flight, plane, transportation, travel, trip</summary>
	/// <value>local_airport</value>
	LocalAirport = 58685,

	/// <summary>atm, bill, card, cart, cash, coin, commerce, credit, currency, dollars, local, money, online, pay, payment, shopping, symbol</summary>
	/// <value>local_atm</value>
	LocalAtm = 58686,

	/// <summary>alcohol, bar, bottle, club, cocktail, drink, food, liquor, local, wine</summary>
	/// <value>local_bar</value>
	LocalBar = 58688,

	/// <summary>bottle, cafe, coffee, cup, drink, food, restaurant, tea</summary>
	/// <value>local_cafe</value>
	LocalCafe = 58689,

	/// <summary>automobile, car, cars, local, maps, transportation, travel, vehicle, wash</summary>
	/// <value>local_car_wash</value>
	LocalCarWash = 58690,

	/// <summary>--, 24, bill, building, business, card, cash, coin, commerce, company, convenience, credit, currency, dollars, local, maps, market, money, new, online, pay, payment, plus, shop, shopping, store, storefront, symbol</summary>
	/// <value>local_convenience_store</value>
	LocalConvenienceStore = 58691,

	/// <summary>dining, eat, food, fork, knife, local, meal, restaurant, spoon</summary>
	/// <value>local_dining</value>
	LocalDining = 58710,

	/// <summary>cup, drink, drop, droplet, liquid, local, park, water</summary>
	/// <value>local_drink</value>
	LocalDrink = 58692,

	/// <summary>911, department, fire, firefighter, flame, hot</summary>
	/// <value>local_fire_department</value>
	LocalFireDepartment = 61269,

	/// <summary>florist, flower, local, shop</summary>
	/// <value>local_florist</value>
	LocalFlorist = 58693,

	/// <summary>auto, car, gas, local, oil, station, vehicle</summary>
	/// <value>local_gas_station</value>
	LocalGasStation = 58694,

	/// <summary>grocery, market, shop, store</summary>
	/// <value>local_grocery_store</value>
	LocalGroceryStore = 58695,

	/// <summary>911, aid, cross, emergency, first, hospital, local, medicine</summary>
	/// <value>local_hospital</value>
	LocalHospital = 58696,

	/// <summary></summary>
	/// <value>local_hotel</value>
	LocalHotel = 58697,

	/// <summary>cleaning, clothing, dry, dryer, hotel, laundry, local, service, washer</summary>
	/// <value>local_laundry_service</value>
	LocalLaundryService = 58698,

	/// <summary>book, community learning, library, local, read</summary>
	/// <value>local_library</value>
	LocalLibrary = 58699,

	/// <summary>bag, bill, building, business, buy, card, cart, cash, coin, commerce, credit, currency, dollars, handbag, local, mall, money, online, pay, payment, shop, shopping, store, storefront</summary>
	/// <value>local_mall</value>
	LocalMall = 58700,

	/// <summary></summary>
	/// <value>local_movies</value>
	LocalMovies = 58701,

	/// <summary>deal, discount, offer, price, shop, shopping, store, tag</summary>
	/// <value>local_offer</value>
	LocalOffer = 58702,

	/// <summary>alphabet, auto, car, character, font, garage, letter, local, park, parking, symbol, text, type, vehicle</summary>
	/// <value>local_parking</value>
	LocalParking = 58703,

	/// <summary>911, aid, cross, emergency, first, hospital, local, medicine, pharmacy, places</summary>
	/// <value>local_pharmacy</value>
	LocalPharmacy = 58704,

	/// <summary>booth, call, communication, phone, telecommunication</summary>
	/// <value>local_phone</value>
	LocalPhone = 58705,

	/// <summary>drink, fastfood, food, local, meal, pizza</summary>
	/// <value>local_pizza</value>
	LocalPizza = 58706,

	/// <summary></summary>
	/// <value>local_play</value>
	LocalPlay = 58707,

	/// <summary>911, badge, law, local, officer, police, protect, protection, security, shield</summary>
	/// <value>local_police</value>
	LocalPolice = 61270,

	/// <summary>delivery, email, envelop, letter, local, mail, message, office, package, parcel, post, postal, send, stamp</summary>
	/// <value>local_post_office</value>
	LocalPostOffice = 58708,

	/// <summary>draft, fax, ink, local, machine, office, paper, print, printer, printshop, send</summary>
	/// <value>local_printshop</value>
	LocalPrintshop = 58709,

	/// <summary>camera, lens, local, photo, photography, picture, see</summary>
	/// <value>local_see</value>
	LocalSee = 58711,

	/// <summary>automobile, car, cars, delivery, letter, local, mail, maps, office, package, parcel, post, postal, send, shipping, shopping, stamp, transportation, truck, vehicle</summary>
	/// <value>local_shipping</value>
	LocalShipping = 58712,

	/// <summary>automobile, cab, call, car, cars, direction, local, lyft, maps, public, taxi, transportation, uber, vehicle, yellow</summary>
	/// <value>local_taxi</value>
	LocalTaxi = 58713,

	/// <summary>apartments, architecture, buildings, business, city, estate, home, landscape, location, place, real, residence, residential, shelter, town, urban</summary>
	/// <value>location_city</value>
	LocationCity = 59377,

	/// <summary>destination, direction, disabled, enabled, location, maps, off, on, pin, place, pointer, slash, stop, tracking</summary>
	/// <value>location_disabled</value>
	LocationDisabled = 57782,

	/// <summary>destination, direction, disabled, enabled, location, maps, off, on, pin, place, slash, stop</summary>
	/// <value>location_off</value>
	LocationOff = 57543,

	/// <summary>destination, direction, disabled, enabled, location, maps, off, on, pin, place, slash, stop</summary>
	/// <value>location_on</value>
	LocationOn = 57544,

	/// <summary>destination, direction, location, maps, pin, place, pointer, searching, stop, tracking</summary>
	/// <value>location_searching</value>
	LocationSearching = 57783,

	/// <summary>lock, locked, password, privacy, private, protection, safety, secure, security</summary>
	/// <value>lock</value>
	Lock = 59543,

	/// <summary>clock, date, lock, locked, password, privacy, private, protection, safety, schedule, secure, security, time</summary>
	/// <value>lock_clock</value>
	LockClock = 61271,

	/// <summary>lock, open, password, privacy, private, protection, safety, secure, security, unlocked</summary>
	/// <value>lock_open</value>
	LockOpen = 59544,

	/// <summary></summary>
	/// <value>lock_reset</value>
	LockReset = 60126,

	/// <summary>access, app, application, arrow, components, design, enter, in, interface, left, log, login, screen, sign, site, ui, ux, web, website</summary>
	/// <value>login</value>
	Login = 60023,

	/// <summary></summary>
	/// <value>logo_dev</value>
	LogoDev = 60118,

	/// <summary>app, application, arrow, components, design, exit, interface, leave, log, login, logout, right, screen, site, ui, ux, web, website</summary>
	/// <value>logout</value>
	Logout = 59834,

	/// <summary>circle, half, looks, rainbow</summary>
	/// <value>looks</value>
	Looks = 58364,

	/// <summary>3, digit, looks, numbers, square, symbol</summary>
	/// <value>looks_3</value>
	Looks3 = 58363,

	/// <summary>4, digit, looks, numbers, square, symbol</summary>
	/// <value>looks_4</value>
	Looks4 = 58365,

	/// <summary>5, digit, looks, numbers, square, symbol</summary>
	/// <value>looks_5</value>
	Looks5 = 58366,

	/// <summary>6, digit, looks, numbers, square, symbol</summary>
	/// <value>looks_6</value>
	Looks6 = 58367,

	/// <summary>1, digit, looks, numbers, square, symbol</summary>
	/// <value>looks_one</value>
	LooksOne = 58368,

	/// <summary>2, digit, looks, numbers, square, symbol</summary>
	/// <value>looks_two</value>
	LooksTwo = 58369,

	/// <summary>around, arrow, arrows, direction, inprogress, load, loading refresh, loop, music, navigation, renew, rotate, turn</summary>
	/// <value>loop</value>
	Loop = 57384,

	/// <summary>+, add, details, focus, glass, loupe, magnifying, new, plus, symbol</summary>
	/// <value>loupe</value>
	Loupe = 58370,

	/// <summary>arrange, arrow, backward, bottom, list, low, move, order, priority</summary>
	/// <value>low_priority</value>
	LowPriority = 57709,

	/// <summary>card, credit, loyalty, membership, miles, points, program, subscription heart, tag, travel, trip</summary>
	/// <value>loyalty</value>
	Loyalty = 59546,

	/// <summary>alphabet, character, data, font, internet, letter, lte, mobile, network, speed, symbol, text, type, wifi, wireless</summary>
	/// <value>lte_mobiledata</value>
	LteMobiledata = 61484,

	/// <summary>+, alphabet, character, data, font, internet, letter, lte, mobile, network, plus, speed, symbol, text, type, wifi, wireless</summary>
	/// <value>lte_plus_mobiledata</value>
	LtePlusMobiledata = 61485,

	/// <summary>airport, bag, baggage, carry, flight, hotel, luggage, on, suitcase, travel, trip</summary>
	/// <value>luggage</value>
	Luggage = 62005,

	/// <summary>breakfast, dining, dinner, drink, fastfood, food, hamburger, lunch, meal</summary>
	/// <value>lunch_dining</value>
	LunchDining = 60001,

	/// <summary>email, envelop, envelope, inbox, letter, mail, message, send</summary>
	/// <value>mail</value>
	Mail = 57688,

	/// <summary>email, envelop, letter, mail, message, outline, send</summary>
	/// <value>mail_outline</value>
	MailOutline = 57569,

	/// <summary>boy, gender, male, man, social, symbol</summary>
	/// <value>male</value>
	Male = 58766,

	/// <summary></summary>
	/// <value>man</value>
	Man = 58603,

	/// <summary>accounts, change, details service-human, face, gear, manage, options, people, person, profile, settings, user</summary>
	/// <value>manage_accounts</value>
	ManageAccounts = 61486,

	/// <summary>glass, history, magnifying, manage, search, text</summary>
	/// <value>manage_search</value>
	ManageSearch = 61487,

	/// <summary>destination, direction, location, map, maps, pin, place, route, stop, travel</summary>
	/// <value>map</value>
	Map = 58715,

	/// <summary>building, home, house, maps, office, work</summary>
	/// <value>maps_home_work</value>
	MapsHomeWork = 61488,

	/// <summary>+, add, bubble, comment, communicate, feedback, maps, message, new, plus, speech, symbol, ugc</summary>
	/// <value>maps_ugc</value>
	MapsUgc = 61272,

	/// <summary>design, layout, margin, padding, size, square</summary>
	/// <value>margin</value>
	Margin = 59835,

	/// <summary>as, envelop, letter, mail, mark, post, postal, read, receive, send, unread</summary>
	/// <value>mark_as_unread</value>
	MarkAsUnread = 59836,

	/// <summary>approve, bubble, chat, check, comment, communicate, complete, done, mark, message, ok, read, select, sent, speech, tick, verified, yes</summary>
	/// <value>mark_chat_read</value>
	MarkChatRead = 61835,

	/// <summary>bubble, chat, circle, comment, communicate, mark, message, notification, speech, unread</summary>
	/// <value>mark_chat_unread</value>
	MarkChatUnread = 61833,

	/// <summary>approve, check, complete, done, email, envelop, letter, mail, mark, message, note, ok, read, select, send, sent, tick, yes</summary>
	/// <value>mark_email_read</value>
	MarkEmailRead = 61836,

	/// <summary>check, circle, email, envelop, letter, mail, mark, message, note, notification, send, unread</summary>
	/// <value>mark_email_unread</value>
	MarkEmailUnread = 61834,

	/// <summary></summary>
	/// <value>mark_unread_chat_alt</value>
	MarkUnreadChatAlt = 60317,

	/// <summary>email, envelop, letter, mail, markunread, message, send, unread</summary>
	/// <value>markunread</value>
	Markunread = 57689,

	/// <summary>deliver, envelop, letter, mail, mailbox, markunread, post, postal, postbox, receive, send, unread</summary>
	/// <value>markunread_mailbox</value>
	MarkunreadMailbox = 59547,

	/// <summary>air, cover, covid, face, hospital, masks, medical, pollution, protection, respirator, sick, social</summary>
	/// <value>masks</value>
	Masks = 61976,

	/// <summary>app, application, components, design, interface, line, maximize, screen, shape, site, ui, ux, web, website</summary>
	/// <value>maximize</value>
	Maximize = 59696,

	/// <summary>bluetooth, connect, connection, connectivity, device, disabled, enabled, media, music, note, off, offline, on, paring, signal, slash, symbol, wireless</summary>
	/// <value>media_bluetooth_off</value>
	MediaBluetoothOff = 61489,

	/// <summary>bluetooth, connect, connection, connectivity, device, disabled, enabled, media, music, note, off, on, online, paring, signal, slash, symbol, wireless</summary>
	/// <value>media_bluetooth_on</value>
	MediaBluetoothOn = 61490,

	/// <summary>alternative, compromise, mediation, negotiation, party, structure</summary>
	/// <value>mediation</value>
	Mediation = 61351,

	/// <summary>aid, bag, briefcase, emergency, first, kit, medical, medicine, services</summary>
	/// <value>medical_services</value>
	MedicalServices = 61705,

	/// <summary>doctor, drug, emergency, hospital, medication, medicine, pharmacy, pills, prescription</summary>
	/// <value>medication</value>
	Medication = 61491,

	/// <summary></summary>
	/// <value>medication_liquid</value>
	MedicationLiquid = 60039,

	/// <summary>building, door, doorway, entrance, home, house, interior, meeting, office, open, places, room</summary>
	/// <value>meeting_room</value>
	MeetingRoom = 60239,

	/// <summary>card, chip, digital, memory, micro, processor, sd, storage</summary>
	/// <value>memory</value>
	Memory = 58146,

	/// <summary>app, application, components, hamburger, interface, line, lines, menu, screen, site, ui, ux, web, website</summary>
	/// <value>menu</value>
	Menu = 58834,

	/// <summary>book, dining, food, meal, menu, restaurant</summary>
	/// <value>menu_book</value>
	MenuBook = 59929,

	/// <summary>app, application, arrow, components, hamburger, interface, left, line, lines, menu, open, screen, site, ui, ux, web, website</summary>
	/// <value>menu_open</value>
	MenuOpen = 59837,

	/// <summary></summary>
	/// <value>merge</value>
	Merge = 60312,

	/// <summary>arrow, combine, direction, format, merge, text, type</summary>
	/// <value>merge_type</value>
	MergeType = 57938,

	/// <summary>bubble, chat, comment, communicate, feedback, message, speech</summary>
	/// <value>message</value>
	Message = 57545,

	/// <summary>hear, hearing, mic, microphone, noise, record, search, sound, speech, voice</summary>
	/// <value>mic</value>
	Mic = 57385,

	/// <summary>audio, disabled, enabled, external, mic, microphone, off, on, slash, sound, voice</summary>
	/// <value>mic_external_off</value>
	MicExternalOff = 61273,

	/// <summary>audio, disabled, enabled, external, mic, microphone, off, on, slash, sound, voice</summary>
	/// <value>mic_external_on</value>
	MicExternalOn = 61274,

	/// <summary>hear, hearing, mic, microphone, noise, none, record, sound, voice</summary>
	/// <value>mic_none</value>
	MicNone = 57386,

	/// <summary>audio, disabled, enabled, hear, hearing, mic, microphone, noise, off, on, record, recording, slash, sound, voice</summary>
	/// <value>mic_off</value>
	MicOff = 57387,

	/// <summary>appliance, cooking, electric, heat, home, house, kitchen, machine, microwave</summary>
	/// <value>microwave</value>
	Microwave = 61956,

	/// <summary>army, award, badge, honor, medal, merit, military, order, privilege, prize, rank, reward, ribbon, soldier, star, status, tech, trophy, win, winner</summary>
	/// <value>military_tech</value>
	MilitaryTech = 59967,

	/// <summary>app, application, components, design, interface, line, minimize, screen, shape, site, ui, ux, web, website</summary>
	/// <value>minimize</value>
	Minimize = 59697,

	/// <summary></summary>
	/// <value>miscellaneous_services</value>
	MiscellaneousServices = 61708,

	/// <summary>arrow, call, camera, film, filming, hardware, image, missed, motion, picture, record, video, videography</summary>
	/// <value>missed_video_call</value>
	MissedVideoCall = 57459,

	/// <summary>bubble, chat, comment, communicate, feedback, image, landscape, message, mms, mountain, mountains, multimedia, photo, photography, picture, speech</summary>
	/// <value>mms</value>
	Mms = 58904,

	/// <summary>Android, OS, approve, cell, check, complete, device, done, friendly, hardware, iOS, mark, mobile, ok, phone, select, tablet, tick, validate, verified, yes</summary>
	/// <value>mobile_friendly</value>
	MobileFriendly = 57856,

	/// <summary>Android, OS, cell, device, disabled, enabled, hardware, iOS, mobile, off, on, phone, silence, slash, tablet</summary>
	/// <value>mobile_off</value>
	MobileOff = 57857,

	/// <summary>Android, OS, cast, cell, device, hardware, iOS, mirror, mobile, monitor, phone, screen, screencast, share, stream, streaming, tablet, tv, wireless</summary>
	/// <value>mobile_screen_share</value>
	MobileScreenShare = 57575,

	/// <summary>arrow, data, disabled, down, enabled, internet, mobile, network, off, on, slash, speed, up, wifi, wireless</summary>
	/// <value>mobiledata_off</value>
	MobiledataOff = 61492,

	/// <summary>compose, create, draft, draw, edit, mode, pen, pencil, write</summary>
	/// <value>mode</value>
	Mode = 61591,

	/// <summary>bubble, chat, comment, communicate, feedback, message, mode comment, speech</summary>
	/// <value>mode_comment</value>
	ModeComment = 57939,

	/// <summary>compose, create, draft, draw, edit, mode, pen, pencil, write</summary>
	/// <value>mode_edit</value>
	ModeEdit = 57940,

	/// <summary>compose, create, draft, draw, edit, mode, outline, pen, pencil, write</summary>
	/// <value>mode_edit_outline</value>
	ModeEditOutline = 61493,

	/// <summary>dark, disturb, mode, moon, night, sleep, weather</summary>
	/// <value>mode_night</value>
	ModeNight = 61494,

	/// <summary></summary>
	/// <value>mode_of_travel</value>
	ModeOfTravel = 59342,

	/// <summary>disturb, mode, power, sleep, standby, target</summary>
	/// <value>mode_standby</value>
	ModeStandby = 61495,

	/// <summary>arrow, bulb, idea, inprogress, light, load, loading, model, refresh, renew, restore, reverse, rotate, training</summary>
	/// <value>model_training</value>
	ModelTraining = 61647,

	/// <summary>bill, card, cash, circle, coin, commerce, cost, credit, currency, dollars, finance, monetization, money, on, online, pay, payment, shopping, symbol</summary>
	/// <value>monetization_on</value>
	MonetizationOn = 57955,

	/// <summary>100, bill, card, cash, coin, commerce, cost, credit, currency, digit, dollars, finance, money, number, online, pay, payment, price, shopping, symbol</summary>
	/// <value>money</value>
	Money = 58749,

	/// <summary>bill, card, cart, cash, coin, commerce, credit, currency, disabled, dollars, enabled, money, off, on, online, pay, payment, shopping, slash, symbol</summary>
	/// <value>money_off</value>
	MoneyOff = 57948,

	/// <summary>bill, card, cart, cash, coin, commerce, credit, csred, currency, disabled, dollars, enabled, money, off, on, online, pay, payment, shopping, slash, symbol</summary>
	/// <value>money_off_csred</value>
	MoneyOffCsred = 61496,

	/// <summary>Android, OS, chrome, device, display, hardware, iOS, mac, monitor, screen, web, window</summary>
	/// <value>monitor</value>
	Monitor = 61275,

	/// <summary></summary>
	/// <value>monitor_heart</value>
	MonitorHeart = 60066,

	/// <summary>body, device, diet, health, monitor, scale, smart, weight</summary>
	/// <value>monitor_weight</value>
	MonitorWeight = 61497,

	/// <summary>black, camera, image, monochrome, photo, photography, photos, picture, white</summary>
	/// <value>monochrome_photos</value>
	MonochromePhotos = 58371,

	/// <summary>emoji, emotions, expressions, face, feelings, glad, happiness, happy, like, mood, person, pleased, smile, smiling, social, survey</summary>
	/// <value>mood</value>
	Mood = 59378,

	/// <summary>bad, disappointment, dislike, emoji, emotions, expressions, face, feelings, mood, person, rating, social, survey, unhappiness, unhappy, unpleased, unsmile, unsmiling</summary>
	/// <value>mood_bad</value>
	MoodBad = 59379,

	/// <summary>automobile, car, cars, direction, maps, moped, motorized, public, scooter, transportation, vehicle, vespa</summary>
	/// <value>moped</value>
	Moped = 60200,

	/// <summary>3, archive, bookmark, dots, etc, favorite, indent, label, more, remember, save, stamp, sticker, tab, tag, three</summary>
	/// <value>more</value>
	More = 58905,

	/// <summary>3, app, application, components, dots, etc, horiz, horizontal, interface, ios, more, screen, site, three, ui, ux, web, website</summary>
	/// <value>more_horiz</value>
	MoreHoriz = 58835,

	/// <summary>+, add, clock, date, more, new, plus, schedule, symbol, time</summary>
	/// <value>more_time</value>
	MoreTime = 59997,

	/// <summary>3, android, app, application, components, dots, etc, interface, more, screen, site, three, ui, ux, vert, vertical, web, website</summary>
	/// <value>more_vert</value>
	MoreVert = 58836,

	/// <summary></summary>
	/// <value>mosque</value>
	Mosque = 60082,

	/// <summary>A, alphabet, animation, auto, automatic, character, circle, font, gif, letter, live, motion, photos, symbol, text, type, video</summary>
	/// <value>motion_photos_auto</value>
	MotionPhotosAuto = 61498,

	/// <summary>animation, circle, disabled, enabled, motion, off, on, photos, slash, video</summary>
	/// <value>motion_photos_off</value>
	MotionPhotosOff = 59840,

	/// <summary>animation, circle, disabled, enabled, motion, off, on, photos, play, slash, video</summary>
	/// <value>motion_photos_on</value>
	MotionPhotosOn = 59841,

	/// <summary></summary>
	/// <value>motion_photos_pause</value>
	MotionPhotosPause = 61991,

	/// <summary>animation, circle, motion, pause, paused, photos, video</summary>
	/// <value>motion_photos_paused</value>
	MotionPhotosPaused = 59842,

	/// <summary>click, computer, cursor, device, hardware, mouse, wireless</summary>
	/// <value>mouse</value>
	Mouse = 58147,

	/// <summary></summary>
	/// <value>move_down</value>
	MoveDown = 60257,

	/// <summary>archive, arrow, down, email, envelop, inbox, incoming, letter, mail, message, move to, send</summary>
	/// <value>move_to_inbox</value>
	MoveToInbox = 57704,

	/// <summary></summary>
	/// <value>move_up</value>
	MoveUp = 60260,

	/// <summary>cinema, film, media, movie, slate, video</summary>
	/// <value>movie</value>
	Movie = 57388,

	/// <summary>clapperboard, creation, film, movie, movies, slate, video</summary>
	/// <value>movie_creation</value>
	MovieCreation = 58372,

	/// <summary>clapperboard, creation, film, filter, movie, movies, slate, stars, video</summary>
	/// <value>movie_filter</value>
	MovieFilter = 58426,

	/// <summary>arrow, direction, moving, navigation, travel, up</summary>
	/// <value>moving</value>
	Moving = 58625,

	/// <summary>alphabet, character, font, image, letter, megapixel, mp, photo, photography, pixels, quality, resolution, symbol, text, type</summary>
	/// <value>mp</value>
	Mp = 59843,

	/// <summary>analytics, bar, bars, chart, data, diagram, graph, infographic, line, measure, metrics, multiple, statistics, tracking</summary>
	/// <value>multiline_chart</value>
	MultilineChart = 59103,

	/// <summary>arrows, directions, dots, left, maps, multiple, navigation, right, stop</summary>
	/// <value>multiple_stop</value>
	MultipleStop = 61881,

	/// <summary>architecture, attraction, building, estate, event, exhibition, explore, local, museum, palces, real, see, shop, store, tour</summary>
	/// <value>museum</value>
	Museum = 59958,

	/// <summary>audio, audiotrack, key, music, note, sound, track</summary>
	/// <value>music_note</value>
	MusicNote = 58373,

	/// <summary>audio, audiotrack, disabled, enabled, key, music, note, off, on, slash, sound, track</summary>
	/// <value>music_off</value>
	MusicOff = 58432,

	/// <summary>band, music, mv, recording, screen, tv, video, watch</summary>
	/// <value>music_video</value>
	MusicVideo = 57443,

	/// <summary>destination, direction, location, maps, navigation, pin, place, point, stop</summary>
	/// <value>my_location</value>
	MyLocation = 58716,

	/// <summary>communication, nat</summary>
	/// <value>nat</value>
	Nat = 61276,

	/// <summary>forest, nature, outdoor, outside, park, tree, wilderness</summary>
	/// <value>nature</value>
	Nature = 58374,

	/// <summary>activity, body, forest, human, nature, outdoor, outside, park, people, person, tree, wilderness</summary>
	/// <value>nature_people</value>
	NaturePeople = 58375,

	/// <summary>arrow, arrows, before, direction, left, navigate</summary>
	/// <value>navigate_before</value>
	NavigateBefore = 58376,

	/// <summary>arrow, arrows, direction, navigate, next, right</summary>
	/// <value>navigate_next</value>
	NavigateNext = 58377,

	/// <summary>destination, direction, location, maps, navigation, pin, place, point, stop</summary>
	/// <value>navigation</value>
	Navigation = 58717,

	/// <summary>destination, direction, location, maps, me, navigation, near, pin, place, point, stop</summary>
	/// <value>near_me</value>
	NearMe = 58729,

	/// <summary>destination, direction, disabled, enabled, location, maps, me, navigation, near, off, on, pin, place, point, slash</summary>
	/// <value>near_me_disabled</value>
	NearMeDisabled = 61935,

	/// <summary>!, alert, attention, caution, danger, error, exclamation, important, mark, nearby, notification, symbol, warning</summary>
	/// <value>nearby_error</value>
	NearbyError = 61499,

	/// <summary>disabled, enabled, nearby, off, on, slash</summary>
	/// <value>nearby_off</value>
	NearbyOff = 61500,

	/// <summary>cell, cellular, data, internet, mobile, network, phone, speed, wifi, wireless</summary>
	/// <value>network_cell</value>
	NetworkCell = 57785,

	/// <summary>check, connect, connection, internet, meter, network, signal, speed, tick, wifi, wireless</summary>
	/// <value>network_check</value>
	NetworkCheck = 58944,

	/// <summary>alert, available, cellular, connection, data, error, internet, lock, locked, mobile, network, not, privacy, private, protection, restricted, safety, secure, security, service, signal, warning, wifi, wireless</summary>
	/// <value>network_locked</value>
	NetworkLocked = 58906,

	/// <summary></summary>
	/// <value>network_ping</value>
	NetworkPing = 60362,

	/// <summary>cell, cellular, data, internet, mobile, network, phone, speed, wifi, wireless</summary>
	/// <value>network_wifi</value>
	NetworkWifi = 57786,

	/// <summary></summary>
	/// <value>new_label</value>
	NewLabel = 58889,

	/// <summary>!, alert, attention, burst, caution, danger, error, exclamation, important, mark, new, notification, release, releases, star, symbol, warning</summary>
	/// <value>new_releases</value>
	NewReleases = 57393,

	/// <summary></summary>
	/// <value>newspaper</value>
	Newspaper = 60289,

	/// <summary>arrow, circle, next, plan, right</summary>
	/// <value>next_plan</value>
	NextPlan = 61277,

	/// <summary>arrow, bag, baggage, briefcase, business, case, next, suitcase, week</summary>
	/// <value>next_week</value>
	NextWeek = 57706,

	/// <summary>communication, data, field, mobile, near, nfc, wireless</summary>
	/// <value>nfc</value>
	Nfc = 57787,

	/// <summary>architecture, bed, building, estate, homeless, house, night, place, real, shelter, sleep</summary>
	/// <value>night_shelter</value>
	NightShelter = 61937,

	/// <summary>alcohol, bar, bottle, club, cocktail, dance, drink, food, glass, liquor, music, nightlife, note, wine</summary>
	/// <value>nightlife</value>
	Nightlife = 60002,

	/// <summary>dark, disturb, mode, moon, night, nightlight, sleep, weather</summary>
	/// <value>nightlight</value>
	Nightlight = 61501,

	/// <summary>dark, half, light, mode, moon, night, nightlight, round</summary>
	/// <value>nightlight_round</value>
	NightlightRound = 61278,

	/// <summary>cloud, crescent, dark, mode, moon, nights, phases, silence, silent, sky, stay, time, weather</summary>
	/// <value>nights_stay</value>
	NightsStay = 59974,

	/// <summary>account, accounts, avatar, disabled, enabled, face, human, no, off, offline, on, people, person, profile, slash, thumbnail, unavailable, unidentifiable, unknown, user</summary>
	/// <value>no_accounts</value>
	NoAccounts = 61502,

	/// <summary>accessory, backpack, bag, bookbag, knapsack, no, pack, travel</summary>
	/// <value>no_backpack</value>
	NoBackpack = 62007,

	/// <summary>Android, OS, cell, device, disabled, enabled, hardware, iOS, mobile, no, off, on, phone, slash, tablet</summary>
	/// <value>no_cell</value>
	NoCell = 61860,

	/// <summary>alcohol, beverage, bottle, cocktail, drink, drinks, food, liquor, no, wine</summary>
	/// <value>no_drinks</value>
	NoDrinks = 61861,

	/// <summary>disabled, enabled, encryption, lock, no, off, on, password, safety, security, slash</summary>
	/// <value>no_encryption</value>
	NoEncryption = 58945,

	/// <summary>disabled, enabled, encryption, error, gmail, lock, locked, no, off, on, slash</summary>
	/// <value>no_encryption_gmailerrorred</value>
	NoEncryptionGmailerrorred = 61503,

	/// <summary>bolt, camera, disabled, enabled, flash, image, lightning, no, off, on, photo, photography, picture, slash, thunderbolt</summary>
	/// <value>no_flash</value>
	NoFlash = 61862,

	/// <summary>disabled, drink, enabled, fastfood, food, hamburger, meal, no, off, on, slash</summary>
	/// <value>no_food</value>
	NoFood = 61863,

	/// <summary>bag, baggage, carry, disabled, enabled, luggage, no, off, on, slash, suitcase, travel</summary>
	/// <value>no_luggage</value>
	NoLuggage = 62011,

	/// <summary>dining, disabled, eat, enabled, food, fork, knife, meal, meals, no, off, on, restaurant, slash, spoon, utensils</summary>
	/// <value>no_meals</value>
	NoMeals = 61910,

	/// <summary>building, disabled, door, doorway, enabled, entrance, home, house, interior, meeting, no, off, office, on, open, places, room, slash</summary>
	/// <value>no_meeting_room</value>
	NoMeetingRoom = 60238,

	/// <summary>camera, disabled, enabled, image, no, off, on, photo, photography, picture, slash</summary>
	/// <value>no_photography</value>
	NoPhotography = 61864,

	/// <summary>camera, card, device, eject, insert, memory, no, phone, sim, storage</summary>
	/// <value>no_sim</value>
	NoSim = 57548,

	/// <summary>baby, care, carriage, child, children, disabled, enabled, infant, kid, newborn, no, off, on, parents, slash, stroller, toddler, young</summary>
	/// <value>no_stroller</value>
	NoStroller = 61871,

	/// <summary>automobile, bus, car, cars, direction, disabled, enabled, maps, no, off, on, public, slash, transfer, transportation, vehicle</summary>
	/// <value>no_transfer</value>
	NoTransfer = 61909,

	/// <summary>athlete, athletic, body, entertainment, exercise, hiking, hobby, human, nordic, people, person, social, sports, travel, walker, walking</summary>
	/// <value>nordic_walking</value>
	NordicWalking = 58638,

	/// <summary>arrow, directional, maps, navigation, north, up</summary>
	/// <value>north</value>
	North = 61920,

	/// <summary>arrow, east, maps, navigation, noth, right, up</summary>
	/// <value>north_east</value>
	NorthEast = 61921,

	/// <summary>arrow, directional, left, maps, navigation, north, up, west</summary>
	/// <value>north_west</value>
	NorthWest = 61922,

	/// <summary>accessibility, accessible, body, handicap, help, human, not, person, wheelchair</summary>
	/// <value>not_accessible</value>
	NotAccessible = 61694,

	/// <summary>cancel, close, dislike, exit, interested, no, not, off, quit, remove, stop, x</summary>
	/// <value>not_interested</value>
	NotInterested = 57395,

	/// <summary>?, assistance, destination, direction, help, info, information, listed, location, maps, not, pin, place, punctuation, question mark, stop, support, symbol</summary>
	/// <value>not_listed_location</value>
	NotListedLocation = 58741,

	/// <summary>circle, media, not, pause, play, started, video</summary>
	/// <value>not_started</value>
	NotStarted = 61649,

	/// <summary>bookmark, message, note, paper</summary>
	/// <value>note</value>
	Note = 57455,

	/// <summary>+, -doc, add, data, document, drive, file, folder, folders, new, note, page, paper, plus, sheet, slide, symbol, writing</summary>
	/// <value>note_add</value>
	NoteAdd = 59548,

	/// <summary>alt, clipboard, document, file, memo, note, page, paper, writing</summary>
	/// <value>note_alt</value>
	NoteAlt = 61504,

	/// <summary>comment, doc, document, note, notes, text, write, writing</summary>
	/// <value>notes</value>
	Notes = 57964,

	/// <summary>+, active, add, alarm, alert, bell, chime, notification, notifications, notify, plus, reminder, ring, sound, symbol</summary>
	/// <value>notification_add</value>
	NotificationAdd = 58265,

	/// <summary>!, active, alarm, alert, attention, bell, caution, chime, danger, error, exclamation, important, mark, notification, notifications, notify, reminder, ring, sound, symbol, warning</summary>
	/// <value>notification_important</value>
	NotificationImportant = 57348,

	/// <summary>active, alarm, alert, bell, chime, notifications, notify, reminder, ring, sound</summary>
	/// <value>notifications</value>
	Notifications = 59380,

	/// <summary>active, alarm, alert, bell, chime, notifications, notify, reminder, ring, ringing, sound</summary>
	/// <value>notifications_active</value>
	NotificationsActive = 59383,

	/// <summary>alarm, alert, bell, none, notifications, notify, reminder, sound</summary>
	/// <value>notifications_none</value>
	NotificationsNone = 59381,

	/// <summary>active, alarm, alert, bell, chime, disabled, enabled, notifications, notify, off, offline, on, reminder, ring, slash, sound</summary>
	/// <value>notifications_off</value>
	NotificationsOff = 59382,

	/// <summary>active, alarm, alert, bell, chime, ignore, notifications, notify, paused, quiet, reminder, ring --- pause, sleep, snooze, sound, z, zzz</summary>
	/// <value>notifications_paused</value>
	NotificationsPaused = 59384,

	/// <summary></summary>
	/// <value>numbers</value>
	Numbers = 60103,

	/// <summary>bolt, circle, electric, fast, lightning, offline, thunderbolt</summary>
	/// <value>offline_bolt</value>
	OfflineBolt = 59698,

	/// <summary>approve, check, checkmark, circle, complete, done, mark, offline, ok, pin, select, tick, validate, verified, yes</summary>
	/// <value>offline_pin</value>
	OfflinePin = 59658,

	/// <summary>Android, OS, arrow, cell, connect, device, direction, hardware, iOS, link, mobile, multiple, offline, phone, right, share, tablet</summary>
	/// <value>offline_share</value>
	OfflineShare = 59845,

	/// <summary>Android, OS, chrome, demand, desktop, device, hardware, iOS, mac, monitor, ondemand, play, television, tv, video, web, window</summary>
	/// <value>ondemand_video</value>
	OndemandVideo = 58938,

	/// <summary>bulb, connection, idea, light, network, online, prediction, signal, wireless</summary>
	/// <value>online_prediction</value>
	OnlinePrediction = 61675,

	/// <summary>color, drop, droplet, hue, invert, inverted, opacity, palette, tone, water</summary>
	/// <value>opacity</value>
	Opacity = 59676,

	/// <summary>arrow, browser, in, open, site, up, web, website, window</summary>
	/// <value>open_in_browser</value>
	OpenInBrowser = 59549,

	/// <summary>action, arrow, arrows, expand, full, grow, in, move, open</summary>
	/// <value>open_in_full</value>
	OpenInFull = 61902,

	/// <summary>app, application, arrow, box, components, in, interface, new, open, screen, site, ui, ux, web, website, window</summary>
	/// <value>open_in_new</value>
	OpenInNew = 59550,

	/// <summary>arrow, box, disabled, enabled, export, in, new, off, on, open, slash, window</summary>
	/// <value>open_in_new_off</value>
	OpenInNewOff = 58614,

	/// <summary>arrow, arrows, direction, expand, move, open, pan, with</summary>
	/// <value>open_with</value>
	OpenWith = 59551,

	/// <summary>architecture, cottage, estate, home, house, houses, maps, other, place, real, residence, residential, stay, traveling</summary>
	/// <value>other_houses</value>
	OtherHouses = 58764,

	/// <summary></summary>
	/// <value>outbound</value>
	Outbound = 57802,

	/// <summary>box, mail, outbox, send, sent</summary>
	/// <value>outbox</value>
	Outbox = 61279,

	/// <summary>barbecue, bbq, charcoal, cooking, grill, home, house, outdoor, outside</summary>
	/// <value>outdoor_grill</value>
	OutdoorGrill = 59975,

	/// <summary>connect, connecter, electricity, outlet, plug, power</summary>
	/// <value>outlet</value>
	Outlet = 61908,

	/// <summary>country, flag, goal, mark, nation, outlined, report, start</summary>
	/// <value>outlined_flag</value>
	OutlinedFlag = 57710,

	/// <summary></summary>
	/// <value>output</value>
	Output = 60350,

	/// <summary>design, layout, margin, padding, size, square</summary>
	/// <value>padding</value>
	Padding = 59848,

	/// <summary>article, gplus, pages, paper, post, star</summary>
	/// <value>pages</value>
	Pages = 59385,

	/// <summary>doc, document, find, glass, magnifying, page, paper, search, view</summary>
	/// <value>pageview</value>
	Pageview = 59552,

	/// <summary>circle, currency, money, paid, payment, transaction</summary>
	/// <value>paid</value>
	Paid = 61505,

	/// <summary>art, color, colors, filters, paint, palette</summary>
	/// <value>palette</value>
	Palette = 58378,

	/// <summary>fingers, gesture, hand, hands, human, move, pan, scan, stop, tool</summary>
	/// <value>pan_tool</value>
	PanTool = 59685,

	/// <summary></summary>
	/// <value>pan_tool_alt</value>
	PanToolAlt = 60345,

	/// <summary>angle, image, mountain, mountains, panorama, photo, photography, picture, view, wide</summary>
	/// <value>panorama</value>
	Panorama = 58379,

	/// <summary>angle, circle, eye, fish, image, panorama, photo, photography, picture, wide</summary>
	/// <value>panorama_fish_eye</value>
	PanoramaFishEye = 58380,

	/// <summary>angle, horizontal, image, panorama, photo, photography, picture, wide</summary>
	/// <value>panorama_horizontal</value>
	PanoramaHorizontal = 58381,

	/// <summary>angle, horizontal, image, panorama, photo, photography, picture, select, wide</summary>
	/// <value>panorama_horizontal_select</value>
	PanoramaHorizontalSelect = 61280,

	/// <summary>angle, horizontal, image, panorama, photo, photography, photosphere, picture, wide</summary>
	/// <value>panorama_photosphere</value>
	PanoramaPhotosphere = 59849,

	/// <summary>angle, horizontal, image, panorama, photo, photography, photosphere, picture, select, wide</summary>
	/// <value>panorama_photosphere_select</value>
	PanoramaPhotosphereSelect = 59850,

	/// <summary>angle, image, panorama, photo, photography, picture, vertical, wide</summary>
	/// <value>panorama_vertical</value>
	PanoramaVertical = 58382,

	/// <summary>angle, image, panorama, photo, photography, picture, select, vertical, wide</summary>
	/// <value>panorama_vertical_select</value>
	PanoramaVerticalSelect = 61281,

	/// <summary>angle, image, panorama, photo, photography, picture, wide</summary>
	/// <value>panorama_wide_angle</value>
	PanoramaWideAngle = 58383,

	/// <summary>angle, image, panorama, photo, photography, picture, select, wide</summary>
	/// <value>panorama_wide_angle_select</value>
	PanoramaWideAngleSelect = 61282,

	/// <summary>athlete, athletic, body, entertainment, exercise, fly, gliding, hobby, human, parachute, paragliding, people, person, sky, skydiving, social, sports, travel</summary>
	/// <value>paragliding</value>
	Paragliding = 58639,

	/// <summary>attraction, fresh, local, nature, outside, park, plant, tree</summary>
	/// <value>park</value>
	Park = 60003,

	/// <summary>camera, lens, mode, party, photo, photography, picture</summary>
	/// <value>party_mode</value>
	PartyMode = 59386,

	/// <summary>key, login, password, pin, security, star, unlock</summary>
	/// <value>password</value>
	Password = 61506,

	/// <summary>key, login, password, pattern, pin, security, star, unlock</summary>
	/// <value>pattern</value>
	Pattern = 61507,

	/// <summary>control, controls, media, music, pause, player, video</summary>
	/// <value>pause</value>
	Pause = 57396,

	/// <summary></summary>
	/// <value>pause_circle</value>
	PauseCircle = 57762,

	/// <summary>circle, control, controls, filled, media, music, pause, video</summary>
	/// <value>pause_circle_filled</value>
	PauseCircleFilled = 57397,

	/// <summary>circle, control, controls, media, music, outline, pause, video</summary>
	/// <value>pause_circle_outline</value>
	PauseCircleOutline = 57398,

	/// <summary>app, application desktop, device, pause, present, presentation, screen, share, site, slides, web, website, window, www</summary>
	/// <value>pause_presentation</value>
	PausePresentation = 57578,

	/// <summary>bill, card, cash, coin, commerce, cost, credit, currency, dollars, finance, money, online, pay, payment, price, shopping, symbol</summary>
	/// <value>payment</value>
	Payment = 59553,

	/// <summary>bill, card, cash, coin, commerce, cost, credit, currency, dollars, finance, layer, money, multiple, online, pay, payment, payments, price, shopping, symbol</summary>
	/// <value>payments</value>
	Payments = 61283,

	/// <summary>automobile, bicycle, bike, car, cars, maps, pedal, public, transportation, vehicle</summary>
	/// <value>pedal_bike</value>
	PedalBike = 60201,

	/// <summary>circle, dots, loading, pending, progress, wait, waiting</summary>
	/// <value>pending</value>
	Pending = 61284,

	/// <summary>actions, clipboard, clock, date, doc, document, pending, remember, schedule, time</summary>
	/// <value>pending_actions</value>
	PendingActions = 61883,

	/// <summary></summary>
	/// <value>pentagon</value>
	Pentagon = 60240,

	/// <summary>accounts, committee, community, face, family, friends, group, humans, network, people, persons, profiles, social, team, users</summary>
	/// <value>people</value>
	People = 59387,

	/// <summary>accounts, committee, face, family, friends, humans, network, people, persons, profiles, social, team, users</summary>
	/// <value>people_alt</value>
	PeopleAlt = 59937,

	/// <summary>accounts, committee, face, family, friends, humans, network, outline, people, persons, profiles, social, team, users</summary>
	/// <value>people_outline</value>
	PeopleOutline = 59388,

	/// <summary></summary>
	/// <value>percent</value>
	Percent = 60248,

	/// <summary>camera, image, microphone, min, perm, photo, photography, picture, speaker</summary>
	/// <value>perm_camera_mic</value>
	PermCameraMic = 59554,

	/// <summary>account, calendar, contact, date, face, human, information, people, perm, person, profile, schedule, time, user</summary>
	/// <value>perm_contact_calendar</value>
	PermContactCalendar = 59555,

	/// <summary>data, gear, info, information, perm, settings</summary>
	/// <value>perm_data_setting</value>
	PermDataSetting = 59556,

	/// <summary>Android, OS, alert, announcement, device, hardware, i, iOS, info, information, mobile, perm, phone, tablet</summary>
	/// <value>perm_device_information</value>
	PermDeviceInformation = 59557,

	/// <summary>account, avatar, face, human, identity, people, perm, person, profile, thumbnail, user</summary>
	/// <value>perm_identity</value>
	PermIdentity = 59558,

	/// <summary>collection, data, doc, document, file, folder, folders, image, landscape, media, mountain, mountains, perm, photo, photography, picture, storage</summary>
	/// <value>perm_media</value>
	PermMedia = 59559,

	/// <summary>bubble, call, cell, chat, comment, communicate, contact, device, message, msg, perm, phone, recording, speech, telephone, voice</summary>
	/// <value>perm_phone_msg</value>
	PermPhoneMsg = 59560,

	/// <summary>alert, announcement, connection, info, information, internet, network, perm, scan, service, signal, wifi, wireless</summary>
	/// <value>perm_scan_wifi</value>
	PermScanWifi = 59561,

	/// <summary>account, face, human, people, person, profile, user</summary>
	/// <value>person</value>
	Person = 59389,

	/// <summary>+, account, add, avatar, face, friend, human, new, people, person, plus, profile, symbol, user</summary>
	/// <value>person_add</value>
	PersonAdd = 59390,

	/// <summary>+, account, add, face, human, people, person, plus, profile, user</summary>
	/// <value>person_add_alt</value>
	PersonAddAlt = 59981,

	/// <summary></summary>
	/// <value>person_add_alt_1</value>
	PersonAddAlt1 = 61285,

	/// <summary>+, account, add, disabled, enabled, face, human, new, off, offline, on, people, person, plus, profile, slash, symbol, user</summary>
	/// <value>person_add_disabled</value>
	PersonAddDisabled = 59851,

	/// <summary>account, avatar, disabled, enabled, face, human, off, on, people, person, profile, slash, user</summary>
	/// <value>person_off</value>
	PersonOff = 58640,

	/// <summary>account, face, human, outline, people, person, profile, user</summary>
	/// <value>person_outline</value>
	PersonOutline = 59391,

	/// <summary>account, avatar, destination, direction, face, human, location, maps, people, person, pin, place, profile, stop, user</summary>
	/// <value>person_pin</value>
	PersonPin = 58714,

	/// <summary>account, circle, destination, direction, face, human, location, maps, people, person, pin, place, profile, stop, user</summary>
	/// <value>person_pin_circle</value>
	PersonPinCircle = 58730,

	/// <summary>account, avatar, delete, face, human, minus, people, person, profile, remove, unfriend, user</summary>
	/// <value>person_remove</value>
	PersonRemove = 61286,

	/// <summary></summary>
	/// <value>person_remove_alt_1</value>
	PersonRemoveAlt1 = 61287,

	/// <summary>account, avatar, face, find, glass, human, look, magnify, magnifying, people, person, profile, search, user</summary>
	/// <value>person_search</value>
	PersonSearch = 61702,

	/// <summary></summary>
	/// <value>personal_injury</value>
	PersonalInjury = 59098,

	/// <summary>Android, OS, cam, chrome, desktop, device, hardware, iOS, mac, monitor, personal, television, tv, video, web, window</summary>
	/// <value>personal_video</value>
	PersonalVideo = 58939,

	/// <summary>bug, control, exterminator, insects, pest</summary>
	/// <value>pest_control</value>
	PestControl = 61690,

	/// <summary>control, exterminator, mice, pest, rodent</summary>
	/// <value>pest_control_rodent</value>
	PestControlRodent = 61693,

	/// <summary>animal, cat, dog, hand, paw, pet</summary>
	/// <value>pets</value>
	Pets = 59677,

	/// <summary></summary>
	/// <value>phishing</value>
	Phishing = 60119,

	/// <summary>call, cell, contact, device, hardware, mobile, phone, telephone</summary>
	/// <value>phone</value>
	Phone = 57549,

	/// <summary>OS, android, cell, device, hardware, iOS, mobile, phone, tablet</summary>
	/// <value>phone_android</value>
	PhoneAndroid = 58148,

	/// <summary>bluetooth, call, cell, connect, connection, connectivity, contact, device, hardware, mobile, phone, signal, speaker, symbol, telephone, wireless</summary>
	/// <value>phone_bluetooth_speaker</value>
	PhoneBluetoothSpeaker = 58907,

	/// <summary>arrow, call, callback, cell, contact, device, down, hardware, mobile, phone, telephone</summary>
	/// <value>phone_callback</value>
	PhoneCallback = 58953,

	/// <summary>call, cell, contact, device, disabled, enabled, hardware, mobile, off, offline, on, phone, slash, telephone</summary>
	/// <value>phone_disabled</value>
	PhoneDisabled = 59852,

	/// <summary>call, cell, contact, device, enabled, hardware, mobile, phone, telephone</summary>
	/// <value>phone_enabled</value>
	PhoneEnabled = 59853,

	/// <summary>arrow, call, cell, contact, device, direction, forwarded, hardware, mobile, phone, right, telephone</summary>
	/// <value>phone_forwarded</value>
	PhoneForwarded = 58908,

	/// <summary>call, cell, connection, contact, data, device, hardware, in, mobile, network, phone, scan, service, signal, sound, speaker, talk, telephone, waves, wireless</summary>
	/// <value>phone_in_talk</value>
	PhoneInTalk = 58909,

	/// <summary>Android, OS, cell, device, hardware, iOS, iphone, mobile, phone, tablet</summary>
	/// <value>phone_iphone</value>
	PhoneIphone = 58149,

	/// <summary>call, cell, contact, device, hardware, lock, locked, mobile, password, phone, privacy, private, protection, safety, secure, security, telephone</summary>
	/// <value>phone_locked</value>
	PhoneLocked = 58910,

	/// <summary>arrow, call, cell, contact, device, hardware, missed, mobile, phone, telephone</summary>
	/// <value>phone_missed</value>
	PhoneMissed = 58911,

	/// <summary>call, cell, contact, device, hardware, mobile, pause, paused, phone, telephone</summary>
	/// <value>phone_paused</value>
	PhonePaused = 58912,

	/// <summary>Android, OS, chrome, computer, connect, desktop, device, hardware, iOS, link, mac, mobile, phone, phonelink, sync, tablet, web, windows</summary>
	/// <value>phonelink</value>
	Phonelink = 58150,

	/// <summary>Android, OS, cancel, cell, close, connection, device, erase, exit, hardware, iOS, mobile, no, phone, phonelink, remove, stop, tablet, x</summary>
	/// <value>phonelink_erase</value>
	PhonelinkErase = 57563,

	/// <summary>Android, OS, cell, connection, device, erase, hardware, iOS, lock, locked, mobile, password, phone, phonelink, privacy, private, protection, safety, secure, security, tablet</summary>
	/// <value>phonelink_lock</value>
	PhonelinkLock = 57564,

	/// <summary>Android, OS, chrome, computer, connect, desktop, device, disabled, enabled, hardware, iOS, link, mac, mobile, off, on, phone, phonelink, slash, sync, tablet, web, windows</summary>
	/// <value>phonelink_off</value>
	PhonelinkOff = 58151,

	/// <summary>Android, OS, cell, connection, data, device, hardware, iOS, mobile, network, phone, phonelink, ring, service, signal, tablet, wireless</summary>
	/// <value>phonelink_ring</value>
	PhonelinkRing = 57565,

	/// <summary>Android, OS, call, chat, device, hardware, iOS, info, mobile, phone, phonelink, settings, setup, tablet, text</summary>
	/// <value>phonelink_setup</value>
	PhonelinkSetup = 57566,

	/// <summary>image, mountain, mountains, photo, photography, picture</summary>
	/// <value>photo</value>
	Photo = 58384,

	/// <summary>album, archive, bookmark, image, label, library, mountain, mountains, photo, photography, picture, ribbon, save, tag</summary>
	/// <value>photo_album</value>
	PhotoAlbum = 58385,

	/// <summary>camera, image, photo, photography, picture</summary>
	/// <value>photo_camera</value>
	PhotoCamera = 58386,

	/// <summary>back, camera, image, landscape, mountain, mountains, photo, photography, picture, rear</summary>
	/// <value>photo_camera_back</value>
	PhotoCameraBack = 61288,

	/// <summary>account, camera, face, front, human, image, people, person, photo, photography, picture, portrait, profile, user</summary>
	/// <value>photo_camera_front</value>
	PhotoCameraFront = 61289,

	/// <summary>filter, filters, image, photo, photography, picture, star, stars</summary>
	/// <value>photo_filter</value>
	PhotoFilter = 58427,

	/// <summary>album, image, library, mountain, mountains, photo, photography, picture</summary>
	/// <value>photo_library</value>
	PhotoLibrary = 58387,

	/// <summary>actual, image, mountain, mountains, photo, photography, picture, select, size</summary>
	/// <value>photo_size_select_actual</value>
	PhotoSizeSelectActual = 58418,

	/// <summary>adjust, album, edit, editing, image, large, library, mountain, mountains, photo, photography, picture, select, size</summary>
	/// <value>photo_size_select_large</value>
	PhotoSizeSelectLarge = 58419,

	/// <summary>adjust, album, edit, editing, image, large, library, mountain, mountains, photo, photography, picture, select, size, small</summary>
	/// <value>photo_size_select_small</value>
	PhotoSizeSelectSmall = 58420,

	/// <summary></summary>
	/// <value>php</value>
	Php = 60303,

	/// <summary>instrument, keyboard, keys, music, musical, piano, social</summary>
	/// <value>piano</value>
	Piano = 58657,

	/// <summary>disabled, enabled, instrument, keyboard, keys, music, musical, off, on, piano, slash, social</summary>
	/// <value>piano_off</value>
	PianoOff = 58656,

	/// <summary>alphabet, as, character, document, file, font, image, letter, multiple, pdf, photo, photography, picture, symbol, text, type</summary>
	/// <value>picture_as_pdf</value>
	PictureAsPdf = 58389,

	/// <summary>crop, cropped, overlap, photo, picture, position, shape</summary>
	/// <value>picture_in_picture</value>
	PictureInPicture = 59562,

	/// <summary>crop, cropped, overlap, photo, picture, position, shape</summary>
	/// <value>picture_in_picture_alt</value>
	PictureInPictureAlt = 59665,

	/// <summary>analytics, bar, bars, chart, data, diagram, graph, infographic, measure, metrics, pie, statistics, tracking</summary>
	/// <value>pie_chart</value>
	PieChart = 59076,

	/// <summary>analytics, bar, bars, chart, data, diagram, graph, infographic, measure, metrics, outline, pie, statistics, tracking</summary>
	/// <value>pie_chart_outline</value>
	PieChartOutline = 61508,

	/// <summary>1, 2, 3, digit, key, login, logout, number, password, pattern, pin, security, star, symbol, unlock</summary>
	/// <value>pin</value>
	Pin = 61509,

	/// <summary>destination, direction, drop, location, maps, navigation, pin, place, stop</summary>
	/// <value>pin_drop</value>
	PinDrop = 58718,

	/// <summary></summary>
	/// <value>pin_end</value>
	PinEnd = 59239,

	/// <summary></summary>
	/// <value>pin_invoke</value>
	PinInvoke = 59235,

	/// <summary></summary>
	/// <value>pinch</value>
	Pinch = 60216,

	/// <summary>analytics, arrow, arrows, bar, bars, chart, data, diagram, direction, drive, edit, editing, graph, grid, infographic, measure, metrics, pivot, rotate, sheet, statistics, table, tracking</summary>
	/// <value>pivot_table_chart</value>
	PivotTableChart = 59854,

	/// <summary></summary>
	/// <value>pix</value>
	Pix = 60067,

	/// <summary>destination, direction, location, maps, navigation, pin, place, point, stop</summary>
	/// <value>place</value>
	Place = 58719,

	/// <summary>doc, document, find, glass, look, magnifying, page, paper, plagiarism, search, see</summary>
	/// <value>plagiarism</value>
	Plagiarism = 59994,

	/// <summary>arrow, control, controls, media, music, play, player, start, video</summary>
	/// <value>play_arrow</value>
	PlayArrow = 57399,

	/// <summary></summary>
	/// <value>play_circle</value>
	PlayCircle = 57796,

	/// <summary>arrow, circle, control, controls, media, music, play, video</summary>
	/// <value>play_circle_filled</value>
	PlayCircleFilled = 57400,

	/// <summary>arrow, circle, control, controls, media, music, outline, play, video</summary>
	/// <value>play_circle_outline</value>
	PlayCircleOutline = 57401,

	/// <summary>control, controls, disabled, enabled, media, music, off, on, play, slash, video</summary>
	/// <value>play_disabled</value>
	PlayDisabled = 61290,

	/// <summary>arrow, circle, down, google, half, play, work</summary>
	/// <value>play_for_work</value>
	PlayForWork = 59654,

	/// <summary>audio, book, bookmark, digital, ebook, lesson, multimedia, play, play lesson, read, reading, ribbon</summary>
	/// <value>play_lesson</value>
	PlayLesson = 61511,

	/// <summary>+, add, collection, list, music, new, playlist, plus, symbol</summary>
	/// <value>playlist_add</value>
	PlaylistAdd = 57403,

	/// <summary>add, approve, check, collection, complete, done, list, mark, music, ok, playlist, select, tick, validate, verified, yes</summary>
	/// <value>playlist_add_check</value>
	PlaylistAddCheck = 57445,

	/// <summary></summary>
	/// <value>playlist_add_check_circle</value>
	PlaylistAddCheckCircle = 59366,

	/// <summary></summary>
	/// <value>playlist_add_circle</value>
	PlaylistAddCircle = 59365,

	/// <summary>arow, collection, list, music, play, playlist</summary>
	/// <value>playlist_play</value>
	PlaylistPlay = 57439,

	/// <summary></summary>
	/// <value>playlist_remove</value>
	PlaylistRemove = 60288,

	/// <summary>build, construction, fix, handyman, plumbing, repair, tools, wrench</summary>
	/// <value>plumbing</value>
	Plumbing = 61703,

	/// <summary>1, add, digit, increase, number, one, plus, symbol</summary>
	/// <value>plus_one</value>
	PlusOne = 59392,

	/// <summary>broadcast, casting, network, podcasts, signal, transmitting, wireless</summary>
	/// <value>podcasts</value>
	Podcasts = 61512,

	/// <summary>checkout, cost, machine, merchant, money, of, pay, payment, point, pos, retail, sale, system, transaction</summary>
	/// <value>point_of_sale</value>
	PointOfSale = 61822,

	/// <summary>certified, find, glass, legal, look, magnify, magnifying, policy, privacy, private, protect, protection, search, security, see, shield, verified</summary>
	/// <value>policy</value>
	Policy = 59927,

	/// <summary>analytics, bar, bars, chart, data, diagram, graph, infographic, measure, metrics, poll, statistics, survey, tracking, vote</summary>
	/// <value>poll</value>
	Poll = 59393,

	/// <summary></summary>
	/// <value>polyline</value>
	Polyline = 60347,

	/// <summary>emblem, logo, mark, polymer</summary>
	/// <value>polymer</value>
	Polymer = 59563,

	/// <summary>athlete, athletic, beach, body, entertainment, exercise, hobby, human, ocean, people, person, places, pool, sea, sports, swim, swimming, water</summary>
	/// <value>pool</value>
	Pool = 60232,

	/// <summary>connection, data, disabled, enabled, internet, network, off, offline, on, portable, service, signal, slash, wifi, wireless</summary>
	/// <value>portable_wifi_off</value>
	PortableWifiOff = 57550,

	/// <summary>account, face, human, people, person, photo, picture, portrait, profile, user</summary>
	/// <value>portrait</value>
	Portrait = 58390,

	/// <summary>+, add, data, doc, document, drive, file, folder, folders, page, paper, plus, post, sheet, slide, text, writing</summary>
	/// <value>post_add</value>
	PostAdd = 59936,

	/// <summary>charge, cord, electric, electrical, outlet, plug, power</summary>
	/// <value>power</value>
	Power = 58940,

	/// <summary>input, lines, power, supply</summary>
	/// <value>power_input</value>
	PowerInput = 58166,

	/// <summary>charge, cord, disabled, electric, electrical, enabled, off, on, outlet, plug, power, slash</summary>
	/// <value>power_off</value>
	PowerOff = 58950,

	/// <summary>info, information, off, on, power, save, settings, shutdown</summary>
	/// <value>power_settings_new</value>
	PowerSettingsNew = 59564,

	/// <summary>arm, automatic, chain, conveyor, crane, factory, industry, machinery, manufacturing, mechanical, precision, production, repairing, robot, supply, warehouse</summary>
	/// <value>precision_manufacturing</value>
	PrecisionManufacturing = 61513,

	/// <summary>baby, birth, body, female, human, lady, maternity, mom, mother, people, person, pregnant, women</summary>
	/// <value>pregnant_woman</value>
	PregnantWoman = 59678,

	/// <summary>all, arrow, present, presentation, screen, share, site, slides, to, web, website</summary>
	/// <value>present_to_all</value>
	PresentToAll = 57567,

	/// <summary>design, eye, layout, preview, reveal, screen, see, show, site, view, web, website, window, www</summary>
	/// <value>preview</value>
	Preview = 61893,

	/// <summary>arrows, bill, card, cash, change, coin, commerce, cost, credit, currency, dollars, down, finance, money, online, pay, payment, price, shopping, symbol, up</summary>
	/// <value>price_change</value>
	PriceChange = 61514,

	/// <summary>approve, bill, card, cash, check, coin, commerce, complete, cost, credit, currency, dollars, done, finance, mark, money, ok, online, pay, payment, price, select, shopping, symbol, tick, validate, verified, yes</summary>
	/// <value>price_check</value>
	PriceCheck = 61515,

	/// <summary>draft, fax, ink, machine, office, paper, print, printer, send</summary>
	/// <value>print</value>
	Print = 59565,

	/// <summary>disabled, enabled, off, on, paper, print, printer, slash</summary>
	/// <value>print_disabled</value>
	PrintDisabled = 59855,

	/// <summary>!, alert, attention, caution, danger, error, exclamation, high, important, mark, notification, priority, symbol, warning</summary>
	/// <value>priority_high</value>
	PriorityHigh = 58949,

	/// <summary>alert, announcment, assistance, certified, details, help, i, info, information, privacy, private, protect, protection, security, service, shield, support, tip, verified</summary>
	/// <value>privacy_tip</value>
	PrivacyTip = 61660,

	/// <summary></summary>
	/// <value>private_connectivity</value>
	PrivateConnectivity = 59204,

	/// <summary>!, alert, attention, bill, card, cart, cash, caution, coin, commerce, credit, currency, danger, dollars, error, exclamation, important, limits, mark, money, notification, online, pay, payment, production, quantity, shopping, symbol, warning</summary>
	/// <value>production_quantity_limits</value>
	ProductionQuantityLimits = 57809,

	/// <summary>behavior, body, brain, cognitive, function, gear, head, human, intellectual, mental, mind, people, person, preferences, psychiatric, psychology, science, settings, social, therapy, thinking, thoughts</summary>
	/// <value>psychology</value>
	Psychology = 59978,

	/// <summary>earth, global, globe, map, network, planet, public, social, space, web, world</summary>
	/// <value>public</value>
	Public = 59403,

	/// <summary>disabled, earth, enabled, global, globe, map, network, off, on, planet, public, slash, social, space, web, world</summary>
	/// <value>public_off</value>
	PublicOff = 61898,

	/// <summary>arrow, cloud, file, import, publish, up, upload</summary>
	/// <value>publish</value>
	Publish = 57941,

	/// <summary>approve, arrow, arrows, changes, check, complete, done, inprogress, load, loading, mark, ok, published, refresh, renew, replace, rotate, select, tick, validate, verified, with, yes</summary>
	/// <value>published_with_changes</value>
	PublishedWithChanges = 62002,

	/// <summary></summary>
	/// <value>punch_clock</value>
	PunchClock = 60072,

	/// <summary>location, marker, pin, place, push, remember, save</summary>
	/// <value>push_pin</value>
	PushPin = 61709,

	/// <summary>barcode, camera, code, media, product, qr, quick, response, smartphone, url, urls</summary>
	/// <value>qr_code</value>
	QrCode = 61291,

	/// <summary>barcode, camera, code, media, product, qr, quick, response, smartphone, url, urls</summary>
	/// <value>qr_code_2</value>
	QrCode2 = 57354,

	/// <summary>barcode, camera, code, media, product, qr, quick, response, scanner, smartphone, url, urls</summary>
	/// <value>qr_code_scanner</value>
	QrCodeScanner = 61958,

	/// <summary>builder, clock, date, query, schedule, time</summary>
	/// <value>query_builder</value>
	QueryBuilder = 59566,

	/// <summary></summary>
	/// <value>query_stats</value>
	QueryStats = 58620,

	/// <summary>answer, bubble, chat, comment, communicate, conversation, feedback, message, question, speech, talk</summary>
	/// <value>question_answer</value>
	QuestionAnswer = 59567,

	/// <summary></summary>
	/// <value>question_mark</value>
	QuestionMark = 60299,

	/// <summary>add, collection, layers, list, multiple, music, playlist, queue, stack, stream, video</summary>
	/// <value>queue</value>
	Queue = 57404,

	/// <summary>collection, list, music, playlist, queue</summary>
	/// <value>queue_music</value>
	QueueMusic = 57405,

	/// <summary>+, add, arrow, desktop, device, display, hardware, monitor, new, next, play, plus, queue, screen, steam, symbol, tv</summary>
	/// <value>queue_play_next</value>
	QueuePlayNext = 57446,

	/// <summary>bolt, bubble, chat, comment, communicate, fast, lightning, message, quick, quickreply, reply, speech, thunderbolt</summary>
	/// <value>quickreply</value>
	Quickreply = 61292,

	/// <summary>?, assistance, faq, help, info, information, punctuation, question mark, quiz, support, symbol, test</summary>
	/// <value>quiz</value>
	Quiz = 61516,

	/// <summary>alphabet, character, data, font, letter, mobile, r, symbol, text, type</summary>
	/// <value>r_mobiledata</value>
	RMobiledata = 61517,

	/// <summary>detect, military, near, network, position, radar, scan</summary>
	/// <value>radar</value>
	Radar = 61518,

	/// <summary>antenna, audio, device, frequency, hardware, listen, media, music, player, radio, signal, tune</summary>
	/// <value>radio</value>
	Radio = 57406,

	/// <summary>app, application, bullet, button, checked, circle, components, design, form, interface, off, on, point, radio, record, screen, select, selected, site, toggle, ui, ux, web, website</summary>
	/// <value>radio_button_checked</value>
	RadioButtonChecked = 59447,

	/// <summary>bullet, button, circle, deselected, form, off, on, point, radio, record, select, toggle, unchecked</summary>
	/// <value>radio_button_unchecked</value>
	RadioButtonUnchecked = 59446,

	/// <summary>!, alert, attention, automobile, bike, car, cars, caution, danger, direction, error, exclamation, important, maps, mark, notification, public, railway, scooter, subway, symbol, train, transportation, vehicle, vespa, warning</summary>
	/// <value>railway_alert</value>
	RailwayAlert = 59857,

	/// <summary>breakfast, dining, dinner, drink, fastfood, food, lunch, meal, noodles, ramen, restaurant</summary>
	/// <value>ramen_dining</value>
	RamenDining = 60004,

	/// <summary></summary>
	/// <value>ramp_left</value>
	RampLeft = 60316,

	/// <summary></summary>
	/// <value>ramp_right</value>
	RampRight = 60310,

	/// <summary>comment, feedback, pen, pencil, rate, review, stars, write</summary>
	/// <value>rate_review</value>
	RateReview = 58720,

	/// <summary>alphabet, character, disabled, enabled, font, image, letter, off, on, original, photo, photography, raw, slash, symbol, text, type</summary>
	/// <value>raw_off</value>
	RawOff = 61519,

	/// <summary>alphabet, character, disabled, enabled, font, image, letter, off, on, original, photo, photography, raw, slash, symbol, text, type</summary>
	/// <value>raw_on</value>
	RawOn = 61520,

	/// <summary>arrow, more, read, text</summary>
	/// <value>read_more</value>
	ReadMore = 61293,

	/// <summary></summary>
	/// <value>real_estate_agent</value>
	RealEstateAgent = 59194,

	/// <summary>bill, credit, invoice, paper, payment, receipt, sale</summary>
	/// <value>receipt</value>
	Receipt = 59568,

	/// <summary>bill, check, document, list, long, paper, paperwork, receipt, record, store, transaction</summary>
	/// <value>receipt_long</value>
	ReceiptLong = 61294,

	/// <summary>account, actors, avatar, card, cards, carousel, face, human, layers, list, people, person, profile, recent, thumbnail, user</summary>
	/// <value>recent_actors</value>
	RecentActors = 57407,

	/// <summary>approved, circle, confirm, favorite, gesture, hand, like, reaction, recommend, social, support, thumbs, up, well</summary>
	/// <value>recommend</value>
	Recommend = 59858,

	/// <summary>account, face, human, over, people, person, profile, record, recording, speak, speaking, speech, transcript, user, voice</summary>
	/// <value>record_voice_over</value>
	RecordVoiceOver = 59679,

	/// <summary></summary>
	/// <value>rectangle</value>
	Rectangle = 60244,

	/// <summary></summary>
	/// <value>recycling</value>
	Recycling = 59232,

	/// <summary>bill, card, cart, cash, certificate, coin, commerce, credit, currency, dollars, gift, giftcard, money, online, pay, payment, present, redeem, shopping</summary>
	/// <value>redeem</value>
	Redeem = 59569,

	/// <summary>arrow, backward, forward, next, redo, repeat, rotate, undo</summary>
	/// <value>redo</value>
	Redo = 57690,

	/// <summary>arrow, body, capacity, covid, decrease, down, human, people, person, reduce, social</summary>
	/// <value>reduce_capacity</value>
	ReduceCapacity = 61980,

	/// <summary>around, arrow, arrows, direction, inprogress, load, loading refresh, navigation, refresh, renew, right, rotate, turn</summary>
	/// <value>refresh</value>
	Refresh = 58837,

	/// <summary>Android, OS, avatar, device, hardware, human, iOS, identity, me, mobile, people, person, phone, profile, remember, tablet, user</summary>
	/// <value>remember_me</value>
	RememberMe = 61521,

	/// <summary>can, delete, minus, negative, remove, substract, trash</summary>
	/// <value>remove</value>
	Remove = 57691,

	/// <summary>block, can, circle, delete, minus, negative, remove, substract, trash</summary>
	/// <value>remove_circle</value>
	RemoveCircle = 57692,

	/// <summary>block, can, circle, delete, minus, negative, outline, remove, substract, trash</summary>
	/// <value>remove_circle_outline</value>
	RemoveCircleOutline = 57693,

	/// <summary>approve, check, complete, disabled, done, enabled, finished, mark, multiple, off, ok, on, remove, select, slash, tick, yes</summary>
	/// <value>remove_done</value>
	RemoveDone = 59859,

	/// <summary>desktop, device, display, from, hardware, monitor, queue, remove, screen, steam</summary>
	/// <value>remove_from_queue</value>
	RemoveFromQueue = 57447,

	/// <summary>certified, disabled, enabled, moderator, off, on, privacy, private, protect, protection, remove, security, shield, slash, verified</summary>
	/// <value>remove_moderator</value>
	RemoveModerator = 59860,

	/// <summary>eye, iris, look, looking, preview, red, remove, see, sight, vision</summary>
	/// <value>remove_red_eye</value>
	RemoveRedEye = 58391,

	/// <summary>card, cart, cash, checkout, coin, commerce, credit, currency, disabled, dollars, enabled, off, on, online, pay, payment, remove, shopping, slash, tick</summary>
	/// <value>remove_shopping_cart</value>
	RemoveShoppingCart = 59688,

	/// <summary>format, lines, list, order, reorder, stacked</summary>
	/// <value>reorder</value>
	Reorder = 59646,

	/// <summary>arrow, arrows, control, controls, media, music, repeat, video</summary>
	/// <value>repeat</value>
	Repeat = 57408,

	/// <summary>arrow, arrows, control, controls, media, music, on, repeat, video</summary>
	/// <value>repeat_on</value>
	RepeatOn = 59862,

	/// <summary>1, arrow, arrows, control, controls, digit, media, music, number, one, repeat, symbol, video</summary>
	/// <value>repeat_one</value>
	RepeatOne = 57409,

	/// <summary>arrow, arrows, control, controls, digit, media, music, number, on, one, repeat, symbol, video</summary>
	/// <value>repeat_one_on</value>
	RepeatOneOn = 59863,

	/// <summary>arrow, arrows, control, controls, music, refresh, renew, repeat, replay, video</summary>
	/// <value>replay</value>
	Replay = 57410,

	/// <summary>10, arrow, arrows, control, controls, digit, music, number, refresh, renew, repeat, replay, symbol, ten, video</summary>
	/// <value>replay_10</value>
	Replay10 = 57433,

	/// <summary>30, arrow, arrows, control, controls, digit, music, number, refresh, renew, repeat, replay, symbol, thirty, video</summary>
	/// <value>replay_30</value>
	Replay30 = 57434,

	/// <summary>5, arrow, arrows, control, controls, digit, five, music, number, refresh, renew, repeat, replay, symbol, video</summary>
	/// <value>replay_5</value>
	Replay5 = 57435,

	/// <summary>arrow, arrows, circle, control, controls, filled, music, refresh, renew, repeat, replay, video</summary>
	/// <value>replay_circle_filled</value>
	ReplayCircleFilled = 59864,

	/// <summary>arrow, backward, left, mail, message, reply, send, share</summary>
	/// <value>reply</value>
	Reply = 57694,

	/// <summary>all, arrow, backward, group, left, mail, message, multiple, reply, send, share</summary>
	/// <value>reply_all</value>
	ReplyAll = 57695,

	/// <summary>!, alert, attention, caution, danger, error, exclamation, important, mark, notification, octagon, report, symbol, warning</summary>
	/// <value>report</value>
	Report = 57696,

	/// <summary>!, alert, attention, caution, danger, error, exclamation, gmail, gmailerrorred, important, mark, notification, octagon, report, symbol, warning</summary>
	/// <value>report_gmailerrorred</value>
	ReportGmailerrorred = 61522,

	/// <summary>!, alert, attention, caution, danger, disabled, enabled, error, exclamation, important, mark, notification, octagon, off, offline, on, report, slash, symbol, warning</summary>
	/// <value>report_off</value>
	ReportOff = 57712,

	/// <summary>!, alert, attention, caution, danger, error, exclamation, feedback, important, mark, notification, problem, report, symbol, triangle, warning</summary>
	/// <value>report_problem</value>
	ReportProblem = 59570,

	/// <summary></summary>
	/// <value>request_page</value>
	RequestPage = 61996,

	/// <summary>bill, card, cash, coin, commerce, cost, credit, currency, dollars, finance, money, online, pay, payment, price, quote, request, shopping, symbol</summary>
	/// <value>request_quote</value>
	RequestQuote = 61878,

	/// <summary>arrow, device, hardware, monitor, reset, television, tv</summary>
	/// <value>reset_tv</value>
	ResetTv = 59865,

	/// <summary>alt, around, arrow, inprogress, load, loading refresh, reboot, renew, repeat, reset, restart</summary>
	/// <value>restart_alt</value>
	RestartAlt = 61523,

	/// <summary>breakfast, dining, dinner, eat, food, fork, knife, local, lunch, meal, places, restaurant, spoon, utensils</summary>
	/// <value>restaurant</value>
	Restaurant = 58732,

	/// <summary>book, dining, eat, food, fork, knife, local, meal, menu, restaurant, spoon</summary>
	/// <value>restaurant_menu</value>
	RestaurantMenu = 58721,

	/// <summary>arrow, back, backwards, clock, date, history, refresh, renew, restore, reverse, rotate, schedule, time, turn</summary>
	/// <value>restore</value>
	Restore = 59571,

	/// <summary>arrow, back, backwards, clock, date, history, refresh, renew, restore, reverse, rotate, schedule, time, turn</summary>
	/// <value>restore_from_trash</value>
	RestoreFromTrash = 59704,

	/// <summary>arrow, data, doc, file, page, paper, refresh, restore, rotate, sheet, storage</summary>
	/// <value>restore_page</value>
	RestorePage = 59689,

	/// <summary>bubble, chat, comment, communicate, feedback, message, rate, rating, recommendation, reviews, speech</summary>
	/// <value>reviews</value>
	Reviews = 61524,

	/// <summary>bowl, dinner, food, lunch, meal, restaurant, rice</summary>
	/// <value>rice_bowl</value>
	RiceBowl = 61941,

	/// <summary>call, calling, cell, contact, device, hardware, incoming, mobile, phone, ring, ringer, sound, telephone, volume</summary>
	/// <value>ring_volume</value>
	RingVolume = 57553,

	/// <summary></summary>
	/// <value>rocket</value>
	Rocket = 60325,

	/// <summary></summary>
	/// <value>rocket_launch</value>
	RocketLaunch = 60315,

	/// <summary></summary>
	/// <value>roller_skating</value>
	RollerSkating = 60365,

	/// <summary>architecture, building, chimney, construction, estate, home, house, real, residence, residential, roof, roofing, service, shelter</summary>
	/// <value>roofing</value>
	Roofing = 61953,

	/// <summary>destination, direction, location, maps, pin, place, room, stop</summary>
	/// <value>room</value>
	Room = 59572,

	/// <summary>building, door, doorway, entrance, gear, home, house, interior, office, open, preferences, room, settings</summary>
	/// <value>room_preferences</value>
	RoomPreferences = 61880,

	/// <summary>alert, bell, delivery, hotel, notify, room, service</summary>
	/// <value>room_service</value>
	RoomService = 60233,

	/// <summary>90, arrow, arrows, ccw, degrees, direction, edit, editing, image, photo, rotate, turn</summary>
	/// <value>rotate_90_degrees_ccw</value>
	Rotate90DegreesCcw = 58392,

	/// <summary></summary>
	/// <value>rotate_90_degrees_cw</value>
	Rotate90DegreesCw = 60075,

	/// <summary>around, arrow, direction, inprogress, left, load, loading refresh, renew, rotate, turn</summary>
	/// <value>rotate_left</value>
	RotateLeft = 58393,

	/// <summary>around, arrow, direction, inprogress, load, loading refresh, renew, right, rotate, turn</summary>
	/// <value>rotate_right</value>
	RotateRight = 58394,

	/// <summary></summary>
	/// <value>roundabout_left</value>
	RoundaboutLeft = 60313,

	/// <summary></summary>
	/// <value>roundabout_right</value>
	RoundaboutRight = 60323,

	/// <summary>adjust, corner, edit, rounded, shape, square, transform</summary>
	/// <value>rounded_corner</value>
	RoundedCorner = 59680,

	/// <summary></summary>
	/// <value>route</value>
	Route = 60109,

	/// <summary>box, cable, connection, hardware, internet, network, router, signal, wifi</summary>
	/// <value>router</value>
	Router = 58152,

	/// <summary>activity, boat, body, canoe, human, people, person, row, rowing, sport, water</summary>
	/// <value>rowing</value>
	Rowing = 59681,

	/// <summary>application, blog, connection, data, feed, internet, network, rss, service, signal, website, wifi, wireless</summary>
	/// <value>rss_feed</value>
	RssFeed = 57573,

	/// <summary>alphabet, character, font, invitation, invite, letter, plaît, respond, rsvp, répondez, sil, symbol, text, type, vous</summary>
	/// <value>rsvp</value>
	Rsvp = 61525,

	/// <summary>call, real, rrt, text, time</summary>
	/// <value>rtt</value>
	Rtt = 59821,

	/// <summary>approve, check, complete, done, incomplete, line, mark, missing, no, ok, rule, select, tick, validate, verified, wrong, x, yes</summary>
	/// <value>rule</value>
	Rule = 61890,

	/// <summary>approve, cancel, check, close, complete, data, doc, document, done, drive, exit, file, folder, mark, no, ok, remove, rule, select, sheet, slide, storage, tick, validate, verified, x, yes</summary>
	/// <value>rule_folder</value>
	RuleFolder = 61897,

	/// <summary>body, circle, exercise, human, people, person, run, running</summary>
	/// <value>run_circle</value>
	RunCircle = 61295,

	/// <summary>!, alert, attention, caution, danger, duration, error, errors, exclamation, important, mark, notification, process, processing, running, symbol, time, warning, with</summary>
	/// <value>running_with_errors</value>
	RunningWithErrors = 58653,

	/// <summary>arrow, attach, automobile, automotive, back, car, cars, connect, direction, hookup, left, maps, public, right, rv, trailer, transportation, travel, truck, van, vehicle</summary>
	/// <value>rv_hookup</value>
	RvHookup = 58946,

	/// <summary>apart, distance, divider, safety, separate, social, space</summary>
	/// <value>safety_divider</value>
	SafetyDivider = 57804,

	/// <summary>boat, entertainment, fishing, hobby, ocean, sailboat, sailing, sea, social sports, travel, water</summary>
	/// <value>sailing</value>
	Sailing = 58626,

	/// <summary>bacteria, bottle, clean, covid, disinfect, germs, pump, sanitizer</summary>
	/// <value>sanitizer</value>
	Sanitizer = 61981,

	/// <summary>bluetooth, connect, connection, connectivity, data, device, image, internet, landscape, location, maps, mountain, mountains, network, photo, photography, picture, satellite, scan, service, signal, symbol, wireless-- wifi</summary>
	/// <value>satellite</value>
	Satellite = 58722,

	/// <summary></summary>
	/// <value>satellite_alt</value>
	SatelliteAlt = 60218,

	/// <summary>data, disk, document, drive, file, floppy, multimedia, save, storage</summary>
	/// <value>save</value>
	Save = 57697,

	/// <summary>alt, arrow, disk, document, down, file, floppy, multimedia, save</summary>
	/// <value>save_alt</value>
	SaveAlt = 57713,

	/// <summary></summary>
	/// <value>save_as</value>
	SaveAs = 60256,

	/// <summary>find, glass, important, look, magnify, magnifying, marked, saved, search, see, star</summary>
	/// <value>saved_search</value>
	SavedSearch = 59921,

	/// <summary>bank, bill, card, cash, coin, commerce, cost, credit, currency, dollars, finance, money, online, pay, payment, pig, piggy, savings, symbol</summary>
	/// <value>savings</value>
	Savings = 58091,

	/// <summary></summary>
	/// <value>scale</value>
	Scale = 60255,

	/// <summary>copy, device, hardware, machine, scan, scanner</summary>
	/// <value>scanner</value>
	Scanner = 58153,

	/// <summary>analytics, bar, bars, chart, circles, data, diagram, dot, graph, infographic, measure, metrics, plot, scatter, statistics, tracking</summary>
	/// <value>scatter_plot</value>
	ScatterPlot = 57960,

	/// <summary>clock, date, schedule, time</summary>
	/// <value>schedule</value>
	Schedule = 59573,

	/// <summary>calendar, clock, date, email, letter, mail, remember, schedule, send, share, time</summary>
	/// <value>schedule_send</value>
	ScheduleSend = 59914,

	/// <summary></summary>
	/// <value>schema</value>
	Schema = 58621,

	/// <summary>academy, achievement, cap, class, college, education, graduation, hat, knowledge, learning, school, university</summary>
	/// <value>school</value>
	School = 59404,

	/// <summary>beaker, chemical, chemistry, experiment, flask, glass, laboratory, research, science, tube</summary>
	/// <value>science</value>
	Science = 59979,

	/// <summary>2k, alphabet, analytics, bar, bars, character, chart, data, diagram, digit, font, graph, infographic, letter, measure, metrics, number, score, statistics, symbol, text, tracking, type</summary>
	/// <value>score</value>
	Score = 57961,

	/// <summary></summary>
	/// <value>scoreboard</value>
	Scoreboard = 60368,

	/// <summary>Android, OS, device, hardware, iOS, landscape, lock, mobile, phone, rotate, screen, tablet</summary>
	/// <value>screen_lock_landscape</value>
	ScreenLockLandscape = 57790,

	/// <summary>Android, OS, device, hardware, iOS, lock, mobile, phone, portrait, rotate, screen, tablet</summary>
	/// <value>screen_lock_portrait</value>
	ScreenLockPortrait = 57791,

	/// <summary>Android, OS, arrow, device, hardware, iOS, lock, mobile, phone, rotate, rotation, screen, tablet, turn</summary>
	/// <value>screen_lock_rotation</value>
	ScreenLockRotation = 57792,

	/// <summary>Android, OS, arrow, device, hardware, iOS, mobile, phone, rotate, rotation, screen, tablet, turn</summary>
	/// <value>screen_rotation</value>
	ScreenRotation = 57793,

	/// <summary>Android, OS, arrow, desktop, device, hardware, iOS, lock, monitor, rotate, screen, web</summary>
	/// <value>screen_search_desktop</value>
	ScreenSearchDesktop = 61296,

	/// <summary>Android, OS, arrow, cast, chrome, device, display, hardware, iOS, laptop, mac, mirror, monitor, screen, share, steam, streaming, web, window</summary>
	/// <value>screen_share</value>
	ScreenShare = 57570,

	/// <summary>Android, OS, cell, crop, device, hardware, iOS, mobile, phone, screen, screenshot, tablet</summary>
	/// <value>screenshot</value>
	Screenshot = 61526,

	/// <summary></summary>
	/// <value>scuba_diving</value>
	ScubaDiving = 60366,

	/// <summary>alphabet, camera, card, character, data, device, digital, drive, flash, font, image, letter, memory, photo, sd, secure, symbol, text, type</summary>
	/// <value>sd</value>
	Sd = 59869,

	/// <summary>camera, card, digital, memory, photos, sd, secure, storage</summary>
	/// <value>sd_card</value>
	SdCard = 58915,

	/// <summary>!, alert, attention, camera, card, caution, danger, digital, error, exclamation, important, mark, memory, notification, photos, sd, secure, storage, symbol, warning</summary>
	/// <value>sd_card_alert</value>
	SdCardAlert = 61527,

	/// <summary>camera, card, data, digital, memory, sd, secure, storage</summary>
	/// <value>sd_storage</value>
	SdStorage = 57794,

	/// <summary>filter, find, glass, look, magnify, magnifying, search, see</summary>
	/// <value>search</value>
	Search = 59574,

	/// <summary>cancel, close, disabled, enabled, find, glass, look, magnify, magnifying, off, on, search, see, slash, stop, x</summary>
	/// <value>search_off</value>
	SearchOff = 60022,

	/// <summary>certified, privacy, private, protect, protection, security, shield, verified</summary>
	/// <value>security</value>
	Security = 58154,

	/// <summary>Android, OS, arrow, device, down, download, hardware, iOS, mobile, phone, security, tablet, update</summary>
	/// <value>security_update</value>
	SecurityUpdate = 61528,

	/// <summary>Android, OS, checkmark, device, good, hardware, iOS, mobile, ok, phone, security, tablet, tick, update</summary>
	/// <value>security_update_good</value>
	SecurityUpdateGood = 61529,

	/// <summary>!, Android, OS, alert, attention, caution, danger, device, download, error, exclamation, hardware, iOS, important, mark, mobile, notification, phone, security, symbol, tablet, update, warning</summary>
	/// <value>security_update_warning</value>
	SecurityUpdateWarning = 61530,

	/// <summary>alignment, fonts, format, lines, list, paragraph, part, piece, rule, rules, segment, style, text</summary>
	/// <value>segment</value>
	Segment = 59723,

	/// <summary>all, select, selection, square, tool</summary>
	/// <value>select_all</value>
	SelectAll = 57698,

	/// <summary>body, calm, care, chi, human, improvement, meditate, meditation, people, person, relax, self, sitting, wellbeing, yoga, zen</summary>
	/// <value>self_improvement</value>
	SelfImprovement = 60024,

	/// <summary>bill, card, cart, cash, coin, commerce, credit, currency, dollars, money, online, pay, payment, price, sell, shopping, tag</summary>
	/// <value>sell</value>
	Sell = 61531,

	/// <summary>email, mail, message, paper, plane, reply, right, send, share</summary>
	/// <value>send</value>
	Send = 57699,

	/// <summary>archive, arrow, down, download, email, letter, mail, save, send, share</summary>
	/// <value>send_and_archive</value>
	SendAndArchive = 59916,

	/// <summary></summary>
	/// <value>send_time_extension</value>
	SendTimeExtension = 60123,

	/// <summary>Android, OS, arrow, device, export, forward, hardware, iOS, mobile, phone, right, send, share, tablet, to</summary>
	/// <value>send_to_mobile</value>
	SendToMobile = 61532,

	/// <summary></summary>
	/// <value>sensor_door</value>
	SensorDoor = 61877,

	/// <summary></summary>
	/// <value>sensor_window</value>
	SensorWindow = 61876,

	/// <summary>connection, network, scan, sensors, signal, wireless</summary>
	/// <value>sensors</value>
	Sensors = 58654,

	/// <summary>connection, disabled, enabled, network, off, on, scan, sensors, signal, slash, wireless</summary>
	/// <value>sensors_off</value>
	SensorsOff = 58655,

	/// <summary>angry, disappointed, dislike, dissatisfied, emotions, expressions, face, feelings, frown, mood, person, sad, sentiment, survey, unhappy, unsatisfied, upset</summary>
	/// <value>sentiment_dissatisfied</value>
	SentimentDissatisfied = 59409,

	/// <summary>emotionless, emotions, expressions, face, feelings, fine, indifference, mood, neutral, okay, person, sentiment, survey</summary>
	/// <value>sentiment_neutral</value>
	SentimentNeutral = 59410,

	/// <summary>emotions, expressions, face, feelings, glad, happiness, happy, like, mood, person, pleased, satisfied, sentiment, smile, smiling, survey</summary>
	/// <value>sentiment_satisfied</value>
	SentimentSatisfied = 59411,

	/// <summary>account, alt, emoji, face, happy, human, people, person, profile, satisfied, sentiment, smile, user</summary>
	/// <value>sentiment_satisfied_alt</value>
	SentimentSatisfiedAlt = 57581,

	/// <summary>angry, disappointed, dislike, dissatisfied, emotions, expressions, face, feelings, mood, person, sad, sentiment, sorrow, survey, unhappy, unsatisfied, upset, very</summary>
	/// <value>sentiment_very_dissatisfied</value>
	SentimentVeryDissatisfied = 59412,

	/// <summary>emotions, expressions, face, feelings, glad, happiness, happy, like, mood, person, pleased, satisfied, sentiment, smile, smiling, survey, very</summary>
	/// <value>sentiment_very_satisfied</value>
	SentimentVerySatisfied = 59413,

	/// <summary>chopsticks, dinner, fish, food, lunch, meal, restaurant, set, teishoku</summary>
	/// <value>set_meal</value>
	SetMeal = 61930,

	/// <summary>application, change, details, gear, info, information, options, personal, service, settings</summary>
	/// <value>settings</value>
	Settings = 59576,

	/// <summary>accessibility, body, details, human, information, people, person, personal, preferences, profile, settings, user</summary>
	/// <value>settings_accessibility</value>
	SettingsAccessibility = 61533,

	/// <summary>application, change, details, gear, info, information, options, personal, service, settings</summary>
	/// <value>settings_applications</value>
	SettingsApplications = 59577,

	/// <summary>arrow, back, backup, backwards, refresh, restore, reverse, rotate, settings</summary>
	/// <value>settings_backup_restore</value>
	SettingsBackupRestore = 59578,

	/// <summary>bluetooth, connect, connection, connectivity, device, settings, signal, symbol</summary>
	/// <value>settings_bluetooth</value>
	SettingsBluetooth = 59579,

	/// <summary>brightness, dark, filter, light, mode, setting, settings</summary>
	/// <value>settings_brightness</value>
	SettingsBrightness = 59581,

	/// <summary>Android, OS, cell, device, hardware, iOS, mobile, phone, settings, tablet</summary>
	/// <value>settings_cell</value>
	SettingsCell = 59580,

	/// <summary>arrows, computer, connect, connection, connectivity, dots, ethernet, internet, network, settings, wifi</summary>
	/// <value>settings_ethernet</value>
	SettingsEthernet = 59582,

	/// <summary>airplay, antenna, arrows, cast, computer, connect, connection, connectivity, dots, input, internet, network, screencast, settings, stream, wifi, wireless</summary>
	/// <value>settings_input_antenna</value>
	SettingsInputAntenna = 59583,

	/// <summary>audio, av, cable, cables, component, connect, connection, connectivity, input, internet, plug, points, settings, video, wifi</summary>
	/// <value>settings_input_component</value>
	SettingsInputComponent = 59584,

	/// <summary>component, composite, connection, connectivity, input, plug, points, settings</summary>
	/// <value>settings_input_composite</value>
	SettingsInputComposite = 59585,

	/// <summary>cable, connection, connectivity, definition, hdmi, high, input, plug, plugin, points, settings, video, wire</summary>
	/// <value>settings_input_hdmi</value>
	SettingsInputHdmi = 59586,

	/// <summary>cable, connection, connectivity, definition, input, plug, plugin, points, settings, standard, svideo, video</summary>
	/// <value>settings_input_svideo</value>
	SettingsInputSvideo = 59587,

	/// <summary>arrows, expand, image, photo, picture, scan, settings</summary>
	/// <value>settings_overscan</value>
	SettingsOverscan = 59588,

	/// <summary>call, cell, contact, device, hardware, mobile, phone, settings, telephone</summary>
	/// <value>settings_phone</value>
	SettingsPhone = 59589,

	/// <summary>info, information, off, on, power, save, settings, shutdown</summary>
	/// <value>settings_power</value>
	SettingsPower = 59590,

	/// <summary>bluetooth, connection, connectivity, device, remote, settings, signal, wifi, wireless</summary>
	/// <value>settings_remote</value>
	SettingsRemote = 59591,

	/// <summary>change, details, gear, options, recommendation, service, settings, suggest, suggestion, system</summary>
	/// <value>settings_suggest</value>
	SettingsSuggest = 61534,

	/// <summary>backup, cloud, daydream, drive, settings, storage, system</summary>
	/// <value>settings_system_daydream</value>
	SettingsSystemDaydream = 57795,

	/// <summary>mic, microphone, record, recorder, settings, speaker, voice</summary>
	/// <value>settings_voice</value>
	SettingsVoice = 59592,

	/// <summary>android, connect, contect, link, media, multimedia, multiple, network, options, send, share, shared, sharing, social</summary>
	/// <value>share</value>
	Share = 59405,

	/// <summary>destination, direction, gps, location, maps, pin, place, share, stop, tracking</summary>
	/// <value>share_location</value>
	ShareLocation = 61535,

	/// <summary>certified, privacy, private, protect, protection, secure, security, shield, verified</summary>
	/// <value>shield</value>
	Shield = 59872,

	/// <summary></summary>
	/// <value>shield_moon</value>
	ShieldMoon = 60073,

	/// <summary>bag, bill, buy, card, cart, cash, coin, commerce, credit, currency, dollars, google, money, online, pay, payment, play, shop, shopping, store</summary>
	/// <value>shop</value>
	Shop = 59593,

	/// <summary></summary>
	/// <value>shop_2</value>
	Shop2 = 57758,

	/// <summary>add, arrow, buy, cart, google, play, purchase, shop, shopping, two</summary>
	/// <value>shop_two</value>
	ShopTwo = 59594,

	/// <summary>bag, bill, business, buy, card, cart, cash, coin, commerce, credit, currency, dollars, money, online, pay, payment, shop, shopping, store, storefront</summary>
	/// <value>shopping_bag</value>
	ShoppingBag = 61900,

	/// <summary>add, basket, bill, buy, card, cart, cash, checkout, coin, commerce, credit, currency, dollars, money, online, pay, payment, shopping</summary>
	/// <value>shopping_basket</value>
	ShoppingBasket = 59595,

	/// <summary>add, bill, buy, card, cart, cash, checkout, coin, commerce, credit, currency, dollars, money, online, pay, payment, shopping</summary>
	/// <value>shopping_cart</value>
	ShoppingCart = 59596,

	/// <summary></summary>
	/// <value>shopping_cart_checkout</value>
	ShoppingCartCheckout = 60296,

	/// <summary>brief, comment, doc, document, note, short, text, write, writing</summary>
	/// <value>short_text</value>
	ShortText = 57953,

	/// <summary>arrow, direction, forward, right, shortcut</summary>
	/// <value>shortcut</value>
	Shortcut = 61536,

	/// <summary>analytics, bar, bars, chart, data, diagram, graph, infographic, line, measure, metrics, presentation, show chart, statistics, tracking</summary>
	/// <value>show_chart</value>
	ShowChart = 59105,

	/// <summary>bath, bathroom, closet, home, house, place, plumbing, room, shower, sprinkler, wash, water, wc</summary>
	/// <value>shower</value>
	Shower = 61537,

	/// <summary>arrow, arrows, control, controls, music, random, shuffle, video</summary>
	/// <value>shuffle</value>
	Shuffle = 57411,

	/// <summary>arrow, arrows, control, controls, music, on, random, shuffle, video</summary>
	/// <value>shuffle_on</value>
	ShuffleOn = 59873,

	/// <summary>aperture, camera, duration, image, lens, photo, photography, photos, picture, setting, shutter, speed, stop, time, timer, watch</summary>
	/// <value>shutter_speed</value>
	ShutterSpeed = 58429,

	/// <summary>covid, discomfort, emotions, expressions, face, feelings, fever, flu, ill, mood, pain, person, sick, survey, upset</summary>
	/// <value>sick</value>
	Sick = 61984,

	/// <summary>0, bar, cell, cellular, data, internet, mobile, network, phone, signal, speed, wifi, wireless</summary>
	/// <value>signal_cellular_0_bar</value>
	SignalCellular0Bar = 61608,

	/// <summary>4, bar, cell, cellular, data, internet, mobile, network, phone, signal, speed, wifi, wireless</summary>
	/// <value>signal_cellular_4_bar</value>
	SignalCellular4Bar = 57800,

	/// <summary>alt, analytics, bar, cell, cellular, chart, data, diagram, graph, infographic, internet, measure, metrics, mobile, network, phone, signal, statistics, tracking, wifi, wireless</summary>
	/// <value>signal_cellular_alt</value>
	SignalCellularAlt = 57858,

	/// <summary>!, 0, alert, attention, bar, caution, cell, cellular, connected, danger, data, error, exclamation, important, internet, mark, mobile, network, no, notification, phone, signal, symbol, warning, wifi, wireless</summary>
	/// <value>signal_cellular_connected_no_internet_0_bar</value>
	SignalCellularConnectedNoInternet0Bar = 61612,

	/// <summary>!, 4, alert, attention, bar, caution, cell, cellular, connected, danger, data, error, exclamation, important, internet, mark, mobile, network, no, notification, phone, signal, symbol, warning, wifi, wireless</summary>
	/// <value>signal_cellular_connected_no_internet_4_bar</value>
	SignalCellularConnectedNoInternet4Bar = 57805,

	/// <summary>camera, card, cellular, chip, device, disabled, enabled, memory, no, off, offline, on, phone, signal, sim, slash, storage</summary>
	/// <value>signal_cellular_no_sim</value>
	SignalCellularNoSim = 57806,

	/// <summary>cell, cellular, data, internet, mobile, network, no, nodata, offline, phone, quit, signal, wifi, wireless, x</summary>
	/// <value>signal_cellular_nodata</value>
	SignalCellularNodata = 61538,

	/// <summary>cell, cellular, data, internet, mobile, network, null, phone, signal, wifi, wireless</summary>
	/// <value>signal_cellular_null</value>
	SignalCellularNull = 57807,

	/// <summary>cell, cellular, data, disabled, enabled, internet, mobile, network, off, offline, on, phone, signal, slash, wifi, wireless</summary>
	/// <value>signal_cellular_off</value>
	SignalCellularOff = 57808,

	/// <summary>0, bar, cell, cellular, data, internet, mobile, network, phone, signal, wifi, wireless</summary>
	/// <value>signal_wifi_0_bar</value>
	SignalWifi0Bar = 61616,

	/// <summary>4, bar, cell, cellular, data, internet, mobile, network, phone, signal, wifi, wireless</summary>
	/// <value>signal_wifi_4_bar</value>
	SignalWifi4Bar = 57816,

	/// <summary>4, bar, cell, cellular, data, internet, lock, locked, mobile, network, password, phone, privacy, private, protection, safety, secure, security, signal, wifi, wireless</summary>
	/// <value>signal_wifi_4_bar_lock</value>
	SignalWifi4BarLock = 57817,

	/// <summary>bad, bar, cancel, cell, cellular, close, data, exit, internet, mobile, network, no, phone, quit, remove, signal, stop, wifi, wireless, x</summary>
	/// <value>signal_wifi_bad</value>
	SignalWifiBad = 61539,

	/// <summary>4, cell, cellular, connected, data, internet, mobile, network, no, offline, phone, signal, wifi, wireless, x</summary>
	/// <value>signal_wifi_connected_no_internet_4</value>
	SignalWifiConnectedNoInternet4 = 61540,

	/// <summary>cell, cellular, data, disabled, enabled, internet, mobile, network, off, on, phone, signal, slash, speed, wifi, wireless</summary>
	/// <value>signal_wifi_off</value>
	SignalWifiOff = 57818,

	/// <summary>4, bar, cell, cellular, data, internet, mobile, network, phone, signal, speed, statusbar, wifi, wireless</summary>
	/// <value>signal_wifi_statusbar_4_bar</value>
	SignalWifiStatusbar4Bar = 61541,

	/// <summary>!, 4, alert, attention, caution, cell, cellular, connected, danger, data, error, exclamation, important, internet, mark, mobile, network, no, notification, phone, signal, speed, statusbar, symbol, warning, wifi, wireless</summary>
	/// <value>signal_wifi_statusbar_connected_no_internet_4</value>
	SignalWifiStatusbarConnectedNoInternet4 = 61542,

	/// <summary>cell, cellular, data, internet, mobile, network, null, phone, signal, speed, statusbar, wifi, wireless</summary>
	/// <value>signal_wifi_statusbar_null</value>
	SignalWifiStatusbarNull = 61543,

	/// <summary></summary>
	/// <value>signpost</value>
	Signpost = 60305,

	/// <summary>camera, card, chip, device, memory, phone, sim, storage</summary>
	/// <value>sim_card</value>
	SimCard = 58155,

	/// <summary>!, alert, attention, camera, card, caution, danger, digital, error, exclamation, important, mark, memory, notification, photos, sd, secure, storage, symbol, warning</summary>
	/// <value>sim_card_alert</value>
	SimCardAlert = 58916,

	/// <summary>arrow, camera, card, chip, device, down, download, memory, phone, sim, storage</summary>
	/// <value>sim_card_download</value>
	SimCardDownload = 61544,

	/// <summary>bed, bedroom, double, furniture, home, hotel, house, king, night, pillows, queen, rest, room, single, sleep, twin</summary>
	/// <value>single_bed</value>
	SingleBed = 59976,

	/// <summary>alphabet, call, character, dialer, font, initiation, internet, letter, over, phone, protocol, routing, session, sip, symbol, text, type, voice</summary>
	/// <value>sip</value>
	Sip = 61545,

	/// <summary>athlete, athletic, body, entertainment, exercise, hobby, human, people, person, skate, skateboarder, skateboarding, social, sports</summary>
	/// <value>skateboarding</value>
	Skateboarding = 58641,

	/// <summary>arrow, control, controls, forward, music, next, play, previous, skip, transport, video</summary>
	/// <value>skip_next</value>
	SkipNext = 57412,

	/// <summary>arrow, backward, control, controls, music, next, play, previous, skip, transport, video</summary>
	/// <value>skip_previous</value>
	SkipPrevious = 57413,

	/// <summary>athlete, athletic, body, entertainment, exercise, hobby, human, people, person, sled, sledding, sledge, snow, social, sports, travel, winter</summary>
	/// <value>sledding</value>
	Sledding = 58642,

	/// <summary>movie, photos, play, slideshow, square, video, view</summary>
	/// <value>slideshow</value>
	Slideshow = 58395,

	/// <summary>arrow, control, controls, motion, music, play, slow, speed, video</summary>
	/// <value>slow_motion_video</value>
	SlowMotionVideo = 57448,

	/// <summary>action, auto, button, components, composer, function, interface, site, smart, special, stars, ui, ux, web, website</summary>
	/// <value>smart_button</value>
	SmartButton = 61889,

	/// <summary>airplay, cast, chrome, connect, device, display, play, screen, screencast, smart, stream, television, tv, video, wireless</summary>
	/// <value>smart_display</value>
	SmartDisplay = 61546,

	/// <summary>Android, OS, airplay, cast, cell, connect, device, hardware, iOS, mobile, phone, screen, screencast, smart, stream, tablet, video</summary>
	/// <value>smart_screen</value>
	SmartScreen = 61547,

	/// <summary>games, robot, smart, toy</summary>
	/// <value>smart_toy</value>
	SmartToy = 61548,

	/// <summary>Android, OS, call, cell, chat, device, hardware, iOS, mobile, phone, smartphone, tablet, text</summary>
	/// <value>smartphone</value>
	Smartphone = 58156,

	/// <summary>cigarette, disabled, enabled, free, never, no, off, on, places, prohibited, slash, smoke, smoking, tobacco, warning, zone</summary>
	/// <value>smoke_free</value>
	SmokeFree = 60234,

	/// <summary>allowed, cigarette, places, rooms, smoke, smoking, tobacco, zone</summary>
	/// <value>smoking_rooms</value>
	SmokingRooms = 60235,

	/// <summary>3, bubble, chat, communication, conversation, dots, message, more, service, sms, speech, three</summary>
	/// <value>sms</value>
	Sms = 58917,

	/// <summary>!, alert, attention, bubbles, caution, chat, communication, conversation, danger, error, exclamation, failed, important, mark, message, notification, service, sms, speech, symbol, warning</summary>
	/// <value>sms_failed</value>
	SmsFailed = 58918,

	/// <summary>data, doc, document, drive, file, folder, sheet, slide, snippet, storage</summary>
	/// <value>snippet_folder</value>
	SnippetFolder = 61895,

	/// <summary>alarm, bell, clock, duration, notification, snooze, time, timer, watch, z</summary>
	/// <value>snooze</value>
	Snooze = 57414,

	/// <summary>athlete, athletic, body, entertainment, exercise, hobby, human, people, person, snow, snowboarding, social, sports, travel, winter</summary>
	/// <value>snowboarding</value>
	Snowboarding = 58643,

	/// <summary>automobile, car, direction, skimobile, snow, snowmobile, social, sports, transportation, travel, vehicle, winter</summary>
	/// <value>snowmobile</value>
	Snowmobile = 58627,

	/// <summary>body, human, people, person, snow, snowshoe, snowshoeing, sports, travel, winter</summary>
	/// <value>snowshoeing</value>
	Snowshoeing = 58644,

	/// <summary>bathroom, clean, fingers, gesture, hand, soap, wash, wc</summary>
	/// <value>soap</value>
	Soap = 61874,

	/// <summary>6, apart, body, distance, ft, human, people, person, social, space</summary>
	/// <value>social_distance</value>
	SocialDistance = 57803,

	/// <summary>filter, find, lines, list, organize, sort</summary>
	/// <value>sort</value>
	Sort = 57700,

	/// <summary>alphabet, alphabetize, az, by alpha, character, font, letter, list, order, organize, sort, symbol, text, type</summary>
	/// <value>sort_by_alpha</value>
	SortByAlpha = 57427,

	/// <summary></summary>
	/// <value>soup_kitchen</value>
	SoupKitchen = 59347,

	/// <summary>code, composer, content, creation, data, doc, document, file, folder, mode, source, storage, view</summary>
	/// <value>source</value>
	Source = 61892,

	/// <summary>arrow, directional, down, maps, navigation, south</summary>
	/// <value>south</value>
	South = 61923,

	/// <summary></summary>
	/// <value>south_america</value>
	SouthAmerica = 59364,

	/// <summary>arrow, directional, down, east, maps, navigation, right, south</summary>
	/// <value>south_east</value>
	SouthEast = 61924,

	/// <summary>arrow, directional, down, left, maps, navigation, south, west</summary>
	/// <value>south_west</value>
	SouthWest = 61925,

	/// <summary>aromatherapy, flower, healthcare, leaf, massage, meditation, nature, petals, places, relax, spa, wellbeing, wellness</summary>
	/// <value>spa</value>
	Spa = 60236,

	/// <summary>bar, keyboard, line, space</summary>
	/// <value>space_bar</value>
	SpaceBar = 57942,

	/// <summary></summary>
	/// <value>space_dashboard</value>
	SpaceDashboard = 58987,

	/// <summary>box, electronic, loud, music, sound, speaker, stereo, system, video</summary>
	/// <value>speaker</value>
	Speaker = 58157,

	/// <summary>box, electronic, group, loud, multiple, music, sound, speaker, stereo, system, video</summary>
	/// <value>speaker_group</value>
	SpeakerGroup = 58158,

	/// <summary>bubble, chat, comment, communicate, format, list, message, notes, speaker, speech, text</summary>
	/// <value>speaker_notes</value>
	SpeakerNotes = 59597,

	/// <summary>bubble, chat, comment, communicate, disabled, enabled, format, list, message, notes, off, on, slash, speaker, speech, text</summary>
	/// <value>speaker_notes_off</value>
	SpeakerNotesOff = 59690,

	/// <summary>Android, OS, cell, device, hardware, iOS, mobile, phone, sound, speaker, tablet, volume</summary>
	/// <value>speaker_phone</value>
	SpeakerPhone = 57554,

	/// <summary>arrow, control, controls, fast, gauge, meter, motion, music, slow, speed, speedometer, velocity, video</summary>
	/// <value>speed</value>
	Speed = 59876,

	/// <summary>a, alphabet, approve, character, check, font, letter, mark, ok, processor, select, spell, spellcheck, symbol, text, tick, type, word, write, yes</summary>
	/// <value>spellcheck</value>
	Spellcheck = 59598,

	/// <summary>grid, layout, multitasking, screen, split, splitscreen, two</summary>
	/// <value>splitscreen</value>
	Splitscreen = 61549,

	/// <summary></summary>
	/// <value>spoke</value>
	Spoke = 59815,

	/// <summary>athlete, athletic, ball, basketball, blowing, coach, entertainment, exercise, game, hobby, instrument, live, referee, soccer, social, sound, sports, trophy, warning, whistle</summary>
	/// <value>sports</value>
	Sports = 59952,

	/// <summary>alcohol, bar, beer, drink, liquor, pint, places, pub, sports</summary>
	/// <value>sports_bar</value>
	SportsBar = 61939,

	/// <summary>athlete, athletic, ball, baseball, entertainment, exercise, game, hobby, social, sports</summary>
	/// <value>sports_baseball</value>
	SportsBaseball = 59985,

	/// <summary>athlete, athletic, ball, basketball, entertainment, exercise, game, hobby, social, sports</summary>
	/// <value>sports_basketball</value>
	SportsBasketball = 59942,

	/// <summary>athlete, athletic, ball, bat, cricket, entertainment, exercise, game, hobby, social, sports</summary>
	/// <value>sports_cricket</value>
	SportsCricket = 59943,

	/// <summary>controller, entertainment, esports, game, gamepad, gaming, hobby, online, social, sports, video</summary>
	/// <value>sports_esports</value>
	SportsEsports = 59944,

	/// <summary>athlete, athletic, ball, entertainment, exercise, football, game, hobby, social, sports</summary>
	/// <value>sports_football</value>
	SportsFootball = 59945,

	/// <summary>athlete, athletic, ball, club, entertainment, exercise, game, golf, golfer, golfing, hobby, social, sports</summary>
	/// <value>sports_golf</value>
	SportsGolf = 59946,

	/// <summary></summary>
	/// <value>sports_gymnastics</value>
	SportsGymnastics = 60356,

	/// <summary>athlete, athletic, ball, body, entertainment, exercise, game, handball, hobby, human, people, person, social, sports</summary>
	/// <value>sports_handball</value>
	SportsHandball = 59955,

	/// <summary>athlete, athletic, entertainment, exercise, game, hobby, hockey, social, sports, sticks</summary>
	/// <value>sports_hockey</value>
	SportsHockey = 59947,

	/// <summary>athlete, athletic, body, combat, entertainment, exercise, fighting, game, hobby, human, kabaddi, people, person, social, sports, wrestle, wrestling</summary>
	/// <value>sports_kabaddi</value>
	SportsKabaddi = 59956,

	/// <summary></summary>
	/// <value>sports_martial_arts</value>
	SportsMartialArts = 60137,

	/// <summary>arts, athlete, athletic, boxing, combat, entertainment, exercise, fighting, game, glove, hobby, martial, mixed, mma, social, sports</summary>
	/// <value>sports_mma</value>
	SportsMma = 59948,

	/// <summary>athlete, athletic, automobile, bike, drive, driving, entertainment, helmet, hobby, motorcycle, motorsports, protect, social, sports, vehicle</summary>
	/// <value>sports_motorsports</value>
	SportsMotorsports = 59949,

	/// <summary>athlete, athletic, ball, entertainment, exercise, game, hobby, rugby, social, sports</summary>
	/// <value>sports_rugby</value>
	SportsRugby = 59950,

	/// <summary>destination, flag, goal, score, sports</summary>
	/// <value>sports_score</value>
	SportsScore = 61550,

	/// <summary>athlete, athletic, ball, entertainment, exercise, football, game, hobby, soccer, social, sports</summary>
	/// <value>sports_soccer</value>
	SportsSoccer = 59951,

	/// <summary>athlete, athletic, ball, bat, entertainment, exercise, game, hobby, racket, social, sports, tennis</summary>
	/// <value>sports_tennis</value>
	SportsTennis = 59954,

	/// <summary>athlete, athletic, ball, entertainment, exercise, game, hobby, social, sports, volleyball</summary>
	/// <value>sports_volleyball</value>
	SportsVolleyball = 59953,

	/// <summary></summary>
	/// <value>square</value>
	Square = 60214,

	/// <summary>construction, feet, foot, inches, length, measurement, ruler, school, set, square, tools</summary>
	/// <value>square_foot</value>
	SquareFoot = 59977,

	/// <summary></summary>
	/// <value>ssid_chart</value>
	SsidChart = 60262,

	/// <summary>analytics, bar, chart-chart, data, diagram, graph, infographic, measure, metrics, stacked, statistics, tracking</summary>
	/// <value>stacked_bar_chart</value>
	StackedBarChart = 59878,

	/// <summary>analytics, chart, data, diagram, graph, infographic, line, measure, metrics, stacked, statistics, tracking</summary>
	/// <value>stacked_line_chart</value>
	StackedLineChart = 61995,

	/// <summary></summary>
	/// <value>stadium</value>
	Stadium = 60304,

	/// <summary>down, staircase, stairs, up</summary>
	/// <value>stairs</value>
	Stairs = 61865,

	/// <summary>best, bookmark, favorite, highlight, ranking, rate, rating, save, star, toggle</summary>
	/// <value>star</value>
	Star = 59448,

	/// <summary>best, bookmark, border, favorite, highlight, outline, ranking, rate, rating, save, star, toggle</summary>
	/// <value>star_border</value>
	StarBorder = 59450,

	/// <summary>500, best, bookmark, border, favorite, highlight, outline, purple, ranking, rate, rating, save, star, toggle</summary>
	/// <value>star_border_purple500</value>
	StarBorderPurple500 = 61593,

	/// <summary>0.5, 1/2, achievement, bookmark, favorite, half, highlight, important, marked, ranking, rate, rating, rating rank, reward, save, saved, shape, special, star, toggle</summary>
	/// <value>star_half</value>
	StarHalf = 59449,

	/// <summary>bookmark, favorite, half, highlight, ranking, rate, rating, save, star, toggle</summary>
	/// <value>star_outline</value>
	StarOutline = 61551,

	/// <summary>500, best, bookmark, favorite, highlight, purple, ranking, rate, rating, save, star, toggle</summary>
	/// <value>star_purple500</value>
	StarPurple500 = 61594,

	/// <summary>achievement, bookmark, favorite, highlight, important, marked, ranking, rate, rating rank, reward, save, saved, shape, special, star</summary>
	/// <value>star_rate</value>
	StarRate = 61676,

	/// <summary>achievement, bookmark, circle, favorite, highlight, important, marked, ranking, rate, rating rank, reward, save, saved, shape, special, star</summary>
	/// <value>stars</value>
	Stars = 59600,

	/// <summary></summary>
	/// <value>start</value>
	Start = 57481,

	/// <summary>Android, OS, current, device, hardware, iOS, landscape, mobile, phone, stay, tablet</summary>
	/// <value>stay_current_landscape</value>
	StayCurrentLandscape = 57555,

	/// <summary>Android, OS, current, device, hardware, iOS, mobile, phone, portrait, stay, tablet</summary>
	/// <value>stay_current_portrait</value>
	StayCurrentPortrait = 57556,

	/// <summary>Android, OS, current, device, hardware, iOS, landscape, mobile, phone, primary, stay, tablet</summary>
	/// <value>stay_primary_landscape</value>
	StayPrimaryLandscape = 57557,

	/// <summary>Android, OS, current, device, hardware, iOS, mobile, phone, portrait, primary, stay, tablet</summary>
	/// <value>stay_primary_portrait</value>
	StayPrimaryPortrait = 57558,

	/// <summary>2, bookmark, mark, message, note, paper, sticky, text, writing</summary>
	/// <value>sticky_note_2</value>
	StickyNote2 = 61948,

	/// <summary>control, controls, music, pause, play, player, square, stop, video</summary>
	/// <value>stop</value>
	Stop = 57415,

	/// <summary></summary>
	/// <value>stop_circle</value>
	StopCircle = 61297,

	/// <summary>Android, OS, arrow, cast, chrome, device, disabled, display, enabled, hardware, iOS, laptop, mac, mirror, monitor, off, offline, on, screen, share, slash, steam, stop, streaming, web, window</summary>
	/// <value>stop_screen_share</value>
	StopScreenShare = 57571,

	/// <summary>computer, data, drive, memory, storage</summary>
	/// <value>storage</value>
	Storage = 57819,

	/// <summary>bill, building, business, card, cash, coin, commerce, company, credit, currency, dollars, market, money, online, pay, payment, shop, shopping, store, storefront</summary>
	/// <value>store</value>
	Store = 59601,

	/// <summary>directory, mall, store</summary>
	/// <value>store_mall_directory</value>
	StoreMallDirectory = 58723,

	/// <summary>business, buy, cafe, commerce, front, market, places, restaurant, retail, sell, shop, shopping, store, storefront</summary>
	/// <value>storefront</value>
	Storefront = 59922,

	/// <summary>forecast, hurricane, storm, temperature, twister, weather, wind</summary>
	/// <value>storm</value>
	Storm = 61552,

	/// <summary></summary>
	/// <value>straight</value>
	Straight = 60309,

	/// <summary>length, measure, measurement, ruler, size, straighten</summary>
	/// <value>straighten</value>
	Straighten = 58396,

	/// <summary>cast, connected, feed, live, network, signal, stream, wireless</summary>
	/// <value>stream</value>
	Stream = 59881,

	/// <summary>maps, street, streetview, view</summary>
	/// <value>streetview</value>
	Streetview = 58734,

	/// <summary>alphabet, character, cross, doc, edit, editing, editor, font, letter, out, s, sheet, spreadsheet, strikethrough, styles, symbol, text, type, writing</summary>
	/// <value>strikethrough_s</value>
	StrikethroughS = 57943,

	/// <summary>baby, care, carriage, child, children, infant, kid, newborn, stroller, toddler, young</summary>
	/// <value>stroller</value>
	Stroller = 61870,

	/// <summary>booklet, cards, filters, options, style, tags</summary>
	/// <value>style</value>
	Style = 58397,

	/// <summary>arrow, directory, down, left, navigation, sub, subdirectory</summary>
	/// <value>subdirectory_arrow_left</value>
	SubdirectoryArrowLeft = 58841,

	/// <summary>arrow, directory, down, navigation, right, sub, subdirectory</summary>
	/// <value>subdirectory_arrow_right</value>
	SubdirectoryArrowRight = 58842,

	/// <summary>alignment, doc, document, email, full, justify, list, note, subject, text, writing</summary>
	/// <value>subject</value>
	Subject = 59602,

	/// <summary>2, doc, edit, editing, editor, gmail, novitas, sheet, spreadsheet, style, subscript, symbol, text, writing, x</summary>
	/// <value>subscript</value>
	Subscript = 61713,

	/// <summary>enroll, list, media, order, play, signup, subs, subscribe, subscriptions</summary>
	/// <value>subscriptions</value>
	Subscriptions = 57444,

	/// <summary>accessible, caption, cc, character, closed, decoder, language, media, movies, subtitle, subtitles, tv</summary>
	/// <value>subtitles</value>
	Subtitles = 57416,

	/// <summary>accessibility, accessible, caption, cc, closed, disabled, enabled, language, off, on, slash, subtitle, subtitles, translate, video</summary>
	/// <value>subtitles_off</value>
	SubtitlesOff = 61298,

	/// <summary>automobile, bike, car, cars, maps, rail, scooter, subway, train, transportation, travel, tunnel, underground, vehicle, vespa</summary>
	/// <value>subway</value>
	Subway = 58735,

	/// <summary>doc, document, list, menu, note, report, summary</summary>
	/// <value>summarize</value>
	Summarize = 61553,

	/// <summary>2, doc, edit, editing, editor, gmail, novitas, sheet, spreadsheet, style, superscript, symbol, text, writing, x</summary>
	/// <value>superscript</value>
	Superscript = 61714,

	/// <summary>account, avatar, circle, control, face, human, parental, parents, people, person, profile, supervised, supervisor, user</summary>
	/// <value>supervised_user_circle</value>
	SupervisedUserCircle = 59705,

	/// <summary>account, avatar, control, face, human, parental, parental control, parents, people, person, profile, supervised, supervisor, user</summary>
	/// <value>supervisor_account</value>
	SupervisorAccount = 59603,

	/// <summary>assist, buoy, help, life, lifebuoy, rescue, safe, safety, support</summary>
	/// <value>support</value>
	Support = 61299,

	/// <summary>agent, care, customer, face, headphone, person, representative, service, support</summary>
	/// <value>support_agent</value>
	SupportAgent = 61666,

	/// <summary>athlete, athletic, beach, body, entertainment, exercise, hobby, human, people, person, sea, social sports, sports, summer, surfing, water</summary>
	/// <value>surfing</value>
	Surfing = 58645,

	/// <summary>circle, signal, sound, speaker, surround, system, volumn, wireless</summary>
	/// <value>surround_sound</value>
	SurroundSound = 57417,

	/// <summary>arrow, arrows, calls, device, direction, mobile, share, swap</summary>
	/// <value>swap_calls</value>
	SwapCalls = 57559,

	/// <summary>arrow, arrows, back, forward, horizontal, swap</summary>
	/// <value>swap_horiz</value>
	SwapHoriz = 59604,

	/// <summary>arrow, arrows, back, circle, forward, horizontal, swap</summary>
	/// <value>swap_horizontal_circle</value>
	SwapHorizontalCircle = 59699,

	/// <summary>arrow, arrows, direction, down, navigation, swap, up, vert, vertical</summary>
	/// <value>swap_vert</value>
	SwapVert = 59605,

	/// <summary>arrow, arrows, circle, down, swap, up, vertical</summary>
	/// <value>swap_vertical_circle</value>
	SwapVerticalCircle = 59606,

	/// <summary>arrow, arrows, fingers, gesture, hand, hands, swipe, touch</summary>
	/// <value>swipe</value>
	Swipe = 59884,

	/// <summary></summary>
	/// <value>swipe_down</value>
	SwipeDown = 60243,

	/// <summary></summary>
	/// <value>swipe_down_alt</value>
	SwipeDownAlt = 60208,

	/// <summary></summary>
	/// <value>swipe_left</value>
	SwipeLeft = 60249,

	/// <summary></summary>
	/// <value>swipe_left_alt</value>
	SwipeLeftAlt = 60211,

	/// <summary></summary>
	/// <value>swipe_right</value>
	SwipeRight = 60242,

	/// <summary></summary>
	/// <value>swipe_right_alt</value>
	SwipeRightAlt = 60246,

	/// <summary></summary>
	/// <value>swipe_up</value>
	SwipeUp = 60206,

	/// <summary></summary>
	/// <value>swipe_up_alt</value>
	SwipeUpAlt = 60213,

	/// <summary></summary>
	/// <value>swipe_vertical</value>
	SwipeVertical = 60241,

	/// <summary></summary>
	/// <value>switch_access_shortcut</value>
	SwitchAccessShortcut = 59361,

	/// <summary></summary>
	/// <value>switch_access_shortcut_add</value>
	SwitchAccessShortcutAdd = 59362,

	/// <summary>account, choices, face, human, multiple, options, people, person, profile, social, switch, user</summary>
	/// <value>switch_account</value>
	SwitchAccount = 59885,

	/// <summary>arrow, arrows, camera, photo, photography, picture, switch</summary>
	/// <value>switch_camera</value>
	SwitchCamera = 58398,

	/// <summary>arrows, directional, left, navigation, switch, toggle</summary>
	/// <value>switch_left</value>
	SwitchLeft = 61905,

	/// <summary>arrows, directional, navigation, right, switch, toggle</summary>
	/// <value>switch_right</value>
	SwitchRight = 61906,

	/// <summary>arrow, arrows, camera, photography, switch, video, videos</summary>
	/// <value>switch_video</value>
	SwitchVideo = 58399,

	/// <summary></summary>
	/// <value>synagogue</value>
	Synagogue = 60080,

	/// <summary>360, around, arrow, arrows, direction, inprogress, load, loading refresh, renew, rotate, sync, turn</summary>
	/// <value>sync</value>
	Sync = 58919,

	/// <summary>alt, arrow, arrows, horizontal, internet, sync, technology, up, update, wifi</summary>
	/// <value>sync_alt</value>
	SyncAlt = 59928,

	/// <summary>360, around, arrow, arrows, direction, disabled, enabled, inprogress, load, loading refresh, off, on, renew, rotate, slash, sync, turn</summary>
	/// <value>sync_disabled</value>
	SyncDisabled = 58920,

	/// <summary></summary>
	/// <value>sync_lock</value>
	SyncLock = 60142,

	/// <summary>!, 360, alert, around, arrow, arrows, attention, caution, danger, direction, error, exclamation, important, inprogress, load, loading refresh, mark, notification, problem, renew, rotate, symbol, sync, turn, warning</summary>
	/// <value>sync_problem</value>
	SyncProblem = 58921,

	/// <summary>Android, OS, arrow, cell, device, down, hardware, iOS, mobile, phone, security, system, tablet, update</summary>
	/// <value>system_security_update</value>
	SystemSecurityUpdate = 61554,

	/// <summary>Android, OS, approve, cell, check, complete, device, done, good, hardware, iOS, mark, mobile, ok, phone, security, select, system, tablet, tick, update, validate, verified, yes</summary>
	/// <value>system_security_update_good</value>
	SystemSecurityUpdateGood = 61555,

	/// <summary>!, Android, OS, alert, attention, caution, cell, danger, device, error, exclamation, hardware, iOS, important, mark, mobile, notification, phone, security, symbol, system, tablet, update, warning</summary>
	/// <value>system_security_update_warning</value>
	SystemSecurityUpdateWarning = 61556,

	/// <summary>Android, OS, arrow, arrows, cell, device, direction, down, download, hardware, iOS, install, mobile, phone, system, tablet, update</summary>
	/// <value>system_update</value>
	SystemUpdate = 58922,

	/// <summary>arrow, down, download, export, system, update</summary>
	/// <value>system_update_alt</value>
	SystemUpdateAlt = 59607,

	/// <summary>browser, computer, document, documents, folder, internet, tab, tabs, web, website, window, windows</summary>
	/// <value>tab</value>
	Tab = 59608,

	/// <summary>browser, computer, document, documents, folder, internet, tab, tabs, unselected, web, website, window, windows</summary>
	/// <value>tab_unselected</value>
	TabUnselected = 59609,

	/// <summary></summary>
	/// <value>table_bar</value>
	TableBar = 60114,

	/// <summary>analytics, bar, bars, chart, data, diagram, graph, infographic grid, measure, metrics, statistics, table, tracking</summary>
	/// <value>table_chart</value>
	TableChart = 57957,

	/// <summary></summary>
	/// <value>table_restaurant</value>
	TableRestaurant = 60102,

	/// <summary>grid, layout, lines, rows, stacked, table</summary>
	/// <value>table_rows</value>
	TableRows = 61697,

	/// <summary>format, grid, group, layout, multiple, table, view</summary>
	/// <value>table_view</value>
	TableView = 61886,

	/// <summary>Android, OS, device, hardware, iOS, ipad, mobile, tablet, web</summary>
	/// <value>tablet</value>
	Tablet = 58159,

	/// <summary>OS, android, device, hardware, iOS, ipad, mobile, tablet, web</summary>
	/// <value>tablet_android</value>
	TabletAndroid = 58160,

	/// <summary>Android, OS, device, hardware, iOS, ipad, mobile, tablet mac, web</summary>
	/// <value>tablet_mac</value>
	TabletMac = 58161,

	/// <summary>hash, hashtag, key, media, number, pound, social, tag, trend</summary>
	/// <value>tag</value>
	Tag = 59887,

	/// <summary>emoji, emotion, faces, happy, satisfied, smile, tag</summary>
	/// <value>tag_faces</value>
	TagFaces = 58400,

	/// <summary>box, container, delivery, dining, food, meal, restaurant, takeout</summary>
	/// <value>takeout_dining</value>
	TakeoutDining = 60020,

	/// <summary>Android, OS wifi, cell, connection, device, hardware, iOS, internet, mobile, network, phone, play, signal, tablet, tap, to, wireless</summary>
	/// <value>tap_and_play</value>
	TapAndPlay = 58923,

	/// <summary>appetizer, brunch, dinner, food, lunch, restaurant, snack, tapas</summary>
	/// <value>tapas</value>
	Tapas = 61929,

	/// <summary>approve, check, complete, data, doc, document, done, drive, file, folder, folders, mark, ok, page, paper, select, sheet, slide, task, tick, validate, verified, writing, yes</summary>
	/// <value>task</value>
	Task = 61557,

	/// <summary>approve, check, circle, complete, done, mark, ok, select, task, tick, validate, verified, yes</summary>
	/// <value>task_alt</value>
	TaskAlt = 58086,

	/// <summary>!, alert, attention, automobile, cab, car, cars, caution, danger, direction, error, exclamation, important, lyft, maps, mark, notification, public, symbol, taxi, transportation, uber, vehicle, warning, yellow</summary>
	/// <value>taxi_alert</value>
	TaxiAlert = 61300,

	/// <summary></summary>
	/// <value>temple_buddhist</value>
	TempleBuddhist = 60083,

	/// <summary></summary>
	/// <value>temple_hindu</value>
	TempleHindu = 60079,

	/// <summary></summary>
	/// <value>terminal</value>
	Terminal = 60302,

	/// <summary>geography, landscape, mountain, terrain</summary>
	/// <value>terrain</value>
	Terrain = 58724,

	/// <summary></summary>
	/// <value>text_decrease</value>
	TextDecrease = 60125,

	/// <summary>T, add, alphabet, character, field, fields, font, input, letter, symbol, text, type</summary>
	/// <value>text_fields</value>
	TextFields = 57954,

	/// <summary>alphabet, character, font, format, letter, square A, style, symbol, text, type</summary>
	/// <value>text_format</value>
	TextFormat = 57701,

	/// <summary></summary>
	/// <value>text_increase</value>
	TextIncrease = 60130,

	/// <summary>A, alphabet, arrow, character, field, font, letter, move, rotate, symbol, text, type, up</summary>
	/// <value>text_rotate_up</value>
	TextRotateUp = 59706,

	/// <summary>A, alphabet, arrow, character, down, field, font, letter, move, rotate, symbol, text, type, vertical</summary>
	/// <value>text_rotate_vertical</value>
	TextRotateVertical = 59707,

	/// <summary>A, alphabet, angledown, arrow, character, field, font, letter, move, rotate, symbol, text, type</summary>
	/// <value>text_rotation_angledown</value>
	TextRotationAngledown = 59708,

	/// <summary>A, alphabet, angleup, arrow, character, field, font, letter, move, rotate, symbol, text, type</summary>
	/// <value>text_rotation_angleup</value>
	TextRotationAngleup = 59709,

	/// <summary>A, alphabet, arrow, character, dow, field, font, letter, move, rotate, symbol, text, type</summary>
	/// <value>text_rotation_down</value>
	TextRotationDown = 59710,

	/// <summary>A, alphabet, arrow, character, field, font, letter, move, none, rotate, symbol, text, type</summary>
	/// <value>text_rotation_none</value>
	TextRotationNone = 59711,

	/// <summary>data, doc, document, file, note, notes, snippet, storage, text, writing</summary>
	/// <value>text_snippet</value>
	TextSnippet = 61894,

	/// <summary>bubble, chat, comment, communicate, dots, feedback, message, speech, textsms</summary>
	/// <value>textsms</value>
	Textsms = 57560,

	/// <summary>diagonal, lines, pattern, stripes, texture</summary>
	/// <value>texture</value>
	Texture = 58401,

	/// <summary>broadway, comedy, event, movie, musical, places, show, standup, theater, tour, watch</summary>
	/// <value>theater_comedy</value>
	TheaterComedy = 60006,

	/// <summary>film, movie, movies, show, showtimes, theater, theaters, watch</summary>
	/// <value>theaters</value>
	Theaters = 59610,

	/// <summary>forecast, temperature, thermostat, weather</summary>
	/// <value>thermostat</value>
	Thermostat = 61558,

	/// <summary>A, auto, celsius, fahrenheit, meter, temp, temperature, thermometer, thermostat</summary>
	/// <value>thermostat_auto</value>
	ThermostatAuto = 61559,

	/// <summary>ate, dislike, down, downvote, favorite, fingers, gesture, hand, hands, like, rank, ranking, rating, thumb</summary>
	/// <value>thumb_down</value>
	ThumbDown = 59611,

	/// <summary>bad, decline, disapprove, dislike, down, feedback, hate, negative, no, reject, social, thumb, veto, vote</summary>
	/// <value>thumb_down_alt</value>
	ThumbDownAlt = 59414,

	/// <summary>bad, decline, disapprove, dislike, down, feedback, hate, negative, no, reject, sad, social, thumb, veto, vote</summary>
	/// <value>thumb_down_off_alt</value>
	ThumbDownOffAlt = 59890,

	/// <summary>favorite, fingers, gesture, hand, hands, like, rank, ranking, rate, rating, thumb, up, upvote</summary>
	/// <value>thumb_up</value>
	ThumbUp = 59612,

	/// <summary>agreed, approved, confirm, correct, favorite, feedback, good, happy, like, okay, positive, satisfaction, social, thumb, up, vote, yes</summary>
	/// <value>thumb_up_alt</value>
	ThumbUpAlt = 59415,

	/// <summary>agreed, approved, confirm, correct, favorite, feedback, good, happy, like, okay, positive, satisfaction, social, thumb, up, vote, yes</summary>
	/// <value>thumb_up_off_alt</value>
	ThumbUpOffAlt = 59891,

	/// <summary>dislike, down, favorite, fingers, gesture, hands, like, rate, rating, thumbs, up</summary>
	/// <value>thumbs_up_down</value>
	ThumbsUpDown = 59613,

	/// <summary>automobile, car, cars, destination, direction, drive, estimate, eta, maps, public, transportation, travel, trip, vehicle</summary>
	/// <value>time_to_leave</value>
	TimeToLeave = 58924,

	/// <summary>duration, motion, photo, time, timelapse, timer, video</summary>
	/// <value>timelapse</value>
	Timelapse = 58402,

	/// <summary>data, history, line, movement, point, points, timeline, tracking, trending, zigzag</summary>
	/// <value>timeline</value>
	Timeline = 59682,

	/// <summary>alarm, alart, bell, clock, disabled, duration, enabled, notification, off, on, slash, stop, time, timer, watch</summary>
	/// <value>timer</value>
	Timer = 58405,

	/// <summary>10, digits, duration, number, numbers, seconds, time, timer</summary>
	/// <value>timer_10</value>
	Timer10 = 58403,

	/// <summary>10, alphabet, camera, character, digit, font, letter, number, seconds, select, symbol, text, timer, type</summary>
	/// <value>timer_10_select</value>
	Timer10Select = 61562,

	/// <summary>3, digits, duration, number, numbers, seconds, time, timer</summary>
	/// <value>timer_3</value>
	Timer3 = 58404,

	/// <summary>3, alphabet, camera, character, digit, font, letter, number, seconds, select, symbol, text, timer, type</summary>
	/// <value>timer_3_select</value>
	Timer3Select = 61563,

	/// <summary>alarm, alart, bell, clock, disabled, duration, enabled, notification, off, on, slash, stop, time, timer, watch</summary>
	/// <value>timer_off</value>
	TimerOff = 58406,

	/// <summary></summary>
	/// <value>tips_and_updates</value>
	TipsAndUpdates = 59290,

	/// <summary></summary>
	/// <value>tire_repair</value>
	TireRepair = 60360,

	/// <summary>T, alphabet, character, font, header, letter, subject, symbol, text, title, type</summary>
	/// <value>title</value>
	Title = 57956,

	/// <summary>content, format, lines, list, order, reorder, stacked, table, title, titles, toc</summary>
	/// <value>toc</value>
	Toc = 59614,

	/// <summary>calendar, date, day, event, mark, month, remember, reminder, schedule, time, today</summary>
	/// <value>today</value>
	Today = 59615,

	/// <summary>active, app, application, components, configuration, control, design, disable, inable, inactive, interface, off, on, selection, settings, site, slider, switch, toggle, ui, ux, web, website</summary>
	/// <value>toggle_off</value>
	ToggleOff = 59893,

	/// <summary>active, app, application, components, configuration, control, design, disable, inable, inactive, interface, off, on, selection, settings, site, slider, switch, toggle, ui, ux, web, website</summary>
	/// <value>toggle_on</value>
	ToggleOn = 59894,

	/// <summary></summary>
	/// <value>token</value>
	Token = 59941,

	/// <summary>bill, booth, car, card, cash, coin, commerce, credit, currency, dollars, highway, money, online, pay, payment, ticket, toll</summary>
	/// <value>toll</value>
	Toll = 59616,

	/// <summary>circle, edit, editing, filter, image, photography, picture, tonality</summary>
	/// <value>tonality</value>
	Tonality = 58407,

	/// <summary>data, doc, document, drive, file, folder, sheet, slide, storage, topic</summary>
	/// <value>topic</value>
	Topic = 61896,

	/// <summary>app, command, fingers, gesture, hand, press, tap, touch</summary>
	/// <value>touch_app</value>
	TouchApp = 59667,

	/// <summary>destination, flag, places, tour, travel, visit</summary>
	/// <value>tour</value>
	Tour = 61301,

	/// <summary>car, games, kids, toys, windmill</summary>
	/// <value>toys</value>
	Toys = 58162,

	/// <summary>bullseye, changes, circle, evolve, lines, movement, rotate, shift, target, track</summary>
	/// <value>track_changes</value>
	TrackChanges = 59617,

	/// <summary>direction, light, maps, signal, street, traffic</summary>
	/// <value>traffic</value>
	Traffic = 58725,

	/// <summary>automobile, car, cars, direction, maps, public, rail, subway, train, transportation, vehicle</summary>
	/// <value>train</value>
	Train = 58736,

	/// <summary>automobile, car, cars, direction, maps, public, rail, subway, train, tram, transportation, vehicle</summary>
	/// <value>tram</value>
	Tram = 58737,

	/// <summary>a, arrow, arrows, body, direction, human, left, maps, people, person, public, right, route, station, stop, transfer, transportation, vehicle, walk, within</summary>
	/// <value>transfer_within_a_station</value>
	TransferWithinAStation = 58738,

	/// <summary>adjust, crop, edit, editing, image, photo, picture, transform</summary>
	/// <value>transform</value>
	Transform = 58408,

	/// <summary>female, gender, lgbt, male, neutrual, social, transgender</summary>
	/// <value>transgender</value>
	Transgender = 58765,

	/// <summary>arrow, direction, enterexit, maps, navigation, route, transit, transportation</summary>
	/// <value>transit_enterexit</value>
	TransitEnterexit = 58745,

	/// <summary>language, speaking, speech, translate, translator, words</summary>
	/// <value>translate</value>
	Translate = 59618,

	/// <summary>earth, explore, find, glass, global, globe, look, magnify, magnifying, map, network, planet, search, see, social, space, travel, web, world</summary>
	/// <value>travel_explore</value>
	TravelExplore = 58075,

	/// <summary>analytics, arrow, data, diagram, down, graph, infographic, measure, metrics, movement, rate, rating, statistics, tracking, trending</summary>
	/// <value>trending_down</value>
	TrendingDown = 59619,

	/// <summary>arrow, change, data, flat, metric, movement, rate, right, track, tracking, trending</summary>
	/// <value>trending_flat</value>
	TrendingFlat = 59620,

	/// <summary>analytics, arrow, data, diagram, graph, infographic, measure, metrics, movement, rate, rating, statistics, tracking, trending, up</summary>
	/// <value>trending_up</value>
	TrendingUp = 59621,

	/// <summary>circle, departure, origin, trip</summary>
	/// <value>trip_origin</value>
	TripOrigin = 58747,

	/// <summary>bookmark, bubble, chat, comment, communicate, favorite, feedback, highlight, important, marked, message, save, saved, shape, special, speech, star, try</summary>
	/// <value>try</value>
	Try = 61564,

	/// <summary>call, cell, contact, deaf, device, hardware, impaired, mobile, phone, speech, talk, telephone, text, tty</summary>
	/// <value>tty</value>
	Tty = 61866,

	/// <summary>adjust, edit, editing, options, setting, settings, tune</summary>
	/// <value>tune</value>
	Tune = 58409,

	/// <summary>electricity, indoor, lamp, light, lightbulb, setting, tungsten</summary>
	/// <value>tungsten</value>
	Tungsten = 61565,

	/// <summary></summary>
	/// <value>turn_left</value>
	TurnLeft = 60326,

	/// <summary></summary>
	/// <value>turn_right</value>
	TurnRight = 60331,

	/// <summary></summary>
	/// <value>turn_sharp_left</value>
	TurnSharpLeft = 60327,

	/// <summary></summary>
	/// <value>turn_sharp_right</value>
	TurnSharpRight = 60330,

	/// <summary></summary>
	/// <value>turn_slight_left</value>
	TurnSlightLeft = 60324,

	/// <summary></summary>
	/// <value>turn_slight_right</value>
	TurnSlightRight = 60314,

	/// <summary>archive, bookmark, favorite, in, label, library, read, reading, remember, ribbon, save, tag, turned</summary>
	/// <value>turned_in</value>
	TurnedIn = 59622,

	/// <summary>archive, bookmark, favorite, in, label, library, not, read, reading, remember, ribbon, save, tag, turned</summary>
	/// <value>turned_in_not</value>
	TurnedInNot = 59623,

	/// <summary>device, display, linear, living room, monitor, screen, screencast, stream, television, tv, video, wireless</summary>
	/// <value>tv</value>
	Tv = 58163,

	/// <summary>Android, OS, chrome, desktop, device, disabled, enabled, hardware, iOS, mac, monitor, off, on, slash, television, tv, web, window</summary>
	/// <value>tv_off</value>
	TvOff = 58951,

	/// <summary>automobile, bike, car, cars, direction, maps, motorcycle, public, scooter, sport, transportation, travel, twom wheeler, vehicle</summary>
	/// <value>two_wheeler</value>
	TwoWheeler = 59897,

	/// <summary></summary>
	/// <value>u_turn_left</value>
	UTurnLeft = 60321,

	/// <summary></summary>
	/// <value>u_turn_right</value>
	UTurnRight = 60322,

	/// <summary>beach, protection, rain, sun, sunny, umbrella</summary>
	/// <value>umbrella</value>
	Umbrella = 61869,

	/// <summary>archive, arrow, inbox, mail, store, unarchive, undo, up</summary>
	/// <value>unarchive</value>
	Unarchive = 57705,

	/// <summary>arrow, backward, mail, previous, redo, repeat, rotate, undo</summary>
	/// <value>undo</value>
	Undo = 57702,

	/// <summary>arrow, arrows, chevron, collapse, direction, expand, expandable, inward, less, list, navigation, unfold, up</summary>
	/// <value>unfold_less</value>
	UnfoldLess = 58838,

	/// <summary>arrow, arrows, chevron, collapse, direction, down, expand, expandable, list, more, navigation, unfold</summary>
	/// <value>unfold_more</value>
	UnfoldMore = 58839,

	/// <summary>approve, check, circle, complete, disabled, done, enabled, mark, off, ok, on, select, slash, tick, unpublished, validate, verified, yes</summary>
	/// <value>unpublished</value>
	Unpublished = 62006,

	/// <summary>cancel, close, email, envelop, esubscribe, letter, mail, message, newsletter, off, remove, send, unsubscribe</summary>
	/// <value>unsubscribe</value>
	Unsubscribe = 57579,

	/// <summary>alarm, calendar, mail, message, notification, upcoming</summary>
	/// <value>upcoming</value>
	Upcoming = 61566,

	/// <summary>arrow, back, backwards, clock, forward, history, load, refresh, reverse, schedule, time, update</summary>
	/// <value>update</value>
	Update = 59683,

	/// <summary>arrow, back, backwards, clock, date, disabled, enabled, forward, history, load, off, on, refresh, reverse, rotate, schedule, slash, time, update</summary>
	/// <value>update_disabled</value>
	UpdateDisabled = 57461,

	/// <summary>arrow, export, instal, line, replace, up, update, upgrade</summary>
	/// <value>upgrade</value>
	Upgrade = 61691,

	/// <summary>arrow, arrows, download, drive, up, upload</summary>
	/// <value>upload</value>
	Upload = 61595,

	/// <summary>arrow, data, doc, document, download, drive, file, folder, folders, page, paper, sheet, slide, up, upload, writing</summary>
	/// <value>upload_file</value>
	UploadFile = 59900,

	/// <summary>cable, connection, device, usb, wire</summary>
	/// <value>usb</value>
	Usb = 57824,

	/// <summary>cable, connection, device, off, usb, wire</summary>
	/// <value>usb_off</value>
	UsbOff = 58618,

	/// <summary></summary>
	/// <value>vaccines</value>
	Vaccines = 57656,

	/// <summary></summary>
	/// <value>vape_free</value>
	VapeFree = 60358,

	/// <summary></summary>
	/// <value>vaping_rooms</value>
	VapingRooms = 60367,

	/// <summary>approve, badge, burst, check, complete, done, mark, ok, select, star, tick, validate, verified, yes</summary>
	/// <value>verified</value>
	Verified = 61302,

	/// <summary>approve, certified, check, complete, done, mark, ok, privacy, private, protect, protection, security, select, shield, tick, user, validate, verified, yes</summary>
	/// <value>verified_user</value>
	VerifiedUser = 59624,

	/// <summary>align, alignment, arrow, bottom, doc, down, edit, editing, editor, sheet, spreadsheet, text, type, vertical, writing</summary>
	/// <value>vertical_align_bottom</value>
	VerticalAlignBottom = 57944,

	/// <summary>align, alignment, arrow, center, doc, down, edit, editing, editor, sheet, spreadsheet, text, type, up, vertical, writing</summary>
	/// <value>vertical_align_center</value>
	VerticalAlignCenter = 57945,

	/// <summary>align, alignment, arrow, doc, edit, editing, editor, sheet, spreadsheet, text, top, type, up, vertical, writing</summary>
	/// <value>vertical_align_top</value>
	VerticalAlignTop = 57946,

	/// <summary>alignment, distribute, format, layout, lines, paragraph, rule, rules, style, text, vertical</summary>
	/// <value>vertical_distribute</value>
	VerticalDistribute = 57462,

	/// <summary>design, format, grid, layout, paragraph, split, text, vertical, website, writing</summary>
	/// <value>vertical_split</value>
	VerticalSplit = 59721,

	/// <summary>Android, OS, alert, cell, device, hardware, iOS, mobile, mode, motion, notification, phone, silence, silent, tablet, vibrate, vibration</summary>
	/// <value>vibration</value>
	Vibration = 58925,

	/// <summary>+, add, call, camera, chat, conference, film, filming, hardware, image, motion, new, picture, plus, symbol, video, videography</summary>
	/// <value>video_call</value>
	VideoCall = 57456,

	/// <summary>back, camera, image, landscape, mountain, mountains, photo, photography, picture, rear, video</summary>
	/// <value>video_camera_back</value>
	VideoCameraBack = 61567,

	/// <summary>account, camera, face, front, human, image, people, person, photo, photography, picture, profile, user, video</summary>
	/// <value>video_camera_front</value>
	VideoCameraFront = 61568,

	/// <summary></summary>
	/// <value>video_file</value>
	VideoFile = 60295,

	/// <summary>label, screen, video, window</summary>
	/// <value>video_label</value>
	VideoLabel = 57457,

	/// <summary>arrow, collection, library, play, video</summary>
	/// <value>video_library</value>
	VideoLibrary = 57418,

	/// <summary>change, details, gear, info, information, options, play, screen, service, setting, settings, video, window</summary>
	/// <value>video_settings</value>
	VideoSettings = 60021,

	/// <summary>film, filming, recording, setting, stability, stable, taping, video</summary>
	/// <value>video_stable</value>
	VideoStable = 61569,

	/// <summary>cam, camera, conference, film, filming, hardware, image, motion, picture, video, videography</summary>
	/// <value>videocam</value>
	Videocam = 57419,

	/// <summary>cam, camera, conference, disabled, enabled, film, filming, hardware, image, motion, off, offline, on, picture, slash, video, videography</summary>
	/// <value>videocam_off</value>
	VideocamOff = 57420,

	/// <summary>asset, console, controller, device, game, gamepad, gaming, playstation, video</summary>
	/// <value>videogame_asset</value>
	VideogameAsset = 58168,

	/// <summary>asset, console, controller, device, disabled, enabled, game, gamepad, gaming, off, on, playstation, slash, video, videogame</summary>
	/// <value>videogame_asset_off</value>
	VideogameAssetOff = 58624,

	/// <summary>agenda, cards, design, format, grid, layout, stacked, view, website</summary>
	/// <value>view_agenda</value>
	ViewAgenda = 59625,

	/// <summary>array, design, format, grid, layout, view, website</summary>
	/// <value>view_array</value>
	ViewArray = 59626,

	/// <summary>cards, carousel, design, format, grid, layout, view, website</summary>
	/// <value>view_carousel</value>
	ViewCarousel = 59627,

	/// <summary>column, design, format, grid, layout, vertical, view, website</summary>
	/// <value>view_column</value>
	ViewColumn = 59628,

	/// <summary>comfy, grid, layout, pattern, squares, view</summary>
	/// <value>view_comfy</value>
	ViewComfy = 58410,

	/// <summary></summary>
	/// <value>view_comfy_alt</value>
	ViewComfyAlt = 60275,

	/// <summary>compact, grid, layout, pattern, squares, view</summary>
	/// <value>view_compact</value>
	ViewCompact = 58411,

	/// <summary></summary>
	/// <value>view_compact_alt</value>
	ViewCompactAlt = 60276,

	/// <summary></summary>
	/// <value>view_cozy</value>
	ViewCozy = 60277,

	/// <summary>cards, carousel, day, design, format, grid, layout, view, website</summary>
	/// <value>view_day</value>
	ViewDay = 59629,

	/// <summary>design, format, grid, headline, layout, paragraph, text, view, website</summary>
	/// <value>view_headline</value>
	ViewHeadline = 59630,

	/// <summary>3d, ar, augmented, cube, daydream, headset, in, reality, square, view, vr</summary>
	/// <value>view_in_ar</value>
	ViewInAr = 59902,

	/// <summary></summary>
	/// <value>view_kanban</value>
	ViewKanban = 60287,

	/// <summary>design, format, grid, layout, lines, list, stacked, view, website</summary>
	/// <value>view_list</value>
	ViewList = 59631,

	/// <summary>design, format, grid, layout, module, square, squares, stacked, view, website</summary>
	/// <value>view_module</value>
	ViewModule = 59632,

	/// <summary>design, format, grid, layout, quilt, square, squares, stacked, view, website</summary>
	/// <value>view_quilt</value>
	ViewQuilt = 59633,

	/// <summary>design, format, grid, layout, sidebar, view, web</summary>
	/// <value>view_sidebar</value>
	ViewSidebar = 61716,

	/// <summary>design, format, grid, layout, lines, list, stacked, stream, view, website</summary>
	/// <value>view_stream</value>
	ViewStream = 59634,

	/// <summary></summary>
	/// <value>view_timeline</value>
	ViewTimeline = 60293,

	/// <summary>bars, columns, design, format, grid, layout, view, website, week</summary>
	/// <value>view_week</value>
	ViewWeek = 59635,

	/// <summary>border, edit, editing, filter, gradient, image, photo, photography, setting, vignette</summary>
	/// <value>vignette</value>
	Vignette = 58421,

	/// <summary>architecture, beach, estate, home, house, maps, place, real, residence, residential, traveling, vacation stay, villa</summary>
	/// <value>villa</value>
	Villa = 58758,

	/// <summary>eye, on, reveal, see, show, view, visability</summary>
	/// <value>visibility</value>
	Visibility = 59636,

	/// <summary>disabled, enabled, eye, off, on, reveal, see, show, slash, view, visability</summary>
	/// <value>visibility_off</value>
	VisibilityOff = 59637,

	/// <summary>bubble, cam, camera, chat, comment, communicate, facetime, feedback, message, speech, video, voice</summary>
	/// <value>voice_chat</value>
	VoiceChat = 58926,

	/// <summary>account, disabled, enabled, face, human, off, on, over, people, person, profile, recording, slash, speak, speaking, speech, transcript, user, voice</summary>
	/// <value>voice_over_off</value>
	VoiceOverOff = 59722,

	/// <summary>call, device, message, missed, mobile, phone, recording, voice, voicemail</summary>
	/// <value>voicemail</value>
	Voicemail = 57561,

	/// <summary>audio, av, control, down, music, quieter, shh, soft, sound, speaker, tv, volume</summary>
	/// <value>volume_down</value>
	VolumeDown = 57421,

	/// <summary>audio, control, music, mute, sound, speaker, tv, volume</summary>
	/// <value>volume_mute</value>
	VolumeMute = 57422,

	/// <summary>audio, av, control, disabled, enabled, low, music, mute, off, on, slash, sound, speaker, tv, volume</summary>
	/// <value>volume_off</value>
	VolumeOff = 57423,

	/// <summary>audio, control, music, sound, speaker, tv, up, volume</summary>
	/// <value>volume_up</value>
	VolumeUp = 57424,

	/// <summary>activism, donation, fingers, gesture, giving, hand, hands, heart, love, sharing, volunteer</summary>
	/// <value>volunteer_activism</value>
	VolunteerActivism = 60016,

	/// <summary>code, key, lock, network, passcode, password, unlock, vpn</summary>
	/// <value>vpn_key</value>
	VpnKey = 57562,

	/// <summary></summary>
	/// <value>vpn_key_off</value>
	VpnKeyOff = 60282,

	/// <summary>earth, globe, lock, locked, network, password, privacy, private, protection, safety, secure, security, virtual, vpn, world</summary>
	/// <value>vpn_lock</value>
	VpnLock = 58927,

	/// <summary>angle, image, landscape, mountain, mountains, panorama, photo, photography, picture, view, vrpano, wide</summary>
	/// <value>vrpano</value>
	Vrpano = 61570,

	/// <summary>background, image, landscape, photo, photography, picture, wallpaper</summary>
	/// <value>wallpaper</value>
	Wallpaper = 57788,

	/// <summary></summary>
	/// <value>warehouse</value>
	Warehouse = 60344,

	/// <summary>!, alert, attention, caution, danger, error, exclamation, important, mark, notification, symbol, triangle, warning</summary>
	/// <value>warning</value>
	Warning = 57346,

	/// <summary>!, alert, amber, attention, caution, danger, error, exclamation, important, mark, notification, symbol, triangle, warning</summary>
	/// <value>warning_amber</value>
	WarningAmber = 61571,

	/// <summary>bathroom, clean, fingers, gesture, hand, wash, wc</summary>
	/// <value>wash</value>
	Wash = 61873,

	/// <summary>Android, OS, ar, clock, gadget, iOS, time, vr, watch, wearables, web, wristwatch</summary>
	/// <value>watch</value>
	Watch = 58164,

	/// <summary>clock, date, later, schedule, time, watch</summary>
	/// <value>watch_later</value>
	WatchLater = 59684,

	/// <summary></summary>
	/// <value>watch_off</value>
	WatchOff = 60131,

	/// <summary>aqua, beach, lake, ocean, river, water, waves, weather</summary>
	/// <value>water</value>
	Water = 61572,

	/// <summary>architecture, building, damage, drop, droplet, estate, house, leak, plumbing, real, residence, residential, shelter, water</summary>
	/// <value>water_damage</value>
	WaterDamage = 61955,

	/// <summary></summary>
	/// <value>water_drop</value>
	WaterDrop = 59288,

	/// <summary>analytics, bar, chart, data, diagram, graph, infographic, measure, metrics, statistics, tracking, waterfall</summary>
	/// <value>waterfall_chart</value>
	WaterfallChart = 59904,

	/// <summary>beach, lake, ocean, pool, river, sea, swim, water, wave, waves</summary>
	/// <value>waves</value>
	Waves = 57718,

	/// <summary></summary>
	/// <value>waving_hand</value>
	WavingHand = 59238,

	/// <summary>A, W, alphabet, auto, automatic, balance, character, edit, editing, font, image, letter, photo, photography, symbol, text, type, white, wp</summary>
	/// <value>wb_auto</value>
	WbAuto = 58412,

	/// <summary>balance, cloud, cloudy, edit, editing, white, wp</summary>
	/// <value>wb_cloudy</value>
	WbCloudy = 58413,

	/// <summary>balance, bright, edit, editing, incandescent, light, lighting, setting, settings, white, wp</summary>
	/// <value>wb_incandescent</value>
	WbIncandescent = 58414,

	/// <summary>balance, bright, edit, editing, iridescent, light, lighting, setting, settings, white, wp</summary>
	/// <value>wb_iridescent</value>
	WbIridescent = 58422,

	/// <summary>balance, house, light, lighting, shade, wb, white</summary>
	/// <value>wb_shade</value>
	WbShade = 59905,

	/// <summary>balance, bright, light, lighting, sun, sunny, wb, white</summary>
	/// <value>wb_sunny</value>
	WbSunny = 58416,

	/// <summary></summary>
	/// <value>wb_twilight</value>
	WbTwilight = 57798,

	/// <summary>bathroom, closet, female, male, man, restroom, room, wash, water, wc, women</summary>
	/// <value>wc</value>
	Wc = 58941,

	/// <summary>browser, internet, page, screen, site, web, website, www</summary>
	/// <value>web</value>
	Web = 57425,

	/// <summary>-website, app, application desktop, asset, browser, design, download, image, interface, internet, layout, screen, site, ui, ux, video, web, website, window, www</summary>
	/// <value>web_asset</value>
	WebAsset = 57449,

	/// <summary>asset, browser, disabled, enabled, internet, off, on, page, screen, slash, web, webpage, website, windows, www</summary>
	/// <value>web_asset_off</value>
	WebAssetOff = 58615,

	/// <summary></summary>
	/// <value>webhook</value>
	Webhook = 60306,

	/// <summary>chair, couch, furniture, home, living, lounge, relax, room, weekend</summary>
	/// <value>weekend</value>
	Weekend = 57707,

	/// <summary>arrow, directional, left, maps, navigation, west</summary>
	/// <value>west</value>
	West = 61926,

	/// <summary></summary>
	/// <value>whatsapp</value>
	Whatsapp = 60060,

	/// <summary>arrow, circle, direction, fire, frames, hot, round, whatshot</summary>
	/// <value>whatshot</value>
	Whatshot = 59406,

	/// <summary>accessibility, accessible, body, handicap, help, human, person, pickup, wheelchair</summary>
	/// <value>wheelchair_pickup</value>
	WheelchairPickup = 61867,

	/// <summary>approve, ballot, check, complete, destination, direction, done, location, maps, mark, ok, pin, place, poll, select, stop, tick, to, validate election, verified, vote, where, yes</summary>
	/// <value>where_to_vote</value>
	WhereToVote = 57719,

	/// <summary>app, box, menu, setting, squares, ui, widgets</summary>
	/// <value>widgets</value>
	Widgets = 57789,

	/// <summary>connection, data, internet, network, scan, service, signal, wifi, wireless</summary>
	/// <value>wifi</value>
	Wifi = 58942,

	/// <summary>call, calling, cell, connect, connection, connectivity, contact, device, hardware, mobile, phone, signal, telephone, wifi, wireless</summary>
	/// <value>wifi_calling</value>
	WifiCalling = 61303,

	/// <summary>3, calling, cell, cellular, data, internet, mobile, network, phone, speed, wifi, wireless</summary>
	/// <value>wifi_calling_3</value>
	WifiCalling3 = 61573,

	/// <summary></summary>
	/// <value>wifi_channel</value>
	WifiChannel = 60266,

	/// <summary></summary>
	/// <value>wifi_find</value>
	WifiFind = 60209,

	/// <summary>cellular, connection, data, internet, lock, locked, mobile, network, password, privacy, private, protection, safety, secure, security, service, signal, wifi, wireless</summary>
	/// <value>wifi_lock</value>
	WifiLock = 57825,

	/// <summary>connection, data, disabled, enabled, internet, network, off, offline, on, scan, service, signal, slash, wifi, wireless</summary>
	/// <value>wifi_off</value>
	WifiOff = 58952,

	/// <summary></summary>
	/// <value>wifi_password</value>
	WifiPassword = 60267,

	/// <summary>around, arrow, arrows, protected, rotate, setup, wifi</summary>
	/// <value>wifi_protected_setup</value>
	WifiProtectedSetup = 61692,

	/// <summary>cell, cellular, connection, data, internet, mobile, network, phone, scan, service, signal, speed, tethering, wifi, wireless</summary>
	/// <value>wifi_tethering</value>
	WifiTethering = 57826,

	/// <summary></summary>
	/// <value>wifi_tethering_error</value>
	WifiTetheringError = 60121,

	/// <summary>cell, cellular, connection, data, disabled, enabled, internet, mobile, network, off, offline, on, phone, scan, service, signal, slash, speed, tethering, wifi, wireless</summary>
	/// <value>wifi_tethering_off</value>
	WifiTetheringOff = 61575,

	/// <summary>close, glass, grid, home, house, interior, layout, outside, window</summary>
	/// <value>window</value>
	Window = 61576,

	/// <summary>alcohol, bar, cocktail, cup, drink, glass, liquor, wine</summary>
	/// <value>wine_bar</value>
	WineBar = 61928,

	/// <summary></summary>
	/// <value>woman</value>
	Woman = 57662,

	/// <summary>-briefcase, bag, baggage, business, case, job, suitcase, work</summary>
	/// <value>work</value>
	Work = 59641,

	/// <summary>bag, baggage, briefcase, business, case, disabled, enabled, job, off, on, slash, suitcase, work</summary>
	/// <value>work_off</value>
	WorkOff = 59714,

	/// <summary>bag, baggage, briefcase, business, case, job, suitcase, work</summary>
	/// <value>work_outline</value>
	WorkOutline = 59715,

	/// <summary></summary>
	/// <value>workspace_premium</value>
	WorkspacePremium = 59311,

	/// <summary></summary>
	/// <value>workspaces</value>
	Workspaces = 57760,

	/// <summary>arrow writing, doc, edit, editing, editor, sheet, spreadsheet, text, type, wrap, write, writing</summary>
	/// <value>wrap_text</value>
	WrapText = 57947,

	/// <summary>cancel, close, destination, direction, exit, location, maps, no, pin, place, quit, remove, stop, wrong, x</summary>
	/// <value>wrong_location</value>
	WrongLocation = 61304,

	/// <summary>composer, mode, screen, site, software, system, text, view, visibility, web, website, window, wysiwyg</summary>
	/// <value>wysiwyg</value>
	Wysiwyg = 61891,

	/// <summary>backyard, flower, garden, home, house, nature, pettle, plants, yard</summary>
	/// <value>yard</value>
	Yard = 61577,

	/// <summary>arrow, back, backwards, find, glass, history, inprogress, load, loading, look, magnify, magnifying, refresh, renew, restore, reverse, rotate, search, see, yt</summary>
	/// <value>youtube_searched_for</value>
	YoutubeSearchedFor = 59642,

	/// <summary>big, bigger, find, glass, grow, in, look, magnify, magnifying, plus, scale, search, see, size, zoom</summary>
	/// <value>zoom_in</value>
	ZoomIn = 59647,

	/// <summary></summary>
	/// <value>zoom_in_map</value>
	ZoomInMap = 60205,

	/// <summary>find, glass, look, magnify, magnifying, minus, negative, out, scale, search, see, size, small, smaller, zoom</summary>
	/// <value>zoom_out</value>
	ZoomOut = 59648,

	/// <summary>arrow, arrows, destination, location, maps, move, out, place, stop, zoom</summary>
	/// <value>zoom_out_map</value>
	ZoomOutMap = 58731,
}
