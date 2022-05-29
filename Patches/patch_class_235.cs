using Quintessential;
using System;
using System.IO;

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it

class patch_class_235 {

	// checks mods for sounds before vanilla

	public static extern Sound orig_method_616(string param_3981);

	public static Sound method_616(string path) {
        Sound sound = null;
        string filePath = Path.Combine("Content", path) + ".wav";
		for (int i = QuintessentialLoader.ModContentDirectories.Count - 1; i >= 0; i--)
		{
			string dir = Path.Combine(QuintessentialLoader.ModContentDirectories[i],"Content");
			string str = Path.Combine(dir, path) + ".wav";
			if (File.Exists(str))
			{
				filePath = str;
                sound = new Sound {
                    field_4060 = Path.GetFileNameWithoutExtension(filePath),
                    field_4061 = class_158.method_375(filePath),
                };
				break;
			}

		}
        if(sound == null) return orig_method_616(path);
        return sound;
		
	}
}