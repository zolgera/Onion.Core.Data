using Core.Data.Entitys;
using Core.Data.Interfaces.Entitys;
using System.ComponentModel.DataAnnotations;

namespace Core.Data.Dtos
{
    public class BaseDocumentDto: BaseDto, IBaseDocument
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }

        protected void SetBaseDocument(BaseDocument baseDocument)
        {
            SetBaseDto(baseDocument);
            Code = baseDocument.Code;
            Name = baseDocument.Name;
        }
    }
}
