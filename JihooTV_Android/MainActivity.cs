namespace JihooTV_Android
{
    using Android.App;
    using Android.OS;
    using Android.Views;
    using Android.Webkit;
    using Android.Widget;

    namespace WebViewExample
    {
        [Activity(Label = "������TV", MainLauncher = true)]
        public class MainActivity : Activity
        {
            protected override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);
                SetContentView(Resource.Layout.activity_main);

                // WebView �ʱ�ȭ
                WebView webView = FindViewById<WebView>(Resource.Id.webView);
                webView.Settings.JavaScriptEnabled = true; // JavaScript ���

                // ��ư �ʱ�ȭ �� Ŭ�� �̺�Ʈ ����
                Button loadButton = FindViewById<Button>(Resource.Id.loadButton);
                loadButton.Click += (sender, e) =>
                {
                    // YouTube ä�� ������ URL
                    string url = "https://www.youtube.com/channel/UCwYW5Wm-VgpIvGVbINv4HzQ";
                    webView.LoadUrl(url);
                };
            }
        }
    }
}