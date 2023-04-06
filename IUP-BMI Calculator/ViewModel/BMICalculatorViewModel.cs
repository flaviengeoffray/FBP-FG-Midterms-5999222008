using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IUP_BMI_Calculator.Model;
using IUP_BMI_Calculator.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator.ViewModel
{
    internal partial class BMICalculatorViewModel : ObservableObject
    {
        [ObservableProperty]
        public String name;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(BMIScore))]
        [NotifyPropertyChangedFor(nameof(BMIResult))]
        public double height;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(BMIScore))]
        [NotifyPropertyChangedFor(nameof(BMIResult))]
        public double weight;

        public double BMIScore
            => Math.Round(Weight / Math.Pow(Height / 100, 2), 2);

        public String BMIResult
        {
            get
            {
                if (BMIScore < 18.5)
                    return "Underweight";
                else if (BMIScore < 25)
                    return "Healthy";
                else if (BMIScore < 30)
                    return "Overweight";
                else
                    return "Obese";
            }
        }
        
        [RelayCommand]
        public void Save()
        {
            var repo = new BMIResultRepository(FileAccessHelper.GetLocalFilePath("BMIResult_5999222008_FlavienGeoffray.db3"));
            repo.AddNewBMIResult(Name,Height,Weight,BMIScore,BMIResult);
        }

        [RelayCommand]
        public void Clear()
        {
            Name = null;
            Height = 0;
            Weight = 0;
        }

    }
}
