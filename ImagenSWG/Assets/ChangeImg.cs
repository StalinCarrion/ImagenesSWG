using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Unity.VectorGraphics;



public class ChangeImg : MonoBehaviour {

    public RawImage img;
   
    private void Awake()
    {
        img = this.gameObject.GetComponent<RawImage>();
    }
    IEnumerator Start()
    {
        WWW www = new WWW("https://commons.wikimedia.org/wiki/File:Ghostscript_Tiger.svg");
        yield return www ;
        
        img.texture = www.texture;
        
        
    }


}
