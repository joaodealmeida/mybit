using myBit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Controls;
//using myBit.Views;

namespace myBit.Views
{
	public class LoginView : ContentPage
	{
		public LoginView ()
		{
			BindingContext = new LoginViewModel(Navigation);
			Grid grid = new Grid
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				RowDefinitions =
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(.5, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(.25, GridUnitType.Star) },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
				},
				ColumnDefinitions =
				{
					new ColumnDefinition { Width = new GridLength(.1, GridUnitType.Star) },
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = new GridLength(.1, GridUnitType.Star) }
				}
				};

			grid.Children.Add(new Label
				{
					Text = "MyBit",
					FontSize = 40,
					TextColor = Color.FromHex("82909a"),
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.EndAndExpand
				}, 1, 2, 0, 2);

			grid.Children.Add (
				new Image{
					//Aspect = Aspect.AspectFit,
					Source = ImageSource.FromUri(new Uri("http://placehold.it/300x300")),
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					VerticalOptions = LayoutOptions.EndAndExpand
				}, 1, 2, 0, 1
			);

			grid.Children.Add(
				new ExtendedEntry() 
				{
					Placeholder = "Username",
					TextColor = Color.FromHex("9fcdca"),
					//Font = Font.SystemFontOfSize(NamedSize.Large),
					PlaceholderTextColor = Color.Red,
					HasBorder = true,
					XAlign = TextAlignment.Center
				}
				, 1, 2, 4, 5);

			/*
			grid.Children.Add(new Entry {
				Placeholder = "Username",
				TextColor = Color.Aqua,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.EndAndExpand,
				WidthRequest = 300,
			}, 1, 2, 4, 5);
			*/
			/* username.SetBinding(Entry.TextProperty, LoginViewModel.UsernamePropertyName);
			layout.Children.Add(username);
			*/

			grid.Children.Add(new Entry
				{
					Placeholder = "Password",
					TextColor = Color.FromHex("9fcdca"),
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					VerticalOptions = LayoutOptions.EndAndExpand,
					WidthRequest = 300,
				}, 1, 2, 5, 6);
			/*
            password.SetBinding(Entry.TextProperty, LoginViewModel.PasswordPropertyName);
            layout.Children.Add(password);
            */

			grid.Children.Add(new Button {
				Text = "Sign In",
				TextColor = Color.White,
				BackgroundColor = Color.FromHex("9fcdca"),
				VerticalOptions = LayoutOptions.Start,
				WidthRequest = 300,
			}, 1, 2, 6, 7);
			/*
            button.SetBinding(Button.CommandProperty, LoginViewModel.LoginCommandPropertyName);
            layout.Children.Add(button);
            */

			this.BackgroundColor = Color.FromHex ("eef2f5");
			this.Content = grid;
		}
	}
}

