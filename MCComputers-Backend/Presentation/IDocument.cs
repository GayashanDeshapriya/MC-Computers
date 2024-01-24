using QuestPDF.Infrastructure;

namespace MCComputers.Presentation
{
    public interface IDocument
    {
        DocumentMetadata GetMetadata();
        DocumentSettings GetSettings();
        void Compose(IDocumentContainer container);
    }
}
