using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dunsparce : Pokemon
{
	public override string Name => "Dunsparce";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Serenegrace(), new Abilities.Runaway() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
	public override Stats BaseStats => new Stats(100, 70, 70, 65, 65, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Flail(), new Moves.Defensecurl() },
		[4] = new List<Move>() { new Moves.Mudslap() },
		[8] = new List<Move>() { new Moves.Rollout() },
		[12] = new List<Move>() { new Moves.Glare() },
		[16] = new List<Move>() { new Moves.Screech() },
		[20] = new List<Move>() { new Moves.Ancientpower() },
		[24] = new List<Move>() { new Moves.Drillrun() },
		[28] = new List<Move>() { new Moves.Yawn() },
		[32] = new List<Move>() { new Moves.Bodyslam() },
		[36] = new List<Move>() { new Moves.Takedown() },
		[40] = new List<Move>() { new Moves.Roost() },
		[44] = new List<Move>() { new Moves.Dragonrush() },
		[48] = new List<Move>() { new Moves.Coil() },
		[52] = new List<Move>() { new Moves.Doubleedge() },
		[56] = new List<Move>() { new Moves.Endeavor() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Drillrun(), new Moves.Dualwingbeat(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Irontail(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roost(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Terrainpulse(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Waterpulse(), new Moves.Wildcharge(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Ancientpower(), new Moves.Aquatail(), new Moves.Astonish(), new Moves.Bite(), new Moves.Curse(), new Moves.Headbutt(), new Moves.Hex(), new Moves.Lastresort(), new Moves.Magiccoat(), new Moves.Snore() };
	public override int Weight => 140;
	public override int ExpYield => 145;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}