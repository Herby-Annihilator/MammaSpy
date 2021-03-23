using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MammaSpy.View.Windows
{
	/// <summary>
	/// Логика взаимодействия для DossierWindow.xaml
	/// </summary>
	public partial class DossierWindow : Window
	{
		public static readonly DependencyProperty FirstNameProperty =
			DependencyProperty.Register(
				nameof(FirstName),
				typeof(string),
				typeof(DossierWindow),
				new PropertyMetadata(default(string))
				);
		public string FirstName { get => (string)GetValue(FirstNameProperty); set => 
				SetValue(FirstNameProperty, value);
		}

		public static readonly DependencyProperty LastNameProperty =
			DependencyProperty.Register(
				nameof(LastName),
				typeof(string),
				typeof(DossierWindow),
				new PropertyMetadata(default(string))
				);
		public string LastName { get => (string)GetValue(LastNameProperty); set =>
			SetValue(LastNameProperty, value); 
		}

		public static readonly DependencyProperty PatronymicProperty =
			DependencyProperty.Register(
				nameof(Patronymic),
				typeof(string),
				typeof(DossierWindow),
				new PropertyMetadata(default(string))
				);
		public string Patronymic { get => (string)GetValue(PatronymicProperty); set =>
			SetValue(PatronymicProperty, value); 
		}


		public static readonly DependencyProperty BirthdayProperty =
			DependencyProperty.Register(
				nameof(Birthday),
				typeof(string),
				typeof(DossierWindow),
				new PropertyMetadata(default(string))
				);
		public string Birthday { get => (string)GetValue(BirthdayProperty); set =>
				SetValue(BirthdayProperty, value);
		}

		public static readonly DependencyProperty AgeProperty =
			DependencyProperty.Register(
				nameof(Age),
				typeof(int),
				typeof(DossierWindow),
				new PropertyMetadata(default(int)));
		public int Age { get => (int)GetValue(AgeProperty); set =>
				SetValue(AgeProperty, value);
		}

		public static readonly DependencyProperty StudyPlaceProperty =
			DependencyProperty.Register(
				nameof(StudyPlace),
				typeof(string),
				typeof(DossierWindow),
				new PropertyMetadata(default(string)));
		public string StudyPlace { get => (string)GetValue(StudyPlaceProperty); set =>
				SetValue(StudyPlaceProperty, value);
		}

		public static readonly DependencyProperty JobPlaceProperty =
			DependencyProperty.Register(
				nameof(JobPlace),
				typeof(string),
				typeof(DossierWindow),
				new PropertyMetadata(default(string)));

		public string JobPlace { get => (string)GetValue(JobPlaceProperty); set =>
				SetValue(JobPlaceProperty, value);
		}

		public static readonly DependencyProperty AddressProperty =
			DependencyProperty.Register(
				nameof(Address),
				typeof(string),
				typeof(DossierWindow),
				new PropertyMetadata(default(string)));
		public string Address { get => (string)GetValue(AddressProperty); set =>
				SetValue(AddressProperty, value);
		}
		public DossierWindow()
		{
			InitializeComponent();
		}
	}
}
