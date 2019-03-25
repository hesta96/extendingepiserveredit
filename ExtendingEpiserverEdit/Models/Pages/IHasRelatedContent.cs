using EPiServer.Core;

namespace ExtendingEpiserverEdit.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
