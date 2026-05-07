using Microsoft.Maui.Layouts;

namespace AnimalMatchingGame
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            AnimalButtons.IsVisible = true;
            PlayAgainButton.IsVisible = false;
            List<string> animalEmoji = ["🐧","🐧", "🐻‍❄️","🐻‍❄️", "🐠", "🐠", "🦖", "🦖", "🦃", "🦃", "🐖", "🐖", "🐳", "🐳", "🐃", "🐃"];
            foreach (var button in AnimalButtons.Children.OfType<Button>())
            {
                int index = Random.Shared.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                button.Text = nextEmoji;
                animalEmoji.RemoveAt(index);           
            }
          
        }

        Button lastClicked;
        bool findingMatch = false;
        int matchesFound;
        private void Button_Clicked(object sender, EventArgs e)
        {
            if(sender is Button buttonClicked) // if an animal button is clicked
            {
                if(!string.IsNullOrWhiteSpace(buttonClicked.Text) && (findingMatch == false)) // if the button is not blank, and we havent matched yet
                {
                    buttonClicked.BackgroundColor = Colors.Red; 
                    lastClicked = buttonClicked; // track what we just clicked
                    findingMatch = true; // we're looking for a match now!
                }
                else
                {
                    if((buttonClicked != lastClicked) && (buttonClicked.Text == lastClicked.Text) && (!string.IsNullOrWhiteSpace(buttonClicked.Text))) // new button clicked, and it matched!
                    { 
                        matchesFound++; // increment matches for score
                        lastClicked.Text = " "; // reset the logic
                        buttonClicked.Text = " "; // reset the logic
                    }
                    lastClicked.BackgroundColor = Colors.LightBlue;
                    buttonClicked.BackgroundColor = Colors.LightBlue;
                    findingMatch = false;
                }
                if(matchesFound == 8) // all matches found, reset the game to start and alert user
                {
                    matchesFound = 0;
                    AnimalButtons.IsVisible = false;
                    PlayAgainButton.IsVisible = true;

                    // await DisplayAlertAsync("Alert", "You Win!", "OK"); future development, removed to preserve curriculum progress.
                }
            }

        }
    }
}
