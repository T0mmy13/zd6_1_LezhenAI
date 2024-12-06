using LezhenAI_6_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Color = System.Drawing.Color;

namespace LezhenAI_6._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // Create a Grid layout
            var grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition {  Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition {  Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition {  Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition {  Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition {  Height = new GridLength(50) } // Fixed size for button
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition {  Width = new GridLength(1, GridUnitType.Star) }
                },
                RowSpacing = 0, // No space between rows
                ColumnSpacing = 0 // No space between columns
            };

            // First row of colored rectangles
            var firstRow = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            firstRow.Children.Add(CreateColoredRectangle(Color.Yellow, true));
            firstRow.Children.Add(CreateColoredRectangle(Color.Red, true));
            firstRow.Children.Add(CreateColoredRectangle(Color.Green, true));

            // Second row of black rectangles
            var secondRow = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            secondRow.Children.Add(CreateColoredRectangle(Color.Black, true));
            secondRow.Children.Add(CreateColoredRectangle(Color.Black, true));
            secondRow.Children.Add(CreateColoredRectangle(Color.Black, true));

            // Third row with blue and light blue rectangles
            var thirdRow = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            thirdRow.Children.Add(CreateColoredRectangle(Color.Blue, true));
            thirdRow.Children.Add(CreateColoredRectangle(Color.LightBlue, true));

            // Fourth row with a red rectangle
            var fourthRow = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            fourthRow.Children.Add(CreateColoredRectangle(Color.Red, true));

            // Add rows to the Grid
            grid.Children.Add(firstRow, 0, 0);
            grid.Children.Add(secondRow, 0, 1);
            grid.Children.Add(thirdRow, 0, 2);
            grid.Children.Add(fourthRow, 0, 3);

            // Add button to the Grid
            var nextButton = new Button
            {
                Text = "Next Screen",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.End
            };

            nextButton.Clicked += OnNextButtonClicked;

            grid.Children.Add(nextButton, 0, 4);

            // Set the content of the page
            Content = grid;
        }

        // Event handler for button click
        private async void OnNextButtonClicked(object sender, EventArgs e)
        {
            // Navigate to the next page (replace NextPage with your page)
            await Navigation.PushAsync(new Page1());
        }

        // Helper method to create a colored rectangle
        private BoxView CreateColoredRectangle(Color color, bool fill = false)
        {
            return new BoxView
            {
                Color = color,
                HorizontalOptions = fill ? LayoutOptions.FillAndExpand : LayoutOptions.Start
            };
        }
    }
}

