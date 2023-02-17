using UnityEngine;
namespace Internal_assets.Scripts.QuickRun.Enemy
{
    [CreateAssetMenu(fileName = "newEnemyData", menuName = "Data/Enemy Data/Data Base")]
    public class EnemyData : ScriptableObject
    {
        [Header("Enemy Name")]
        public string raceName;

        [Header("Enemy Health")]
        public float maxHealth;
        
        [Header("Enemy Movement")]
        public float movementSpeed;

        [Header("Enemy Attack")]
        public float[] attackDamage = new float[2];
        public float[] attackRetryTime = new float[2];
        public float attackDistance;

        [Header("Player Check")]
        public float playerCheckDistance;

        public RuntimeAnimatorController AnimatorController;
    }
}