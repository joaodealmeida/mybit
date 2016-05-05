using System;

using Xamarin.Forms;

namespace myBit.Views
{
	public class RoomInfo2View : ContentPage
	{
		public RoomInfo2View ()
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
			Label room = new Label
			{
				Text = "Room",
				VerticalOptions = LayoutOptions.FillAndExpand,
				FontSize = 25
			};
			Label description = new Label
			{
				Text = "descricao",
				VerticalOptions = LayoutOptions.FillAndExpand,
				FontSize = 25
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
						this.Navigation.PushAsync(new RoomInfoView());
					})
			};
			mainGrid.Children.Add (room,0,0);
			mainGrid.Children.Add (description, 0, 1);
			mainGrid.Children.Add(back,0, 6);

			this.Content = mainGrid;
		}
	}
}


