using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace myBit.Views
{
	public class PageTwoView : BaseView
	{
		public PageTwoView()
		{
			this.Content = new Label
			{
				Text = "PageTwo View!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}

