using CarFix.Project.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Interfaces
{
    interface IBudgetRepository
    {
        List<Budget> ListAllBudgets();
        List<Budget> ListActiveBudgets();
        Budget? FindBudget(Guid idBudget);
        Budget? FindBudgetByVehicle(Guid idVehicle);
        void AnswerBudget(DateTime timeEstimate, double totalValue);
        void Register(Budget newBudget);
        void Update(Budget updatedBudget);
        void Delete(Guid idBudget);
    }
}
