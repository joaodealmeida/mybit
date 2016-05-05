using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace myBit.Views
{
	public class DashboardView : BaseView
	{
		public DashboardView()
		{
			Grid mainGrid = new Grid()
			{
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				RowSpacing = 0,
				ColumnSpacing = 0,
				Padding = 0,
				RowDefinitions =
				{
					new RowDefinition { Height = GridLength.Auto},
					new RowDefinition { Height = GridLength.Auto}
				},
				ColumnDefinitions =
				{
					new ColumnDefinition { Width = GridLength.Auto}
				}
				};

			Image myImage = new Image()
			{
				Aspect = Aspect.AspectFill,
				HeightRequest = 150,
				MinimumHeightRequest = 150,
				Source = ImageSource.FromFile(
					"home.png"
				),
			};

			Label myLabel = new Label
			{
				Text = "Dashboard View!"
			};

			mainGrid.Children.Add(myImage, 0, 0);
			mainGrid.Children.Add(myLabel, 0, 1);

			this.Content = mainGrid;
		}
	}
}
