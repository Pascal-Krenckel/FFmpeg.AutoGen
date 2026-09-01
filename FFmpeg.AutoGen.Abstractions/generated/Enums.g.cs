namespace FFmpeg.AutoGen.Abstractions;

public enum _AVActiveFormatDescription : int
{
    @AV_AFD_SAME = 8,
    @AV_AFD_4_3 = 9,
    @AV_AFD_16_9 = 10,
    @AV_AFD_14_9 = 11,
    @AV_AFD_4_3_SP_14_9 = 13,
    @AV_AFD_16_9_SP_14_9 = 14,
    @AV_AFD_SP_4_3 = 15,
}

/// <summary>Correlation between the alpha channel and color values.</summary>
public enum _AVAlphaMode : int
{
    /// <summary>Unknown alpha handling, or no alpha channel</summary>
    @AVALPHA_MODE_UNSPECIFIED = 0,
    /// <summary>Alpha channel is multiplied into color values</summary>
    @AVALPHA_MODE_PREMULTIPLIED = 1,
    /// <summary>Alpha channel is independent of color values</summary>
    @AVALPHA_MODE_STRAIGHT = 2,
    /// <summary>Not part of ABI</summary>
    @AVALPHA_MODE_NB = 3,
}

/// <summary>Message types used by avdevice_app_to_dev_control_message().</summary>
public enum _AVAppToDevMessageType : int
{
    /// <summary>Dummy message.</summary>
    @AV_APP_TO_DEV_NONE = 1313820229,
    /// <summary>Window size change message.</summary>
    @AV_APP_TO_DEV_WINDOW_SIZE = 1195724621,
    /// <summary>Repaint request message.</summary>
    @AV_APP_TO_DEV_WINDOW_REPAINT = 1380274241,
    /// <summary>Request pause/play.</summary>
    @AV_APP_TO_DEV_PAUSE = 1346458912,
    /// <summary>Request pause/play.</summary>
    @AV_APP_TO_DEV_PLAY = 1347174745,
    /// <summary>Request pause/play.</summary>
    @AV_APP_TO_DEV_TOGGLE_PAUSE = 1346458964,
    /// <summary>Volume control message.</summary>
    @AV_APP_TO_DEV_SET_VOLUME = 1398165324,
    /// <summary>Mute control messages.</summary>
    @AV_APP_TO_DEV_MUTE = 541939028,
    /// <summary>Mute control messages.</summary>
    @AV_APP_TO_DEV_UNMUTE = 1431131476,
    /// <summary>Mute control messages.</summary>
    @AV_APP_TO_DEV_TOGGLE_MUTE = 1414354260,
    /// <summary>Get volume/mute messages.</summary>
    @AV_APP_TO_DEV_GET_VOLUME = 1196838732,
    /// <summary>Get volume/mute messages.</summary>
    @AV_APP_TO_DEV_GET_MUTE = 1196250452,
}

public enum _AVAudioServiceType : int
{
    @AV_AUDIO_SERVICE_TYPE_MAIN = 0,
    @AV_AUDIO_SERVICE_TYPE_EFFECTS = 1,
    @AV_AUDIO_SERVICE_TYPE_VISUALLY_IMPAIRED = 2,
    @AV_AUDIO_SERVICE_TYPE_HEARING_IMPAIRED = 3,
    @AV_AUDIO_SERVICE_TYPE_DIALOGUE = 4,
    @AV_AUDIO_SERVICE_TYPE_COMMENTARY = 5,
    @AV_AUDIO_SERVICE_TYPE_EMERGENCY = 6,
    @AV_AUDIO_SERVICE_TYPE_VOICE_OVER = 7,
    @AV_AUDIO_SERVICE_TYPE_KARAOKE = 8,
    /// <summary>Not part of ABI</summary>
    @AV_AUDIO_SERVICE_TYPE_NB = 9,
}

/// <summary>Audio channel layout utility functions</summary>
public enum _AVChannel : int
{
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_NONE = -1,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_FRONT_LEFT = 0,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_FRONT_RIGHT = 1,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_FRONT_CENTER = 2,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_LOW_FREQUENCY = 3,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_BACK_LEFT = 4,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_BACK_RIGHT = 5,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_FRONT_LEFT_OF_CENTER = 6,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_FRONT_RIGHT_OF_CENTER = 7,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_BACK_CENTER = 8,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_SIDE_LEFT = 9,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_SIDE_RIGHT = 10,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_TOP_CENTER = 11,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_TOP_FRONT_LEFT = 12,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_TOP_FRONT_CENTER = 13,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_TOP_FRONT_RIGHT = 14,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_TOP_BACK_LEFT = 15,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_TOP_BACK_CENTER = 16,
    /// <summary>Invalid channel index</summary>
    @AV_CHAN_TOP_BACK_RIGHT = 17,
    /// <summary>Stereo downmix.</summary>
    @AV_CHAN_STEREO_LEFT = 29,
    /// <summary>See above.</summary>
    @AV_CHAN_STEREO_RIGHT = 30,
    /// <summary>See above.</summary>
    @AV_CHAN_WIDE_LEFT = 31,
    /// <summary>See above.</summary>
    @AV_CHAN_WIDE_RIGHT = 32,
    /// <summary>See above.</summary>
    @AV_CHAN_SURROUND_DIRECT_LEFT = 33,
    /// <summary>See above.</summary>
    @AV_CHAN_SURROUND_DIRECT_RIGHT = 34,
    /// <summary>See above.</summary>
    @AV_CHAN_LOW_FREQUENCY_2 = 35,
    /// <summary>See above.</summary>
    @AV_CHAN_TOP_SIDE_LEFT = 36,
    /// <summary>See above.</summary>
    @AV_CHAN_TOP_SIDE_RIGHT = 37,
    /// <summary>See above.</summary>
    @AV_CHAN_BOTTOM_FRONT_CENTER = 38,
    /// <summary>See above.</summary>
    @AV_CHAN_BOTTOM_FRONT_LEFT = 39,
    /// <summary>See above.</summary>
    @AV_CHAN_BOTTOM_FRONT_RIGHT = 40,
    /// <summary>+90 degrees, Lss, SiL</summary>
    @AV_CHAN_SIDE_SURROUND_LEFT = 41,
    /// <summary>-90 degrees, Rss, SiR</summary>
    @AV_CHAN_SIDE_SURROUND_RIGHT = 42,
    /// <summary>+110 degrees, Lvs, TpLS</summary>
    @AV_CHAN_TOP_SURROUND_LEFT = 43,
    /// <summary>-110 degrees, Rvs, TpRS</summary>
    @AV_CHAN_TOP_SURROUND_RIGHT = 44,
    @AV_CHAN_BINAURAL_LEFT = 61,
    @AV_CHAN_BINAURAL_RIGHT = 62,
    /// <summary>Channel is empty can be safely skipped.</summary>
    @AV_CHAN_UNUSED = 512,
    /// <summary>Channel contains data, but its position is unknown.</summary>
    @AV_CHAN_UNKNOWN = 768,
    /// <summary>Range of channels between AV_CHAN_AMBISONIC_BASE and AV_CHAN_AMBISONIC_END represent Ambisonic components using the ACN system.</summary>
    @AV_CHAN_AMBISONIC_BASE = 1024,
    /// <summary>Range of channels between AV_CHAN_AMBISONIC_BASE and AV_CHAN_AMBISONIC_END represent Ambisonic components using the ACN system.</summary>
    @AV_CHAN_AMBISONIC_END = 2047,
}

public enum _AVChannelOrder : int
{
    /// <summary>Only the channel count is specified, without any further information about the channel order.</summary>
    @AV_CHANNEL_ORDER_UNSPEC = 0,
    /// <summary>The native channel order, i.e. the channels are in the same order in which they are defined in the AVChannel enum. This supports up to 63 different channels.</summary>
    @AV_CHANNEL_ORDER_NATIVE = 1,
    /// <summary>The channel order does not correspond to any other predefined order and is stored as an explicit map. For example, this could be used to support layouts with 64 or more channels, or with empty/skipped (AV_CHAN_UNUSED) channels at arbitrary positions.</summary>
    @AV_CHANNEL_ORDER_CUSTOM = 2,
    /// <summary>The audio is represented as the decomposition of the sound field into spherical harmonics. Each channel corresponds to a single expansion component. Channels are ordered according to ACN (Ambisonic Channel Number).</summary>
    @AV_CHANNEL_ORDER_AMBISONIC = 3,
    /// <summary>Number of channel orders, not part of ABI/API</summary>
    @FF_CHANNEL_ORDER_NB = 4,
}

/// <summary>Location of chroma samples.</summary>
public enum _AVChromaLocation : int
{
    @AVCHROMA_LOC_UNSPECIFIED = 0,
    /// <summary>MPEG-2/4 4:2:0, H.264 default for 4:2:0</summary>
    @AVCHROMA_LOC_LEFT = 1,
    /// <summary>MPEG-1 4:2:0, JPEG 4:2:0, H.263 4:2:0</summary>
    @AVCHROMA_LOC_CENTER = 2,
    /// <summary>ITU-R 601, SMPTE 274M 296M S314M(DV 4:1:1), mpeg2 4:2:2</summary>
    @AVCHROMA_LOC_TOPLEFT = 3,
    @AVCHROMA_LOC_TOP = 4,
    @AVCHROMA_LOC_BOTTOMLEFT = 5,
    @AVCHROMA_LOC_BOTTOM = 6,
    /// <summary>Not part of ABI</summary>
    @AVCHROMA_LOC_NB = 7,
}

public enum _AVClassCategory : int
{
    @AV_CLASS_CATEGORY_NA = 0,
    @AV_CLASS_CATEGORY_INPUT = 1,
    @AV_CLASS_CATEGORY_OUTPUT = 2,
    @AV_CLASS_CATEGORY_MUXER = 3,
    @AV_CLASS_CATEGORY_DEMUXER = 4,
    @AV_CLASS_CATEGORY_ENCODER = 5,
    @AV_CLASS_CATEGORY_DECODER = 6,
    @AV_CLASS_CATEGORY_FILTER = 7,
    @AV_CLASS_CATEGORY_BITSTREAM_FILTER = 8,
    @AV_CLASS_CATEGORY_SWSCALER = 9,
    @AV_CLASS_CATEGORY_SWRESAMPLER = 10,
    @AV_CLASS_CATEGORY_HWDEVICE = 11,
    @AV_CLASS_CATEGORY_DEVICE_VIDEO_OUTPUT = 40,
    @AV_CLASS_CATEGORY_DEVICE_VIDEO_INPUT = 41,
    @AV_CLASS_CATEGORY_DEVICE_AUDIO_OUTPUT = 42,
    @AV_CLASS_CATEGORY_DEVICE_AUDIO_INPUT = 43,
    @AV_CLASS_CATEGORY_DEVICE_OUTPUT = 44,
    @AV_CLASS_CATEGORY_DEVICE_INPUT = 45,
    /// <summary>not part of ABI/API</summary>
    @AV_CLASS_CATEGORY_NB = 46,
}

public enum _AVClassStateFlags : int
{
    /// <summary>Object initialization has finished and it is now in the &apos;runtime&apos; stage. This affects e.g. what options can be set on the object (only AV_OPT_FLAG_RUNTIME_PARAM options can be set on initialized objects).</summary>
    @AV_CLASS_STATE_INITIALIZED = 1,
}

public enum _AVCodecConfig : int
{
    /// <summary>AVPixelFormat, terminated by AV_PIX_FMT_NONE</summary>
    @AV_CODEC_CONFIG_PIX_FORMAT = 0,
    /// <summary>AVRational, terminated by {0, 0}</summary>
    @AV_CODEC_CONFIG_FRAME_RATE = 1,
    /// <summary>int, terminated by 0</summary>
    @AV_CODEC_CONFIG_SAMPLE_RATE = 2,
    /// <summary>AVSampleFormat, terminated by AV_SAMPLE_FMT_NONE</summary>
    @AV_CODEC_CONFIG_SAMPLE_FORMAT = 3,
    /// <summary>AVChannelLayout, terminated by {0}</summary>
    @AV_CODEC_CONFIG_CHANNEL_LAYOUT = 4,
    /// <summary>AVColorRange, terminated by AVCOL_RANGE_UNSPECIFIED</summary>
    @AV_CODEC_CONFIG_COLOR_RANGE = 5,
    /// <summary>AVColorSpace, terminated by AVCOL_SPC_UNSPECIFIED</summary>
    @AV_CODEC_CONFIG_COLOR_SPACE = 6,
    /// <summary>AVAlphaMode, terminated by AVALPHA_MODE_UNSPECIFIED</summary>
    @AV_CODEC_CONFIG_ALPHA_MODE = 7,
}

/// <summary>Identify the syntax and semantics of the bitstream. The principle is roughly: Two decoders with the same ID can decode the same streams. Two encoders with the same ID can encode compatible streams. There may be slight deviations from the principle due to implementation details.</summary>
public enum _AVCodecID : int
{
    @AV_CODEC_ID_NONE = 0,
    @AV_CODEC_ID_MPEG1VIDEO = 1,
    /// <summary>preferred ID for MPEG-1/2 video decoding</summary>
    @AV_CODEC_ID_MPEG2VIDEO = 2,
    @AV_CODEC_ID_H261 = 3,
    @AV_CODEC_ID_H263 = 4,
    @AV_CODEC_ID_RV10 = 5,
    @AV_CODEC_ID_RV20 = 6,
    @AV_CODEC_ID_MJPEG = 7,
    @AV_CODEC_ID_MJPEGB = 8,
    @AV_CODEC_ID_LJPEG = 9,
    @AV_CODEC_ID_SP5X = 10,
    @AV_CODEC_ID_JPEGLS = 11,
    @AV_CODEC_ID_MPEG4 = 12,
    @AV_CODEC_ID_RAWVIDEO = 13,
    @AV_CODEC_ID_MSMPEG4V1 = 14,
    @AV_CODEC_ID_MSMPEG4V2 = 15,
    @AV_CODEC_ID_MSMPEG4V3 = 16,
    @AV_CODEC_ID_WMV1 = 17,
    @AV_CODEC_ID_WMV2 = 18,
    @AV_CODEC_ID_H263P = 19,
    @AV_CODEC_ID_H263I = 20,
    @AV_CODEC_ID_FLV1 = 21,
    @AV_CODEC_ID_SVQ1 = 22,
    @AV_CODEC_ID_SVQ3 = 23,
    @AV_CODEC_ID_DVVIDEO = 24,
    @AV_CODEC_ID_HUFFYUV = 25,
    @AV_CODEC_ID_CYUV = 26,
    @AV_CODEC_ID_H264 = 27,
    @AV_CODEC_ID_INDEO3 = 28,
    @AV_CODEC_ID_VP3 = 29,
    @AV_CODEC_ID_THEORA = 30,
    @AV_CODEC_ID_ASV1 = 31,
    @AV_CODEC_ID_ASV2 = 32,
    @AV_CODEC_ID_FFV1 = 33,
    @AV_CODEC_ID_4XM = 34,
    @AV_CODEC_ID_VCR1 = 35,
    @AV_CODEC_ID_CLJR = 36,
    @AV_CODEC_ID_MDEC = 37,
    @AV_CODEC_ID_ROQ = 38,
    @AV_CODEC_ID_INTERPLAY_VIDEO = 39,
    @AV_CODEC_ID_XAN_WC3 = 40,
    @AV_CODEC_ID_XAN_WC4 = 41,
    @AV_CODEC_ID_RPZA = 42,
    @AV_CODEC_ID_CINEPAK = 43,
    @AV_CODEC_ID_WS_VQA = 44,
    @AV_CODEC_ID_MSRLE = 45,
    @AV_CODEC_ID_MSVIDEO1 = 46,
    @AV_CODEC_ID_IDCIN = 47,
    @AV_CODEC_ID_8BPS = 48,
    @AV_CODEC_ID_SMC = 49,
    @AV_CODEC_ID_FLIC = 50,
    @AV_CODEC_ID_TRUEMOTION1 = 51,
    @AV_CODEC_ID_VMDVIDEO = 52,
    @AV_CODEC_ID_MSZH = 53,
    @AV_CODEC_ID_ZLIB = 54,
    @AV_CODEC_ID_QTRLE = 55,
    @AV_CODEC_ID_TSCC = 56,
    @AV_CODEC_ID_ULTI = 57,
    @AV_CODEC_ID_QDRAW = 58,
    @AV_CODEC_ID_VIXL = 59,
    @AV_CODEC_ID_QPEG = 60,
    @AV_CODEC_ID_PNG = 61,
    @AV_CODEC_ID_PPM = 62,
    @AV_CODEC_ID_PBM = 63,
    @AV_CODEC_ID_PGM = 64,
    @AV_CODEC_ID_PGMYUV = 65,
    @AV_CODEC_ID_PAM = 66,
    @AV_CODEC_ID_FFVHUFF = 67,
    @AV_CODEC_ID_RV30 = 68,
    @AV_CODEC_ID_RV40 = 69,
    @AV_CODEC_ID_VC1 = 70,
    @AV_CODEC_ID_WMV3 = 71,
    @AV_CODEC_ID_LOCO = 72,
    @AV_CODEC_ID_WNV1 = 73,
    @AV_CODEC_ID_AASC = 74,
    @AV_CODEC_ID_INDEO2 = 75,
    @AV_CODEC_ID_FRAPS = 76,
    @AV_CODEC_ID_TRUEMOTION2 = 77,
    @AV_CODEC_ID_BMP = 78,
    @AV_CODEC_ID_CSCD = 79,
    @AV_CODEC_ID_MMVIDEO = 80,
    @AV_CODEC_ID_ZMBV = 81,
    @AV_CODEC_ID_AVS = 82,
    @AV_CODEC_ID_SMACKVIDEO = 83,
    @AV_CODEC_ID_NUV = 84,
    @AV_CODEC_ID_KMVC = 85,
    @AV_CODEC_ID_FLASHSV = 86,
    @AV_CODEC_ID_CAVS = 87,
    @AV_CODEC_ID_JPEG2000 = 88,
    @AV_CODEC_ID_VMNC = 89,
    @AV_CODEC_ID_VP5 = 90,
    @AV_CODEC_ID_VP6 = 91,
    @AV_CODEC_ID_VP6F = 92,
    @AV_CODEC_ID_TARGA = 93,
    @AV_CODEC_ID_DSICINVIDEO = 94,
    @AV_CODEC_ID_TIERTEXSEQVIDEO = 95,
    @AV_CODEC_ID_TIFF = 96,
    @AV_CODEC_ID_GIF = 97,
    @AV_CODEC_ID_DXA = 98,
    @AV_CODEC_ID_DNXHD = 99,
    @AV_CODEC_ID_THP = 100,
    @AV_CODEC_ID_SGI = 101,
    @AV_CODEC_ID_C93 = 102,
    @AV_CODEC_ID_BETHSOFTVID = 103,
    @AV_CODEC_ID_PTX = 104,
    @AV_CODEC_ID_TXD = 105,
    @AV_CODEC_ID_VP6A = 106,
    @AV_CODEC_ID_AMV = 107,
    @AV_CODEC_ID_VB = 108,
    @AV_CODEC_ID_PCX = 109,
    @AV_CODEC_ID_SUNRAST = 110,
    @AV_CODEC_ID_INDEO4 = 111,
    @AV_CODEC_ID_INDEO5 = 112,
    @AV_CODEC_ID_MIMIC = 113,
    @AV_CODEC_ID_RL2 = 114,
    @AV_CODEC_ID_ESCAPE124 = 115,
    @AV_CODEC_ID_DIRAC = 116,
    @AV_CODEC_ID_BFI = 117,
    @AV_CODEC_ID_CMV = 118,
    @AV_CODEC_ID_MOTIONPIXELS = 119,
    @AV_CODEC_ID_TGV = 120,
    @AV_CODEC_ID_TGQ = 121,
    @AV_CODEC_ID_TQI = 122,
    @AV_CODEC_ID_AURA = 123,
    @AV_CODEC_ID_AURA2 = 124,
    @AV_CODEC_ID_V210X = 125,
    @AV_CODEC_ID_TMV = 126,
    @AV_CODEC_ID_V210 = 127,
    @AV_CODEC_ID_DPX = 128,
    @AV_CODEC_ID_MAD = 129,
    @AV_CODEC_ID_FRWU = 130,
    @AV_CODEC_ID_FLASHSV2 = 131,
    @AV_CODEC_ID_CDGRAPHICS = 132,
    @AV_CODEC_ID_R210 = 133,
    @AV_CODEC_ID_ANM = 134,
    @AV_CODEC_ID_BINKVIDEO = 135,
    @AV_CODEC_ID_IFF_ILBM = 136,
    @AV_CODEC_ID_KGV1 = 137,
    @AV_CODEC_ID_YOP = 138,
    @AV_CODEC_ID_VP8 = 139,
    @AV_CODEC_ID_PICTOR = 140,
    @AV_CODEC_ID_ANSI = 141,
    @AV_CODEC_ID_A64_MULTI = 142,
    @AV_CODEC_ID_A64_MULTI5 = 143,
    @AV_CODEC_ID_R10K = 144,
    @AV_CODEC_ID_MXPEG = 145,
    @AV_CODEC_ID_LAGARITH = 146,
    @AV_CODEC_ID_PRORES = 147,
    @AV_CODEC_ID_JV = 148,
    @AV_CODEC_ID_DFA = 149,
    @AV_CODEC_ID_WMV3IMAGE = 150,
    @AV_CODEC_ID_VC1IMAGE = 151,
    @AV_CODEC_ID_UTVIDEO = 152,
    @AV_CODEC_ID_BMV_VIDEO = 153,
    @AV_CODEC_ID_VBLE = 154,
    @AV_CODEC_ID_DXTORY = 155,
    @AV_CODEC_ID_XWD = 156,
    @AV_CODEC_ID_CDXL = 157,
    @AV_CODEC_ID_XBM = 158,
    @AV_CODEC_ID_ZEROCODEC = 159,
    @AV_CODEC_ID_MSS1 = 160,
    @AV_CODEC_ID_MSA1 = 161,
    @AV_CODEC_ID_TSCC2 = 162,
    @AV_CODEC_ID_MTS2 = 163,
    @AV_CODEC_ID_CLLC = 164,
    @AV_CODEC_ID_MSS2 = 165,
    @AV_CODEC_ID_VP9 = 166,
    @AV_CODEC_ID_AIC = 167,
    @AV_CODEC_ID_ESCAPE130 = 168,
    @AV_CODEC_ID_G2M = 169,
    @AV_CODEC_ID_WEBP = 170,
    @AV_CODEC_ID_HNM4_VIDEO = 171,
    @AV_CODEC_ID_HEVC = 172,
    @AV_CODEC_ID_FIC = 173,
    @AV_CODEC_ID_ALIAS_PIX = 174,
    @AV_CODEC_ID_BRENDER_PIX = 175,
    @AV_CODEC_ID_PAF_VIDEO = 176,
    @AV_CODEC_ID_EXR = 177,
    @AV_CODEC_ID_VP7 = 178,
    @AV_CODEC_ID_SANM = 179,
    @AV_CODEC_ID_SGIRLE = 180,
    @AV_CODEC_ID_MVC1 = 181,
    @AV_CODEC_ID_MVC2 = 182,
    @AV_CODEC_ID_HQX = 183,
    @AV_CODEC_ID_TDSC = 184,
    @AV_CODEC_ID_HQ_HQA = 185,
    @AV_CODEC_ID_HAP = 186,
    @AV_CODEC_ID_DDS = 187,
    @AV_CODEC_ID_DXV = 188,
    @AV_CODEC_ID_SCREENPRESSO = 189,
    @AV_CODEC_ID_RSCC = 190,
    @AV_CODEC_ID_AVS2 = 191,
    @AV_CODEC_ID_PGX = 192,
    @AV_CODEC_ID_AVS3 = 193,
    @AV_CODEC_ID_MSP2 = 194,
    @AV_CODEC_ID_VVC = 195,
    @AV_CODEC_ID_Y41P = 196,
    @AV_CODEC_ID_AVRP = 197,
    @AV_CODEC_ID_012V = 198,
    @AV_CODEC_ID_AVUI = 199,
    @AV_CODEC_ID_TARGA_Y216 = 200,
    @AV_CODEC_ID_YUV4 = 201,
    @AV_CODEC_ID_AVRN = 202,
    @AV_CODEC_ID_CPIA = 203,
    @AV_CODEC_ID_XFACE = 204,
    @AV_CODEC_ID_SNOW = 205,
    @AV_CODEC_ID_SMVJPEG = 206,
    @AV_CODEC_ID_APNG = 207,
    @AV_CODEC_ID_DAALA = 208,
    @AV_CODEC_ID_CFHD = 209,
    @AV_CODEC_ID_TRUEMOTION2RT = 210,
    @AV_CODEC_ID_M101 = 211,
    @AV_CODEC_ID_MAGICYUV = 212,
    @AV_CODEC_ID_SHEERVIDEO = 213,
    @AV_CODEC_ID_YLC = 214,
    @AV_CODEC_ID_PSD = 215,
    @AV_CODEC_ID_PIXLET = 216,
    @AV_CODEC_ID_SPEEDHQ = 217,
    @AV_CODEC_ID_FMVC = 218,
    @AV_CODEC_ID_SCPR = 219,
    @AV_CODEC_ID_CLEARVIDEO = 220,
    @AV_CODEC_ID_XPM = 221,
    @AV_CODEC_ID_AV1 = 222,
    @AV_CODEC_ID_BITPACKED = 223,
    @AV_CODEC_ID_MSCC = 224,
    @AV_CODEC_ID_SRGC = 225,
    @AV_CODEC_ID_SVG = 226,
    @AV_CODEC_ID_GDV = 227,
    @AV_CODEC_ID_FITS = 228,
    @AV_CODEC_ID_IMM4 = 229,
    @AV_CODEC_ID_PROSUMER = 230,
    @AV_CODEC_ID_MWSC = 231,
    @AV_CODEC_ID_WCMV = 232,
    @AV_CODEC_ID_RASC = 233,
    @AV_CODEC_ID_HYMT = 234,
    @AV_CODEC_ID_ARBC = 235,
    @AV_CODEC_ID_AGM = 236,
    @AV_CODEC_ID_LSCR = 237,
    @AV_CODEC_ID_VP4 = 238,
    @AV_CODEC_ID_IMM5 = 239,
    @AV_CODEC_ID_MVDV = 240,
    @AV_CODEC_ID_MVHA = 241,
    @AV_CODEC_ID_CDTOONS = 242,
    @AV_CODEC_ID_MV30 = 243,
    @AV_CODEC_ID_NOTCHLC = 244,
    @AV_CODEC_ID_PFM = 245,
    @AV_CODEC_ID_MOBICLIP = 246,
    @AV_CODEC_ID_PHOTOCD = 247,
    @AV_CODEC_ID_IPU = 248,
    @AV_CODEC_ID_ARGO = 249,
    @AV_CODEC_ID_CRI = 250,
    @AV_CODEC_ID_SIMBIOSIS_IMX = 251,
    @AV_CODEC_ID_SGA_VIDEO = 252,
    @AV_CODEC_ID_GEM = 253,
    @AV_CODEC_ID_VBN = 254,
    @AV_CODEC_ID_JPEGXL = 255,
    @AV_CODEC_ID_QOI = 256,
    @AV_CODEC_ID_PHM = 257,
    @AV_CODEC_ID_RADIANCE_HDR = 258,
    @AV_CODEC_ID_WBMP = 259,
    @AV_CODEC_ID_MEDIA100 = 260,
    @AV_CODEC_ID_VQC = 261,
    @AV_CODEC_ID_PDV = 262,
    @AV_CODEC_ID_EVC = 263,
    @AV_CODEC_ID_RTV1 = 264,
    @AV_CODEC_ID_VMIX = 265,
    @AV_CODEC_ID_LEAD = 266,
    @AV_CODEC_ID_DNXUC = 267,
    @AV_CODEC_ID_RV60 = 268,
    @AV_CODEC_ID_JPEGXL_ANIM = 269,
    @AV_CODEC_ID_APV = 270,
    @AV_CODEC_ID_PRORES_RAW = 271,
    @AV_CODEC_ID_JPEGXS = 272,
    @AV_CODEC_ID_WEBP_ANIM = 273,
    /// <summary>A dummy id pointing at the start of audio codecs</summary>
    @AV_CODEC_ID_FIRST_AUDIO = 65536,
    @AV_CODEC_ID_PCM_S16LE = 65536,
    @AV_CODEC_ID_PCM_S16BE = 65537,
    @AV_CODEC_ID_PCM_U16LE = 65538,
    @AV_CODEC_ID_PCM_U16BE = 65539,
    @AV_CODEC_ID_PCM_S8 = 65540,
    @AV_CODEC_ID_PCM_U8 = 65541,
    @AV_CODEC_ID_PCM_MULAW = 65542,
    @AV_CODEC_ID_PCM_ALAW = 65543,
    @AV_CODEC_ID_PCM_S32LE = 65544,
    @AV_CODEC_ID_PCM_S32BE = 65545,
    @AV_CODEC_ID_PCM_U32LE = 65546,
    @AV_CODEC_ID_PCM_U32BE = 65547,
    @AV_CODEC_ID_PCM_S24LE = 65548,
    @AV_CODEC_ID_PCM_S24BE = 65549,
    @AV_CODEC_ID_PCM_U24LE = 65550,
    @AV_CODEC_ID_PCM_U24BE = 65551,
    @AV_CODEC_ID_PCM_S24DAUD = 65552,
    @AV_CODEC_ID_PCM_ZORK = 65553,
    @AV_CODEC_ID_PCM_S16LE_PLANAR = 65554,
    @AV_CODEC_ID_PCM_DVD = 65555,
    @AV_CODEC_ID_PCM_F32BE = 65556,
    @AV_CODEC_ID_PCM_F32LE = 65557,
    @AV_CODEC_ID_PCM_F64BE = 65558,
    @AV_CODEC_ID_PCM_F64LE = 65559,
    @AV_CODEC_ID_PCM_BLURAY = 65560,
    @AV_CODEC_ID_PCM_LXF = 65561,
    @AV_CODEC_ID_S302M = 65562,
    @AV_CODEC_ID_PCM_S8_PLANAR = 65563,
    @AV_CODEC_ID_PCM_S24LE_PLANAR = 65564,
    @AV_CODEC_ID_PCM_S32LE_PLANAR = 65565,
    @AV_CODEC_ID_PCM_S16BE_PLANAR = 65566,
    @AV_CODEC_ID_PCM_S64LE = 65567,
    @AV_CODEC_ID_PCM_S64BE = 65568,
    @AV_CODEC_ID_PCM_F16LE = 65569,
    @AV_CODEC_ID_PCM_F24LE = 65570,
    @AV_CODEC_ID_PCM_VIDC = 65571,
    @AV_CODEC_ID_PCM_SGA = 65572,
    @AV_CODEC_ID_ADPCM_IMA_QT = 69632,
    @AV_CODEC_ID_ADPCM_IMA_WAV = 69633,
    @AV_CODEC_ID_ADPCM_IMA_DK3 = 69634,
    @AV_CODEC_ID_ADPCM_IMA_DK4 = 69635,
    @AV_CODEC_ID_ADPCM_IMA_WS = 69636,
    @AV_CODEC_ID_ADPCM_IMA_SMJPEG = 69637,
    @AV_CODEC_ID_ADPCM_MS = 69638,
    @AV_CODEC_ID_ADPCM_4XM = 69639,
    @AV_CODEC_ID_ADPCM_XA = 69640,
    @AV_CODEC_ID_ADPCM_ADX = 69641,
    @AV_CODEC_ID_ADPCM_EA = 69642,
    @AV_CODEC_ID_ADPCM_G726 = 69643,
    @AV_CODEC_ID_ADPCM_CT = 69644,
    @AV_CODEC_ID_ADPCM_SWF = 69645,
    @AV_CODEC_ID_ADPCM_YAMAHA = 69646,
    @AV_CODEC_ID_ADPCM_SBPRO_4 = 69647,
    @AV_CODEC_ID_ADPCM_SBPRO_3 = 69648,
    @AV_CODEC_ID_ADPCM_SBPRO_2 = 69649,
    @AV_CODEC_ID_ADPCM_THP = 69650,
    @AV_CODEC_ID_ADPCM_IMA_AMV = 69651,
    @AV_CODEC_ID_ADPCM_EA_R1 = 69652,
    @AV_CODEC_ID_ADPCM_EA_R3 = 69653,
    @AV_CODEC_ID_ADPCM_EA_R2 = 69654,
    @AV_CODEC_ID_ADPCM_IMA_EA_SEAD = 69655,
    @AV_CODEC_ID_ADPCM_IMA_EA_EACS = 69656,
    @AV_CODEC_ID_ADPCM_EA_XAS = 69657,
    @AV_CODEC_ID_ADPCM_EA_MAXIS_XA = 69658,
    @AV_CODEC_ID_ADPCM_IMA_ISS = 69659,
    @AV_CODEC_ID_ADPCM_G722 = 69660,
    @AV_CODEC_ID_ADPCM_IMA_APC = 69661,
    @AV_CODEC_ID_ADPCM_VIMA = 69662,
    @AV_CODEC_ID_ADPCM_AFC = 69663,
    @AV_CODEC_ID_ADPCM_IMA_OKI = 69664,
    @AV_CODEC_ID_ADPCM_DTK = 69665,
    @AV_CODEC_ID_ADPCM_IMA_RAD = 69666,
    @AV_CODEC_ID_ADPCM_G726LE = 69667,
    @AV_CODEC_ID_ADPCM_THP_LE = 69668,
    @AV_CODEC_ID_ADPCM_PSX = 69669,
    @AV_CODEC_ID_ADPCM_AICA = 69670,
    @AV_CODEC_ID_ADPCM_IMA_DAT4 = 69671,
    @AV_CODEC_ID_ADPCM_MTAF = 69672,
    @AV_CODEC_ID_ADPCM_AGM = 69673,
    @AV_CODEC_ID_ADPCM_ARGO = 69674,
    @AV_CODEC_ID_ADPCM_IMA_SSI = 69675,
    @AV_CODEC_ID_ADPCM_ZORK = 69676,
    @AV_CODEC_ID_ADPCM_IMA_APM = 69677,
    @AV_CODEC_ID_ADPCM_IMA_ALP = 69678,
    @AV_CODEC_ID_ADPCM_IMA_MTF = 69679,
    @AV_CODEC_ID_ADPCM_IMA_CUNNING = 69680,
    @AV_CODEC_ID_ADPCM_IMA_MOFLEX = 69681,
    @AV_CODEC_ID_ADPCM_IMA_ACORN = 69682,
    @AV_CODEC_ID_ADPCM_XMD = 69683,
    @AV_CODEC_ID_ADPCM_IMA_XBOX = 69684,
    @AV_CODEC_ID_ADPCM_SANYO = 69685,
    @AV_CODEC_ID_ADPCM_IMA_HVQM4 = 69686,
    @AV_CODEC_ID_ADPCM_IMA_PDA = 69687,
    @AV_CODEC_ID_ADPCM_N64 = 69688,
    @AV_CODEC_ID_ADPCM_IMA_HVQM2 = 69689,
    @AV_CODEC_ID_ADPCM_IMA_MAGIX = 69690,
    @AV_CODEC_ID_ADPCM_PSXC = 69691,
    @AV_CODEC_ID_ADPCM_CIRCUS = 69692,
    @AV_CODEC_ID_ADPCM_IMA_ESCAPE = 69693,
    @AV_CODEC_ID_AMR_NB = 73728,
    @AV_CODEC_ID_AMR_WB = 73729,
    @AV_CODEC_ID_RA_144 = 77824,
    @AV_CODEC_ID_RA_288 = 77825,
    @AV_CODEC_ID_ROQ_DPCM = 81920,
    @AV_CODEC_ID_INTERPLAY_DPCM = 81921,
    @AV_CODEC_ID_XAN_DPCM = 81922,
    @AV_CODEC_ID_SOL_DPCM = 81923,
    @AV_CODEC_ID_SDX2_DPCM = 81924,
    @AV_CODEC_ID_GREMLIN_DPCM = 81925,
    @AV_CODEC_ID_DERF_DPCM = 81926,
    @AV_CODEC_ID_WADY_DPCM = 81927,
    @AV_CODEC_ID_CBD2_DPCM = 81928,
    @AV_CODEC_ID_MP2 = 86016,
    /// <summary>preferred ID for decoding MPEG audio layer 1, 2 or 3</summary>
    @AV_CODEC_ID_MP3 = 86017,
    @AV_CODEC_ID_AAC = 86018,
    @AV_CODEC_ID_AC3 = 86019,
    @AV_CODEC_ID_DTS = 86020,
    @AV_CODEC_ID_VORBIS = 86021,
    @AV_CODEC_ID_DVAUDIO = 86022,
    @AV_CODEC_ID_WMAV1 = 86023,
    @AV_CODEC_ID_WMAV2 = 86024,
    @AV_CODEC_ID_MACE3 = 86025,
    @AV_CODEC_ID_MACE6 = 86026,
    @AV_CODEC_ID_VMDAUDIO = 86027,
    @AV_CODEC_ID_FLAC = 86028,
    @AV_CODEC_ID_MP3ADU = 86029,
    @AV_CODEC_ID_MP3ON4 = 86030,
    @AV_CODEC_ID_SHORTEN = 86031,
    @AV_CODEC_ID_ALAC = 86032,
    @AV_CODEC_ID_WESTWOOD_SND1 = 86033,
    /// <summary>as in Berlin toast format</summary>
    @AV_CODEC_ID_GSM = 86034,
    @AV_CODEC_ID_QDM2 = 86035,
    @AV_CODEC_ID_COOK = 86036,
    @AV_CODEC_ID_TRUESPEECH = 86037,
    @AV_CODEC_ID_TTA = 86038,
    @AV_CODEC_ID_SMACKAUDIO = 86039,
    @AV_CODEC_ID_QCELP = 86040,
    @AV_CODEC_ID_WAVPACK = 86041,
    @AV_CODEC_ID_DSICINAUDIO = 86042,
    @AV_CODEC_ID_IMC = 86043,
    @AV_CODEC_ID_MUSEPACK7 = 86044,
    @AV_CODEC_ID_MLP = 86045,
    @AV_CODEC_ID_GSM_MS = 86046,
    @AV_CODEC_ID_ATRAC3 = 86047,
    @AV_CODEC_ID_APE = 86048,
    @AV_CODEC_ID_NELLYMOSER = 86049,
    @AV_CODEC_ID_MUSEPACK8 = 86050,
    @AV_CODEC_ID_SPEEX = 86051,
    @AV_CODEC_ID_WMAVOICE = 86052,
    @AV_CODEC_ID_WMAPRO = 86053,
    @AV_CODEC_ID_WMALOSSLESS = 86054,
    @AV_CODEC_ID_ATRAC3P = 86055,
    @AV_CODEC_ID_EAC3 = 86056,
    @AV_CODEC_ID_SIPR = 86057,
    @AV_CODEC_ID_MP1 = 86058,
    @AV_CODEC_ID_TWINVQ = 86059,
    @AV_CODEC_ID_TRUEHD = 86060,
    @AV_CODEC_ID_MP4ALS = 86061,
    @AV_CODEC_ID_ATRAC1 = 86062,
    @AV_CODEC_ID_BINKAUDIO_RDFT = 86063,
    @AV_CODEC_ID_BINKAUDIO_DCT = 86064,
    @AV_CODEC_ID_AAC_LATM = 86065,
    @AV_CODEC_ID_QDMC = 86066,
    @AV_CODEC_ID_CELT = 86067,
    @AV_CODEC_ID_G723_1 = 86068,
    @AV_CODEC_ID_G729 = 86069,
    @AV_CODEC_ID_8SVX_EXP = 86070,
    @AV_CODEC_ID_8SVX_FIB = 86071,
    @AV_CODEC_ID_BMV_AUDIO = 86072,
    @AV_CODEC_ID_RALF = 86073,
    @AV_CODEC_ID_IAC = 86074,
    @AV_CODEC_ID_ILBC = 86075,
    @AV_CODEC_ID_OPUS = 86076,
    @AV_CODEC_ID_COMFORT_NOISE = 86077,
    @AV_CODEC_ID_TAK = 86078,
    @AV_CODEC_ID_METASOUND = 86079,
    @AV_CODEC_ID_PAF_AUDIO = 86080,
    @AV_CODEC_ID_ON2AVC = 86081,
    @AV_CODEC_ID_DSS_SP = 86082,
    @AV_CODEC_ID_CODEC2 = 86083,
    @AV_CODEC_ID_FFWAVESYNTH = 86084,
    @AV_CODEC_ID_SONIC = 86085,
    @AV_CODEC_ID_SONIC_LS = 86086,
    @AV_CODEC_ID_EVRC = 86087,
    @AV_CODEC_ID_SMV = 86088,
    @AV_CODEC_ID_DSD_LSBF = 86089,
    @AV_CODEC_ID_DSD_MSBF = 86090,
    @AV_CODEC_ID_DSD_LSBF_PLANAR = 86091,
    @AV_CODEC_ID_DSD_MSBF_PLANAR = 86092,
    @AV_CODEC_ID_4GV = 86093,
    @AV_CODEC_ID_INTERPLAY_ACM = 86094,
    @AV_CODEC_ID_XMA1 = 86095,
    @AV_CODEC_ID_XMA2 = 86096,
    @AV_CODEC_ID_DST = 86097,
    @AV_CODEC_ID_ATRAC3AL = 86098,
    @AV_CODEC_ID_ATRAC3PAL = 86099,
    @AV_CODEC_ID_DOLBY_E = 86100,
    @AV_CODEC_ID_APTX = 86101,
    @AV_CODEC_ID_APTX_HD = 86102,
    @AV_CODEC_ID_SBC = 86103,
    @AV_CODEC_ID_ATRAC9 = 86104,
    @AV_CODEC_ID_HCOM = 86105,
    @AV_CODEC_ID_ACELP_KELVIN = 86106,
    @AV_CODEC_ID_MPEGH_3D_AUDIO = 86107,
    @AV_CODEC_ID_SIREN = 86108,
    @AV_CODEC_ID_HCA = 86109,
    @AV_CODEC_ID_FASTAUDIO = 86110,
    @AV_CODEC_ID_MSNSIREN = 86111,
    @AV_CODEC_ID_DFPWM = 86112,
    @AV_CODEC_ID_BONK = 86113,
    @AV_CODEC_ID_MISC4 = 86114,
    @AV_CODEC_ID_APAC = 86115,
    @AV_CODEC_ID_FTR = 86116,
    @AV_CODEC_ID_WAVARC = 86117,
    @AV_CODEC_ID_RKA = 86118,
    @AV_CODEC_ID_AC4 = 86119,
    @AV_CODEC_ID_OSQ = 86120,
    @AV_CODEC_ID_QOA = 86121,
    @AV_CODEC_ID_LC3 = 86122,
    @AV_CODEC_ID_G728 = 86123,
    @AV_CODEC_ID_AHX = 86124,
    @AV_CODEC_ID_APPLE_APAC = 86125,
    /// <summary>A dummy ID pointing at the start of subtitle codecs.</summary>
    @AV_CODEC_ID_FIRST_SUBTITLE = 94208,
    @AV_CODEC_ID_DVD_SUBTITLE = 94208,
    @AV_CODEC_ID_DVB_SUBTITLE = 94209,
    /// <summary>raw UTF-8 text</summary>
    @AV_CODEC_ID_TEXT = 94210,
    @AV_CODEC_ID_XSUB = 94211,
    @AV_CODEC_ID_SSA = 94212,
    @AV_CODEC_ID_MOV_TEXT = 94213,
    @AV_CODEC_ID_HDMV_PGS_SUBTITLE = 94214,
    @AV_CODEC_ID_DVB_TELETEXT = 94215,
    @AV_CODEC_ID_SRT = 94216,
    @AV_CODEC_ID_MICRODVD = 94217,
    @AV_CODEC_ID_EIA_608 = 94218,
    @AV_CODEC_ID_JACOSUB = 94219,
    @AV_CODEC_ID_SAMI = 94220,
    @AV_CODEC_ID_REALTEXT = 94221,
    @AV_CODEC_ID_STL = 94222,
    @AV_CODEC_ID_SUBVIEWER1 = 94223,
    @AV_CODEC_ID_SUBVIEWER = 94224,
    @AV_CODEC_ID_SUBRIP = 94225,
    @AV_CODEC_ID_WEBVTT = 94226,
    @AV_CODEC_ID_MPL2 = 94227,
    @AV_CODEC_ID_VPLAYER = 94228,
    @AV_CODEC_ID_PJS = 94229,
    @AV_CODEC_ID_ASS = 94230,
    @AV_CODEC_ID_HDMV_TEXT_SUBTITLE = 94231,
    @AV_CODEC_ID_TTML = 94232,
    @AV_CODEC_ID_ARIB_CAPTION = 94233,
    @AV_CODEC_ID_IVTV_VBI = 94234,
    /// <summary>A dummy ID pointing at the start of various fake codecs.</summary>
    @AV_CODEC_ID_FIRST_UNKNOWN = 98304,
    @AV_CODEC_ID_TTF = 98304,
    /// <summary>Contain timestamp estimated through PCR of program stream.</summary>
    @AV_CODEC_ID_SCTE_35 = 98305,
    @AV_CODEC_ID_EPG = 98306,
    @AV_CODEC_ID_BINTEXT = 98307,
    @AV_CODEC_ID_XBIN = 98308,
    @AV_CODEC_ID_IDF = 98309,
    @AV_CODEC_ID_OTF = 98310,
    @AV_CODEC_ID_SMPTE_KLV = 98311,
    @AV_CODEC_ID_DVD_NAV = 98312,
    @AV_CODEC_ID_TIMED_ID3 = 98313,
    @AV_CODEC_ID_BIN_DATA = 98314,
    @AV_CODEC_ID_SMPTE_2038 = 98315,
    @AV_CODEC_ID_LCEVC = 98316,
    @AV_CODEC_ID_SMPTE_436M_ANC = 98317,
    /// <summary>codec_id is not known (like AV_CODEC_ID_NONE) but lavf should attempt to identify it</summary>
    @AV_CODEC_ID_PROBE = 102400,
    /// <summary>_FAKE_ codec to indicate a raw MPEG-2 TS stream (only used by libavformat)</summary>
    @AV_CODEC_ID_MPEG2TS = 131072,
    /// <summary>_FAKE_ codec to indicate a MPEG-4 Systems stream (only used by libavformat)</summary>
    @AV_CODEC_ID_MPEG4SYSTEMS = 131073,
    /// <summary>Dummy codec for streams containing only metadata information.</summary>
    @AV_CODEC_ID_FFMETADATA = 135168,
    /// <summary>Passthrough codec, AVFrames wrapped in AVPacket</summary>
    @AV_CODEC_ID_WRAPPED_AVFRAME = 135169,
    /// <summary>Dummy null video codec, useful mainly for development and debugging. Null encoder/decoder discard all input and never return any output.</summary>
    @AV_CODEC_ID_VNULL = 135170,
    /// <summary>Dummy null audio codec, useful mainly for development and debugging. Null encoder/decoder discard all input and never return any output.</summary>
    @AV_CODEC_ID_ANULL = 135171,
}

/// <summary>Chromaticity coordinates of the source primaries. These values match the ones defined by ISO/IEC 23091-2_2019 subclause 8.1 and ITU-T H.273.</summary>
public enum _AVColorPrimaries : int
{
    @AVCOL_PRI_RESERVED0 = 0,
    /// <summary>also ITU-R BT1361 / IEC 61966-2-4 / SMPTE RP 177 Annex B</summary>
    @AVCOL_PRI_BT709 = 1,
    @AVCOL_PRI_UNSPECIFIED = 2,
    @AVCOL_PRI_RESERVED = 3,
    /// <summary>also FCC Title 47 Code of Federal Regulations 73.682 (a)(20)</summary>
    @AVCOL_PRI_BT470M = 4,
    /// <summary>also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL &amp; SECAM</summary>
    @AVCOL_PRI_BT470BG = 5,
    /// <summary>also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC</summary>
    @AVCOL_PRI_SMPTE170M = 6,
    /// <summary>identical to above, also called &quot;SMPTE C&quot; even though it uses D65</summary>
    @AVCOL_PRI_SMPTE240M = 7,
    /// <summary>colour filters using Illuminant C</summary>
    @AVCOL_PRI_FILM = 8,
    /// <summary>ITU-R BT2020</summary>
    @AVCOL_PRI_BT2020 = 9,
    /// <summary>SMPTE ST 428-1 (CIE 1931 XYZ)</summary>
    @AVCOL_PRI_SMPTE428 = 10,
    @AVCOL_PRI_SMPTEST428_1 = 10,
    /// <summary>SMPTE ST 431-2 (2011) / DCI P3</summary>
    @AVCOL_PRI_SMPTE431 = 11,
    /// <summary>SMPTE ST 432-1 (2010) / P3 D65 / Display P3</summary>
    @AVCOL_PRI_SMPTE432 = 12,
    /// <summary>EBU Tech. 3213-E (nothing there) / one of JEDEC P22 group phosphors</summary>
    @AVCOL_PRI_EBU3213 = 22,
    @AVCOL_PRI_JEDEC_P22 = 22,
    /// <summary>Not part of ABI</summary>
    @AVCOL_PRI_NB = 23,
    @AVCOL_PRI_EXT_BASE = 256,
    @AVCOL_PRI_V_GAMUT = 256,
    /// <summary>Not part of ABI</summary>
    @AVCOL_PRI_EXT_NB = 257,
}

/// <summary>Visual content value range.</summary>
public enum _AVColorRange : int
{
    @AVCOL_RANGE_UNSPECIFIED = 0,
    /// <summary>Narrow or limited range content.</summary>
    @AVCOL_RANGE_MPEG = 1,
    /// <summary>Full range content.</summary>
    @AVCOL_RANGE_JPEG = 2,
    /// <summary>Not part of ABI</summary>
    @AVCOL_RANGE_NB = 3,
}

/// <summary>YUV colorspace type. These values match the ones defined by ISO/IEC 23091-2_2019 subclause 8.3.</summary>
public enum _AVColorSpace : int
{
    /// <summary>order of coefficients is actually GBR, also IEC 61966-2-1 (sRGB), YZX and ST 428-1</summary>
    @AVCOL_SPC_RGB = 0,
    /// <summary>also ITU-R BT1361 / IEC 61966-2-4 xvYCC709 / derived in SMPTE RP 177 Annex B</summary>
    @AVCOL_SPC_BT709 = 1,
    @AVCOL_SPC_UNSPECIFIED = 2,
    /// <summary>reserved for future use by ITU-T and ISO/IEC just like 15-255 are</summary>
    @AVCOL_SPC_RESERVED = 3,
    /// <summary>FCC Title 47 Code of Federal Regulations 73.682 (a)(20)</summary>
    @AVCOL_SPC_FCC = 4,
    /// <summary>also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL &amp; SECAM / IEC 61966-2-4 xvYCC601</summary>
    @AVCOL_SPC_BT470BG = 5,
    /// <summary>also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC / functionally identical to above</summary>
    @AVCOL_SPC_SMPTE170M = 6,
    /// <summary>derived from 170M primaries and D65 white point, 170M is derived from BT470 System M&apos;s primaries</summary>
    @AVCOL_SPC_SMPTE240M = 7,
    /// <summary>used by Dirac / VC-2 and H.264 FRext, see ITU-T SG16</summary>
    @AVCOL_SPC_YCGCO = 8,
    @AVCOL_SPC_YCOCG = 8,
    /// <summary>ITU-R BT2020 non-constant luminance system</summary>
    @AVCOL_SPC_BT2020_NCL = 9,
    /// <summary>ITU-R BT2020 constant luminance system</summary>
    @AVCOL_SPC_BT2020_CL = 10,
    /// <summary>SMPTE 2085, Y&apos;D&apos;zD&apos;x</summary>
    @AVCOL_SPC_SMPTE2085 = 11,
    /// <summary>Chromaticity-derived non-constant luminance system</summary>
    @AVCOL_SPC_CHROMA_DERIVED_NCL = 12,
    /// <summary>Chromaticity-derived constant luminance system</summary>
    @AVCOL_SPC_CHROMA_DERIVED_CL = 13,
    /// <summary>ITU-R BT.2100-0, ICtCp</summary>
    @AVCOL_SPC_ICTCP = 14,
    /// <summary>SMPTE ST 2128, IPT-C2</summary>
    @AVCOL_SPC_IPT_C2 = 15,
    /// <summary>YCgCo-R, even addition of bits</summary>
    @AVCOL_SPC_YCGCO_RE = 16,
    /// <summary>YCgCo-R, odd addition of bits</summary>
    @AVCOL_SPC_YCGCO_RO = 17,
    /// <summary>Not part of ABI</summary>
    @AVCOL_SPC_NB = 18,
}

/// <summary>Color Transfer Characteristic. These values match the ones defined by ISO/IEC 23091-2_2019 subclause 8.2.</summary>
public enum _AVColorTransferCharacteristic : int
{
    @AVCOL_TRC_RESERVED0 = 0,
    /// <summary>also ITU-R BT1361</summary>
    @AVCOL_TRC_BT709 = 1,
    @AVCOL_TRC_UNSPECIFIED = 2,
    @AVCOL_TRC_RESERVED = 3,
    /// <summary>also ITU-R BT470M / ITU-R BT1700 625 PAL &amp; SECAM</summary>
    @AVCOL_TRC_GAMMA22 = 4,
    /// <summary>also ITU-R BT470BG</summary>
    @AVCOL_TRC_GAMMA28 = 5,
    /// <summary>also ITU-R BT601-6 525 or 625 / ITU-R BT1358 525 or 625 / ITU-R BT1700 NTSC</summary>
    @AVCOL_TRC_SMPTE170M = 6,
    @AVCOL_TRC_SMPTE240M = 7,
    /// <summary>&quot;Linear transfer characteristics&quot;</summary>
    @AVCOL_TRC_LINEAR = 8,
    /// <summary>&quot;Logarithmic transfer characteristic (100:1 range)&quot;</summary>
    @AVCOL_TRC_LOG = 9,
    /// <summary>&quot;Logarithmic transfer characteristic (100 * Sqrt(10) : 1 range)&quot;</summary>
    @AVCOL_TRC_LOG_SQRT = 10,
    /// <summary>IEC 61966-2-4</summary>
    @AVCOL_TRC_IEC61966_2_4 = 11,
    /// <summary>ITU-R BT1361 Extended Colour Gamut</summary>
    @AVCOL_TRC_BT1361_ECG = 12,
    /// <summary>IEC 61966-2-1 (sRGB or sYCC)</summary>
    @AVCOL_TRC_IEC61966_2_1 = 13,
    /// <summary>ITU-R BT2020 for 10-bit system</summary>
    @AVCOL_TRC_BT2020_10 = 14,
    /// <summary>ITU-R BT2020 for 12-bit system</summary>
    @AVCOL_TRC_BT2020_12 = 15,
    /// <summary>SMPTE ST 2084 for 10-, 12-, 14- and 16-bit systems</summary>
    @AVCOL_TRC_SMPTE2084 = 16,
    @AVCOL_TRC_SMPTEST2084 = 16,
    /// <summary>SMPTE ST 428-1</summary>
    @AVCOL_TRC_SMPTE428 = 17,
    @AVCOL_TRC_SMPTEST428_1 = 17,
    /// <summary>ARIB STD-B67, known as &quot;Hybrid log-gamma&quot;</summary>
    @AVCOL_TRC_ARIB_STD_B67 = 18,
    /// <summary>Not part of ABI</summary>
    @AVCOL_TRC_NB = 19,
    @AVCOL_TRC_EXT_BASE = 256,
    @AVCOL_TRC_V_LOG = 256,
    /// <summary>Not part of ABI</summary>
    @AVCOL_TRC_EXT_NB = 257,
}

/// <summary>Define the behaviours of frame allocation.</summary>
public enum _AVD3D12VAFrameFlags : int
{
    @AV_D3D12VA_FRAME_FLAG_NONE = 0,
    /// <summary>Indicates that frame data should be allocated using a texture array resource.</summary>
    @AV_D3D12VA_FRAME_FLAG_TEXTURE_ARRAY = 2,
}

/// <summary>Message types used by avdevice_dev_to_app_control_message().</summary>
public enum _AVDevToAppMessageType : int
{
    /// <summary>Dummy message.</summary>
    @AV_DEV_TO_APP_NONE = 1313820229,
    /// <summary>Create window buffer message.</summary>
    @AV_DEV_TO_APP_CREATE_WINDOW_BUFFER = 1111708229,
    /// <summary>Prepare window buffer message.</summary>
    @AV_DEV_TO_APP_PREPARE_WINDOW_BUFFER = 1112560197,
    /// <summary>Display window buffer message.</summary>
    @AV_DEV_TO_APP_DISPLAY_WINDOW_BUFFER = 1111771475,
    /// <summary>Destroy window buffer message.</summary>
    @AV_DEV_TO_APP_DESTROY_WINDOW_BUFFER = 1111770451,
    /// <summary>Buffer fullness status messages.</summary>
    @AV_DEV_TO_APP_BUFFER_OVERFLOW = 1112491596,
    /// <summary>Buffer fullness status messages.</summary>
    @AV_DEV_TO_APP_BUFFER_UNDERFLOW = 1112884812,
    /// <summary>Buffer readable/writable.</summary>
    @AV_DEV_TO_APP_BUFFER_READABLE = 1112687648,
    /// <summary>Buffer readable/writable.</summary>
    @AV_DEV_TO_APP_BUFFER_WRITABLE = 1113018912,
    /// <summary>Mute state change message.</summary>
    @AV_DEV_TO_APP_MUTE_STATE_CHANGED = 1129141588,
    /// <summary>Volume level change message.</summary>
    @AV_DEV_TO_APP_VOLUME_LEVEL_CHANGED = 1129729868,
}

public enum _AVDiscard : int
{
    /// <summary>discard nothing</summary>
    @AVDISCARD_NONE = -16,
    /// <summary>discard useless packets like 0 size packets in avi</summary>
    @AVDISCARD_DEFAULT = 0,
    /// <summary>discard all non reference</summary>
    @AVDISCARD_NONREF = 8,
    /// <summary>discard all bidirectional frames</summary>
    @AVDISCARD_BIDIR = 16,
    /// <summary>discard all non intra frames</summary>
    @AVDISCARD_NONINTRA = 24,
    /// <summary>discard all frames except keyframes</summary>
    @AVDISCARD_NONKEY = 32,
    /// <summary>discard all</summary>
    @AVDISCARD_ALL = 48,
}

/// <summary>The duration of a video can be estimated through various ways, and this enum can be used to know how the duration was estimated.</summary>
public enum _AVDurationEstimationMethod : int
{
    /// <summary>Duration accurately estimated from PTSes</summary>
    @AVFMT_DURATION_FROM_PTS = 0,
    /// <summary>Duration estimated from a stream with a known duration</summary>
    @AVFMT_DURATION_FROM_STREAM = 1,
    /// <summary>Duration estimated from bitrate (less accurate)</summary>
    @AVFMT_DURATION_FROM_BITRATE = 2,
}

public enum _AVFieldOrder : int
{
    @AV_FIELD_UNKNOWN = 0,
    @AV_FIELD_PROGRESSIVE = 1,
    /// <summary>Top coded_first, top displayed first</summary>
    @AV_FIELD_TT = 2,
    /// <summary>Bottom coded first, bottom displayed first</summary>
    @AV_FIELD_BB = 3,
    /// <summary>Top coded first, bottom displayed first</summary>
    @AV_FIELD_TB = 4,
    /// <summary>Bottom coded first, top displayed first</summary>
    @AV_FIELD_BT = 5,
}

/// <summary>Command IDs that can be sent to the demuxer</summary>
public enum _AVFormatCommandID : int
{
    /// <summary>Send a RTSP `SET_PARAMETER` request to the server</summary>
    @AVFORMAT_COMMAND_RTSP_SET_PARAMETER = 0,
}

/// <summary>@{ AVFrame is an abstraction for reference-counted raw multimedia data.</summary>
public enum _AVFrameSideDataType : int
{
    /// <summary>The data is the AVPanScan struct defined in libavcodec.</summary>
    @AV_FRAME_DATA_PANSCAN = 0,
    /// <summary>ATSC A53 Part 4 Closed Captions. A53 CC bitstream is stored as uint8_t in AVFrameSideData.data. The number of bytes of CC data is AVFrameSideData.size.</summary>
    @AV_FRAME_DATA_A53_CC = 1,
    /// <summary>Stereoscopic 3d metadata. The data is the AVStereo3D struct defined in libavutil/stereo3d.h.</summary>
    @AV_FRAME_DATA_STEREO3D = 2,
    /// <summary>The data is the AVMatrixEncoding enum defined in libavutil/channel_layout.h.</summary>
    @AV_FRAME_DATA_MATRIXENCODING = 3,
    /// <summary>Metadata relevant to a downmix procedure. The data is the AVDownmixInfo struct defined in libavutil/downmix_info.h.</summary>
    @AV_FRAME_DATA_DOWNMIX_INFO = 4,
    /// <summary>ReplayGain information in the form of the AVReplayGain struct.</summary>
    @AV_FRAME_DATA_REPLAYGAIN = 5,
    /// <summary>This side data contains a 3x3 transformation matrix describing an affine transformation that needs to be applied to the frame for correct presentation.</summary>
    @AV_FRAME_DATA_DISPLAYMATRIX = 6,
    /// <summary>Active Format Description data consisting of a single byte as specified in ETSI TS 101 154 using AVActiveFormatDescription enum.</summary>
    @AV_FRAME_DATA_AFD = 7,
    /// <summary>Motion vectors exported by some codecs (on demand through the export_mvs flag set in the libavcodec AVCodecContext flags2 option). The data is the AVMotionVector struct defined in libavutil/motion_vector.h.</summary>
    @AV_FRAME_DATA_MOTION_VECTORS = 8,
    /// <summary>Recommends skipping the specified number of samples. This is exported only if the &quot;skip_manual&quot; AVOption is set in libavcodec. This has the same format as AV_PKT_DATA_SKIP_SAMPLES.</summary>
    @AV_FRAME_DATA_SKIP_SAMPLES = 9,
    /// <summary>This side data must be associated with an audio frame and corresponds to enum AVAudioServiceType defined in avcodec.h.</summary>
    @AV_FRAME_DATA_AUDIO_SERVICE_TYPE = 10,
    /// <summary>Mastering display metadata associated with a video frame. The payload is an AVMasteringDisplayMetadata type and contains information about the mastering display color volume.</summary>
    @AV_FRAME_DATA_MASTERING_DISPLAY_METADATA = 11,
    /// <summary>The GOP timecode in 25 bit timecode format. Data format is 64-bit integer. This is set on the first frame of a GOP that has a temporal reference of 0.</summary>
    @AV_FRAME_DATA_GOP_TIMECODE = 12,
    /// <summary>The data represents the AVSphericalMapping structure defined in libavutil/spherical.h.</summary>
    @AV_FRAME_DATA_SPHERICAL = 13,
    /// <summary>Content light level (based on CTA-861.3). This payload contains data in the form of the AVContentLightMetadata struct.</summary>
    @AV_FRAME_DATA_CONTENT_LIGHT_LEVEL = 14,
    /// <summary>The data contains an ICC profile as an opaque octet buffer following the format described by ISO 15076-1 with an optional name defined in the metadata key entry &quot;name&quot;.</summary>
    @AV_FRAME_DATA_ICC_PROFILE = 15,
    /// <summary>Timecode which conforms to SMPTE ST 12-1. The data is an array of 4 uint32_t where the first uint32_t describes how many (1-3) of the other timecodes are used. The timecode format is described in the documentation of av_timecode_get_smpte_from_framenum() function in libavutil/timecode.h.</summary>
    @AV_FRAME_DATA_S12M_TIMECODE = 16,
    /// <summary>HDR dynamic metadata associated with a video frame. The payload is an AVDynamicHDRPlus type and contains information for color volume transform - application 4 of SMPTE 2094-40:2016 standard.</summary>
    @AV_FRAME_DATA_DYNAMIC_HDR_PLUS = 17,
    /// <summary>Regions Of Interest, the data is an array of AVRegionOfInterest type, the number of array element is implied by AVFrameSideData.size / AVRegionOfInterest.self_size.</summary>
    @AV_FRAME_DATA_REGIONS_OF_INTEREST = 18,
    /// <summary>Encoding parameters for a video frame, as described by AVVideoEncParams.</summary>
    @AV_FRAME_DATA_VIDEO_ENC_PARAMS = 19,
    /// <summary>User data unregistered metadata associated with a video frame. This is the H.26[45] UDU SEI message, and shouldn&apos;t be used for any other purpose The data is stored as uint8_t in AVFrameSideData.data which is 16 bytes of uuid_iso_iec_11578 followed by AVFrameSideData.size - 16 bytes of user_data_payload_byte.</summary>
    @AV_FRAME_DATA_SEI_UNREGISTERED = 20,
    /// <summary>Film grain parameters for a frame, described by AVFilmGrainParams. Must be present for every frame which should have film grain applied.</summary>
    @AV_FRAME_DATA_FILM_GRAIN_PARAMS = 21,
    /// <summary>Bounding boxes for object detection and classification, as described by AVDetectionBBoxHeader.</summary>
    @AV_FRAME_DATA_DETECTION_BBOXES = 22,
    /// <summary>Dolby Vision RPU raw data, suitable for passing to x265 or other libraries. Array of uint8_t, with NAL emulation bytes intact.</summary>
    @AV_FRAME_DATA_DOVI_RPU_BUFFER = 23,
    /// <summary>Parsed Dolby Vision metadata, suitable for passing to a software implementation. The payload is the AVDOVIMetadata struct defined in libavutil/dovi_meta.h.</summary>
    @AV_FRAME_DATA_DOVI_METADATA = 24,
    /// <summary>HDR Vivid dynamic metadata associated with a video frame. The payload is an AVDynamicHDRVivid type and contains information for color volume transform - CUVA 005.1-2021.</summary>
    @AV_FRAME_DATA_DYNAMIC_HDR_VIVID = 25,
    /// <summary>Ambient viewing environment metadata, as defined by H.274.</summary>
    @AV_FRAME_DATA_AMBIENT_VIEWING_ENVIRONMENT = 26,
    /// <summary>Provide encoder-specific hinting information about changed/unchanged portions of a frame. It can be used to pass information about which macroblocks can be skipped because they didn&apos;t change from the corresponding ones in the previous frame. This could be useful for applications which know this information in advance to speed up encoding.</summary>
    @AV_FRAME_DATA_VIDEO_HINT = 27,
    /// <summary>Raw LCEVC payload data, as a uint8_t array, with NAL emulation bytes intact.</summary>
    @AV_FRAME_DATA_LCEVC = 28,
    /// <summary>This side data must be associated with a video frame. The presence of this side data indicates that the video stream is composed of multiple views (e.g. stereoscopic 3D content, cf. H.264 Annex H or H.265 Annex G). The data is an int storing the view ID.</summary>
    @AV_FRAME_DATA_VIEW_ID = 29,
    /// <summary>This side data contains information about the reference display width(s) and reference viewing distance(s) as well as information about the corresponding reference stereo pair(s), i.e., the pair(s) of views to be displayed for the viewer&apos;s left and right eyes on the reference display at the reference viewing distance. The payload is the AV3DReferenceDisplaysInfo struct defined in libavutil/tdrdi.h.</summary>
    @AV_FRAME_DATA_3D_REFERENCE_DISPLAYS = 30,
    /// <summary>Exchangeable image file format metadata. The payload is a buffer containing EXIF metadata, starting with either 49 49 2a 00, or 4d 4d 00 2a. These four bytes signify the endianness, and occur as the first part of the TIFF header.</summary>
    @AV_FRAME_DATA_EXIF = 31,
    /// <summary>HDR dynamic metadata associated with a video frame. The payload is an AVDynamicHDRSmpte2094App5 type and contains information for color volume transform as specified in the SMPTE 2094-50 standard.</summary>
    @AV_FRAME_DATA_DYNAMIC_HDR_SMPTE_2094_APP5 = 32,
    /// <summary>IAMF Mix Gain Parameter Data associated with the audio frame. This metadata is in the form of the AVIAMFParamDefinition struct and contains information defined in sections 3.6.1 and 3.8.1 of the Immersive Audio Model and Formats standard.</summary>
    @AV_FRAME_DATA_IAMF_MIX_GAIN_PARAM = 33,
    /// <summary>IAMF Demixing Info Parameter Data associated with the audio frame. This metadata is in the form of the AVIAMFParamDefinition struct and contains information defined in sections 3.6.1 and 3.8.2 of the Immersive Audio Model and Formats standard.</summary>
    @AV_FRAME_DATA_IAMF_DEMIXING_INFO_PARAM = 34,
    /// <summary>IAMF Recon Gain Info Parameter Data associated with the audio frame. This metadata is in the form of the AVIAMFParamDefinition struct and contains information defined in sections 3.6.1 and 3.8.3 of the Immersive Audio Model and Formats standard.</summary>
    @AV_FRAME_DATA_IAMF_RECON_GAIN_INFO_PARAM = 35,
    /// <summary>Color information from a RAW camera codecs, needed to correctly process the video data. The payload is an AVRawColorParams struct defined in libavutil/raw_color_params.h.</summary>
    @AV_FRAME_DATA_RAW_COLOR_PARAMS = 36,
}

/// <summary>Option for overlapping elliptical pixel selectors in an image.</summary>
public enum _AVHDRPlusOverlapProcessOption : int
{
    @AV_HDR_PLUS_OVERLAP_PROCESS_WEIGHTED_AVERAGING = 0,
    @AV_HDR_PLUS_OVERLAP_PROCESS_LAYERING = 1,
}

public enum _AVHWDeviceType : int
{
    @AV_HWDEVICE_TYPE_NONE = 0,
    @AV_HWDEVICE_TYPE_VDPAU = 1,
    @AV_HWDEVICE_TYPE_CUDA = 2,
    @AV_HWDEVICE_TYPE_VAAPI = 3,
    @AV_HWDEVICE_TYPE_DXVA2 = 4,
    @AV_HWDEVICE_TYPE_QSV = 5,
    @AV_HWDEVICE_TYPE_VIDEOTOOLBOX = 6,
    @AV_HWDEVICE_TYPE_D3D11VA = 7,
    @AV_HWDEVICE_TYPE_DRM = 8,
    @AV_HWDEVICE_TYPE_OPENCL = 9,
    @AV_HWDEVICE_TYPE_MEDIACODEC = 10,
    @AV_HWDEVICE_TYPE_VULKAN = 11,
    @AV_HWDEVICE_TYPE_D3D12VA = 12,
    @AV_HWDEVICE_TYPE_AMF = 13,
    @AV_HWDEVICE_TYPE_OHCODEC = 14,
}

public enum _AVHWFrameTransferDirection : int
{
    /// <summary>Transfer the data from the queried hw frame.</summary>
    @AV_HWFRAME_TRANSFER_DIRECTION_FROM = 0,
    /// <summary>Transfer the data to the queried hw frame.</summary>
    @AV_HWFRAME_TRANSFER_DIRECTION_TO = 1,
}

/// <summary>Different data types that can be returned via the AVIO write_data_type callback.</summary>
public enum _AVIODataMarkerType : int
{
    /// <summary>Header data; this needs to be present for the stream to be decodeable.</summary>
    @AVIO_DATA_MARKER_HEADER = 0,
    /// <summary>A point in the output bytestream where a decoder can start decoding (i.e. a keyframe). A demuxer/decoder given the data flagged with AVIO_DATA_MARKER_HEADER, followed by any AVIO_DATA_MARKER_SYNC_POINT, should give decodeable results.</summary>
    @AVIO_DATA_MARKER_SYNC_POINT = 1,
    /// <summary>A point in the output bytestream where a demuxer can start parsing (for non self synchronizing bytestream formats). That is, any non-keyframe packet start point.</summary>
    @AVIO_DATA_MARKER_BOUNDARY_POINT = 2,
    /// <summary>This is any, unlabelled data. It can either be a muxer not marking any positions at all, it can be an actual boundary/sync point that the muxer chooses not to mark, or a later part of a packet/fragment that is cut into multiple write callbacks due to limited IO buffer size.</summary>
    @AVIO_DATA_MARKER_UNKNOWN = 3,
    /// <summary>Trailer data, which doesn&apos;t contain actual content, but only for finalizing the output file.</summary>
    @AVIO_DATA_MARKER_TRAILER = 4,
    /// <summary>A point in the output bytestream where the underlying AVIOContext might flush the buffer depending on latency or buffering requirements. Typically means the end of a packet.</summary>
    @AVIO_DATA_MARKER_FLUSH_POINT = 5,
}

/// <summary>Directory entry types.</summary>
public enum _AVIODirEntryType : int
{
    @AVIO_ENTRY_UNKNOWN = 0,
    @AVIO_ENTRY_BLOCK_DEVICE = 1,
    @AVIO_ENTRY_CHARACTER_DEVICE = 2,
    @AVIO_ENTRY_DIRECTORY = 3,
    @AVIO_ENTRY_NAMED_PIPE = 4,
    @AVIO_ENTRY_SYMBOLIC_LINK = 5,
    @AVIO_ENTRY_SOCKET = 6,
    @AVIO_ENTRY_FILE = 7,
    @AVIO_ENTRY_SERVER = 8,
    @AVIO_ENTRY_SHARE = 9,
    @AVIO_ENTRY_WORKGROUP = 10,
}

public enum _AVMatrixEncoding : int
{
    @AV_MATRIX_ENCODING_NONE = 0,
    @AV_MATRIX_ENCODING_DOLBY = 1,
    @AV_MATRIX_ENCODING_DPLII = 2,
    @AV_MATRIX_ENCODING_DPLIIX = 3,
    @AV_MATRIX_ENCODING_DPLIIZ = 4,
    @AV_MATRIX_ENCODING_DOLBYEX = 5,
    @AV_MATRIX_ENCODING_DOLBYHEADPHONE = 6,
    @AV_MATRIX_ENCODING_NB = 7,
}

/// <summary>Media Type</summary>
public enum _AVMediaType : int
{
    /// <summary>Usually treated as AVMEDIA_TYPE_DATA</summary>
    @AVMEDIA_TYPE_UNKNOWN = -1,
    @AVMEDIA_TYPE_VIDEO = 0,
    @AVMEDIA_TYPE_AUDIO = 1,
    /// <summary>Opaque data information usually continuous</summary>
    @AVMEDIA_TYPE_DATA = 2,
    @AVMEDIA_TYPE_SUBTITLE = 3,
    /// <summary>Opaque data information usually sparse</summary>
    @AVMEDIA_TYPE_ATTACHMENT = 4,
    @AVMEDIA_TYPE_NB = 5,
}

/// <summary>An option type determines: - for native access, the underlying C type of the field that an AVOption refers to; - for foreign access, the semantics of accessing the option through this API, e.g. which av_opt_get_*() and av_opt_set_*() functions can be called, or what format will av_opt_get()/av_opt_set() expect/produce.</summary>
public enum _AVOptionType : int
{
    /// <summary>Underlying C type is unsigned int.</summary>
    @AV_OPT_TYPE_FLAGS = 1,
    /// <summary>Underlying C type is int.</summary>
    @AV_OPT_TYPE_INT = 2,
    /// <summary>Underlying C type is int64_t.</summary>
    @AV_OPT_TYPE_INT64 = 3,
    /// <summary>Underlying C type is double.</summary>
    @AV_OPT_TYPE_DOUBLE = 4,
    /// <summary>Underlying C type is float.</summary>
    @AV_OPT_TYPE_FLOAT = 5,
    /// <summary>Underlying C type is a uint8_t* that is either NULL or points to a C string allocated with the av_malloc() family of functions.</summary>
    @AV_OPT_TYPE_STRING = 6,
    /// <summary>Underlying C type is AVRational.</summary>
    @AV_OPT_TYPE_RATIONAL = 7,
    /// <summary>Underlying C type is a uint8_t* that is either NULL or points to an array allocated with the av_malloc() family of functions. The pointer is immediately followed by an int containing the array length in bytes.</summary>
    @AV_OPT_TYPE_BINARY = 8,
    /// <summary>Underlying C type is AVDictionary*.</summary>
    @AV_OPT_TYPE_DICT = 9,
    /// <summary>Underlying C type is uint64_t.</summary>
    @AV_OPT_TYPE_UINT64 = 10,
    /// <summary>Special option type for declaring named constants. Does not correspond to an actual field in the object, offset must be 0.</summary>
    @AV_OPT_TYPE_CONST = 11,
    /// <summary>Underlying C type is two consecutive integers.</summary>
    @AV_OPT_TYPE_IMAGE_SIZE = 12,
    /// <summary>Underlying C type is enum AVPixelFormat.</summary>
    @AV_OPT_TYPE_PIXEL_FMT = 13,
    /// <summary>Underlying C type is enum AVSampleFormat.</summary>
    @AV_OPT_TYPE_SAMPLE_FMT = 14,
    /// <summary>Underlying C type is AVRational.</summary>
    @AV_OPT_TYPE_VIDEO_RATE = 15,
    /// <summary>Underlying C type is int64_t.</summary>
    @AV_OPT_TYPE_DURATION = 16,
    /// <summary>Underlying C type is uint8_t[4].</summary>
    @AV_OPT_TYPE_COLOR = 17,
    /// <summary>Underlying C type is int.</summary>
    @AV_OPT_TYPE_BOOL = 18,
    /// <summary>Underlying C type is AVChannelLayout.</summary>
    @AV_OPT_TYPE_CHLAYOUT = 19,
    /// <summary>Underlying C type is unsigned int.</summary>
    @AV_OPT_TYPE_UINT = 20,
    /// <summary>May be combined with another regular option type to declare an array option.</summary>
    @AV_OPT_TYPE_FLAG_ARRAY = 65536,
}

/// <summary>Types and functions for working with AVPacketSideData. @{</summary>
public enum _AVPacketSideDataType : int
{
    /// <summary>An AV_PKT_DATA_PALETTE side data packet contains exactly AVPALETTE_SIZE bytes worth of palette. This side data signals that a new palette is present.</summary>
    @AV_PKT_DATA_PALETTE = 0,
    /// <summary>The AV_PKT_DATA_NEW_EXTRADATA is used to notify the codec or the format that the extradata buffer was changed and the receiving side should act upon it appropriately. The new extradata is embedded in the side data buffer and should be immediately used for processing the current frame or packet.</summary>
    @AV_PKT_DATA_NEW_EXTRADATA = 1,
    /// <summary>An AV_PKT_DATA_PARAM_CHANGE side data packet is laid out as follows:</summary>
    @AV_PKT_DATA_PARAM_CHANGE = 2,
    /// <summary>An AV_PKT_DATA_H263_MB_INFO side data packet contains a number of structures with info about macroblocks relevant to splitting the packet into smaller packets on macroblock edges (e.g. as for RFC 2190). That is, it does not necessarily contain info about all macroblocks, as long as the distance between macroblocks in the info is smaller than the target payload size. Each MB info structure is 12 bytes, and is laid out as follows:</summary>
    @AV_PKT_DATA_H263_MB_INFO = 3,
    /// <summary>This side data should be associated with an audio stream and contains ReplayGain information in form of the AVReplayGain struct.</summary>
    @AV_PKT_DATA_REPLAYGAIN = 4,
    /// <summary>This side data contains a 3x3 transformation matrix describing an affine transformation that needs to be applied to the decoded video frames for correct presentation.</summary>
    @AV_PKT_DATA_DISPLAYMATRIX = 5,
    /// <summary>This side data should be associated with a video stream and contains Stereoscopic 3D information in form of the AVStereo3D struct.</summary>
    @AV_PKT_DATA_STEREO3D = 6,
    /// <summary>This side data should be associated with an audio stream and corresponds to enum AVAudioServiceType.</summary>
    @AV_PKT_DATA_AUDIO_SERVICE_TYPE = 7,
    /// <summary>This side data contains quality related information from the encoder.</summary>
    @AV_PKT_DATA_QUALITY_STATS = 8,
    /// <summary>This side data contains an integer value representing the stream index of a &quot;fallback&quot; track. A fallback track indicates an alternate track to use when the current track can not be decoded for some reason. e.g. no decoder available for codec.</summary>
    @AV_PKT_DATA_FALLBACK_TRACK = 9,
    /// <summary>This side data corresponds to the AVCPBProperties struct.</summary>
    @AV_PKT_DATA_CPB_PROPERTIES = 10,
    /// <summary>Recommends skipping the specified number of samples</summary>
    @AV_PKT_DATA_SKIP_SAMPLES = 11,
    /// <summary>An AV_PKT_DATA_JP_DUALMONO side data packet indicates that the packet may contain &quot;dual mono&quot; audio specific to Japanese DTV and if it is true, recommends only the selected channel to be used.</summary>
    @AV_PKT_DATA_JP_DUALMONO = 12,
    /// <summary>A list of zero terminated key/value strings. There is no end marker for the list, so it is required to rely on the side data size to stop.</summary>
    @AV_PKT_DATA_STRINGS_METADATA = 13,
    /// <summary>Subtitle event position</summary>
    @AV_PKT_DATA_SUBTITLE_POSITION = 14,
    /// <summary>Data found in BlockAdditional element of matroska container. There is no end marker for the data, so it is required to rely on the side data size to recognize the end. 8 byte id (as found in BlockAddId) followed by data.</summary>
    @AV_PKT_DATA_MATROSKA_BLOCKADDITIONAL = 15,
    /// <summary>The optional first identifier line of a WebVTT cue.</summary>
    @AV_PKT_DATA_WEBVTT_IDENTIFIER = 16,
    /// <summary>The optional settings (rendering instructions) that immediately follow the timestamp specifier of a WebVTT cue.</summary>
    @AV_PKT_DATA_WEBVTT_SETTINGS = 17,
    /// <summary>A list of zero terminated key/value strings. There is no end marker for the list, so it is required to rely on the side data size to stop. This side data includes updated metadata which appeared in the stream.</summary>
    @AV_PKT_DATA_METADATA_UPDATE = 18,
    /// <summary>MPEGTS stream ID as uint8_t, this is required to pass the stream ID information from the demuxer to the corresponding muxer.</summary>
    @AV_PKT_DATA_MPEGTS_STREAM_ID = 19,
    /// <summary>Mastering display metadata (based on SMPTE-2086:2014). This metadata should be associated with a video stream and contains data in the form of the AVMasteringDisplayMetadata struct.</summary>
    @AV_PKT_DATA_MASTERING_DISPLAY_METADATA = 20,
    /// <summary>This side data should be associated with a video stream and corresponds to the AVSphericalMapping structure.</summary>
    @AV_PKT_DATA_SPHERICAL = 21,
    /// <summary>Content light level (based on CTA-861.3). This metadata should be associated with a video stream and contains data in the form of the AVContentLightMetadata struct.</summary>
    @AV_PKT_DATA_CONTENT_LIGHT_LEVEL = 22,
    /// <summary>ATSC A53 Part 4 Closed Captions. This metadata should be associated with a video stream. A53 CC bitstream is stored as uint8_t in AVPacketSideData.data. The number of bytes of CC data is AVPacketSideData.size.</summary>
    @AV_PKT_DATA_A53_CC = 23,
    /// <summary>This side data is encryption initialization data. The format is not part of ABI, use av_encryption_init_info_* methods to access.</summary>
    @AV_PKT_DATA_ENCRYPTION_INIT_INFO = 24,
    /// <summary>This side data contains encryption info for how to decrypt the packet. The format is not part of ABI, use av_encryption_info_* methods to access.</summary>
    @AV_PKT_DATA_ENCRYPTION_INFO = 25,
    /// <summary>Active Format Description data consisting of a single byte as specified in ETSI TS 101 154 using AVActiveFormatDescription enum.</summary>
    @AV_PKT_DATA_AFD = 26,
    /// <summary>Producer Reference Time data corresponding to the AVProducerReferenceTime struct, usually exported by some encoders (on demand through the prft flag set in the AVCodecContext export_side_data field).</summary>
    @AV_PKT_DATA_PRFT = 27,
    /// <summary>ICC profile data consisting of an opaque octet buffer following the format described by ISO 15076-1.</summary>
    @AV_PKT_DATA_ICC_PROFILE = 28,
    /// <summary>DOVI configuration ref: dolby-vision-bitstreams-within-the-iso-base-media-file-format-v2.1.2, section 2.2 dolby-vision-bitstreams-in-mpeg-2-transport-stream-multiplex-v1.2, section 3.3 Tags are stored in struct AVDOVIDecoderConfigurationRecord.</summary>
    @AV_PKT_DATA_DOVI_CONF = 29,
    /// <summary>Timecode which conforms to SMPTE ST 12-1:2014. The data is an array of 4 uint32_t where the first uint32_t describes how many (1-3) of the other timecodes are used. The timecode format is described in the documentation of av_timecode_get_smpte_from_framenum() function in libavutil/timecode.h.</summary>
    @AV_PKT_DATA_S12M_TIMECODE = 30,
    /// <summary>HDR10+ dynamic metadata associated with a video frame. The metadata is in the form of the AVDynamicHDRPlus struct and contains information for color volume transform - application 4 of SMPTE 2094-40:2016 standard.</summary>
    @AV_PKT_DATA_DYNAMIC_HDR10_PLUS = 31,
    /// <summary>IAMF Mix Gain Parameter Data associated with the audio frame. This metadata is in the form of the AVIAMFParamDefinition struct and contains information defined in sections 3.6.1 and 3.8.1 of the Immersive Audio Model and Formats standard.</summary>
    @AV_PKT_DATA_IAMF_MIX_GAIN_PARAM = 32,
    /// <summary>IAMF Demixing Info Parameter Data associated with the audio frame. This metadata is in the form of the AVIAMFParamDefinition struct and contains information defined in sections 3.6.1 and 3.8.2 of the Immersive Audio Model and Formats standard.</summary>
    @AV_PKT_DATA_IAMF_DEMIXING_INFO_PARAM = 33,
    /// <summary>IAMF Recon Gain Info Parameter Data associated with the audio frame. This metadata is in the form of the AVIAMFParamDefinition struct and contains information defined in sections 3.6.1 and 3.8.3 of the Immersive Audio Model and Formats standard.</summary>
    @AV_PKT_DATA_IAMF_RECON_GAIN_INFO_PARAM = 34,
    /// <summary>Ambient viewing environment metadata, as defined by H.274. This metadata should be associated with a video stream and contains data in the form of the AVAmbientViewingEnvironment struct.</summary>
    @AV_PKT_DATA_AMBIENT_VIEWING_ENVIRONMENT = 35,
    /// <summary>The number of pixels to discard from the top/bottom/left/right border of the decoded frame to obtain the sub-rectangle intended for presentation.</summary>
    @AV_PKT_DATA_FRAME_CROPPING = 36,
    /// <summary>Raw LCEVC payload data, as a uint8_t array, with NAL emulation bytes intact.</summary>
    @AV_PKT_DATA_LCEVC = 37,
    /// <summary>This side data contains information about the reference display width(s) and reference viewing distance(s) as well as information about the corresponding reference stereo pair(s), i.e., the pair(s) of views to be displayed for the viewer&apos;s left and right eyes on the reference display at the reference viewing distance. The payload is the AV3DReferenceDisplaysInfo struct defined in libavutil/tdrdi.h.</summary>
    @AV_PKT_DATA_3D_REFERENCE_DISPLAYS = 38,
    /// <summary>Contains the last received RTCP SR (Sender Report) information in the form of the AVRTCPSenderReport struct.</summary>
    @AV_PKT_DATA_RTCP_SR = 39,
    /// <summary>Extensible image file format metadata. The payload is a buffer containing EXIF metadata, starting with either 49 49 2a 00, or 4d 4d 00 2a.</summary>
    @AV_PKT_DATA_EXIF = 40,
    /// <summary>HDR dynamic metadata associated with a video frame. The payload is an AVDynamicHDRSmpte2094App5 type and contains information for color volume transform as specified in the SMPTE 2094-50 standard.</summary>
    @AV_PKT_DATA_DYNAMIC_HDR_SMPTE_2094_APP5 = 41,
    /// <summary>Dolby Vision enhancement-layer HEVC decoder configuration. Parsed from the hvcE box in ISOM-based containers or the corresponding BlockAdditionMapping in Matroska. The data is a raw HEVCDecoderConfigurationRecord as defined in ISO 14496-15.</summary>
    @AV_PKT_DATA_HEVC_CONF = 42,
    /// <summary>The number of side data types. This is not part of the public API/ABI in the sense that it may change when new side data types are added. This must stay the last enum value. If its value becomes huge, some code using it needs to be updated as it assumes it to be smaller than other limits.</summary>
    @AV_PKT_DATA_NB = 43,
}

/// <summary>@{</summary>
public enum _AVPictureStructure : int
{
    /// <summary>unknown</summary>
    @AV_PICTURE_STRUCTURE_UNKNOWN = 0,
    /// <summary>coded as top field</summary>
    @AV_PICTURE_STRUCTURE_TOP_FIELD = 1,
    /// <summary>coded as bottom field</summary>
    @AV_PICTURE_STRUCTURE_BOTTOM_FIELD = 2,
    /// <summary>coded as frame</summary>
    @AV_PICTURE_STRUCTURE_FRAME = 3,
}

/// <summary>@} @}</summary>
public enum _AVPictureType : int
{
    /// <summary>Undefined</summary>
    @AV_PICTURE_TYPE_NONE = 0,
    /// <summary>Intra</summary>
    @AV_PICTURE_TYPE_I = 1,
    /// <summary>Predicted</summary>
    @AV_PICTURE_TYPE_P = 2,
    /// <summary>Bi-dir predicted</summary>
    @AV_PICTURE_TYPE_B = 3,
    /// <summary>S(GMC)-VOP MPEG-4</summary>
    @AV_PICTURE_TYPE_S = 4,
    /// <summary>Switching Intra</summary>
    @AV_PICTURE_TYPE_SI = 5,
    /// <summary>Switching Predicted</summary>
    @AV_PICTURE_TYPE_SP = 6,
    /// <summary>BI type</summary>
    @AV_PICTURE_TYPE_BI = 7,
}

/// <summary>Pixel format.</summary>
public enum _AVPixelFormat : int
{
    @AV_PIX_FMT_NONE = -1,
    /// <summary>planar YUV 4:2:0, 12bpp, (1 Cr &amp; Cb sample per 2x2 Y samples)</summary>
    @AV_PIX_FMT_YUV420P = 0,
    /// <summary>packed YUV 4:2:2, 16bpp, Y0 Cb Y1 Cr</summary>
    @AV_PIX_FMT_YUYV422 = 1,
    /// <summary>packed RGB 8:8:8, 24bpp, RGBRGB...</summary>
    @AV_PIX_FMT_RGB24 = 2,
    /// <summary>packed RGB 8:8:8, 24bpp, BGRBGR...</summary>
    @AV_PIX_FMT_BGR24 = 3,
    /// <summary>planar YUV 4:2:2, 16bpp, (1 Cr &amp; Cb sample per 2x1 Y samples)</summary>
    @AV_PIX_FMT_YUV422P = 4,
    /// <summary>planar YUV 4:4:4, 24bpp, (1 Cr &amp; Cb sample per 1x1 Y samples)</summary>
    @AV_PIX_FMT_YUV444P = 5,
    /// <summary>planar YUV 4:1:0, 9bpp, (1 Cr &amp; Cb sample per 4x4 Y samples)</summary>
    @AV_PIX_FMT_YUV410P = 6,
    /// <summary>planar YUV 4:1:1, 12bpp, (1 Cr &amp; Cb sample per 4x1 Y samples)</summary>
    @AV_PIX_FMT_YUV411P = 7,
    /// <summary>Y , 8bpp</summary>
    @AV_PIX_FMT_GRAY8 = 8,
    /// <summary>Y , 1bpp, 0 is white, 1 is black, in each byte pixels are ordered from the msb to the lsb</summary>
    @AV_PIX_FMT_MONOWHITE = 9,
    /// <summary>Y , 1bpp, 0 is black, 1 is white, in each byte pixels are ordered from the msb to the lsb</summary>
    @AV_PIX_FMT_MONOBLACK = 10,
    /// <summary>8 bits with AV_PIX_FMT_RGB32 palette</summary>
    @AV_PIX_FMT_PAL8 = 11,
    /// <summary>planar YUV 4:2:0, 12bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV420P and setting color_range</summary>
    @AV_PIX_FMT_YUVJ420P = 12,
    /// <summary>planar YUV 4:2:2, 16bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV422P and setting color_range</summary>
    @AV_PIX_FMT_YUVJ422P = 13,
    /// <summary>planar YUV 4:4:4, 24bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV444P and setting color_range</summary>
    @AV_PIX_FMT_YUVJ444P = 14,
    /// <summary>packed YUV 4:2:2, 16bpp, Cb Y0 Cr Y1</summary>
    @AV_PIX_FMT_UYVY422 = 15,
    /// <summary>packed YUV 4:1:1, 12bpp, Cb Y0 Y1 Cr Y2 Y3</summary>
    @AV_PIX_FMT_UYYVYY411 = 16,
    /// <summary>packed RGB 3:3:2, 8bpp, (msb)2B 3G 3R(lsb)</summary>
    @AV_PIX_FMT_BGR8 = 17,
    /// <summary>packed RGB 1:2:1 bitstream, 4bpp, (msb)1B 2G 1R(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits</summary>
    @AV_PIX_FMT_BGR4 = 18,
    /// <summary>packed RGB 1:2:1, 8bpp, (msb)1B 2G 1R(lsb)</summary>
    @AV_PIX_FMT_BGR4_BYTE = 19,
    /// <summary>packed RGB 3:3:2, 8bpp, (msb)3R 3G 2B(lsb)</summary>
    @AV_PIX_FMT_RGB8 = 20,
    /// <summary>packed RGB 1:2:1 bitstream, 4bpp, (msb)1R 2G 1B(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits</summary>
    @AV_PIX_FMT_RGB4 = 21,
    /// <summary>packed RGB 1:2:1, 8bpp, (msb)1R 2G 1B(lsb)</summary>
    @AV_PIX_FMT_RGB4_BYTE = 22,
    /// <summary>planar YUV 4:2:0, 12bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V)</summary>
    @AV_PIX_FMT_NV12 = 23,
    /// <summary>as above, but U and V bytes are swapped</summary>
    @AV_PIX_FMT_NV21 = 24,
    /// <summary>packed ARGB 8:8:8:8, 32bpp, ARGBARGB...</summary>
    @AV_PIX_FMT_ARGB = 25,
    /// <summary>packed RGBA 8:8:8:8, 32bpp, RGBARGBA...</summary>
    @AV_PIX_FMT_RGBA = 26,
    /// <summary>packed ABGR 8:8:8:8, 32bpp, ABGRABGR...</summary>
    @AV_PIX_FMT_ABGR = 27,
    /// <summary>packed BGRA 8:8:8:8, 32bpp, BGRABGRA...</summary>
    @AV_PIX_FMT_BGRA = 28,
    /// <summary>Y , 16bpp, big-endian</summary>
    @AV_PIX_FMT_GRAY16BE = 29,
    /// <summary>Y , 16bpp, little-endian</summary>
    @AV_PIX_FMT_GRAY16LE = 30,
    /// <summary>planar YUV 4:4:0 (1 Cr &amp; Cb sample per 1x2 Y samples)</summary>
    @AV_PIX_FMT_YUV440P = 31,
    /// <summary>planar YUV 4:4:0 full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV440P and setting color_range</summary>
    @AV_PIX_FMT_YUVJ440P = 32,
    /// <summary>planar YUV 4:2:0, 20bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples)</summary>
    @AV_PIX_FMT_YUVA420P = 33,
    /// <summary>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as big-endian</summary>
    @AV_PIX_FMT_RGB48BE = 34,
    /// <summary>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as little-endian</summary>
    @AV_PIX_FMT_RGB48LE = 35,
    /// <summary>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), big-endian</summary>
    @AV_PIX_FMT_RGB565BE = 36,
    /// <summary>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), little-endian</summary>
    @AV_PIX_FMT_RGB565LE = 37,
    /// <summary>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), big-endian , X=unused/undefined</summary>
    @AV_PIX_FMT_RGB555BE = 38,
    /// <summary>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), little-endian, X=unused/undefined</summary>
    @AV_PIX_FMT_RGB555LE = 39,
    /// <summary>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), big-endian</summary>
    @AV_PIX_FMT_BGR565BE = 40,
    /// <summary>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), little-endian</summary>
    @AV_PIX_FMT_BGR565LE = 41,
    /// <summary>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), big-endian , X=unused/undefined</summary>
    @AV_PIX_FMT_BGR555BE = 42,
    /// <summary>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), little-endian, X=unused/undefined</summary>
    @AV_PIX_FMT_BGR555LE = 43,
    /// <summary>Hardware acceleration through VA-API, data[3] contains a VASurfaceID.</summary>
    @AV_PIX_FMT_VAAPI = 44,
    /// <summary>planar YUV 4:2:0, 24bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV420P16LE = 45,
    /// <summary>planar YUV 4:2:0, 24bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV420P16BE = 46,
    /// <summary>planar YUV 4:2:2, 32bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV422P16LE = 47,
    /// <summary>planar YUV 4:2:2, 32bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV422P16BE = 48,
    /// <summary>planar YUV 4:4:4, 48bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV444P16LE = 49,
    /// <summary>planar YUV 4:4:4, 48bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV444P16BE = 50,
    /// <summary>HW decoding through DXVA2, Picture.data[3] contains a LPDIRECT3DSURFACE9 pointer</summary>
    @AV_PIX_FMT_DXVA2_VLD = 51,
    /// <summary>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), little-endian, X=unused/undefined</summary>
    @AV_PIX_FMT_RGB444LE = 52,
    /// <summary>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), big-endian, X=unused/undefined</summary>
    @AV_PIX_FMT_RGB444BE = 53,
    /// <summary>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), little-endian, X=unused/undefined</summary>
    @AV_PIX_FMT_BGR444LE = 54,
    /// <summary>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), big-endian, X=unused/undefined</summary>
    @AV_PIX_FMT_BGR444BE = 55,
    /// <summary>8 bits gray, 8 bits alpha</summary>
    @AV_PIX_FMT_YA8 = 56,
    /// <summary>alias for AV_PIX_FMT_YA8</summary>
    @AV_PIX_FMT_Y400A = 56,
    /// <summary>alias for AV_PIX_FMT_YA8</summary>
    @AV_PIX_FMT_GRAY8A = 56,
    /// <summary>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as big-endian</summary>
    @AV_PIX_FMT_BGR48BE = 57,
    /// <summary>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as little-endian</summary>
    @AV_PIX_FMT_BGR48LE = 58,
    /// <summary>planar YUV 4:2:0, 13.5bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV420P9BE = 59,
    /// <summary>planar YUV 4:2:0, 13.5bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV420P9LE = 60,
    /// <summary>planar YUV 4:2:0, 15bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV420P10BE = 61,
    /// <summary>planar YUV 4:2:0, 15bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV420P10LE = 62,
    /// <summary>planar YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV422P10BE = 63,
    /// <summary>planar YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV422P10LE = 64,
    /// <summary>planar YUV 4:4:4, 27bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV444P9BE = 65,
    /// <summary>planar YUV 4:4:4, 27bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV444P9LE = 66,
    /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV444P10BE = 67,
    /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV444P10LE = 68,
    /// <summary>planar YUV 4:2:2, 18bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV422P9BE = 69,
    /// <summary>planar YUV 4:2:2, 18bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV422P9LE = 70,
    /// <summary>planar GBR 4:4:4 24bpp</summary>
    @AV_PIX_FMT_GBRP = 71,
    @AV_PIX_FMT_GBR24P = 71,
    /// <summary>planar GBR 4:4:4 27bpp, big-endian</summary>
    @AV_PIX_FMT_GBRP9BE = 72,
    /// <summary>planar GBR 4:4:4 27bpp, little-endian</summary>
    @AV_PIX_FMT_GBRP9LE = 73,
    /// <summary>planar GBR 4:4:4 30bpp, big-endian</summary>
    @AV_PIX_FMT_GBRP10BE = 74,
    /// <summary>planar GBR 4:4:4 30bpp, little-endian</summary>
    @AV_PIX_FMT_GBRP10LE = 75,
    /// <summary>planar GBR 4:4:4 48bpp, big-endian</summary>
    @AV_PIX_FMT_GBRP16BE = 76,
    /// <summary>planar GBR 4:4:4 48bpp, little-endian</summary>
    @AV_PIX_FMT_GBRP16LE = 77,
    /// <summary>planar YUV 4:2:2 24bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples)</summary>
    @AV_PIX_FMT_YUVA422P = 78,
    /// <summary>planar YUV 4:4:4 32bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples)</summary>
    @AV_PIX_FMT_YUVA444P = 79,
    /// <summary>planar YUV 4:2:0 22.5bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples), big-endian</summary>
    @AV_PIX_FMT_YUVA420P9BE = 80,
    /// <summary>planar YUV 4:2:0 22.5bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples), little-endian</summary>
    @AV_PIX_FMT_YUVA420P9LE = 81,
    /// <summary>planar YUV 4:2:2 27bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples), big-endian</summary>
    @AV_PIX_FMT_YUVA422P9BE = 82,
    /// <summary>planar YUV 4:2:2 27bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples), little-endian</summary>
    @AV_PIX_FMT_YUVA422P9LE = 83,
    /// <summary>planar YUV 4:4:4 36bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), big-endian</summary>
    @AV_PIX_FMT_YUVA444P9BE = 84,
    /// <summary>planar YUV 4:4:4 36bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), little-endian</summary>
    @AV_PIX_FMT_YUVA444P9LE = 85,
    /// <summary>planar YUV 4:2:0 25bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, big-endian)</summary>
    @AV_PIX_FMT_YUVA420P10BE = 86,
    /// <summary>planar YUV 4:2:0 25bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, little-endian)</summary>
    @AV_PIX_FMT_YUVA420P10LE = 87,
    /// <summary>planar YUV 4:2:2 30bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, big-endian)</summary>
    @AV_PIX_FMT_YUVA422P10BE = 88,
    /// <summary>planar YUV 4:2:2 30bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, little-endian)</summary>
    @AV_PIX_FMT_YUVA422P10LE = 89,
    /// <summary>planar YUV 4:4:4 40bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, big-endian)</summary>
    @AV_PIX_FMT_YUVA444P10BE = 90,
    /// <summary>planar YUV 4:4:4 40bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, little-endian)</summary>
    @AV_PIX_FMT_YUVA444P10LE = 91,
    /// <summary>planar YUV 4:2:0 40bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, big-endian)</summary>
    @AV_PIX_FMT_YUVA420P16BE = 92,
    /// <summary>planar YUV 4:2:0 40bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, little-endian)</summary>
    @AV_PIX_FMT_YUVA420P16LE = 93,
    /// <summary>planar YUV 4:2:2 48bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, big-endian)</summary>
    @AV_PIX_FMT_YUVA422P16BE = 94,
    /// <summary>planar YUV 4:2:2 48bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, little-endian)</summary>
    @AV_PIX_FMT_YUVA422P16LE = 95,
    /// <summary>planar YUV 4:4:4 64bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, big-endian)</summary>
    @AV_PIX_FMT_YUVA444P16BE = 96,
    /// <summary>planar YUV 4:4:4 64bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, little-endian)</summary>
    @AV_PIX_FMT_YUVA444P16LE = 97,
    /// <summary>HW acceleration through VDPAU, Picture.data[3] contains a VdpVideoSurface</summary>
    @AV_PIX_FMT_VDPAU = 98,
    /// <summary>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as little-endian, the 4 lower bits are set to 0</summary>
    @AV_PIX_FMT_XYZ12LE = 99,
    /// <summary>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as big-endian, the 4 lower bits are set to 0</summary>
    @AV_PIX_FMT_XYZ12BE = 100,
    /// <summary>interleaved chroma YUV 4:2:2, 16bpp, (1 Cr &amp; Cb sample per 2x1 Y samples)</summary>
    @AV_PIX_FMT_NV16 = 101,
    /// <summary>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_NV20LE = 102,
    /// <summary>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_NV20BE = 103,
    /// <summary>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian</summary>
    @AV_PIX_FMT_RGBA64BE = 104,
    /// <summary>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian</summary>
    @AV_PIX_FMT_RGBA64LE = 105,
    /// <summary>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian</summary>
    @AV_PIX_FMT_BGRA64BE = 106,
    /// <summary>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian</summary>
    @AV_PIX_FMT_BGRA64LE = 107,
    /// <summary>packed YUV 4:2:2, 16bpp, Y0 Cr Y1 Cb</summary>
    @AV_PIX_FMT_YVYU422 = 108,
    /// <summary>16 bits gray, 16 bits alpha (big-endian)</summary>
    @AV_PIX_FMT_YA16BE = 109,
    /// <summary>16 bits gray, 16 bits alpha (little-endian)</summary>
    @AV_PIX_FMT_YA16LE = 110,
    /// <summary>planar GBRA 4:4:4:4 32bpp</summary>
    @AV_PIX_FMT_GBRAP = 111,
    /// <summary>planar GBRA 4:4:4:4 64bpp, big-endian</summary>
    @AV_PIX_FMT_GBRAP16BE = 112,
    /// <summary>planar GBRA 4:4:4:4 64bpp, little-endian</summary>
    @AV_PIX_FMT_GBRAP16LE = 113,
    /// <summary>HW acceleration through QSV, data[3] contains a pointer to the mfxFrameSurface1 structure.</summary>
    @AV_PIX_FMT_QSV = 114,
    /// <summary>HW acceleration though MMAL, data[3] contains a pointer to the MMAL_BUFFER_HEADER_T structure.</summary>
    @AV_PIX_FMT_MMAL = 115,
    /// <summary>HW decoding through Direct3D11 via old API, Picture.data[3] contains a ID3D11VideoDecoderOutputView pointer</summary>
    @AV_PIX_FMT_D3D11VA_VLD = 116,
    /// <summary>HW acceleration through CUDA. data[i] contain CUdeviceptr pointers exactly as for system memory frames.</summary>
    @AV_PIX_FMT_CUDA = 117,
    /// <summary>packed RGB 8:8:8, 32bpp, XRGBXRGB... X=unused/undefined</summary>
    @AV_PIX_FMT_0RGB = 118,
    /// <summary>packed RGB 8:8:8, 32bpp, RGBXRGBX... X=unused/undefined</summary>
    @AV_PIX_FMT_RGB0 = 119,
    /// <summary>packed BGR 8:8:8, 32bpp, XBGRXBGR... X=unused/undefined</summary>
    @AV_PIX_FMT_0BGR = 120,
    /// <summary>packed BGR 8:8:8, 32bpp, BGRXBGRX... X=unused/undefined</summary>
    @AV_PIX_FMT_BGR0 = 121,
    /// <summary>planar YUV 4:2:0,18bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV420P12BE = 122,
    /// <summary>planar YUV 4:2:0,18bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV420P12LE = 123,
    /// <summary>planar YUV 4:2:0,21bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV420P14BE = 124,
    /// <summary>planar YUV 4:2:0,21bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV420P14LE = 125,
    /// <summary>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV422P12BE = 126,
    /// <summary>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV422P12LE = 127,
    /// <summary>planar YUV 4:2:2,28bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV422P14BE = 128,
    /// <summary>planar YUV 4:2:2,28bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV422P14LE = 129,
    /// <summary>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV444P12BE = 130,
    /// <summary>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV444P12LE = 131,
    /// <summary>planar YUV 4:4:4,42bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV444P14BE = 132,
    /// <summary>planar YUV 4:4:4,42bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV444P14LE = 133,
    /// <summary>planar GBR 4:4:4 36bpp, big-endian</summary>
    @AV_PIX_FMT_GBRP12BE = 134,
    /// <summary>planar GBR 4:4:4 36bpp, little-endian</summary>
    @AV_PIX_FMT_GBRP12LE = 135,
    /// <summary>planar GBR 4:4:4 42bpp, big-endian</summary>
    @AV_PIX_FMT_GBRP14BE = 136,
    /// <summary>planar GBR 4:4:4 42bpp, little-endian</summary>
    @AV_PIX_FMT_GBRP14LE = 137,
    /// <summary>planar YUV 4:1:1, 12bpp, (1 Cr &amp; Cb sample per 4x1 Y samples) full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV411P and setting color_range</summary>
    @AV_PIX_FMT_YUVJ411P = 138,
    /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 8-bit samples</summary>
    @AV_PIX_FMT_BAYER_BGGR8 = 139,
    /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 8-bit samples</summary>
    @AV_PIX_FMT_BAYER_RGGB8 = 140,
    /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 8-bit samples</summary>
    @AV_PIX_FMT_BAYER_GBRG8 = 141,
    /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 8-bit samples</summary>
    @AV_PIX_FMT_BAYER_GRBG8 = 142,
    /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 16-bit samples, little-endian</summary>
    @AV_PIX_FMT_BAYER_BGGR16LE = 143,
    /// <summary>bayer, BGBG..(odd line), GRGR..(even line), 16-bit samples, big-endian</summary>
    @AV_PIX_FMT_BAYER_BGGR16BE = 144,
    /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 16-bit samples, little-endian</summary>
    @AV_PIX_FMT_BAYER_RGGB16LE = 145,
    /// <summary>bayer, RGRG..(odd line), GBGB..(even line), 16-bit samples, big-endian</summary>
    @AV_PIX_FMT_BAYER_RGGB16BE = 146,
    /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 16-bit samples, little-endian</summary>
    @AV_PIX_FMT_BAYER_GBRG16LE = 147,
    /// <summary>bayer, GBGB..(odd line), RGRG..(even line), 16-bit samples, big-endian</summary>
    @AV_PIX_FMT_BAYER_GBRG16BE = 148,
    /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 16-bit samples, little-endian</summary>
    @AV_PIX_FMT_BAYER_GRBG16LE = 149,
    /// <summary>bayer, GRGR..(odd line), BGBG..(even line), 16-bit samples, big-endian</summary>
    @AV_PIX_FMT_BAYER_GRBG16BE = 150,
    /// <summary>planar YUV 4:4:0,20bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV440P10LE = 151,
    /// <summary>planar YUV 4:4:0,20bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV440P10BE = 152,
    /// <summary>planar YUV 4:4:0,24bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), little-endian</summary>
    @AV_PIX_FMT_YUV440P12LE = 153,
    /// <summary>planar YUV 4:4:0,24bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), big-endian</summary>
    @AV_PIX_FMT_YUV440P12BE = 154,
    /// <summary>packed AYUV 4:4:4,64bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), little-endian</summary>
    @AV_PIX_FMT_AYUV64LE = 155,
    /// <summary>packed AYUV 4:4:4,64bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), big-endian</summary>
    @AV_PIX_FMT_AYUV64BE = 156,
    /// <summary>hardware decoding through Videotoolbox</summary>
    @AV_PIX_FMT_VIDEOTOOLBOX = 157,
    /// <summary>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, little-endian</summary>
    @AV_PIX_FMT_P010LE = 158,
    /// <summary>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, big-endian</summary>
    @AV_PIX_FMT_P010BE = 159,
    /// <summary>planar GBR 4:4:4:4 48bpp, big-endian</summary>
    @AV_PIX_FMT_GBRAP12BE = 160,
    /// <summary>planar GBR 4:4:4:4 48bpp, little-endian</summary>
    @AV_PIX_FMT_GBRAP12LE = 161,
    /// <summary>planar GBR 4:4:4:4 40bpp, big-endian</summary>
    @AV_PIX_FMT_GBRAP10BE = 162,
    /// <summary>planar GBR 4:4:4:4 40bpp, little-endian</summary>
    @AV_PIX_FMT_GBRAP10LE = 163,
    /// <summary>hardware decoding through MediaCodec</summary>
    @AV_PIX_FMT_MEDIACODEC = 164,
    /// <summary>Y , 12bpp, big-endian</summary>
    @AV_PIX_FMT_GRAY12BE = 165,
    /// <summary>Y , 12bpp, little-endian</summary>
    @AV_PIX_FMT_GRAY12LE = 166,
    /// <summary>Y , 10bpp, big-endian</summary>
    @AV_PIX_FMT_GRAY10BE = 167,
    /// <summary>Y , 10bpp, little-endian</summary>
    @AV_PIX_FMT_GRAY10LE = 168,
    /// <summary>like NV12, with 16bpp per component, little-endian</summary>
    @AV_PIX_FMT_P016LE = 169,
    /// <summary>like NV12, with 16bpp per component, big-endian</summary>
    @AV_PIX_FMT_P016BE = 170,
    /// <summary>Hardware surfaces for Direct3D11.</summary>
    @AV_PIX_FMT_D3D11 = 171,
    /// <summary>Y , 9bpp, big-endian</summary>
    @AV_PIX_FMT_GRAY9BE = 172,
    /// <summary>Y , 9bpp, little-endian</summary>
    @AV_PIX_FMT_GRAY9LE = 173,
    /// <summary>IEEE-754 single precision planar GBR 4:4:4, 96bpp, big-endian</summary>
    @AV_PIX_FMT_GBRPF32BE = 174,
    /// <summary>IEEE-754 single precision planar GBR 4:4:4, 96bpp, little-endian</summary>
    @AV_PIX_FMT_GBRPF32LE = 175,
    /// <summary>IEEE-754 single precision planar GBRA 4:4:4:4, 128bpp, big-endian</summary>
    @AV_PIX_FMT_GBRAPF32BE = 176,
    /// <summary>IEEE-754 single precision planar GBRA 4:4:4:4, 128bpp, little-endian</summary>
    @AV_PIX_FMT_GBRAPF32LE = 177,
    /// <summary>DRM-managed buffers exposed through PRIME buffer sharing.</summary>
    @AV_PIX_FMT_DRM_PRIME = 178,
    /// <summary>Hardware surfaces for OpenCL.</summary>
    @AV_PIX_FMT_OPENCL = 179,
    /// <summary>Y , 14bpp, big-endian</summary>
    @AV_PIX_FMT_GRAY14BE = 180,
    /// <summary>Y , 14bpp, little-endian</summary>
    @AV_PIX_FMT_GRAY14LE = 181,
    /// <summary>IEEE-754 single precision Y, 32bpp, big-endian</summary>
    @AV_PIX_FMT_GRAYF32BE = 182,
    /// <summary>IEEE-754 single precision Y, 32bpp, little-endian</summary>
    @AV_PIX_FMT_GRAYF32LE = 183,
    /// <summary>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), 12b alpha, big-endian</summary>
    @AV_PIX_FMT_YUVA422P12BE = 184,
    /// <summary>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), 12b alpha, little-endian</summary>
    @AV_PIX_FMT_YUVA422P12LE = 185,
    /// <summary>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), 12b alpha, big-endian</summary>
    @AV_PIX_FMT_YUVA444P12BE = 186,
    /// <summary>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), 12b alpha, little-endian</summary>
    @AV_PIX_FMT_YUVA444P12LE = 187,
    /// <summary>planar YUV 4:4:4, 24bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V)</summary>
    @AV_PIX_FMT_NV24 = 188,
    /// <summary>as above, but U and V bytes are swapped</summary>
    @AV_PIX_FMT_NV42 = 189,
    /// <summary>Vulkan hardware images.</summary>
    @AV_PIX_FMT_VULKAN = 190,
    /// <summary>packed YUV 4:2:2 like YUYV422, 20bpp, data in the high bits, big-endian</summary>
    @AV_PIX_FMT_Y210BE = 191,
    /// <summary>packed YUV 4:2:2 like YUYV422, 20bpp, data in the high bits, little-endian</summary>
    @AV_PIX_FMT_Y210LE = 192,
    /// <summary>packed RGB 10:10:10, 30bpp, (msb)2X 10R 10G 10B(lsb), little-endian, X=unused/undefined</summary>
    @AV_PIX_FMT_X2RGB10LE = 193,
    /// <summary>packed RGB 10:10:10, 30bpp, (msb)2X 10R 10G 10B(lsb), big-endian, X=unused/undefined</summary>
    @AV_PIX_FMT_X2RGB10BE = 194,
    /// <summary>packed BGR 10:10:10, 30bpp, (msb)2X 10B 10G 10R(lsb), little-endian, X=unused/undefined</summary>
    @AV_PIX_FMT_X2BGR10LE = 195,
    /// <summary>packed BGR 10:10:10, 30bpp, (msb)2X 10B 10G 10R(lsb), big-endian, X=unused/undefined</summary>
    @AV_PIX_FMT_X2BGR10BE = 196,
    /// <summary>interleaved chroma YUV 4:2:2, 20bpp, data in the high bits, big-endian</summary>
    @AV_PIX_FMT_P210BE = 197,
    /// <summary>interleaved chroma YUV 4:2:2, 20bpp, data in the high bits, little-endian</summary>
    @AV_PIX_FMT_P210LE = 198,
    /// <summary>interleaved chroma YUV 4:4:4, 30bpp, data in the high bits, big-endian</summary>
    @AV_PIX_FMT_P410BE = 199,
    /// <summary>interleaved chroma YUV 4:4:4, 30bpp, data in the high bits, little-endian</summary>
    @AV_PIX_FMT_P410LE = 200,
    /// <summary>interleaved chroma YUV 4:2:2, 32bpp, big-endian</summary>
    @AV_PIX_FMT_P216BE = 201,
    /// <summary>interleaved chroma YUV 4:2:2, 32bpp, little-endian</summary>
    @AV_PIX_FMT_P216LE = 202,
    /// <summary>interleaved chroma YUV 4:4:4, 48bpp, big-endian</summary>
    @AV_PIX_FMT_P416BE = 203,
    /// <summary>interleaved chroma YUV 4:4:4, 48bpp, little-endian</summary>
    @AV_PIX_FMT_P416LE = 204,
    /// <summary>packed VUYA 4:4:4:4, 32bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), VUYAVUYA...</summary>
    @AV_PIX_FMT_VUYA = 205,
    /// <summary>IEEE-754 half precision packed RGBA 16:16:16:16, 64bpp, RGBARGBA..., big-endian</summary>
    @AV_PIX_FMT_RGBAF16BE = 206,
    /// <summary>IEEE-754 half precision packed RGBA 16:16:16:16, 64bpp, RGBARGBA..., little-endian</summary>
    @AV_PIX_FMT_RGBAF16LE = 207,
    /// <summary>packed VUYX 4:4:4:4, 32bpp, Variant of VUYA where alpha channel is left undefined</summary>
    @AV_PIX_FMT_VUYX = 208,
    /// <summary>like NV12, with 12bpp per component, data in the high bits, zeros in the low bits, little-endian</summary>
    @AV_PIX_FMT_P012LE = 209,
    /// <summary>like NV12, with 12bpp per component, data in the high bits, zeros in the low bits, big-endian</summary>
    @AV_PIX_FMT_P012BE = 210,
    /// <summary>packed YUV 4:2:2 like YUYV422, 24bpp, data in the high bits, zeros in the low bits, big-endian</summary>
    @AV_PIX_FMT_Y212BE = 211,
    /// <summary>packed YUV 4:2:2 like YUYV422, 24bpp, data in the high bits, zeros in the low bits, little-endian</summary>
    @AV_PIX_FMT_Y212LE = 212,
    /// <summary>packed XVYU 4:4:4, 32bpp, (msb)2X 10V 10Y 10U(lsb), big-endian, variant of Y410 where alpha channel is left undefined</summary>
    @AV_PIX_FMT_XV30BE = 213,
    /// <summary>packed XVYU 4:4:4, 32bpp, (msb)2X 10V 10Y 10U(lsb), little-endian, variant of Y410 where alpha channel is left undefined</summary>
    @AV_PIX_FMT_XV30LE = 214,
    /// <summary>packed XVYU 4:4:4, 48bpp, data in the high bits, zeros in the low bits, big-endian, variant of Y412 where alpha channel is left undefined</summary>
    @AV_PIX_FMT_XV36BE = 215,
    /// <summary>packed XVYU 4:4:4, 48bpp, data in the high bits, zeros in the low bits, little-endian, variant of Y412 where alpha channel is left undefined</summary>
    @AV_PIX_FMT_XV36LE = 216,
    /// <summary>IEEE-754 single precision packed RGB 32:32:32, 96bpp, RGBRGB..., big-endian</summary>
    @AV_PIX_FMT_RGBF32BE = 217,
    /// <summary>IEEE-754 single precision packed RGB 32:32:32, 96bpp, RGBRGB..., little-endian</summary>
    @AV_PIX_FMT_RGBF32LE = 218,
    /// <summary>IEEE-754 single precision packed RGBA 32:32:32:32, 128bpp, RGBARGBA..., big-endian</summary>
    @AV_PIX_FMT_RGBAF32BE = 219,
    /// <summary>IEEE-754 single precision packed RGBA 32:32:32:32, 128bpp, RGBARGBA..., little-endian</summary>
    @AV_PIX_FMT_RGBAF32LE = 220,
    /// <summary>interleaved chroma YUV 4:2:2, 24bpp, data in the high bits, big-endian</summary>
    @AV_PIX_FMT_P212BE = 221,
    /// <summary>interleaved chroma YUV 4:2:2, 24bpp, data in the high bits, little-endian</summary>
    @AV_PIX_FMT_P212LE = 222,
    /// <summary>interleaved chroma YUV 4:4:4, 36bpp, data in the high bits, big-endian</summary>
    @AV_PIX_FMT_P412BE = 223,
    /// <summary>interleaved chroma YUV 4:4:4, 36bpp, data in the high bits, little-endian</summary>
    @AV_PIX_FMT_P412LE = 224,
    /// <summary>planar GBR 4:4:4:4 56bpp, big-endian</summary>
    @AV_PIX_FMT_GBRAP14BE = 225,
    /// <summary>planar GBR 4:4:4:4 56bpp, little-endian</summary>
    @AV_PIX_FMT_GBRAP14LE = 226,
    /// <summary>Hardware surfaces for Direct3D 12.</summary>
    @AV_PIX_FMT_D3D12 = 227,
    /// <summary>packed AYUV 4:4:4:4, 32bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), AYUVAYUV...</summary>
    @AV_PIX_FMT_AYUV = 228,
    /// <summary>packed UYVA 4:4:4:4, 32bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), UYVAUYVA...</summary>
    @AV_PIX_FMT_UYVA = 229,
    /// <summary>packed VYU 4:4:4, 24bpp (1 Cr &amp; Cb sample per 1x1 Y), VYUVYU...</summary>
    @AV_PIX_FMT_VYU444 = 230,
    /// <summary>packed VYUX 4:4:4 like XV30, 32bpp, (msb)10V 10Y 10U 2X(lsb), big-endian</summary>
    @AV_PIX_FMT_V30XBE = 231,
    /// <summary>packed VYUX 4:4:4 like XV30, 32bpp, (msb)10V 10Y 10U 2X(lsb), little-endian</summary>
    @AV_PIX_FMT_V30XLE = 232,
    /// <summary>IEEE-754 half precision packed RGB 16:16:16, 48bpp, RGBRGB..., big-endian</summary>
    @AV_PIX_FMT_RGBF16BE = 233,
    /// <summary>IEEE-754 half precision packed RGB 16:16:16, 48bpp, RGBRGB..., little-endian</summary>
    @AV_PIX_FMT_RGBF16LE = 234,
    /// <summary>packed RGBA 32:32:32:32, 128bpp, RGBARGBA..., big-endian</summary>
    @AV_PIX_FMT_RGBA128BE = 235,
    /// <summary>packed RGBA 32:32:32:32, 128bpp, RGBARGBA..., little-endian</summary>
    @AV_PIX_FMT_RGBA128LE = 236,
    /// <summary>packed RGBA 32:32:32, 96bpp, RGBRGB..., big-endian</summary>
    @AV_PIX_FMT_RGB96BE = 237,
    /// <summary>packed RGBA 32:32:32, 96bpp, RGBRGB..., little-endian</summary>
    @AV_PIX_FMT_RGB96LE = 238,
    /// <summary>packed YUV 4:2:2 like YUYV422, 32bpp, big-endian</summary>
    @AV_PIX_FMT_Y216BE = 239,
    /// <summary>packed YUV 4:2:2 like YUYV422, 32bpp, little-endian</summary>
    @AV_PIX_FMT_Y216LE = 240,
    /// <summary>packed XVYU 4:4:4, 64bpp, big-endian, variant of Y416 where alpha channel is left undefined</summary>
    @AV_PIX_FMT_XV48BE = 241,
    /// <summary>packed XVYU 4:4:4, 64bpp, little-endian, variant of Y416 where alpha channel is left undefined</summary>
    @AV_PIX_FMT_XV48LE = 242,
    /// <summary>IEEE-754 half precision planer GBR 4:4:4, 48bpp, big-endian</summary>
    @AV_PIX_FMT_GBRPF16BE = 243,
    /// <summary>IEEE-754 half precision planer GBR 4:4:4, 48bpp, little-endian</summary>
    @AV_PIX_FMT_GBRPF16LE = 244,
    /// <summary>IEEE-754 half precision planar GBRA 4:4:4:4, 64bpp, big-endian</summary>
    @AV_PIX_FMT_GBRAPF16BE = 245,
    /// <summary>IEEE-754 half precision planar GBRA 4:4:4:4, 64bpp, little-endian</summary>
    @AV_PIX_FMT_GBRAPF16LE = 246,
    /// <summary>IEEE-754 half precision Y, 16bpp, big-endian</summary>
    @AV_PIX_FMT_GRAYF16BE = 247,
    /// <summary>IEEE-754 half precision Y, 16bpp, little-endian</summary>
    @AV_PIX_FMT_GRAYF16LE = 248,
    /// <summary>HW acceleration through AMF. data[0] contain AMFSurface pointer</summary>
    @AV_PIX_FMT_AMF_SURFACE = 249,
    /// <summary>Y , 32bpp, big-endian</summary>
    @AV_PIX_FMT_GRAY32BE = 250,
    /// <summary>Y , 32bpp, little-endian</summary>
    @AV_PIX_FMT_GRAY32LE = 251,
    /// <summary>IEEE-754 single precision packed YA, 32 bits gray, 32 bits alpha, 64bpp, big-endian</summary>
    @AV_PIX_FMT_YAF32BE = 252,
    /// <summary>IEEE-754 single precision packed YA, 32 bits gray, 32 bits alpha, 64bpp, little-endian</summary>
    @AV_PIX_FMT_YAF32LE = 253,
    /// <summary>IEEE-754 half precision packed YA, 16 bits gray, 16 bits alpha, 32bpp, big-endian</summary>
    @AV_PIX_FMT_YAF16BE = 254,
    /// <summary>IEEE-754 half precision packed YA, 16 bits gray, 16 bits alpha, 32bpp, little-endian</summary>
    @AV_PIX_FMT_YAF16LE = 255,
    /// <summary>planar GBRA 4:4:4:4 128bpp, big-endian</summary>
    @AV_PIX_FMT_GBRAP32BE = 256,
    /// <summary>planar GBRA 4:4:4:4 128bpp, little-endian</summary>
    @AV_PIX_FMT_GBRAP32LE = 257,
    /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), lowest bits zero, big-endian</summary>
    @AV_PIX_FMT_YUV444P10MSBBE = 258,
    /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), lowest bits zero, little-endian</summary>
    @AV_PIX_FMT_YUV444P10MSBLE = 259,
    /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), lowest bits zero, big-endian</summary>
    @AV_PIX_FMT_YUV444P12MSBBE = 260,
    /// <summary>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), lowest bits zero, little-endian</summary>
    @AV_PIX_FMT_YUV444P12MSBLE = 261,
    /// <summary>planar GBR 4:4:4 30bpp, lowest bits zero, big-endian</summary>
    @AV_PIX_FMT_GBRP10MSBBE = 262,
    /// <summary>planar GBR 4:4:4 30bpp, lowest bits zero, little-endian</summary>
    @AV_PIX_FMT_GBRP10MSBLE = 263,
    /// <summary>planar GBR 4:4:4 36bpp, lowest bits zero, big-endian</summary>
    @AV_PIX_FMT_GBRP12MSBBE = 264,
    /// <summary>planar GBR 4:4:4 36bpp, lowest bits zero, little-endian</summary>
    @AV_PIX_FMT_GBRP12MSBLE = 265,
    @AV_PIX_FMT_OHCODEC = 266,
    /// <summary>number of pixel formats, DO NOT USE THIS if you want to link with shared libav* because the number of formats might differ between versions</summary>
    @AV_PIX_FMT_NB = 267,
}

/// <summary>Rounding methods.</summary>
public enum _AVRounding : int
{
    /// <summary>Round toward zero.</summary>
    @AV_ROUND_ZERO = 0,
    /// <summary>Round away from zero.</summary>
    @AV_ROUND_INF = 1,
    /// <summary>Round toward -infinity.</summary>
    @AV_ROUND_DOWN = 2,
    /// <summary>Round toward +infinity.</summary>
    @AV_ROUND_UP = 3,
    /// <summary>Round to nearest and halfway cases away from zero.</summary>
    @AV_ROUND_NEAR_INF = 5,
    /// <summary>Flag telling rescaling functions to pass `INT64_MIN`/`MAX` through unchanged, avoiding special cases for #AV_NOPTS_VALUE.</summary>
    @AV_ROUND_PASS_MINMAX = 8192,
}

/// <summary>Audio sample formats</summary>
public enum _AVSampleFormat : int
{
    @AV_SAMPLE_FMT_NONE = -1,
    /// <summary>unsigned 8 bits</summary>
    @AV_SAMPLE_FMT_U8 = 0,
    /// <summary>signed 16 bits</summary>
    @AV_SAMPLE_FMT_S16 = 1,
    /// <summary>signed 32 bits</summary>
    @AV_SAMPLE_FMT_S32 = 2,
    /// <summary>float</summary>
    @AV_SAMPLE_FMT_FLT = 3,
    /// <summary>double</summary>
    @AV_SAMPLE_FMT_DBL = 4,
    /// <summary>unsigned 8 bits, planar</summary>
    @AV_SAMPLE_FMT_U8P = 5,
    /// <summary>signed 16 bits, planar</summary>
    @AV_SAMPLE_FMT_S16P = 6,
    /// <summary>signed 32 bits, planar</summary>
    @AV_SAMPLE_FMT_S32P = 7,
    /// <summary>float, planar</summary>
    @AV_SAMPLE_FMT_FLTP = 8,
    /// <summary>double, planar</summary>
    @AV_SAMPLE_FMT_DBLP = 9,
    /// <summary>signed 64 bits</summary>
    @AV_SAMPLE_FMT_S64 = 10,
    /// <summary>signed 64 bits, planar</summary>
    @AV_SAMPLE_FMT_S64P = 11,
    /// <summary>Number of sample formats. DO NOT USE if linking dynamically</summary>
    @AV_SAMPLE_FMT_NB = 12,
}

public enum _AVSideDataParamChangeFlags : int
{
    @AV_SIDE_DATA_PARAM_CHANGE_SAMPLE_RATE = 4,
    @AV_SIDE_DATA_PARAM_CHANGE_DIMENSIONS = 8,
}

public enum _AVSideDataProps : int
{
    /// <summary>The side data type can be used in stream-global structures. Side data types without this property are only meaningful on per-frame basis.</summary>
    @AV_SIDE_DATA_PROP_GLOBAL = 1,
    /// <summary>Multiple instances of this side data type can be meaningfully present in a single side data array.</summary>
    @AV_SIDE_DATA_PROP_MULTI = 2,
    /// <summary>Side data depends on the video dimensions. Side data with this property loses its meaning when rescaling or cropping the image, unless either recomputed or adjusted to the new resolution.</summary>
    @AV_SIDE_DATA_PROP_SIZE_DEPENDENT = 4,
    /// <summary>Side data depends on the video color space. Side data with this property loses its meaning when changing the video color encoding, e.g. by adapting to a different set of primaries or transfer characteristics.</summary>
    @AV_SIDE_DATA_PROP_COLOR_DEPENDENT = 8,
    /// <summary>Side data depends on the channel layout. Side data with this property loses its meaning when downmixing or upmixing, unless either recomputed or adjusted to the new layout.</summary>
    @AV_SIDE_DATA_PROP_CHANNEL_DEPENDENT = 16,
}

/// <summary>List of possible primary eyes.</summary>
public enum _AVStereo3DPrimaryEye : int
{
    /// <summary>Neither eye.</summary>
    @AV_PRIMARY_EYE_NONE = 0,
    /// <summary>Left eye.</summary>
    @AV_PRIMARY_EYE_LEFT = 1,
    /// <summary>Right eye</summary>
    @AV_PRIMARY_EYE_RIGHT = 2,
}

/// <summary>List of possible 3D Types</summary>
public enum _AVStereo3DType : int
{
    /// <summary>Video is not stereoscopic (and metadata has to be there).</summary>
    @AV_STEREO3D_2D = 0,
    /// <summary>Views are next to each other.</summary>
    @AV_STEREO3D_SIDEBYSIDE = 1,
    /// <summary>Views are on top of each other.</summary>
    @AV_STEREO3D_TOPBOTTOM = 2,
    /// <summary>Views are alternated temporally.</summary>
    @AV_STEREO3D_FRAMESEQUENCE = 3,
    /// <summary>Views are packed in a checkerboard-like structure per pixel.</summary>
    @AV_STEREO3D_CHECKERBOARD = 4,
    /// <summary>Views are next to each other, but when upscaling apply a checkerboard pattern.</summary>
    @AV_STEREO3D_SIDEBYSIDE_QUINCUNX = 5,
    /// <summary>Views are packed per line, as if interlaced.</summary>
    @AV_STEREO3D_LINES = 6,
    /// <summary>Views are packed per column.</summary>
    @AV_STEREO3D_COLUMNS = 7,
    /// <summary>Video is stereoscopic but the packing is unspecified.</summary>
    @AV_STEREO3D_UNSPEC = 8,
}

/// <summary>List of possible view types.</summary>
public enum _AVStereo3DView : int
{
    /// <summary>Frame contains two packed views.</summary>
    @AV_STEREO3D_VIEW_PACKED = 0,
    /// <summary>Frame contains only the left view.</summary>
    @AV_STEREO3D_VIEW_LEFT = 1,
    /// <summary>Frame contains only the right view.</summary>
    @AV_STEREO3D_VIEW_RIGHT = 2,
    /// <summary>Content is unspecified.</summary>
    @AV_STEREO3D_VIEW_UNSPEC = 3,
}

public enum _AVStreamGroupParamsType : int
{
    @AV_STREAM_GROUP_PARAMS_NONE = 0,
    @AV_STREAM_GROUP_PARAMS_IAMF_AUDIO_ELEMENT = 1,
    @AV_STREAM_GROUP_PARAMS_IAMF_MIX_PRESENTATION = 2,
    @AV_STREAM_GROUP_PARAMS_TILE_GRID = 3,
    @AV_STREAM_GROUP_PARAMS_LCEVC = 4,
    @AV_STREAM_GROUP_PARAMS_TREF = 5,
    @AV_STREAM_GROUP_PARAMS_DOLBY_VISION = 6,
}

/// <summary>@}</summary>
public enum _AVStreamParseType : int
{
    @AVSTREAM_PARSE_NONE = 0,
    /// <summary>full parsing and repack</summary>
    @AVSTREAM_PARSE_FULL = 1,
    /// <summary>Only parse headers, do not repack.</summary>
    @AVSTREAM_PARSE_HEADERS = 2,
    /// <summary>full parsing and interpolation of timestamps for frames not starting on a packet boundary</summary>
    @AVSTREAM_PARSE_TIMESTAMPS = 3,
    /// <summary>full parsing and repack of the first frame only, only implemented for H.264 currently</summary>
    @AVSTREAM_PARSE_FULL_ONCE = 4,
    /// <summary>full parsing and repack with timestamp and position generation by parser for raw this assumes that each packet in the file contains no demuxer level headers and just codec level data, otherwise position generation would fail</summary>
    @AVSTREAM_PARSE_FULL_RAW = 5,
}

/// <summary>@}</summary>
public enum _AVSubtitleType : int
{
    @SUBTITLE_NONE = 0,
    /// <summary>A bitmap, pict will be set</summary>
    @SUBTITLE_BITMAP = 1,
    /// <summary>Plain text, the text field must be set by the decoder and is authoritative. ass and pict fields may contain approximations.</summary>
    @SUBTITLE_TEXT = 2,
    /// <summary>Formatted text, the ass field must be set by the decoder and is authoritative. pict and text fields may contain approximations.</summary>
    @SUBTITLE_ASS = 3,
}

public enum _AVTimecodeFlag : int
{
    /// <summary>timecode is drop frame</summary>
    @AV_TIMECODE_FLAG_DROPFRAME = 1,
    /// <summary>timecode wraps after 24 hours</summary>
    @AV_TIMECODE_FLAG_24HOURSMAX = 2,
    /// <summary>negative time values are allowed</summary>
    @AV_TIMECODE_FLAG_ALLOWNEGATIVE = 4,
}

/// <summary>Defines the behaviour of frame allocation.</summary>
public enum _AVVkFrameFlags : int
{
    @AV_VK_FRAME_FLAG_NONE = 1,
    @AV_VK_FRAME_FLAG_DISABLE_MULTIPLANE = 4,
}

public enum _D3D12_HEAP_FLAGS : int
{
    @D3D12_HEAP_FLAG_NONE = 0,
    @D3D12_HEAP_FLAG_SHARED = 1,
    @D3D12_HEAP_FLAG_DENY_BUFFERS = 4,
    @D3D12_HEAP_FLAG_ALLOW_DISPLAY = 8,
    @D3D12_HEAP_FLAG_SHARED_CROSS_ADAPTER = 32,
    @D3D12_HEAP_FLAG_DENY_RT_DS_TEXTURES = 64,
    @D3D12_HEAP_FLAG_DENY_NON_RT_DS_TEXTURES = 128,
    @D3D12_HEAP_FLAG_HARDWARE_PROTECTED = 256,
    @D3D12_HEAP_FLAG_ALLOW_WRITE_WATCH = 512,
    @D3D12_HEAP_FLAG_ALLOW_SHADER_ATOMICS = 1024,
    @D3D12_HEAP_FLAG_CREATE_NOT_RESIDENT = 2048,
    @D3D12_HEAP_FLAG_CREATE_NOT_ZEROED = 4096,
    @D3D12_HEAP_FLAG_TOOLS_USE_MANUAL_WRITE_TRACKING = 8192,
    @D3D12_HEAP_FLAG_ALLOW_ALL_BUFFERS_AND_TEXTURES = 0,
    @D3D12_HEAP_FLAG_ALLOW_ONLY_BUFFERS = 192,
    @D3D12_HEAP_FLAG_ALLOW_ONLY_NON_RT_DS_TEXTURES = 68,
    @D3D12_HEAP_FLAG_ALLOW_ONLY_RT_DS_TEXTURES = 132,
}

public enum _D3D12_RESOURCE_FLAGS : int
{
    @D3D12_RESOURCE_FLAG_NONE = 0,
    @D3D12_RESOURCE_FLAG_ALLOW_RENDER_TARGET = 1,
    @D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL = 2,
    @D3D12_RESOURCE_FLAG_ALLOW_UNORDERED_ACCESS = 4,
    @D3D12_RESOURCE_FLAG_DENY_SHADER_RESOURCE = 8,
    @D3D12_RESOURCE_FLAG_ALLOW_CROSS_ADAPTER = 16,
    @D3D12_RESOURCE_FLAG_ALLOW_SIMULTANEOUS_ACCESS = 32,
    @D3D12_RESOURCE_FLAG_VIDEO_DECODE_REFERENCE_ONLY = 64,
    @D3D12_RESOURCE_FLAG_VIDEO_ENCODE_REFERENCE_ONLY = 128,
    @D3D12_RESOURCE_FLAG_RAYTRACING_ACCELERATION_STRUCTURE = 256,
}

public enum _DXGI_FORMAT : int
{
    @DXGI_FORMAT_UNKNOWN = 0,
    @DXGI_FORMAT_R32G32B32A32_TYPELESS = 1,
    @DXGI_FORMAT_R32G32B32A32_FLOAT = 2,
    @DXGI_FORMAT_R32G32B32A32_UINT = 3,
    @DXGI_FORMAT_R32G32B32A32_SINT = 4,
    @DXGI_FORMAT_R32G32B32_TYPELESS = 5,
    @DXGI_FORMAT_R32G32B32_FLOAT = 6,
    @DXGI_FORMAT_R32G32B32_UINT = 7,
    @DXGI_FORMAT_R32G32B32_SINT = 8,
    @DXGI_FORMAT_R16G16B16A16_TYPELESS = 9,
    @DXGI_FORMAT_R16G16B16A16_FLOAT = 10,
    @DXGI_FORMAT_R16G16B16A16_UNORM = 11,
    @DXGI_FORMAT_R16G16B16A16_UINT = 12,
    @DXGI_FORMAT_R16G16B16A16_SNORM = 13,
    @DXGI_FORMAT_R16G16B16A16_SINT = 14,
    @DXGI_FORMAT_R32G32_TYPELESS = 15,
    @DXGI_FORMAT_R32G32_FLOAT = 16,
    @DXGI_FORMAT_R32G32_UINT = 17,
    @DXGI_FORMAT_R32G32_SINT = 18,
    @DXGI_FORMAT_R32G8X24_TYPELESS = 19,
    @DXGI_FORMAT_D32_FLOAT_S8X24_UINT = 20,
    @DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS = 21,
    @DXGI_FORMAT_X32_TYPELESS_G8X24_UINT = 22,
    @DXGI_FORMAT_R10G10B10A2_TYPELESS = 23,
    @DXGI_FORMAT_R10G10B10A2_UNORM = 24,
    @DXGI_FORMAT_R10G10B10A2_UINT = 25,
    @DXGI_FORMAT_R11G11B10_FLOAT = 26,
    @DXGI_FORMAT_R8G8B8A8_TYPELESS = 27,
    @DXGI_FORMAT_R8G8B8A8_UNORM = 28,
    @DXGI_FORMAT_R8G8B8A8_UNORM_SRGB = 29,
    @DXGI_FORMAT_R8G8B8A8_UINT = 30,
    @DXGI_FORMAT_R8G8B8A8_SNORM = 31,
    @DXGI_FORMAT_R8G8B8A8_SINT = 32,
    @DXGI_FORMAT_R16G16_TYPELESS = 33,
    @DXGI_FORMAT_R16G16_FLOAT = 34,
    @DXGI_FORMAT_R16G16_UNORM = 35,
    @DXGI_FORMAT_R16G16_UINT = 36,
    @DXGI_FORMAT_R16G16_SNORM = 37,
    @DXGI_FORMAT_R16G16_SINT = 38,
    @DXGI_FORMAT_R32_TYPELESS = 39,
    @DXGI_FORMAT_D32_FLOAT = 40,
    @DXGI_FORMAT_R32_FLOAT = 41,
    @DXGI_FORMAT_R32_UINT = 42,
    @DXGI_FORMAT_R32_SINT = 43,
    @DXGI_FORMAT_R24G8_TYPELESS = 44,
    @DXGI_FORMAT_D24_UNORM_S8_UINT = 45,
    @DXGI_FORMAT_R24_UNORM_X8_TYPELESS = 46,
    @DXGI_FORMAT_X24_TYPELESS_G8_UINT = 47,
    @DXGI_FORMAT_R8G8_TYPELESS = 48,
    @DXGI_FORMAT_R8G8_UNORM = 49,
    @DXGI_FORMAT_R8G8_UINT = 50,
    @DXGI_FORMAT_R8G8_SNORM = 51,
    @DXGI_FORMAT_R8G8_SINT = 52,
    @DXGI_FORMAT_R16_TYPELESS = 53,
    @DXGI_FORMAT_R16_FLOAT = 54,
    @DXGI_FORMAT_D16_UNORM = 55,
    @DXGI_FORMAT_R16_UNORM = 56,
    @DXGI_FORMAT_R16_UINT = 57,
    @DXGI_FORMAT_R16_SNORM = 58,
    @DXGI_FORMAT_R16_SINT = 59,
    @DXGI_FORMAT_R8_TYPELESS = 60,
    @DXGI_FORMAT_R8_UNORM = 61,
    @DXGI_FORMAT_R8_UINT = 62,
    @DXGI_FORMAT_R8_SNORM = 63,
    @DXGI_FORMAT_R8_SINT = 64,
    @DXGI_FORMAT_A8_UNORM = 65,
    @DXGI_FORMAT_R1_UNORM = 66,
    @DXGI_FORMAT_R9G9B9E5_SHAREDEXP = 67,
    @DXGI_FORMAT_R8G8_B8G8_UNORM = 68,
    @DXGI_FORMAT_G8R8_G8B8_UNORM = 69,
    @DXGI_FORMAT_BC1_TYPELESS = 70,
    @DXGI_FORMAT_BC1_UNORM = 71,
    @DXGI_FORMAT_BC1_UNORM_SRGB = 72,
    @DXGI_FORMAT_BC2_TYPELESS = 73,
    @DXGI_FORMAT_BC2_UNORM = 74,
    @DXGI_FORMAT_BC2_UNORM_SRGB = 75,
    @DXGI_FORMAT_BC3_TYPELESS = 76,
    @DXGI_FORMAT_BC3_UNORM = 77,
    @DXGI_FORMAT_BC3_UNORM_SRGB = 78,
    @DXGI_FORMAT_BC4_TYPELESS = 79,
    @DXGI_FORMAT_BC4_UNORM = 80,
    @DXGI_FORMAT_BC4_SNORM = 81,
    @DXGI_FORMAT_BC5_TYPELESS = 82,
    @DXGI_FORMAT_BC5_UNORM = 83,
    @DXGI_FORMAT_BC5_SNORM = 84,
    @DXGI_FORMAT_B5G6R5_UNORM = 85,
    @DXGI_FORMAT_B5G5R5A1_UNORM = 86,
    @DXGI_FORMAT_B8G8R8A8_UNORM = 87,
    @DXGI_FORMAT_B8G8R8X8_UNORM = 88,
    @DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM = 89,
    @DXGI_FORMAT_B8G8R8A8_TYPELESS = 90,
    @DXGI_FORMAT_B8G8R8A8_UNORM_SRGB = 91,
    @DXGI_FORMAT_B8G8R8X8_TYPELESS = 92,
    @DXGI_FORMAT_B8G8R8X8_UNORM_SRGB = 93,
    @DXGI_FORMAT_BC6H_TYPELESS = 94,
    @DXGI_FORMAT_BC6H_UF16 = 95,
    @DXGI_FORMAT_BC6H_SF16 = 96,
    @DXGI_FORMAT_BC7_TYPELESS = 97,
    @DXGI_FORMAT_BC7_UNORM = 98,
    @DXGI_FORMAT_BC7_UNORM_SRGB = 99,
    @DXGI_FORMAT_AYUV = 100,
    @DXGI_FORMAT_Y410 = 101,
    @DXGI_FORMAT_Y416 = 102,
    @DXGI_FORMAT_NV12 = 103,
    @DXGI_FORMAT_P010 = 104,
    @DXGI_FORMAT_P016 = 105,
    @DXGI_FORMAT_420_OPAQUE = 106,
    @DXGI_FORMAT_YUY2 = 107,
    @DXGI_FORMAT_Y210 = 108,
    @DXGI_FORMAT_Y216 = 109,
    @DXGI_FORMAT_NV11 = 110,
    @DXGI_FORMAT_AI44 = 111,
    @DXGI_FORMAT_IA44 = 112,
    @DXGI_FORMAT_P8 = 113,
    @DXGI_FORMAT_A8P8 = 114,
    @DXGI_FORMAT_B4G4R4A4_UNORM = 115,
    @DXGI_FORMAT_P208 = 130,
    @DXGI_FORMAT_V208 = 131,
    @DXGI_FORMAT_V408 = 132,
    @DXGI_FORMAT_SAMPLER_FEEDBACK_MIN_MIP_OPAQUE = 189,
    @DXGI_FORMAT_SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE = 190,
    @DXGI_FORMAT_A4B4G4R4_UNORM = 191,
    @DXGI_FORMAT_FORCE_UINT = -1,
}

/// <summary>Dithering algorithms</summary>
public enum _SwrDitherType : int
{
    @SWR_DITHER_NONE = 0,
    @SWR_DITHER_RECTANGULAR = 1,
    @SWR_DITHER_TRIANGULAR = 2,
    @SWR_DITHER_TRIANGULAR_HIGHPASS = 3,
    /// <summary>not part of API/ABI</summary>
    @SWR_DITHER_NS = 64,
    @SWR_DITHER_NS_LIPSHITZ = 65,
    @SWR_DITHER_NS_F_WEIGHTED = 66,
    @SWR_DITHER_NS_MODIFIED_E_WEIGHTED = 67,
    @SWR_DITHER_NS_IMPROVED_E_WEIGHTED = 68,
    @SWR_DITHER_NS_SHIBATA = 69,
    @SWR_DITHER_NS_LOW_SHIBATA = 70,
    @SWR_DITHER_NS_HIGH_SHIBATA = 71,
    /// <summary>not part of API/ABI</summary>
    @SWR_DITHER_NB = 72,
}

/// <summary>Resampling Engines</summary>
public enum _SwrEngine : int
{
    /// <summary>SW Resampler</summary>
    @SWR_ENGINE_SWR = 0,
    /// <summary>SoX Resampler</summary>
    @SWR_ENGINE_SOXR = 1,
    /// <summary>not part of API/ABI</summary>
    @SWR_ENGINE_NB = 2,
}

/// <summary>Resampling Filter Types</summary>
public enum _SwrFilterType : int
{
    /// <summary>Cubic</summary>
    @SWR_FILTER_TYPE_CUBIC = 0,
    /// <summary>Blackman Nuttall windowed sinc</summary>
    @SWR_FILTER_TYPE_BLACKMAN_NUTTALL = 1,
    /// <summary>Kaiser windowed sinc</summary>
    @SWR_FILTER_TYPE_KAISER = 2,
}

public enum _SwsAlphaBlend : int
{
    @SWS_ALPHA_BLEND_NONE = 0,
    @SWS_ALPHA_BLEND_UNIFORM = 1,
    @SWS_ALPHA_BLEND_CHECKERBOARD = 2,
    @SWS_ALPHA_BLEND_NB = 3,
    @SWS_ALPHA_BLEND_MAX_ENUM = 2147483647,
}

public enum _SwsBackend : int
{
    /// <summary>Legacy bespoke format-specific code</summary>
    @SWS_BACKEND_LEGACY = 1,
    @SWS_BACKEND_STABLE = 1,
    /// <summary>Template-based C reference implementation</summary>
    @SWS_BACKEND_C = 2,
    /// <summary>Fast path using libc memcpy() / memset()</summary>
    @SWS_BACKEND_MEMCPY = 4,
    /// <summary>Chained x86 SIMD kernels</summary>
    @SWS_BACKEND_X86 = 8,
    /// <summary>Chained AArch64 NEON kernels</summary>
    @SWS_BACKEND_AARCH64 = 16,
    /// <summary>Vulkan SPIR-V backend</summary>
    @SWS_BACKEND_SPIRV = 32,
    @SWS_BACKEND_UNSTABLE = 62,
    @SWS_BACKEND_ALL = 63,
    /// <summary>force size to 32 bits, not a valid backend</summary>
    @SWS_BACKEND_MAX_ENUM = 2147483647,
}

/// <summary>**************************** Flags and quality settings * ****************************</summary>
public enum _SwsDither : int
{
    @SWS_DITHER_NONE = 0,
    @SWS_DITHER_AUTO = 1,
    @SWS_DITHER_BAYER = 2,
    @SWS_DITHER_ED = 3,
    @SWS_DITHER_A_DITHER = 4,
    @SWS_DITHER_X_DITHER = 5,
    @SWS_DITHER_NB = 6,
    @SWS_DITHER_MAX_ENUM = 2147483647,
}

public enum _SwsFlags : int
{
    /// <summary>Return an error on underspecified conversions. Without this flag, unspecified fields are defaulted to sensible values.</summary>
    @SWS_STRICT = 2048,
    /// <summary>Emit verbose log of scaling parameters.</summary>
    @SWS_PRINT_INFO = 4096,
    /// <summary>Perform full chroma upsampling when upscaling to RGB.</summary>
    @SWS_FULL_CHR_H_INT = 8192,
    /// <summary>Perform full chroma interpolation when downscaling RGB sources.</summary>
    @SWS_FULL_CHR_H_INP = 16384,
    /// <summary>Force bit-exact output. This will prevent the use of platform-specific optimizations that may lead to slight difference in rounding, in favor of always maintaining exact bit output compatibility with the reference C code.</summary>
    @SWS_ACCURATE_RND = 262144,
    /// <summary>Force bit-exact output. This will prevent the use of platform-specific optimizations that may lead to slight difference in rounding, in favor of always maintaining exact bit output compatibility with the reference C code.</summary>
    @SWS_BITEXACT = 524288,
    /// <summary>Allow/prefer using experimental new code paths. This may be faster, slower, or produce different output, with semantics subject to change at any point in time. For testing and debugging purposes only.</summary>
    @SWS_UNSTABLE = 1048576,
    /// <summary>This flag has no effect</summary>
    @SWS_DIRECT_BGR = 32768,
    /// <summary>Set `SwsContext.dither` instead</summary>
    @SWS_ERROR_DIFFUSION = 8388608,
    /// <summary>fast bilinear filtering</summary>
    @SWS_FAST_BILINEAR = 1,
    /// <summary>bilinear filtering</summary>
    @SWS_BILINEAR = 2,
    /// <summary>2-tap cubic B-spline</summary>
    @SWS_BICUBIC = 4,
    /// <summary>experimental</summary>
    @SWS_X = 8,
    /// <summary>nearest neighbor</summary>
    @SWS_POINT = 16,
    /// <summary>area averaging</summary>
    @SWS_AREA = 32,
    /// <summary>bicubic luma, bilinear chroma</summary>
    @SWS_BICUBLIN = 64,
    /// <summary>gaussian approximation</summary>
    @SWS_GAUSS = 128,
    /// <summary>unwindowed sinc</summary>
    @SWS_SINC = 256,
    /// <summary>3-tap sinc/sinc</summary>
    @SWS_LANCZOS = 512,
    /// <summary>unwindowed natural cubic spline</summary>
    @SWS_SPLINE = 1024,
}

public enum _SwsIntent : int
{
    /// <summary>Perceptual tone mapping</summary>
    @SWS_INTENT_PERCEPTUAL = 0,
    /// <summary>Relative colorimetric clipping</summary>
    @SWS_INTENT_RELATIVE_COLORIMETRIC = 1,
    /// <summary>Saturation mapping</summary>
    @SWS_INTENT_SATURATION = 2,
    /// <summary>Absolute colorimetric clipping</summary>
    @SWS_INTENT_ABSOLUTE_COLORIMETRIC = 3,
    /// <summary>not part of the ABI</summary>
    @SWS_INTENT_NB = 4,
}

public enum _SwsScaler : int
{
    @SWS_SCALE_AUTO = 0,
    /// <summary>bilinear filtering</summary>
    @SWS_SCALE_BILINEAR = 1,
    /// <summary>2-tap cubic BC-spline</summary>
    @SWS_SCALE_BICUBIC = 2,
    /// <summary>nearest neighbor (point sampling)</summary>
    @SWS_SCALE_POINT = 3,
    /// <summary>area averaging</summary>
    @SWS_SCALE_AREA = 4,
    /// <summary>2-tap gaussian approximation</summary>
    @SWS_SCALE_GAUSSIAN = 5,
    /// <summary>unwindowed sinc</summary>
    @SWS_SCALE_SINC = 6,
    /// <summary>3-tap sinc/sinc</summary>
    @SWS_SCALE_LANCZOS = 7,
    /// <summary>unwindowned natural cubic spline</summary>
    @SWS_SCALE_SPLINE = 8,
    /// <summary>not part of the ABI</summary>
    @SWS_SCALE_NB = 9,
    /// <summary>force size to 32 bits, not a valid filter type</summary>
    @SWS_SCALE_MAX_ENUM = 2147483647,
}

public enum _VkFormat : int
{
    @VK_FORMAT_UNDEFINED = 0,
    @VK_FORMAT_R4G4_UNORM_PACK8 = 1,
    @VK_FORMAT_R4G4B4A4_UNORM_PACK16 = 2,
    @VK_FORMAT_B4G4R4A4_UNORM_PACK16 = 3,
    @VK_FORMAT_R5G6B5_UNORM_PACK16 = 4,
    @VK_FORMAT_B5G6R5_UNORM_PACK16 = 5,
    @VK_FORMAT_R5G5B5A1_UNORM_PACK16 = 6,
    @VK_FORMAT_B5G5R5A1_UNORM_PACK16 = 7,
    @VK_FORMAT_A1R5G5B5_UNORM_PACK16 = 8,
    @VK_FORMAT_R8_UNORM = 9,
    @VK_FORMAT_R8_SNORM = 10,
    @VK_FORMAT_R8_USCALED = 11,
    @VK_FORMAT_R8_SSCALED = 12,
    @VK_FORMAT_R8_UINT = 13,
    @VK_FORMAT_R8_SINT = 14,
    @VK_FORMAT_R8_SRGB = 15,
    @VK_FORMAT_R8G8_UNORM = 16,
    @VK_FORMAT_R8G8_SNORM = 17,
    @VK_FORMAT_R8G8_USCALED = 18,
    @VK_FORMAT_R8G8_SSCALED = 19,
    @VK_FORMAT_R8G8_UINT = 20,
    @VK_FORMAT_R8G8_SINT = 21,
    @VK_FORMAT_R8G8_SRGB = 22,
    @VK_FORMAT_R8G8B8_UNORM = 23,
    @VK_FORMAT_R8G8B8_SNORM = 24,
    @VK_FORMAT_R8G8B8_USCALED = 25,
    @VK_FORMAT_R8G8B8_SSCALED = 26,
    @VK_FORMAT_R8G8B8_UINT = 27,
    @VK_FORMAT_R8G8B8_SINT = 28,
    @VK_FORMAT_R8G8B8_SRGB = 29,
    @VK_FORMAT_B8G8R8_UNORM = 30,
    @VK_FORMAT_B8G8R8_SNORM = 31,
    @VK_FORMAT_B8G8R8_USCALED = 32,
    @VK_FORMAT_B8G8R8_SSCALED = 33,
    @VK_FORMAT_B8G8R8_UINT = 34,
    @VK_FORMAT_B8G8R8_SINT = 35,
    @VK_FORMAT_B8G8R8_SRGB = 36,
    @VK_FORMAT_R8G8B8A8_UNORM = 37,
    @VK_FORMAT_R8G8B8A8_SNORM = 38,
    @VK_FORMAT_R8G8B8A8_USCALED = 39,
    @VK_FORMAT_R8G8B8A8_SSCALED = 40,
    @VK_FORMAT_R8G8B8A8_UINT = 41,
    @VK_FORMAT_R8G8B8A8_SINT = 42,
    @VK_FORMAT_R8G8B8A8_SRGB = 43,
    @VK_FORMAT_B8G8R8A8_UNORM = 44,
    @VK_FORMAT_B8G8R8A8_SNORM = 45,
    @VK_FORMAT_B8G8R8A8_USCALED = 46,
    @VK_FORMAT_B8G8R8A8_SSCALED = 47,
    @VK_FORMAT_B8G8R8A8_UINT = 48,
    @VK_FORMAT_B8G8R8A8_SINT = 49,
    @VK_FORMAT_B8G8R8A8_SRGB = 50,
    @VK_FORMAT_A8B8G8R8_UNORM_PACK32 = 51,
    @VK_FORMAT_A8B8G8R8_SNORM_PACK32 = 52,
    @VK_FORMAT_A8B8G8R8_USCALED_PACK32 = 53,
    @VK_FORMAT_A8B8G8R8_SSCALED_PACK32 = 54,
    @VK_FORMAT_A8B8G8R8_UINT_PACK32 = 55,
    @VK_FORMAT_A8B8G8R8_SINT_PACK32 = 56,
    @VK_FORMAT_A8B8G8R8_SRGB_PACK32 = 57,
    @VK_FORMAT_A2R10G10B10_UNORM_PACK32 = 58,
    @VK_FORMAT_A2R10G10B10_SNORM_PACK32 = 59,
    @VK_FORMAT_A2R10G10B10_USCALED_PACK32 = 60,
    @VK_FORMAT_A2R10G10B10_SSCALED_PACK32 = 61,
    @VK_FORMAT_A2R10G10B10_UINT_PACK32 = 62,
    @VK_FORMAT_A2R10G10B10_SINT_PACK32 = 63,
    @VK_FORMAT_A2B10G10R10_UNORM_PACK32 = 64,
    @VK_FORMAT_A2B10G10R10_SNORM_PACK32 = 65,
    @VK_FORMAT_A2B10G10R10_USCALED_PACK32 = 66,
    @VK_FORMAT_A2B10G10R10_SSCALED_PACK32 = 67,
    @VK_FORMAT_A2B10G10R10_UINT_PACK32 = 68,
    @VK_FORMAT_A2B10G10R10_SINT_PACK32 = 69,
    @VK_FORMAT_R16_UNORM = 70,
    @VK_FORMAT_R16_SNORM = 71,
    @VK_FORMAT_R16_USCALED = 72,
    @VK_FORMAT_R16_SSCALED = 73,
    @VK_FORMAT_R16_UINT = 74,
    @VK_FORMAT_R16_SINT = 75,
    @VK_FORMAT_R16_SFLOAT = 76,
    @VK_FORMAT_R16G16_UNORM = 77,
    @VK_FORMAT_R16G16_SNORM = 78,
    @VK_FORMAT_R16G16_USCALED = 79,
    @VK_FORMAT_R16G16_SSCALED = 80,
    @VK_FORMAT_R16G16_UINT = 81,
    @VK_FORMAT_R16G16_SINT = 82,
    @VK_FORMAT_R16G16_SFLOAT = 83,
    @VK_FORMAT_R16G16B16_UNORM = 84,
    @VK_FORMAT_R16G16B16_SNORM = 85,
    @VK_FORMAT_R16G16B16_USCALED = 86,
    @VK_FORMAT_R16G16B16_SSCALED = 87,
    @VK_FORMAT_R16G16B16_UINT = 88,
    @VK_FORMAT_R16G16B16_SINT = 89,
    @VK_FORMAT_R16G16B16_SFLOAT = 90,
    @VK_FORMAT_R16G16B16A16_UNORM = 91,
    @VK_FORMAT_R16G16B16A16_SNORM = 92,
    @VK_FORMAT_R16G16B16A16_USCALED = 93,
    @VK_FORMAT_R16G16B16A16_SSCALED = 94,
    @VK_FORMAT_R16G16B16A16_UINT = 95,
    @VK_FORMAT_R16G16B16A16_SINT = 96,
    @VK_FORMAT_R16G16B16A16_SFLOAT = 97,
    @VK_FORMAT_R32_UINT = 98,
    @VK_FORMAT_R32_SINT = 99,
    @VK_FORMAT_R32_SFLOAT = 100,
    @VK_FORMAT_R32G32_UINT = 101,
    @VK_FORMAT_R32G32_SINT = 102,
    @VK_FORMAT_R32G32_SFLOAT = 103,
    @VK_FORMAT_R32G32B32_UINT = 104,
    @VK_FORMAT_R32G32B32_SINT = 105,
    @VK_FORMAT_R32G32B32_SFLOAT = 106,
    @VK_FORMAT_R32G32B32A32_UINT = 107,
    @VK_FORMAT_R32G32B32A32_SINT = 108,
    @VK_FORMAT_R32G32B32A32_SFLOAT = 109,
    @VK_FORMAT_R64_UINT = 110,
    @VK_FORMAT_R64_SINT = 111,
    @VK_FORMAT_R64_SFLOAT = 112,
    @VK_FORMAT_R64G64_UINT = 113,
    @VK_FORMAT_R64G64_SINT = 114,
    @VK_FORMAT_R64G64_SFLOAT = 115,
    @VK_FORMAT_R64G64B64_UINT = 116,
    @VK_FORMAT_R64G64B64_SINT = 117,
    @VK_FORMAT_R64G64B64_SFLOAT = 118,
    @VK_FORMAT_R64G64B64A64_UINT = 119,
    @VK_FORMAT_R64G64B64A64_SINT = 120,
    @VK_FORMAT_R64G64B64A64_SFLOAT = 121,
    @VK_FORMAT_B10G11R11_UFLOAT_PACK32 = 122,
    @VK_FORMAT_E5B9G9R9_UFLOAT_PACK32 = 123,
    @VK_FORMAT_D16_UNORM = 124,
    @VK_FORMAT_X8_D24_UNORM_PACK32 = 125,
    @VK_FORMAT_D32_SFLOAT = 126,
    @VK_FORMAT_S8_UINT = 127,
    @VK_FORMAT_D16_UNORM_S8_UINT = 128,
    @VK_FORMAT_D24_UNORM_S8_UINT = 129,
    @VK_FORMAT_D32_SFLOAT_S8_UINT = 130,
    @VK_FORMAT_BC1_RGB_UNORM_BLOCK = 131,
    @VK_FORMAT_BC1_RGB_SRGB_BLOCK = 132,
    @VK_FORMAT_BC1_RGBA_UNORM_BLOCK = 133,
    @VK_FORMAT_BC1_RGBA_SRGB_BLOCK = 134,
    @VK_FORMAT_BC2_UNORM_BLOCK = 135,
    @VK_FORMAT_BC2_SRGB_BLOCK = 136,
    @VK_FORMAT_BC3_UNORM_BLOCK = 137,
    @VK_FORMAT_BC3_SRGB_BLOCK = 138,
    @VK_FORMAT_BC4_UNORM_BLOCK = 139,
    @VK_FORMAT_BC4_SNORM_BLOCK = 140,
    @VK_FORMAT_BC5_UNORM_BLOCK = 141,
    @VK_FORMAT_BC5_SNORM_BLOCK = 142,
    @VK_FORMAT_BC6H_UFLOAT_BLOCK = 143,
    @VK_FORMAT_BC6H_SFLOAT_BLOCK = 144,
    @VK_FORMAT_BC7_UNORM_BLOCK = 145,
    @VK_FORMAT_BC7_SRGB_BLOCK = 146,
    @VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK = 147,
    @VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK = 148,
    @VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK = 149,
    @VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK = 150,
    @VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK = 151,
    @VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK = 152,
    @VK_FORMAT_EAC_R11_UNORM_BLOCK = 153,
    @VK_FORMAT_EAC_R11_SNORM_BLOCK = 154,
    @VK_FORMAT_EAC_R11G11_UNORM_BLOCK = 155,
    @VK_FORMAT_EAC_R11G11_SNORM_BLOCK = 156,
    @VK_FORMAT_ASTC_4x4_UNORM_BLOCK = 157,
    @VK_FORMAT_ASTC_4x4_SRGB_BLOCK = 158,
    @VK_FORMAT_ASTC_5x4_UNORM_BLOCK = 159,
    @VK_FORMAT_ASTC_5x4_SRGB_BLOCK = 160,
    @VK_FORMAT_ASTC_5x5_UNORM_BLOCK = 161,
    @VK_FORMAT_ASTC_5x5_SRGB_BLOCK = 162,
    @VK_FORMAT_ASTC_6x5_UNORM_BLOCK = 163,
    @VK_FORMAT_ASTC_6x5_SRGB_BLOCK = 164,
    @VK_FORMAT_ASTC_6x6_UNORM_BLOCK = 165,
    @VK_FORMAT_ASTC_6x6_SRGB_BLOCK = 166,
    @VK_FORMAT_ASTC_8x5_UNORM_BLOCK = 167,
    @VK_FORMAT_ASTC_8x5_SRGB_BLOCK = 168,
    @VK_FORMAT_ASTC_8x6_UNORM_BLOCK = 169,
    @VK_FORMAT_ASTC_8x6_SRGB_BLOCK = 170,
    @VK_FORMAT_ASTC_8x8_UNORM_BLOCK = 171,
    @VK_FORMAT_ASTC_8x8_SRGB_BLOCK = 172,
    @VK_FORMAT_ASTC_10x5_UNORM_BLOCK = 173,
    @VK_FORMAT_ASTC_10x5_SRGB_BLOCK = 174,
    @VK_FORMAT_ASTC_10x6_UNORM_BLOCK = 175,
    @VK_FORMAT_ASTC_10x6_SRGB_BLOCK = 176,
    @VK_FORMAT_ASTC_10x8_UNORM_BLOCK = 177,
    @VK_FORMAT_ASTC_10x8_SRGB_BLOCK = 178,
    @VK_FORMAT_ASTC_10x10_UNORM_BLOCK = 179,
    @VK_FORMAT_ASTC_10x10_SRGB_BLOCK = 180,
    @VK_FORMAT_ASTC_12x10_UNORM_BLOCK = 181,
    @VK_FORMAT_ASTC_12x10_SRGB_BLOCK = 182,
    @VK_FORMAT_ASTC_12x12_UNORM_BLOCK = 183,
    @VK_FORMAT_ASTC_12x12_SRGB_BLOCK = 184,
    @VK_FORMAT_G8B8G8R8_422_UNORM = 1000156000,
    @VK_FORMAT_B8G8R8G8_422_UNORM = 1000156001,
    @VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM = 1000156002,
    @VK_FORMAT_G8_B8R8_2PLANE_420_UNORM = 1000156003,
    @VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM = 1000156004,
    @VK_FORMAT_G8_B8R8_2PLANE_422_UNORM = 1000156005,
    @VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM = 1000156006,
    @VK_FORMAT_R10X6_UNORM_PACK16 = 1000156007,
    @VK_FORMAT_R10X6G10X6_UNORM_2PACK16 = 1000156008,
    @VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16 = 1000156009,
    @VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16 = 1000156010,
    @VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16 = 1000156011,
    @VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16 = 1000156012,
    @VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16 = 1000156013,
    @VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16 = 1000156014,
    @VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16 = 1000156015,
    @VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16 = 1000156016,
    @VK_FORMAT_R12X4_UNORM_PACK16 = 1000156017,
    @VK_FORMAT_R12X4G12X4_UNORM_2PACK16 = 1000156018,
    @VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16 = 1000156019,
    @VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16 = 1000156020,
    @VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16 = 1000156021,
    @VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16 = 1000156022,
    @VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16 = 1000156023,
    @VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16 = 1000156024,
    @VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16 = 1000156025,
    @VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16 = 1000156026,
    @VK_FORMAT_G16B16G16R16_422_UNORM = 1000156027,
    @VK_FORMAT_B16G16R16G16_422_UNORM = 1000156028,
    @VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM = 1000156029,
    @VK_FORMAT_G16_B16R16_2PLANE_420_UNORM = 1000156030,
    @VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM = 1000156031,
    @VK_FORMAT_G16_B16R16_2PLANE_422_UNORM = 1000156032,
    @VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM = 1000156033,
    @VK_FORMAT_G8_B8R8_2PLANE_444_UNORM = 1000330000,
    @VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16 = 1000330001,
    @VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16 = 1000330002,
    @VK_FORMAT_G16_B16R16_2PLANE_444_UNORM = 1000330003,
    @VK_FORMAT_A4R4G4B4_UNORM_PACK16 = 1000340000,
    @VK_FORMAT_A4B4G4R4_UNORM_PACK16 = 1000340001,
    @VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK = 1000066000,
    @VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK = 1000066001,
    @VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK = 1000066002,
    @VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK = 1000066003,
    @VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK = 1000066004,
    @VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK = 1000066005,
    @VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK = 1000066006,
    @VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK = 1000066007,
    @VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK = 1000066008,
    @VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK = 1000066009,
    @VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK = 1000066010,
    @VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK = 1000066011,
    @VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK = 1000066012,
    @VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK = 1000066013,
    @VK_FORMAT_A1B5G5R5_UNORM_PACK16 = 1000470000,
    @VK_FORMAT_A8_UNORM = 1000470001,
    @VK_FORMAT_PVRTC1_2BPP_UNORM_BLOCK_IMG = 1000054000,
    @VK_FORMAT_PVRTC1_4BPP_UNORM_BLOCK_IMG = 1000054001,
    @VK_FORMAT_PVRTC2_2BPP_UNORM_BLOCK_IMG = 1000054002,
    @VK_FORMAT_PVRTC2_4BPP_UNORM_BLOCK_IMG = 1000054003,
    @VK_FORMAT_PVRTC1_2BPP_SRGB_BLOCK_IMG = 1000054004,
    @VK_FORMAT_PVRTC1_4BPP_SRGB_BLOCK_IMG = 1000054005,
    @VK_FORMAT_PVRTC2_2BPP_SRGB_BLOCK_IMG = 1000054006,
    @VK_FORMAT_PVRTC2_4BPP_SRGB_BLOCK_IMG = 1000054007,
    @VK_FORMAT_ASTC_3x3x3_UNORM_BLOCK_EXT = 1000288000,
    @VK_FORMAT_ASTC_3x3x3_SRGB_BLOCK_EXT = 1000288001,
    @VK_FORMAT_ASTC_3x3x3_SFLOAT_BLOCK_EXT = 1000288002,
    @VK_FORMAT_ASTC_4x3x3_UNORM_BLOCK_EXT = 1000288003,
    @VK_FORMAT_ASTC_4x3x3_SRGB_BLOCK_EXT = 1000288004,
    @VK_FORMAT_ASTC_4x3x3_SFLOAT_BLOCK_EXT = 1000288005,
    @VK_FORMAT_ASTC_4x4x3_UNORM_BLOCK_EXT = 1000288006,
    @VK_FORMAT_ASTC_4x4x3_SRGB_BLOCK_EXT = 1000288007,
    @VK_FORMAT_ASTC_4x4x3_SFLOAT_BLOCK_EXT = 1000288008,
    @VK_FORMAT_ASTC_4x4x4_UNORM_BLOCK_EXT = 1000288009,
    @VK_FORMAT_ASTC_4x4x4_SRGB_BLOCK_EXT = 1000288010,
    @VK_FORMAT_ASTC_4x4x4_SFLOAT_BLOCK_EXT = 1000288011,
    @VK_FORMAT_ASTC_5x4x4_UNORM_BLOCK_EXT = 1000288012,
    @VK_FORMAT_ASTC_5x4x4_SRGB_BLOCK_EXT = 1000288013,
    @VK_FORMAT_ASTC_5x4x4_SFLOAT_BLOCK_EXT = 1000288014,
    @VK_FORMAT_ASTC_5x5x4_UNORM_BLOCK_EXT = 1000288015,
    @VK_FORMAT_ASTC_5x5x4_SRGB_BLOCK_EXT = 1000288016,
    @VK_FORMAT_ASTC_5x5x4_SFLOAT_BLOCK_EXT = 1000288017,
    @VK_FORMAT_ASTC_5x5x5_UNORM_BLOCK_EXT = 1000288018,
    @VK_FORMAT_ASTC_5x5x5_SRGB_BLOCK_EXT = 1000288019,
    @VK_FORMAT_ASTC_5x5x5_SFLOAT_BLOCK_EXT = 1000288020,
    @VK_FORMAT_ASTC_6x5x5_UNORM_BLOCK_EXT = 1000288021,
    @VK_FORMAT_ASTC_6x5x5_SRGB_BLOCK_EXT = 1000288022,
    @VK_FORMAT_ASTC_6x5x5_SFLOAT_BLOCK_EXT = 1000288023,
    @VK_FORMAT_ASTC_6x6x5_UNORM_BLOCK_EXT = 1000288024,
    @VK_FORMAT_ASTC_6x6x5_SRGB_BLOCK_EXT = 1000288025,
    @VK_FORMAT_ASTC_6x6x5_SFLOAT_BLOCK_EXT = 1000288026,
    @VK_FORMAT_ASTC_6x6x6_UNORM_BLOCK_EXT = 1000288027,
    @VK_FORMAT_ASTC_6x6x6_SRGB_BLOCK_EXT = 1000288028,
    @VK_FORMAT_ASTC_6x6x6_SFLOAT_BLOCK_EXT = 1000288029,
    @VK_FORMAT_R8_BOOL_ARM = 1000460000,
    @VK_FORMAT_R16_SFLOAT_FPENCODING_BFLOAT16_ARM = 1000460001,
    @VK_FORMAT_R8_SFLOAT_FPENCODING_FLOAT8E4M3_ARM = 1000460002,
    @VK_FORMAT_R8_SFLOAT_FPENCODING_FLOAT8E5M2_ARM = 1000460003,
    @VK_FORMAT_R16G16_SFIXED5_NV = 1000464000,
    @VK_FORMAT_R10X6_UINT_PACK16_ARM = 1000609000,
    @VK_FORMAT_R10X6G10X6_UINT_2PACK16_ARM = 1000609001,
    @VK_FORMAT_R10X6G10X6B10X6A10X6_UINT_4PACK16_ARM = 1000609002,
    @VK_FORMAT_R12X4_UINT_PACK16_ARM = 1000609003,
    @VK_FORMAT_R12X4G12X4_UINT_2PACK16_ARM = 1000609004,
    @VK_FORMAT_R12X4G12X4B12X4A12X4_UINT_4PACK16_ARM = 1000609005,
    @VK_FORMAT_R14X2_UINT_PACK16_ARM = 1000609006,
    @VK_FORMAT_R14X2G14X2_UINT_2PACK16_ARM = 1000609007,
    @VK_FORMAT_R14X2G14X2B14X2A14X2_UINT_4PACK16_ARM = 1000609008,
    @VK_FORMAT_R14X2_UNORM_PACK16_ARM = 1000609009,
    @VK_FORMAT_R14X2G14X2_UNORM_2PACK16_ARM = 1000609010,
    @VK_FORMAT_R14X2G14X2B14X2A14X2_UNORM_4PACK16_ARM = 1000609011,
    @VK_FORMAT_G14X2_B14X2R14X2_2PLANE_420_UNORM_3PACK16_ARM = 1000609012,
    @VK_FORMAT_G14X2_B14X2R14X2_2PLANE_422_UNORM_3PACK16_ARM = 1000609013,
    @VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK_EXT = 1000066000,
    @VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK_EXT = 1000066001,
    @VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK_EXT = 1000066002,
    @VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK_EXT = 1000066003,
    @VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK_EXT = 1000066004,
    @VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK_EXT = 1000066005,
    @VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK_EXT = 1000066006,
    @VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK_EXT = 1000066007,
    @VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK_EXT = 1000066008,
    @VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK_EXT = 1000066009,
    @VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK_EXT = 1000066010,
    @VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK_EXT = 1000066011,
    @VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK_EXT = 1000066012,
    @VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK_EXT = 1000066013,
    @VK_FORMAT_G8B8G8R8_422_UNORM_KHR = 1000156000,
    @VK_FORMAT_B8G8R8G8_422_UNORM_KHR = 1000156001,
    @VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM_KHR = 1000156002,
    @VK_FORMAT_G8_B8R8_2PLANE_420_UNORM_KHR = 1000156003,
    @VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM_KHR = 1000156004,
    @VK_FORMAT_G8_B8R8_2PLANE_422_UNORM_KHR = 1000156005,
    @VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM_KHR = 1000156006,
    @VK_FORMAT_R10X6_UNORM_PACK16_KHR = 1000156007,
    @VK_FORMAT_R10X6G10X6_UNORM_2PACK16_KHR = 1000156008,
    @VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16_KHR = 1000156009,
    @VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16_KHR = 1000156010,
    @VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16_KHR = 1000156011,
    @VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16_KHR = 1000156012,
    @VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16_KHR = 1000156013,
    @VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16_KHR = 1000156014,
    @VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16_KHR = 1000156015,
    @VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16_KHR = 1000156016,
    @VK_FORMAT_R12X4_UNORM_PACK16_KHR = 1000156017,
    @VK_FORMAT_R12X4G12X4_UNORM_2PACK16_KHR = 1000156018,
    @VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16_KHR = 1000156019,
    @VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16_KHR = 1000156020,
    @VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16_KHR = 1000156021,
    @VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16_KHR = 1000156022,
    @VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16_KHR = 1000156023,
    @VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16_KHR = 1000156024,
    @VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16_KHR = 1000156025,
    @VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16_KHR = 1000156026,
    @VK_FORMAT_G16B16G16R16_422_UNORM_KHR = 1000156027,
    @VK_FORMAT_B16G16R16G16_422_UNORM_KHR = 1000156028,
    @VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM_KHR = 1000156029,
    @VK_FORMAT_G16_B16R16_2PLANE_420_UNORM_KHR = 1000156030,
    @VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM_KHR = 1000156031,
    @VK_FORMAT_G16_B16R16_2PLANE_422_UNORM_KHR = 1000156032,
    @VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM_KHR = 1000156033,
    @VK_FORMAT_G8_B8R8_2PLANE_444_UNORM_EXT = 1000330000,
    @VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16_EXT = 1000330001,
    @VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16_EXT = 1000330002,
    @VK_FORMAT_G16_B16R16_2PLANE_444_UNORM_EXT = 1000330003,
    @VK_FORMAT_A4R4G4B4_UNORM_PACK16_EXT = 1000340000,
    @VK_FORMAT_A4B4G4R4_UNORM_PACK16_EXT = 1000340001,
    @VK_FORMAT_R16G16_S10_5_NV = 1000464000,
    @VK_FORMAT_A1B5G5R5_UNORM_PACK16_KHR = 1000470000,
    @VK_FORMAT_A8_UNORM_KHR = 1000470001,
    @VK_FORMAT_MAX_ENUM = 2147483647,
}

public enum _VkImageLayout : int
{
    @VK_IMAGE_LAYOUT_UNDEFINED = 0,
    @VK_IMAGE_LAYOUT_GENERAL = 1,
    @VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL = 2,
    @VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL = 3,
    @VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL = 4,
    @VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL = 5,
    @VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL = 6,
    @VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL = 7,
    @VK_IMAGE_LAYOUT_PREINITIALIZED = 8,
    @VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL = 1000117000,
    @VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL = 1000117001,
    @VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL = 1000241000,
    @VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL = 1000241001,
    @VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL = 1000241002,
    @VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL = 1000241003,
    @VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL = 1000314000,
    @VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL = 1000314001,
    @VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ = 1000232000,
    @VK_IMAGE_LAYOUT_PRESENT_SRC_KHR = 1000001002,
    @VK_IMAGE_LAYOUT_VIDEO_DECODE_DST_KHR = 1000024000,
    @VK_IMAGE_LAYOUT_VIDEO_DECODE_SRC_KHR = 1000024001,
    @VK_IMAGE_LAYOUT_VIDEO_DECODE_DPB_KHR = 1000024002,
    @VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR = 1000111000,
    @VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT = 1000218000,
    @VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR = 1000164003,
    @VK_IMAGE_LAYOUT_VIDEO_ENCODE_DST_KHR = 1000299000,
    @VK_IMAGE_LAYOUT_VIDEO_ENCODE_SRC_KHR = 1000299001,
    @VK_IMAGE_LAYOUT_VIDEO_ENCODE_DPB_KHR = 1000299002,
    @VK_IMAGE_LAYOUT_ATTACHMENT_FEEDBACK_LOOP_OPTIMAL_EXT = 1000339000,
    @VK_IMAGE_LAYOUT_TENSOR_ALIASING_ARM = 1000460000,
    @VK_IMAGE_LAYOUT_VIDEO_ENCODE_QUANTIZATION_MAP_KHR = 1000553000,
    @VK_IMAGE_LAYOUT_ZERO_INITIALIZED_EXT = 1000620000,
    @VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL_KHR = 1000117000,
    @VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL_KHR = 1000117001,
    @VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV = 1000164003,
    @VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ_KHR = 1000232000,
    @VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL_KHR = 1000241000,
    @VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL_KHR = 1000241001,
    @VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL_KHR = 1000241002,
    @VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL_KHR = 1000241003,
    @VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL_KHR = 1000314000,
    @VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL_KHR = 1000314001,
    @VK_IMAGE_LAYOUT_MAX_ENUM = 2147483647,
}

public enum _VkImageTiling : int
{
    @VK_IMAGE_TILING_OPTIMAL = 0,
    @VK_IMAGE_TILING_LINEAR = 1,
    @VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT = 1000158000,
    @VK_IMAGE_TILING_MAX_ENUM = 2147483647,
}

public enum _VkImageUsageFlagBits : int
{
    @VK_IMAGE_USAGE_TRANSFER_SRC_BIT = 1,
    @VK_IMAGE_USAGE_TRANSFER_DST_BIT = 2,
    @VK_IMAGE_USAGE_SAMPLED_BIT = 4,
    @VK_IMAGE_USAGE_STORAGE_BIT = 8,
    @VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT = 16,
    @VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT = 32,
    @VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT = 64,
    @VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT = 128,
    @VK_IMAGE_USAGE_HOST_TRANSFER_BIT = 4194304,
    @VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR = 1024,
    @VK_IMAGE_USAGE_VIDEO_DECODE_SRC_BIT_KHR = 2048,
    @VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR = 4096,
    @VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT = 512,
    @VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 256,
    @VK_IMAGE_USAGE_VIDEO_ENCODE_DST_BIT_KHR = 8192,
    @VK_IMAGE_USAGE_VIDEO_ENCODE_SRC_BIT_KHR = 16384,
    @VK_IMAGE_USAGE_VIDEO_ENCODE_DPB_BIT_KHR = 32768,
    @VK_IMAGE_USAGE_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 524288,
    @VK_IMAGE_USAGE_INVOCATION_MASK_BIT_HUAWEI = 262144,
    @VK_IMAGE_USAGE_SAMPLE_WEIGHT_BIT_QCOM = 1048576,
    @VK_IMAGE_USAGE_SAMPLE_BLOCK_MATCH_BIT_QCOM = 2097152,
    @VK_IMAGE_USAGE_TENSOR_ALIASING_BIT_ARM = 8388608,
    @VK_IMAGE_USAGE_TILE_MEMORY_BIT_QCOM = 134217728,
    @VK_IMAGE_USAGE_VIDEO_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR = 33554432,
    @VK_IMAGE_USAGE_VIDEO_ENCODE_EMPHASIS_MAP_BIT_KHR = 67108864,
    @VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV = 256,
    @VK_IMAGE_USAGE_HOST_TRANSFER_BIT_EXT = 4194304,
    @VK_IMAGE_USAGE_FLAG_BITS_MAX_ENUM = 2147483647,
}

public enum _VkMemoryPropertyFlagBits : int
{
    @VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT = 1,
    @VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT = 2,
    @VK_MEMORY_PROPERTY_HOST_COHERENT_BIT = 4,
    @VK_MEMORY_PROPERTY_HOST_CACHED_BIT = 8,
    @VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT = 16,
    @VK_MEMORY_PROPERTY_PROTECTED_BIT = 32,
    @VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD = 64,
    @VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD = 128,
    @VK_MEMORY_PROPERTY_RDMA_CAPABLE_BIT_NV = 256,
    @VK_MEMORY_PROPERTY_FLAG_BITS_MAX_ENUM = 2147483647,
}

public enum _VkQueueFlagBits : int
{
    @VK_QUEUE_GRAPHICS_BIT = 1,
    @VK_QUEUE_COMPUTE_BIT = 2,
    @VK_QUEUE_TRANSFER_BIT = 4,
    @VK_QUEUE_SPARSE_BINDING_BIT = 8,
    @VK_QUEUE_PROTECTED_BIT = 16,
    @VK_QUEUE_VIDEO_DECODE_BIT_KHR = 32,
    @VK_QUEUE_VIDEO_ENCODE_BIT_KHR = 64,
    @VK_QUEUE_OPTICAL_FLOW_BIT_NV = 256,
    @VK_QUEUE_DATA_GRAPH_BIT_ARM = 1024,
    @VK_QUEUE_FLAG_BITS_MAX_ENUM = 2147483647,
}

public enum _VkStructureType : int
{
    @VK_STRUCTURE_TYPE_APPLICATION_INFO = 0,
    @VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = 1,
    @VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO = 2,
    @VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = 3,
    @VK_STRUCTURE_TYPE_SUBMIT_INFO = 4,
    @VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO = 5,
    @VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE = 6,
    @VK_STRUCTURE_TYPE_BIND_SPARSE_INFO = 7,
    @VK_STRUCTURE_TYPE_FENCE_CREATE_INFO = 8,
    @VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO = 9,
    @VK_STRUCTURE_TYPE_EVENT_CREATE_INFO = 10,
    @VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO = 11,
    @VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO = 12,
    @VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO = 13,
    @VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO = 14,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO = 15,
    @VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO = 16,
    @VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO = 17,
    @VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO = 18,
    @VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO = 19,
    @VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO = 20,
    @VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO = 21,
    @VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO = 22,
    @VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO = 23,
    @VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO = 24,
    @VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO = 25,
    @VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO = 26,
    @VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO = 27,
    @VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO = 28,
    @VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO = 29,
    @VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO = 30,
    @VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO = 31,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO = 32,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO = 33,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO = 34,
    @VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET = 35,
    @VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET = 36,
    @VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO = 37,
    @VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO = 38,
    @VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO = 39,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO = 40,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO = 41,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO = 42,
    @VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO = 43,
    @VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER = 44,
    @VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER = 45,
    @VK_STRUCTURE_TYPE_MEMORY_BARRIER = 46,
    @VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO = 47,
    @VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO = 48,
    @VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO = 1000157000,
    @VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO = 1000157001,
    @VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS = 1000127000,
    @VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO = 1000127001,
    @VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO = 1000060000,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO = 1000060004,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO = 1000060005,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO = 1000060006,
    @VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO = 1000060013,
    @VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO = 1000060014,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES = 1000070000,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO = 1000070001,
    @VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2 = 1000146000,
    @VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2 = 1000146001,
    @VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2 = 1000146002,
    @VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2 = 1000146003,
    @VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2 = 1000146004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2 = 1000059000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2 = 1000059001,
    @VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2 = 1000059002,
    @VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2 = 1000059003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2 = 1000059004,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2 = 1000059005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2 = 1000059006,
    @VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2 = 1000059007,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2 = 1000059008,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO = 1000117002,
    @VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO = 1000145000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES = 1000145001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES = 1000145002,
    @VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2 = 1000145003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO = 1000071000,
    @VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES = 1000071001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO = 1000071002,
    @VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES = 1000071003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES = 1000071004,
    @VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO = 1000072000,
    @VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO = 1000072001,
    @VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO = 1000072002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO = 1000112000,
    @VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES = 1000112001,
    @VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO = 1000113000,
    @VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO = 1000077000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO = 1000076000,
    @VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES = 1000076001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES = 1000094000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES = 1000083000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES = 1000120000,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO = 1000085000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES = 1000168000,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT = 1000168001,
    @VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO = 1000156000,
    @VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO = 1000156001,
    @VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO = 1000156002,
    @VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO = 1000156003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES = 1000156004,
    @VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES = 1000156005,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO = 1000060003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES = 1000117000,
    @VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO = 1000117001,
    @VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO = 1000117003,
    @VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO = 1000053000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES = 1000053001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES = 1000053002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES = 1000063000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES = 1000196000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_FEATURES = 49,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES = 50,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES = 51,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES = 52,
    @VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO = 1000147000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES = 1000211000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES = 1000261000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES = 1000207000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES = 1000207001,
    @VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO = 1000207002,
    @VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO = 1000207003,
    @VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO = 1000207004,
    @VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO = 1000207005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES = 1000257000,
    @VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO = 1000244001,
    @VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO = 1000257002,
    @VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO = 1000257003,
    @VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO = 1000257004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES = 1000177000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES = 1000180000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES = 1000082000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES = 1000197000,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO = 1000161000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES = 1000161001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES = 1000161002,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO = 1000161003,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT = 1000161004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES = 1000221000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES = 1000130000,
    @VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO = 1000130001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES = 1000253000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES = 1000175000,
    @VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2 = 1000109000,
    @VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2 = 1000109001,
    @VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2 = 1000109002,
    @VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2 = 1000109003,
    @VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2 = 1000109004,
    @VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO = 1000109005,
    @VK_STRUCTURE_TYPE_SUBPASS_END_INFO = 1000109006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES = 1000199000,
    @VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE = 1000199001,
    @VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO = 1000246000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES = 1000108000,
    @VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO = 1000108001,
    @VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO = 1000108002,
    @VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO = 1000108003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES = 1000241000,
    @VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT = 1000241001,
    @VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT = 1000241002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_FEATURES = 53,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_PROPERTIES = 54,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES = 1000245000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES = 1000295000,
    @VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO = 1000295001,
    @VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO = 1000295002,
    @VK_STRUCTURE_TYPE_MEMORY_BARRIER_2 = 1000314000,
    @VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2 = 1000314001,
    @VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2 = 1000314002,
    @VK_STRUCTURE_TYPE_DEPENDENCY_INFO = 1000314003,
    @VK_STRUCTURE_TYPE_SUBMIT_INFO_2 = 1000314004,
    @VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO = 1000314005,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO = 1000314006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES = 1000314007,
    @VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2 = 1000337000,
    @VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2 = 1000337001,
    @VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2 = 1000337002,
    @VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2 = 1000337003,
    @VK_STRUCTURE_TYPE_BUFFER_COPY_2 = 1000337006,
    @VK_STRUCTURE_TYPE_IMAGE_COPY_2 = 1000337007,
    @VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2 = 1000337009,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES = 1000066000,
    @VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3 = 1000360000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES = 1000413000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES = 1000413001,
    @VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS = 1000413002,
    @VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS = 1000413003,
    @VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO = 1000192000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES = 1000215000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES = 1000276000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES = 1000297000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES = 1000325000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES = 1000335000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES = 1000225000,
    @VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO = 1000225001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES = 1000225002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES = 1000138000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES = 1000138001,
    @VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK = 1000138002,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO = 1000138003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES = 1000280000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES = 1000280001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES = 1000281001,
    @VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2 = 1000337004,
    @VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2 = 1000337005,
    @VK_STRUCTURE_TYPE_IMAGE_BLIT_2 = 1000337008,
    @VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2 = 1000337010,
    @VK_STRUCTURE_TYPE_RENDERING_INFO = 1000044000,
    @VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO = 1000044001,
    @VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO = 1000044002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES = 1000044003,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO = 1000044004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_4_FEATURES = 55,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_4_PROPERTIES = 56,
    @VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO = 1000174000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES = 1000388000,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES = 1000388001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES = 1000265000,
    @VK_STRUCTURE_TYPE_MEMORY_MAP_INFO = 1000271000,
    @VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO = 1000271001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES = 1000470000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES = 1000470001,
    @VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO = 1000470004,
    @VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2 = 1000338002,
    @VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2 = 1000338003,
    @VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO = 1000470006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES = 1000545000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES = 1000545001,
    @VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS = 1000545002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES = 1000270000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES = 1000270001,
    @VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY = 1000270002,
    @VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY = 1000270003,
    @VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO = 1000270004,
    @VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO = 1000270005,
    @VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO = 1000270006,
    @VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO = 1000270007,
    @VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE = 1000270008,
    @VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY = 1000270009,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES = 1000416000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES = 1000528000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES = 1000544000,
    @VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO = 1000470005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES = 1000080000,
    @VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO = 1000545003,
    @VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO = 1000545004,
    @VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO = 1000545005,
    @VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO = 1000545006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES = 1000466000,
    @VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO = 1000068000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES = 1000068001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES = 1000068002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES = 1000259000,
    @VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO = 1000259001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES = 1000259002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES = 1000525000,
    @VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO = 1000190001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES = 1000190002,
    @VK_STRUCTURE_TYPE_RENDERING_AREA_INFO = 1000470003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES = 1000232000,
    @VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO = 1000232001,
    @VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO = 1000232002,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR = 1000001000,
    @VK_STRUCTURE_TYPE_PRESENT_INFO_KHR = 1000001001,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR = 1000060007,
    @VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR = 1000060008,
    @VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR = 1000060009,
    @VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR = 1000060010,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR = 1000060011,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR = 1000060012,
    @VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR = 1000002000,
    @VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR = 1000002001,
    @VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR = 1000003000,
    @VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR = 1000004000,
    @VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR = 1000005000,
    @VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR = 1000006000,
    @VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR = 1000008000,
    @VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR = 1000009000,
    @VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT = 1000011000,
    @VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD = 1000018000,
    @VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT = 1000022000,
    @VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT = 1000022001,
    @VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT = 1000022002,
    @VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR = 1000023000,
    @VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR = 1000023001,
    @VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR = 1000023002,
    @VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR = 1000023003,
    @VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR = 1000023004,
    @VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR = 1000023005,
    @VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000023006,
    @VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR = 1000023007,
    @VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR = 1000023008,
    @VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR = 1000023009,
    @VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR = 1000023010,
    @VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR = 1000023011,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR = 1000023012,
    @VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR = 1000023013,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR = 1000023014,
    @VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR = 1000023015,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR = 1000023016,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR = 1000024000,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR = 1000024001,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR = 1000024002,
    @VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV = 1000026000,
    @VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV = 1000026001,
    @VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV = 1000026002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT = 1000028000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT = 1000028001,
    @VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT = 1000028002,
    @VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX = 1000029000,
    @VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX = 1000029001,
    @VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX = 1000029002,
    @VK_STRUCTURE_TYPE_CU_MODULE_TEXTURING_MODE_CREATE_INFO_NVX = 1000029004,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX = 1000030000,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX = 1000030001,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_KHR = 1000038000,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000038001,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR = 1000038002,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_KHR = 1000038003,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_KHR = 1000038004,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_KHR = 1000038005,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_GOP_REMAINING_FRAME_INFO_KHR = 1000038006,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_KHR = 1000038007,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_KHR = 1000038008,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_KHR = 1000038009,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_KHR = 1000038010,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUALITY_LEVEL_PROPERTIES_KHR = 1000038011,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_GET_INFO_KHR = 1000038012,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_FEEDBACK_INFO_KHR = 1000038013,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_KHR = 1000039000,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000039001,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR = 1000039002,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PICTURE_INFO_KHR = 1000039003,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_KHR = 1000039004,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_KHR = 1000039005,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_GOP_REMAINING_FRAME_INFO_KHR = 1000039006,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_KHR = 1000039007,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_KHR = 1000039009,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_KHR = 1000039010,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_KHR = 1000039011,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUALITY_LEVEL_PROPERTIES_KHR = 1000039012,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_GET_INFO_KHR = 1000039013,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_FEEDBACK_INFO_KHR = 1000039014,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR = 1000040000,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR = 1000040001,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR = 1000040003,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000040004,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR = 1000040005,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR = 1000040006,
    @VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD = 1000041000,
    @VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP = 1000049000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV = 1000050000,
    @VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV = 1000056000,
    @VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV = 1000056001,
    @VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV = 1000057000,
    @VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV = 1000057001,
    @VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV = 1000058000,
    @VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT = 1000061000,
    @VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN = 1000062000,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT = 1000067000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT = 1000067001,
    @VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR = 1000073000,
    @VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR = 1000073001,
    @VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR = 1000073002,
    @VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR = 1000073003,
    @VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR = 1000074000,
    @VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR = 1000074001,
    @VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR = 1000074002,
    @VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR = 1000075000,
    @VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = 1000078000,
    @VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = 1000078001,
    @VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR = 1000078002,
    @VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR = 1000078003,
    @VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR = 1000079000,
    @VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR = 1000079001,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT = 1000081000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT = 1000081001,
    @VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT = 1000081002,
    @VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR = 1000084000,
    @VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV = 1000087000,
    @VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT = 1000090000,
    @VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT = 1000091000,
    @VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT = 1000091001,
    @VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT = 1000091002,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT = 1000091003,
    @VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE = 1000092000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX = 1000097000,
    @VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX = 1000044009,
    @VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV = 1000098000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT = 1000099000,
    @VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT = 1000099001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT = 1000101000,
    @VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT = 1000101001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT = 1000102000,
    @VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT = 1000102001,
    @VK_STRUCTURE_TYPE_HDR_METADATA_EXT = 1000105000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RELAXED_LINE_RASTERIZATION_FEATURES_IMG = 1000110000,
    @VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR = 1000111000,
    @VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR = 1000114000,
    @VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR = 1000114001,
    @VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR = 1000114002,
    @VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR = 1000115000,
    @VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR = 1000115001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR = 1000116000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR = 1000116001,
    @VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR = 1000116002,
    @VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR = 1000116003,
    @VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR = 1000116004,
    @VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR = 1000116005,
    @VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR = 1000116006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR = 1000119000,
    @VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR = 1000119001,
    @VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR = 1000119002,
    @VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR = 1000121000,
    @VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR = 1000121001,
    @VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR = 1000121002,
    @VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR = 1000121003,
    @VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR = 1000121004,
    @VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK = 1000122000,
    @VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK = 1000123000,
    @VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT = 1000128000,
    @VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT = 1000128001,
    @VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT = 1000128002,
    @VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT = 1000128003,
    @VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT = 1000128004,
    @VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID = 1000129000,
    @VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID = 1000129001,
    @VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID = 1000129002,
    @VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = 1000129003,
    @VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = 1000129004,
    @VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID = 1000129005,
    @VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID = 1000129006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GPA_FEATURES_AMD = 1000133000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GPA_PROPERTIES_AMD = 1000133001,
    @VK_STRUCTURE_TYPE_GPA_SAMPLE_BEGIN_INFO_AMD = 1000133002,
    @VK_STRUCTURE_TYPE_GPA_SESSION_CREATE_INFO_AMD = 1000133003,
    @VK_STRUCTURE_TYPE_GPA_DEVICE_CLOCK_MODE_INFO_AMD = 1000133004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GPA_PROPERTIES_2_AMD = 1000133005,
    @VK_STRUCTURE_TYPE_GPA_DEVICE_GET_CLOCK_INFO_AMD = 1000133006,
    @VK_STRUCTURE_TYPE_TEXEL_BUFFER_DESCRIPTOR_INFO_EXT = 1000135000,
    @VK_STRUCTURE_TYPE_IMAGE_DESCRIPTOR_INFO_EXT = 1000135001,
    @VK_STRUCTURE_TYPE_RESOURCE_DESCRIPTOR_INFO_EXT = 1000135002,
    @VK_STRUCTURE_TYPE_BIND_HEAP_INFO_EXT = 1000135003,
    @VK_STRUCTURE_TYPE_PUSH_DATA_INFO_EXT = 1000135004,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_AND_BINDING_MAPPING_EXT = 1000135005,
    @VK_STRUCTURE_TYPE_SHADER_DESCRIPTOR_SET_AND_BINDING_MAPPING_INFO_EXT = 1000135006,
    @VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DATA_CREATE_INFO_EXT = 1000135007,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_HEAP_PROPERTIES_EXT = 1000135008,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_HEAP_FEATURES_EXT = 1000135009,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_DESCRIPTOR_HEAP_INFO_EXT = 1000135010,
    @VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_INDEX_CREATE_INFO_EXT = 1000135011,
    @VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_PUSH_DATA_TOKEN_NV = 1000135012,
    @VK_STRUCTURE_TYPE_SUBSAMPLED_IMAGE_FORMAT_PROPERTIES_EXT = 1000135013,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_HEAP_TENSOR_PROPERTIES_ARM = 1000135014,
    @VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD = 1000044008,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_BFLOAT16_FEATURES_KHR = 1000141000,
    @VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT = 1000143000,
    @VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT = 1000143001,
    @VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT = 1000143002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT = 1000143003,
    @VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT = 1000143004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT = 1000148000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT = 1000148001,
    @VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT = 1000148002,
    @VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV = 1000149000,
    @VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR = 1000150007,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR = 1000150000,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR = 1000150002,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR = 1000150003,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR = 1000150004,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR = 1000150005,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR = 1000150006,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR = 1000150009,
    @VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR = 1000150010,
    @VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR = 1000150011,
    @VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR = 1000150012,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR = 1000150013,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR = 1000150014,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR = 1000150017,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR = 1000150020,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR = 1000347000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR = 1000347001,
    @VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR = 1000150015,
    @VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR = 1000150016,
    @VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR = 1000150018,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR = 1000348013,
    @VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV = 1000152000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV = 1000154000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV = 1000154001,
    @VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT = 1000158000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT = 1000158002,
    @VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT = 1000158003,
    @VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT = 1000158004,
    @VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT = 1000158005,
    @VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT = 1000158006,
    @VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT = 1000160000,
    @VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT = 1000160001,
    @VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV = 1000164000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV = 1000164001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV = 1000164002,
    @VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV = 1000164005,
    @VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV = 1000165000,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV = 1000165001,
    @VK_STRUCTURE_TYPE_GEOMETRY_NV = 1000165003,
    @VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV = 1000165004,
    @VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV = 1000165005,
    @VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV = 1000165006,
    @VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV = 1000165007,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV = 1000165008,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV = 1000165009,
    @VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV = 1000165011,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV = 1000165012,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV = 1000166000,
    @VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV = 1000166001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT = 1000170000,
    @VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT = 1000170001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_CONVERSION_FEATURES_QCOM = 1000172000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ELAPSED_TIMER_QUERY_FEATURES_QCOM = 1000173000,
    @VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT = 1000178000,
    @VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT = 1000178001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT = 1000178002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR = 1000181000,
    @VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD = 1000183000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD = 1000185000,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR = 1000187000,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000187001,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR = 1000187002,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR = 1000187003,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR = 1000187004,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_KHR = 1000187005,
    @VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD = 1000189000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT = 1000190000,
    @VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP = 1000191000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV = 1000202000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV = 1000202001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV = 1000204000,
    @VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV = 1000205000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV = 1000205002,
    @VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV = 1000206000,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV = 1000206001,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV = 1000314008,
    @VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV = 1000314009,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_TIMING_FEATURES_EXT = 1000208000,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_TIMING_PROPERTIES_EXT = 1000208001,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_TIME_DOMAIN_PROPERTIES_EXT = 1000208002,
    @VK_STRUCTURE_TYPE_PRESENT_TIMINGS_INFO_EXT = 1000208003,
    @VK_STRUCTURE_TYPE_PRESENT_TIMING_INFO_EXT = 1000208004,
    @VK_STRUCTURE_TYPE_PAST_PRESENTATION_TIMING_INFO_EXT = 1000208005,
    @VK_STRUCTURE_TYPE_PAST_PRESENTATION_TIMING_PROPERTIES_EXT = 1000208006,
    @VK_STRUCTURE_TYPE_PAST_PRESENTATION_TIMING_EXT = 1000208007,
    @VK_STRUCTURE_TYPE_PRESENT_TIMING_SURFACE_CAPABILITIES_EXT = 1000208008,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_CALIBRATED_TIMESTAMP_INFO_EXT = 1000208009,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL = 1000209000,
    @VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL = 1000210000,
    @VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL = 1000210001,
    @VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL = 1000210002,
    @VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL = 1000210003,
    @VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL = 1000210004,
    @VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL = 1000210005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT = 1000212000,
    @VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD = 1000213000,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD = 1000213001,
    @VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA = 1000214000,
    @VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT = 1000217000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT = 1000218000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT = 1000218001,
    @VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT = 1000218002,
    @VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT = 1000044007,
    @VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = 1000226000,
    @VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR = 1000226001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR = 1000226002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR = 1000226003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR = 1000226004,
    @VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = 1000044006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD = 1000227000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD = 1000229000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CONSTANT_DATA_FEATURES_KHR = 1000231000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ABORT_FEATURES_KHR = 1000233000,
    @VK_STRUCTURE_TYPE_DEVICE_FAULT_SHADER_ABORT_MESSAGE_INFO_KHR = 1000233001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ABORT_PROPERTIES_KHR = 1000233002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT = 1000234000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_QUAD_CONTROL_FEATURES_KHR = 1000235000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT = 1000237000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT = 1000238000,
    @VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT = 1000238001,
    @VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR = 1000239000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV = 1000240000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT = 1000244000,
    @VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT = 1000244002,
    @VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT = 1000247000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR = 1000248000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV = 1000249000,
    @VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV = 1000249001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV = 1000249002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV = 1000250000,
    @VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV = 1000250001,
    @VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV = 1000250002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT = 1000251000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT = 1000252000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT = 1000254000,
    @VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT = 1000254001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT = 1000254002,
    @VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT = 1000255000,
    @VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT = 1000255002,
    @VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT = 1000255001,
    @VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT = 1000256000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT = 1000260000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT = 1000267000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR = 1000269000,
    @VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR = 1000269001,
    @VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR = 1000269002,
    @VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR = 1000269003,
    @VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR = 1000269004,
    @VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR = 1000269005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_FEATURES_EXT = 1000272000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_PROPERTIES_EXT = 1000272001,
    @VK_STRUCTURE_TYPE_MEMORY_MAP_PLACED_INFO_EXT = 1000272002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT = 1000273000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV = 1000277000,
    @VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV = 1000277001,
    @VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV = 1000277002,
    @VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV = 1000277003,
    @VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV = 1000277004,
    @VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV = 1000277005,
    @VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV = 1000277006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV = 1000277007,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV = 1000278000,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV = 1000278001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT = 1000281000,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM = 1000282000,
    @VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM = 1000282001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT = 1000283000,
    @VK_STRUCTURE_TYPE_DEPTH_BIAS_INFO_EXT = 1000283001,
    @VK_STRUCTURE_TYPE_DEPTH_BIAS_REPRESENTATION_INFO_EXT = 1000283002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT = 1000284000,
    @VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT = 1000284001,
    @VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT = 1000284002,
    @VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT = 1000287000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT = 1000287001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT = 1000287002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_3D_FEATURES_EXT = 1000288000,
    @VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR = 1000290000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV = 1000292000,
    @VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV = 1000292001,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV = 1000292002,
    @VK_STRUCTURE_TYPE_PRESENT_ID_KHR = 1000294000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR = 1000294001,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR = 1000299000,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR = 1000299001,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR = 1000299002,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR = 1000299003,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR = 1000299004,
    @VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR = 1000299005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR = 1000299006,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_PROPERTIES_KHR = 1000299007,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR = 1000299008,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_GET_INFO_KHR = 1000299009,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_FEEDBACK_INFO_KHR = 1000299010,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV = 1000300000,
    @VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV = 1000300001,
    @VK_STRUCTURE_TYPE_PERF_HINT_INFO_QCOM = 1000302000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_PERF_HINT_FEATURES_QCOM = 1000302001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_PERF_HINT_PROPERTIES_QCOM = 1000302002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_3_FEATURES_QCOM = 1000303000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MULTIPLE_WAIT_QUEUES_FEATURES_QCOM = 1000304000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MULTIPLE_WAIT_QUEUES_PROPERTIES_QCOM = 1000304001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SPLIT_BARRIER_FEATURES_EXT = 1000305000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SPLIT_BARRIER_PROPERTIES_EXT = 1000305001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_FEATURES_QCOM = 1000309000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_PROPERTIES_QCOM = 1000309001,
    @VK_STRUCTURE_TYPE_RENDER_PASS_TILE_SHADING_CREATE_INFO_QCOM = 1000309002,
    @VK_STRUCTURE_TYPE_PER_TILE_BEGIN_INFO_QCOM = 1000309003,
    @VK_STRUCTURE_TYPE_PER_TILE_END_INFO_QCOM = 1000309004,
    @VK_STRUCTURE_TYPE_DISPATCH_TILE_INFO_QCOM = 1000309005,
    @VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV = 1000310000,
    @VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT = 1000311000,
    @VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT = 1000311001,
    @VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT = 1000311002,
    @VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT = 1000311003,
    @VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT = 1000311004,
    @VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT = 1000311005,
    @VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT = 1000311006,
    @VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT = 1000311007,
    @VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT = 1000311008,
    @VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT = 1000311009,
    @VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT = 1000311010,
    @VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT = 1000311011,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT = 1000316000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_DENSITY_MAP_PROPERTIES_EXT = 1000316001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT = 1000316002,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT = 1000316003,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT = 1000316004,
    @VK_STRUCTURE_TYPE_BUFFER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316005,
    @VK_STRUCTURE_TYPE_IMAGE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316006,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316007,
    @VK_STRUCTURE_TYPE_SAMPLER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316008,
    @VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT = 1000316010,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT = 1000316011,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT = 1000316012,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316009,
    @VK_STRUCTURE_TYPE_DEVICE_MEMORY_COPY_KHR = 1000318000,
    @VK_STRUCTURE_TYPE_COPY_DEVICE_MEMORY_INFO_KHR = 1000318001,
    @VK_STRUCTURE_TYPE_DEVICE_MEMORY_IMAGE_COPY_KHR = 1000318002,
    @VK_STRUCTURE_TYPE_COPY_DEVICE_MEMORY_IMAGE_INFO_KHR = 1000318003,
    @VK_STRUCTURE_TYPE_MEMORY_RANGE_BARRIERS_INFO_KHR = 1000318004,
    @VK_STRUCTURE_TYPE_MEMORY_RANGE_BARRIER_KHR = 1000318005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_ADDRESS_COMMANDS_FEATURES_KHR = 1000318006,
    @VK_STRUCTURE_TYPE_BIND_INDEX_BUFFER_3_INFO_KHR = 1000318007,
    @VK_STRUCTURE_TYPE_BIND_VERTEX_BUFFER_3_INFO_KHR = 1000318008,
    @VK_STRUCTURE_TYPE_DRAW_INDIRECT_2_INFO_KHR = 1000318009,
    @VK_STRUCTURE_TYPE_DRAW_INDIRECT_COUNT_2_INFO_KHR = 1000318010,
    @VK_STRUCTURE_TYPE_DISPATCH_INDIRECT_2_INFO_KHR = 1000318011,
    @VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_2_EXT = 1000318012,
    @VK_STRUCTURE_TYPE_BIND_TRANSFORM_FEEDBACK_BUFFER_2_INFO_EXT = 1000318013,
    @VK_STRUCTURE_TYPE_MEMORY_MARKER_INFO_AMD = 1000318014,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_2_KHR = 1000318015,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT = 1000320000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT = 1000320001,
    @VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT = 1000320002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD = 1000321000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR = 1000203000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR = 1000322000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR = 1000323000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV = 1000326000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV = 1000326001,
    @VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV = 1000326002,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV = 1000327000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV = 1000327001,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV = 1000327002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT = 1000328000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT = 1000328001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT = 1000330000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT = 1000332000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT = 1000332001,
    @VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM = 1000333000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR = 1000336000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT = 1000338000,
    @VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT = 1000338001,
    @VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT = 1000338004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT = 1000339000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT = 1000340000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_EXT = 1000341000,
    @VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT = 1000341001,
    @VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT = 1000341002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT = 1000344000,
    @VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT = 1000346000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT = 1000352000,
    @VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT = 1000352001,
    @VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT = 1000352002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT = 1000353000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT = 1000354000,
    @VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT = 1000354001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT = 1000355000,
    @VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT = 1000355001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT = 1000356000,
    @VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA = 1000364000,
    @VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA = 1000364001,
    @VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA = 1000364002,
    @VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA = 1000365000,
    @VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA = 1000365001,
    @VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA = 1000366000,
    @VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA = 1000366001,
    @VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA = 1000366002,
    @VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA = 1000366003,
    @VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA = 1000366004,
    @VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA = 1000366005,
    @VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA = 1000366006,
    @VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA = 1000366007,
    @VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA = 1000366008,
    @VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA = 1000366009,
    @VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI = 1000369000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI = 1000369001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI = 1000369002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI = 1000370000,
    @VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV = 1000371000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV = 1000371001,
    @VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT = 1000372000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT = 1000372001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAME_BOUNDARY_FEATURES_EXT = 1000375000,
    @VK_STRUCTURE_TYPE_FRAME_BOUNDARY_EXT = 1000375001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT = 1000376000,
    @VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT = 1000376001,
    @VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT = 1000376002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT = 1000377000,
    @VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX = 1000378000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT = 1000381000,
    @VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT = 1000381001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT = 1000382000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR = 1000386000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNTYPED_POINTERS_FEATURES_KHR = 1000387000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_RGB_CONVERSION_FEATURES_VALVE = 1000390000,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_RGB_CONVERSION_CAPABILITIES_VALVE = 1000390001,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_PROFILE_RGB_CONVERSION_INFO_VALVE = 1000390002,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_RGB_CONVERSION_CREATE_INFO_VALVE = 1000390003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT = 1000391000,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT = 1000391001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT = 1000392000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT = 1000392001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT = 1000393000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_FEATURES_EXT = 1000395000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT = 1000395001,
    @VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT = 1000396000,
    @VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT = 1000396001,
    @VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT = 1000396002,
    @VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT = 1000396003,
    @VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT = 1000396004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT = 1000396005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_EXT = 1000396006,
    @VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT = 1000396007,
    @VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT = 1000396008,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT = 1000396009,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI = 1000404000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI = 1000404001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_VRS_FEATURES_HUAWEI = 1000404002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT = 1000411000,
    @VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT = 1000411001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT = 1000412000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM = 1000415000,
    @VK_STRUCTURE_TYPE_DEVICE_QUEUE_SHADER_CORE_CONTROL_CREATE_INFO_ARM = 1000417000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_FEATURES_ARM = 1000417001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_PROPERTIES_ARM = 1000417002,
    @VK_STRUCTURE_TYPE_DISPATCH_PARAMETERS_ARM = 1000417003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_DISPATCH_PARAMETERS_PROPERTIES_ARM = 1000417004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT = 1000418000,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT = 1000418001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE = 1000420000,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE = 1000420001,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE = 1000420002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT = 1000422000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_FEATURES_ARM = 1000424000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_PROPERTIES_ARM = 1000424001,
    @VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_BEGIN_INFO_ARM = 1000424002,
    @VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_INFO_ARM = 1000424003,
    @VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_SUBMIT_INFO_ARM = 1000424004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_NV = 1000426000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV = 1000428000,
    @VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV = 1000428001,
    @VK_STRUCTURE_TYPE_PIPELINE_INDIRECT_DEVICE_ADDRESS_INFO_NV = 1000428002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_LINEAR_SWEPT_SPHERES_FEATURES_NV = 1000429008,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_LINEAR_SWEPT_SPHERES_DATA_NV = 1000429009,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_SPHERES_DATA_NV = 1000429010,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV = 1000430000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MAXIMAL_RECONVERGENCE_FEATURES_KHR = 1000434000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT = 1000437000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM = 1000440000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM = 1000440001,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM = 1000440002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_FEATURES_EXT = 1000451000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_PROPERTIES_EXT = 1000451001,
    @VK_STRUCTURE_TYPE_NATIVE_BUFFER_USAGE_OHOS = 1000452000,
    @VK_STRUCTURE_TYPE_NATIVE_BUFFER_PROPERTIES_OHOS = 1000452001,
    @VK_STRUCTURE_TYPE_NATIVE_BUFFER_FORMAT_PROPERTIES_OHOS = 1000452002,
    @VK_STRUCTURE_TYPE_IMPORT_NATIVE_BUFFER_INFO_OHOS = 1000452003,
    @VK_STRUCTURE_TYPE_MEMORY_GET_NATIVE_BUFFER_INFO_OHOS = 1000452004,
    @VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_OHOS = 1000452005,
    @VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT = 1000453000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT = 1000455000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT = 1000455001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT = 1000458000,
    @VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT = 1000458001,
    @VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT = 1000458002,
    @VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT = 1000458003,
    @VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG = 1000459000,
    @VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG = 1000459001,
    @VK_STRUCTURE_TYPE_TENSOR_CREATE_INFO_ARM = 1000460000,
    @VK_STRUCTURE_TYPE_TENSOR_VIEW_CREATE_INFO_ARM = 1000460001,
    @VK_STRUCTURE_TYPE_BIND_TENSOR_MEMORY_INFO_ARM = 1000460002,
    @VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_TENSOR_ARM = 1000460003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_PROPERTIES_ARM = 1000460004,
    @VK_STRUCTURE_TYPE_TENSOR_FORMAT_PROPERTIES_ARM = 1000460005,
    @VK_STRUCTURE_TYPE_TENSOR_DESCRIPTION_ARM = 1000460006,
    @VK_STRUCTURE_TYPE_TENSOR_MEMORY_REQUIREMENTS_INFO_ARM = 1000460007,
    @VK_STRUCTURE_TYPE_TENSOR_MEMORY_BARRIER_ARM = 1000460008,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_FEATURES_ARM = 1000460009,
    @VK_STRUCTURE_TYPE_DEVICE_TENSOR_MEMORY_REQUIREMENTS_ARM = 1000460010,
    @VK_STRUCTURE_TYPE_COPY_TENSOR_INFO_ARM = 1000460011,
    @VK_STRUCTURE_TYPE_TENSOR_COPY_ARM = 1000460012,
    @VK_STRUCTURE_TYPE_TENSOR_DEPENDENCY_INFO_ARM = 1000460013,
    @VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_TENSOR_ARM = 1000460014,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_TENSOR_INFO_ARM = 1000460015,
    @VK_STRUCTURE_TYPE_EXTERNAL_TENSOR_PROPERTIES_ARM = 1000460016,
    @VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_TENSOR_CREATE_INFO_ARM = 1000460017,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_FEATURES_ARM = 1000460018,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_PROPERTIES_ARM = 1000460019,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_GET_TENSOR_INFO_ARM = 1000460020,
    @VK_STRUCTURE_TYPE_TENSOR_CAPTURE_DESCRIPTOR_DATA_INFO_ARM = 1000460021,
    @VK_STRUCTURE_TYPE_TENSOR_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_ARM = 1000460022,
    @VK_STRUCTURE_TYPE_FRAME_BOUNDARY_TENSORS_ARM = 1000460023,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_FEATURES_EXT = 1000462000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_PROPERTIES_EXT = 1000462001,
    @VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_MODULE_IDENTIFIER_CREATE_INFO_EXT = 1000462002,
    @VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT = 1000462003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT = 1000342000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_FEATURES_NV = 1000464000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV = 1000464001,
    @VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV = 1000464002,
    @VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_NV = 1000464003,
    @VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_INFO_NV = 1000464004,
    @VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV = 1000464005,
    @VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV = 1000464010,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT = 1000465000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_FEATURES_ANDROID = 1000468000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_PROPERTIES_ANDROID = 1000468001,
    @VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_RESOLVE_PROPERTIES_ANDROID = 1000468002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ANTI_LAG_FEATURES_AMD = 1000476000,
    @VK_STRUCTURE_TYPE_ANTI_LAG_DATA_AMD = 1000476001,
    @VK_STRUCTURE_TYPE_ANTI_LAG_PRESENTATION_INFO_AMD = 1000476002,
    @VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_ID_2_KHR = 1000479000,
    @VK_STRUCTURE_TYPE_PRESENT_ID_2_KHR = 1000479001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_2_FEATURES_KHR = 1000479002,
    @VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_WAIT_2_KHR = 1000480000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_2_FEATURES_KHR = 1000480001,
    @VK_STRUCTURE_TYPE_PRESENT_WAIT_2_INFO_KHR = 1000480002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_POSITION_FETCH_FEATURES_KHR = 1000481000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_FEATURES_EXT = 1000482000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_PROPERTIES_EXT = 1000482001,
    @VK_STRUCTURE_TYPE_SHADER_CREATE_INFO_EXT = 1000482002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_FEATURES_KHR = 1000483000,
    @VK_STRUCTURE_TYPE_PIPELINE_BINARY_CREATE_INFO_KHR = 1000483001,
    @VK_STRUCTURE_TYPE_PIPELINE_BINARY_INFO_KHR = 1000483002,
    @VK_STRUCTURE_TYPE_PIPELINE_BINARY_KEY_KHR = 1000483003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_PROPERTIES_KHR = 1000483004,
    @VK_STRUCTURE_TYPE_RELEASE_CAPTURED_PIPELINE_DATA_INFO_KHR = 1000483005,
    @VK_STRUCTURE_TYPE_PIPELINE_BINARY_DATA_INFO_KHR = 1000483006,
    @VK_STRUCTURE_TYPE_PIPELINE_CREATE_INFO_KHR = 1000483007,
    @VK_STRUCTURE_TYPE_DEVICE_PIPELINE_BINARY_INTERNAL_CACHE_CONTROL_KHR = 1000483008,
    @VK_STRUCTURE_TYPE_PIPELINE_BINARY_HANDLES_INFO_KHR = 1000483009,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM = 1000484000,
    @VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM = 1000484001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC = 1000485000,
    @VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC = 1000485001,
    @VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_KHR = 1000274000,
    @VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_KHR = 1000274001,
    @VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_KHR = 1000274002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_KHR = 1000275000,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_KHR = 1000275001,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_KHR = 1000275002,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_KHR = 1000275003,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_KHR = 1000275004,
    @VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_KHR = 1000275005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM = 1000488000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV = 1000490000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV = 1000490001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_FEATURES_NV = 1000491000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_PROPERTIES_NV = 1000491001,
    @VK_STRUCTURE_TYPE_COOPERATIVE_VECTOR_PROPERTIES_NV = 1000491002,
    @VK_STRUCTURE_TYPE_CONVERT_COOPERATIVE_VECTOR_MATRIX_INFO_NV = 1000491004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_FEATURES_NV = 1000492000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_PROPERTIES_NV = 1000492001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT = 1000351000,
    @VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT = 1000351002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_FEATURES_EXT = 1000495000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_PROPERTIES_EXT = 1000495001,
    @VK_STRUCTURE_TYPE_LAYER_SETTINGS_CREATE_INFO_EXT = 1000496000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM = 1000497000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM = 1000497001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_LIBRARY_GROUP_HANDLES_FEATURES_EXT = 1000498000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_FEATURES_EXT = 1000499000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INTERNALLY_SYNCHRONIZED_QUEUES_FEATURES_KHR = 1000504000,
    @VK_STRUCTURE_TYPE_LATENCY_SLEEP_MODE_INFO_NV = 1000505000,
    @VK_STRUCTURE_TYPE_LATENCY_SLEEP_INFO_NV = 1000505001,
    @VK_STRUCTURE_TYPE_SET_LATENCY_MARKER_INFO_NV = 1000505002,
    @VK_STRUCTURE_TYPE_GET_LATENCY_MARKER_INFO_NV = 1000505003,
    @VK_STRUCTURE_TYPE_LATENCY_TIMINGS_FRAME_REPORT_NV = 1000505004,
    @VK_STRUCTURE_TYPE_LATENCY_SUBMISSION_PRESENT_ID_NV = 1000505005,
    @VK_STRUCTURE_TYPE_OUT_OF_BAND_QUEUE_TYPE_INFO_NV = 1000505006,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_LATENCY_CREATE_INFO_NV = 1000505007,
    @VK_STRUCTURE_TYPE_LATENCY_SURFACE_CAPABILITIES_NV = 1000505008,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_KHR = 1000506000,
    @VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_KHR = 1000506001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_KHR = 1000506002,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CREATE_INFO_ARM = 1000507000,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_CREATE_INFO_ARM = 1000507001,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_RESOURCE_INFO_ARM = 1000507002,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_ARM = 1000507003,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_MEMORY_REQUIREMENTS_INFO_ARM = 1000507004,
    @VK_STRUCTURE_TYPE_BIND_DATA_GRAPH_PIPELINE_SESSION_MEMORY_INFO_ARM = 1000507005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_FEATURES_ARM = 1000507006,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SHADER_MODULE_CREATE_INFO_ARM = 1000507007,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_PROPERTY_QUERY_RESULT_ARM = 1000507008,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_INFO_ARM = 1000507009,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_COMPILER_CONTROL_CREATE_INFO_ARM = 1000507010,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENTS_INFO_ARM = 1000507011,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENT_ARM = 1000507012,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_IDENTIFIER_CREATE_INFO_ARM = 1000507013,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_DISPATCH_INFO_ARM = 1000507014,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PROCESSING_ENGINE_CREATE_INFO_ARM = 1000507016,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_PROPERTIES_ARM = 1000507017,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROPERTIES_ARM = 1000507018,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_INFO_ARM = 1000507019,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_TENSOR_SEMI_STRUCTURED_SPARSITY_INFO_ARM = 1000507015,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_TOSA_PROPERTIES_ARM = 1000508000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM = 1000510000,
    @VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM = 1000510001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_KHR = 1000201000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_PROPERTIES_KHR = 1000511000,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_CAPABILITIES_KHR = 1000512000,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PICTURE_INFO_KHR = 1000512001,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PROFILE_INFO_KHR = 1000512003,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000512004,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_DPB_SLOT_INFO_KHR = 1000512005,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_CAPABILITIES_KHR = 1000513000,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000513001,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PICTURE_INFO_KHR = 1000513002,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_DPB_SLOT_INFO_KHR = 1000513003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_AV1_FEATURES_KHR = 1000513004,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PROFILE_INFO_KHR = 1000513005,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_INFO_KHR = 1000513006,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_LAYER_INFO_KHR = 1000513007,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUALITY_LEVEL_PROPERTIES_KHR = 1000513008,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_CREATE_INFO_KHR = 1000513009,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_GOP_REMAINING_FRAME_INFO_KHR = 1000513010,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_DECODE_VP9_FEATURES_KHR = 1000514000,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_CAPABILITIES_KHR = 1000514001,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PICTURE_INFO_KHR = 1000514002,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PROFILE_INFO_KHR = 1000514003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_1_FEATURES_KHR = 1000515000,
    @VK_STRUCTURE_TYPE_VIDEO_INLINE_QUERY_INFO_KHR = 1000515001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PER_STAGE_DESCRIPTOR_SET_FEATURES_NV = 1000516000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_FEATURES_QCOM = 1000518000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_PROPERTIES_QCOM = 1000518001,
    @VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM = 1000518002,
    @VK_STRUCTURE_TYPE_SAMPLER_CUBIC_WEIGHTS_CREATE_INFO_QCOM = 1000519000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_WEIGHTS_FEATURES_QCOM = 1000519001,
    @VK_STRUCTURE_TYPE_BLIT_IMAGE_CUBIC_WEIGHTS_INFO_QCOM = 1000519002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_DEGAMMA_FEATURES_QCOM = 1000520000,
    @VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM = 1000520001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_CLAMP_FEATURES_QCOM = 1000521000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_FEATURES_EXT = 1000524000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFIED_IMAGE_LAYOUTS_FEATURES_KHR = 1000527000,
    @VK_STRUCTURE_TYPE_ATTACHMENT_FEEDBACK_LOOP_INFO_EXT = 1000527001,
    @VK_STRUCTURE_TYPE_SCREEN_BUFFER_PROPERTIES_QNX = 1000529000,
    @VK_STRUCTURE_TYPE_SCREEN_BUFFER_FORMAT_PROPERTIES_QNX = 1000529001,
    @VK_STRUCTURE_TYPE_IMPORT_SCREEN_BUFFER_INFO_QNX = 1000529002,
    @VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_QNX = 1000529003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCREEN_BUFFER_FEATURES_QNX = 1000529004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_DRIVER_PROPERTIES_MSFT = 1000530000,
    @VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_KHR = 1000184000,
    @VK_STRUCTURE_TYPE_SET_DESCRIPTOR_BUFFER_OFFSETS_INFO_EXT = 1000545007,
    @VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_BUFFER_EMBEDDED_SAMPLERS_INFO_EXT = 1000545008,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_POOL_OVERALLOCATION_FEATURES_NV = 1000546000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_FEATURES_QCOM = 1000547000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_PROPERTIES_QCOM = 1000547001,
    @VK_STRUCTURE_TYPE_TILE_MEMORY_REQUIREMENTS_QCOM = 1000547002,
    @VK_STRUCTURE_TYPE_TILE_MEMORY_BIND_INFO_QCOM = 1000547003,
    @VK_STRUCTURE_TYPE_TILE_MEMORY_SIZE_INFO_QCOM = 1000547004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_KHR = 1000549000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_KHR = 1000426001,
    @VK_STRUCTURE_TYPE_COPY_MEMORY_INDIRECT_INFO_KHR = 1000549002,
    @VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INDIRECT_INFO_KHR = 1000549003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_EXT = 1000427000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_EXT = 1000427001,
    @VK_STRUCTURE_TYPE_DECOMPRESS_MEMORY_INFO_EXT = 1000550002,
    @VK_STRUCTURE_TYPE_DISPLAY_SURFACE_STEREO_CREATE_INFO_NV = 1000551000,
    @VK_STRUCTURE_TYPE_DISPLAY_MODE_STEREO_PROPERTIES_NV = 1000551001,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_CAPABILITIES_KHR = 1000552000,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_INTRA_REFRESH_CREATE_INFO_KHR = 1000552001,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_INFO_KHR = 1000552002,
    @VK_STRUCTURE_TYPE_VIDEO_REFERENCE_INTRA_REFRESH_INFO_KHR = 1000552003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_INTRA_REFRESH_FEATURES_KHR = 1000552004,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553000,
    @VK_STRUCTURE_TYPE_VIDEO_FORMAT_QUANTIZATION_MAP_PROPERTIES_KHR = 1000553001,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_INFO_KHR = 1000553002,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000553005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUANTIZATION_MAP_FEATURES_KHR = 1000553009,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553003,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553004,
    @VK_STRUCTURE_TYPE_VIDEO_FORMAT_H265_QUANTIZATION_MAP_PROPERTIES_KHR = 1000553006,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553007,
    @VK_STRUCTURE_TYPE_VIDEO_FORMAT_AV1_QUANTIZATION_MAP_PROPERTIES_KHR = 1000553008,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAW_ACCESS_CHAINS_FEATURES_NV = 1000555000,
    @VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DEVICE_CREATE_INFO_NV = 1000556000,
    @VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_CREATE_INFO_NV = 1000556001,
    @VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DATA_PARAMS_NV = 1000556002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_COMPUTE_QUEUE_PROPERTIES_NV = 1000556003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_RELAXED_EXTENDED_INSTRUCTION_FEATURES_KHR = 1000558000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMMAND_BUFFER_INHERITANCE_FEATURES_NV = 1000559000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_FEATURES_KHR = 1000562000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_PROPERTIES_KHR = 1000562001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_LIST_KHR = 1000562002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_KHR = 1000562003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_VULKAN_PROPERTIES_KHR = 1000562004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT16_VECTOR_FEATURES_NV = 1000563000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_REPLICATED_COMPOSITES_FEATURES_EXT = 1000564000,
    @VK_STRUCTURE_TYPE_TENSOR_EXPLICIT_TILING_FORMAT_PROPERTIES_ARM = 1000565000,
    @VK_STRUCTURE_TYPE_TENSOR_ROLLING_BACKING_CREATE_INFO_ARM = 1000565001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT8_FEATURES_EXT = 1000567000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_VALIDATION_FEATURES_NV = 1000568000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_FEATURES_NV = 1000569000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_PROPERTIES_NV = 1000569001,
    @VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_CLUSTERS_BOTTOM_LEVEL_INPUT_NV = 1000569002,
    @VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_TRIANGLE_CLUSTER_INPUT_NV = 1000569003,
    @VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_MOVE_OBJECTS_INPUT_NV = 1000569004,
    @VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_INPUT_INFO_NV = 1000569005,
    @VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_COMMANDS_INFO_NV = 1000569006,
    @VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CLUSTER_ACCELERATION_STRUCTURE_CREATE_INFO_NV = 1000569007,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_FEATURES_NV = 1000570000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_PROPERTIES_NV = 1000570001,
    @VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_PARTITIONED_ACCELERATION_STRUCTURE_NV = 1000570002,
    @VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCES_INPUT_NV = 1000570003,
    @VK_STRUCTURE_TYPE_BUILD_PARTITIONED_ACCELERATION_STRUCTURE_INFO_NV = 1000570004,
    @VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_FLAGS_NV = 1000570005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_EXT = 1000572000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_EXT = 1000572001,
    @VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_EXT = 1000572002,
    @VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_CREATE_INFO_EXT = 1000572003,
    @VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_EXT = 1000572004,
    @VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_EXT = 1000572006,
    @VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_EXT = 1000572007,
    @VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_PIPELINE_EXT = 1000572008,
    @VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_SHADER_EXT = 1000572009,
    @VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_PIPELINE_INFO_EXT = 1000572010,
    @VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_INFO_EXT = 1000572011,
    @VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_LAYOUT_INFO_EXT = 1000572012,
    @VK_STRUCTURE_TYPE_GENERATED_COMMANDS_PIPELINE_INFO_EXT = 1000572013,
    @VK_STRUCTURE_TYPE_GENERATED_COMMANDS_SHADER_INFO_EXT = 1000572014,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_KHR = 1000573000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_PROPERTIES_KHR = 1000573001,
    @VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_KHR = 1000573002,
    @VK_STRUCTURE_TYPE_DEVICE_FAULT_DEBUG_INFO_KHR = 1000573003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_8_FEATURES_KHR = 1000574000,
    @VK_STRUCTURE_TYPE_MEMORY_BARRIER_ACCESS_FLAGS_3_KHR = 1000574002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_FEATURES_MESA = 1000575000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_PROPERTIES_MESA = 1000575001,
    @VK_STRUCTURE_TYPE_IMAGE_ALIGNMENT_CONTROL_CREATE_INFO_MESA = 1000575002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FMA_FEATURES_KHR = 1000579000,
    @VK_STRUCTURE_TYPE_PUSH_CONSTANT_BANK_INFO_NV = 1000580000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_CONSTANT_BANK_FEATURES_NV = 1000580001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_CONSTANT_BANK_PROPERTIES_NV = 1000580002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_EXT = 1000581000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_EXT = 1000581001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_CONTROL_FEATURES_EXT = 1000582000,
    @VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLAMP_CONTROL_CREATE_INFO_EXT = 1000582001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_FEATURES_KHR = 1000584000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_PROPERTIES_KHR = 1000584001,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_OWNERSHIP_TRANSFER_PROPERTIES_KHR = 1000584002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_2_FEATURES_KHR = 1000586000,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_INLINE_SESSION_PARAMETERS_INFO_KHR = 1000586001,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_INLINE_SESSION_PARAMETERS_INFO_KHR = 1000586002,
    @VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_INLINE_SESSION_PARAMETERS_INFO_KHR = 1000586003,
    @VK_STRUCTURE_TYPE_SURFACE_CREATE_INFO_OHOS = 1000685000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HDR_VIVID_FEATURES_HUAWEI = 1000590000,
    @VK_STRUCTURE_TYPE_HDR_VIVID_DYNAMIC_METADATA_HUAWEI = 1000590001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_FEATURES_NV = 1000593000,
    @VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_FLEXIBLE_DIMENSIONS_PROPERTIES_NV = 1000593001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_PROPERTIES_NV = 1000593002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_OPACITY_MICROMAP_FEATURES_ARM = 1000596000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_FEEDBACK_2_FEATURES_KHR = 1000598000,
    @VK_STRUCTURE_TYPE_VIDEO_ENCODE_FEEDBACK_2_CAPABILITIES_KHR = 1000598001,
    @VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_CREATE_INFO_KHR = 1000598002,
    @VK_STRUCTURE_TYPE_IMPORT_MEMORY_METAL_HANDLE_INFO_EXT = 1000602000,
    @VK_STRUCTURE_TYPE_MEMORY_METAL_HANDLE_PROPERTIES_EXT = 1000602001,
    @VK_STRUCTURE_TYPE_MEMORY_GET_METAL_HANDLE_INFO_EXT = 1000602002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_KHR = 1000421000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_FEATURES_ARM = 1000605000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_PROPERTIES_ARM = 1000605001,
    @VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_ARM = 1000605002,
    @VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_ARM = 1000605003,
    @VK_STRUCTURE_TYPE_RENDER_PASS_PERFORMANCE_COUNTERS_BY_REGION_BEGIN_INFO_ARM = 1000605004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INSTRUMENTATION_FEATURES_ARM = 1000607000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INSTRUMENTATION_PROPERTIES_ARM = 1000607001,
    @VK_STRUCTURE_TYPE_SHADER_INSTRUMENTATION_CREATE_INFO_ARM = 1000607002,
    @VK_STRUCTURE_TYPE_SHADER_INSTRUMENTATION_METRIC_DESCRIPTION_ARM = 1000607003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_ROBUSTNESS_FEATURES_EXT = 1000608000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FORMAT_PACK_FEATURES_ARM = 1000609000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_FEATURES_VALVE = 1000611000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_PROPERTIES_VALVE = 1000611001,
    @VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_DENSITY_MAP_LAYERED_CREATE_INFO_VALVE = 1000611002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_KHR = 1000286000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_KHR = 1000286001,
    @VK_STRUCTURE_TYPE_SET_PRESENT_CONFIG_NV = 1000613000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_METERING_FEATURES_NV = 1000613001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SWAPCHAIN_FEATURES_EXT = 1000616000,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_FLAGS_SURFACE_CAPABILITIES_EXT = 1000616001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_EXT = 1000425000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_EXT = 1000425001,
    @VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_EXT = 1000425002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_DEVICE_MEMORY_FEATURES_EXT = 1000620000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_KHR = 1000361000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_KHR = 1000623000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_KHR = 1000623001,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MICROMAP_DATA_KHR = 1000623002,
    @VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_KHR = 1000623003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_64_BIT_INDEXING_FEATURES_EXT = 1000627000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_RESOLVE_FEATURES_EXT = 1000628000,
    @VK_STRUCTURE_TYPE_BEGIN_CUSTOM_RESOLVE_INFO_EXT = 1000628001,
    @VK_STRUCTURE_TYPE_CUSTOM_RESOLVE_CREATE_INFO_EXT = 1000628002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_MODEL_FEATURES_QCOM = 1000629000,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_BUILTIN_MODEL_CREATE_INFO_QCOM = 1000629001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_FEATURES_KHR = 1000630000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_PROPERTIES_KHR = 1000630001,
    @VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_FLAGS_INFO_KHR = 1000630002,
    @VK_STRUCTURE_TYPE_RENDERING_END_INFO_KHR = 1000619003,
    @VK_STRUCTURE_TYPE_RESOLVE_IMAGE_MODE_INFO_KHR = 1000630004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_OPTICAL_FLOW_FEATURES_ARM = 1000631000,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_OPTICAL_FLOW_PROPERTIES_ARM = 1000631001,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_OPTICAL_FLOW_IMAGE_FORMAT_INFO_ARM = 1000631003,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_ARM = 1000631004,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_OPTICAL_FLOW_DISPATCH_INFO_ARM = 1000631005,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_OPTICAL_FLOW_CREATE_INFO_ARM = 1000631002,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_RESOURCE_INFO_IMAGE_LAYOUT_ARM = 1000631006,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SINGLE_NODE_CREATE_INFO_ARM = 1000631007,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SINGLE_NODE_CONNECTION_ARM = 1000631008,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_LONG_VECTOR_FEATURES_EXT = 1000635000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_LONG_VECTOR_PROPERTIES_EXT = 1000635001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CACHE_INCREMENTAL_MODE_FEATURES_SEC = 1000637000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNIFORM_BUFFER_UNSIZED_ARRAY_FEATURES_EXT = 1000642000,
    @VK_STRUCTURE_TYPE_COMPUTE_OCCUPANCY_PRIORITY_PARAMETERS_NV = 1000645000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_OCCUPANCY_PRIORITY_FEATURES_NV = 1000645001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_11_FEATURES_KHR = 1000657000,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_OPTIMAL_IMAGE_TRANSFER_GRANULARITY_PROPERTIES_KHR = 1000657001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_PARTITIONED_FEATURES_EXT = 1000662000,
    @VK_STRUCTURE_TYPE_UBM_SURFACE_CREATE_INFO_SEC = 1000664000,
    @VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_4_KHR = 1000668000,
    @VK_STRUCTURE_TYPE_IMAGE_CREATE_FLAGS_2_CREATE_INFO_KHR = 1000668001,
    @VK_STRUCTURE_TYPE_IMAGE_USAGE_FLAGS_2_CREATE_INFO_KHR = 1000668002,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_2_CREATE_INFO_KHR = 1000668003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_FLAGS_FEATURES_KHR = 1000668004,
    @VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_2_CREATE_INFO_KHR = 1000668005,
    @VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_2_KHR = 1000668006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OCP_MICROSCALING_TYPES_FEATURES_EXT = 1000672000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MIXED_FLOAT_DOT_PRODUCT_FEATURES_VALVE = 1000673000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_THROTTLE_HINT_FEATURES_SEC = 1000674000,
    @VK_STRUCTURE_TYPE_THROTTLE_HINT_SUBMIT_INFO_SEC = 1000674001,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_NEURAL_STATISTICS_CREATE_INFO_ARM = 1000676000,
    @VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_NEURAL_STATISTICS_CREATE_INFO_ARM = 1000676001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_NEURAL_ACCELERATOR_STATISTICS_FEATURES_ARM = 1000676002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_RESTART_INDEX_FEATURES_EXT = 1000678000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_DECODE_VECTOR_FEATURES_NV = 1000689000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES = 1000120000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETER_FEATURES = 1000063000,
    @VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT = 1000011000,
    @VK_STRUCTURE_TYPE_RENDERING_INFO_KHR = 1000044000,
    @VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO_KHR = 1000044001,
    @VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO_KHR = 1000044002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES_KHR = 1000044003,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO_KHR = 1000044004,
    @VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR = 1000053000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR = 1000053001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR = 1000053002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR = 1000059000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR = 1000059001,
    @VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR = 1000059002,
    @VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR = 1000059003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR = 1000059004,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR = 1000059005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR = 1000059006,
    @VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR = 1000059007,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR = 1000059008,
    @VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR = 1000060000,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR = 1000060003,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR = 1000060004,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR = 1000060005,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR = 1000060006,
    @VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR = 1000060013,
    @VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR = 1000060014,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT = 1000066000,
    @VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT = 1000068000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES_EXT = 1000068001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT = 1000068002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR = 1000070000,
    @VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR = 1000070001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR = 1000071000,
    @VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR = 1000071001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR = 1000071002,
    @VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR = 1000071003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR = 1000071004,
    @VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR = 1000072000,
    @VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR = 1000072001,
    @VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR = 1000072002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR = 1000076000,
    @VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR = 1000076001,
    @VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR = 1000077000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR = 1000080000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR = 1000082000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR = 1000082000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR = 1000083000,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR = 1000085000,
    @VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT = 1000090000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES_KHR = 1000108000,
    @VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO_KHR = 1000108001,
    @VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO_KHR = 1000108002,
    @VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO_KHR = 1000108003,
    @VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR = 1000109000,
    @VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR = 1000109001,
    @VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR = 1000109002,
    @VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR = 1000109003,
    @VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR = 1000109004,
    @VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR = 1000109005,
    @VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR = 1000109006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR = 1000112000,
    @VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR = 1000112001,
    @VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR = 1000113000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR = 1000117000,
    @VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR = 1000117001,
    @VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR = 1000117002,
    @VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR = 1000117003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR = 1000120000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR = 1000120000,
    @VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR = 1000127000,
    @VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR = 1000127001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT = 1000130000,
    @VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT = 1000130001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT = 1000138000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT = 1000138001,
    @VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT = 1000138002,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT = 1000138003,
    @VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR = 1000146000,
    @VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR = 1000146001,
    @VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR = 1000146002,
    @VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR = 1000146003,
    @VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR = 1000146004,
    @VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR = 1000147000,
    @VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_NV = 1000044008,
    @VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR = 1000156000,
    @VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR = 1000156001,
    @VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR = 1000156002,
    @VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR = 1000156003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR = 1000156004,
    @VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR = 1000156005,
    @VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR = 1000157000,
    @VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR = 1000157001,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT = 1000161000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT = 1000161001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT = 1000161002,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT = 1000161003,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT = 1000161004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR = 1000168000,
    @VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR = 1000168001,
    @VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT = 1000174000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR = 1000175000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR = 1000177000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR = 1000180000,
    @VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT = 1000184000,
    @VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR = 1000174000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR = 1000388000,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR = 1000388001,
    @VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT = 1000190001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT = 1000190002,
    @VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT = 1000192000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR = 1000196000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR = 1000197000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR = 1000199000,
    @VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR = 1000199001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV = 1000201000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV = 1000203000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR = 1000207000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR = 1000207001,
    @VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO_KHR = 1000207002,
    @VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR = 1000207003,
    @VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO_KHR = 1000207004,
    @VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO_KHR = 1000207005,
    @VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO_INTEL = 1000210000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR = 1000211000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR = 1000215000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT = 1000221000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT = 1000225000,
    @VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT = 1000225001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT = 1000225002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES_KHR = 1000232000,
    @VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO_KHR = 1000232001,
    @VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO_KHR = 1000232002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES_KHR = 1000241000,
    @VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT_KHR = 1000241001,
    @VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT_KHR = 1000241002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT = 1000244000,
    @VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT = 1000244001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT = 1000245000,
    @VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT = 1000246000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR = 1000253000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR = 1000257000,
    @VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_KHR = 1000244001,
    @VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR = 1000257002,
    @VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR = 1000257003,
    @VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR = 1000257004,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT = 1000259000,
    @VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT = 1000259001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT = 1000259002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT = 1000261000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT = 1000265000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES_EXT = 1000270000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES_EXT = 1000270001,
    @VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY_EXT = 1000270002,
    @VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY_EXT = 1000270003,
    @VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO_EXT = 1000270004,
    @VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO_EXT = 1000270005,
    @VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO_EXT = 1000270006,
    @VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO_EXT = 1000270007,
    @VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE_EXT = 1000270008,
    @VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY_EXT = 1000270009,
    @VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR = 1000271000,
    @VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR = 1000271001,
    @VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT = 1000274000,
    @VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT = 1000274001,
    @VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT = 1000274002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT = 1000275000,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT = 1000275001,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT = 1000275002,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT = 1000275003,
    @VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT = 1000275004,
    @VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT = 1000275005,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT = 1000276000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES_KHR = 1000280000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES_KHR = 1000280001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT = 1000281001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT = 1000286000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT = 1000286001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT = 1000295000,
    @VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT = 1000295001,
    @VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT = 1000295002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT = 1000297000,
    @VK_STRUCTURE_TYPE_MEMORY_BARRIER_2_KHR = 1000314000,
    @VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2_KHR = 1000314001,
    @VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2_KHR = 1000314002,
    @VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR = 1000314003,
    @VK_STRUCTURE_TYPE_SUBMIT_INFO_2_KHR = 1000314004,
    @VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR = 1000314005,
    @VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR = 1000314006,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR = 1000314007,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR = 1000325000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT = 1000335000,
    @VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR = 1000337000,
    @VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR = 1000337001,
    @VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR = 1000337002,
    @VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR = 1000337003,
    @VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR = 1000337004,
    @VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR = 1000337005,
    @VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR = 1000337006,
    @VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR = 1000337007,
    @VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR = 1000337008,
    @VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR = 1000337009,
    @VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR = 1000337010,
    @VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_EXT = 1000338002,
    @VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_EXT = 1000338003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_ARM = 1000342000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE = 1000351000,
    @VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE = 1000351002,
    @VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3_KHR = 1000360000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_EXT = 1000361000,
    @VK_STRUCTURE_TYPE_PIPELINE_INFO_EXT = 1000269001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT = 1000388000,
    @VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT = 1000388001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES_KHR = 1000413000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES_KHR = 1000413001,
    @VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS_KHR = 1000413002,
    @VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS_KHR = 1000413003,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES_KHR = 1000416000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT = 1000421000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM = 1000425000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM = 1000425001,
    @VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM = 1000425002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_NV = 1000426001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_NV = 1000427000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV = 1000427001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT = 1000466000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES_KHR = 1000470000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES_KHR = 1000470001,
    @VK_STRUCTURE_TYPE_RENDERING_AREA_INFO_KHR = 1000470003,
    @VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO_KHR = 1000470004,
    @VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_KHR = 1000338002,
    @VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_KHR = 1000338003,
    @VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO_KHR = 1000470005,
    @VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO_KHR = 1000470006,
    @VK_STRUCTURE_TYPE_SHADER_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT = 1000225001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_KHR = 1000525000,
    @VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_KHR = 1000190001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_KHR = 1000190002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES_KHR = 1000528000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_KHR = 1000265000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_KHR = 1000259000,
    @VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_KHR = 1000259001,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_KHR = 1000259002,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES_KHR = 1000544000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES_KHR = 1000545000,
    @VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES_KHR = 1000545001,
    @VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS_KHR = 1000545002,
    @VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO_KHR = 1000545003,
    @VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO_KHR = 1000545004,
    @VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO_KHR = 1000545005,
    @VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO_KHR = 1000545006,
    @VK_STRUCTURE_TYPE_RENDERING_END_INFO_EXT = 1000619003,
    @VK_STRUCTURE_TYPE_MAX_ENUM = 2147483647,
}

public enum _VkVideoCodecOperationFlagBitsKHR : int
{
    @VK_VIDEO_CODEC_OPERATION_NONE_KHR = 0,
    @VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_KHR = 65536,
    @VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_KHR = 131072,
    @VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR = 1,
    @VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR = 2,
    @VK_VIDEO_CODEC_OPERATION_DECODE_AV1_BIT_KHR = 4,
    @VK_VIDEO_CODEC_OPERATION_ENCODE_AV1_BIT_KHR = 262144,
    @VK_VIDEO_CODEC_OPERATION_DECODE_VP9_BIT_KHR = 8,
    @VK_VIDEO_CODEC_OPERATION_FLAG_BITS_MAX_ENUM_KHR = 2147483647,
}

/// <summary>@{</summary>
public enum AvBuffersrcFlag : int
{
    /// <summary>Do not check for format changes.</summary>
    @AV_BUFFERSRC_FLAG_NO_CHECK_FORMAT = 1,
    /// <summary>Immediately push the frame to the output.</summary>
    @AV_BUFFERSRC_FLAG_PUSH = 4,
    /// <summary>Keep a reference to the frame. If the frame if reference-counted, create a new reference; otherwise copy the frame data.</summary>
    @AV_BUFFERSRC_FLAG_KEEP_REF = 8,
}

public enum AvCodecHwConfigMethod : int
{
    /// <summary>The codec supports this format via the hw_device_ctx interface.</summary>
    @AV_CODEC_HW_CONFIG_METHOD_HW_DEVICE_CTX = 1,
    /// <summary>The codec supports this format via the hw_frames_ctx interface.</summary>
    @AV_CODEC_HW_CONFIG_METHOD_HW_FRAMES_CTX = 2,
    /// <summary>The codec supports this format by some internal method.</summary>
    @AV_CODEC_HW_CONFIG_METHOD_INTERNAL = 4,
    /// <summary>The codec supports this format by some ad-hoc method.</summary>
    @AV_CODEC_HW_CONFIG_METHOD_AD_HOC = 8,
}

public enum AvfilterAutoConvert : int
{
    /// <summary>all automatic conversions enabled</summary>
    @AVFILTER_AUTO_CONVERT_ALL = 0,
    /// <summary>all automatic conversions disabled</summary>
    @AVFILTER_AUTO_CONVERT_NONE = -1,
}

/// <summary>Flags for frame cropping.</summary>
public enum AvFrameCrop : int
{
    /// <summary>Apply the maximum possible cropping, even if it requires setting the AVFrame.data[] entries to unaligned pointers. Passing unaligned data to FFmpeg API is generally not allowed, and causes undefined behavior (such as crashes). You can pass unaligned data only to FFmpeg APIs that are explicitly documented to accept it. Use this flag only if you absolutely know what you are doing.</summary>
    @AV_FRAME_CROP_UNALIGNED = 1,
}

/// <summary>Flags to apply to frame mappings.</summary>
public enum AvHwframeMap : int
{
    /// <summary>The mapping must be readable.</summary>
    @AV_HWFRAME_MAP_READ = 1,
    /// <summary>The mapping must be writeable.</summary>
    @AV_HWFRAME_MAP_WRITE = 2,
    /// <summary>The mapped frame will be overwritten completely in subsequent operations, so the current frame data need not be loaded. Any values which are not overwritten are unspecified.</summary>
    @AV_HWFRAME_MAP_OVERWRITE = 4,
    /// <summary>The mapping must be direct. That is, there must not be any copying in the map or unmap steps. Note that performance of direct mappings may be much lower than normal memory.</summary>
    @AV_HWFRAME_MAP_DIRECT = 8,
}

public enum AvOptFlagImplicit : int
{
    /// <summary>Accept to parse a value without a key; the key will then be returned as NULL.</summary>
    @AV_OPT_FLAG_IMPLICIT_KEY = 1,
}

