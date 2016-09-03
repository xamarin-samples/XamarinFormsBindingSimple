using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsBindingSimple
{
	public partial class Page1 : ContentPage
	{
		public string MainText { get; set; } = "Hello";

		public Page1()
		{
			InitializeComponent();
			this.BindingContext = this;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			this.MainText += "!";
			this.OnPropertyChanged("MainText");
		}
	}
}
