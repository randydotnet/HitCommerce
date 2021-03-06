using System;
using System.Threading;
using System.Threading.Tasks;
using Hitasp.HitCommon.Seo;
using Volo.Abp.Domain.Services;

namespace Hitasp.HitCommerce.Seo
{
    public interface IUrlRecordService : IDomainService
    {
        Task DeleteUrlRecordAsync(UrlRecord urlRecord, CancellationToken cancellationToken = default);

        Task InsertUrlRecordAsync(UrlRecord urlRecord, CancellationToken cancellationToken = default);

        Task UpdateUrlRecordAsync(UrlRecord urlRecord, CancellationToken cancellationToken = default);

        Task<string> GetActiveSlugAsync(Guid entityId, string entityName,
            CancellationToken cancellationToken = default);

        Task SaveSlugAsync<T>(T entity, string slug, CancellationToken cancellationToken = default)
            where T : ISlugSupported;

        Task<string> GetSeNameAsync<T>(T entity, bool returnDefaultValue = true,
            CancellationToken cancellationToken = default) where T : ISlugSupported;

        Task<string> GetSeNameAsync(Guid entityId, string entityName,
            CancellationToken cancellationToken = default);

        Task<string> GetSeNameAsync(string name, bool convertNonWesternChars, bool allowUnicodeCharsInUrls,
            CancellationToken cancellationToken = default);

        Task<string> ValidateSeNameAsync<T>(T entity, string seName, string name, bool ensureNotEmpty,
            CancellationToken cancellationToken = default) where T : ISlugSupported;

        Task<string> ValidateSeNameAsync(Guid entityId, string entityName, string seName, string name,
            bool ensureNotEmpty, CancellationToken cancellationToken = default);
    }
}