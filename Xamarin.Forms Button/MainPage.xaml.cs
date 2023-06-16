namespace Xamarin.Forms_Button;

///<Summary>
///<Createddate> 2022/06/16 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/16 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked (object sender, EventArgs e)
	{
		(sender as Button).Text = "Presioname de nuevo";
	}
}