using System.Threading.Tasks;
using Amolenk.ServerlessPonies.FunctionApplication.Model;

namespace Amolenk.ServerlessPonies.FunctionApplication.Entities
{
    public interface IGameSession
    {
        Task StartSinglePlayer(string playerName);

        Task PurchaseAnimalAsync(AnimalPurchase purchase);

        Task MoveAnimalAsync(AnimalMovement movement);

        Task UpdateAnimalMoodAsync(AnimalMoodChange mood);

        Task DepositCreditsAsync(CreditsDeposit deposit);
    }
}