using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


using UnityEditor.Rendering.HighDefinition;
using UnityEditor.Rendering;

public class AdvancedDissolveUIBlock : MaterialUIBlock
{
    ExpandableBit foldoutBit;

    public AdvancedDissolveUIBlock(ExpandableBit expandableBit)
    {
        foldoutBit = expandableBit;
    }

    public override void LoadMaterialProperties()
    {
        AmazingAssets.AdvancedDissolveEditor.AdvancedDissolveMaterialProperties.Init(properties);
    }

    public override void OnGUI()
    {
        using (var header = new MaterialHeaderScope("Advanced Dissolve", (uint)foldoutBit, materialEditor))
        {
            if (header.expanded)
            {
                AmazingAssets.AdvancedDissolveEditor.AdvancedDissolveMaterialProperties.DrawDissolveOptions(false, materialEditor, true, true, false, true, true);
            }
        }
    }
}
