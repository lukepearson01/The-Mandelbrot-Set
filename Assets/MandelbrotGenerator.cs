using System.Drawing.Bitmap;
/// <summary>
/// Used to calculate Mandelbrot set.
/// </summary>
public class MandelbrotGenerator
{
    ///<summary>
    /// Return Bitmap of mandelbrot set at (<param>x</param>,<param>y</param>) with given resolution
    ///</summary>
    public Bitmap generateImageAt(int x, int y, int res)
    {
        return new Bitmap(res,res);
    }
}
