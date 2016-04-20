﻿using System;
using Xamarin.Forms;

namespace Teste1
{
	public class FindRoommateView : BaseView
	{

		Label resultsLabel;
		SearchBar searchBar;

		public FindRoommateView ()
		{
			resultsLabel = new Label {
				Text = "Result will appear here.",
				VerticalOptions = LayoutOptions.FillAndExpand,
				FontSize = 25
			};

			searchBar = new SearchBar {
				Placeholder = "Enter search term",
				SearchCommand = new Command(() => {resultsLabel.Text = "Result: " + searchBar.Text + " is what you asked for.";})
			};

			this.Content = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
				Children = {
					searchBar,
					new ScrollView
					{
						Content = resultsLabel,
						VerticalOptions = LayoutOptions.FillAndExpand
					},
					new Label {
						Text = "Find Roommate View!",
						VerticalOptions = LayoutOptions.CenterAndExpand,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
					},
					new Button {
						Text = "Show Roommate",
						Command = new Command(() => 
							{
								this.Navigation.PushAsync(new FeedbackView());
							})
					}
				}
			};
		}
	}
}