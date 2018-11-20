using EdrpgDLL.Abstract;
using EdrpgDLL.Components.Abstract;
using EdrpgDLL.Ships.Abstract;

namespace EdrpgDLL.Ships.Mounts
{
    class UtilityMount : iMounts
    {
        public UtilityMount(int size)
        {
            Military = false;
            MountType = "Utility";
            Size = size;
        }

        public bool Military { get { return Military; } set { Military = value; } }

        public string MountType { get { return MountType; } set { MountType = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public iUtilityComponent Weapon { get { return Weapon; } set { Weapon = value; } }

        public void EquipComponent(iComponent pw)
        {
            if (VerifyComponent(pw))
            {
                Weapon = (iUtilityComponent)pw;
            }
            else
            {
                /// Do nothing
            }
        }

        public bool VerifyComponent(iComponent pw)
        {
            if (pw is iUtilityComponent && pw.Size <= Size) return true;
            else return false;
        }
    }
}