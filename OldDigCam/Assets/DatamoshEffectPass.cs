using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class DatamoshEffectPass : CustomPass
{
    // Exposed Material for the datamoshing effect
    public Material datamoshMaterial;

    private RenderTexture currentTarget;

    protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
    {
        // Check if the material is assigned
        if (datamoshMaterial == null)
        {
            Debug.LogWarning("DatamoshEffectPass: Material is not assigned. Please assign a material.");
        }
    }

    protected override void Execute(ScriptableRenderContext renderContext, CommandBuffer cmd, HDCamera hdCamera, CullingResults cullingResults)
    {
        if (datamoshMaterial == null)
        {
            Debug.LogError("DatamoshEffectPass: Material is missing. Skipping the custom pass.");
            return;
        }
        currentTarget = hdCamera.camera.targetTexture;
        datamoshMaterial.SetTexture("_MainTex", currentTarget);
        //CoreUtils.DrawFullScreen(cmd, datamoshMaterial, null, 0);
    }

    protected override void Cleanup()
    {
        // Clean up resources if needed
    }
}
