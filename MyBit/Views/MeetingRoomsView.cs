using System;
using Xamarin.Forms;


namespace myBit.Views
{
    public class MeetingRoomsView : BaseView
    {
        public MeetingRoomsView()
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

            /*mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
			mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
			mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
			mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)});
			*/
            var date = new Label { Text = "Date " };
            var time = new Label { Text = "Time " };
            var duration = new Label { Text = "Duration " };
            var room = new Label { Text = "Room ", HorizontalOptions = LayoutOptions.Center };
            var durationEntry = new Entry { Placeholder = "1H" };
            DatePicker datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            var beeroclock = new TimePicker() { Time = new TimeSpan(17, 0, 0) };
            Button formal = new Button
            {
                Text = "Formal",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Red
            };
            Button informal = new Button
            {
                Text = "Informal",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
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
                    this.Navigation.PushAsync(new BookingMateView());
                })
            };

            mainGrid.Children.Add(date, 0, 0);
            mainGrid.Children.Add(datePicker, 1, 0);
            mainGrid.Children.Add(time, 0, 1);
            mainGrid.Children.Add(beeroclock, 1, 1);
            mainGrid.Children.Add(duration, 0, 2);
            mainGrid.Children.Add(durationEntry, 1, 2);
            mainGrid.Children.Add(room, 0, 3);
            mainGrid.Children.Add(formal, 0, 4);
            mainGrid.Children.Add(informal, 1, 4);
            mainGrid.Children.Add(next, 1, 6);

            this.Content = mainGrid;
        }
    }
}
