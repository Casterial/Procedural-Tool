using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    /// <summary>
    /// draws the noise map and allows the texture to be edited
    /// Assigns colors, 0 - 1 value (black and white)
    /// renders the plane.
    /// </summary>
    public Renderer textureRender;

    public void DrawTexture(Texture2D texture)
    {
        textureRender.sharedMaterial.mainTexture = texture;
        textureRender.transform.localScale = new Vector3(texture.width, 1, texture.height);
    }
}
