using System;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using MyAuthen.Droid.CustomViews;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(XEntryRenderer))]
namespace MyAuthen.Droid.CustomViews
{
    public class XEntryRenderer : EntryRenderer
    {

        private readonly Context context;

        public XEntryRenderer(Context context) : base(context)
        {
            this.context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = context.GetDrawable(Resource.Drawable.RoundedCornerEntry);

            }

            //if (e.OldElement == null)
            //{
            //    var nativeEditText = (global::Android.Widget.EditText)Control;
            //    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
            //    shape.Paint.Color = Xamarin.Forms.Color.Red.ToAndroid();
            //    shape.Paint.SetStyle(Paint.Style.Stroke);
            //    nativeEditText.Background = shape;
            //}
        }
    }
}
