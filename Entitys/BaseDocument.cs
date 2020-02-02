using Core.Data.Dtos;
using Core.Data.Interfaces.Audit;
using Core.Data.Interfaces.Entitys;

namespace Core.Data.Entitys
{
    public abstract class BaseDocument : BaseEntity, IBaseDocument, IAuditable
    {
        private string code;
        public string Code { get {
                return code;
            } set {
                code = value;
            } }
        public string Name { get; set; }
        public void SetCode(string code)
        {
            this.code = code;
        }
        protected void SetDto(BaseDocumentDto dto)
        {
            SetDto((BaseDto)dto);
            Code = dto.Code;
            Name = dto.Name;
        }
    }
}
