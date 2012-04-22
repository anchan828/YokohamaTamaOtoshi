using UnityEngine;

public class WebViewPlugin : MonoBehaviour
{
	private readonly string url = "http://www.google.com/";
	
	void Start ()
	{
		AndroidJavaClass webview = new AndroidJavaClass ("jp.unitygames.yokouni.WebViewSample");
		webview.CallStatic ("createWebView", url);
	}
}
