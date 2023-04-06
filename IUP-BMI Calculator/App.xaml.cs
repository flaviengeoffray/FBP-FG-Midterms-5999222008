using IUP_BMI_Calculator.Repository;

namespace IUP_BMI_Calculator;

public partial class App : Application
{
	public BMIResultRepository BMIResultRepo { get; set; }

	public App()
	{
		InitializeComponent();

		BMIResultRepo = new BMIResultRepository(FileAccessHelper.GetLocalFilePath("BMIResult_5999222008_FlavienGeoffray.db3"));

        MainPage = new AppShell();
    }
}
