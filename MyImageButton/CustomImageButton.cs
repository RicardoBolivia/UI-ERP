using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyImageButton
{
	public partial class CustomImageButton : PictureBox
	{
		public CustomImageButton()
		{
			InitializeComponent();
		}
		private Image NormalImage;

		public Image ImageNormal
		{
			get { return NormalImage; }
			set { NormalImage = value; }
		}
		private Image HoverImage;

		public Image ImageHover
		{
			get { return HoverImage; }
			set { HoverImage = value; }
		}

		private void CustomImageButton_MouseHover(object sender, EventArgs e)
		{
			this.Image = HoverImage;
		}

		private void CustomImageButton_MouseLeave(object sender, EventArgs e)
		{
			this.Image = NormalImage;
		}
	}
}
