using Cookbook.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechRecognition;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Cookbook.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RecipesView : Page
    {
        private RecipesViewModel viewModel;
        private CoreDispatcher dispatcher;
        private const string nextTerm = "next";
        private const string backTerm = "back";
        
        public RecipesView()
        {
            this.InitializeComponent();

            this.dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.viewModel = new RecipesViewModel();
            this.DataContext = viewModel;

            await viewModel.LoadRecipes();

            InitializeSpeechRecognition();
        }

        private async void InitializeSpeechRecognition()
        {
            var speechRecognizer = new SpeechRecognizer(new Windows.Globalization.Language("en-US"));

            var navigationConstraint = new SpeechRecognitionListConstraint(new[] { nextTerm, backTerm }, "navigate");
            speechRecognizer.Constraints.Add(navigationConstraint);

            await speechRecognizer.CompileConstraintsAsync();

            speechRecognizer.ContinuousRecognitionSession.ResultGenerated += ContinuousRecognitionSession_ResultGenerated;
            await speechRecognizer.ContinuousRecognitionSession.StartAsync();
        }

        private async void ContinuousRecognitionSession_ResultGenerated(SpeechContinuousRecognitionSession sender, SpeechContinuousRecognitionResultGeneratedEventArgs args)
        {
            if (args.Result?.Constraint.Tag == "navigate")
            {
                await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (args.Result.Text == nextTerm)
                    {
                        this.viewModel.NavigateRecipe(1);
                    }
                    else
                    {
                        this.viewModel.NavigateRecipe(-1);
                    }
                });
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.splitView.IsPaneOpen = !this.splitView.IsPaneOpen;
        }
    }
}
