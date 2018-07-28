package com.YourCompanyName;
import android.app.Activity;
import android.view.WindowManager;
import android.util.Log;
import android.content.Intent;
import com.unity3d.player.UnityPlayer;

public class UnityPluginDisplay4k {
    public static void init() {
        final Activity activity = UnityPlayer.currentActivity;
        activity.runOnUiThread(new Runnable() {
            @Override
            public void run() {
                WindowManager.LayoutParams params = activity.getWindow().getAttributes();
                params.preferredDisplayModeId = 2;
                activity.getWindow().setAttributes(params);
                Log.i("UnityPluginDisplay4k", "Successful! ");
            }
        });
    }
}
