using EdrpgDLL.Abstract;

namespace EdrpgDLL.Ships.Abstract
{
    public interface iMounts
    {
        /// <summary>
        /// Size of mount.
        /// Components sizes: 1-8
        /// Utility sized as 0
        /// Small weapon mount = 1
        /// Medium weapon mount = 2
        /// Large weapon mount = 3
        /// Huge weapon mount = 4
        /// </summary>
        int Size { get; set; }
        /// <summary>
        /// Some mounts can only receive Military components.
        /// </summary>
        bool Military { get; set; }
        /// <summary>
        /// Mount Types can be Fixed, Optional, Utility, or Weapon
        /// </summary>
        string MountType { get; set; }

        bool VerifyComponent(iComponent pw);
        void EquipComponent(iComponent pw);

        string ToString();
    }
}
