using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using myBit.Views;

namespace myBit {
    class SelectView : ExpandView {

        private int _index;
        public int Index {
            get {
                return _index;
            }
            set {
                _index = value;
                for (var i = 0; i < _buttons.Count; i++) {
                    var title = string.Format("{0}{1}", Index == i ? "●" : "  ", _list[i]);
						new MeetingRoomsView ();
                    _buttons[i].Text = title;
                }
            }
        }


        private List<ExButton> _buttons = new List<ExButton>();
        private int _buttonHeight;
		private List<String> _list;

		public SelectView(List<String>list) {
            _list = list;

            _buttonHeight = Device.OnPlatform(50, 50, 100);
            _height = _buttonHeight * list.Count;

            var stackLayout = new StackLayout {
                Spacing = 0,
            };
            for (var i = 0; i < list.Count; i++) {
                var button = new ExButton(Alignment.Left);
                button.HeightRequest = _buttonHeight;
                _buttons.Add(button);
                stackLayout.Children.Add(button);
                subViews.Add(button);
                button.Clicked += (s, e) => {
                    Index = _buttons.IndexOf((ExButton)s);
                    Expand = false;
                };
            }
            Index = 0;
            Content = stackLayout;
        }
    }
}
