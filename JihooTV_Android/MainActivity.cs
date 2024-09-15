namespace JihooTV_Android
{
    using Android.App;
    using Android.OS;
    using Android.Views;
    using Android.Webkit;
    using Android.Widget;

    namespace WebViewExample
    {
        [Activity(Label = "박지후TV", MainLauncher = true)]
        public class MainActivity : Activity
        {
            protected override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);
                SetContentView(Resource.Layout.activity_main);

                // WebView 초기화
                WebView webView = FindViewById<WebView>(Resource.Id.webView);
                webView.Settings.JavaScriptEnabled = true; // JavaScript 허용

                // 버튼 초기화 및 클릭 이벤트 설정
                Button loadButton = FindViewById<Button>(Resource.Id.loadButton);
                loadButton.Click += (sender, e) =>
                {
                    // YouTube 채널 페이지 URL
                    string url = "https://www.youtube.com/channel/UCwYW5Wm-VgpIvGVbINv4HzQ";
                    webView.LoadUrl(url);
                };
            }
        }
    }
}