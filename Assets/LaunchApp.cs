using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.AndroidJavaClass;

public class LaunchApp : MonoBehaviour
{
    public void LaunchSecondApp()
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        AndroidJavaObject packageManager = currentActivity.Call<AndroidJavaObject>("getPackageManager");

        string packageName = "com.NostalgicDreamers.TPPHcamera";

        AndroidJavaObject launchIntent = packageManager.Call<AndroidJavaObject>("getLaunchIntentForPackage", packageName);

        if (launchIntent != null)
        {
            currentActivity.Call("startActivity", launchIntent);
        }
        else
        {
            Debug.Log("App not installed.");
        }
    }
    public void OnButtonPress()
    {
        LaunchSecondApp();
    }
}
