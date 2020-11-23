using UnityEngine;
using GoogleMobileAds.Api;

public class AdmobBannerScript : MonoBehaviour
{
    static bool isAdsBannerLoaded = false;
    
    void Start()
    {
        if (!isAdsBannerLoaded)
            RequestBanner();
    }

    //광고 요청 Method
    private void RequestBanner()
    {
        //Test Banner ID : ca-app-pub-3940256099942544/6300978111
        //여러분들의 광고 ID가 들어갈 곳입니다.
        //ca-app-pub-3462718233988228/6832749500
        string BannerID = "ca-app-pub-3462718233988228/6832749500";
        BannerView bannerview = new BannerView(BannerID, AdSize.SmartBanner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();
        bannerview.LoadAd(request);
        isAdsBannerLoaded = true;
    }
}
