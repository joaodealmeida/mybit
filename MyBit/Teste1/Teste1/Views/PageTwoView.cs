using System;
using Xamarin.Forms;

namespace Teste1
{
	public class PageTwoView : BaseView
	{
		public PageTwoView ()
		{
			this.Content = new Label {
				Text = "PageTwo View!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}