using System;
using System.Collections.Generic;
using System.Text;

namespace FFmpeg.AutoGen;

public partial struct _AVCodecTag
{
    public _AVCodecID id;
    public uint tag;

    public readonly override string ToString() => $"{ffmpeg.TAG_TO_STRING(tag)}/{id}";
}
