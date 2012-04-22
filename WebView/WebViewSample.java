package jp.unitygames.yokouni;

import android.app.Activity;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.FrameLayout;

import com.unity3d.player.UnityPlayer;

public class WebViewSample {
	final static Activity activity = UnityPlayer.currentActivity;

	public static void createWebView(final String url) {
		activity.runOnUiThread(new Runnable() {
			public void run() {
				WebView webview = new WebView(activity);
				webview.setWebViewClient(new WebViewClient());
				webview.loadUrl(url);
				FrameLayout.LayoutParams params = new FrameLayout.LayoutParams(
						400, 400);
				activity.addContentView(webview, params);
			}
		});
	}
}
