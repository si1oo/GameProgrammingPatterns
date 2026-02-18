using UnityEngine;
/// <summary>
/// 测试类
/// </summary>
public class Example07 : MonoBehaviour
{
    private DoubleBufferedRenderer doubleBufferedRenderer;
    private Texture2D displayTexture;
    private bool shouldDraw = true;

    void Start()
    {
        doubleBufferedRenderer = new DoubleBufferedRenderer();
        displayTexture = new Texture2D(Framebuffer.WIDTH, Framebuffer.HEIGHT);
        GetComponent<Renderer>().material.mainTexture = displayTexture;
    }

    void Update()
    {
        var fb = doubleBufferedRenderer.GetDrawBuffer();
        fb.Clear(Color.white);

        //绘制笑脸
        int centerX = Framebuffer.WIDTH / 2, centerY = Framebuffer.HEIGHT / 2;
        for (int x = -10; x <= 10; x++) fb.DrawPixel(centerX + x, centerY - 10, Color.black);
        fb.DrawPixel(centerX - 5, centerY + 5, Color.black); 
        fb.DrawPixel(centerX + 5, centerY + 5, Color.black); 

        //交换缓冲区
        doubleBufferedRenderer.Swap();
        shouldDraw = true;
    }

    void LateUpdate()
    {
        Debug.Log(displayTexture);
        if (shouldDraw) //发送数据
        { 
            displayTexture.SetPixels32(doubleBufferedRenderer.GetCurrentPixels());
            displayTexture.Apply();
            shouldDraw = false;
        }
    }
}