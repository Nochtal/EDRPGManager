using EdrpgDLL.Ships.Abstract;
using EdrpgDLL.Components.Abstract;
using EdrpgDLL.Abstract;

namespace EdrpgDLL.Ships.Mounts
{
    public class WeaponMount : iMounts
    {
        public WeaponMount(int size)
        {
            Military = false;
            MountType = "Weapon";
            Size = size;
        }

        public bool Military { get { return Military; } set { Military = value; } }

        public string MountType { get  { return MountType; } set { MountType = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public iWeaponComponent Weapon { get { return Weapon; } set { Weapon = value; } }

        public void EquipComponent(iComponent pw)
        {
            if (VerifyComponent(pw))
            {
                Weapon = (iWeaponComponent)pw;
            }
            else
            {
                /// Do nothing
            }
        }

        public void RemoveComponent()
        {
            Weapon = null;
        }

        public bool VerifyComponent(iComponent pw)
        {
            if (pw is iWeaponComponent && pw.Size <= Size) return true;
            else return false;
        }
    }
}
