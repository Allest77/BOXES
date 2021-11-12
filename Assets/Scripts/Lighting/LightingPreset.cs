using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Lighting Preset", menuName = "Scriptables/Lighting Preset", order =1)]
public class LightingPreset : ScriptableObject {
    public Gradient AmbientColor, DirectionalColor, FogColor;
}

//ScriptableObject: Enable us to share one specific preset between scenes by creating a file.