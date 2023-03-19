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

    internal class MaskModule
    {
        public void Add(Bitmap img, Mask mask)
        {

        }

        public void Disable(Bitmap img, Mask mask) 
        { 
        
        }
    }
}
