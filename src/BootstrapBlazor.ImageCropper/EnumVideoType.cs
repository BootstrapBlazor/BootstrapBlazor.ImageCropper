// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************

using System.ComponentModel;

namespace BootstrapBlazor.Components;

/// <summary>
/// 类型
/// </summary>
public enum EnumCropper
{
    [Description("video/ogg")]
    opus,
    [Description("video/ogg")]
    ogv,
    [Description("video/mp4")]
    mp4,
    [Description("video/mp4")]
    mov,
    [Description("video/mp4")]
    m4v,
    [Description("video/x-matroska")]
    mkv,
    [Description("audio/mp4")]
    m4a,
    [Description("audio/mpeg")]
    mp3,
    [Description("audio/aac")]
    aac,
    [Description("audio/x-caf")]
    caf,
    [Description("audio/flac")]
    flac,
    [Description("audio/ogg")]
    oga,
    [Description("audio/wav")]
    wav,
    [Description("application/x-mpegURL")]
    m3u8,
    [Description("application/dash+xml")]
    mpd,
    [Description("image/jpeg")]
    jpg,
    [Description("image/jpeg")]
    jpeg,
    [Description("image/gif")]
    gif,
    [Description("image/png")]
    png,
    [Description("image/svg+xml")]
    svg,
    [Description("image/webp")]
    webp,

}
