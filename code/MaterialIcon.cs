using System.Collections.Generic;

namespace Sandbox
{
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

	public static class MaterialIconUtility
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

			return default;
		}



		static Dictionary<int, string> IconToValue = new()
		{
			{ 59729, "10k" },
			{ 59730, "10mp" },
			{ 59731, "11mp" },
			{ 60301, "123" },
			{ 59732, "12mp" },
			{ 59733, "13mp" },
			{ 59734, "14mp" },
			{ 59735, "15mp" },
			{ 59736, "16mp" },
			{ 59737, "17mp" },
			{ 59738, "18mp" },
			{ 59739, "19mp" },
			{ 59740, "1k" },
			{ 59741, "1k_plus" },
			{ 61389, "1x_mobiledata" },
			{ 59742, "20mp" },
			{ 59743, "21mp" },
			{ 59744, "22mp" },
			{ 59745, "23mp" },
			{ 59746, "24mp" },
			{ 59747, "2k" },
			{ 59748, "2k_plus" },
			{ 59749, "2mp" },
			{ 61390, "30fps" },
			{ 61391, "30fps_select" },
			{ 58743, "360" },
			{ 59469, "3d_rotation" },
			{ 61392, "3g_mobiledata" },
			{ 59750, "3k" },
			{ 59751, "3k_plus" },
			{ 59752, "3mp" },
			{ 61393, "3p" },
			{ 61394, "4g_mobiledata" },
			{ 61395, "4g_plus_mobiledata" },
			{ 57458, "4k" },
			{ 59753, "4k_plus" },
			{ 59754, "4mp" },
			{ 61240, "5g" },
			{ 59755, "5k" },
			{ 59756, "5k_plus" },
			{ 59757, "5mp" },
			{ 61396, "60fps" },
			{ 61397, "60fps_select" },
			{ 61982, "6_ft_apart" },
			{ 59758, "6k" },
			{ 59759, "6k_plus" },
			{ 59760, "6mp" },
			{ 59761, "7k" },
			{ 59762, "7k_plus" },
			{ 59763, "7mp" },
			{ 59764, "8k" },
			{ 59765, "8k_plus" },
			{ 59766, "8mp" },
			{ 59767, "9k" },
			{ 59768, "9k_plus" },
			{ 59769, "9mp" },
			{ 60308, "abc" },
			{ 60219, "ac_unit" },
			{ 57744, "access_alarm" },
			{ 57745, "access_alarms" },
			{ 57746, "access_time" },
			{ 61398, "access_time_filled" },
			{ 59470, "accessibility" },
			{ 59692, "accessibility_new" },
			{ 59668, "accessible" },
			{ 59700, "accessible_forward" },
			{ 59471, "account_balance" },
			{ 59472, "account_balance_wallet" },
			{ 59473, "account_box" },
			{ 59475, "account_circle" },
			{ 59770, "account_tree" },
			{ 61241, "ad_units" },
			{ 58894, "adb" },
			{ 57669, "add" },
			{ 58425, "add_a_photo" },
			{ 57747, "add_alarm" },
			{ 57347, "add_alert" },
			{ 57670, "add_box" },
			{ 59177, "add_business" },
			{ 60294, "add_card" },
			{ 59771, "add_chart" },
			{ 57671, "add_circle" },
			{ 57672, "add_circle_outline" },
			{ 57958, "add_comment" },
			{ 59772, "add_ic_call" },
			{ 57720, "add_link" },
			{ 58727, "add_location" },
			{ 61242, "add_location_alt" },
			{ 59773, "add_moderator" },
			{ 58430, "add_photo_alternate" },
			{ 57811, "add_reaction" },
			{ 61243, "add_road" },
			{ 59476, "add_shopping_cart" },
			{ 62010, "add_task" },
			{ 58972, "add_to_drive" },
			{ 57854, "add_to_home_screen" },
			{ 58269, "add_to_photos" },
			{ 57436, "add_to_queue" },
			{ 61244, "addchart" },
			{ 60122, "adf_scanner" },
			{ 58270, "adjust" },
			{ 61245, "admin_panel_settings" },
			{ 59234, "ads_click" },
			{ 60025, "agriculture" },
			{ 61400, "air" },
			{ 58928, "airline_seat_flat" },
			{ 58929, "airline_seat_flat_angled" },
			{ 58930, "airline_seat_individual_suite" },
			{ 58931, "airline_seat_legroom_extra" },
			{ 58932, "airline_seat_legroom_normal" },
			{ 58933, "airline_seat_legroom_reduced" },
			{ 58934, "airline_seat_recline_extra" },
			{ 58935, "airline_seat_recline_normal" },
			{ 59344, "airline_stops" },
			{ 59338, "airlines" },
			{ 61401, "airplane_ticket" },
			{ 57749, "airplanemode_active" },
			{ 57748, "airplanemode_inactive" },
			{ 57429, "airplay" },
			{ 60220, "airport_shuttle" },
			{ 59477, "alarm" },
			{ 59478, "alarm_add" },
			{ 59479, "alarm_off" },
			{ 59480, "alarm_on" },
			{ 57369, "album" },
			{ 57359, "align_horizontal_center" },
			{ 57357, "align_horizontal_left" },
			{ 57360, "align_horizontal_right" },
			{ 57365, "align_vertical_bottom" },
			{ 57361, "align_vertical_center" },
			{ 57356, "align_vertical_top" },
			{ 59775, "all_inbox" },
			{ 60221, "all_inclusive" },
			{ 59659, "all_out" },
			{ 61828, "alt_route" },
			{ 57574, "alternate_email" },
			{ 61246, "analytics" },
			{ 61901, "anchor" },
			{ 59481, "android" },
			{ 59164, "animation" },
			{ 59482, "announcement" },
			{ 61402, "aod" },
			{ 59968, "apartment" },
			{ 61879, "api" },
			{ 61247, "app_blocking" },
			{ 61248, "app_registration" },
			{ 61249, "app_settings_alt" },
			{ 60132, "app_shortcut" },
			{ 59778, "approval" },
			{ 58819, "apps" },
			{ 59340, "apps_outage" },
			{ 59963, "architecture" },
			{ 57673, "archive" },
			{ 59248, "area_chart" },
			{ 58820, "arrow_back" },
			{ 58848, "arrow_back_ios" },
			{ 58090, "arrow_back_ios_new" },
			{ 61825, "arrow_circle_down" },
			{ 60071, "arrow_circle_left" },
			{ 60074, "arrow_circle_right" },
			{ 61826, "arrow_circle_up" },
			{ 58843, "arrow_downward" },
			{ 58821, "arrow_drop_down" },
			{ 58822, "arrow_drop_down_circle" },
			{ 58823, "arrow_drop_up" },
			{ 58824, "arrow_forward" },
			{ 58849, "arrow_forward_ios" },
			{ 58846, "arrow_left" },
			{ 58847, "arrow_right" },
			{ 59713, "arrow_right_alt" },
			{ 58840, "arrow_upward" },
			{ 57440, "art_track" },
			{ 61250, "article" },
			{ 59483, "aspect_ratio" },
			{ 59484, "assessment" },
			{ 59485, "assignment" },
			{ 59486, "assignment_ind" },
			{ 59487, "assignment_late" },
			{ 59488, "assignment_return" },
			{ 59489, "assignment_returned" },
			{ 59490, "assignment_turned_in" },
			{ 58271, "assistant" },
			{ 59784, "assistant_direction" },
			{ 58272, "assistant_photo" },
			{ 60271, "assured_workload" },
			{ 58739, "atm" },
			{ 59998, "attach_email" },
			{ 57894, "attach_file" },
			{ 57895, "attach_money" },
			{ 58044, "attachment" },
			{ 59986, "attractions" },
			{ 61403, "attribution" },
			{ 60290, "audio_file" },
			{ 58273, "audiotrack" },
			{ 58975, "auto_awesome" },
			{ 58976, "auto_awesome_mosaic" },
			{ 58977, "auto_awesome_motion" },
			{ 59980, "auto_delete" },
			{ 58979, "auto_fix_high" },
			{ 58980, "auto_fix_normal" },
			{ 58981, "auto_fix_off" },
			{ 58619, "auto_graph" },
			{ 58982, "auto_stories" },
			{ 61404, "autofps_select" },
			{ 59491, "autorenew" },
			{ 57371, "av_timer" },
			{ 61851, "baby_changing_station" },
			{ 59236, "back_hand" },
			{ 61852, "backpack" },
			{ 57674, "backspace" },
			{ 59492, "backup" },
			{ 61251, "backup_table" },
			{ 60007, "badge" },
			{ 59987, "bakery_dining" },
			{ 60150, "balance" },
			{ 58767, "balcony" },
			{ 57714, "ballot" },
			{ 57963, "bar_chart" },
			{ 61685, "batch_prediction" },
			{ 61405, "bathroom" },
			{ 59969, "bathtub" },
			{ 57756, "battery_alert" },
			{ 57763, "battery_charging_full" },
			{ 57764, "battery_full" },
			{ 61406, "battery_saver" },
			{ 57765, "battery_std" },
			{ 57766, "battery_unknown" },
			{ 60222, "beach_access" },
			{ 61407, "bed" },
			{ 61408, "bedroom_baby" },
			{ 61409, "bedroom_child" },
			{ 61410, "bedroom_parent" },
			{ 61252, "bedtime" },
			{ 60278, "bedtime_off" },
			{ 58669, "beenhere" },
			{ 61940, "bento" },
			{ 61253, "bike_scooter" },
			{ 59962, "biotech" },
			{ 61411, "blender" },
			{ 57675, "block" },
			{ 61412, "bloodtype" },
			{ 57767, "bluetooth" },
			{ 58895, "bluetooth_audio" },
			{ 57768, "bluetooth_connected" },
			{ 57769, "bluetooth_disabled" },
			{ 61413, "bluetooth_drive" },
			{ 57770, "bluetooth_searching" },
			{ 58274, "blur_circular" },
			{ 58275, "blur_linear" },
			{ 58276, "blur_off" },
			{ 58277, "blur_on" },
			{ 59915, "bolt" },
			{ 59493, "book" },
			{ 61975, "book_online" },
			{ 59494, "bookmark" },
			{ 58776, "bookmark_add" },
			{ 58777, "bookmark_added" },
			{ 59495, "bookmark_border" },
			{ 58778, "bookmark_remove" },
			{ 59787, "bookmarks" },
			{ 57896, "border_all" },
			{ 57897, "border_bottom" },
			{ 57898, "border_clear" },
			{ 57899, "border_color" },
			{ 57900, "border_horizontal" },
			{ 57901, "border_inner" },
			{ 57902, "border_left" },
			{ 57903, "border_outer" },
			{ 57904, "border_right" },
			{ 57905, "border_style" },
			{ 57906, "border_top" },
			{ 57907, "border_vertical" },
			{ 60263, "boy" },
			{ 57451, "branding_watermark" },
			{ 59988, "breakfast_dining" },
			{ 58278, "brightness_1" },
			{ 58279, "brightness_2" },
			{ 58280, "brightness_3" },
			{ 58281, "brightness_4" },
			{ 58282, "brightness_5" },
			{ 58283, "brightness_6" },
			{ 58284, "brightness_7" },
			{ 57771, "brightness_auto" },
			{ 57772, "brightness_high" },
			{ 57773, "brightness_low" },
			{ 57774, "brightness_medium" },
			{ 58285, "broken_image" },
			{ 60369, "browse_gallery" },
			{ 61255, "browser_not_supported" },
			{ 59343, "browser_updated" },
			{ 60019, "brunch_dining" },
			{ 58286, "brush" },
			{ 59101, "bubble_chart" },
			{ 59496, "bug_report" },
			{ 59497, "build" },
			{ 61256, "build_circle" },
			{ 58769, "bungalow" },
			{ 58428, "burst_mode" },
			{ 59791, "bus_alert" },
			{ 57519, "business" },
			{ 60223, "business_center" },
			{ 58761, "cabin" },
			{ 61414, "cable" },
			{ 59498, "cached" },
			{ 59369, "cake" },
			{ 59999, "calculate" },
			{ 60364, "calendar_month" },
			{ 59701, "calendar_today" },
			{ 59702, "calendar_view_day" },
			{ 61415, "calendar_view_month" },
			{ 61416, "calendar_view_week" },
			{ 57520, "call" },
			{ 57521, "call_end" },
			{ 57522, "call_made" },
			{ 57523, "call_merge" },
			{ 57524, "call_missed" },
			{ 57572, "call_missed_outgoing" },
			{ 57525, "call_received" },
			{ 57526, "call_split" },
			{ 57452, "call_to_action" },
			{ 58287, "camera" },
			{ 58288, "camera_alt" },
			{ 59644, "camera_enhance" },
			{ 58289, "camera_front" },
			{ 61417, "camera_indoor" },
			{ 61418, "camera_outdoor" },
			{ 58290, "camera_rear" },
			{ 58291, "camera_roll" },
			{ 61419, "cameraswitch" },
			{ 61257, "campaign" },
			{ 58825, "cancel" },
			{ 57577, "cancel_presentation" },
			{ 59961, "cancel_schedule_send" },
			{ 60116, "candlestick_chart" },
			{ 59989, "car_rental" },
			{ 59990, "car_repair" },
			{ 59638, "card_giftcard" },
			{ 59639, "card_membership" },
			{ 59640, "card_travel" },
			{ 61944, "carpenter" },
			{ 59794, "cases" },
			{ 60224, "casino" },
			{ 58119, "cast" },
			{ 58120, "cast_connected" },
			{ 61420, "cast_for_education" },
			{ 60081, "castle" },
			{ 58632, "catching_pokemon" },
			{ 58740, "category" },
			{ 60005, "celebration" },
			{ 60346, "cell_tower" },
			{ 57580, "cell_wifi" },
			{ 58292, "center_focus_strong" },
			{ 58293, "center_focus_weak" },
			{ 61421, "chair" },
			{ 61422, "chair_alt" },
			{ 58757, "chalet" },
			{ 58087, "change_circle" },
			{ 59499, "change_history" },
			{ 61853, "charging_station" },
			{ 57527, "chat" },
			{ 57546, "chat_bubble" },
			{ 57547, "chat_bubble_outline" },
			{ 58826, "check" },
			{ 59444, "check_box" },
			{ 59445, "check_box_outline_blank" },
			{ 59500, "check_circle" },
			{ 59693, "check_circle_outline" },
			{ 59057, "checklist" },
			{ 59059, "checklist_rtl" },
			{ 61854, "checkroom" },
			{ 58827, "chevron_left" },
			{ 58828, "chevron_right" },
			{ 60225, "child_care" },
			{ 60226, "child_friendly" },
			{ 59501, "chrome_reader_mode" },
			{ 60078, "church" },
			{ 61258, "circle" },
			{ 59796, "circle_notifications" },
			{ 59502, "class" },
			{ 61983, "clean_hands" },
			{ 61695, "cleaning_services" },
			{ 57676, "clear" },
			{ 57528, "clear_all" },
			{ 58829, "close" },
			{ 61903, "close_fullscreen" },
			{ 57372, "closed_caption" },
			{ 61916, "closed_caption_disabled" },
			{ 59798, "closed_caption_off" },
			{ 58045, "cloud" },
			{ 58046, "cloud_circle" },
			{ 58047, "cloud_done" },
			{ 58048, "cloud_download" },
			{ 58049, "cloud_off" },
			{ 58050, "cloud_queue" },
			{ 60250, "cloud_sync" },
			{ 58051, "cloud_upload" },
			{ 59312, "co2" },
			{ 60144, "co_present" },
			{ 59503, "code" },
			{ 58611, "code_off" },
			{ 61423, "coffee" },
			{ 61424, "coffee_maker" },
			{ 58294, "collections" },
			{ 58417, "collections_bookmark" },
			{ 58295, "color_lens" },
			{ 58296, "colorize" },
			{ 57529, "comment" },
			{ 59982, "comment_bank" },
			{ 59298, "comments_disabled" },
			{ 60149, "commit" },
			{ 59712, "commute" },
			{ 58297, "compare" },
			{ 59669, "compare_arrows" },
			{ 58748, "compass_calibration" },
			{ 59233, "compost" },
			{ 59725, "compress" },
			{ 58122, "computer" },
			{ 58936, "confirmation_number" },
			{ 61987, "connect_without_contact" },
			{ 59800, "connected_tv" },
			{ 59337, "connecting_airports" },
			{ 59964, "construction" },
			{ 57552, "contact_mail" },
			{ 61998, "contact_page" },
			{ 57551, "contact_phone" },
			{ 59724, "contact_support" },
			{ 60017, "contactless" },
			{ 57530, "contacts" },
			{ 57677, "content_copy" },
			{ 57678, "content_cut" },
			{ 57679, "content_paste" },
			{ 60046, "content_paste_go" },
			{ 58616, "content_paste_off" },
			{ 60059, "content_paste_search" },
			{ 60215, "contrast" },
			{ 57460, "control_camera" },
			{ 58298, "control_point" },
			{ 58299, "control_point_duplicate" },
			{ 60076, "cookie" },
			{ 58092, "copy_all" },
			{ 59660, "copyright" },
			{ 61985, "coronavirus" },
			{ 61904, "corporate_fare" },
			{ 58759, "cottage" },
			{ 61943, "countertops" },
			{ 57680, "create" },
			{ 58060, "create_new_folder" },
			{ 59504, "credit_card" },
			{ 58612, "credit_card_off" },
			{ 61425, "credit_score" },
			{ 58760, "crib" },
			{ 58302, "crop" },
			{ 58300, "crop_16_9" },
			{ 58301, "crop_3_2" },
			{ 58303, "crop_5_4" },
			{ 58304, "crop_7_5" },
			{ 58305, "crop_din" },
			{ 58306, "crop_free" },
			{ 58307, "crop_landscape" },
			{ 58308, "crop_original" },
			{ 58309, "crop_portrait" },
			{ 58423, "crop_rotate" },
			{ 58310, "crop_square" },
			{ 59289, "cruelty_free" },
			{ 60307, "css" },
			{ 60357, "currency_bitcoin" },
			{ 60272, "currency_exchange" },
			{ 60154, "currency_franc" },
			{ 60143, "currency_lira" },
			{ 60145, "currency_pound" },
			{ 60140, "currency_ruble" },
			{ 60151, "currency_rupee" },
			{ 60155, "currency_yen" },
			{ 60153, "currency_yuan" },
			{ 59802, "dangerous" },
			{ 58652, "dark_mode" },
			{ 59505, "dashboard" },
			{ 59803, "dashboard_customize" },
			{ 60113, "data_array" },
			{ 59247, "data_exploration" },
			{ 60115, "data_object" },
			{ 61426, "data_saver_off" },
			{ 61427, "data_saver_on" },
			{ 60319, "data_thresholding" },
			{ 57775, "data_usage" },
			{ 59670, "date_range" },
			{ 60279, "deblur" },
			{ 59970, "deck" },
			{ 58311, "dehaze" },
			{ 59506, "delete" },
			{ 59691, "delete_forever" },
			{ 59694, "delete_outline" },
			{ 57708, "delete_sweep" },
			{ 60018, "delivery_dining" },
			{ 60329, "density_large" },
			{ 60318, "density_medium" },
			{ 60328, "density_small" },
			{ 58742, "departure_board" },
			{ 59507, "description" },
			{ 60342, "deselect" },
			{ 61706, "design_services" },
			{ 59805, "desktop_access_disabled" },
			{ 58123, "desktop_mac" },
			{ 58124, "desktop_windows" },
			{ 58312, "details" },
			{ 58125, "developer_board" },
			{ 58623, "developer_board_off" },
			{ 57776, "developer_mode" },
			{ 58165, "device_hub" },
			{ 57855, "device_thermostat" },
			{ 58169, "device_unknown" },
			{ 57777, "devices" },
			{ 58167, "devices_other" },
			{ 57531, "dialer_sip" },
			{ 57532, "dialpad" },
			{ 60117, "diamond" },
			{ 60285, "difference" },
			{ 61428, "dining" },
			{ 59991, "dinner_dining" },
			{ 58670, "directions" },
			{ 58671, "directions_bike" },
			{ 58674, "directions_boat" },
			{ 61429, "directions_boat_filled" },
			{ 58672, "directions_bus" },
			{ 61430, "directions_bus_filled" },
			{ 58673, "directions_car" },
			{ 61431, "directions_car_filled" },
			{ 61711, "directions_off" },
			{ 58676, "directions_railway" },
			{ 61432, "directions_railway_filled" },
			{ 58726, "directions_run" },
			{ 58675, "directions_subway" },
			{ 61433, "directions_subway_filled" },
			{ 58677, "directions_transit" },
			{ 61434, "directions_transit_filled" },
			{ 58678, "directions_walk" },
			{ 61259, "dirty_lens" },
			{ 62000, "disabled_by_default" },
			{ 59246, "disabled_visible" },
			{ 58896, "disc_full" },
			{ 60361, "discount" },
			{ 60311, "display_settings" },
			{ 59509, "dns" },
			{ 61580, "do_disturb" },
			{ 61581, "do_disturb_alt" },
			{ 61582, "do_disturb_off" },
			{ 61583, "do_disturb_on" },
			{ 58898, "do_not_disturb" },
			{ 58897, "do_not_disturb_alt" },
			{ 58947, "do_not_disturb_off" },
			{ 58948, "do_not_disturb_on" },
			{ 61435, "do_not_disturb_on_total_silence" },
			{ 61855, "do_not_step" },
			{ 61872, "do_not_touch" },
			{ 58126, "dock" },
			{ 58874, "document_scanner" },
			{ 59374, "domain" },
			{ 60258, "domain_add" },
			{ 57583, "domain_disabled" },
			{ 61260, "domain_verification" },
			{ 59510, "done" },
			{ 59511, "done_all" },
			{ 59695, "done_outline" },
			{ 59671, "donut_large" },
			{ 59672, "donut_small" },
			{ 61436, "door_back" },
			{ 61437, "door_front" },
			{ 61438, "door_sliding" },
			{ 61439, "doorbell" },
			{ 59984, "double_arrow" },
			{ 58633, "downhill_skiing" },
			{ 61584, "download" },
			{ 61585, "download_done" },
			{ 61440, "download_for_offline" },
			{ 61441, "downloading" },
			{ 57681, "drafts" },
			{ 57949, "drag_handle" },
			{ 59717, "drag_indicator" },
			{ 59206, "draw" },
			{ 58899, "drive_eta" },
			{ 58997, "drive_file_move" },
			{ 59245, "drive_file_move_rtl" },
			{ 59810, "drive_file_rename_outline" },
			{ 59811, "drive_folder_upload" },
			{ 61875, "dry" },
			{ 59992, "dry_cleaning" },
			{ 59813, "duo" },
			{ 57778, "dvr" },
			{ 59924, "dynamic_feed" },
			{ 61887, "dynamic_form" },
			{ 61442, "e_mobiledata" },
			{ 61443, "earbuds" },
			{ 61444, "earbuds_battery" },
			{ 61919, "east" },
			{ 61445, "edgesensor_high" },
			{ 61446, "edgesensor_low" },
			{ 58313, "edit" },
			{ 58744, "edit_attributes" },
			{ 59202, "edit_calendar" },
			{ 58728, "edit_location" },
			{ 57797, "edit_location_alt" },
			{ 59205, "edit_note" },
			{ 58661, "edit_notifications" },
			{ 59728, "edit_off" },
			{ 61261, "edit_road" },
			{ 60108, "egg" },
			{ 60104, "egg_alt" },
			{ 59643, "eject" },
			{ 61978, "elderly" },
			{ 60265, "elderly_woman" },
			{ 60187, "electric_bike" },
			{ 60188, "electric_car" },
			{ 60189, "electric_moped" },
			{ 60190, "electric_rickshaw" },
			{ 60191, "electric_scooter" },
			{ 61698, "electrical_services" },
			{ 61856, "elevator" },
			{ 57534, "email" },
			{ 57835, "emergency" },
			{ 59938, "emoji_emotions" },
			{ 59939, "emoji_events" },
			{ 59931, "emoji_food_beverage" },
			{ 59932, "emoji_nature" },
			{ 59940, "emoji_objects" },
			{ 59933, "emoji_people" },
			{ 59934, "emoji_symbols" },
			{ 59935, "emoji_transportation" },
			{ 59965, "engineering" },
			{ 58943, "enhanced_encryption" },
			{ 57373, "equalizer" },
			{ 57344, "error" },
			{ 57345, "error_outline" },
			{ 61857, "escalator" },
			{ 61868, "escalator_warning" },
			{ 59925, "euro" },
			{ 59686, "euro_symbol" },
			{ 58733, "ev_station" },
			{ 59512, "event" },
			{ 58900, "event_available" },
			{ 58901, "event_busy" },
			{ 58902, "event_note" },
			{ 60283, "event_repeat" },
			{ 59651, "event_seat" },
			{ 59513, "exit_to_app" },
			{ 59727, "expand" },
			{ 59341, "expand_circle_down" },
			{ 58830, "expand_less" },
			{ 58831, "expand_more" },
			{ 57374, "explicit" },
			{ 59514, "explore" },
			{ 59816, "explore_off" },
			{ 58314, "exposure" },
			{ 58315, "exposure_neg_1" },
			{ 58316, "exposure_neg_2" },
			{ 58317, "exposure_plus_1" },
			{ 58318, "exposure_plus_2" },
			{ 58319, "exposure_zero" },
			{ 59515, "extension" },
			{ 58613, "extension_off" },
			{ 59516, "face" },
			{ 61262, "face_retouching_natural" },
			{ 61447, "face_retouching_off" },
			{ 61637, "fact_check" },
			{ 60348, "factory" },
			{ 61858, "family_restroom" },
			{ 57375, "fast_forward" },
			{ 57376, "fast_rewind" },
			{ 58746, "fastfood" },
			{ 59517, "favorite" },
			{ 59518, "favorite_border" },
			{ 60120, "fax" },
			{ 57453, "featured_play_list" },
			{ 57454, "featured_video" },
			{ 61449, "feed" },
			{ 59519, "feedback" },
			{ 58768, "female" },
			{ 61942, "fence" },
			{ 60008, "festival" },
			{ 57437, "fiber_dvr" },
			{ 57441, "fiber_manual_record" },
			{ 57438, "fiber_new" },
			{ 57450, "fiber_pin" },
			{ 57442, "fiber_smart_record" },
			{ 57715, "file_copy" },
			{ 58052, "file_download" },
			{ 59818, "file_download_done" },
			{ 58622, "file_download_off" },
			{ 60147, "file_open" },
			{ 59918, "file_present" },
			{ 58054, "file_upload" },
			{ 58323, "filter" },
			{ 58320, "filter_1" },
			{ 58321, "filter_2" },
			{ 58322, "filter_3" },
			{ 58324, "filter_4" },
			{ 58325, "filter_5" },
			{ 58326, "filter_6" },
			{ 58327, "filter_7" },
			{ 58328, "filter_8" },
			{ 58329, "filter_9" },
			{ 58330, "filter_9_plus" },
			{ 61263, "filter_alt" },
			{ 60210, "filter_alt_off" },
			{ 58331, "filter_b_and_w" },
			{ 58332, "filter_center_focus" },
			{ 58333, "filter_drama" },
			{ 58334, "filter_frames" },
			{ 58335, "filter_hdr" },
			{ 57682, "filter_list" },
			{ 60247, "filter_list_off" },
			{ 58336, "filter_none" },
			{ 58338, "filter_tilt_shift" },
			{ 58339, "filter_vintage" },
			{ 59520, "find_in_page" },
			{ 59521, "find_replace" },
			{ 59661, "fingerprint" },
			{ 61912, "fire_extinguisher" },
			{ 59971, "fireplace" },
			{ 58844, "first_page" },
			{ 59920, "fit_screen" },
			{ 59435, "fitbit" },
			{ 60227, "fitness_center" },
			{ 57683, "flag" },
			{ 60152, "flag_circle" },
			{ 61264, "flaky" },
			{ 58340, "flare" },
			{ 58341, "flash_auto" },
			{ 58342, "flash_off" },
			{ 58343, "flash_on" },
			{ 61450, "flashlight_off" },
			{ 61451, "flashlight_on" },
			{ 61452, "flatware" },
			{ 58681, "flight" },
			{ 59339, "flight_class" },
			{ 59652, "flight_land" },
			{ 59653, "flight_takeoff" },
			{ 58344, "flip" },
			{ 59959, "flip_camera_android" },
			{ 59960, "flip_camera_ios" },
			{ 59522, "flip_to_back" },
			{ 59523, "flip_to_front" },
			{ 61453, "flourescent" },
			{ 57355, "flutter_dash" },
			{ 61454, "fmd_bad" },
			{ 61455, "fmd_good" },
			{ 58055, "folder" },
			{ 60349, "folder_copy" },
			{ 60212, "folder_delete" },
			{ 60291, "folder_off" },
			{ 58056, "folder_open" },
			{ 58057, "folder_shared" },
			{ 58903, "folder_special" },
			{ 60204, "folder_zip" },
			{ 61986, "follow_the_signs" },
			{ 57703, "font_download" },
			{ 58617, "font_download_off" },
			{ 61938, "food_bank" },
			{ 60057, "forest" },
			{ 60320, "fork_left" },
			{ 60332, "fork_right" },
			{ 57908, "format_align_center" },
			{ 57909, "format_align_justify" },
			{ 57910, "format_align_left" },
			{ 57911, "format_align_right" },
			{ 57912, "format_bold" },
			{ 57913, "format_clear" },
			{ 57914, "format_color_fill" },
			{ 57915, "format_color_reset" },
			{ 57916, "format_color_text" },
			{ 57917, "format_indent_decrease" },
			{ 57918, "format_indent_increase" },
			{ 57919, "format_italic" },
			{ 57920, "format_line_spacing" },
			{ 57921, "format_list_bulleted" },
			{ 57922, "format_list_numbered" },
			{ 57959, "format_list_numbered_rtl" },
			{ 60261, "format_overline" },
			{ 57923, "format_paint" },
			{ 57924, "format_quote" },
			{ 57950, "format_shapes" },
			{ 57925, "format_size" },
			{ 57926, "format_strikethrough" },
			{ 57927, "format_textdirection_l_to_r" },
			{ 57928, "format_textdirection_r_to_l" },
			{ 57929, "format_underlined" },
			{ 60077, "fort" },
			{ 57535, "forum" },
			{ 57684, "forward" },
			{ 57430, "forward_10" },
			{ 57431, "forward_30" },
			{ 57432, "forward_5" },
			{ 61831, "forward_to_inbox" },
			{ 61952, "foundation" },
			{ 60228, "free_breakfast" },
			{ 59208, "free_cancellation" },
			{ 59241, "front_hand" },
			{ 58832, "fullscreen" },
			{ 58833, "fullscreen_exit" },
			{ 57930, "functions" },
			{ 61456, "g_mobiledata" },
			{ 59687, "g_translate" },
			{ 58127, "gamepad" },
			{ 57377, "games" },
			{ 61457, "garage" },
			{ 59662, "gavel" },
			{ 59209, "generating_tokens" },
			{ 57685, "gesture" },
			{ 59524, "get_app" },
			{ 59656, "gif" },
			{ 59299, "gif_box" },
			{ 60264, "girl" },
			{ 58763, "gite" },
			{ 60229, "golf_course" },
			{ 61458, "gpp_bad" },
			{ 61459, "gpp_good" },
			{ 61460, "gpp_maybe" },
			{ 57779, "gps_fixed" },
			{ 57780, "gps_not_fixed" },
			{ 57781, "gps_off" },
			{ 59525, "grade" },
			{ 58345, "gradient" },
			{ 59983, "grading" },
			{ 58346, "grain" },
			{ 57784, "graphic_eq" },
			{ 61957, "grass" },
			{ 61461, "grid_3x3" },
			{ 61462, "grid_4x4" },
			{ 61463, "grid_goldenratio" },
			{ 58347, "grid_off" },
			{ 58348, "grid_on" },
			{ 59824, "grid_view" },
			{ 59375, "group" },
			{ 59376, "group_add" },
			{ 59207, "group_off" },
			{ 59309, "group_remove" },
			{ 59526, "group_work" },
			{ 62003, "groups" },
			{ 61464, "h_mobiledata" },
			{ 61465, "h_plus_mobiledata" },
			{ 59825, "hail" },
			{ 60363, "handshake" },
			{ 61707, "handyman" },
			{ 59993, "hardware" },
			{ 57426, "hd" },
			{ 61466, "hdr_auto" },
			{ 61467, "hdr_auto_select" },
			{ 61265, "hdr_enhanced_select" },
			{ 58349, "hdr_off" },
			{ 61468, "hdr_off_select" },
			{ 58350, "hdr_on" },
			{ 61469, "hdr_on_select" },
			{ 61470, "hdr_plus" },
			{ 58353, "hdr_strong" },
			{ 58354, "hdr_weak" },
			{ 61471, "headphones" },
			{ 61472, "headphones_battery" },
			{ 58128, "headset" },
			{ 58129, "headset_mic" },
			{ 58170, "headset_off" },
			{ 58355, "healing" },
			{ 57813, "health_and_safety" },
			{ 57379, "hearing" },
			{ 61700, "hearing_disabled" },
			{ 60098, "heart_broken" },
			{ 59926, "height" },
			{ 59527, "help" },
			{ 61888, "help_center" },
			{ 59645, "help_outline" },
			{ 61473, "hevc" },
			{ 60217, "hexagon" },
			{ 61474, "hide_image" },
			{ 61475, "hide_source" },
			{ 57380, "high_quality" },
			{ 57951, "highlight" },
			{ 61266, "highlight_alt" },
			{ 59528, "highlight_off" },
			{ 58634, "hiking" },
			{ 59529, "history" },
			{ 59966, "history_edu" },
			{ 61821, "history_toggle_off" },
			{ 60070, "hive" },
			{ 60298, "hls" },
			{ 60300, "hls_off" },
			{ 58762, "holiday_village" },
			{ 59530, "home" },
			{ 61476, "home_max" },
			{ 61477, "home_mini" },
			{ 61696, "home_repair_service" },
			{ 59913, "home_work" },
			{ 57364, "horizontal_distribute" },
			{ 61704, "horizontal_rule" },
			{ 59719, "horizontal_split" },
			{ 60230, "hot_tub" },
			{ 58682, "hotel" },
			{ 59203, "hotel_class" },
			{ 59996, "hourglass_bottom" },
			{ 61267, "hourglass_disabled" },
			{ 59531, "hourglass_empty" },
			{ 59532, "hourglass_full" },
			{ 59995, "hourglass_top" },
			{ 59972, "house" },
			{ 61954, "house_siding" },
			{ 58756, "houseboat" },
			{ 57716, "how_to_reg" },
			{ 57717, "how_to_vote" },
			{ 60286, "html" },
			{ 59650, "http" },
			{ 59533, "https" },
			{ 59892, "hub" },
			{ 61710, "hvac" },
			{ 58635, "ice_skating" },
			{ 60009, "icecream" },
			{ 58356, "image" },
			{ 58357, "image_aspect_ratio" },
			{ 61718, "image_not_supported" },
			{ 58431, "image_search" },
			{ 59828, "imagesearch_roller" },
			{ 57568, "import_contacts" },
			{ 57539, "import_export" },
			{ 59666, "important_devices" },
			{ 57686, "inbox" },
			{ 59291, "incomplete_circle" },
			{ 59657, "indeterminate_check_box" },
			{ 59534, "info" },
			{ 59536, "input" },
			{ 57931, "insert_chart" },
			{ 57962, "insert_chart_outlined" },
			{ 57932, "insert_comment" },
			{ 57933, "insert_drive_file" },
			{ 57934, "insert_emoticon" },
			{ 57935, "insert_invitation" },
			{ 57936, "insert_link" },
			{ 60106, "insert_page_break" },
			{ 57937, "insert_photo" },
			{ 61586, "insights" },
			{ 60273, "install_desktop" },
			{ 60274, "install_mobile" },
			{ 61268, "integration_instructions" },
			{ 59336, "interests" },
			{ 59451, "interpreter_mode" },
			{ 57721, "inventory" },
			{ 57761, "inventory_2" },
			{ 59537, "invert_colors" },
			{ 57540, "invert_colors_off" },
			{ 59064, "ios_share" },
			{ 58755, "iron" },
			{ 58358, "iso" },
			{ 60284, "javascript" },
			{ 60139, "join_full" },
			{ 60148, "join_inner" },
			{ 60146, "join_left" },
			{ 60138, "join_right" },
			{ 58636, "kayaking" },
			{ 59458, "kebab_dining" },
			{ 59196, "key" },
			{ 60292, "key_off" },
			{ 58130, "keyboard" },
			{ 61480, "keyboard_alt" },
			{ 58131, "keyboard_arrow_down" },
			{ 58132, "keyboard_arrow_left" },
			{ 58133, "keyboard_arrow_right" },
			{ 58134, "keyboard_arrow_up" },
			{ 58135, "keyboard_backspace" },
			{ 58136, "keyboard_capslock" },
			{ 60135, "keyboard_command_key" },
			{ 60134, "keyboard_control_key" },
			{ 60112, "keyboard_double_arrow_down" },
			{ 60099, "keyboard_double_arrow_left" },
			{ 60105, "keyboard_double_arrow_right" },
			{ 60111, "keyboard_double_arrow_up" },
			{ 58138, "keyboard_hide" },
			{ 60136, "keyboard_option_key" },
			{ 58139, "keyboard_return" },
			{ 58140, "keyboard_tab" },
			{ 58141, "keyboard_voice" },
			{ 59973, "king_bed" },
			{ 60231, "kitchen" },
			{ 58637, "kitesurfing" },
			{ 59538, "label" },
			{ 59703, "label_important" },
			{ 59830, "label_off" },
			{ 60207, "lan" },
			{ 58359, "landscape" },
			{ 59540, "language" },
			{ 58142, "laptop" },
			{ 58143, "laptop_chromebook" },
			{ 58144, "laptop_mac" },
			{ 58145, "laptop_windows" },
			{ 58845, "last_page" },
			{ 59541, "launch" },
			{ 58683, "layers" },
			{ 58684, "layers_clear" },
			{ 61964, "leaderboard" },
			{ 58360, "leak_add" },
			{ 58361, "leak_remove" },
			{ 61723, "legend_toggle" },
			{ 58362, "lens" },
			{ 61481, "lens_blur" },
			{ 57390, "library_add" },
			{ 59831, "library_add_check" },
			{ 57391, "library_books" },
			{ 57392, "library_music" },
			{ 61482, "light" },
			{ 58648, "light_mode" },
			{ 57584, "lightbulb" },
			{ 60058, "line_axis" },
			{ 59673, "line_style" },
			{ 59674, "line_weight" },
			{ 57952, "linear_scale" },
			{ 57687, "link" },
			{ 57711, "link_off" },
			{ 58424, "linked_camera" },
			{ 60000, "liquor" },
			{ 59542, "list" },
			{ 57582, "list_alt" },
			{ 57542, "live_help" },
			{ 58937, "live_tv" },
			{ 61483, "living" },
			{ 58687, "local_activity" },
			{ 58685, "local_airport" },
			{ 58686, "local_atm" },
			{ 58688, "local_bar" },
			{ 58689, "local_cafe" },
			{ 58690, "local_car_wash" },
			{ 58691, "local_convenience_store" },
			{ 58710, "local_dining" },
			{ 58692, "local_drink" },
			{ 61269, "local_fire_department" },
			{ 58693, "local_florist" },
			{ 58694, "local_gas_station" },
			{ 58695, "local_grocery_store" },
			{ 58696, "local_hospital" },
			{ 58697, "local_hotel" },
			{ 58698, "local_laundry_service" },
			{ 58699, "local_library" },
			{ 58700, "local_mall" },
			{ 58701, "local_movies" },
			{ 58702, "local_offer" },
			{ 58703, "local_parking" },
			{ 58704, "local_pharmacy" },
			{ 58705, "local_phone" },
			{ 58706, "local_pizza" },
			{ 58707, "local_play" },
			{ 61270, "local_police" },
			{ 58708, "local_post_office" },
			{ 58709, "local_printshop" },
			{ 58711, "local_see" },
			{ 58712, "local_shipping" },
			{ 58713, "local_taxi" },
			{ 59377, "location_city" },
			{ 57782, "location_disabled" },
			{ 57543, "location_off" },
			{ 57544, "location_on" },
			{ 57783, "location_searching" },
			{ 59543, "lock" },
			{ 61271, "lock_clock" },
			{ 59544, "lock_open" },
			{ 60126, "lock_reset" },
			{ 60023, "login" },
			{ 60118, "logo_dev" },
			{ 59834, "logout" },
			{ 58364, "looks" },
			{ 58363, "looks_3" },
			{ 58365, "looks_4" },
			{ 58366, "looks_5" },
			{ 58367, "looks_6" },
			{ 58368, "looks_one" },
			{ 58369, "looks_two" },
			{ 57384, "loop" },
			{ 58370, "loupe" },
			{ 57709, "low_priority" },
			{ 59546, "loyalty" },
			{ 61484, "lte_mobiledata" },
			{ 61485, "lte_plus_mobiledata" },
			{ 62005, "luggage" },
			{ 60001, "lunch_dining" },
			{ 57688, "mail" },
			{ 57569, "mail_outline" },
			{ 58766, "male" },
			{ 58603, "man" },
			{ 61486, "manage_accounts" },
			{ 61487, "manage_search" },
			{ 58715, "map" },
			{ 61488, "maps_home_work" },
			{ 61272, "maps_ugc" },
			{ 59835, "margin" },
			{ 59836, "mark_as_unread" },
			{ 61835, "mark_chat_read" },
			{ 61833, "mark_chat_unread" },
			{ 61836, "mark_email_read" },
			{ 61834, "mark_email_unread" },
			{ 60317, "mark_unread_chat_alt" },
			{ 57689, "markunread" },
			{ 59547, "markunread_mailbox" },
			{ 61976, "masks" },
			{ 59696, "maximize" },
			{ 61489, "media_bluetooth_off" },
			{ 61490, "media_bluetooth_on" },
			{ 61351, "mediation" },
			{ 61705, "medical_services" },
			{ 61491, "medication" },
			{ 60039, "medication_liquid" },
			{ 60239, "meeting_room" },
			{ 58146, "memory" },
			{ 58834, "menu" },
			{ 59929, "menu_book" },
			{ 59837, "menu_open" },
			{ 60312, "merge" },
			{ 57938, "merge_type" },
			{ 57545, "message" },
			{ 57385, "mic" },
			{ 61273, "mic_external_off" },
			{ 61274, "mic_external_on" },
			{ 57386, "mic_none" },
			{ 57387, "mic_off" },
			{ 61956, "microwave" },
			{ 59967, "military_tech" },
			{ 59697, "minimize" },
			{ 61708, "miscellaneous_services" },
			{ 57459, "missed_video_call" },
			{ 58904, "mms" },
			{ 57856, "mobile_friendly" },
			{ 57857, "mobile_off" },
			{ 57575, "mobile_screen_share" },
			{ 61492, "mobiledata_off" },
			{ 61591, "mode" },
			{ 57939, "mode_comment" },
			{ 57940, "mode_edit" },
			{ 61493, "mode_edit_outline" },
			{ 61494, "mode_night" },
			{ 59342, "mode_of_travel" },
			{ 61495, "mode_standby" },
			{ 61647, "model_training" },
			{ 57955, "monetization_on" },
			{ 58749, "money" },
			{ 57948, "money_off" },
			{ 61496, "money_off_csred" },
			{ 61275, "monitor" },
			{ 60066, "monitor_heart" },
			{ 61497, "monitor_weight" },
			{ 58371, "monochrome_photos" },
			{ 59378, "mood" },
			{ 59379, "mood_bad" },
			{ 60200, "moped" },
			{ 58905, "more" },
			{ 58835, "more_horiz" },
			{ 59997, "more_time" },
			{ 58836, "more_vert" },
			{ 60082, "mosque" },
			{ 61498, "motion_photos_auto" },
			{ 59840, "motion_photos_off" },
			{ 59841, "motion_photos_on" },
			{ 61991, "motion_photos_pause" },
			{ 59842, "motion_photos_paused" },
			{ 58147, "mouse" },
			{ 60257, "move_down" },
			{ 57704, "move_to_inbox" },
			{ 60260, "move_up" },
			{ 57388, "movie" },
			{ 58372, "movie_creation" },
			{ 58426, "movie_filter" },
			{ 58625, "moving" },
			{ 59843, "mp" },
			{ 59103, "multiline_chart" },
			{ 61881, "multiple_stop" },
			{ 59958, "museum" },
			{ 58373, "music_note" },
			{ 58432, "music_off" },
			{ 57443, "music_video" },
			{ 58716, "my_location" },
			{ 61276, "nat" },
			{ 58374, "nature" },
			{ 58375, "nature_people" },
			{ 58376, "navigate_before" },
			{ 58377, "navigate_next" },
			{ 58717, "navigation" },
			{ 58729, "near_me" },
			{ 61935, "near_me_disabled" },
			{ 61499, "nearby_error" },
			{ 61500, "nearby_off" },
			{ 57785, "network_cell" },
			{ 58944, "network_check" },
			{ 58906, "network_locked" },
			{ 60362, "network_ping" },
			{ 57786, "network_wifi" },
			{ 58889, "new_label" },
			{ 57393, "new_releases" },
			{ 60289, "newspaper" },
			{ 61277, "next_plan" },
			{ 57706, "next_week" },
			{ 57787, "nfc" },
			{ 61937, "night_shelter" },
			{ 60002, "nightlife" },
			{ 61501, "nightlight" },
			{ 61278, "nightlight_round" },
			{ 59974, "nights_stay" },
			{ 61502, "no_accounts" },
			{ 62007, "no_backpack" },
			{ 61860, "no_cell" },
			{ 61861, "no_drinks" },
			{ 58945, "no_encryption" },
			{ 61503, "no_encryption_gmailerrorred" },
			{ 61862, "no_flash" },
			{ 61863, "no_food" },
			{ 62011, "no_luggage" },
			{ 61910, "no_meals" },
			{ 60238, "no_meeting_room" },
			{ 61864, "no_photography" },
			{ 57548, "no_sim" },
			{ 61871, "no_stroller" },
			{ 61909, "no_transfer" },
			{ 58638, "nordic_walking" },
			{ 61920, "north" },
			{ 61921, "north_east" },
			{ 61922, "north_west" },
			{ 61694, "not_accessible" },
			{ 57395, "not_interested" },
			{ 58741, "not_listed_location" },
			{ 61649, "not_started" },
			{ 57455, "note" },
			{ 59548, "note_add" },
			{ 61504, "note_alt" },
			{ 57964, "notes" },
			{ 58265, "notification_add" },
			{ 57348, "notification_important" },
			{ 59380, "notifications" },
			{ 59383, "notifications_active" },
			{ 59381, "notifications_none" },
			{ 59382, "notifications_off" },
			{ 59384, "notifications_paused" },
			{ 60103, "numbers" },
			{ 59698, "offline_bolt" },
			{ 59658, "offline_pin" },
			{ 59845, "offline_share" },
			{ 58938, "ondemand_video" },
			{ 61675, "online_prediction" },
			{ 59676, "opacity" },
			{ 59549, "open_in_browser" },
			{ 61902, "open_in_full" },
			{ 59550, "open_in_new" },
			{ 58614, "open_in_new_off" },
			{ 59551, "open_with" },
			{ 58764, "other_houses" },
			{ 57802, "outbound" },
			{ 61279, "outbox" },
			{ 59975, "outdoor_grill" },
			{ 61908, "outlet" },
			{ 57710, "outlined_flag" },
			{ 60350, "output" },
			{ 59848, "padding" },
			{ 59385, "pages" },
			{ 59552, "pageview" },
			{ 61505, "paid" },
			{ 58378, "palette" },
			{ 59685, "pan_tool" },
			{ 60345, "pan_tool_alt" },
			{ 58379, "panorama" },
			{ 58380, "panorama_fish_eye" },
			{ 58381, "panorama_horizontal" },
			{ 61280, "panorama_horizontal_select" },
			{ 59849, "panorama_photosphere" },
			{ 59850, "panorama_photosphere_select" },
			{ 58382, "panorama_vertical" },
			{ 61281, "panorama_vertical_select" },
			{ 58383, "panorama_wide_angle" },
			{ 61282, "panorama_wide_angle_select" },
			{ 58639, "paragliding" },
			{ 60003, "park" },
			{ 59386, "party_mode" },
			{ 61506, "password" },
			{ 61507, "pattern" },
			{ 57396, "pause" },
			{ 57762, "pause_circle" },
			{ 57397, "pause_circle_filled" },
			{ 57398, "pause_circle_outline" },
			{ 57578, "pause_presentation" },
			{ 59553, "payment" },
			{ 61283, "payments" },
			{ 60201, "pedal_bike" },
			{ 61284, "pending" },
			{ 61883, "pending_actions" },
			{ 60240, "pentagon" },
			{ 59387, "people" },
			{ 59937, "people_alt" },
			{ 59388, "people_outline" },
			{ 60248, "percent" },
			{ 59554, "perm_camera_mic" },
			{ 59555, "perm_contact_calendar" },
			{ 59556, "perm_data_setting" },
			{ 59557, "perm_device_information" },
			{ 59558, "perm_identity" },
			{ 59559, "perm_media" },
			{ 59560, "perm_phone_msg" },
			{ 59561, "perm_scan_wifi" },
			{ 59389, "person" },
			{ 59390, "person_add" },
			{ 59981, "person_add_alt" },
			{ 61285, "person_add_alt_1" },
			{ 59851, "person_add_disabled" },
			{ 58640, "person_off" },
			{ 59391, "person_outline" },
			{ 58714, "person_pin" },
			{ 58730, "person_pin_circle" },
			{ 61286, "person_remove" },
			{ 61287, "person_remove_alt_1" },
			{ 61702, "person_search" },
			{ 59098, "personal_injury" },
			{ 58939, "personal_video" },
			{ 61690, "pest_control" },
			{ 61693, "pest_control_rodent" },
			{ 59677, "pets" },
			{ 60119, "phishing" },
			{ 57549, "phone" },
			{ 58148, "phone_android" },
			{ 58907, "phone_bluetooth_speaker" },
			{ 58953, "phone_callback" },
			{ 59852, "phone_disabled" },
			{ 59853, "phone_enabled" },
			{ 58908, "phone_forwarded" },
			{ 58909, "phone_in_talk" },
			{ 58149, "phone_iphone" },
			{ 58910, "phone_locked" },
			{ 58911, "phone_missed" },
			{ 58912, "phone_paused" },
			{ 58150, "phonelink" },
			{ 57563, "phonelink_erase" },
			{ 57564, "phonelink_lock" },
			{ 58151, "phonelink_off" },
			{ 57565, "phonelink_ring" },
			{ 57566, "phonelink_setup" },
			{ 58384, "photo" },
			{ 58385, "photo_album" },
			{ 58386, "photo_camera" },
			{ 61288, "photo_camera_back" },
			{ 61289, "photo_camera_front" },
			{ 58427, "photo_filter" },
			{ 58387, "photo_library" },
			{ 58418, "photo_size_select_actual" },
			{ 58419, "photo_size_select_large" },
			{ 58420, "photo_size_select_small" },
			{ 60303, "php" },
			{ 58657, "piano" },
			{ 58656, "piano_off" },
			{ 58389, "picture_as_pdf" },
			{ 59562, "picture_in_picture" },
			{ 59665, "picture_in_picture_alt" },
			{ 59076, "pie_chart" },
			{ 61508, "pie_chart_outline" },
			{ 61509, "pin" },
			{ 58718, "pin_drop" },
			{ 59239, "pin_end" },
			{ 59235, "pin_invoke" },
			{ 60216, "pinch" },
			{ 59854, "pivot_table_chart" },
			{ 60067, "pix" },
			{ 58719, "place" },
			{ 59994, "plagiarism" },
			{ 57399, "play_arrow" },
			{ 57796, "play_circle" },
			{ 57400, "play_circle_filled" },
			{ 57401, "play_circle_outline" },
			{ 61290, "play_disabled" },
			{ 59654, "play_for_work" },
			{ 61511, "play_lesson" },
			{ 57403, "playlist_add" },
			{ 57445, "playlist_add_check" },
			{ 59366, "playlist_add_check_circle" },
			{ 59365, "playlist_add_circle" },
			{ 57439, "playlist_play" },
			{ 60288, "playlist_remove" },
			{ 61703, "plumbing" },
			{ 59392, "plus_one" },
			{ 61512, "podcasts" },
			{ 61822, "point_of_sale" },
			{ 59927, "policy" },
			{ 59393, "poll" },
			{ 60347, "polyline" },
			{ 59563, "polymer" },
			{ 60232, "pool" },
			{ 57550, "portable_wifi_off" },
			{ 58390, "portrait" },
			{ 59936, "post_add" },
			{ 58940, "power" },
			{ 58166, "power_input" },
			{ 58950, "power_off" },
			{ 59564, "power_settings_new" },
			{ 61513, "precision_manufacturing" },
			{ 59678, "pregnant_woman" },
			{ 57567, "present_to_all" },
			{ 61893, "preview" },
			{ 61514, "price_change" },
			{ 61515, "price_check" },
			{ 59565, "print" },
			{ 59855, "print_disabled" },
			{ 58949, "priority_high" },
			{ 61660, "privacy_tip" },
			{ 59204, "private_connectivity" },
			{ 57809, "production_quantity_limits" },
			{ 59978, "psychology" },
			{ 59403, "public" },
			{ 61898, "public_off" },
			{ 57941, "publish" },
			{ 62002, "published_with_changes" },
			{ 60072, "punch_clock" },
			{ 61709, "push_pin" },
			{ 61291, "qr_code" },
			{ 57354, "qr_code_2" },
			{ 61958, "qr_code_scanner" },
			{ 59566, "query_builder" },
			{ 58620, "query_stats" },
			{ 59567, "question_answer" },
			{ 60299, "question_mark" },
			{ 57404, "queue" },
			{ 57405, "queue_music" },
			{ 57446, "queue_play_next" },
			{ 61292, "quickreply" },
			{ 61516, "quiz" },
			{ 61517, "r_mobiledata" },
			{ 61518, "radar" },
			{ 57406, "radio" },
			{ 59447, "radio_button_checked" },
			{ 59446, "radio_button_unchecked" },
			{ 59857, "railway_alert" },
			{ 60004, "ramen_dining" },
			{ 60316, "ramp_left" },
			{ 60310, "ramp_right" },
			{ 58720, "rate_review" },
			{ 61519, "raw_off" },
			{ 61520, "raw_on" },
			{ 61293, "read_more" },
			{ 59194, "real_estate_agent" },
			{ 59568, "receipt" },
			{ 61294, "receipt_long" },
			{ 57407, "recent_actors" },
			{ 59858, "recommend" },
			{ 59679, "record_voice_over" },
			{ 60244, "rectangle" },
			{ 59232, "recycling" },
			{ 59569, "redeem" },
			{ 57690, "redo" },
			{ 61980, "reduce_capacity" },
			{ 58837, "refresh" },
			{ 61521, "remember_me" },
			{ 57691, "remove" },
			{ 57692, "remove_circle" },
			{ 57693, "remove_circle_outline" },
			{ 59859, "remove_done" },
			{ 57447, "remove_from_queue" },
			{ 59860, "remove_moderator" },
			{ 58391, "remove_red_eye" },
			{ 59688, "remove_shopping_cart" },
			{ 59646, "reorder" },
			{ 57408, "repeat" },
			{ 59862, "repeat_on" },
			{ 57409, "repeat_one" },
			{ 59863, "repeat_one_on" },
			{ 57410, "replay" },
			{ 57433, "replay_10" },
			{ 57434, "replay_30" },
			{ 57435, "replay_5" },
			{ 59864, "replay_circle_filled" },
			{ 57694, "reply" },
			{ 57695, "reply_all" },
			{ 57696, "report" },
			{ 61522, "report_gmailerrorred" },
			{ 57712, "report_off" },
			{ 59570, "report_problem" },
			{ 61996, "request_page" },
			{ 61878, "request_quote" },
			{ 59865, "reset_tv" },
			{ 61523, "restart_alt" },
			{ 58732, "restaurant" },
			{ 58721, "restaurant_menu" },
			{ 59571, "restore" },
			{ 59704, "restore_from_trash" },
			{ 59689, "restore_page" },
			{ 61524, "reviews" },
			{ 61941, "rice_bowl" },
			{ 57553, "ring_volume" },
			{ 60325, "rocket" },
			{ 60315, "rocket_launch" },
			{ 60365, "roller_skating" },
			{ 61953, "roofing" },
			{ 59572, "room" },
			{ 61880, "room_preferences" },
			{ 60233, "room_service" },
			{ 58392, "rotate_90_degrees_ccw" },
			{ 60075, "rotate_90_degrees_cw" },
			{ 58393, "rotate_left" },
			{ 58394, "rotate_right" },
			{ 60313, "roundabout_left" },
			{ 60323, "roundabout_right" },
			{ 59680, "rounded_corner" },
			{ 60109, "route" },
			{ 58152, "router" },
			{ 59681, "rowing" },
			{ 57573, "rss_feed" },
			{ 61525, "rsvp" },
			{ 59821, "rtt" },
			{ 61890, "rule" },
			{ 61897, "rule_folder" },
			{ 61295, "run_circle" },
			{ 58653, "running_with_errors" },
			{ 58946, "rv_hookup" },
			{ 57804, "safety_divider" },
			{ 58626, "sailing" },
			{ 61981, "sanitizer" },
			{ 58722, "satellite" },
			{ 60218, "satellite_alt" },
			{ 57697, "save" },
			{ 57713, "save_alt" },
			{ 60256, "save_as" },
			{ 59921, "saved_search" },
			{ 58091, "savings" },
			{ 60255, "scale" },
			{ 58153, "scanner" },
			{ 57960, "scatter_plot" },
			{ 59573, "schedule" },
			{ 59914, "schedule_send" },
			{ 58621, "schema" },
			{ 59404, "school" },
			{ 59979, "science" },
			{ 57961, "score" },
			{ 60368, "scoreboard" },
			{ 57790, "screen_lock_landscape" },
			{ 57791, "screen_lock_portrait" },
			{ 57792, "screen_lock_rotation" },
			{ 57793, "screen_rotation" },
			{ 61296, "screen_search_desktop" },
			{ 57570, "screen_share" },
			{ 61526, "screenshot" },
			{ 60366, "scuba_diving" },
			{ 59869, "sd" },
			{ 58915, "sd_card" },
			{ 61527, "sd_card_alert" },
			{ 57794, "sd_storage" },
			{ 59574, "search" },
			{ 60022, "search_off" },
			{ 58154, "security" },
			{ 61528, "security_update" },
			{ 61529, "security_update_good" },
			{ 61530, "security_update_warning" },
			{ 59723, "segment" },
			{ 57698, "select_all" },
			{ 60024, "self_improvement" },
			{ 61531, "sell" },
			{ 57699, "send" },
			{ 59916, "send_and_archive" },
			{ 60123, "send_time_extension" },
			{ 61532, "send_to_mobile" },
			{ 61877, "sensor_door" },
			{ 61876, "sensor_window" },
			{ 58654, "sensors" },
			{ 58655, "sensors_off" },
			{ 59409, "sentiment_dissatisfied" },
			{ 59410, "sentiment_neutral" },
			{ 59411, "sentiment_satisfied" },
			{ 57581, "sentiment_satisfied_alt" },
			{ 59412, "sentiment_very_dissatisfied" },
			{ 59413, "sentiment_very_satisfied" },
			{ 61930, "set_meal" },
			{ 59576, "settings" },
			{ 61533, "settings_accessibility" },
			{ 59577, "settings_applications" },
			{ 59578, "settings_backup_restore" },
			{ 59579, "settings_bluetooth" },
			{ 59581, "settings_brightness" },
			{ 59580, "settings_cell" },
			{ 59582, "settings_ethernet" },
			{ 59583, "settings_input_antenna" },
			{ 59584, "settings_input_component" },
			{ 59585, "settings_input_composite" },
			{ 59586, "settings_input_hdmi" },
			{ 59587, "settings_input_svideo" },
			{ 59588, "settings_overscan" },
			{ 59589, "settings_phone" },
			{ 59590, "settings_power" },
			{ 59591, "settings_remote" },
			{ 61534, "settings_suggest" },
			{ 57795, "settings_system_daydream" },
			{ 59592, "settings_voice" },
			{ 59405, "share" },
			{ 61535, "share_location" },
			{ 59872, "shield" },
			{ 60073, "shield_moon" },
			{ 59593, "shop" },
			{ 57758, "shop_2" },
			{ 59594, "shop_two" },
			{ 61900, "shopping_bag" },
			{ 59595, "shopping_basket" },
			{ 59596, "shopping_cart" },
			{ 60296, "shopping_cart_checkout" },
			{ 57953, "short_text" },
			{ 61536, "shortcut" },
			{ 59105, "show_chart" },
			{ 61537, "shower" },
			{ 57411, "shuffle" },
			{ 59873, "shuffle_on" },
			{ 58429, "shutter_speed" },
			{ 61984, "sick" },
			{ 61608, "signal_cellular_0_bar" },
			{ 57800, "signal_cellular_4_bar" },
			{ 57858, "signal_cellular_alt" },
			{ 61612, "signal_cellular_connected_no_internet_0_bar" },
			{ 57805, "signal_cellular_connected_no_internet_4_bar" },
			{ 57806, "signal_cellular_no_sim" },
			{ 61538, "signal_cellular_nodata" },
			{ 57807, "signal_cellular_null" },
			{ 57808, "signal_cellular_off" },
			{ 61616, "signal_wifi_0_bar" },
			{ 57816, "signal_wifi_4_bar" },
			{ 57817, "signal_wifi_4_bar_lock" },
			{ 61539, "signal_wifi_bad" },
			{ 61540, "signal_wifi_connected_no_internet_4" },
			{ 57818, "signal_wifi_off" },
			{ 61541, "signal_wifi_statusbar_4_bar" },
			{ 61542, "signal_wifi_statusbar_connected_no_internet_4" },
			{ 61543, "signal_wifi_statusbar_null" },
			{ 60305, "signpost" },
			{ 58155, "sim_card" },
			{ 58916, "sim_card_alert" },
			{ 61544, "sim_card_download" },
			{ 59976, "single_bed" },
			{ 61545, "sip" },
			{ 58641, "skateboarding" },
			{ 57412, "skip_next" },
			{ 57413, "skip_previous" },
			{ 58642, "sledding" },
			{ 58395, "slideshow" },
			{ 57448, "slow_motion_video" },
			{ 61889, "smart_button" },
			{ 61546, "smart_display" },
			{ 61547, "smart_screen" },
			{ 61548, "smart_toy" },
			{ 58156, "smartphone" },
			{ 60234, "smoke_free" },
			{ 60235, "smoking_rooms" },
			{ 58917, "sms" },
			{ 58918, "sms_failed" },
			{ 61895, "snippet_folder" },
			{ 57414, "snooze" },
			{ 58643, "snowboarding" },
			{ 58627, "snowmobile" },
			{ 58644, "snowshoeing" },
			{ 61874, "soap" },
			{ 57803, "social_distance" },
			{ 57700, "sort" },
			{ 57427, "sort_by_alpha" },
			{ 59347, "soup_kitchen" },
			{ 61892, "source" },
			{ 61923, "south" },
			{ 59364, "south_america" },
			{ 61924, "south_east" },
			{ 61925, "south_west" },
			{ 60236, "spa" },
			{ 57942, "space_bar" },
			{ 58987, "space_dashboard" },
			{ 58157, "speaker" },
			{ 58158, "speaker_group" },
			{ 59597, "speaker_notes" },
			{ 59690, "speaker_notes_off" },
			{ 57554, "speaker_phone" },
			{ 59876, "speed" },
			{ 59598, "spellcheck" },
			{ 61549, "splitscreen" },
			{ 59815, "spoke" },
			{ 59952, "sports" },
			{ 61939, "sports_bar" },
			{ 59985, "sports_baseball" },
			{ 59942, "sports_basketball" },
			{ 59943, "sports_cricket" },
			{ 59944, "sports_esports" },
			{ 59945, "sports_football" },
			{ 59946, "sports_golf" },
			{ 60356, "sports_gymnastics" },
			{ 59955, "sports_handball" },
			{ 59947, "sports_hockey" },
			{ 59956, "sports_kabaddi" },
			{ 60137, "sports_martial_arts" },
			{ 59948, "sports_mma" },
			{ 59949, "sports_motorsports" },
			{ 59950, "sports_rugby" },
			{ 61550, "sports_score" },
			{ 59951, "sports_soccer" },
			{ 59954, "sports_tennis" },
			{ 59953, "sports_volleyball" },
			{ 60214, "square" },
			{ 59977, "square_foot" },
			{ 60262, "ssid_chart" },
			{ 59878, "stacked_bar_chart" },
			{ 61995, "stacked_line_chart" },
			{ 60304, "stadium" },
			{ 61865, "stairs" },
			{ 59448, "star" },
			{ 59450, "star_border" },
			{ 61593, "star_border_purple500" },
			{ 59449, "star_half" },
			{ 61551, "star_outline" },
			{ 61594, "star_purple500" },
			{ 61676, "star_rate" },
			{ 59600, "stars" },
			{ 57481, "start" },
			{ 57555, "stay_current_landscape" },
			{ 57556, "stay_current_portrait" },
			{ 57557, "stay_primary_landscape" },
			{ 57558, "stay_primary_portrait" },
			{ 61948, "sticky_note_2" },
			{ 57415, "stop" },
			{ 61297, "stop_circle" },
			{ 57571, "stop_screen_share" },
			{ 57819, "storage" },
			{ 59601, "store" },
			{ 58723, "store_mall_directory" },
			{ 59922, "storefront" },
			{ 61552, "storm" },
			{ 60309, "straight" },
			{ 58396, "straighten" },
			{ 59881, "stream" },
			{ 58734, "streetview" },
			{ 57943, "strikethrough_s" },
			{ 61870, "stroller" },
			{ 58397, "style" },
			{ 58841, "subdirectory_arrow_left" },
			{ 58842, "subdirectory_arrow_right" },
			{ 59602, "subject" },
			{ 61713, "subscript" },
			{ 57444, "subscriptions" },
			{ 57416, "subtitles" },
			{ 61298, "subtitles_off" },
			{ 58735, "subway" },
			{ 61553, "summarize" },
			{ 61714, "superscript" },
			{ 59705, "supervised_user_circle" },
			{ 59603, "supervisor_account" },
			{ 61299, "support" },
			{ 61666, "support_agent" },
			{ 58645, "surfing" },
			{ 57417, "surround_sound" },
			{ 57559, "swap_calls" },
			{ 59604, "swap_horiz" },
			{ 59699, "swap_horizontal_circle" },
			{ 59605, "swap_vert" },
			{ 59606, "swap_vertical_circle" },
			{ 59884, "swipe" },
			{ 60243, "swipe_down" },
			{ 60208, "swipe_down_alt" },
			{ 60249, "swipe_left" },
			{ 60211, "swipe_left_alt" },
			{ 60242, "swipe_right" },
			{ 60246, "swipe_right_alt" },
			{ 60206, "swipe_up" },
			{ 60213, "swipe_up_alt" },
			{ 60241, "swipe_vertical" },
			{ 59361, "switch_access_shortcut" },
			{ 59362, "switch_access_shortcut_add" },
			{ 59885, "switch_account" },
			{ 58398, "switch_camera" },
			{ 61905, "switch_left" },
			{ 61906, "switch_right" },
			{ 58399, "switch_video" },
			{ 60080, "synagogue" },
			{ 58919, "sync" },
			{ 59928, "sync_alt" },
			{ 58920, "sync_disabled" },
			{ 60142, "sync_lock" },
			{ 58921, "sync_problem" },
			{ 61554, "system_security_update" },
			{ 61555, "system_security_update_good" },
			{ 61556, "system_security_update_warning" },
			{ 58922, "system_update" },
			{ 59607, "system_update_alt" },
			{ 59608, "tab" },
			{ 59609, "tab_unselected" },
			{ 60114, "table_bar" },
			{ 57957, "table_chart" },
			{ 60102, "table_restaurant" },
			{ 61697, "table_rows" },
			{ 61886, "table_view" },
			{ 58159, "tablet" },
			{ 58160, "tablet_android" },
			{ 58161, "tablet_mac" },
			{ 59887, "tag" },
			{ 58400, "tag_faces" },
			{ 60020, "takeout_dining" },
			{ 58923, "tap_and_play" },
			{ 61929, "tapas" },
			{ 61557, "task" },
			{ 58086, "task_alt" },
			{ 61300, "taxi_alert" },
			{ 60083, "temple_buddhist" },
			{ 60079, "temple_hindu" },
			{ 60302, "terminal" },
			{ 58724, "terrain" },
			{ 60125, "text_decrease" },
			{ 57954, "text_fields" },
			{ 57701, "text_format" },
			{ 60130, "text_increase" },
			{ 59706, "text_rotate_up" },
			{ 59707, "text_rotate_vertical" },
			{ 59708, "text_rotation_angledown" },
			{ 59709, "text_rotation_angleup" },
			{ 59710, "text_rotation_down" },
			{ 59711, "text_rotation_none" },
			{ 61894, "text_snippet" },
			{ 57560, "textsms" },
			{ 58401, "texture" },
			{ 60006, "theater_comedy" },
			{ 59610, "theaters" },
			{ 61558, "thermostat" },
			{ 61559, "thermostat_auto" },
			{ 59611, "thumb_down" },
			{ 59414, "thumb_down_alt" },
			{ 59890, "thumb_down_off_alt" },
			{ 59612, "thumb_up" },
			{ 59415, "thumb_up_alt" },
			{ 59891, "thumb_up_off_alt" },
			{ 59613, "thumbs_up_down" },
			{ 58924, "time_to_leave" },
			{ 58402, "timelapse" },
			{ 59682, "timeline" },
			{ 58405, "timer" },
			{ 58403, "timer_10" },
			{ 61562, "timer_10_select" },
			{ 58404, "timer_3" },
			{ 61563, "timer_3_select" },
			{ 58406, "timer_off" },
			{ 59290, "tips_and_updates" },
			{ 60360, "tire_repair" },
			{ 57956, "title" },
			{ 59614, "toc" },
			{ 59615, "today" },
			{ 59893, "toggle_off" },
			{ 59894, "toggle_on" },
			{ 59941, "token" },
			{ 59616, "toll" },
			{ 58407, "tonality" },
			{ 61896, "topic" },
			{ 59667, "touch_app" },
			{ 61301, "tour" },
			{ 58162, "toys" },
			{ 59617, "track_changes" },
			{ 58725, "traffic" },
			{ 58736, "train" },
			{ 58737, "tram" },
			{ 58738, "transfer_within_a_station" },
			{ 58408, "transform" },
			{ 58765, "transgender" },
			{ 58745, "transit_enterexit" },
			{ 59618, "translate" },
			{ 58075, "travel_explore" },
			{ 59619, "trending_down" },
			{ 59620, "trending_flat" },
			{ 59621, "trending_up" },
			{ 58747, "trip_origin" },
			{ 61564, "try" },
			{ 61866, "tty" },
			{ 58409, "tune" },
			{ 61565, "tungsten" },
			{ 60326, "turn_left" },
			{ 60331, "turn_right" },
			{ 60327, "turn_sharp_left" },
			{ 60330, "turn_sharp_right" },
			{ 60324, "turn_slight_left" },
			{ 60314, "turn_slight_right" },
			{ 59622, "turned_in" },
			{ 59623, "turned_in_not" },
			{ 58163, "tv" },
			{ 58951, "tv_off" },
			{ 59897, "two_wheeler" },
			{ 60321, "u_turn_left" },
			{ 60322, "u_turn_right" },
			{ 61869, "umbrella" },
			{ 57705, "unarchive" },
			{ 57702, "undo" },
			{ 58838, "unfold_less" },
			{ 58839, "unfold_more" },
			{ 62006, "unpublished" },
			{ 57579, "unsubscribe" },
			{ 61566, "upcoming" },
			{ 59683, "update" },
			{ 57461, "update_disabled" },
			{ 61691, "upgrade" },
			{ 61595, "upload" },
			{ 59900, "upload_file" },
			{ 57824, "usb" },
			{ 58618, "usb_off" },
			{ 57656, "vaccines" },
			{ 60358, "vape_free" },
			{ 60367, "vaping_rooms" },
			{ 61302, "verified" },
			{ 59624, "verified_user" },
			{ 57944, "vertical_align_bottom" },
			{ 57945, "vertical_align_center" },
			{ 57946, "vertical_align_top" },
			{ 57462, "vertical_distribute" },
			{ 59721, "vertical_split" },
			{ 58925, "vibration" },
			{ 57456, "video_call" },
			{ 61567, "video_camera_back" },
			{ 61568, "video_camera_front" },
			{ 60295, "video_file" },
			{ 57457, "video_label" },
			{ 57418, "video_library" },
			{ 60021, "video_settings" },
			{ 61569, "video_stable" },
			{ 57419, "videocam" },
			{ 57420, "videocam_off" },
			{ 58168, "videogame_asset" },
			{ 58624, "videogame_asset_off" },
			{ 59625, "view_agenda" },
			{ 59626, "view_array" },
			{ 59627, "view_carousel" },
			{ 59628, "view_column" },
			{ 58410, "view_comfy" },
			{ 60275, "view_comfy_alt" },
			{ 58411, "view_compact" },
			{ 60276, "view_compact_alt" },
			{ 60277, "view_cozy" },
			{ 59629, "view_day" },
			{ 59630, "view_headline" },
			{ 59902, "view_in_ar" },
			{ 60287, "view_kanban" },
			{ 59631, "view_list" },
			{ 59632, "view_module" },
			{ 59633, "view_quilt" },
			{ 61716, "view_sidebar" },
			{ 59634, "view_stream" },
			{ 60293, "view_timeline" },
			{ 59635, "view_week" },
			{ 58421, "vignette" },
			{ 58758, "villa" },
			{ 59636, "visibility" },
			{ 59637, "visibility_off" },
			{ 58926, "voice_chat" },
			{ 59722, "voice_over_off" },
			{ 57561, "voicemail" },
			{ 57421, "volume_down" },
			{ 57422, "volume_mute" },
			{ 57423, "volume_off" },
			{ 57424, "volume_up" },
			{ 60016, "volunteer_activism" },
			{ 57562, "vpn_key" },
			{ 60282, "vpn_key_off" },
			{ 58927, "vpn_lock" },
			{ 61570, "vrpano" },
			{ 57788, "wallpaper" },
			{ 60344, "warehouse" },
			{ 57346, "warning" },
			{ 61571, "warning_amber" },
			{ 61873, "wash" },
			{ 58164, "watch" },
			{ 59684, "watch_later" },
			{ 60131, "watch_off" },
			{ 61572, "water" },
			{ 61955, "water_damage" },
			{ 59288, "water_drop" },
			{ 59904, "waterfall_chart" },
			{ 57718, "waves" },
			{ 59238, "waving_hand" },
			{ 58412, "wb_auto" },
			{ 58413, "wb_cloudy" },
			{ 58414, "wb_incandescent" },
			{ 58422, "wb_iridescent" },
			{ 59905, "wb_shade" },
			{ 58416, "wb_sunny" },
			{ 57798, "wb_twilight" },
			{ 58941, "wc" },
			{ 57425, "web" },
			{ 57449, "web_asset" },
			{ 58615, "web_asset_off" },
			{ 60306, "webhook" },
			{ 57707, "weekend" },
			{ 61926, "west" },
			{ 60060, "whatsapp" },
			{ 59406, "whatshot" },
			{ 61867, "wheelchair_pickup" },
			{ 57719, "where_to_vote" },
			{ 57789, "widgets" },
			{ 58942, "wifi" },
			{ 61303, "wifi_calling" },
			{ 61573, "wifi_calling_3" },
			{ 60266, "wifi_channel" },
			{ 60209, "wifi_find" },
			{ 57825, "wifi_lock" },
			{ 58952, "wifi_off" },
			{ 60267, "wifi_password" },
			{ 61692, "wifi_protected_setup" },
			{ 57826, "wifi_tethering" },
			{ 60121, "wifi_tethering_error" },
			{ 61575, "wifi_tethering_off" },
			{ 61576, "window" },
			{ 61928, "wine_bar" },
			{ 57662, "woman" },
			{ 59641, "work" },
			{ 59714, "work_off" },
			{ 59715, "work_outline" },
			{ 59311, "workspace_premium" },
			{ 57760, "workspaces" },
			{ 57947, "wrap_text" },
			{ 61304, "wrong_location" },
			{ 61891, "wysiwyg" },
			{ 61577, "yard" },
			{ 59642, "youtube_searched_for" },
			{ 59647, "zoom_in" },
			{ 60205, "zoom_in_map" },
			{ 59648, "zoom_out" },
			{ 58731, "zoom_out_map" },
		};
		static Dictionary<string, int> ValueToIcon = new()
		{
			{ "10k", 59729 },
			{ "10mp", 59730 },
			{ "11mp", 59731 },
			{ "123", 60301 },
			{ "12mp", 59732 },
			{ "13mp", 59733 },
			{ "14mp", 59734 },
			{ "15mp", 59735 },
			{ "16mp", 59736 },
			{ "17mp", 59737 },
			{ "18mp", 59738 },
			{ "19mp", 59739 },
			{ "1k", 59740 },
			{ "1k_plus", 59741 },
			{ "1x_mobiledata", 61389 },
			{ "20mp", 59742 },
			{ "21mp", 59743 },
			{ "22mp", 59744 },
			{ "23mp", 59745 },
			{ "24mp", 59746 },
			{ "2k", 59747 },
			{ "2k_plus", 59748 },
			{ "2mp", 59749 },
			{ "30fps", 61390 },
			{ "30fps_select", 61391 },
			{ "360", 58743 },
			{ "3d_rotation", 59469 },
			{ "3g_mobiledata", 61392 },
			{ "3k", 59750 },
			{ "3k_plus", 59751 },
			{ "3mp", 59752 },
			{ "3p", 61393 },
			{ "4g_mobiledata", 61394 },
			{ "4g_plus_mobiledata", 61395 },
			{ "4k", 57458 },
			{ "4k_plus", 59753 },
			{ "4mp", 59754 },
			{ "5g", 61240 },
			{ "5k", 59755 },
			{ "5k_plus", 59756 },
			{ "5mp", 59757 },
			{ "60fps", 61396 },
			{ "60fps_select", 61397 },
			{ "6_ft_apart", 61982 },
			{ "6k", 59758 },
			{ "6k_plus", 59759 },
			{ "6mp", 59760 },
			{ "7k", 59761 },
			{ "7k_plus", 59762 },
			{ "7mp", 59763 },
			{ "8k", 59764 },
			{ "8k_plus", 59765 },
			{ "8mp", 59766 },
			{ "9k", 59767 },
			{ "9k_plus", 59768 },
			{ "9mp", 59769 },
			{ "abc", 60308 },
			{ "ac_unit", 60219 },
			{ "access_alarm", 57744 },
			{ "access_alarms", 57745 },
			{ "access_time", 57746 },
			{ "access_time_filled", 61398 },
			{ "accessibility", 59470 },
			{ "accessibility_new", 59692 },
			{ "accessible", 59668 },
			{ "accessible_forward", 59700 },
			{ "account_balance", 59471 },
			{ "account_balance_wallet", 59472 },
			{ "account_box", 59473 },
			{ "account_circle", 59475 },
			{ "account_tree", 59770 },
			{ "ad_units", 61241 },
			{ "adb", 58894 },
			{ "add", 57669 },
			{ "add_a_photo", 58425 },
			{ "add_alarm", 57747 },
			{ "add_alert", 57347 },
			{ "add_box", 57670 },
			{ "add_business", 59177 },
			{ "add_card", 60294 },
			{ "add_chart", 59771 },
			{ "add_circle", 57671 },
			{ "add_circle_outline", 57672 },
			{ "add_comment", 57958 },
			{ "add_ic_call", 59772 },
			{ "add_link", 57720 },
			{ "add_location", 58727 },
			{ "add_location_alt", 61242 },
			{ "add_moderator", 59773 },
			{ "add_photo_alternate", 58430 },
			{ "add_reaction", 57811 },
			{ "add_road", 61243 },
			{ "add_shopping_cart", 59476 },
			{ "add_task", 62010 },
			{ "add_to_drive", 58972 },
			{ "add_to_home_screen", 57854 },
			{ "add_to_photos", 58269 },
			{ "add_to_queue", 57436 },
			{ "addchart", 61244 },
			{ "adf_scanner", 60122 },
			{ "adjust", 58270 },
			{ "admin_panel_settings", 61245 },
			{ "ads_click", 59234 },
			{ "agriculture", 60025 },
			{ "air", 61400 },
			{ "airline_seat_flat", 58928 },
			{ "airline_seat_flat_angled", 58929 },
			{ "airline_seat_individual_suite", 58930 },
			{ "airline_seat_legroom_extra", 58931 },
			{ "airline_seat_legroom_normal", 58932 },
			{ "airline_seat_legroom_reduced", 58933 },
			{ "airline_seat_recline_extra", 58934 },
			{ "airline_seat_recline_normal", 58935 },
			{ "airline_stops", 59344 },
			{ "airlines", 59338 },
			{ "airplane_ticket", 61401 },
			{ "airplanemode_active", 57749 },
			{ "airplanemode_inactive", 57748 },
			{ "airplay", 57429 },
			{ "airport_shuttle", 60220 },
			{ "alarm", 59477 },
			{ "alarm_add", 59478 },
			{ "alarm_off", 59479 },
			{ "alarm_on", 59480 },
			{ "album", 57369 },
			{ "align_horizontal_center", 57359 },
			{ "align_horizontal_left", 57357 },
			{ "align_horizontal_right", 57360 },
			{ "align_vertical_bottom", 57365 },
			{ "align_vertical_center", 57361 },
			{ "align_vertical_top", 57356 },
			{ "all_inbox", 59775 },
			{ "all_inclusive", 60221 },
			{ "all_out", 59659 },
			{ "alt_route", 61828 },
			{ "alternate_email", 57574 },
			{ "analytics", 61246 },
			{ "anchor", 61901 },
			{ "android", 59481 },
			{ "animation", 59164 },
			{ "announcement", 59482 },
			{ "aod", 61402 },
			{ "apartment", 59968 },
			{ "api", 61879 },
			{ "app_blocking", 61247 },
			{ "app_registration", 61248 },
			{ "app_settings_alt", 61249 },
			{ "app_shortcut", 60132 },
			{ "approval", 59778 },
			{ "apps", 58819 },
			{ "apps_outage", 59340 },
			{ "architecture", 59963 },
			{ "archive", 57673 },
			{ "area_chart", 59248 },
			{ "arrow_back", 58820 },
			{ "arrow_back_ios", 58848 },
			{ "arrow_back_ios_new", 58090 },
			{ "arrow_circle_down", 61825 },
			{ "arrow_circle_left", 60071 },
			{ "arrow_circle_right", 60074 },
			{ "arrow_circle_up", 61826 },
			{ "arrow_downward", 58843 },
			{ "arrow_drop_down", 58821 },
			{ "arrow_drop_down_circle", 58822 },
			{ "arrow_drop_up", 58823 },
			{ "arrow_forward", 58824 },
			{ "arrow_forward_ios", 58849 },
			{ "arrow_left", 58846 },
			{ "arrow_right", 58847 },
			{ "arrow_right_alt", 59713 },
			{ "arrow_upward", 58840 },
			{ "art_track", 57440 },
			{ "article", 61250 },
			{ "aspect_ratio", 59483 },
			{ "assessment", 59484 },
			{ "assignment", 59485 },
			{ "assignment_ind", 59486 },
			{ "assignment_late", 59487 },
			{ "assignment_return", 59488 },
			{ "assignment_returned", 59489 },
			{ "assignment_turned_in", 59490 },
			{ "assistant", 58271 },
			{ "assistant_direction", 59784 },
			{ "assistant_photo", 58272 },
			{ "assured_workload", 60271 },
			{ "atm", 58739 },
			{ "attach_email", 59998 },
			{ "attach_file", 57894 },
			{ "attach_money", 57895 },
			{ "attachment", 58044 },
			{ "attractions", 59986 },
			{ "attribution", 61403 },
			{ "audio_file", 60290 },
			{ "audiotrack", 58273 },
			{ "auto_awesome", 58975 },
			{ "auto_awesome_mosaic", 58976 },
			{ "auto_awesome_motion", 58977 },
			{ "auto_delete", 59980 },
			{ "auto_fix_high", 58979 },
			{ "auto_fix_normal", 58980 },
			{ "auto_fix_off", 58981 },
			{ "auto_graph", 58619 },
			{ "auto_stories", 58982 },
			{ "autofps_select", 61404 },
			{ "autorenew", 59491 },
			{ "av_timer", 57371 },
			{ "baby_changing_station", 61851 },
			{ "back_hand", 59236 },
			{ "backpack", 61852 },
			{ "backspace", 57674 },
			{ "backup", 59492 },
			{ "backup_table", 61251 },
			{ "badge", 60007 },
			{ "bakery_dining", 59987 },
			{ "balance", 60150 },
			{ "balcony", 58767 },
			{ "ballot", 57714 },
			{ "bar_chart", 57963 },
			{ "batch_prediction", 61685 },
			{ "bathroom", 61405 },
			{ "bathtub", 59969 },
			{ "battery_alert", 57756 },
			{ "battery_charging_full", 57763 },
			{ "battery_full", 57764 },
			{ "battery_saver", 61406 },
			{ "battery_std", 57765 },
			{ "battery_unknown", 57766 },
			{ "beach_access", 60222 },
			{ "bed", 61407 },
			{ "bedroom_baby", 61408 },
			{ "bedroom_child", 61409 },
			{ "bedroom_parent", 61410 },
			{ "bedtime", 61252 },
			{ "bedtime_off", 60278 },
			{ "beenhere", 58669 },
			{ "bento", 61940 },
			{ "bike_scooter", 61253 },
			{ "biotech", 59962 },
			{ "blender", 61411 },
			{ "block", 57675 },
			{ "bloodtype", 61412 },
			{ "bluetooth", 57767 },
			{ "bluetooth_audio", 58895 },
			{ "bluetooth_connected", 57768 },
			{ "bluetooth_disabled", 57769 },
			{ "bluetooth_drive", 61413 },
			{ "bluetooth_searching", 57770 },
			{ "blur_circular", 58274 },
			{ "blur_linear", 58275 },
			{ "blur_off", 58276 },
			{ "blur_on", 58277 },
			{ "bolt", 59915 },
			{ "book", 59493 },
			{ "book_online", 61975 },
			{ "bookmark", 59494 },
			{ "bookmark_add", 58776 },
			{ "bookmark_added", 58777 },
			{ "bookmark_border", 59495 },
			{ "bookmark_remove", 58778 },
			{ "bookmarks", 59787 },
			{ "border_all", 57896 },
			{ "border_bottom", 57897 },
			{ "border_clear", 57898 },
			{ "border_color", 57899 },
			{ "border_horizontal", 57900 },
			{ "border_inner", 57901 },
			{ "border_left", 57902 },
			{ "border_outer", 57903 },
			{ "border_right", 57904 },
			{ "border_style", 57905 },
			{ "border_top", 57906 },
			{ "border_vertical", 57907 },
			{ "boy", 60263 },
			{ "branding_watermark", 57451 },
			{ "breakfast_dining", 59988 },
			{ "brightness_1", 58278 },
			{ "brightness_2", 58279 },
			{ "brightness_3", 58280 },
			{ "brightness_4", 58281 },
			{ "brightness_5", 58282 },
			{ "brightness_6", 58283 },
			{ "brightness_7", 58284 },
			{ "brightness_auto", 57771 },
			{ "brightness_high", 57772 },
			{ "brightness_low", 57773 },
			{ "brightness_medium", 57774 },
			{ "broken_image", 58285 },
			{ "browse_gallery", 60369 },
			{ "browser_not_supported", 61255 },
			{ "browser_updated", 59343 },
			{ "brunch_dining", 60019 },
			{ "brush", 58286 },
			{ "bubble_chart", 59101 },
			{ "bug_report", 59496 },
			{ "build", 59497 },
			{ "build_circle", 61256 },
			{ "bungalow", 58769 },
			{ "burst_mode", 58428 },
			{ "bus_alert", 59791 },
			{ "business", 57519 },
			{ "business_center", 60223 },
			{ "cabin", 58761 },
			{ "cable", 61414 },
			{ "cached", 59498 },
			{ "cake", 59369 },
			{ "calculate", 59999 },
			{ "calendar_month", 60364 },
			{ "calendar_today", 59701 },
			{ "calendar_view_day", 59702 },
			{ "calendar_view_month", 61415 },
			{ "calendar_view_week", 61416 },
			{ "call", 57520 },
			{ "call_end", 57521 },
			{ "call_made", 57522 },
			{ "call_merge", 57523 },
			{ "call_missed", 57524 },
			{ "call_missed_outgoing", 57572 },
			{ "call_received", 57525 },
			{ "call_split", 57526 },
			{ "call_to_action", 57452 },
			{ "camera", 58287 },
			{ "camera_alt", 58288 },
			{ "camera_enhance", 59644 },
			{ "camera_front", 58289 },
			{ "camera_indoor", 61417 },
			{ "camera_outdoor", 61418 },
			{ "camera_rear", 58290 },
			{ "camera_roll", 58291 },
			{ "cameraswitch", 61419 },
			{ "campaign", 61257 },
			{ "cancel", 58825 },
			{ "cancel_presentation", 57577 },
			{ "cancel_schedule_send", 59961 },
			{ "candlestick_chart", 60116 },
			{ "car_rental", 59989 },
			{ "car_repair", 59990 },
			{ "card_giftcard", 59638 },
			{ "card_membership", 59639 },
			{ "card_travel", 59640 },
			{ "carpenter", 61944 },
			{ "cases", 59794 },
			{ "casino", 60224 },
			{ "cast", 58119 },
			{ "cast_connected", 58120 },
			{ "cast_for_education", 61420 },
			{ "castle", 60081 },
			{ "catching_pokemon", 58632 },
			{ "category", 58740 },
			{ "celebration", 60005 },
			{ "cell_tower", 60346 },
			{ "cell_wifi", 57580 },
			{ "center_focus_strong", 58292 },
			{ "center_focus_weak", 58293 },
			{ "chair", 61421 },
			{ "chair_alt", 61422 },
			{ "chalet", 58757 },
			{ "change_circle", 58087 },
			{ "change_history", 59499 },
			{ "charging_station", 61853 },
			{ "chat", 57527 },
			{ "chat_bubble", 57546 },
			{ "chat_bubble_outline", 57547 },
			{ "check", 58826 },
			{ "check_box", 59444 },
			{ "check_box_outline_blank", 59445 },
			{ "check_circle", 59500 },
			{ "check_circle_outline", 59693 },
			{ "checklist", 59057 },
			{ "checklist_rtl", 59059 },
			{ "checkroom", 61854 },
			{ "chevron_left", 58827 },
			{ "chevron_right", 58828 },
			{ "child_care", 60225 },
			{ "child_friendly", 60226 },
			{ "chrome_reader_mode", 59501 },
			{ "church", 60078 },
			{ "circle", 61258 },
			{ "circle_notifications", 59796 },
			{ "class", 59502 },
			{ "clean_hands", 61983 },
			{ "cleaning_services", 61695 },
			{ "clear", 57676 },
			{ "clear_all", 57528 },
			{ "close", 58829 },
			{ "close_fullscreen", 61903 },
			{ "closed_caption", 57372 },
			{ "closed_caption_disabled", 61916 },
			{ "closed_caption_off", 59798 },
			{ "cloud", 58045 },
			{ "cloud_circle", 58046 },
			{ "cloud_done", 58047 },
			{ "cloud_download", 58048 },
			{ "cloud_off", 58049 },
			{ "cloud_queue", 58050 },
			{ "cloud_sync", 60250 },
			{ "cloud_upload", 58051 },
			{ "co2", 59312 },
			{ "co_present", 60144 },
			{ "code", 59503 },
			{ "code_off", 58611 },
			{ "coffee", 61423 },
			{ "coffee_maker", 61424 },
			{ "collections", 58294 },
			{ "collections_bookmark", 58417 },
			{ "color_lens", 58295 },
			{ "colorize", 58296 },
			{ "comment", 57529 },
			{ "comment_bank", 59982 },
			{ "comments_disabled", 59298 },
			{ "commit", 60149 },
			{ "commute", 59712 },
			{ "compare", 58297 },
			{ "compare_arrows", 59669 },
			{ "compass_calibration", 58748 },
			{ "compost", 59233 },
			{ "compress", 59725 },
			{ "computer", 58122 },
			{ "confirmation_number", 58936 },
			{ "connect_without_contact", 61987 },
			{ "connected_tv", 59800 },
			{ "connecting_airports", 59337 },
			{ "construction", 59964 },
			{ "contact_mail", 57552 },
			{ "contact_page", 61998 },
			{ "contact_phone", 57551 },
			{ "contact_support", 59724 },
			{ "contactless", 60017 },
			{ "contacts", 57530 },
			{ "content_copy", 57677 },
			{ "content_cut", 57678 },
			{ "content_paste", 57679 },
			{ "content_paste_go", 60046 },
			{ "content_paste_off", 58616 },
			{ "content_paste_search", 60059 },
			{ "contrast", 60215 },
			{ "control_camera", 57460 },
			{ "control_point", 58298 },
			{ "control_point_duplicate", 58299 },
			{ "cookie", 60076 },
			{ "copy_all", 58092 },
			{ "copyright", 59660 },
			{ "coronavirus", 61985 },
			{ "corporate_fare", 61904 },
			{ "cottage", 58759 },
			{ "countertops", 61943 },
			{ "create", 57680 },
			{ "create_new_folder", 58060 },
			{ "credit_card", 59504 },
			{ "credit_card_off", 58612 },
			{ "credit_score", 61425 },
			{ "crib", 58760 },
			{ "crop", 58302 },
			{ "crop_16_9", 58300 },
			{ "crop_3_2", 58301 },
			{ "crop_5_4", 58303 },
			{ "crop_7_5", 58304 },
			{ "crop_din", 58305 },
			{ "crop_free", 58306 },
			{ "crop_landscape", 58307 },
			{ "crop_original", 58308 },
			{ "crop_portrait", 58309 },
			{ "crop_rotate", 58423 },
			{ "crop_square", 58310 },
			{ "cruelty_free", 59289 },
			{ "css", 60307 },
			{ "currency_bitcoin", 60357 },
			{ "currency_exchange", 60272 },
			{ "currency_franc", 60154 },
			{ "currency_lira", 60143 },
			{ "currency_pound", 60145 },
			{ "currency_ruble", 60140 },
			{ "currency_rupee", 60151 },
			{ "currency_yen", 60155 },
			{ "currency_yuan", 60153 },
			{ "dangerous", 59802 },
			{ "dark_mode", 58652 },
			{ "dashboard", 59505 },
			{ "dashboard_customize", 59803 },
			{ "data_array", 60113 },
			{ "data_exploration", 59247 },
			{ "data_object", 60115 },
			{ "data_saver_off", 61426 },
			{ "data_saver_on", 61427 },
			{ "data_thresholding", 60319 },
			{ "data_usage", 57775 },
			{ "date_range", 59670 },
			{ "deblur", 60279 },
			{ "deck", 59970 },
			{ "dehaze", 58311 },
			{ "delete", 59506 },
			{ "delete_forever", 59691 },
			{ "delete_outline", 59694 },
			{ "delete_sweep", 57708 },
			{ "delivery_dining", 60018 },
			{ "density_large", 60329 },
			{ "density_medium", 60318 },
			{ "density_small", 60328 },
			{ "departure_board", 58742 },
			{ "description", 59507 },
			{ "deselect", 60342 },
			{ "design_services", 61706 },
			{ "desktop_access_disabled", 59805 },
			{ "desktop_mac", 58123 },
			{ "desktop_windows", 58124 },
			{ "details", 58312 },
			{ "developer_board", 58125 },
			{ "developer_board_off", 58623 },
			{ "developer_mode", 57776 },
			{ "device_hub", 58165 },
			{ "device_thermostat", 57855 },
			{ "device_unknown", 58169 },
			{ "devices", 57777 },
			{ "devices_other", 58167 },
			{ "dialer_sip", 57531 },
			{ "dialpad", 57532 },
			{ "diamond", 60117 },
			{ "difference", 60285 },
			{ "dining", 61428 },
			{ "dinner_dining", 59991 },
			{ "directions", 58670 },
			{ "directions_bike", 58671 },
			{ "directions_boat", 58674 },
			{ "directions_boat_filled", 61429 },
			{ "directions_bus", 58672 },
			{ "directions_bus_filled", 61430 },
			{ "directions_car", 58673 },
			{ "directions_car_filled", 61431 },
			{ "directions_off", 61711 },
			{ "directions_railway", 58676 },
			{ "directions_railway_filled", 61432 },
			{ "directions_run", 58726 },
			{ "directions_subway", 58675 },
			{ "directions_subway_filled", 61433 },
			{ "directions_transit", 58677 },
			{ "directions_transit_filled", 61434 },
			{ "directions_walk", 58678 },
			{ "dirty_lens", 61259 },
			{ "disabled_by_default", 62000 },
			{ "disabled_visible", 59246 },
			{ "disc_full", 58896 },
			{ "discount", 60361 },
			{ "display_settings", 60311 },
			{ "dns", 59509 },
			{ "do_disturb", 61580 },
			{ "do_disturb_alt", 61581 },
			{ "do_disturb_off", 61582 },
			{ "do_disturb_on", 61583 },
			{ "do_not_disturb", 58898 },
			{ "do_not_disturb_alt", 58897 },
			{ "do_not_disturb_off", 58947 },
			{ "do_not_disturb_on", 58948 },
			{ "do_not_disturb_on_total_silence", 61435 },
			{ "do_not_step", 61855 },
			{ "do_not_touch", 61872 },
			{ "dock", 58126 },
			{ "document_scanner", 58874 },
			{ "domain", 59374 },
			{ "domain_add", 60258 },
			{ "domain_disabled", 57583 },
			{ "domain_verification", 61260 },
			{ "done", 59510 },
			{ "done_all", 59511 },
			{ "done_outline", 59695 },
			{ "donut_large", 59671 },
			{ "donut_small", 59672 },
			{ "door_back", 61436 },
			{ "door_front", 61437 },
			{ "door_sliding", 61438 },
			{ "doorbell", 61439 },
			{ "double_arrow", 59984 },
			{ "downhill_skiing", 58633 },
			{ "download", 61584 },
			{ "download_done", 61585 },
			{ "download_for_offline", 61440 },
			{ "downloading", 61441 },
			{ "drafts", 57681 },
			{ "drag_handle", 57949 },
			{ "drag_indicator", 59717 },
			{ "draw", 59206 },
			{ "drive_eta", 58899 },
			{ "drive_file_move", 58997 },
			{ "drive_file_move_rtl", 59245 },
			{ "drive_file_rename_outline", 59810 },
			{ "drive_folder_upload", 59811 },
			{ "dry", 61875 },
			{ "dry_cleaning", 59992 },
			{ "duo", 59813 },
			{ "dvr", 57778 },
			{ "dynamic_feed", 59924 },
			{ "dynamic_form", 61887 },
			{ "e_mobiledata", 61442 },
			{ "earbuds", 61443 },
			{ "earbuds_battery", 61444 },
			{ "east", 61919 },
			{ "edgesensor_high", 61445 },
			{ "edgesensor_low", 61446 },
			{ "edit", 58313 },
			{ "edit_attributes", 58744 },
			{ "edit_calendar", 59202 },
			{ "edit_location", 58728 },
			{ "edit_location_alt", 57797 },
			{ "edit_note", 59205 },
			{ "edit_notifications", 58661 },
			{ "edit_off", 59728 },
			{ "edit_road", 61261 },
			{ "egg", 60108 },
			{ "egg_alt", 60104 },
			{ "eject", 59643 },
			{ "elderly", 61978 },
			{ "elderly_woman", 60265 },
			{ "electric_bike", 60187 },
			{ "electric_car", 60188 },
			{ "electric_moped", 60189 },
			{ "electric_rickshaw", 60190 },
			{ "electric_scooter", 60191 },
			{ "electrical_services", 61698 },
			{ "elevator", 61856 },
			{ "email", 57534 },
			{ "emergency", 57835 },
			{ "emoji_emotions", 59938 },
			{ "emoji_events", 59939 },
			{ "emoji_food_beverage", 59931 },
			{ "emoji_nature", 59932 },
			{ "emoji_objects", 59940 },
			{ "emoji_people", 59933 },
			{ "emoji_symbols", 59934 },
			{ "emoji_transportation", 59935 },
			{ "engineering", 59965 },
			{ "enhanced_encryption", 58943 },
			{ "equalizer", 57373 },
			{ "error", 57344 },
			{ "error_outline", 57345 },
			{ "escalator", 61857 },
			{ "escalator_warning", 61868 },
			{ "euro", 59925 },
			{ "euro_symbol", 59686 },
			{ "ev_station", 58733 },
			{ "event", 59512 },
			{ "event_available", 58900 },
			{ "event_busy", 58901 },
			{ "event_note", 58902 },
			{ "event_repeat", 60283 },
			{ "event_seat", 59651 },
			{ "exit_to_app", 59513 },
			{ "expand", 59727 },
			{ "expand_circle_down", 59341 },
			{ "expand_less", 58830 },
			{ "expand_more", 58831 },
			{ "explicit", 57374 },
			{ "explore", 59514 },
			{ "explore_off", 59816 },
			{ "exposure", 58314 },
			{ "exposure_neg_1", 58315 },
			{ "exposure_neg_2", 58316 },
			{ "exposure_plus_1", 58317 },
			{ "exposure_plus_2", 58318 },
			{ "exposure_zero", 58319 },
			{ "extension", 59515 },
			{ "extension_off", 58613 },
			{ "face", 59516 },
			{ "face_retouching_natural", 61262 },
			{ "face_retouching_off", 61447 },
			{ "fact_check", 61637 },
			{ "factory", 60348 },
			{ "family_restroom", 61858 },
			{ "fast_forward", 57375 },
			{ "fast_rewind", 57376 },
			{ "fastfood", 58746 },
			{ "favorite", 59517 },
			{ "favorite_border", 59518 },
			{ "fax", 60120 },
			{ "featured_play_list", 57453 },
			{ "featured_video", 57454 },
			{ "feed", 61449 },
			{ "feedback", 59519 },
			{ "female", 58768 },
			{ "fence", 61942 },
			{ "festival", 60008 },
			{ "fiber_dvr", 57437 },
			{ "fiber_manual_record", 57441 },
			{ "fiber_new", 57438 },
			{ "fiber_pin", 57450 },
			{ "fiber_smart_record", 57442 },
			{ "file_copy", 57715 },
			{ "file_download", 58052 },
			{ "file_download_done", 59818 },
			{ "file_download_off", 58622 },
			{ "file_open", 60147 },
			{ "file_present", 59918 },
			{ "file_upload", 58054 },
			{ "filter", 58323 },
			{ "filter_1", 58320 },
			{ "filter_2", 58321 },
			{ "filter_3", 58322 },
			{ "filter_4", 58324 },
			{ "filter_5", 58325 },
			{ "filter_6", 58326 },
			{ "filter_7", 58327 },
			{ "filter_8", 58328 },
			{ "filter_9", 58329 },
			{ "filter_9_plus", 58330 },
			{ "filter_alt", 61263 },
			{ "filter_alt_off", 60210 },
			{ "filter_b_and_w", 58331 },
			{ "filter_center_focus", 58332 },
			{ "filter_drama", 58333 },
			{ "filter_frames", 58334 },
			{ "filter_hdr", 58335 },
			{ "filter_list", 57682 },
			{ "filter_list_off", 60247 },
			{ "filter_none", 58336 },
			{ "filter_tilt_shift", 58338 },
			{ "filter_vintage", 58339 },
			{ "find_in_page", 59520 },
			{ "find_replace", 59521 },
			{ "fingerprint", 59661 },
			{ "fire_extinguisher", 61912 },
			{ "fireplace", 59971 },
			{ "first_page", 58844 },
			{ "fit_screen", 59920 },
			{ "fitbit", 59435 },
			{ "fitness_center", 60227 },
			{ "flag", 57683 },
			{ "flag_circle", 60152 },
			{ "flaky", 61264 },
			{ "flare", 58340 },
			{ "flash_auto", 58341 },
			{ "flash_off", 58342 },
			{ "flash_on", 58343 },
			{ "flashlight_off", 61450 },
			{ "flashlight_on", 61451 },
			{ "flatware", 61452 },
			{ "flight", 58681 },
			{ "flight_class", 59339 },
			{ "flight_land", 59652 },
			{ "flight_takeoff", 59653 },
			{ "flip", 58344 },
			{ "flip_camera_android", 59959 },
			{ "flip_camera_ios", 59960 },
			{ "flip_to_back", 59522 },
			{ "flip_to_front", 59523 },
			{ "flourescent", 61453 },
			{ "flutter_dash", 57355 },
			{ "fmd_bad", 61454 },
			{ "fmd_good", 61455 },
			{ "folder", 58055 },
			{ "folder_copy", 60349 },
			{ "folder_delete", 60212 },
			{ "folder_off", 60291 },
			{ "folder_open", 58056 },
			{ "folder_shared", 58057 },
			{ "folder_special", 58903 },
			{ "folder_zip", 60204 },
			{ "follow_the_signs", 61986 },
			{ "font_download", 57703 },
			{ "font_download_off", 58617 },
			{ "food_bank", 61938 },
			{ "forest", 60057 },
			{ "fork_left", 60320 },
			{ "fork_right", 60332 },
			{ "format_align_center", 57908 },
			{ "format_align_justify", 57909 },
			{ "format_align_left", 57910 },
			{ "format_align_right", 57911 },
			{ "format_bold", 57912 },
			{ "format_clear", 57913 },
			{ "format_color_fill", 57914 },
			{ "format_color_reset", 57915 },
			{ "format_color_text", 57916 },
			{ "format_indent_decrease", 57917 },
			{ "format_indent_increase", 57918 },
			{ "format_italic", 57919 },
			{ "format_line_spacing", 57920 },
			{ "format_list_bulleted", 57921 },
			{ "format_list_numbered", 57922 },
			{ "format_list_numbered_rtl", 57959 },
			{ "format_overline", 60261 },
			{ "format_paint", 57923 },
			{ "format_quote", 57924 },
			{ "format_shapes", 57950 },
			{ "format_size", 57925 },
			{ "format_strikethrough", 57926 },
			{ "format_textdirection_l_to_r", 57927 },
			{ "format_textdirection_r_to_l", 57928 },
			{ "format_underlined", 57929 },
			{ "fort", 60077 },
			{ "forum", 57535 },
			{ "forward", 57684 },
			{ "forward_10", 57430 },
			{ "forward_30", 57431 },
			{ "forward_5", 57432 },
			{ "forward_to_inbox", 61831 },
			{ "foundation", 61952 },
			{ "free_breakfast", 60228 },
			{ "free_cancellation", 59208 },
			{ "front_hand", 59241 },
			{ "fullscreen", 58832 },
			{ "fullscreen_exit", 58833 },
			{ "functions", 57930 },
			{ "g_mobiledata", 61456 },
			{ "g_translate", 59687 },
			{ "gamepad", 58127 },
			{ "games", 57377 },
			{ "garage", 61457 },
			{ "gavel", 59662 },
			{ "generating_tokens", 59209 },
			{ "gesture", 57685 },
			{ "get_app", 59524 },
			{ "gif", 59656 },
			{ "gif_box", 59299 },
			{ "girl", 60264 },
			{ "gite", 58763 },
			{ "golf_course", 60229 },
			{ "gpp_bad", 61458 },
			{ "gpp_good", 61459 },
			{ "gpp_maybe", 61460 },
			{ "gps_fixed", 57779 },
			{ "gps_not_fixed", 57780 },
			{ "gps_off", 57781 },
			{ "grade", 59525 },
			{ "gradient", 58345 },
			{ "grading", 59983 },
			{ "grain", 58346 },
			{ "graphic_eq", 57784 },
			{ "grass", 61957 },
			{ "grid_3x3", 61461 },
			{ "grid_4x4", 61462 },
			{ "grid_goldenratio", 61463 },
			{ "grid_off", 58347 },
			{ "grid_on", 58348 },
			{ "grid_view", 59824 },
			{ "group", 59375 },
			{ "group_add", 59376 },
			{ "group_off", 59207 },
			{ "group_remove", 59309 },
			{ "group_work", 59526 },
			{ "groups", 62003 },
			{ "h_mobiledata", 61464 },
			{ "h_plus_mobiledata", 61465 },
			{ "hail", 59825 },
			{ "handshake", 60363 },
			{ "handyman", 61707 },
			{ "hardware", 59993 },
			{ "hd", 57426 },
			{ "hdr_auto", 61466 },
			{ "hdr_auto_select", 61467 },
			{ "hdr_enhanced_select", 61265 },
			{ "hdr_off", 58349 },
			{ "hdr_off_select", 61468 },
			{ "hdr_on", 58350 },
			{ "hdr_on_select", 61469 },
			{ "hdr_plus", 61470 },
			{ "hdr_strong", 58353 },
			{ "hdr_weak", 58354 },
			{ "headphones", 61471 },
			{ "headphones_battery", 61472 },
			{ "headset", 58128 },
			{ "headset_mic", 58129 },
			{ "headset_off", 58170 },
			{ "healing", 58355 },
			{ "health_and_safety", 57813 },
			{ "hearing", 57379 },
			{ "hearing_disabled", 61700 },
			{ "heart_broken", 60098 },
			{ "height", 59926 },
			{ "help", 59527 },
			{ "help_center", 61888 },
			{ "help_outline", 59645 },
			{ "hevc", 61473 },
			{ "hexagon", 60217 },
			{ "hide_image", 61474 },
			{ "hide_source", 61475 },
			{ "high_quality", 57380 },
			{ "highlight", 57951 },
			{ "highlight_alt", 61266 },
			{ "highlight_off", 59528 },
			{ "hiking", 58634 },
			{ "history", 59529 },
			{ "history_edu", 59966 },
			{ "history_toggle_off", 61821 },
			{ "hive", 60070 },
			{ "hls", 60298 },
			{ "hls_off", 60300 },
			{ "holiday_village", 58762 },
			{ "home", 59530 },
			{ "home_max", 61476 },
			{ "home_mini", 61477 },
			{ "home_repair_service", 61696 },
			{ "home_work", 59913 },
			{ "horizontal_distribute", 57364 },
			{ "horizontal_rule", 61704 },
			{ "horizontal_split", 59719 },
			{ "hot_tub", 60230 },
			{ "hotel", 58682 },
			{ "hotel_class", 59203 },
			{ "hourglass_bottom", 59996 },
			{ "hourglass_disabled", 61267 },
			{ "hourglass_empty", 59531 },
			{ "hourglass_full", 59532 },
			{ "hourglass_top", 59995 },
			{ "house", 59972 },
			{ "house_siding", 61954 },
			{ "houseboat", 58756 },
			{ "how_to_reg", 57716 },
			{ "how_to_vote", 57717 },
			{ "html", 60286 },
			{ "http", 59650 },
			{ "https", 59533 },
			{ "hub", 59892 },
			{ "hvac", 61710 },
			{ "ice_skating", 58635 },
			{ "icecream", 60009 },
			{ "image", 58356 },
			{ "image_aspect_ratio", 58357 },
			{ "image_not_supported", 61718 },
			{ "image_search", 58431 },
			{ "imagesearch_roller", 59828 },
			{ "import_contacts", 57568 },
			{ "import_export", 57539 },
			{ "important_devices", 59666 },
			{ "inbox", 57686 },
			{ "incomplete_circle", 59291 },
			{ "indeterminate_check_box", 59657 },
			{ "info", 59534 },
			{ "input", 59536 },
			{ "insert_chart", 57931 },
			{ "insert_chart_outlined", 57962 },
			{ "insert_comment", 57932 },
			{ "insert_drive_file", 57933 },
			{ "insert_emoticon", 57934 },
			{ "insert_invitation", 57935 },
			{ "insert_link", 57936 },
			{ "insert_page_break", 60106 },
			{ "insert_photo", 57937 },
			{ "insights", 61586 },
			{ "install_desktop", 60273 },
			{ "install_mobile", 60274 },
			{ "integration_instructions", 61268 },
			{ "interests", 59336 },
			{ "interpreter_mode", 59451 },
			{ "inventory", 57721 },
			{ "inventory_2", 57761 },
			{ "invert_colors", 59537 },
			{ "invert_colors_off", 57540 },
			{ "ios_share", 59064 },
			{ "iron", 58755 },
			{ "iso", 58358 },
			{ "javascript", 60284 },
			{ "join_full", 60139 },
			{ "join_inner", 60148 },
			{ "join_left", 60146 },
			{ "join_right", 60138 },
			{ "kayaking", 58636 },
			{ "kebab_dining", 59458 },
			{ "key", 59196 },
			{ "key_off", 60292 },
			{ "keyboard", 58130 },
			{ "keyboard_alt", 61480 },
			{ "keyboard_arrow_down", 58131 },
			{ "keyboard_arrow_left", 58132 },
			{ "keyboard_arrow_right", 58133 },
			{ "keyboard_arrow_up", 58134 },
			{ "keyboard_backspace", 58135 },
			{ "keyboard_capslock", 58136 },
			{ "keyboard_command_key", 60135 },
			{ "keyboard_control_key", 60134 },
			{ "keyboard_double_arrow_down", 60112 },
			{ "keyboard_double_arrow_left", 60099 },
			{ "keyboard_double_arrow_right", 60105 },
			{ "keyboard_double_arrow_up", 60111 },
			{ "keyboard_hide", 58138 },
			{ "keyboard_option_key", 60136 },
			{ "keyboard_return", 58139 },
			{ "keyboard_tab", 58140 },
			{ "keyboard_voice", 58141 },
			{ "king_bed", 59973 },
			{ "kitchen", 60231 },
			{ "kitesurfing", 58637 },
			{ "label", 59538 },
			{ "label_important", 59703 },
			{ "label_off", 59830 },
			{ "lan", 60207 },
			{ "landscape", 58359 },
			{ "language", 59540 },
			{ "laptop", 58142 },
			{ "laptop_chromebook", 58143 },
			{ "laptop_mac", 58144 },
			{ "laptop_windows", 58145 },
			{ "last_page", 58845 },
			{ "launch", 59541 },
			{ "layers", 58683 },
			{ "layers_clear", 58684 },
			{ "leaderboard", 61964 },
			{ "leak_add", 58360 },
			{ "leak_remove", 58361 },
			{ "legend_toggle", 61723 },
			{ "lens", 58362 },
			{ "lens_blur", 61481 },
			{ "library_add", 57390 },
			{ "library_add_check", 59831 },
			{ "library_books", 57391 },
			{ "library_music", 57392 },
			{ "light", 61482 },
			{ "light_mode", 58648 },
			{ "lightbulb", 57584 },
			{ "line_axis", 60058 },
			{ "line_style", 59673 },
			{ "line_weight", 59674 },
			{ "linear_scale", 57952 },
			{ "link", 57687 },
			{ "link_off", 57711 },
			{ "linked_camera", 58424 },
			{ "liquor", 60000 },
			{ "list", 59542 },
			{ "list_alt", 57582 },
			{ "live_help", 57542 },
			{ "live_tv", 58937 },
			{ "living", 61483 },
			{ "local_activity", 58687 },
			{ "local_airport", 58685 },
			{ "local_atm", 58686 },
			{ "local_bar", 58688 },
			{ "local_cafe", 58689 },
			{ "local_car_wash", 58690 },
			{ "local_convenience_store", 58691 },
			{ "local_dining", 58710 },
			{ "local_drink", 58692 },
			{ "local_fire_department", 61269 },
			{ "local_florist", 58693 },
			{ "local_gas_station", 58694 },
			{ "local_grocery_store", 58695 },
			{ "local_hospital", 58696 },
			{ "local_hotel", 58697 },
			{ "local_laundry_service", 58698 },
			{ "local_library", 58699 },
			{ "local_mall", 58700 },
			{ "local_movies", 58701 },
			{ "local_offer", 58702 },
			{ "local_parking", 58703 },
			{ "local_pharmacy", 58704 },
			{ "local_phone", 58705 },
			{ "local_pizza", 58706 },
			{ "local_play", 58707 },
			{ "local_police", 61270 },
			{ "local_post_office", 58708 },
			{ "local_printshop", 58709 },
			{ "local_see", 58711 },
			{ "local_shipping", 58712 },
			{ "local_taxi", 58713 },
			{ "location_city", 59377 },
			{ "location_disabled", 57782 },
			{ "location_off", 57543 },
			{ "location_on", 57544 },
			{ "location_searching", 57783 },
			{ "lock", 59543 },
			{ "lock_clock", 61271 },
			{ "lock_open", 59544 },
			{ "lock_reset", 60126 },
			{ "login", 60023 },
			{ "logo_dev", 60118 },
			{ "logout", 59834 },
			{ "looks", 58364 },
			{ "looks_3", 58363 },
			{ "looks_4", 58365 },
			{ "looks_5", 58366 },
			{ "looks_6", 58367 },
			{ "looks_one", 58368 },
			{ "looks_two", 58369 },
			{ "loop", 57384 },
			{ "loupe", 58370 },
			{ "low_priority", 57709 },
			{ "loyalty", 59546 },
			{ "lte_mobiledata", 61484 },
			{ "lte_plus_mobiledata", 61485 },
			{ "luggage", 62005 },
			{ "lunch_dining", 60001 },
			{ "mail", 57688 },
			{ "mail_outline", 57569 },
			{ "male", 58766 },
			{ "man", 58603 },
			{ "manage_accounts", 61486 },
			{ "manage_search", 61487 },
			{ "map", 58715 },
			{ "maps_home_work", 61488 },
			{ "maps_ugc", 61272 },
			{ "margin", 59835 },
			{ "mark_as_unread", 59836 },
			{ "mark_chat_read", 61835 },
			{ "mark_chat_unread", 61833 },
			{ "mark_email_read", 61836 },
			{ "mark_email_unread", 61834 },
			{ "mark_unread_chat_alt", 60317 },
			{ "markunread", 57689 },
			{ "markunread_mailbox", 59547 },
			{ "masks", 61976 },
			{ "maximize", 59696 },
			{ "media_bluetooth_off", 61489 },
			{ "media_bluetooth_on", 61490 },
			{ "mediation", 61351 },
			{ "medical_services", 61705 },
			{ "medication", 61491 },
			{ "medication_liquid", 60039 },
			{ "meeting_room", 60239 },
			{ "memory", 58146 },
			{ "menu", 58834 },
			{ "menu_book", 59929 },
			{ "menu_open", 59837 },
			{ "merge", 60312 },
			{ "merge_type", 57938 },
			{ "message", 57545 },
			{ "mic", 57385 },
			{ "mic_external_off", 61273 },
			{ "mic_external_on", 61274 },
			{ "mic_none", 57386 },
			{ "mic_off", 57387 },
			{ "microwave", 61956 },
			{ "military_tech", 59967 },
			{ "minimize", 59697 },
			{ "miscellaneous_services", 61708 },
			{ "missed_video_call", 57459 },
			{ "mms", 58904 },
			{ "mobile_friendly", 57856 },
			{ "mobile_off", 57857 },
			{ "mobile_screen_share", 57575 },
			{ "mobiledata_off", 61492 },
			{ "mode", 61591 },
			{ "mode_comment", 57939 },
			{ "mode_edit", 57940 },
			{ "mode_edit_outline", 61493 },
			{ "mode_night", 61494 },
			{ "mode_of_travel", 59342 },
			{ "mode_standby", 61495 },
			{ "model_training", 61647 },
			{ "monetization_on", 57955 },
			{ "money", 58749 },
			{ "money_off", 57948 },
			{ "money_off_csred", 61496 },
			{ "monitor", 61275 },
			{ "monitor_heart", 60066 },
			{ "monitor_weight", 61497 },
			{ "monochrome_photos", 58371 },
			{ "mood", 59378 },
			{ "mood_bad", 59379 },
			{ "moped", 60200 },
			{ "more", 58905 },
			{ "more_horiz", 58835 },
			{ "more_time", 59997 },
			{ "more_vert", 58836 },
			{ "mosque", 60082 },
			{ "motion_photos_auto", 61498 },
			{ "motion_photos_off", 59840 },
			{ "motion_photos_on", 59841 },
			{ "motion_photos_pause", 61991 },
			{ "motion_photos_paused", 59842 },
			{ "mouse", 58147 },
			{ "move_down", 60257 },
			{ "move_to_inbox", 57704 },
			{ "move_up", 60260 },
			{ "movie", 57388 },
			{ "movie_creation", 58372 },
			{ "movie_filter", 58426 },
			{ "moving", 58625 },
			{ "mp", 59843 },
			{ "multiline_chart", 59103 },
			{ "multiple_stop", 61881 },
			{ "museum", 59958 },
			{ "music_note", 58373 },
			{ "music_off", 58432 },
			{ "music_video", 57443 },
			{ "my_location", 58716 },
			{ "nat", 61276 },
			{ "nature", 58374 },
			{ "nature_people", 58375 },
			{ "navigate_before", 58376 },
			{ "navigate_next", 58377 },
			{ "navigation", 58717 },
			{ "near_me", 58729 },
			{ "near_me_disabled", 61935 },
			{ "nearby_error", 61499 },
			{ "nearby_off", 61500 },
			{ "network_cell", 57785 },
			{ "network_check", 58944 },
			{ "network_locked", 58906 },
			{ "network_ping", 60362 },
			{ "network_wifi", 57786 },
			{ "new_label", 58889 },
			{ "new_releases", 57393 },
			{ "newspaper", 60289 },
			{ "next_plan", 61277 },
			{ "next_week", 57706 },
			{ "nfc", 57787 },
			{ "night_shelter", 61937 },
			{ "nightlife", 60002 },
			{ "nightlight", 61501 },
			{ "nightlight_round", 61278 },
			{ "nights_stay", 59974 },
			{ "no_accounts", 61502 },
			{ "no_backpack", 62007 },
			{ "no_cell", 61860 },
			{ "no_drinks", 61861 },
			{ "no_encryption", 58945 },
			{ "no_encryption_gmailerrorred", 61503 },
			{ "no_flash", 61862 },
			{ "no_food", 61863 },
			{ "no_luggage", 62011 },
			{ "no_meals", 61910 },
			{ "no_meeting_room", 60238 },
			{ "no_photography", 61864 },
			{ "no_sim", 57548 },
			{ "no_stroller", 61871 },
			{ "no_transfer", 61909 },
			{ "nordic_walking", 58638 },
			{ "north", 61920 },
			{ "north_east", 61921 },
			{ "north_west", 61922 },
			{ "not_accessible", 61694 },
			{ "not_interested", 57395 },
			{ "not_listed_location", 58741 },
			{ "not_started", 61649 },
			{ "note", 57455 },
			{ "note_add", 59548 },
			{ "note_alt", 61504 },
			{ "notes", 57964 },
			{ "notification_add", 58265 },
			{ "notification_important", 57348 },
			{ "notifications", 59380 },
			{ "notifications_active", 59383 },
			{ "notifications_none", 59381 },
			{ "notifications_off", 59382 },
			{ "notifications_paused", 59384 },
			{ "numbers", 60103 },
			{ "offline_bolt", 59698 },
			{ "offline_pin", 59658 },
			{ "offline_share", 59845 },
			{ "ondemand_video", 58938 },
			{ "online_prediction", 61675 },
			{ "opacity", 59676 },
			{ "open_in_browser", 59549 },
			{ "open_in_full", 61902 },
			{ "open_in_new", 59550 },
			{ "open_in_new_off", 58614 },
			{ "open_with", 59551 },
			{ "other_houses", 58764 },
			{ "outbound", 57802 },
			{ "outbox", 61279 },
			{ "outdoor_grill", 59975 },
			{ "outlet", 61908 },
			{ "outlined_flag", 57710 },
			{ "output", 60350 },
			{ "padding", 59848 },
			{ "pages", 59385 },
			{ "pageview", 59552 },
			{ "paid", 61505 },
			{ "palette", 58378 },
			{ "pan_tool", 59685 },
			{ "pan_tool_alt", 60345 },
			{ "panorama", 58379 },
			{ "panorama_fish_eye", 58380 },
			{ "panorama_horizontal", 58381 },
			{ "panorama_horizontal_select", 61280 },
			{ "panorama_photosphere", 59849 },
			{ "panorama_photosphere_select", 59850 },
			{ "panorama_vertical", 58382 },
			{ "panorama_vertical_select", 61281 },
			{ "panorama_wide_angle", 58383 },
			{ "panorama_wide_angle_select", 61282 },
			{ "paragliding", 58639 },
			{ "park", 60003 },
			{ "party_mode", 59386 },
			{ "password", 61506 },
			{ "pattern", 61507 },
			{ "pause", 57396 },
			{ "pause_circle", 57762 },
			{ "pause_circle_filled", 57397 },
			{ "pause_circle_outline", 57398 },
			{ "pause_presentation", 57578 },
			{ "payment", 59553 },
			{ "payments", 61283 },
			{ "pedal_bike", 60201 },
			{ "pending", 61284 },
			{ "pending_actions", 61883 },
			{ "pentagon", 60240 },
			{ "people", 59387 },
			{ "people_alt", 59937 },
			{ "people_outline", 59388 },
			{ "percent", 60248 },
			{ "perm_camera_mic", 59554 },
			{ "perm_contact_calendar", 59555 },
			{ "perm_data_setting", 59556 },
			{ "perm_device_information", 59557 },
			{ "perm_identity", 59558 },
			{ "perm_media", 59559 },
			{ "perm_phone_msg", 59560 },
			{ "perm_scan_wifi", 59561 },
			{ "person", 59389 },
			{ "person_add", 59390 },
			{ "person_add_alt", 59981 },
			{ "person_add_alt_1", 61285 },
			{ "person_add_disabled", 59851 },
			{ "person_off", 58640 },
			{ "person_outline", 59391 },
			{ "person_pin", 58714 },
			{ "person_pin_circle", 58730 },
			{ "person_remove", 61286 },
			{ "person_remove_alt_1", 61287 },
			{ "person_search", 61702 },
			{ "personal_injury", 59098 },
			{ "personal_video", 58939 },
			{ "pest_control", 61690 },
			{ "pest_control_rodent", 61693 },
			{ "pets", 59677 },
			{ "phishing", 60119 },
			{ "phone", 57549 },
			{ "phone_android", 58148 },
			{ "phone_bluetooth_speaker", 58907 },
			{ "phone_callback", 58953 },
			{ "phone_disabled", 59852 },
			{ "phone_enabled", 59853 },
			{ "phone_forwarded", 58908 },
			{ "phone_in_talk", 58909 },
			{ "phone_iphone", 58149 },
			{ "phone_locked", 58910 },
			{ "phone_missed", 58911 },
			{ "phone_paused", 58912 },
			{ "phonelink", 58150 },
			{ "phonelink_erase", 57563 },
			{ "phonelink_lock", 57564 },
			{ "phonelink_off", 58151 },
			{ "phonelink_ring", 57565 },
			{ "phonelink_setup", 57566 },
			{ "photo", 58384 },
			{ "photo_album", 58385 },
			{ "photo_camera", 58386 },
			{ "photo_camera_back", 61288 },
			{ "photo_camera_front", 61289 },
			{ "photo_filter", 58427 },
			{ "photo_library", 58387 },
			{ "photo_size_select_actual", 58418 },
			{ "photo_size_select_large", 58419 },
			{ "photo_size_select_small", 58420 },
			{ "php", 60303 },
			{ "piano", 58657 },
			{ "piano_off", 58656 },
			{ "picture_as_pdf", 58389 },
			{ "picture_in_picture", 59562 },
			{ "picture_in_picture_alt", 59665 },
			{ "pie_chart", 59076 },
			{ "pie_chart_outline", 61508 },
			{ "pin", 61509 },
			{ "pin_drop", 58718 },
			{ "pin_end", 59239 },
			{ "pin_invoke", 59235 },
			{ "pinch", 60216 },
			{ "pivot_table_chart", 59854 },
			{ "pix", 60067 },
			{ "place", 58719 },
			{ "plagiarism", 59994 },
			{ "play_arrow", 57399 },
			{ "play_circle", 57796 },
			{ "play_circle_filled", 57400 },
			{ "play_circle_outline", 57401 },
			{ "play_disabled", 61290 },
			{ "play_for_work", 59654 },
			{ "play_lesson", 61511 },
			{ "playlist_add", 57403 },
			{ "playlist_add_check", 57445 },
			{ "playlist_add_check_circle", 59366 },
			{ "playlist_add_circle", 59365 },
			{ "playlist_play", 57439 },
			{ "playlist_remove", 60288 },
			{ "plumbing", 61703 },
			{ "plus_one", 59392 },
			{ "podcasts", 61512 },
			{ "point_of_sale", 61822 },
			{ "policy", 59927 },
			{ "poll", 59393 },
			{ "polyline", 60347 },
			{ "polymer", 59563 },
			{ "pool", 60232 },
			{ "portable_wifi_off", 57550 },
			{ "portrait", 58390 },
			{ "post_add", 59936 },
			{ "power", 58940 },
			{ "power_input", 58166 },
			{ "power_off", 58950 },
			{ "power_settings_new", 59564 },
			{ "precision_manufacturing", 61513 },
			{ "pregnant_woman", 59678 },
			{ "present_to_all", 57567 },
			{ "preview", 61893 },
			{ "price_change", 61514 },
			{ "price_check", 61515 },
			{ "print", 59565 },
			{ "print_disabled", 59855 },
			{ "priority_high", 58949 },
			{ "privacy_tip", 61660 },
			{ "private_connectivity", 59204 },
			{ "production_quantity_limits", 57809 },
			{ "psychology", 59978 },
			{ "public", 59403 },
			{ "public_off", 61898 },
			{ "publish", 57941 },
			{ "published_with_changes", 62002 },
			{ "punch_clock", 60072 },
			{ "push_pin", 61709 },
			{ "qr_code", 61291 },
			{ "qr_code_2", 57354 },
			{ "qr_code_scanner", 61958 },
			{ "query_builder", 59566 },
			{ "query_stats", 58620 },
			{ "question_answer", 59567 },
			{ "question_mark", 60299 },
			{ "queue", 57404 },
			{ "queue_music", 57405 },
			{ "queue_play_next", 57446 },
			{ "quickreply", 61292 },
			{ "quiz", 61516 },
			{ "r_mobiledata", 61517 },
			{ "radar", 61518 },
			{ "radio", 57406 },
			{ "radio_button_checked", 59447 },
			{ "radio_button_unchecked", 59446 },
			{ "railway_alert", 59857 },
			{ "ramen_dining", 60004 },
			{ "ramp_left", 60316 },
			{ "ramp_right", 60310 },
			{ "rate_review", 58720 },
			{ "raw_off", 61519 },
			{ "raw_on", 61520 },
			{ "read_more", 61293 },
			{ "real_estate_agent", 59194 },
			{ "receipt", 59568 },
			{ "receipt_long", 61294 },
			{ "recent_actors", 57407 },
			{ "recommend", 59858 },
			{ "record_voice_over", 59679 },
			{ "rectangle", 60244 },
			{ "recycling", 59232 },
			{ "redeem", 59569 },
			{ "redo", 57690 },
			{ "reduce_capacity", 61980 },
			{ "refresh", 58837 },
			{ "remember_me", 61521 },
			{ "remove", 57691 },
			{ "remove_circle", 57692 },
			{ "remove_circle_outline", 57693 },
			{ "remove_done", 59859 },
			{ "remove_from_queue", 57447 },
			{ "remove_moderator", 59860 },
			{ "remove_red_eye", 58391 },
			{ "remove_shopping_cart", 59688 },
			{ "reorder", 59646 },
			{ "repeat", 57408 },
			{ "repeat_on", 59862 },
			{ "repeat_one", 57409 },
			{ "repeat_one_on", 59863 },
			{ "replay", 57410 },
			{ "replay_10", 57433 },
			{ "replay_30", 57434 },
			{ "replay_5", 57435 },
			{ "replay_circle_filled", 59864 },
			{ "reply", 57694 },
			{ "reply_all", 57695 },
			{ "report", 57696 },
			{ "report_gmailerrorred", 61522 },
			{ "report_off", 57712 },
			{ "report_problem", 59570 },
			{ "request_page", 61996 },
			{ "request_quote", 61878 },
			{ "reset_tv", 59865 },
			{ "restart_alt", 61523 },
			{ "restaurant", 58732 },
			{ "restaurant_menu", 58721 },
			{ "restore", 59571 },
			{ "restore_from_trash", 59704 },
			{ "restore_page", 59689 },
			{ "reviews", 61524 },
			{ "rice_bowl", 61941 },
			{ "ring_volume", 57553 },
			{ "rocket", 60325 },
			{ "rocket_launch", 60315 },
			{ "roller_skating", 60365 },
			{ "roofing", 61953 },
			{ "room", 59572 },
			{ "room_preferences", 61880 },
			{ "room_service", 60233 },
			{ "rotate_90_degrees_ccw", 58392 },
			{ "rotate_90_degrees_cw", 60075 },
			{ "rotate_left", 58393 },
			{ "rotate_right", 58394 },
			{ "roundabout_left", 60313 },
			{ "roundabout_right", 60323 },
			{ "rounded_corner", 59680 },
			{ "route", 60109 },
			{ "router", 58152 },
			{ "rowing", 59681 },
			{ "rss_feed", 57573 },
			{ "rsvp", 61525 },
			{ "rtt", 59821 },
			{ "rule", 61890 },
			{ "rule_folder", 61897 },
			{ "run_circle", 61295 },
			{ "running_with_errors", 58653 },
			{ "rv_hookup", 58946 },
			{ "safety_divider", 57804 },
			{ "sailing", 58626 },
			{ "sanitizer", 61981 },
			{ "satellite", 58722 },
			{ "satellite_alt", 60218 },
			{ "save", 57697 },
			{ "save_alt", 57713 },
			{ "save_as", 60256 },
			{ "saved_search", 59921 },
			{ "savings", 58091 },
			{ "scale", 60255 },
			{ "scanner", 58153 },
			{ "scatter_plot", 57960 },
			{ "schedule", 59573 },
			{ "schedule_send", 59914 },
			{ "schema", 58621 },
			{ "school", 59404 },
			{ "science", 59979 },
			{ "score", 57961 },
			{ "scoreboard", 60368 },
			{ "screen_lock_landscape", 57790 },
			{ "screen_lock_portrait", 57791 },
			{ "screen_lock_rotation", 57792 },
			{ "screen_rotation", 57793 },
			{ "screen_search_desktop", 61296 },
			{ "screen_share", 57570 },
			{ "screenshot", 61526 },
			{ "scuba_diving", 60366 },
			{ "sd", 59869 },
			{ "sd_card", 58915 },
			{ "sd_card_alert", 61527 },
			{ "sd_storage", 57794 },
			{ "search", 59574 },
			{ "search_off", 60022 },
			{ "security", 58154 },
			{ "security_update", 61528 },
			{ "security_update_good", 61529 },
			{ "security_update_warning", 61530 },
			{ "segment", 59723 },
			{ "select_all", 57698 },
			{ "self_improvement", 60024 },
			{ "sell", 61531 },
			{ "send", 57699 },
			{ "send_and_archive", 59916 },
			{ "send_time_extension", 60123 },
			{ "send_to_mobile", 61532 },
			{ "sensor_door", 61877 },
			{ "sensor_window", 61876 },
			{ "sensors", 58654 },
			{ "sensors_off", 58655 },
			{ "sentiment_dissatisfied", 59409 },
			{ "sentiment_neutral", 59410 },
			{ "sentiment_satisfied", 59411 },
			{ "sentiment_satisfied_alt", 57581 },
			{ "sentiment_very_dissatisfied", 59412 },
			{ "sentiment_very_satisfied", 59413 },
			{ "set_meal", 61930 },
			{ "settings", 59576 },
			{ "settings_accessibility", 61533 },
			{ "settings_applications", 59577 },
			{ "settings_backup_restore", 59578 },
			{ "settings_bluetooth", 59579 },
			{ "settings_brightness", 59581 },
			{ "settings_cell", 59580 },
			{ "settings_ethernet", 59582 },
			{ "settings_input_antenna", 59583 },
			{ "settings_input_component", 59584 },
			{ "settings_input_composite", 59585 },
			{ "settings_input_hdmi", 59586 },
			{ "settings_input_svideo", 59587 },
			{ "settings_overscan", 59588 },
			{ "settings_phone", 59589 },
			{ "settings_power", 59590 },
			{ "settings_remote", 59591 },
			{ "settings_suggest", 61534 },
			{ "settings_system_daydream", 57795 },
			{ "settings_voice", 59592 },
			{ "share", 59405 },
			{ "share_location", 61535 },
			{ "shield", 59872 },
			{ "shield_moon", 60073 },
			{ "shop", 59593 },
			{ "shop_2", 57758 },
			{ "shop_two", 59594 },
			{ "shopping_bag", 61900 },
			{ "shopping_basket", 59595 },
			{ "shopping_cart", 59596 },
			{ "shopping_cart_checkout", 60296 },
			{ "short_text", 57953 },
			{ "shortcut", 61536 },
			{ "show_chart", 59105 },
			{ "shower", 61537 },
			{ "shuffle", 57411 },
			{ "shuffle_on", 59873 },
			{ "shutter_speed", 58429 },
			{ "sick", 61984 },
			{ "signal_cellular_0_bar", 61608 },
			{ "signal_cellular_4_bar", 57800 },
			{ "signal_cellular_alt", 57858 },
			{ "signal_cellular_connected_no_internet_0_bar", 61612 },
			{ "signal_cellular_connected_no_internet_4_bar", 57805 },
			{ "signal_cellular_no_sim", 57806 },
			{ "signal_cellular_nodata", 61538 },
			{ "signal_cellular_null", 57807 },
			{ "signal_cellular_off", 57808 },
			{ "signal_wifi_0_bar", 61616 },
			{ "signal_wifi_4_bar", 57816 },
			{ "signal_wifi_4_bar_lock", 57817 },
			{ "signal_wifi_bad", 61539 },
			{ "signal_wifi_connected_no_internet_4", 61540 },
			{ "signal_wifi_off", 57818 },
			{ "signal_wifi_statusbar_4_bar", 61541 },
			{ "signal_wifi_statusbar_connected_no_internet_4", 61542 },
			{ "signal_wifi_statusbar_null", 61543 },
			{ "signpost", 60305 },
			{ "sim_card", 58155 },
			{ "sim_card_alert", 58916 },
			{ "sim_card_download", 61544 },
			{ "single_bed", 59976 },
			{ "sip", 61545 },
			{ "skateboarding", 58641 },
			{ "skip_next", 57412 },
			{ "skip_previous", 57413 },
			{ "sledding", 58642 },
			{ "slideshow", 58395 },
			{ "slow_motion_video", 57448 },
			{ "smart_button", 61889 },
			{ "smart_display", 61546 },
			{ "smart_screen", 61547 },
			{ "smart_toy", 61548 },
			{ "smartphone", 58156 },
			{ "smoke_free", 60234 },
			{ "smoking_rooms", 60235 },
			{ "sms", 58917 },
			{ "sms_failed", 58918 },
			{ "snippet_folder", 61895 },
			{ "snooze", 57414 },
			{ "snowboarding", 58643 },
			{ "snowmobile", 58627 },
			{ "snowshoeing", 58644 },
			{ "soap", 61874 },
			{ "social_distance", 57803 },
			{ "sort", 57700 },
			{ "sort_by_alpha", 57427 },
			{ "soup_kitchen", 59347 },
			{ "source", 61892 },
			{ "south", 61923 },
			{ "south_america", 59364 },
			{ "south_east", 61924 },
			{ "south_west", 61925 },
			{ "spa", 60236 },
			{ "space_bar", 57942 },
			{ "space_dashboard", 58987 },
			{ "speaker", 58157 },
			{ "speaker_group", 58158 },
			{ "speaker_notes", 59597 },
			{ "speaker_notes_off", 59690 },
			{ "speaker_phone", 57554 },
			{ "speed", 59876 },
			{ "spellcheck", 59598 },
			{ "splitscreen", 61549 },
			{ "spoke", 59815 },
			{ "sports", 59952 },
			{ "sports_bar", 61939 },
			{ "sports_baseball", 59985 },
			{ "sports_basketball", 59942 },
			{ "sports_cricket", 59943 },
			{ "sports_esports", 59944 },
			{ "sports_football", 59945 },
			{ "sports_golf", 59946 },
			{ "sports_gymnastics", 60356 },
			{ "sports_handball", 59955 },
			{ "sports_hockey", 59947 },
			{ "sports_kabaddi", 59956 },
			{ "sports_martial_arts", 60137 },
			{ "sports_mma", 59948 },
			{ "sports_motorsports", 59949 },
			{ "sports_rugby", 59950 },
			{ "sports_score", 61550 },
			{ "sports_soccer", 59951 },
			{ "sports_tennis", 59954 },
			{ "sports_volleyball", 59953 },
			{ "square", 60214 },
			{ "square_foot", 59977 },
			{ "ssid_chart", 60262 },
			{ "stacked_bar_chart", 59878 },
			{ "stacked_line_chart", 61995 },
			{ "stadium", 60304 },
			{ "stairs", 61865 },
			{ "star", 59448 },
			{ "star_border", 59450 },
			{ "star_border_purple500", 61593 },
			{ "star_half", 59449 },
			{ "star_outline", 61551 },
			{ "star_purple500", 61594 },
			{ "star_rate", 61676 },
			{ "stars", 59600 },
			{ "start", 57481 },
			{ "stay_current_landscape", 57555 },
			{ "stay_current_portrait", 57556 },
			{ "stay_primary_landscape", 57557 },
			{ "stay_primary_portrait", 57558 },
			{ "sticky_note_2", 61948 },
			{ "stop", 57415 },
			{ "stop_circle", 61297 },
			{ "stop_screen_share", 57571 },
			{ "storage", 57819 },
			{ "store", 59601 },
			{ "store_mall_directory", 58723 },
			{ "storefront", 59922 },
			{ "storm", 61552 },
			{ "straight", 60309 },
			{ "straighten", 58396 },
			{ "stream", 59881 },
			{ "streetview", 58734 },
			{ "strikethrough_s", 57943 },
			{ "stroller", 61870 },
			{ "style", 58397 },
			{ "subdirectory_arrow_left", 58841 },
			{ "subdirectory_arrow_right", 58842 },
			{ "subject", 59602 },
			{ "subscript", 61713 },
			{ "subscriptions", 57444 },
			{ "subtitles", 57416 },
			{ "subtitles_off", 61298 },
			{ "subway", 58735 },
			{ "summarize", 61553 },
			{ "superscript", 61714 },
			{ "supervised_user_circle", 59705 },
			{ "supervisor_account", 59603 },
			{ "support", 61299 },
			{ "support_agent", 61666 },
			{ "surfing", 58645 },
			{ "surround_sound", 57417 },
			{ "swap_calls", 57559 },
			{ "swap_horiz", 59604 },
			{ "swap_horizontal_circle", 59699 },
			{ "swap_vert", 59605 },
			{ "swap_vertical_circle", 59606 },
			{ "swipe", 59884 },
			{ "swipe_down", 60243 },
			{ "swipe_down_alt", 60208 },
			{ "swipe_left", 60249 },
			{ "swipe_left_alt", 60211 },
			{ "swipe_right", 60242 },
			{ "swipe_right_alt", 60246 },
			{ "swipe_up", 60206 },
			{ "swipe_up_alt", 60213 },
			{ "swipe_vertical", 60241 },
			{ "switch_access_shortcut", 59361 },
			{ "switch_access_shortcut_add", 59362 },
			{ "switch_account", 59885 },
			{ "switch_camera", 58398 },
			{ "switch_left", 61905 },
			{ "switch_right", 61906 },
			{ "switch_video", 58399 },
			{ "synagogue", 60080 },
			{ "sync", 58919 },
			{ "sync_alt", 59928 },
			{ "sync_disabled", 58920 },
			{ "sync_lock", 60142 },
			{ "sync_problem", 58921 },
			{ "system_security_update", 61554 },
			{ "system_security_update_good", 61555 },
			{ "system_security_update_warning", 61556 },
			{ "system_update", 58922 },
			{ "system_update_alt", 59607 },
			{ "tab", 59608 },
			{ "tab_unselected", 59609 },
			{ "table_bar", 60114 },
			{ "table_chart", 57957 },
			{ "table_restaurant", 60102 },
			{ "table_rows", 61697 },
			{ "table_view", 61886 },
			{ "tablet", 58159 },
			{ "tablet_android", 58160 },
			{ "tablet_mac", 58161 },
			{ "tag", 59887 },
			{ "tag_faces", 58400 },
			{ "takeout_dining", 60020 },
			{ "tap_and_play", 58923 },
			{ "tapas", 61929 },
			{ "task", 61557 },
			{ "task_alt", 58086 },
			{ "taxi_alert", 61300 },
			{ "temple_buddhist", 60083 },
			{ "temple_hindu", 60079 },
			{ "terminal", 60302 },
			{ "terrain", 58724 },
			{ "text_decrease", 60125 },
			{ "text_fields", 57954 },
			{ "text_format", 57701 },
			{ "text_increase", 60130 },
			{ "text_rotate_up", 59706 },
			{ "text_rotate_vertical", 59707 },
			{ "text_rotation_angledown", 59708 },
			{ "text_rotation_angleup", 59709 },
			{ "text_rotation_down", 59710 },
			{ "text_rotation_none", 59711 },
			{ "text_snippet", 61894 },
			{ "textsms", 57560 },
			{ "texture", 58401 },
			{ "theater_comedy", 60006 },
			{ "theaters", 59610 },
			{ "thermostat", 61558 },
			{ "thermostat_auto", 61559 },
			{ "thumb_down", 59611 },
			{ "thumb_down_alt", 59414 },
			{ "thumb_down_off_alt", 59890 },
			{ "thumb_up", 59612 },
			{ "thumb_up_alt", 59415 },
			{ "thumb_up_off_alt", 59891 },
			{ "thumbs_up_down", 59613 },
			{ "time_to_leave", 58924 },
			{ "timelapse", 58402 },
			{ "timeline", 59682 },
			{ "timer", 58405 },
			{ "timer_10", 58403 },
			{ "timer_10_select", 61562 },
			{ "timer_3", 58404 },
			{ "timer_3_select", 61563 },
			{ "timer_off", 58406 },
			{ "tips_and_updates", 59290 },
			{ "tire_repair", 60360 },
			{ "title", 57956 },
			{ "toc", 59614 },
			{ "today", 59615 },
			{ "toggle_off", 59893 },
			{ "toggle_on", 59894 },
			{ "token", 59941 },
			{ "toll", 59616 },
			{ "tonality", 58407 },
			{ "topic", 61896 },
			{ "touch_app", 59667 },
			{ "tour", 61301 },
			{ "toys", 58162 },
			{ "track_changes", 59617 },
			{ "traffic", 58725 },
			{ "train", 58736 },
			{ "tram", 58737 },
			{ "transfer_within_a_station", 58738 },
			{ "transform", 58408 },
			{ "transgender", 58765 },
			{ "transit_enterexit", 58745 },
			{ "translate", 59618 },
			{ "travel_explore", 58075 },
			{ "trending_down", 59619 },
			{ "trending_flat", 59620 },
			{ "trending_up", 59621 },
			{ "trip_origin", 58747 },
			{ "try", 61564 },
			{ "tty", 61866 },
			{ "tune", 58409 },
			{ "tungsten", 61565 },
			{ "turn_left", 60326 },
			{ "turn_right", 60331 },
			{ "turn_sharp_left", 60327 },
			{ "turn_sharp_right", 60330 },
			{ "turn_slight_left", 60324 },
			{ "turn_slight_right", 60314 },
			{ "turned_in", 59622 },
			{ "turned_in_not", 59623 },
			{ "tv", 58163 },
			{ "tv_off", 58951 },
			{ "two_wheeler", 59897 },
			{ "u_turn_left", 60321 },
			{ "u_turn_right", 60322 },
			{ "umbrella", 61869 },
			{ "unarchive", 57705 },
			{ "undo", 57702 },
			{ "unfold_less", 58838 },
			{ "unfold_more", 58839 },
			{ "unpublished", 62006 },
			{ "unsubscribe", 57579 },
			{ "upcoming", 61566 },
			{ "update", 59683 },
			{ "update_disabled", 57461 },
			{ "upgrade", 61691 },
			{ "upload", 61595 },
			{ "upload_file", 59900 },
			{ "usb", 57824 },
			{ "usb_off", 58618 },
			{ "vaccines", 57656 },
			{ "vape_free", 60358 },
			{ "vaping_rooms", 60367 },
			{ "verified", 61302 },
			{ "verified_user", 59624 },
			{ "vertical_align_bottom", 57944 },
			{ "vertical_align_center", 57945 },
			{ "vertical_align_top", 57946 },
			{ "vertical_distribute", 57462 },
			{ "vertical_split", 59721 },
			{ "vibration", 58925 },
			{ "video_call", 57456 },
			{ "video_camera_back", 61567 },
			{ "video_camera_front", 61568 },
			{ "video_file", 60295 },
			{ "video_label", 57457 },
			{ "video_library", 57418 },
			{ "video_settings", 60021 },
			{ "video_stable", 61569 },
			{ "videocam", 57419 },
			{ "videocam_off", 57420 },
			{ "videogame_asset", 58168 },
			{ "videogame_asset_off", 58624 },
			{ "view_agenda", 59625 },
			{ "view_array", 59626 },
			{ "view_carousel", 59627 },
			{ "view_column", 59628 },
			{ "view_comfy", 58410 },
			{ "view_comfy_alt", 60275 },
			{ "view_compact", 58411 },
			{ "view_compact_alt", 60276 },
			{ "view_cozy", 60277 },
			{ "view_day", 59629 },
			{ "view_headline", 59630 },
			{ "view_in_ar", 59902 },
			{ "view_kanban", 60287 },
			{ "view_list", 59631 },
			{ "view_module", 59632 },
			{ "view_quilt", 59633 },
			{ "view_sidebar", 61716 },
			{ "view_stream", 59634 },
			{ "view_timeline", 60293 },
			{ "view_week", 59635 },
			{ "vignette", 58421 },
			{ "villa", 58758 },
			{ "visibility", 59636 },
			{ "visibility_off", 59637 },
			{ "voice_chat", 58926 },
			{ "voice_over_off", 59722 },
			{ "voicemail", 57561 },
			{ "volume_down", 57421 },
			{ "volume_mute", 57422 },
			{ "volume_off", 57423 },
			{ "volume_up", 57424 },
			{ "volunteer_activism", 60016 },
			{ "vpn_key", 57562 },
			{ "vpn_key_off", 60282 },
			{ "vpn_lock", 58927 },
			{ "vrpano", 61570 },
			{ "wallpaper", 57788 },
			{ "warehouse", 60344 },
			{ "warning", 57346 },
			{ "warning_amber", 61571 },
			{ "wash", 61873 },
			{ "watch", 58164 },
			{ "watch_later", 59684 },
			{ "watch_off", 60131 },
			{ "water", 61572 },
			{ "water_damage", 61955 },
			{ "water_drop", 59288 },
			{ "waterfall_chart", 59904 },
			{ "waves", 57718 },
			{ "waving_hand", 59238 },
			{ "wb_auto", 58412 },
			{ "wb_cloudy", 58413 },
			{ "wb_incandescent", 58414 },
			{ "wb_iridescent", 58422 },
			{ "wb_shade", 59905 },
			{ "wb_sunny", 58416 },
			{ "wb_twilight", 57798 },
			{ "wc", 58941 },
			{ "web", 57425 },
			{ "web_asset", 57449 },
			{ "web_asset_off", 58615 },
			{ "webhook", 60306 },
			{ "weekend", 57707 },
			{ "west", 61926 },
			{ "whatsapp", 60060 },
			{ "whatshot", 59406 },
			{ "wheelchair_pickup", 61867 },
			{ "where_to_vote", 57719 },
			{ "widgets", 57789 },
			{ "wifi", 58942 },
			{ "wifi_calling", 61303 },
			{ "wifi_calling_3", 61573 },
			{ "wifi_channel", 60266 },
			{ "wifi_find", 60209 },
			{ "wifi_lock", 57825 },
			{ "wifi_off", 58952 },
			{ "wifi_password", 60267 },
			{ "wifi_protected_setup", 61692 },
			{ "wifi_tethering", 57826 },
			{ "wifi_tethering_error", 60121 },
			{ "wifi_tethering_off", 61575 },
			{ "window", 61576 },
			{ "wine_bar", 61928 },
			{ "woman", 57662 },
			{ "work", 59641 },
			{ "work_off", 59714 },
			{ "work_outline", 59715 },
			{ "workspace_premium", 59311 },
			{ "workspaces", 57760 },
			{ "wrap_text", 57947 },
			{ "wrong_location", 61304 },
			{ "wysiwyg", 61891 },
			{ "yard", 61577 },
			{ "youtube_searched_for", 59642 },
			{ "zoom_in", 59647 },
			{ "zoom_in_map", 60205 },
			{ "zoom_out", 59648 },
			{ "zoom_out_map", 58731 },
		};

	}


}
