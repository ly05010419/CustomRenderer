using Android.Provider;
using CustomRenderer.Android.CustomRenderer;
using CustomRenderer.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly:ExportRenderer(typeof(MyEntry),typeof(EntryRenderer_Android))]
namespace CustomRenderer.Android.CustomRenderer
{
    public class EntryRenderer_Android:Xamarin.Forms.Platform.Android.EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control !=null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Azure);
            }
        }
    }
}