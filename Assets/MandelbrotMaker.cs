using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MandelbrotMaker : MonoBehaviour
{
    MandelbrotGenerator mg;
    RawImage ri;
    // Start is called before the first frame update
    void Start()
    {
        mg = new MandelbrotGenerator();
        ri = GetComponent<RawImage>();
        Texture2D t2d = new Texture2D(100,100);
        t2d.SetPixel(50,50,Color.red);
        t2d.SetPixel(50,51,Color.red);
        t2d.SetPixel(51,50,Color.red);
        t2d.SetPixel(51,51,Color.red);
        //sr.sprite = Sprite.Create(mg.generateImageAt(0,0,100,100,1),new Rect(0,0,100,100),new Vector2(0,0));
        ri.texture = mg.generateImageAt(-1,-1,100,100,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
