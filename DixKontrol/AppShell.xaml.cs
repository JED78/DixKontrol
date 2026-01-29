namespace DixKontrol
{
    public partial class AppShell : Shell
    {
            public AppShell()
            {
                InitializeComponent();

        this.Items.Add(new ShellContent
        {
            ContentTemplate = new DataTemplate(typeof(DermiurgoPage)),
            Route = "MainPage"
        });
            }
        }
    }
