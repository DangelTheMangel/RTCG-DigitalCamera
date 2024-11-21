using NUnit.Framework.Internal;
using UnityEngine;

public class PixelAccumulationEffect : MonoBehaviour
{
    public Material accumulationMaterial; // Material with the accumulation shader
    public RenderTexture accumulationRT; // Accumulation texture

    private RenderTexture tempRT; // Temporary render texture

    void Start()
    {
       /* // Initialize Render Textures
        accumulationRT = new RenderTexture(Screen.width, Screen.height, 0);
        accumulationRT.Create();

        tempRT = new RenderTexture(Screen.width, Screen.height, 0);
        tempRT.Create();*/
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        // Render the current frame into the temporary RT
        Graphics.Blit(source, tempRT, accumulationMaterial);

        // Pass the previous accumulation texture to the material
        accumulationMaterial.SetTexture("_AccumulationTex", accumulationRT);

        // Blend the current frame with the accumulation texture
       /* Graphics.Blit(tempRT, accumulationRT, accumulationMaterial);

        // Output the accumulation texture to the screen
        Graphics.Blit(accumulationRT, destination);*/
    }

}
