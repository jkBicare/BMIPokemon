using BMIPokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIPokemon.ViewModels
{
    public class BMIViewModel
    {
        public BMIModel BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new BMIModel();
            BMI.Height = 170;
            BMI.Weight = 43;
        }

    }
}
