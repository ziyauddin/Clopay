using Android.Graphics.Drawables;
using Android.Text;
using Clopay;
using Clopay.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Clopay.Droid.Renderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// Init Renderer
        /// </summary>
        public static void InitRenderer()
        {
        }
#pragma warning disable CS0618 // Type or member is obsolete
        public CustomEntryRenderer()
        {
        }
#pragma warning restore CS0618 // Type or member is obsolete
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetBackgroundDrawable(gd);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
            }
        }
    }
}