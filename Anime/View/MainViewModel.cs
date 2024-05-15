using Anime.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Anime.View
{
	public class MainViewModel:INotifyPropertyChanged
	{
		private object currentView;

		public object CurrentView
		{
			get { return currentView; }
			set { 
				currentView = value;
				OnPropertyChanged();
			}
		}

		HomeView homeView;
		UserView userView;

		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged([CallerMemberName]string name=null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		public RelayCommand openHome { get; }
        public RelayCommand openUser { get; }


        public MainViewModel()
		{
			homeView = new HomeView();
			userView = new UserView();

			openHome = new RelayCommand(x => CurrentView = homeView);
            openUser = new RelayCommand(x => CurrentView = userView);


            CurrentView = homeView;
		}


}
	}
