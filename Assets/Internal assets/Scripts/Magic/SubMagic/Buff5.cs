using Magic.SuperMagic;
using Magic.Type;
using UnityEngine;

namespace Magic.SubMagic
{
    public class Buff5: MagicAttack
    {
        public override MagicType MagicType { get; set; }
        protected override Color ColorSphere { get; set; }
        protected override float ForceFlight { get; set; }
        protected override float Radius { get; set; }
        
        protected override void CreateMagicModel()
        {
            MagicType = MagicType.Buff5;
            ColorSphere = Color.green;
            ForceFlight = 1000;
            Radius = 0.5f;
            base.CreateMagicModel();
        }
    }
}