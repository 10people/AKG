﻿using UnityEngine;

public class HeroAttack4State : MonoBehaviour
{
	public HeroAttackMove AttackMove;

	private PlayerControl player;

    void OnEnable()
    {
        player.LastAttack = true;
	}

	void OnDisable()
	{
		player.LastAttack = false;
	}

	void FixedUpdate()
	{
		AttackMove.MoveUpdate();
	}

	public void OnAttack4Start()
	{
		AttackMove.MoveStart();
	}

	public void OnAttack4Stop()
	{
		AttackMove.MoveStop();
	}

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
	}
}
