# UnityPluginDisplay4k

Unity plugin for Android to enable 4K display mode  
Tested with SONY XPERIA Z5 Premium / XPERIA XZ Premium  
See also https://developer.android.com/about/versions/marshmallow/android-6.0.html?#4K-display  

<br>

## System Requirements

  * Unity 5.4 or later
  * For VR
    * Unity 5.4 only
    * Google VR SDK for Unity from v1.0.3 to v1.40.0  

<br>

## Usage

  * Copy display4k.jar to Assets/Plugins/Android folder in your Unity project
  * Copy Test4k.cs to Assets folder in your Unity project
  * Add an empty GameObject to your scene
  * Attach Test4k.cs to the empty object

For VR  
  * Copy GvrViewerTest4k.cs in your Unity project
  * Attach GvrViewerTest4k.cs to GvrViewerMain
  * Change Distortion Correction from `Native` to `Unity` in GvrViewerMain
    <img src="https://github.com/m-tukiok/UnityPluginDisplay4k/blob/image/GvrViewerMain.png" width="730px">
  * Uncheck Virtual Reality Supported in PlayerSettings
    <img src="https://github.com/m-tukiok/UnityPluginDisplay4k/blob/image/PlayerSettings.png" width="692px">
    
<br>

## Screenshots

  * Original display mode (Z5P)  
    <img src="https://github.com/m-tukiok/UnityPluginDisplay4k/blob/image/screenshot_1080p.png" width="720px">

  * 4K display mode (Z5P)  
    <img src="https://github.com/m-tukiok/UnityPluginDisplay4k/blob/image/screenshot_4k.png" width="720px">

<br>

## Known Issue

For VR
  * The stereo screen shrinks to 1080 x 1920 pixels in 4K display mode
    * Unity 5.4, you can solve this issue by changing Distortion Correction from `Native` to `Unity` in GvrViewerMain
    * Unity 5.5 or later have no workaround
    <img src="https://github.com/m-tukiok/UnityPluginDisplay4k/blob/image/screenshot_4k_wrong_strereo_screen.png" width="720px">

<br>
