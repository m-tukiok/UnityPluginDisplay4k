using UnityEngine;
using System.Collections;

public class GvrViewerTest4k : MonoBehaviour {
	[SerializeField] private float renderScale = 4.0f;

	// Use this for initialization
	void Start () {
		GvrViewer gv = GetComponent<GvrViewer>();
		gv.StereoScreenScale = renderScale;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
