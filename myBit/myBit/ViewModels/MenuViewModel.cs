using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myBit.Menu;

namespace myBit.ViewModels
{
	public class MenuViewModel : BaseViewModel
	{
		#region Properties
		public ObservableCollection<HomeMenuItem> MenuItems { get; set; }
		#endregion

		#region Ctor
		public MenuViewModel()
		{
			CanLoadMore = true;
			Title = "MasterDetailTabbed";
			MenuItems = new ObservableCollection<HomeMenuItem>();

			MenuItems.Add(new HomeMenuItem
				{
					Id = 1,
					Title = "Home",
					MenuType = MenuType.Home,
					Icon = "home.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 2,
					Title = "Meeting Rooms",
					MenuType = MenuType.MeetingRooms,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 3,
					Title = "Find Roommate",
					MenuType = MenuType.FindRoommate,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 4,
					Title = "Send Notification",
					MenuType = MenuType.SendNotification,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 5,
					Title = "Dashboard",
					MenuType = MenuType.Dashboard,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 6,
					Title = "Profile",
					MenuType = MenuType.Profile,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 7,
					Title = "About",
					MenuType = MenuType.About,
					Icon = "about.png"
				});
		}
		#endregion
	}
}

