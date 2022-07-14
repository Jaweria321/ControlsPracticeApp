using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControlsPracticeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderLabel.Text = Slider.Value.ToString();
        }

       

        private void ColorRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //The sender argument is the RadioButton responsible for this event. You can use
            //this to access the RadioButton object, or to distinguish between multiple
            //RadioButton objects sharing the same CheckedChanged event handler.

            RadioButton radioButton = sender as RadioButton;
            string bg_color = radioButton.Value.ToString();
            if( bg_color == "red" )
            {
                MainView.BackgroundColor = Color.Red;
            }
            else if( bg_color == "black")
            {
                MainView.BackgroundColor = Color.Black;
            }
            else if( bg_color == "gray")
            {
                MainView.BackgroundColor = Color.Gray;
            }

            
                    

   
        }
    }
}
