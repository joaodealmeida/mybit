using myBit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace myBit.Views
{
	public class HomeView : BaseView
	{
		List<ExpandView> expandViews = new List<ExpandView>();
		public HomeView()
		{
			Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);



			var roomsView = new SelectView(new List<string>() { "Booking", "Room Calendar", "Room Info"});
			var roomsCell = CreateCell("Booking", roomsView);
			var bitmateView = new SelectView(new List<string>() { "Search Mate", "Notify Team" });
			var bitmateCell = CreateCell("BitMate", bitmateView);
			var mystatsView = new SelectView(new List<string>() { "Rooms", "Inflow" , "Application"});
			var mystatsCell = CreateCell("My Stats", mystatsView);
			var groupPreferences = CreateGroup("", new List<StackLayout> { roomsCell, bitmateCell, mystatsCell });





			var scrollView = new ScrollView {
				Content = new StackLayout {
					Children = {  groupPreferences }
				}
			};

			Content = scrollView;
		}
		StackLayout CreateCell(string title, ExpandView expandView) {
			expandViews.Add(expandView); 
			var button1 = CreateButton(title);
			button1.Clicked += (s, e) => {
				
				if (expandView.Expand) {
					expandView.Expand = false;
				} else { 
					foreach (var v in expandViews) {
						v.Expand = false;
					}
					expandView.Expand = true;
				}
			};
			return new StackLayout {
				Children = { button1, expandView }
			};

		}

		StackLayout CreateGroup(string title, IList<StackLayout> ar) {
			var subLayout = new StackLayout {
				Padding = new Thickness(10, 0, 10, 0),
			};
			foreach (var a in ar) {
				subLayout.Children.Add(a);
			}
			return new StackLayout {
				Children = { CreateGroupLabel(title), subLayout }
			};
		}

		Label CreateGroupLabel(string title) {
			var label = new Label() {
				Text = "  " + title,
				HorizontalOptions = LayoutOptions.Start,
				BackgroundColor = Device.OnPlatform(Color.FromRgb(220, 220, 220), Color.Transparent, Color.FromRgb(90, 90, 90)),
				HeightRequest = Device.OnPlatform(20, 20, 40),
			};
			return label;
		}

		Button CreateButton(string title) {
			var button = new ExButton(Alignment.Right) {
				Text = title + " > ",
				HeightRequest = Device.OnPlatform(50, 50, 80),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				TextColor = Color.Silver,
			};
			return button;
		}
	}
}
