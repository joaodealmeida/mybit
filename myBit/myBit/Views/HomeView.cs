using myBit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace myBit.Views
{
	public class HomeView : ContentPage
	{
		public HomeView()
		{
			BindingContext = new LoginViewModel(Navigation);
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
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
				},
				ColumnDefinitions =
				{
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
				}
			};

			grid.Children.Add(new Label
				{
					Text = "MyBit",
					FontSize = 50,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.EndAndExpand
				}, 1, 2, 0, 2);

			grid.Children.Add(new Entry {
				Placeholder = "Username",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.EndAndExpand,
				WidthRequest = 200,
			}, 1, 2, 3, 4);
			/* username.SetBinding(Entry.TextProperty, LoginViewModel.UsernamePropertyName);
             layout.Children.Add(username);
             */

			grid.Children.Add(new Entry
				{
					Placeholder = "Password",
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					VerticalOptions = LayoutOptions.EndAndExpand,
					WidthRequest = 200,
				}, 1, 2, 4, 5);
			/*
            password.SetBinding(Entry.TextProperty, LoginViewModel.PasswordPropertyName);
            layout.Children.Add(password);
            */

			grid.Children.Add(new Button {
				Text = "Sign In",
				TextColor = Color.White,
				VerticalOptions = LayoutOptions.Start,
				WidthRequest = 200,
			}, 1, 2, 5, 6);
			/*
            button.SetBinding(Button.CommandProperty, LoginViewModel.LoginCommandPropertyName);
            layout.Children.Add(button);
            */

			this.Content = grid;
		}
	}
}

/*
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

            BindingContext = new LoginViewModel(Navigation);

            var layout = new StackLayout { Padding = 10 };

            var username = new Entry { Placeholder = "Username" };
            username.SetBinding(Entry.TextProperty, LoginViewModel.UsernamePropertyName);
            layout.Children.Add(username);

            var password = new Entry { Placeholder = "Password", IsPassword = true };
            password.SetBinding(Entry.TextProperty, LoginViewModel.PasswordPropertyName);
            layout.Children.Add(password);

            var button = new Button { Text = "Sign In", TextColor = Color.White };
            button.SetBinding(Button.CommandProperty, LoginViewModel.LoginCommandPropertyName);
            layout.Children.Add(button);

            Content = new ScrollView { Content = layout };

    */