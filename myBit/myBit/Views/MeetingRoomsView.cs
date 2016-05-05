using System;
using Xamarin.Forms;




namespace myBit.Views
{
	public class MeetingRoomsView : BaseView
	{
		public MeetingRoomsView()
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

			/*mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
			mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
			mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
			mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
			*/
			grid.Children.Add (
				new Label { 
					Text = "Date",
					VerticalOptions = LayoutOptions.EndAndExpand
				},
				1,2,1,2
			);
			grid.Children.Add (
				new Label {
					Text = "Time",
					VerticalOptions = LayoutOptions.EndAndExpand
				},
				1,2,2,3
			);
			grid.Children.Add (
				new Label { 
					Text = "Duration",
					VerticalOptions = LayoutOptions.EndAndExpand
				},
				1,3,3,4
			);
			grid.Children.Add (
				new Label { 
					Text = "Room ", 
					HorizontalOptions = LayoutOptions.Center 
				},
				1,4,4,5
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
			grid.Children.Add (
				new TimePicker() { 
					Time = new TimeSpan(17, 0, 0),
					VerticalOptions = LayoutOptions.EndAndExpand,
					WidthRequest = 200
				},
				2,4,2,3
			);
			/*
			grid.Children.Add (
				new Entry { 
					Placeholder = "1H",
					VerticalOptions = LayoutOptions.EndAndExpand
				},
				3,4,3,4
			);
			*/
			String[] stringArray = { "Formal", "Informal" };
			Picker pickerRoom = new Picker
			{
				Title = "Room",
				VerticalOptions = LayoutOptions.Center
			};
			foreach (string i in stringArray)
			{
				pickerRoom.Items.Add(i);
			}

			grid.Children.Add (
				pickerRoom,1,5,5,6
			);

			string[] intArray = { "0", "1", "2", "3", "4", "5", "6" };
			Picker picker = new Picker
			{
				Title = "hours",
				VerticalOptions = LayoutOptions.Center
			};
			foreach (string i in intArray)
			{
				picker.Items.Add(i);
			}

			grid.Children.Add (
				picker,3,4,3,4
			);



			Button next = new Button
			{
				Text = "Next",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Command = new Command(() =>
					{
						this.Navigation.PushAsync(new BookingMateView());
					})
			};
			grid.Children.Add(next,1,6,6,8);

			this.Content = grid;
		}
	}
}
