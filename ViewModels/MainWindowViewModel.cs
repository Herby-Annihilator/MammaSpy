using System;
using System.Collections.Generic;
using System.Text;
using MammaSpy.ViewModels.Base;
using System.Windows.Markup;
using MammaSpy.Model;
using MammaSpy.Model.Services;
using MammaSpy.Infrasructure.Commands;
using System.Windows.Input;
using MammaSpy.Model.VKAPIShell.Users;
using MammaSpy.Model.VKAPIShell.Parameters.UserParameters;
using MammaSpy.Model.VKAPIShell.Parameters.Base;
using MammaSpy.Model.VKAPIShell.Responses;

namespace MammaSpy.ViewModels
{
	[MarkupExtensionReturnType(typeof(MainWindowViewModel))]
	internal class MainWindowViewModel : ViewModel
	{
		private string _title = "Spy";
		public string Title { get => _title; set => Set(ref _title, value); }

		private Dossier _dossier;
		private VKService _vKService;
		private VKResponseParser _parser;
		private Method _currentMethod;

		public MainWindowViewModel()
		{
			_dossier = new Dossier();
			_vKService = new VKService();
			_parser = new VKResponseParser();
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
			List<int> ids = new List<int>
			{
				UserID
			};
			UserIDsParameter userIDs = new UserIDsParameter(ids);
			List<Parameter> parameters = new List<Parameter>
			{
				userIDs
			};
			_currentMethod = new UserGetMethod(parameters);
			string json = _vKService.GetMethodResult(_currentMethod);
			var user = _parser.Parse<UserResponse>(json).Response[0];
			_dossier.FirstName = user.FirstName;
			_dossier.LastName = user.LastName;
		}
		private bool CanLearnAboutUserCommandExecute(object p) => UserID > 0;
		#endregion
	}
}
