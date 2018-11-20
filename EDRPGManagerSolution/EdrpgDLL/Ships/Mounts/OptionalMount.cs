using EdrpgDLL.Abstract;
using EdrpgDLL.Ships.Abstract;

namespace EdrpgDLL.Ships.Mounts
{
    public class OptionalMount : iMounts
    {
        public OptionalMount(int size)
        {
            Military = false;
            MountType = "Optional";
            Size = size;
        }

        public OptionalMount(bool military, int size)
        {
            Military = military;
            MountType = "Optional";
            Size = size;
        }

        public bool Military { get { return Military; } set { Military = value; } }

        public string MountType { get { return MountType; } set { MountType = value; } }

        public int Size { get { return Size; } set { Size = value; } }

        public iOptionalComponent Optional { get { return Optional; } set { Optional = value; } }

        public void EquipComponent(iComponent pw)
        {
            if (VerifyComponent(pw))
            {
                Optional = (iOptionalComponent)pw;
            }
            else
            {
                /// Do nothing
            }
        }

        public void RemoveComponent()
        {
            Optional = null;
        }

        public bool VerifyComponent(iComponent pw)
        {
            if (Military)
            {
                if (pw is iOptionalComponent && pw.Size <= Size && pw.Military) return true;
                else return false;
            }
            else if (pw is iOptionalComponent && pw.Size <= Size) return true;
            else return false;
        }
    }
}
