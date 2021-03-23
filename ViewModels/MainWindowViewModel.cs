using System;
using System.Collections.Generic;
using System.Text;
using MammaSpy.ViewModels.Base;
using System.Windows.Markup;
using MammaSpy.Model;
using MammaSpy.Model.Services;
using MammaSpy.Infrasructure.Commands;
using System.Windows.Input;

namespace MammaSpy.ViewModels
{
	[MarkupExtensionReturnType(typeof(MainWindowViewModel))]
	internal class MainWindowViewModel : ViewModel
	{
		private string _title = "Spy";
		public string Title { get => _title; set => Set(ref _title, value); }

		private Dossier _dossier;
		private VKService _vKService;

		public MainWindowViewModel()
		{
			_dossier = new Dossier();
			_vKService = new VKService();

			LearnAboutUserCommand = new LambdaCommand(OnLearnAboutUserCommandExecuted, CanLearnAboutUserCommandExecute);
		}

		#region Properties
		private string _status = "Start";
		public string Status { get => _status; set => Set(ref _status, value); }

		private int _userID = -1;
		public int UserID { get => _userID; set => Set(ref _userID, value); }
		#endregion

		#region Commands
		public ICommand LearnAboutUserCommand { get; }
		private void OnLearnAboutUserCommandExecuted(object p)
		{

		}
		private bool CanLearnAboutUserCommandExecute(object p) => UserID == -1;
		#endregion
	}
}
