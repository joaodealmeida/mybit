using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace myBit.Views
{
    public class PageOneView : BaseView
    {
        Label resultsLabel;
        SearchBar searchBar;

        public PageOneView()
        {
            resultsLabel = new Label
            {
                Text = "Result will appear here.",
                VerticalOptions = LayoutOptions.FillAndExpand,
                FontSize = 25
            };

            searchBar = new SearchBar
            {
                Placeholder = "Enter search term",
                SearchCommand = new Command(() => { resultsLabel.Text = "Result: " + searchBar.Text + " is what you asked for."; })
            };

            this.Content = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                Children = {
                    new Label {
                        Text = "PageOne View!",
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                    },
                    new Button {
                        Text = "Show FeedbackView",
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
