using Clopay;
using Clopay.iOS.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Clopay.iOS.Renderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// On Element Changed
        /// </summary>
        /// <param name="e">event</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {

            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Layer.BorderWidth = 0;
            }
        }
    }
}