using Item;
using Other;
using UnityEngine.Serialization;
namespace Player
{
    [System.Serializable]
    public class Attribute
    {
        [System.NonSerialized] public PlayerAttribute Parent;
        public Attributes type;
        public ModifiableFloat modifiableFloat;

        public float? Value => modifiableFloat.ModifiedValue;

        public void SetParent(PlayerAttribute parent)
        {
            Parent = parent;
            modifiableFloat = new ModifiableFloat(AttributeModified);
        }

        public void AttributeModified()
        {
            PlayerAttribute.AttributeModified(this);
        }
    }
}
