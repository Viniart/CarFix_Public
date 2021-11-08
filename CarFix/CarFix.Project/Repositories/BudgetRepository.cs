﻿using CarFix.Project.Contexts;
using CarFix.Project.Domains;
using CarFix.Project.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarFix.Project.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {

        private readonly CarFixContext c_Context;

        public BudgetRepository(CarFixContext _context)
        {

            c_Context = _context;

        }

        public void AnswerBudget(DateTime timeEstimate, double totalValue)
        {
            throw new NotImplementedException();
        }

        
        public void Delete(Guid idBudget)
        {
            Budget selectedBudget = c_Context.Budgets.Find(idBudget);

            c_Context.Budgets.Remove(selectedBudget);

            c_Context.SaveChanges();
        }

        
        public Budget? FindBudget(Guid idBudget)
        {
            return c_Context.Budgets.FirstOrDefault(x => x.Id == idBudget);
        }

        public Budget? FindBudgetByVehicle(Guid idVehicle)
        {
            return c_Context.Budgets.FirstOrDefault(x => x.Id == idVehicle);
        }

        public List<Budget> ListActiveBudgets()
        {
            throw new NotImplementedException();
        }

        
        public List<Budget> ListAllBudgets()
        {
            return c_Context.Budgets
                .AsNoTracking()
                .Include(x => x.IdVehicle)
                .Include(x => x.Vehicle)
                .Include(x => x.Service)
                .ToList();
        }

        
        public void Register(Budget newBudget)
        {
            c_Context.Budgets.Add(newBudget);

            c_Context.SaveChanges();
        }

        
        public void Update(Budget updatedBudget)
        {
            c_Context.Entry(updatedBudget).State = EntityState.Modified;

            c_Context.SaveChanges();
        }
    
    }

}