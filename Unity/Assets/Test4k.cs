using UnityEngine;
using System.Collections;

public class Test4k : MonoBehaviour {
	private static string JAVA_CLASS_NAME = "com.YourCompanyName.UnityPluginDisplay4k";
	private static string JAVA_METHOD_NAME_INIT = "init";
	[SerializeField] private int width = 3840;
	[SerializeField] private int height = 2160;

	// Use this for initialization
	void Start () {
		using ( AndroidJavaClass plugin = new AndroidJavaClass(JAVA_CLASS_NAME)) {
			plugin.CallStatic(JAVA_METHOD_NAME_INIT);
		}
		Screen.SetResolution(width, height, true);
		// Debug.LogFormat("Screen: width={0}, height={1}", Screen.width, Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
