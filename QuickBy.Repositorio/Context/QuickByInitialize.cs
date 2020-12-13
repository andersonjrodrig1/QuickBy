using QuickBy.Dominio.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBy.Repositorio.Context
{
    public class QuickByInitialize
    {
        private readonly QuickByContext _context;

        public QuickByInitialize(QuickByContext context)
        {
            _context = context;
        }

        public void InitializeQuickByDB()
        {
            if (!_context.Set<FormPayment>().Any())
            {
                _context.Set<FormPayment>().AddRange(
                    new List<FormPayment>() { 
                        new FormPayment() { Id = 1, Name = "Boleto", Description = "Forma de Pagamento Boleto" },
                        new FormPayment() { Id = 2, Name = "Cartão de Crédito",  Description = "Forma de Pagamento Cartão de Crédito" },
                        new FormPayment() { Id = 3, Name = "Depósito", Description = "Forma de Pagamento Depósito" }
                    });

                _context.SaveChanges(true);
            }
        }
    }
}
