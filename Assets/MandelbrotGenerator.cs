using UnityEngine;
/// <summary>
/// Used to calculate Mandelbrot set.
/// </summary>
public class MandelbrotGenerator
{
    ///<summary>
    /// Return Texture2D of mandelbrot set at (<param>x</param>,<param>y</param>) with given resolution
    ///</summary>
    public Texture2D generateImageAt(int x, int y, int res)
    {
        if(res <= 0||res > 1) return null;
        return new Texture2D(res,res);
    }
}
