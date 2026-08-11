namespace FFmpeg.AutoGen;

public partial struct _AVCodecTag
{
    public _AVCodecID id;
    public uint tag;

    public override readonly string ToString() => $"{ffmpeg.TAG_TO_STRING(tag)}/{id}";
}
