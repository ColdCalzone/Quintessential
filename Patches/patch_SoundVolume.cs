using Quintessential;
using MonoMod;
using System.Collections.Generic;

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
[MonoModPatch("class_11")]
abstract class patch_SoundVolume {
    // Function is self explanatory 
    private static Dictionary<string, float> field_52;
    
    public static void AddVolumeEntry(string key, float volume) {
        if(!field_52.ContainsKey(key)) {
            field_52.Add(key, volume);
        } else {
            field_52[key] = volume;
        }
    }
}