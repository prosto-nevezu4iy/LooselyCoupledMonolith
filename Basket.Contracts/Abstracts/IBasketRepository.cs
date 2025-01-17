﻿using BasketProject.Contracts.Entities;
using Core.Interfaces;

namespace BasketProject.Contracts.Abstracts
{
    public interface IBasketRepository
    {
        Task AddAsync(Basket entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(Basket entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(Basket entity, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        Task<Basket?> GetByIdAsync(int id);
        Task<int> GetBasketCountAsync(Guid userId);
        Task<IList<Basket>> ListAsync(CancellationToken cancellationToken = default);
        Task<IList<Basket>> ListAsync(ISpecification<Basket> specification, CancellationToken cancellationToken = default);
        Task<int> CountAsync(ISpecification<Basket> specification, CancellationToken cancellationToken = default);
        Task<Basket?> FirstOrDefaultAsync(ISpecification<Basket> specification, CancellationToken cancellationToken = default);
    }
}
