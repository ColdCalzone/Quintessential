﻿#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it

class patch_Campaigns {

	public static extern void orig_method_828();

	public static void method_828() {
		orig_method_828();
		Quintessential.QuintessentialLoader.LoadCampaigns();
	}
}