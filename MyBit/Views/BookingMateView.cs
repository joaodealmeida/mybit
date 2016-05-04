using System;

using Xamarin.Forms;

namespace myBit.Views
{
	public class BookingMateView : ContentPage
	{
		SearchBar searchBar;
		public BookingMateView ()
		{
			Grid mainGrid = new Grid()
			{
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				RowSpacing = 10,
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
			Label mate = new Label
			{
				Text = "Mate",
				VerticalOptions = LayoutOptions.FillAndExpand,
				FontSize = 25
			};
			Label resultsLabel = new Label
			{
				Text = "Result will appear here.",
				VerticalOptions = LayoutOptions.FillAndExpand,
				FontSize = 25
			};
			searchBar = new SearchBar
			{
				Placeholder = "Enter search term",
				SearchCommand = new Command(() => { resultsLabel.Text = "Result: " + searchBar.Text + " is what you asked for."; })
			};
			ScrollView results = new ScrollView {
				HorizontalOptions = LayoutOptions.Center,
				Content = resultsLabel,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			Button back = new Button
			{
				Text = "Back",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Command = new Command(() =>
					{
						this.Navigation.PushAsync(new MeetingRoomsView());
					})
			};
			Button next = new Button
			{
				Text = "Next",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Command = new Command(() =>
					{
						this.Navigation.PushAsync(new BookingRoomView());
					})
			};

			mainGrid.Children.Add (mate,0,0);
			mainGrid.Children.Add(searchBar,0,1);
			mainGrid.Children.Add(results,0, 2);
			mainGrid.Children.Add(back, 0, 6);
			mainGrid.Children.Add(next, 1, 6);

			this.Content = mainGrid;
		}
	}
}


