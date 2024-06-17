using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackState : PlayerAbilityState
{
    private Weapon Weapon;
    public PlayerAttackState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName, Weapon _weapon)
        : base(player, stateMachine, playerData, animBoolName)
    {
        this.Weapon = _weapon;

    }
    public override void Enter()
    {
        base.Enter();
        Weapon.Enter();
    }
}