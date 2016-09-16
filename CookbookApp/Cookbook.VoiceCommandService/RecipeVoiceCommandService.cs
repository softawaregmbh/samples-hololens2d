using Cookbook.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.AppService;
using Windows.ApplicationModel.Background;
using Windows.ApplicationModel.VoiceCommands;
using Windows.Storage;

namespace Cookbook.VoiceCommandService
{
    public sealed class RecipeVoiceCommandService : IBackgroundTask
    {
        private BackgroundTaskDeferral deferral;
        private VoiceCommandServiceConnection voiceServiceConnection;

        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            deferral = taskInstance.GetDeferral();

            try
            {
                var triggerDetails = taskInstance.TriggerDetails as AppServiceTriggerDetails;

                if (triggerDetails.Name == "RecipeVoiceCommandService")
                {
                    voiceServiceConnection = VoiceCommandServiceConnection.FromAppServiceTriggerDetails(triggerDetails);

                    var voiceCommand = await voiceServiceConnection.GetVoiceCommandAsync();

                    if (voiceCommand.CommandName == "findRecipe")
                    {
                        var ingredient = voiceCommand.Properties["ingredient"].FirstOrDefault();

                        if (ingredient != null)
                        {
                            var recipes = (await RecipeService.GetRecipes()).Where(p => p.Title.Contains(ingredient)).ToList();

                            var message = new VoiceCommandUserMessage();
                            var tiles = new List<VoiceCommandContentTile>();

                            if (recipes.Count == 0)
                            {
                                message.SpokenMessage = $"Ich konnte leider kein Rezept mit {ingredient} finden.";
                                message.DisplayMessage = message.SpokenMessage;
                            }
                            else
                            {
                                if (recipes.Count == 1)
                                {
                                    message.SpokenMessage = "Hier ist dein Rezept:";
                                }
                                else
                                {
                                    message.SpokenMessage = "Ich habe mehrere Rezepte gefunden:";
                                }

                                message.DisplayMessage = message.SpokenMessage;

                                foreach (var recipe in recipes)
                                {
                                    var tile = new VoiceCommandContentTile();
                                    tile.ContentTileType = VoiceCommandContentTileType.TitleWith68x68IconAndText;

                                    tile.Title = recipe.Title;
                                    tile.TextLine1 = $"Bewertung {recipe.Rating}/5";
                                    tile.Image = await StorageFile.CreateStreamedFileFromUriAsync(
                                       $"recipe{recipe.Id}.png",
                                       new Uri(recipe.ImagePath, UriKind.Absolute),
                                       null);

                                    tile.AppLaunchArgument = $"recipeId={recipe.Id}";

                                    tiles.Add(tile);
                                }
                            }

                            var response = VoiceCommandResponse.CreateResponse(message, tiles);

                            await voiceServiceConnection.ReportSuccessAsync(response);
                        }
                    }
                }
            }
            finally
            {
                if (deferral != null)
                {
                    await Task.Delay(2000);
                    deferral.Complete();
                }
            }

        }
    }
}
