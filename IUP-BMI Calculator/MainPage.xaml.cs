﻿using IUP_BMI_Calculator.ViewModel;

namespace IUP_BMI_Calculator;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		var viewModel = new BMICalculatorViewModel();
		BindingContext = viewModel;
	}
}

