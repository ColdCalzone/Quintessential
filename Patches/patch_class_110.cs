﻿using MonoMod;

class patch_class_110 {

	// settings init
	// disabling steam

	[PatchSettingsStaticInit]
	public static extern void orig_cctor();

	[MonoModConstructor]
	public static void cctor() {
		orig_cctor();
	}
}