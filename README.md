# Blazor ImageCropper 图像裁剪 组件  

基于[Cropper.js](https://github.com/fengyuanchen/cropperjs)的Blazor组件

示例:

https://www.blazor.zone/ImageCroppers

https://blazor.app1.es/ImageCroppers

使用方法:

1.nuget包

```BootstrapBlazor.ImageCropper```

2._Imports.razor 文件 或者页面添加 添加组件库引用

```@using BootstrapBlazor.Components```


3.razor页面
```
<ImageCropper Url="./_content/DemoShared/icon-512.png" OnBase64Result="OnResult" />

@code{

    Task OnResult(string base64)
    {
        Console.WriteLine(base64);
        return Task.CompletedTask;
    }

}

<ImageCropper @ref="cropper" Url="@images[0]" DefaultButton="false" />

<BootstrapInputGroup>
    <Button Text="OK" OnClick="(async () => Base64 = await cropper.Crop())" />
    <Button Text="复位" OnClick="cropper.Reset" /> 
    <Button Text="替换" OnClick="(async () => {
                                   index = index == 0 ? 1 : 0;
                                   await cropper.Replace(images[index]); 
                               })" />
</BootstrapInputGroup>

<br/>
<Textarea Value="@Base64" rows="3" />

@code{

    ImageCropper? cropper;

    string[] images = ["./_content/DemoShared/test.jpg", "./_content/DemoShared/icon-512.png"];

    int index = 0;

    string? Base64 { get; set; } 

}

```

4.参数说明

|  类型   |  参数   | 说明  | 默认值  | 
|  ----  |  ----  | ----  | ----  | 
| string | Url  | 图片URL/Base64 dataurl |  | 
| string | ConfirmBtnTitle  | 确认按钮文本 | OK | 
| string | ResetBtnTitle  | 复位按钮文本 | 复位 | 
| string | PreviewTitle  | 预览文本 | 预览 |  
| bool | DefaultButton  | 显示默认按钮 | true | 
| bool | Preview  | 显示剪裁后预览 | true | 
| Task<string> |  Crop | 剪裁,返回 base64, 并执行 OnResult/OnBase64Result 回调 | |
| Task<Stream> |  CropToStream | 剪裁,返回 Stream | |
| Task |  Replace(string url) | 替换图片 | |
| Task |  SetDragMode(string? mode) | 更改拖动模式 | |
| Task |  Enable | 组件可用 | |
| Task |  Disable | 禁用组件 | |
| Task |  Reset | 复位图像 | |
| Task |  Clear | 清空图像 | |
| Task |  Destroy | 销毁 | |
| Task |  Rotate(int degree) |  旋转, 90, 180, 270, -90 ... | |
| Func<Stream, Task>  | OnResult | 剪裁结果 Stream 回调方法 | |
| Func<string, Task>  | OnBase64Result  | 剪裁结果 base64 回调方法 | |
| Func&lt;string, Task&gt;? |  OnError | 错误回调 |
| string | CssClass  | 自定义图片 CSS | null | 
| string | CssPath  | 自定义CSS | null | 
| string | ModulePath  | 自定义cropper.js路径 | null | 


#### 更新历史


---
#### Blazor 组件

[条码扫描 ZXingBlazor](https://www.nuget.org/packages/ZXingBlazor#readme-body-tab)
[![nuget](https://img.shields.io/nuget/v/ZXingBlazor.svg?style=flat-square)](https://www.nuget.org/packages/ZXingBlazor) 
[![stats](https://img.shields.io/nuget/dt/ZXingBlazor.svg?style=flat-square)](https://www.nuget.org/stats/packages/ZXingBlazor?groupby=Version)

[图片浏览器 Viewer](https://www.nuget.org/packages/BootstrapBlazor.Viewer#readme-body-tab)

[手写签名 SignaturePad](https://www.nuget.org/packages/BootstrapBlazor.SignaturePad#readme-body-tab)

[定位/持续定位 Geolocation](https://www.nuget.org/packages/BootstrapBlazor.Geolocation#readme-body-tab)

[屏幕键盘 OnScreenKeyboard](https://www.nuget.org/packages/BootstrapBlazor.OnScreenKeyboard#readme-body-tab)

[百度地图 BaiduMap](https://www.nuget.org/packages/BootstrapBlazor.BaiduMap#readme-body-tab)

[谷歌地图 GoogleMap](https://www.nuget.org/packages/BootstrapBlazor.Maps#readme-body-tab)

[蓝牙和打印 Bluetooth](https://www.nuget.org/packages/BootstrapBlazor.Bluetooth#readme-body-tab)

[PDF阅读器 PdfReader](https://www.nuget.org/packages/BootstrapBlazor.PdfReader#readme-body-tab)

[文件系统访问 FileSystem](https://www.nuget.org/packages/BootstrapBlazor.FileSystem#readme-body-tab)

[光学字符识别 OCR](https://www.nuget.org/packages/BootstrapBlazor.OCR#readme-body-tab)

[电池信息/网络信息 WebAPI](https://www.nuget.org/packages/BootstrapBlazor.WebAPI#readme-body-tab)

[文件预览 FileViewer](https://www.nuget.org/packages/BootstrapBlazor.FileViewer#readme-body-tab)

[视频播放器 VideoPlayer](https://www.nuget.org/packages/BootstrapBlazor.VideoPlayer#readme-body-tab)

[图像裁剪 ImageCropper](https://www.nuget.org/packages/BootstrapBlazor.ImageCropper#readme-body-tab)

[视频播放器 BarcodeGenerator](https://www.nuget.org/packages/BootstrapBlazor.BarcodeGenerator#readme-body-tab)

#### AlexChow

[今日头条](https://www.toutiao.com/c/user/token/MS4wLjABAAAAGMBzlmgJx0rytwH08AEEY8F0wIVXB2soJXXdUP3ohAE/?) | [博客园](https://www.cnblogs.com/densen2014) | [知乎](https://www.zhihu.com/people/alex-chow-54) | [Gitee](https://gitee.com/densen2014) | [GitHub](https://github.com/densen2014)

