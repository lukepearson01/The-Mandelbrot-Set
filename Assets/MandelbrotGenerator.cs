using UnityEngine;
using System;
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
        if(zoom<1) return null;
        Texture2D mandel = new Texture2D(width,height);
        float step = 1/zoom;
        for(int n = 0;n < width;n++)
        {
            for(int m = 0;m < height;m++)
            {
                mandel.SetPixel(n,m,resolveMandel(n*step,m*step));
                Debug.Log(n + " " + m);
            }
        }
        mandel.Apply();
        return mandel;
    }

    private int maxIter = 200;
    private Color resolveMandel(float re, float im){
        float[] num = new float[]{re, im};
        int escape = maxIter;
        int i = 0;
        for(;i < maxIter;i++)
        {
            num = new float[]{(float)(Math.Pow(num[0],2)-Math.Pow(num[1],2)),2*num[0]};
            if(Math.Pow(num[0],2)+Math.Pow(num[1],2)>40000)
            {
                escape = i;
                break;
            }
        }
        Debug.Log(escape);
        if(escape == maxIter) return Color.black;
        return Color.white;
    }
}
