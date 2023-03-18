using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dunsparce : Pokemon
	{
		public override string Name => "Dunsparce";
		public override List<Ability> AvailableAbilities => new() {new Serenegrace(), new Runaway() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(100, 70, 70, 45, 65, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Flail(), new Defensecurl() },
			[4] = new List<Move>() { new Mudslap() },
			[8] = new List<Move>() { new Rollout() },
			[12] = new List<Move>() { new Glare() },
			[16] = new List<Move>() { new Screech() },
			[20] = new List<Move>() { new Ancientpower() },
			[24] = new List<Move>() { new Drillrun() },
			[28] = new List<Move>() { new Yawn() },
			[32] = new List<Move>() { new Bodyslam() },
			[36] = new List<Move>() { new Takedown() },
			[40] = new List<Move>() { new Roost() },
			[44] = new List<Move>() { new Dragonrush() },
			[48] = new List<Move>() { new Coil() },
			[52] = new List<Move>() { new Doubleedge() },
			[56] = new List<Move>() { new Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Airslash(), new Amnesia(), new Attract(), new Batonpass(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Dig(), new Doubleteam(), new Dreameater(), new Drillrun(), new Dualwingbeat(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Gyroball(), new Helpinghand(), new Hex(), new Hiddenpower(), new Icebeam(), new Irontail(), new Poisonjab(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Retaliate(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roost(), new Round(), new Scaleshot(), new Screech(), new Shadowball(), new Shockwave(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Stompingtantrum(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Terrainpulse(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Waterpulse(), new Wildcharge(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Ancientpower(), new Aquatail(), new Astonish(), new Bite(), new Curse(), new Headbutt(), new Hex(), new Lastresort(), new Magiccoat(), new Snore() };
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
}