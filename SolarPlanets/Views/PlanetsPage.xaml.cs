using SolarPlanets.Services;

namespace Views
{
    public partial class PlanetsPage : ContentPage
    {
        private const uint AnimationDuration = 800u;
        public PlanetsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            lstPopularPlanets.ItemsSource = PlanetServices.GetFeaturedPlanets();
            lstAllPlanets.ItemsSource = PlanetServices.GetAllPlanets();
        }

        async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        async void ProfilePic_Clicked(object sender, EventArgs e)
        {
            _ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
            await MainContentGrid.ScaleTo(0.8, AnimationDuration);
            _ = MainContentGrid.FadeTo(0.8, AnimationDuration);
        }

        async void GridArea_Tapped(object sender, EventArgs e)
        {
            await CloseMenu();
        }

        private async Task CloseMenu()
        {
            _ = MainContentGrid.FadeTo(1, AnimationDuration);
            _ = MainContentGrid.ScaleTo(1, AnimationDuration);
            await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
        }
    }
}
