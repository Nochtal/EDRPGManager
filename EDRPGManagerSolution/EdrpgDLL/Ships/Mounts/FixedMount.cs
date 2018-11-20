using EdrpgDLL.Abstract;
using EdrpgDLL.Ships.Abstract;

namespace EdrpgDLL.Ships.Mounts
{
    public class FixedMount : iMounts
    {
        public FixedMount(int size, string component)
        {
            Military = false;
            MountType = "Fixed";
            Component = component;
            Size = size;
        }

        public FixedMount(int size, string component, iFixedComponent c)
        {
            Military = false;
            MountType = "Fixed";
            Component = component;
            Size = size;
            Fixed = c;
        }

        public string Component { get { return Component; } set { Component = value; } }

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
            if (pw is iFixedComponent && pw.Size <= Size && pw.Name == Component) return true;
            else return false;
        }
    }
}
