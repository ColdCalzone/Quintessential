using Quintessential;
using System.Collections.Generic;

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it

class patch_class_201
{   
    // List of all custom sounds. Needed because method 540 sucks.
    public static List<Sound> customSounds = new List<Sound>();
	// Reset custom sounds when normal sounds are reset.
	public extern void orig_method_540();
	public void method_540()
	{
		orig_method_540();
		foreach (var s in customSounds) s.field_4062 = false;
	}
}