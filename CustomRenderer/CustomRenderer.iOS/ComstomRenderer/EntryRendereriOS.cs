using CustomRenderer.Controls;
using CustomRenderer.iOS.ComstomRenderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(MyEntry),typeof(EntryRendereriOS))]

namespace CustomRenderer.iOS.ComstomRenderer
{
    public class EntryRendereriOS:Xamarin.Forms.Platform.iOS.EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.BackgroundColor = UIColor.Cyan;
            Control.BorderStyle = UITextBorderStyle.Line;
        }
    }
}