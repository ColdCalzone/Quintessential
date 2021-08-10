﻿namespace Quintessential {

	abstract class QuintessentialMod {

		public ModMeta Meta;

		public abstract void Load();

		public abstract void PostLoad();

		public abstract void Unload();
	}
}