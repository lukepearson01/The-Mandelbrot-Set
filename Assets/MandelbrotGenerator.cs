using UnityEngine;
/// <summary>
/// Used to calculate Mandelbrot set.
/// </summary>
public class MandelbrotGenerator
{
    ///<summary>
    /// Return Texture2D of mandelbrot set at (<param>x</param>,<param>y</param>) with given resolution and zoom
    ///</summary>
    public Texture2D generateImageAt(float x, float y, int width, int height, int zoom)
    {
        if(res <= 0||res > 1) return null;
        Texture2D mandel = new Texture2D(width,height);
        float step = 1/zoom;
        for(int n = 0;n < width;n++)
        {
            for(int m = 0;m < height;m++)
            {
                x += step;
                y += step;
                mandel.SetPixel(n,m,resolveMandel(x,y));
            }
        return new Texture2D(res,res);
    }

    private int maxIter = 200;
    public Color resolveMandel(float re, float im){
        float[] num = {re, im};
        int escape = maxIter;
        for(i = 0;i < maxIter;i++)
        {
            num = {num[0]^2-num[1]^2,2*num[0]};
            if(num[0]^2+num[1]^2>40000)
            {
                escape = i;
                break;
            }
        }
    }
}
