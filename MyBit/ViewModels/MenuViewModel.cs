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
					Title = "Rooms",
					MenuType = MenuType.Rooms,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 3,
					Title = " - Booking",
					MenuType = MenuType.Booking,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 4,
					Title = " - Room",
					MenuType = MenuType.Room,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 5,
					Title = " - Room Info",
					MenuType = MenuType.RoomInfo,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 6,
					Title = "BitMate",
					MenuType = MenuType.Bitmate,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 7,
					Title = " - Search Mate",
					MenuType = MenuType.SearchMate,
					Icon = "about.png"
				});
			MenuItems.Add(new HomeMenuItem
				{
					Id = 8,
					Title = "MyStats",
					MenuType = MenuType.MyStats,
					Icon = "about.png"
				});
			MenuItems.Add(new HomeMenuItem
				{
					Id = 9,
					Title = " - Rooms",
					MenuType = MenuType.Rooms2,
					Icon = "about.png"
				});
			MenuItems.Add(new HomeMenuItem
				{
					Id = 10,
					Title = " - InFlow",
					MenuType = MenuType.Inflow,
					Icon = "about.png"
				});
			MenuItems.Add(new HomeMenuItem
				{
					Id = 11,
					Title = "  - Floor",
					MenuType = MenuType.Floor,
					Icon = "about.png"
				});
			MenuItems.Add(new HomeMenuItem
				{
					Id = 12,
					Title = "  - Building",
					MenuType = MenuType.Building,
					Icon = "about.png"
				});
			MenuItems.Add(new HomeMenuItem
				{
					Id = 13,
					Title = "  - Heatmaps",
					MenuType = MenuType.Heatmaps,
					Icon = "about.png"
				});
			MenuItems.Add(new HomeMenuItem
				{
					Id = 14,
					Title = " - Application",
					MenuType = MenuType.Application,
					Icon = "about.png"
				});
			MenuItems.Add(new HomeMenuItem
				{
					Id = 15,
					Title = "About",
					MenuType = MenuType.About,
					Icon = "about.png"
				});
			MenuItems.Add(new HomeMenuItem
				{
					Id = 16,
					Title = "Login",
					MenuType = MenuType.Login,
					Icon = "about.png"
				});
			
			
		}
		#endregion
	}
}

