namespace DixKontrol.MVVM.Vistas.ArchivoHistorico;

public partial class ArchivodePrensaPage : BasePage
{
	public ArchivodePrensaPage()
	{
		InitializeComponent();
	}
    private async void OnNoticiaElPeriodicoClicked(object sender, EventArgs e)
       => await Launcher.OpenAsync("https://www.elperiodico.com/es/ocio-y-cultura/20190922/entrevista-dj-nando-dixkontrol-fiesta-celebracion-30-anos-discoteca-psicodromo-poblenou-barcelona-7645963");

    private async void OnNoticiaPonteLasPilasClicked(object sender, EventArgs e)
        => await Launcher.OpenAsync("https://www.rtve.es/play/videos/ponte-las-pilas/");

    private async void OnNoticiaCCCBClicked(object sender, EventArgs e)
        => await Launcher.OpenAsync("https://www.cccb.org/es/participantes/ficha/nando-dixkontrol/226458");

    private async void OnNoticiaLaVanguardiaClicked(object sender, EventArgs e)
        => await Launcher.OpenAsync("https://www.lavanguardia.com/musica/20160906/41120299210/nando-dixkontrol-entrevista-documental-ciudadano-fernando-gallego.HTML");

    private async void OnNoticiaHoyEmpiezaTodoClicked(object sender, EventArgs e)
        => await Launcher.OpenAsync("https://www.rtve.es/play/audios/hoy-empieza-todo-1-2012-2025/hoy-empieza-todo-angel-carmona-nando-dixkontrol-30-anos-techno-espalda-060716/3654562/");

    private async void OnNoticiaBeatburguerClicked(object sender, EventArgs e)
        => await Launcher.OpenAsync("https://beatburguer.com/30-anos-de-psicodromo-club-de-referencia-en-la-noche-y-el-dia-de-barcelona/");

    private async void OnNoticiaElEspanolClicked(object sender, EventArgs e)
        => await Launcher.OpenAsync("https://www.elespanol.com/cultura/musica/20160922/157485069_0.html");
}
