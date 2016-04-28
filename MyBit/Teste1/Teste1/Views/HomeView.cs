/*using System;
using Xamarin.Forms;

namespace Teste1
{
	public class HomeView : CarouselPage
	{
		public HomeView()
		{
			this.Children.Add (new PageOneView ());
			this.Children.Add (new PageTwoView ());
		}
	}*/
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Xamarin.Forms;

	namespace Teste1
	{
		public class HomeView : ContentPage
		{
		public HomeView ()
			{

			Grid mainGrid = new Grid()
			{
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				RowSpacing = 0,
				ColumnSpacing = 0,
				Padding = 0,
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
			
				BindingContext = new LoginViewModel (Navigation);

				var layout = new StackLayout { Padding = 10 };

				var username = new Entry { Placeholder = "Username" };
				username.SetBinding (Entry.TextProperty, LoginViewModel.UsernamePropertyName);
				layout.Children.Add (username);

				var password = new Entry { Placeholder = "Password", IsPassword = true };
				password.SetBinding (Entry.TextProperty, LoginViewModel.PasswordPropertyName);
				layout.Children.Add (password);

				var button = new Button { Text = "Sign In", TextColor = Color.White };
				button.SetBinding (Button.CommandProperty, LoginViewModel.LoginCommandPropertyName);
				layout.Children.Add (button);

				Content = new ScrollView { Content = layout };
			}
		}


	/*

	using MobileCRM.Shared.ViewModels;
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Xamarin.Forms;

	namespace MobileCRM.Shared.Pages
	{
		public class LoginPage : ContentPage
		{
			public LoginPage ()
			{
				BindingContext = new LoginViewModel (Navigation);

				BackgroundColor = Helpers.Color.Blue.ToFormsColor ();

				var layout = new StackLayout { Padding = 10 };

				var label = new Label {
					Text = "Connect with Your Data",
					FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
					TextColor = Color.White,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalTextAlignment = TextAlignment.Center, // Center the text in the blue box.
					VerticalTextAlignment = TextAlignment.Center, // Center the text in the blue box.
				};

				layout.Children.Add (label);

				var username = new Entry { Placeholder = "Username" };
				username.SetBinding (Entry.TextProperty, LoginViewModel.UsernamePropertyName);
				layout.Children.Add (username);

				var password = new Entry { Placeholder = "Password", IsPassword = true };
				password.SetBinding (Entry.TextProperty, LoginViewModel.PasswordPropertyName);
				layout.Children.Add (password);



				var button = new Button { Text = "Sign In", TextColor = Color.White };
				button.SetBinding (Button.CommandProperty, LoginViewModel.LoginCommandPropertyName);

				layout.Children.Add (button);

				Content = new ScrollView { Content = layout };
			}
		}
	}

	Status API Training Shop Blog About 


//	public class HomeView : TabbedPage
//	{
//		public HomeView ()
//		{
//			this.Title = "TabbedPage";
//
//			this.ItemsSource = new NamedColor[] {
//				new NamedColor ("Red", Color.Red),
//				new NamedColor ("Yellow", Color.Yellow),
//				new NamedColor ("Green", Color.Green),
//				new NamedColor ("Aqua", Color.Aqua),
//				new NamedColor ("Blue", Color.Blue),
//				new NamedColor ("Purple", Color.Purple)
//			};
//
//			this.ItemTemplate = new DataTemplate (() => { 
//				return new NamedColorPage (); 
//			});
//		}
//	}
//
//	// Data type:
//	class NamedColor
//	{
//		public NamedColor (string name, Color color)
//		{
//			this.Name = name;
//			this.Color = color;
//		}
//
//		public string Name { private set; get; }
//
//		public Color Color { private set; get; }
//
//		public override string ToString ()
//		{
//			return Name;
//		}
//	}
//
//	// Format page
//	class NamedColorPage : ContentPage
//	{
//		public NamedColorPage ()
//		{
//			// This binding is necessary to label the tabs in
//			// the TabbedPage.
//			this.SetBinding (ContentPage.TitleProperty, "Name");
//			// BoxView to show the color.
//			BoxView boxView = new BoxView {
//				WidthRequest = 100,
//				HeightRequest = 100,
//				HorizontalOptions = LayoutOptions.Center
//			};
//			boxView.SetBinding (BoxView.ColorProperty, "Color");
//
//			// Build the page
//			this.Content = boxView;
//		}
//	}*/
}