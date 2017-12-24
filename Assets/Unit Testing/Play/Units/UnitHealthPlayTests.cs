using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using RealDreams.Studio.Engine;
using System;

public class UnitHealthPlayTests {

	GameObject bot;
	UnitData botStats;
	FloatVariable botHP;
	UnitHealth botHealthBehaviour;

	GameObject enemy;
	EnemyData enemyStats;

	[OneTimeSetUp]
	public void Init()
	{
		botHP = ScriptableObject.CreateInstance<FloatVariable>();

		botStats = ScriptableObject.CreateInstance<PlayerData>();
		botStats.MaxHP = new FloatReference(120f);
		botStats.HP = botHP;

		bot = new GameObject();
		bot.AddComponent<UnitHealth>();
		botHealthBehaviour = bot.GetComponent<UnitHealth>();
		botHealthBehaviour.BaseStats = botStats;
	}

	[UnityTest]
	public IEnumerator UnitHealtTest_StartsWithMaxHP() {
		yield return null;
		Assert.AreEqual(botStats.MaxHP.Value, botHP.Value);
	}

	[Test]
	public void UnitHealtTest_RecievesDamage()
	{
		throw new NotImplementedException();
	}

	[Test]
	public void UnitHealtTest_DeathEventInvoked()
	{
		throw new NotImplementedException();
	}

	[Test]
	public void UnitHealtTest_DamageEventInvoked()
	{
		throw new NotImplementedException();
	}
}