﻿using MonoMod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
class patch_Puzzle {

	[PatchPuzzleIdWrite]
	[MonoModIgnore]
	public static extern void method_1251(string param_4989);
}