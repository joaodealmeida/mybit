using System;
using System.Collections.ObjectModel;

namespace Teste1
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
					Id = 4,
					Title = "Marcar Reunião",
					MenuType = MenuType.MarcarReuniao,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 5,
					Title = "Chamar Equipa",
					MenuType = MenuType.ChamarEquipa,
					Icon = "feedback.png"
				});

			MenuItems.Add(new HomeMenuItem
				{
					Id = 6,
					Title = "About",
					MenuType = MenuType.About,
					Icon = "about.png"
				});
		}
		#endregion
	}
}