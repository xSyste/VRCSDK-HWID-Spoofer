using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;

public class S
{
	public static string G()
	{
		if (S.V())
		{
			return S.C();
		}
		return S.N();
	}

	private static string C()
	{
		return File.ReadAllText(S.P);
	}

	private static bool V()
	{
		if (S.E())
		{
			string CU = S.C();
			if (CU.Length == 40)
			{
				if (Regex.IsMatch(CU, "^[a-z0-9]+$"))
				{
					return true;
				}
				Debug.Log("Invalid HWID (Must only contain A-Z 0-9)");
			}
			else
			{
				Debug.Log("Invalid HWID (Must be length of 40)");
			}
		}
		else
		{
			Debug.Log("No HWID found");
		}
		return false;
	}

	private static bool E()
	{
		return File.Exists(S.P);
	}

	private static string N()
	{
		string text = "";
		for (int i = 0; i < 40; i++)
		{
			text += S.CH[Random.Range(0, S.CH.Length)];
		}
		File.WriteAllText(S.P, text);
		Debug.Log("Made new HWID");
		return text;
	}

	private static string P = "Assets\\VRCSDK\\HWID.txt";

	private static string[] CH = new string[]
	{
		"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9"
	};
}
