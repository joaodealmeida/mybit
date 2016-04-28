using System;
using Xamarin.Forms;

namespace Teste1
{
	public class MeetingRoomsView : BaseView
	{
		public MeetingRoomsView ()
		{
			Grid mainGrid = new Grid()
			{
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				RowSpacing = 0,
				ColumnSpacing = 0,
				Padding = 10,
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

			/*mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
			mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
			mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
			mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
			*/var date = new Label { Text = "Date " };
			var bottomLeft = new Label { Text = "Bottom Left" };
			var bottomRight = new Label { Text = "Bottom Right" };
			DatePicker datePicker = new DatePicker
			{
				Format = "D",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			mainGrid.Children.Add(date, 0, 0);
			mainGrid.Children.Add (datePicker, 1, 0);
			mainGrid.Children.Add(bottomLeft, 0, 1);
			mainGrid.Children.Add(bottomRight, 1, 1);
			this.Content = mainGrid;
		}
	}
}