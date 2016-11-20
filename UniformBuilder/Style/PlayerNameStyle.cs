namespace UniformBuilder.Style
{
    public class PlayerNameStyle: BaseStyle
    {
        public bool IsOptional { get; set; }
        public int NameMaxLength { get; set; }
        public bool ConfigureNamePlate { get; set; }
        public NamePlateStyle NamePlateStyle { get; set; }
    }
}
