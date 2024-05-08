namespace People;

public partial class App : Application
{
    // Add a public static PersonRepository property
    public static PersonRepository PersonRepo { get; set; }

    public App(PersonRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

        //Initialize the PersonRepository property with the PersonRespository singleton object
        //the dependency injection process automatically populates the repo parameter to the constructor
        PersonRepo = repo;

	}
}
