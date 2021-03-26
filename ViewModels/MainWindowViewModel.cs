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
using System.Windows;
using MammaSpy.View.Windows;

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
		private ServiceLocator _locator;

		public MainWindowViewModel()
		{
			_locator = new ServiceLocator();
			_dossier = new Dossier();
			_vKService = new VKService();
			_parser = _locator.VKResponseParser;
			LearnAboutUserCommand = new LambdaCommand(OnLearnAboutUserCommandExecuted, CanLearnAboutUserCommandExecute);
		}

		#region Properties
		private string _status = "Start";
		public string Status { get => _status; set => Set(ref _status, value); }

		private int _userID = 0;
		public int UserID { get => _userID; set => Set(ref _userID, value); }
		#endregion

		#region Commands
		public ICommand LearnAboutUserCommand { get; }
		private void OnLearnAboutUserCommandExecuted(object p)
		{
			try
			{
				OnLearnAboutUserCommandExecutedAsync();
			}
			catch(Exception e)
			{
				Status = $"Operation failed. Reason {e.Message}";
			}
		}
		private async void OnLearnAboutUserCommandExecutedAsync()
		{
			List<int> ids = new List<int>
			{
				UserID
			};
			UserIDsParameter userIDs = new UserIDsParameter(ids);
			UserFieldsParameter userFields = new UserFieldsParameter(FieldsValues.bdate | FieldsValues.home_town | FieldsValues.country | FieldsValues.schools | FieldsValues.followers_count | FieldsValues.photo_200);
			List<Parameter> parameters = new List<Parameter>
			{
				userIDs,
				userFields
			};
			_currentMethod = new UserGetMethod(parameters);
			string json = await _vKService.GetMethodResultAsync(_currentMethod);
			var user = _parser.Parse<UserResponse>(json).Response[0];
			Window dossierWindow = new DossierWindow()
			{
				FirstName = user.FirstName ?? "not found",
				LastName = user.LastName,
				Address = $"{user.HomeTown}, {user.Country.Title}",
				Birthday = user.Birthday,
				StudyPlace = user.Schools?[0].Name,
				FollowersCount = user.FollowersCount,
				PathToImage = user.PathToUserPhoto
			};
			dossierWindow.ShowDialog();
		}
		private bool CanLearnAboutUserCommandExecute(object p) => UserID > 0;
		#endregion
	}
}
