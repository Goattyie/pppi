namespace PPPI
{
    public class Mask
    {
        public MaskType MaskType { get; set; }
    }
    
    public enum MaskType
    {
        Quick,
        Vector
    }


    /// <summary>
    /// Модуль работы с масками
    /// </summary>
    public class MaskModule
    {
        public void Enable(Bitmap img, Mask mask)
        {

        }

        public void Disable(Bitmap img, Mask mask) 
        { 
        
        }
    }
}
