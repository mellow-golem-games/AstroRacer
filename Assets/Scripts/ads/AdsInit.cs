using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsInit : MonoBehaviour
{
  public InterstitialAd interstitial;
	public bool interstitialLoaded = false;

	// Use this for initialization
	void Start () {
		#if UNITY_ANDROID
		string adUnitId = "ca-app-pub-3940256099942544/1033173712";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-7918336603285970/3341454458";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		// Initialize an InterstitialAd.
		interstitial = new InterstitialAd(adUnitId);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the interstitial with the request.
		interstitial.LoadAd(request);
	}

	// Update is called once per frame
	void Update () {
		if (interstitial.IsLoaded() && !interstitialLoaded) {
			interstitial.Show();
			interstitialLoaded = true;
			Debug.Log("ad load");
		}
	}
}
