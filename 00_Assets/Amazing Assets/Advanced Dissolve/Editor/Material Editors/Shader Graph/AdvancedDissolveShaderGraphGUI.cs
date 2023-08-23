using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Rendering.HighDefinition;

namespace AmazingAssets.AdvancedDissolveEditor.ShaderGraph
{
    public class AdvancedDissolve_ShaderGraphGUI : LightingShaderGraphGUI
    {
        public AdvancedDissolve_ShaderGraphGUI()
        {
            // Insert Advanced Dissolve UI Block in the end
            uiBlocks.Insert(uiBlocks.Count - 1, new AdvancedDissolveUIBlock(MaterialUIBlock.ExpandableBit.User0));
        }

        public override void ValidateMaterial(Material material)
        {
            base.ValidateMaterial(material);


            AmazingAssets.AdvancedDissolve.AdvancedDissolveKeywords.Reload(material);
        }
    }
}