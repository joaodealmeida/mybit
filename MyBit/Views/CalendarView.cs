using System;

using Xamarin.Forms;

namespace myBit.Views
{
	public class CalendarView : ContentPage
	{
		public CalendarView ()
		{
			Grid grid = new Grid
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				RowDefinitions =
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
				},
				ColumnDefinitions =
				{
					new ColumnDefinition { Width = new GridLength(.5, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = new GridLength(.5, GridUnitType.Star) }
				}
				};
			grid.Children.Add (
				new Label { 
					Text = "Date",
					VerticalOptions = LayoutOptions.EndAndExpand
				},
				1,2,1,2
			);
			grid.Children.Add (
				new DatePicker
				{
					Format = "D",
					VerticalOptions = LayoutOptions.EndAndExpand,
					WidthRequest = 200
				},
				2,4,1,2
			);

			Button back = new Button
			{
				Text = "Back",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Command = new Command(() =>
					{
						this.Navigation.PushAsync(new RoomCalendarView());
					})
			};
			grid.Children.Add(back,1,6,1,8);

			this.Content = grid;
		}
	}
}


