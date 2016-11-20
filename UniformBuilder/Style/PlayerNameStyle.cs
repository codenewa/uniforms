namespace UniformBuilder.Style
{
    public class PlayerNameStyle: BaseStyle
    {
        public virtual bool IsOptional { get; set; }
        public virtual int NameMaxLength { get; set; }
        public virtual bool ConfigureNamePlate { get; set; }
        public virtual NamePlateStyle NamePlateStyle { get; set; }
    }
}
