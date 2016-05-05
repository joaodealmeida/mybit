using System;

using Xamarin.Forms;

namespace myBit.Views
{
	public class BookingInviteView : BaseView
	{
		public BookingInviteView ()
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
			Label invite = new Label
			{
				Text = "Invite",
				VerticalOptions = LayoutOptions.FillAndExpand,
				FontSize = 25
			};
			Label date = new Label
			{
				Text = "19 November 2016",
				VerticalOptions = LayoutOptions.FillAndExpand,
				FontSize = 15
			};
			Label hour = new Label
			{
				Text = "16:30-17:30",
				VerticalOptions = LayoutOptions.FillAndExpand,
				FontSize = 15
			};
			Label room = new Label
			{
				Text = "Informal Room",
				VerticalOptions = LayoutOptions.FillAndExpand,
				FontSize = 15
			};
			Label roomId = new Label
			{
				Text = "roomId",
				VerticalOptions = LayoutOptions.FillAndExpand,
				FontSize = 15
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
						this.Navigation.PushAsync(new BookingRoomView());
					})
			};
			Button inviteButton = new Button
			{
				Text = "Invite",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,

			};
			mainGrid.Children.Add (invite, 0, 0);
			mainGrid.Children.Add (date, 0, 1);
			mainGrid.Children.Add (hour, 1, 1);
			mainGrid.Children.Add (room, 0, 2);
			mainGrid.Children.Add (roomId, 1, 2);
			mainGrid.Children.Add (back, 0, 6);
			mainGrid.Children.Add (inviteButton, 1, 6);
			this.Content = mainGrid;
		}
	}
}


