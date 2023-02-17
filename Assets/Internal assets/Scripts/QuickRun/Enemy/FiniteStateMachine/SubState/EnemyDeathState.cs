using Internal_assets.Scripts.QuickRun.Enemy.FiniteStateMachine.SuperState;
using UnityEngine;
namespace Internal_assets.Scripts.QuickRun.Enemy.FiniteStateMachine.SubState
{
    public class EnemyDeathState : EnemyAbilityState
    {
        public EnemyDeathState(EnemyStateController stateController, EnemyStateMachine stateMachine, EnemyStatistic enemyStatistic, string animBoolName) : base(stateController, stateMachine, enemyStatistic, animBoolName)
        {
        }

        public override void AnimationFinishTrigger()
        {
            base.AnimationFinishTrigger();

            StateController.gameObject.layer = LayerMask.NameToLayer("Interactable");
        }
    }
}