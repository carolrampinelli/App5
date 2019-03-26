using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Label1.IsVisible = false;
            Label2.IsVisible = false;

            if (Entry2.Text != null &&
                Entry2.Text.Length > 0 &&
                Plicker.SelectedIndex >= 0)
            {
                int periodo = int.Parse(Entry.2Text);
                int semestre = Picker.SelectedIndex + 1;

                if (periodo == semestre)
                {
                    Label1.IsVisible = true;
                }
                else
                {
                    Label2.IsVisible = true;
                }
            }
            else
            {
                Label2.IsVisible = true;
            }

        }
    }
}
