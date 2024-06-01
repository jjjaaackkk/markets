using System.Drawing.Drawing2D;

namespace markets.Addons
{
    internal class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            var gPath = new GraphicsPath();
            gPath.AddEllipse(1, 1, ClientSize.Width - 4, ClientSize.Height - 4);
            this.Region = new Region(gPath);
            base.OnPaint(e);
        }
    }
}
