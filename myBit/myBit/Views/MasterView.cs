using myBit.Menu;
using myBit.ViewModels;

using System;
using Xamarin.Forms;

namespace myBit.Views
{
	public class MasterView : BaseView
	{
		#region Fields
		private Page pageSelection;
		private MenuType menuType = MenuType.About;

		public Action<MenuType> PageSelectionChanged;
		public Page PageSelection
		{
			get { return pageSelection; }
			set
			{
				pageSelection = value;
				if (PageSelectionChanged != null)
					PageSelectionChanged(menuType);
			}
		}
		#endregion

		#region Menu
		private HomeView home;
		private AboutView about;
		private LoginView login;
		private FeedbackView feedback;
		private RoomCalendarView roomCalendar;
		private RoomInfoView roomInfo;
		private DashboardView dashboard;
		private MeetingRoomsView meetingRooms;
		private FindRoommateView findRoommate;
		private SendNotificationView sendNotification;
		#endregion

		#region Ctor
		public MasterView(MenuViewModel viewModel)
		{
			this.BindingContext = viewModel;

			this.Title = "Menu";

			var layout = new StackLayout { Spacing = 0 };

			var listView = new ListView();

			var cell = new DataTemplate(typeof(ImageCell));

			cell.SetBinding(TextCell.TextProperty, MenuViewModel.TitlePropertyName);
			cell.SetBinding(ImageCell.ImageSourceProperty, "Icon");

			listView.ItemTemplate = cell;

			listView.ItemsSource = viewModel.MenuItems;
			if (about == null)
				about = new AboutView();

			PageSelection = about;

			listView.ItemSelected += (sender, args) =>
			{
				var menuItem = listView.SelectedItem as HomeMenuItem;
				menuType = menuItem.MenuType;
				switch (menuItem.MenuType)
				{
				case MenuType.Home:
					if (home == null)
						home = new HomeView();

					PageSelection = home;
					break;
				case MenuType.About:
					if (about == null)
						about = new AboutView();

					PageSelection = about;
					break;
				case MenuType.Booking:
					if (meetingRooms == null)
						meetingRooms = new MeetingRoomsView();

					PageSelection = meetingRooms;
					break;
				case MenuType.Room:
					if (roomCalendar == null)
						roomCalendar = new RoomCalendarView();

					PageSelection = roomCalendar;
					break;
				case MenuType.RoomInfo:
					if (roomInfo == null)
						roomInfo = new RoomInfoView();

					PageSelection = roomInfo;
					break;
				case MenuType.SearchMate:
					if (findRoommate == null)
						findRoommate = new FindRoommateView();

					PageSelection = findRoommate;
					break;
				case MenuType.Login:
					if (login == null)
						login = new LoginView();

					PageSelection = login;
					break;
				}
			};

			listView.SelectedItem = viewModel.MenuItems[0];
			layout.Children.Add(listView);

			this.Content = layout;
		}
		#endregion
	}
}
