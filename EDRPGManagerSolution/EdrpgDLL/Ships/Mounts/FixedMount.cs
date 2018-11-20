using EdrpgDLL.Abstract;
using EdrpgDLL.Ships.Abstract;

namespace EdrpgDLL.Ships.Mounts
{
    public class FixedMount : iMounts
    {
        public FixedMount(int size)
        {
            Military = false;
            MountType = "Fixed";
            Size = size;
        }

        public bool Military { get { return Military; } set { Military = value; } }

        public string MountType { get { return MountType; } set { MountType = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public iFixedComponent Fixed { get { return Fixed; } set { Fixed = value; } }

        public void EquipComponent(iComponent pw)
        {
            if (VerifyComponent(pw))
            {
                Fixed = (iFixedComponent)pw;
            }
            else
            {
                /// Do nothing
            }
        }

        public bool VerifyComponent(iComponent pw)
        {
            if (pw is iFixedComponent && pw.Size <= Size) return true;
            else return false;
        }
    }
}
