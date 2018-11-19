namespace EdrpgDLL.Abstract
{
    interface iOptionalComponent : iComponent
    {
        /// <summary>
        /// Military Component Checksum
        /// True = is military component type
        /// False = is not military component type
        /// Checksum for Optional Slots that are
        /// restricted to Military Components
        /// </summary>
        
        double PowerCost { get; set; }
        
        bool Military { get; set; }
    }
}
