using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using SkiaSharp;
using Xamarin.Forms;

namespace Menghi.Massimo._4H.Fig
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Tela(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            e.Surface.Canvas.Clear();
            SKPath linea = new SKPath();

            SKPoint p = new SKPoint(50, 50);
            linea.MoveTo(p);

            p = new SKPoint(250, 50);
            linea.LineTo(p);

            p = new SKPoint(250, 350);
            linea.LineTo(p);

            p = new SKPoint(50, 350);
            linea.LineTo(p);

            p = new SKPoint(50, 48);
            linea.LineTo(p);

            SKPoint poligono = new SKPoint(70 + 62, -25 + 200);
            linea.MoveTo(poligono);

            p = new SKPoint(105 + 62, -25 + 200);
            linea.LineTo(p);

            p = new SKPoint(120 + 62, 5+200);
            linea.LineTo(p);

            p = new SKPoint(105 + 62, 35 + 200);
            linea.LineTo(p);

            p = new SKPoint(70 + 62, 35 + 200);
            linea.LineTo(p);

            p = new SKPoint(55 + 62, 5 + 200);
            linea.LineTo(p);

            p = new SKPoint(70 + 62, -25+200);
            linea.LineTo(p);

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Red,
                StrokeWidth = 5,
            };


            e.Surface.Canvas.DrawPath(linea, paint);



        }
    }
}
