using System;
using System.Collections.Generic;
using System.Text;
using MammaSpy.ViewModels.Base;
using System.Windows.Markup;
using MammaSpy.Model;
using MammaSpy.Model.Services;
using MammaSpy.Infrasructure.Commands;
using System.Windows.Input;
using MammaSpy.Model.VKAPIShell.Methods;
using MammaSpy.Model.VKAPIShell.Parameters.UserParameters;
using MammaSpy.Model.VKAPIShell.Parameters.Common;
using MammaSpy.Model.VKAPIShell.Parameters.Base;
using MammaSpy.Model.VKAPIShell.Responses;
using System.Windows;
using MammaSpy.View.Windows;
using MammaSpy.Model.VKAPIShell.Methods.UsersMethods;
using MammaSpy.Model.VKAPIShell.Methods.FriendsMethods;

namespace MammaSpy.ViewModels
{
	[MarkupExtensionReturnType(typeof(MainWindowViewModel))]
	internal class MainWindowViewModel : ViewModel
	{
		private string _title = "Spy";
		public string Title { get => _title; set => Set(ref _title, value); }

		private VKService _vKService;
		private VKResponseParser _parser;
		private Method _currentMethod;
		private ServiceLocator _locator;

		public MainWindowViewModel()
		{
			_locator = new ServiceLocator();
			_vKService = new VKService();
			_parser = _locator.VKResponseParser;
			LearnAboutUserCommand = new LambdaCommand(OnLearnAboutUserCommandExecuted, CanLearnAboutUserCommandExecute);
		}

		#region Properties
		private string _status = "Start";
		public string Status { get => _status; set => Set(ref _status, value); }

		private string _userID = "";
		public string UserID { get => _userID; set => Set(ref _userID, value); }
		#endregion

		#region Commands
		public ICommand LearnAboutUserCommand { get; }
		private void OnLearnAboutUserCommandExecuted(object p)
		{
			try
			{
				OnLearnAboutUserCommandExecutedAsync();
				Status = "Работаю...";
			}
			catch(Exception e)
			{
				Status = $"Operation failed. Reason {e.Message}";
			}
		}
		private async void OnLearnAboutUserCommandExecutedAsync()
		{
			List<UserID> ids = new List<UserID>
			{
				new UserID(UserID)
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
			if (user != null)
			{
				UserIDParameter userID = new UserIDParameter()
				{
					Value = user.ID.ToString()
				};
				List<Parameter> param = new List<Parameter>
				{
					userID
				};
				_currentMethod = new FriendGetMethod(param);
				json = await _vKService.GetMethodResultAsync(_currentMethod);
				var friendsList = _parser.Parse<FriendResponse>(json)?.Response;
				Window dossierWindow = new DossierWindow()
				{
					FirstName = user?.FirstName ?? "not found",
					LastName = user?.LastName ?? "not found",
					Address = $"{user?.HomeTown ?? "home town not found"}, {user?.Country?.Title ?? "country not found"}",
					Birthday = user?.Birthday ?? "not found",
					StudyPlace = user?.Schools?.Count > 0 ? user?.Schools?[0].Name ?? "not found" : "not found",
					FollowersCount = user?.FollowersCount ?? 0,
					PathToImage = user?.PathToUserPhoto ?? "",
					JobPlace = user?.Career?.Company ?? "not found or not indicated",
					FriendsList = friendsList?.Items
				};
				Status = "Готово";
				dossierWindow.ShowDialog();
				Status = "Го еще";
			}
			else
			{
				Status = "Не получилось";
			}
		}
		private bool CanLearnAboutUserCommandExecute(object p) => !string.IsNullOrWhiteSpace(UserID);
		#endregion
	}
}
