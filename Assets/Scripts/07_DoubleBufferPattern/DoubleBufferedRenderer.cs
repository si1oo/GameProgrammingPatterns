using UnityEngine;

/// <summary>
/// 帧缓冲
/// 在这里设置像素
/// </summary>
public class Framebuffer
{
    public const int WIDTH = 160;
    public const int HEIGHT = 120;
    private Color32[] pixels;

    public Framebuffer()
    {
        pixels = new Color32[WIDTH * HEIGHT];
        Clear(Color.white);
    }

    public void Clear(Color color)
    {
        for (int i = 0; i < pixels.Length; i++)
            pixels[i] = color;
    }

    public void DrawPixel(int x, int y, Color color)
    {
        if (x < 0 || x >= WIDTH || y < 0 || y >= HEIGHT) return;
        pixels[y * WIDTH + x] = color;
    }

    public Color32[] GetPixels() => pixels;
}

/// <summary>
/// 一个搭配双缓冲区的简易渲染器
/// </summary>
public class DoubleBufferedRenderer
{
    private Framebuffer[] buffers = new Framebuffer[2];
    private Framebuffer current;  // 显卡读取的缓冲
    private Framebuffer next;     // 正在绘制的缓冲

    public DoubleBufferedRenderer()
    {
        buffers[0] = new Framebuffer();
        buffers[1] = new Framebuffer();
        current = buffers[0];
        next = buffers[1];
    }
    /// <summary>
    /// 获得需要被写入的缓冲区
    /// </summary>
    /// <returns></returns>
    public Framebuffer GetDrawBuffer() => next;

    /// <summary>
    /// 交换缓冲区（引用）
    /// </summary>
    public void Swap()
    {
        (current, next) = (next, current);
    }

    public Color32[] GetCurrentPixels() => current.GetPixels();
}