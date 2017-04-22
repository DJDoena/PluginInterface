using System;
using System.Runtime.InteropServices;

namespace Invelos.DVDProfilerPlugin
{
	class PluginConstants
	{
		public const int API_VERSION = 4;

		public const int FORMID_Main        = 0;
		public const int FORMID_AddDVDs     = 1;
		public const int FORMID_Reports     = 2;
		public const int FORMID_Welcome     = 3;
		public const int FORMID_Options     = 4;
		public const int FORMID_EditProfile = 5;
		public const int FORMID_Personalize = 6;
		public const int FORMID_LoadLayout  = 7;

		// Menu IDs
		public const int MENUID_Form = 0;
		// Main form popup menu IDs
		public const int MENUID_Main_Collection = 1;
		// Add DVDs form popup menu IDs
		public const int MENUID_AddDVDs_TitleListing = 1;
		public const int MENUID_AddDVDs_PendingListing = 2;

		// Action IDs
		// FORMID_AddDVDs
		public const int ACTIONID_AddDVDs_GetPendingList = 0;

		// Standard Action result error codes
		public const int ACTIONResult_Unknown       = -1;
		public const int ACTIONResult_FormNotLoaded = -2;

		// Event IDs
		// General Events
		///<summary>
		/// EventData is error description
		///</summary>
		public const int EVENTID_Exception              = 0;
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_PluginUnloading        = 1;
		// Custom Plugin Events
		///<summary>
		/// EventData is Custom Event ID
		///</summary>
		public const int EVENTID_CustomMenuClick        = 100;
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_CustomPluginOptions    = 101;
		// Program Events
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_ProgramLoaded          = 200;
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_ProgramMinimized       = 201;
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_ProgramRestored        = 202;
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_ProgramGotFocus        = 203;
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_ProgramLostFocus       = 204;
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_ProgramLayoutSaving    = 205;
		///<summary>
		/// EventData is Layout file name
		///</summary>
		public const int EVENTID_ProgramLayoutLoaded    = 206;
		// Form Events
		///<summary>
		/// EventData is Form ID
		///</summary>
		public const int EVENTID_FormCreated            = 300;
		///<summary>
		/// EventData is Form ID
		///</summary>
		public const int EVENTID_FormDestroyed          = 301;
		///<summary>
		/// EventData is Host window's WindowHandle
		///</summary>
		public const int EVENTID_HostWindowClosed       = 302;
		// Profile Events
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDSelected            = 400;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDEditStart           = 401;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDEditSave            = 402;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDEditSaveNoChanges   = 428;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDEditCancel          = 403;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToOwned        = 404;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToOrdered      = 405;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToWishList     = 406;
		///<summary>
		/// EventData is image file name
		///</summary>
		public const int EVENTID_DVDImagesChanged       = 407;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDWatched             = 408;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDLoaned              = 409;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDDueDateChanged      = 410;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDReturned            = 411;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDHistoryEdited       = 412;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDTagsChanged         = 413;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDAdded               = 414;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDRemoved             = 415;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDRefreshed           = 416;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDImagesRefreshed     = 417;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToCustom0      = 418;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToCustom1      = 419;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToCustom2      = 420;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToCustom3      = 421;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToCustom4      = 422;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToCustom5      = 423;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToCustom6      = 424;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToCustom7      = 425;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToCustom8      = 426;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDMovedToCustom9      = 427;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDPersonalized        = 429;
		///<summary>
		/// EventData is CastIndex
		///</summary>
		public const int EVENTID_DVDCastEntrySelected   = 430;
		///<summary>
		/// EventData is CrewIndex
		///</summary>
		public const int EVENTID_DVDCrewEntrySelected   = 431;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDReviewed            = 432;
        ///<summary>
        /// EventData is Profile ID
        ///</summary>
        public const int EVENTID_DVDPersonalizeShown    = 433;
        ///<summary>
        /// EventData is Profile ID
        ///</summary>
        public const int EVENTID_DVDPersonalizedAddition = 434;
        // Flag Events
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDFlagged             = 500;
		///<summary>
		/// EventData is Profile ID
		///</summary>
		public const int EVENTID_DVDUnflagged           = 501;
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_BulkFlagOperationStart = 502;
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_BulkFlagOperationEnd   = 503;
		// Collection Display Events
		///<summary>
		/// EventData is Sort Order Type
		///</summary>
		public const int EVENTID_SortOrderChanged       = 600;
		///<summary>
		/// EventData is null
		///</summary>
		public const int EVENTID_CollectionListChanged  = 601;
		// Interface Events
		///<summary>
		/// EventData is name of theme
		///</summary>
		public const int EVENTID_ThemeChanged           = 700;
		// Collection Events
		///<summary>
		/// EventData is file path and name
		///</summary>
		public const int EVENTID_BackupStarting         = 800;
		///<summary>
		/// EventData is file path and name
		///</summary>
		public const int EVENTID_BackupFinished         = 801;
		///<summary>
		/// EventData is file path and name
		///</summary>
		public const int EVENTID_BackupCancelled        = 802;
		///<summary>
		/// EventData is file path and name
		///</summary>
		public const int EVENTID_RestoreStarting        = 803;
		///<summary>
		/// EventData is file path and name
		///</summary>
		public const int EVENTID_RestoreFinished        = 804;
		///<summary>
		/// EventData is file path and name
		///</summary>
		public const int EVENTID_RestoreCancelled       = 805;
		///<summary>
		/// EventData is path
		///</summary>
		public const int EVENTID_DatabaseOpened         = 806;
		///<summary>
		/// EventData is path
		///</summary>
		public const int EVENTID_DatabaseClosed	        = 807;
		
		// Field-specific IDs
		public const int GENRE_None             = 0;
		public const int GENRE_Accessories      = 1;
		public const int GENRE_Action           = 2;
		public const int GENRE_Adult            = 3;
		public const int GENRE_Animation        = 4;
		public const int GENRE_Classic          = 5;
		public const int GENRE_Comedy           = 6;
		public const int GENRE_Drama            = 7;
		public const int GENRE_Family           = 8;
		public const int GENRE_Horror           = 10;
		public const int GENRE_Music            = 11;
		public const int GENRE_ScienceFiction   = 12;
		public const int GENRE_SpecialInterest  = 13;
		public const int GENRE_SuspenseThriller = 14;
		public const int GENRE_Western          = 15;
		public const int GENRE_Adventure        = 16;
		public const int GENRE_Romance          = 17;
		public const int GENRE_Fantasy          = 18;
		public const int GENRE_Anime            = 19;
		public const int GENRE_Documentary      = 20;
		public const int GENRE_Musical          = 21;
		public const int GENRE_Television       = 22;
		public const int GENRE_Sports           = 23;
		public const int GENRE_War              = 24;
		public const int GENRE_MartialArts      = 25;
		public const int GENRE_Crime            = 26;
		public const int GENRE_Disaster         = 27;
		public const int GENRE_FilmNoir         = 28;
		public const int GENRE_Childrens        = 29;

		public const int CASETYPE_None      = 0;
		public const int CASETYPE_KeepCase  = 1;
		public const int CASETYPE_Snapper   = 2;
		public const int CASETYPE_Jewel     = 3;
		public const int CASETYPE_Clamshell = 4;
		public const int CASETYPE_Drawer    = 5;
		public const int CASETYPE_Digipak   = 6;
		public const int CASETYPE_Custom    = 7;
		///<summary>
		/// Slip Case
		///</summary>
		public const int CASETYPE_BoxSet    = 8;
		public const int CASETYPE_Envelope  = 9;
		public const int CASETYPE_SteelBook = 10;
		public const int CASETYPE_Elite     = 11;
		public const int CASETYPE_THINpak   = 12;
		public const int CASETYPE_HDKeepCase = 13;
		public const int CASETYPE_Digibook  = 14;
		public const int CASETYPE_Box       = 15;
		public const int CASETYPE_Handle    = 16;

		public const int VIDSTD_NTSC        = 0;
		public const int VIDSTD_PAL         = 1;

		// These are bitwise values
		public const int DP_COLOR_COLOR         = 8;
		public const int DP_COLOR_BLACKANDWHITE = 16;
		public const int DP_COLOR_COLORIZED     = 32;
		public const int DP_COLOR_MIXED         = 64;
		
		public const int FEATURE_SceneAccess     = 0;
		public const int FEATURE_Commentary      = 1;
		public const int FEATURE_Trailer         = 2;
		public const int FEATURE_Gallery         = 3;
		public const int FEATURE_DeletedScenes   = 4;
		public const int FEATURE_Documentary     = 5;
		public const int FEATURE_ProductionNotes = 6;
		public const int FEATURE_InteractiveGame = 7;
		public const int FEATURE_DVDROMContent   = 8;
		public const int FEATURE_MultiAngle      = 9;
		public const int FEATURE_MusicVideos     = 10;
		public const int FEATURE_ClosedCaptioned = 11;
		public const int FEATURE_THX             = 12;
		public const int FEATURE_Interviews      = 13;
		public const int FEATURE_StoryboardComps = 14;
		public const int FEATURE_Bloopers        = 15;
		public const int FEATURE_PIP             = 16;
		public const int FEATURE_BDLive          = 17;
		public const int FEATURE_BonusTrailers   = 18;
		public const int FEATURE_DigitalCopy     = 19;

		public const int LOCK_Entire          = 0;
		public const int LOCK_Scans           = 1;
		public const int LOCK_Title           = 2;
		public const int LOCK_Overview        = 3;
		public const int LOCK_Regions         = 4;
		public const int LOCK_Genres          = 5;
		public const int LOCK_PurchasePrice   = 6;
		public const int LOCK_Studios         = 7;
		public const int LOCK_DiscInformation = 8;
		public const int LOCK_Cast            = 9;
		public const int LOCK_Crew            = 10;
		public const int LOCK_Features        = 11;
		public const int LOCK_AudioTracks     = 12;
		public const int LOCK_Subtitles       = 13;
		public const int LOCK_EasterEggs      = 14;
		public const int LOCK_RunningTime     = 15;
		public const int LOCK_ReleaseDate     = 16;
		public const int LOCK_ProductionYear  = 17;
		public const int LOCK_CaseType        = 18;
		public const int LOCK_VideoFormats    = 19;
		public const int LOCK_BoxSetContents  = 20;
		public const int LOCK_Rating          = 21;
		public const int LOCK_MediaTypes      = 22;

		public const int COLLTYPE_Owned    = 1;
		public const int COLLTYPE_Ordered  = 2;
		public const int COLLTYPE_WishList = 3;
		public const int COLLTYPE_Custom0  = 4;
		public const int COLLTYPE_Custom1  = 5;
		public const int COLLTYPE_Custom2  = 6;
		public const int COLLTYPE_Custom3  = 7;
		public const int COLLTYPE_Custom4  = 8;
		public const int COLLTYPE_Custom5  = 9;
		public const int COLLTYPE_Custom6  = 10;
		public const int COLLTYPE_Custom7  = 11;
		public const int COLLTYPE_Custom8  = 12;
		public const int COLLTYPE_Custom9  = 13;

		public const int REVIEWPART_Film   = 0;
		public const int REVIEWPART_Video  = 1;
		public const int REVIEWPART_Audio  = 2;
		public const int REVIEWPART_Extras = 3;

		public const int SUBTITLE_Afrikaans  = 0;
		public const int SUBTITLE_Arabic     = 1;
		public const int SUBTITLE_Bahasa     = 38;
		public const int SUBTITLE_Bambara    = 39;
		public const int SUBTITLE_Basque     = 40;
		public const int SUBTITLE_Bulgarian  = 2;
		public const int SUBTITLE_Catalonian = 41;
		public const int SUBTITLE_Chinese    = 3;
		public const int SUBTITLE_Croatian   = 4;
		public const int SUBTITLE_Czech      = 5;
		public const int SUBTITLE_Danish     = 6;
		public const int SUBTITLE_Dutch      = 7;
		public const int SUBTITLE_English    = 8;
		public const int SUBTITLE_Estonian   = 42;
		public const int SUBTITLE_Farsi      = 9;
		public const int SUBTITLE_Finnish    = 10;
		public const int SUBTITLE_Flemish    = 43;
		public const int SUBTITLE_French     = 11;
		public const int SUBTITLE_Galician   = 44;
		public const int SUBTITLE_Georgian   = 45;
		public const int SUBTITLE_German     = 12;
		public const int SUBTITLE_Greek      = 13;
		public const int SUBTITLE_Hebrew     = 14;
		public const int SUBTITLE_Hindi      = 15;
		public const int SUBTITLE_Hungarian  = 16;
		public const int SUBTITLE_Icelandic  = 17;
		public const int SUBTITLE_Italian    = 18;
		public const int SUBTITLE_Japanese   = 19;
		public const int SUBTITLE_Korean     = 20;
		public const int SUBTITLE_Latvian    = 46;
		public const int SUBTITLE_Lithuanian = 47;
		public const int SUBTITLE_Mongolian  = 48;
		public const int SUBTITLE_Norwegian  = 21;
		public const int SUBTITLE_Pashtu     = 49;
		public const int SUBTITLE_Polish     = 22;
		public const int SUBTITLE_Portuguese = 23;
		public const int SUBTITLE_Romanian   = 24;
		public const int SUBTITLE_Rumantsch  = 50;
		public const int SUBTITLE_Russian    = 25;
		public const int SUBTITLE_Serbian    = 51;
		public const int SUBTITLE_Spanish    = 26;
		public const int SUBTITLE_Slovakian  = 27;
		public const int SUBTITLE_Slovenian  = 28;
		public const int SUBTITLE_Swedish    = 29;
		public const int SUBTITLE_SwissGerman= 52;
		public const int SUBTITLE_Tagalog    = 30;
		public const int SUBTITLE_Thai       = 31;
		public const int SUBTITLE_Tibetan    = 54;
		public const int SUBTITLE_Turkish    = 32;
		public const int SUBTITLE_Valencian  = 53;
		public const int SUBTITLE_Vietnamese = 55;
		public const int SUBTITLE_Xhosa      = 33;
		public const int SUBTITLE_Zulu       = 34;
		public const int SUBTITLE_Commentary = 35;
		public const int SUBTITLE_Trivia     = 36;
		public const int SUBTITLE_Other      = 37;
	
		public const int AUDIOCONT_None       = 0;
		public const int AUDIOCONT_Arabic     = 22;
		public const int AUDIOCONT_Bulgarian  = 23;
		public const int AUDIOCONT_Cantonese  = 18;
		public const int AUDIOCONT_Czech      = 24;
		public const int AUDIOCONT_Danish     = 15;
		public const int AUDIOCONT_Dutch      = 12;
		public const int AUDIOCONT_English    = 1;
		public const int AUDIOCONT_Farsi      = 31;
		public const int AUDIOCONT_Finnish    = 16;
		public const int AUDIOCONT_French     = 2;
		public const int AUDIOCONT_German     = 9;
		public const int AUDIOCONT_Greek      = 25;
		public const int AUDIOCONT_Hebrew     = 26;
		public const int AUDIOCONT_Hindi      = 20;
		public const int AUDIOCONT_Hungarian  = 27;
		public const int AUDIOCONT_Icelandic  = 30;
		public const int AUDIOCONT_Italian    = 10;
		public const int AUDIOCONT_Japanese   = 4;
		public const int AUDIOCONT_Korean     = 19;
		public const int AUDIOCONT_Mandarin   = 5;
		public const int AUDIOCONT_Norwegian  = 14;
		public const int AUDIOCONT_Polish     = 21;
		public const int AUDIOCONT_Portuguese = 17;
		public const int AUDIOCONT_Romanian   = 29;
		public const int AUDIOCONT_Russian    = 11;
		public const int AUDIOCONT_Spanish    = 3;
		public const int AUDIOCONT_Swedish    = 13;
		public const int AUDIOCONT_Tagalog    = 28;
		public const int AUDIOCONT_Turkish    = 32;
		public const int AUDIOCONT_Commentary = 6;
		public const int AUDIOCONT_MusicOnly  = 7;
		public const int AUDIOCONT_Other      = 8;

		public const int AUDIOFORMAT_None             = 0;
		public const int AUDIOFORMAT_DolbyDigital     = 3;
		public const int AUDIOFORMAT_DTS              = 5;
		public const int AUDIOFORMAT_DolbyDigitalEX   = 4;
		public const int AUDIOFORMAT_DTSES            = 6;
		public const int AUDIOFORMAT_DolbyDigitalPlus = 7;
		public const int AUDIOFORMAT_DolbyTrueHD      = 8;
		public const int AUDIOFORMAT_DTSHD_HR         = 9;
		public const int AUDIOFORMAT_DTSHD_MA         = 10;
		public const int AUDIOFORMAT_PCM              = 1;
		public const int AUDIOFORMAT_MP2              = 2;

		public const int AUDIOCHANNELS_None         = 0;
		public const int AUDIOCHANNELS_Mono         = 1;
		public const int AUDIOCHANNELS_2Channel     = 2;
		public const int AUDIOCHANNELS_Surround     = 3;
		public const int AUDIOCHANNELS_4_0          = 4;
		public const int AUDIOCHANNELS_4_1          = 5;
		public const int AUDIOCHANNELS_5_0          = 6;
		public const int AUDIOCHANNELS_5_1          = 7;
		public const int AUDIOCHANNELS_6_1_Matrixed = 8;
		public const int AUDIOCHANNELS_6_1_Discrete = 9;
		public const int AUDIOCHANNELS_7_1          = 10;
		public const int AUDIOCHANNELS_3_1          = 11;

		public const int EXCLUSIONTYPE_MoviePick  = 1;
		public const int EXCLUSIONTYPE_Mobile     = 2;
		public const int EXCLUSIONTYPE_iPhone     = 3;
		public const int EXCLUSIONTYPE_Remote     = 4;
		public const int EXCLUSIONTYPE_DPOPublic  = 5;
		public const int EXCLUSIONTYPE_DPOPrivate = 6;

		public const int EVENTTYPE_Borrowed = 0;
		public const int EVENTTYPE_Returned = 1;
		public const int EVENTTYPE_Watched  = 2;

		public const int CURRENCY_USD = 0;
		public const int CURRENCY_ARP = 1;
		public const int CURRENCY_AUD = 2;
		public const int CURRENCY_BRL = 3;
		public const int CURRENCY_CAD = 4;
		public const int CURRENCY_CLP = 5;
		public const int CURRENCY_CNY = 6;
		public const int CURRENCY_DKK = 7;
		public const int CURRENCY_EUR = 8;
		public const int CURRENCY_GBP = 9;
		public const int CURRENCY_HKD = 10;
		public const int CURRENCY_ISK = 11;
		public const int CURRENCY_INR = 12;
		public const int CURRENCY_IDR = 13;
		public const int CURRENCY_ILS = 14;
		public const int CURRENCY_JPY = 15;
		public const int CURRENCY_MXP = 16;
		public const int CURRENCY_NZD = 17;
		public const int CURRENCY_NOK = 18;
		public const int CURRENCY_PHP = 19;
		public const int CURRENCY_RUR = 20;
		public const int CURRENCY_SGD = 21;
		public const int CURRENCY_ZAR = 22;
		public const int CURRENCY_KRW = 23;
		public const int CURRENCY_SEK = 24;
		public const int CURRENCY_CHF = 25;
		public const int CURRENCY_TWD = 26;
		public const int CURRENCY_THB = 27;
		public const int CURRENCY_TRL = 28;
		///<summary>
		/// Stored internally as Satoshi (.00000001 XBT)
		///</summary>
		public const int CURRENCY_XBT = 30;

		public const int CREDIT_Undefined        = 255;
		public const int CREDIT_Direction        = 0;
		public const int CREDITSUB_Director               = 0;
		public const int CREDIT_Writing          = 1;
		public const int CREDITSUB_OriginalMaterialBy     = 0;
		public const int CREDITSUB_Screenwriter           = 1;
		public const int CREDITSUB_Writer                 = 2;
		public const int CREDITSUB_OriginalCharactersBy   = 3;
		public const int CREDITSUB_CreatedBy              = 4;
		public const int CREDITSUB_StoryBy                = 5;
		public const int CREDITSUB_DevelopedBy            = 6;
		public const int CREDIT_Production       = 2;
		public const int CREDITSUB_Producer               = 0;
		public const int CREDITSUB_ExecutiveProducer      = 1;
		public const int CREDIT_Cinematography   = 3;
		public const int CREDITSUB_Cinematographer        = 0;
		public const int CREDITSUB_DirectorOfPhotography  = 1;
		public const int CREDIT_FilmEditing      = 4;
		public const int CREDITSUB_FilmEditor             = 0;
		public const int CREDIT_Music            = 5;
		public const int CREDITSUB_Composer               = 0;
		public const int CREDITSUB_SongWriter             = 1;
		public const int CREDIT_Sound            = 6;
		public const int CREDITSUB_SoundEditor            = 0;
		public const int CREDITSUB_SoundReRecordingMixer  = 1;
		public const int CREDITSUB_SoundDesigner          = 2;
		public const int CREDITSUB_Sound                  = 3;
		public const int CREDITSUB_SupervisingSoundEditor = 4;
		public const int CREDITSUB_ProductionSoundMixer   = 5;
		public const int CREDIT_Art              = 7;
		public const int CREDITSUB_ProductionDesigner     = 0;
		public const int CREDITSUB_ArtDirector            = 1;

		public const int DIVIDER_Episode = 1;
		public const int DIVIDER_Group   = 2;
		public const int DIVIDER_Team    = 3;
		public const int DIVIDER_EndDiv  = 4;

		// IDVD Data load sections
		// Other data elements are always loaded and always saved
		public const int DATASEC_AllSections = -1;
		public const int DATASEC_Cast       = 1;
		public const int DATASEC_Crew       = 2;
		public const int DATASEC_Studios    = 4;
		public const int DATASEC_Retailers  = 8;
		public const int DATASEC_Audio      = 16;
		public const int DATASEC_BoxSet     = 32;
		public const int DATASEC_EasterEggs = 64;
		public const int DATASEC_Genres     = 128;
		public const int DATASEC_Features   = 256;
		public const int DATASEC_Regions    = 512;
		public const int DATASEC_Formats    = 1024;
		public const int DATASEC_Events     = 2048;
		public const int DATASEC_Review     = 4096;
		public const int DATASEC_Tags       = 8192;
		public const int DATASEC_Discs      = 16384;

		// ICollectionFilter Constants
		// ConditionTypes
		public const int CONDITION_Equal          = 0;
		public const int CONDITION_NotEqual       = 1;
		public const int CONDITION_GreaterThan    = 2;
		public const int CONDITION_LessThan       = 3;
		public const int CONDITION_GreaterOrEqual = 4;
		public const int CONDITION_LessOrEqual    = 5;
		public const int CONDITION_Contain        = 6;
		public const int CONDITION_NotContain     = 7;
		// Fields
		public const int FIELD_CollectionType = 0;
		public const int FIELD_IsLoaned       = 1;
		public const int FIELD_LoanDue        = 2;
		public const int FIELD_Genres         = 3;
		public const int FIELD_EverWatched    = 4;
		public const int FIELD_LastWatched    = 5;
		public const int FIELD_Studios        = 6;
		public const int FIELD_BoxSet         = 7;
		///<summary>
		/// Takes a User ID (int)
		///</summary>
		public const int FIELD_IsLoanedTo     = 8;
		///<summary>
		/// Takes a User ID (int)
		///</summary>
		public const int FIELD_WatchedBy      = 9;
		// Sort orders
		public const int SORT_Displayed            = 0;
		public const int SORT_Random               = 1;
		public const int SORT_TitleAsc             = 2;
		public const int SORT_TitleDesc            = 3;
		public const int SORT_CollectionNumberAsc  = 4;
		public const int SORT_CollectionNumberDesc = 5;
		public const int SORT_ProductionYearAsc    = 6;
		public const int SORT_ProductionYearDesc   = 7;
		public const int SORT_DVDReleaseAsc        = 8;
		public const int SORT_DVDReleaseDesc       = 9;
		public const int SORT_PurchaseDateAsc      = 10;
		public const int SORT_PurchaseDateDesc     = 11;
		public const int SORT_LastEditedAsc        = 12;
		public const int SORT_LastEditedDesc       = 13;
		public const int SORT_WishPriorityAsc      = 14;
		public const int SORT_WishPriorityDesc     = 15;
		public const int SORT_FirstGenreAsc        = 16;
		public const int SORT_FirstGenreDesc       = 17;
		public const int SORT_ReviewAsc            = 18;
		public const int SORT_ReviewDesc           = 19;
		public const int SORT_RunTimeAsc           = 20;
		public const int SORT_RunTimeDesc          = 21;
		public const int SORT_RatingAsc            = 22;
		public const int SORT_RatingDesc           = 23;
		public const int SORT_DiscLocationAsc      = 24;
		public const int SORT_DiscLocationDesc     = 25;
		public const int SORT_UPCAsc               = 26;
		public const int SORT_UPCDesc              = 27;
		public const int SORT_LastWatchedAsc       = 28;
		public const int SORT_LastWatchedDesc      = 29;
		// Interface color IDs
		public const int COLOR_BackgroundSolid     = 0;
		public const int COLOR_PanelGradTop        = 1;
		public const int COLOR_PanelGradBottom     = 2;
		public const int COLOR_PanelSolid          = 3;
		public const int COLOR_PanelBevel          = 4;
		public const int COLOR_MessageGradTop      = 5;
		public const int COLOR_MessageGradBottom   = 6;
		public const int COLOR_Highlight           = 7;
		public const int COLOR_HighlightText       = 8;
		public const int COLOR_ListLinesOdd        = 9;
		public const int COLOR_ListLinesEven       = 10;
		public const int COLOR_TabGradientTop      = 11;
		public const int COLOR_TabGradientBottom   = 12;
		public const int COLOR_TabBevel            = 13;
        
		public const int SHORTCUT_MOD_Shift = 0x2000;
		public const int SHORTCUT_MOD_Ctrl  = 0x4000;
		public const int SHORTCUT_MOD_Alt   = 0x8000;
		public const int SHORTCUT_MOD_None  = 0;

		public const int SHORTCUT_KEY_F1 = 112;
		public const int SHORTCUT_KEY_F2 = 113;
		public const int SHORTCUT_KEY_F3 = 114;
		public const int SHORTCUT_KEY_F4 = 115;
		public const int SHORTCUT_KEY_F5 = 116;
		public const int SHORTCUT_KEY_F6 = 117;
		public const int SHORTCUT_KEY_F7 = 118;
		public const int SHORTCUT_KEY_F8 = 119;
		public const int SHORTCUT_KEY_F9 = 120;
		public const int SHORTCUT_KEY_F10 = 121;
		public const int SHORTCUT_KEY_F11 = 122;
		public const int SHORTCUT_KEY_F12 = 123;

		public const int SHORTCUT_KEY_A = 65;
		// Additional shortCut Keys use ASCII values

		// Used for GetConstantByDescription and GetDescriptionByConstant
		public const int CONSTANT_TYPE_SUBTITLE      = 0;
		public const int CONSTANT_TYPE_AUDIOCONT     = 1;
		public const int CONSTANT_TYPE_AUDIOFORMAT   = 2;
		public const int CONSTANT_TYPE_AUDIOCHANNELS = 3;
		public const int CONSTANT_TYPE_GENRE         = 4;
		public const int CONSTANT_TYPE_CREDIT        = 5;
		public const int CONSTANT_TYPE_CREDITSUB     = 6;
		public const int CONSTANT_TYPE_CASETYPE      = 7;
		public const int CONSTANT_TYPE_CURRENCY      = 8;
		public const int CONSTANT_TYPE_LOCALITY      = 9;
		public const int CONSTANT_TYPE_COO           = 10;

		public const int FIELD_TYPE_INT          = 1;
		public const int FIELD_TYPE_STRING       = 2;
		public const int FIELD_TYPE_DATETIME     = 3;
		public const int FIELD_TYPE_CURRENCY     = 4;
		public const int FIELD_TYPE_BYTE_ARRAY   = 5;
        public const int FIELD_TYPE_BOOL         = 6;
        public const int FIELD_TYPE_INT_ARRAY    = 7;
        public const int FIELD_TYPE_STRING_ARRAY = 8;

        public const int FILTER_INPUT_TEXT     = 1;
        public const int FILTER_INPUT_NUMERIC  = 2;
        public const int FILTER_INPUT_CHECKBOX = 3;
        public const int FILTER_INPUT_LISTBOX  = 4;
        public const int FILTER_INPUT_DATE     = 5;
    }
	
	class CategoryRegistrar
	{
		[ComImport(), Guid("0002E012-0000-0000-C000-000000000046"),
			InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
			internal interface ICatRegister
		{
			void RegisterCategories(
				int cCategories,
				IntPtr rgCategoryInfo);

			void UnRegisterCategories(
				int cCategories,
				IntPtr rgcatid);

			void RegisterClassImplCategories(
				[In()] ref Guid rclsid,
				int cCategories,
				[In(), MarshalAs(UnmanagedType.LPArray)] Guid[] rgcatid);

			void UnRegisterClassImplCategories(
				[In()] ref Guid rclsid,
				int cCategories,
				[In(), MarshalAs(UnmanagedType.LPArray)] Guid[] rgcatid);

			void RegisterClassReqCategories(
				[In()] ref Guid rclsid,
				int cCategories,
				[In(), MarshalAs(UnmanagedType.LPArray)] Guid[] rgcatid);

			void UnRegisterClassReqCategories(
				[In()] ref Guid rclsid,
				int cCategories,
				[In(), MarshalAs(UnmanagedType.LPArray)] Guid[] rgcatid);
		}
	}

	[Guid("0A4F32DC-D6AF-4D79-AE47-06D9FA0A0492"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDVDInfo
	{
		// Internal use
		string GetID();
		string GetCollectionNumber();
		void SetCollectionNumber(string Value);
		string GetTitle();
		void SetTitle(string Value);
		string GetSortTitle();
		void SetSortTitle(string Value);
		string GetFormattedProfileID();
        string GetFormattedTitle();
		string GetFormattedRating();
		int GetProductionYear();
		void SetProductionYear(int Value);
		DateTime GetDVDReleaseDate();
		void SetDVDReleaseDate(DateTime Value);
        bool DVDReleaseDateIsEmpty();
        void ClearDVDReleaseDate();
		DateTime GetPurchaseDate();
		void SetPurchaseDate(DateTime Value);
        bool PurchaseDateIsEmpty();
        void ClearPurchaseDate();
		bool GetReceivedAsGift();
		void SetReceivedAsGift(bool Value);
		void GetGiftFrom(out string FirstName, out string LastName);
		void SetGiftFrom(string FirstName, string LastName);
		int GetRuntime();
		void SetRuntime(int Value);
		string GetFormattedGenres();
		bool GetFormatWidescreen();
		void SetFormatWidescreen(bool Value);
		bool GetFormatAnamorphic();
		void SetFormatAnamorphic(bool Value);
		bool GetFormatPanScan();
		void SetFormatPanScan(bool Value);
		bool GetFormatFullFrame();
		void SetFormatFullFrame(bool Value);
		string GetAspectRatio();
		void SetAspectRatio(string Value);
		string GetProfileID();
		void SetProfileID(string Value);
		int GetCaseID();
		void SetCaseID(int Value);
		bool GetCaseSlipCover();
		void SetCaseSlipCover(bool Value);
		int GetVideoStandard();
		void SetVideoStandard(int Value);

		// These use the bitwise values from above
		int GetColorType();
		void SetColorType(int Value);

		string GetOverview();
		void SetOverview(string Value);
		string GetEasterEggs();
		void SetEasterEggs(string Value);
		string GetNotes();
		void SetNotes(string Value);
		string GetEdition();
		void SetEdition(string Value);
		string GetOriginalTitle();
		void SetOriginalTitle(string Value);
		int GetWishPriority();
		void SetWishPriority(int Value);
		bool GetFeatureByID(int FeatureID);
		void SetFeatureByID(int FeatureID, bool Value);
		bool GetLockByID(int LockID);
		void SetLockByID(int LockID, bool Value);
		DateTime GetLastEdited();
		void SetLastEdited(DateTime Value);
		DateTime GetLoanDue();
		void SetLoanDue(DateTime Value);
		int GetCountryOfOrigin(int COOIndex);
		void SetCountryOfOrigin(int COOIndex, int Value);
		string GetPurchasePlace();
		void SetPurchasePlace(string Value);
		string GetOtherFeatures();
		void SetOtherFeatures(string Value);
		int GetCollectionType();
		void SetCollectionType(int Value);
		bool GetRegionByID(int RegionID);
		void SetRegionByID(int RegionID, bool Value);
		string GetStudio(int StudioIndex);
		void SetStudio(int StudioIndex, string Value);
		int GetGenre(int GenreIndex);
		void SetGenre(int GenreIndex, int Value);
		// SRP Value is passed as a fixed-point data type with four implicit decimal places: e.g. 29.95 is passed as 299500.
		long GetSRPValue();
		void SetSRPValue(long Value);
		int GetSRPCurrency();
		void SetSRPCurrency(int Value);
		// Purchase Price Value is passed as a fixed-point data type with four implicit decimal places: e.g. 29.95 is passed as 299500.
		long GetPurchasePriceValue();
		void SetPurchasePriceValue(long Value);
		int GetPurchasePriceCurrency();
		void SetPurchasePriceCurrency(int Value);
		bool PurchasePriceIsEmpty();
		void ClearPurchasePrice();
		void GetReview(out int Film, out int Video, out int Audio, out int Extras);
		void SetReview(int Film, int Video, int Audio, int Extras);
		// Cast
		int GetCastCount();
		void ClearCast();
		void GetCastByIndex(int CastIndex, out string FirstName, out string MiddleName,
		  out string LastName, out int BirthYear, out string Part, out string CreditedAs,
		  out bool Voice, out bool Uncredited);
		void SetCastByIndex(int CastIndex, string FirstName, string MiddleName,
			string LastName, int BirthYear, string Part, string CreditedAs,
			bool Voice, bool Uncredited);
		void AddCast(string FirstName, string MiddleName,
			string LastName, int BirthYear, string Part, string CreditedAs,
			bool Voice, bool Uncredited);
		// Crew
		int GetCrewCount();
		void ClearCrew();
		void GetCrewByIndex(int CrewIndex, out string FirstName, out string MiddleName,
			out string LastName, out int BirthYear, out int CreditType, out int CreditSubtype, 
			out string CreditedAs);
		void SetCrewByIndex(int CrewIndex, string FirstName, string MiddleName,
			string LastName, int BirthYear, int CreditType, int CreditSubtype, string CreditedAs);
		void AddCrew(string FirstName, string MiddleName,
			string LastName, int BirthYear, int CreditType, int CreditSubtype, string CreditedAs);
		void GetMediaTypes(out bool DVD, out bool HDDVD, out bool BluRay);
		void SetMediaTypes(bool DVD, bool HDDVD, bool BluRay);
		void GetDimensions(out bool Dim2D, out bool Dim3DAnaglyph, out bool Dim3DBluRay);
		void SetDimensions(bool Dim2D, bool Dim3DAnaglyph, bool Dim3DBluRay);
		void GetCustomMediaType(out string MediaTypeName);
		void SetCustomMediaType(string MediaTypeName);
		// Box set
		int GetBoxSetContentCount();
		void ClearBoxSetContents();
		string GetBoxSetContentByIndex(int BoxIndex);
		void SetBoxSetContentByIndex(int BoxIndex, string Value);
		void AddBoxSetContent(string Value);
		// Subtitles
		int GetSubtitleCount();
		void ClearSubtitles();
		int GetSubtitleByIndex(int SubIndex);
		void SetSubtitleByIndex(int SubIndex, int Value);
		void AddSubtitle(int Value);
		// Audio Tracks
		void GetAudioTrack(int TrackIndex, out int ContentID, out int FormatID, out int ChannelsID);
		void SetAudioTrack(int TrackIndex, int ContentID, int FormatID, int ChannelsID);
		// Discs
		int GetDiscCount();
		void ClearDiscs();
		void GetDiscByIndex(int DiscIndex, out string DescriptionSideA, out string DescriptionSideB,
			out string LabelSideA, out string LabelSideB, out string DiscIDSideA, out string DiscIDSideB,
			out bool DualLayeredSideA, out bool DualLayeredSideB, out string Location, out string Slot);
		void SetDiscByIndex(int DiscIndex, string DescriptionSideA, string DescriptionSideB,
			string LabelSideA, string LabelSideB, string DiscIDSideA, string DiscIDSideB,
			bool DualLayeredSideA, bool DualLayeredSideB, string Location, string Slot);
		void AddDisc(string DescriptionSideA, string DescriptionSideB,
			string LabelSideA, string LabelSideB, string DiscIDSideA, string DiscIDSideB,
			bool DualLayeredSideA, bool DualLayeredSideB, string Location, string Slot);
		// Tags
		int GetTagCount();
		void ClearTags();
		string GetTagByIndex(int TagIndex);
		void SetTagByIndex(int TagIndex, string Value);
		void AddTag(string Value);
		// Events (History)
		int GetEventCount();
		void ClearEvents();
		void GetEventByIndex(int EventIndex, out string UserFirstName, out string UserLastName,
			out int EventType, out DateTime TimeStamp, out string Note);
		void SetEventByIndex(int EventIndex, string UserFirstName, string UserLastName,
			int EventType, DateTime TimeStamp, string Note);
		void AddEvent(string UserFirstName, string UserLastName,
			int EventType, DateTime TimeStamp, string Note);
		// Other functions
		string GetCoverImageFilename(bool Front, bool Thumbnail);
		string GetXML(bool IncludePersonalInfo);
		bool GetChangesMadeIndicator();
		void SetChangesMadeIndicator(bool Value);
		bool GetPurchasePlaceIsOnline();
		void SetPurchasePlaceIsOnline(bool Value);
		string GetPurchasePlaceWebsite();
		void SetPurchasePlaceWebsite(string Value);
		bool GetPurchasePriceIsEmpty();
		void SetProfileTimestamp(DateTime Value);
		DateTime GetProfileTimestamp();
		string GetParentProfileID();
		void GetCastDividerByIndex(int CastIndex, out string Caption, out int DividerType);
		void SetCastDividerByIndex(int CastIndex, out int DividerType);
        void AddCastDivider(string Caption, int DividerType);
        void GetCrewDividerByIndex(int CrewIndex, out string Caption, out int DividerType, out int CreditType);
        void SetCrewDividerByIndex(int CrewIndex, string Caption, int DividerType, int CreditType);
        string GetCrewCustomRoleByIndex(int CrewIndex);
		void SetCrewCustomRoleByIndex(int CrewIndex, string CustomRole);
		void AddCrewDivider(string Caption, int DividerType, int CreditType);
		string GetMediaCompany(int MediaCompanyIndex);
		void SetMediaCompany(int MediaCompanyIndex, string Value);
		int GetCountAs();
		void SetCountAs(int Value);
		void GetRating(out int RatingSystem, out int RatingAge, out int RatingVariant);
		void SetRating(int RatingSystem, int RatingAge, int RatingVariant);
		string GetRatingDescription();
		void SetRatingDescription(string Value);
		void GetBDRegions(out bool RegA, out bool RegB, out bool RegC);
		void SetBDRegions(bool RegA, bool RegB, bool RegC);
		bool GetExclusion(int ExclusionType);
		void SetExclusion(int ExclusionType, bool ExclusionOn);
		bool GetContributableChangesMade();
		// Controls display of the contribute indicator
		void SetContributableChangesMade(bool Value);
		// NOTE: The XML here is a compact format that differs from that shown in the XML export. Check it for examples
		string GetMyLinksXML();
		// NOTE: The XML here is a compact format that differs from that shown in the XML export. Check GetMyLinksXML for examples
		void SetMyLinksXML(string Value);

		int GetCustomInt(string FieldDomain, string FieldName, string ReadKey, int DefaultVal);
        string GetCustomString(string FieldDomain, string FieldName, string ReadKey, string DefaultVal);
        DateTime GetCustomDateTime(string FieldDomain, string FieldName, string ReadKey, DateTime DefaultVal);
        long GetCustomCurrency(string FieldDomain, string FieldName, string ReadKey, long DefaultVal);
        bool GetCustomBool(string FieldDomain, string FieldName, string ReadKey, bool DefaultVal);
        object GetCustomByteArray(string FieldDomain, string FieldName, string ReadKey);
        object GetCustomIntArray(string FieldDomain, string FieldName, string ReadKey);
        object GetCustomStringArray(string FieldDomain, string FieldName, string ReadKey);
        
        // FieldDomain optional, otherwise will use the plugin's ClassID
        void SetCustomInt(string FieldDomain, string FieldName, string WriteKey, int NewValue);
        void SetCustomString(string FieldDomain, string FieldName, string WriteKey, string NewValue);
        void SetCustomDateTime(string FieldDomain, string FieldName, string WriteKey, DateTime NewValue);
        void SetCustomCurrency(string FieldDomain, string FieldName, string WriteKey, long NewValue);
        void SetCustomBool(string FieldDomain, string FieldName, string WriteKey, bool NewValue);
        void SetCustomByteArray(string FieldDomain, string FieldName, string WriteKey, object NewValue);
        void SetCustomIntArray(string FieldDomain, string FieldName, string WriteKey, object NewValue);
        void SetCustomStringArray(string FieldDomain, string FieldName, string WriteKey, object NewValue);

        bool CustomFieldIsEmpty(string FieldDomain, string FieldName, string ReadKey);
        void ClearCustomField(string FieldDomain, string FieldName, string WriteKey);
    }
	
	[Guid("F4D739B8-0A66-4D3E-9230-680370B399B2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDVDProfilerAPI
	{
        string GetLastError();
		void SelectDVDByProfileID(string ProfileID);
		object GetFlaggedProfileIDs();
        void FlagDVDByProfileID(string ProfileID, bool FlagOn);
		void  FlagAllDVDs(bool FlagOn);
		void FlagAllDisplayedDVDs(bool FlagOn);
		bool DVDIsFlaggedByProfileID(string ProfileID);
		void RegisterForEvent(int EventType);
		string RegisterMenuItem(int FormID, int MenuID, string MenuPath, string Caption, int EventID);
		void SetMenuGlyph(string MenuToken, object LargeImage, object SmallImage, string HintTitle, string HintContent);
		void AssignMenuItemToToolbar(string MenuToken, string ToolbarCaption, bool CreateAsNeeded);
		void RemoveMenuItemFromToolbar(string MenuToken, string ToolbarCaption);
		void UnregisterMenuItem(string MenuToken);
		bool GetRegisteredMenuItemChecked(string MenuToken); 
		void SetRegisteredMenuItemChecked(string MenuToken, bool Checked);
		int GetSortIndexByProfileID(string ProfileID);
		IDVDInfo GetDisplayedDVD();
		// Pass -1 for DataSections for all data; Pass -1 for MaxCast for all cast entries
		// Odd paramater convention due to conflicts with backwards compatibility 
		void DVDByProfileID(out IDVDInfo DVD, string ProfileID, int DataSections, int MaxCast);
		IDVDInfo CreateDVD();
		ICollectionFilter GetCollectionFilter();
		object GetFilteredProfileIDs(ICollectionFilter CollectionFilter);
		object GetDisplayedProfileIDs(int SortOrder);
		object GetAllProfileIDs();
		void SetDisplayedProfileIDs(object ProfileIDList);
		IDVDProfilerPluginHostWindow CreateHostWindow(string PanelCaption);
		
		// Parental control
		bool ParentalControlIsEnabled();
		bool ParentalControlHideInCollection();
		bool ParentalControlHideInOnlineListing();

		// Program Actions
		void FocusMainForm();
		void SetMainFormVisible(bool Visible);
		void ClearAllFilters();
		void ReloadCurrentDVD();
		void RequeryDatabase();
		void UnloadMe();
		void PerformPendingDownloads();
		void ClearPendingDownloads();
		bool DisplayDVDPersonalize(IDVDInfo DVD);
		bool DisplayDVDEdit(IDVDInfo DVD, bool IncludeCoverScanPage, bool IncludePersonalizePage);
		void DisplayCoverScanEdit(string ProfileID);
		void RemoveDVDFromCollection(string ProfileID, bool RemoveCoverScans);
		void SaveDVDToCollection(IDVDInfo DVD);
		void UpdateProfileInListDisplay(string ProfileID);
		
		// Interface queries
		int GetInterfaceColor(int ColorID);

		// Call an action for the specific FormID, which must be loaded
		// ActionID is one of public const int ACTIONID_FormID_XXX
		// ActionData A, B, C and the return value vary by the ActionID
		// Returns public const int ACTIONResult_Unknown for an unknown FormID/ActionID combination
		// Returns public const int ACTIONResult_FormNotLoaded if the form isn't loaded
		object ExecuteAction(int FormID, int ActionID, object ActionDataA, object ActionDataB, object ActionDataC);

		string GetDVDProfilerVersion();
		int GetDVDProfilerBuildNumber();
		void SaveDVDToCollectionPartial(IDVDInfo DVD, int DataSections);
		void LoadFlagSet(string PathFileName);
		void SaveFlagSet(string PathFileName);
		void LoadFilterSetFromFile(string PathFileName, bool LoadTypeAndSort);
		void LoadFilterSetFromString(string FilterString, bool LoadTypeAndSort);
		void SaveFilterSetToFile(string PathFileName, bool SaveTypeAndSort);
		string GetFilterSetAsString(bool SaveTypeAndSort);
		void ShowNotification(string MessageText, string TitleText);
		string GetDefaultOpticalDrive();
		string GetDiscIDFromDrive(string RootPath, out bool IsBluRay, out bool IsDualLayered);
		void SetRegisteredMenuItemEnabled(string MenuToken, bool Enabled);
		string RegisterMenuItemA(int FormID, int MenuID, string MenuPath, string Caption, int EventID,
			string AfterMenuItem, int ShortCutKey, int ShortCutModifier, bool BeginGroup);
		void TriggerMenuItem(int FormID, int MenuID, string MenuPath, string MenuItem);
		string GetDescriptionByConstant(int ConstantType, int ConstantValue, int ConstantSubValue);
		int GetConstantByDescription(int ConstantType, string Description);
		string TranslateString(string InStr, string Key);
		void GetCustomCollectionCategoryInfo(int CollectionType, out string Name, out bool IncludeInOwned,
			out bool TrackCollectionNums, out bool TrackPurchaseInfo);
		void RunCommandFile(string FileName);
		void GetCurrentDatabaseInformation(out string Name, out bool IsRemote, out string LocalPath);
		// Developer must ensure tag has no child tags or they will be orphaned, also only supported on local databases
		void RemoveTag(string TagPathAndName);
		// Returns a variant array of matching User IDs
		object GetUserIDs(bool JustBorrowers, bool JustWatchers, bool JustPrincipals);
		IDVDProfilerUser GetUserByID(int UserID);
		// Returns a variant array of matching Retailer IDs
		object GetRetailerIDs(bool JustOnline, bool JustLocal);
		IDVDProfilerRetailer GetRetailerByID(int RetailerID);
        string EncodeProfileID(string UPCOrDiscID, int LocalityID, int VariantID);
        void DecodeProfileID(string EncodedProfileID, out string UPCOrDiscID, out int LocalityID, out int VariantID);
        // These return a variant array of matching profile IDs
        // Pass -1 to match all localities
        object GetMatchingOnlineProfileIDsByUPC(string UPC, int Locality);
        object GetMatchingOnlineProfileIDsByDiscID(string DiscID, int Locality);
        object GetMatchingOnlineProfileIDsByTitleSearch(string TitleSearchString, bool SearchWithin, bool SearchOriginalTitle, int Locality, bool DVD, bool BluRay);
        void GetInfoOnlineProfileID(string ProfileID, out string Title, out string OriginalTitle, out string Edition, out int Locality, out int ProdYear,
            out int RatingAge, out string Rating, out bool DVD, out bool BluRay, out DateTime ReleaseDate);
        bool GetOnlineProfileByID(out IDVDInfo RetDVD, string ProfileID);
        // Pass blank string for ToDirectory to store in the images directory of the current database
        bool DownloadCoverImagesForProfileID(string ProfileID, string ToDirectory);
        string GetURLForOnlineThumbnail(string ProfileID, bool ForFront);
		// Headshot methods take/return variant arrays of bytes containing the contents of the JPEG file/////////////////////////////
		// Set functions may only be called on local databases
		object GetCastHeadshot(string FirstName, string MiddleName, string LastName, int BirthYear);
		object GetCrewHeadshot(string FirstName, string MiddleName, string LastName, int BirthYear);
		object GetCastCustomHeadshot(string FirstName, string MiddleName, string LastName, int BirthYear, string ForProfileID);
		object GetCrewCustomHeadshot(string FirstName, string MiddleName, string LastName, int BirthYear, string ForProfileID);
		void SetCastHeadshot(string FirstName, string MiddleName, string LastName, int BirthYear, object ImageData);
		void SetCrewHeadshot(string FirstName, string MiddleName, string LastName, int BirthYear, object ImageData);
		void SetCastCustomHeadshot(string FirstName, string MiddleName, string LastName, int BirthYear, string ForProfileID, object ImageData);
		void SetCrewCustomHeadshot(string FirstName, string MiddleName, string LastName, int BirthYear, string ForProfileID, object ImageData);

        void GetCastHeadshotInfo(string FirstName, string MiddleName, string LastName, int BirthYear, string ForProfileID, out bool DBPhotoExists, out bool DBPhotoLocked, out string CustomPhotoFileName, out string ProfilePhotoFileName);
        void GetCrewHeadshotInfo(string FirstName, string MiddleName, string LastName, int BirthYear, string ForProfileID, out bool DBPhotoExists, out bool DBPhotoLocked, out string CustomPhotoFileName, out string ProfilePhotoFileName);
    
        void ShowCastInfo(string FirstName, string MiddleName, string LastName, int BirthYear, bool AllowJumpTo);
		// Pass CREDIT_Undefined to display entries for all credit types
		void ShowCrewInfo(string FirstName, string MiddleName, string LastName, int BirthYear, int CreditType, bool AllowJumpTo);
		// As with other currency functions, amounts are passed as a long with 4 implicit decimal places
		long ConvertCurrency(long SourceAmount, int SourceCurrency, int DestCurrency);
		
		// Custom data field functions
    	// WARNING: Field definitions are cleared whenever the database is cleared (for instance when performing a full database restore)

    	// FieldType per FIELD_TYPE_ constants above
    	// True on success
        // FieldDomain optional, otherwise will use the plugin's ClassID
        // Custom field definitions are database-specific. Register for EVENTID_DatabaseOpened
        bool CreateCustomDVDField(string FieldDomain, string FieldName, int FieldType, string ReadKey, string WriteKey);
        void DeleteCustomDVDField(string FieldDomain, string FieldName, string WriteKey);
        void SetCustomDVDFieldKeys(string FieldDomain, string FieldName, string CurWriteKey, string NewReadKey, string NewWriteKey);
        void SetCustomDVDFieldStorage(string FieldDomain, string FieldName, string WriteKey, bool StoreInBackup, bool StoreInDPO);
	
        // Returns XML definitions for all plugins with custom fields accessible to the current plugin
        string GetCustomDVDFieldDefinitions();

        // These return a Field Filter Token
        // DisplayName: displayed next to the entry fields in the UI
        string SetCustomFieldFilterable(string FieldDomain, string FieldName, string ReadKey, string DisplayName);
        // FilterFieldMatch will be called for each potential match when filtering
        // DisplayName: displayed next to the entry fields in the UI
        // EntryType: one of FILTER_INPUT_ constants above 
        // ComparisonTypes: optional array of strings (else null) e.g. "Contains"
        // MatchItemList: optional array of strings, for use with FILTER_INPUT_LISTBOX
        string SetCustomFieldFilterableA(string DisplayName, int EntryType, object ComparisonTypes, object MatchItemList);
        void RemoveCustomFilterField(string  FieldFilterToken);

        // Global settings are scoped to the current open database
        // ReadKey and WriteKey may be any string to restrict access or blank to allow public access
        // SettingDomain can be blank and will use the plugin's class ID
        void SetGlobalSetting(string SettingDomain, string SettingName, string SettingValue, string ReadKey, string WriteKey);
        string GetGlobalSetting(string SettingDomain, string SettingName, string ReadKey, string DefaultValue);
        void RemoveGlobalSetting(string SettingDomain, string SettingName, string WriteKey);

    }

	[Guid("6598EA88-8FAD-4875-A2F0-39BA225B8233"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDVDProfilerPluginHostWindow
	{
		int GetWindowHandle();
		void CloseWindow();
		void ShowWindow();
		void HideWindow();
		void SetCaption(string Caption);
		void SetInitialSize(int Width, int Height);
	}

	[Guid("2E7E8A3D-FAB8-4DFD-955A-D9B1F607A58C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICollectionFilter
	{
		void SetJoinWithOr(bool Value);
		bool GetJoinWithOr();
		void SetSortOrder(int Value);
		int GetSortOrder();
		void SetIgnoreParentalControl(bool Value);
		bool GetIgnoreParentalControl();
		
		// Other functions
		void Clear();
		void AddCondition(int ConditionField, int ConditionType, object ConditionValue);
		// Internal use
		string GetID();
	}

	[Guid("38D6312C-4B22-4620-A04F-2CC80C873118"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDVDProfilerPluginInfo
	{
		string GetName();
		string GetDescription();
		string GetAuthorName();
		string GetAuthorWebsite();
		int GetPluginAPIVersion();
		int GetVersionMajor();
		int GetVersionMinor();
	}

    [Guid("821F3161-31F3-4778-A9CE-A026EDE00B3D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDVDProfilerPlugin
	{
		void Load(IDVDProfilerAPI DVDProAPI);
		void Unload();
		void HandleEvent(int EventType, object EventData);
	}

	[Guid("3C585134-A0DA-4DAF-A655-8C424B870FC8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDVDProfilerDataAwarePlugin
	{
		bool ExportsCustomDataXML();
		string GetCustomDataXMLForDVD(IDVDInfo SourceDVD);
		
		// These should return an empty string if not otherwise implemented
 		string GetHTMLForDPVarsFunctionSection();
		string GetHTMLForDPVarsDataSection(IDVDInfo SourceDVD, IDVDInfo CompareDVD);

		// Can handle custom tags, or override behavior of built-in tags
		string GetHTMLForTag(string TagName, string FullTag, IDVDInfo SourceDVD, IDVDInfo CompareDVD, out bool Handled);
		
		// These should return null, or an array of strings
		object GetCustomHTMLTagNames();
		object GetCustomHTMLParamsForTag(string TagName);

        // Called for each potential match when filtering. Return true to match
        // For use with SetCustomFieldFilterableA
        // ComparisonTypeIndex: the selected index into ComparisonTypes
        // ComparisonValue: the selected index into MatchItemList, or the user-entered value if no list
        // TestDVD: Shell profile record (Profile ID and access to custom fields only)
        // If more data is required from the profile, need to use DVDByProfileID or similar
        bool FilterFieldMatch(string FieldFilterToken, int ComparisonTypeIndex, object ComparisonValue, IDVDInfo TestDVD);
	}

	[Guid("F47F9D16-DC4D-45B7-9153-50195F99FAC1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDVDProfilerUser
	{
		int GetUserID();
		string GetFirstName();
		string GetLastName();
		string GetPhoneNumber();
		string GetEmailAddress();
		bool GetRoleBorrows();
		bool GetRoleWatches();
		bool GetMaxRatingAge();
		bool GetRatingAdultOK();
		bool GetIsPrincipalUser();
	}

	[Guid("2B6FF6EE-CC7E-4817-A01C-18166921D576"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDVDProfilerRetailer
	{
		int GetRetailerID();
		string GetName();
		string GetWebsite();
		bool GetIsOnline();
	}

}
