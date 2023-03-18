using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Raticate : Pokemon
	{
		public override string Name => "Raticate";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Guts() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(55, 81, 60, 50, 70, 97);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Scaryface() },
			[1] = new List<Move>() { new Scaryface(), new Swordsdance(), new Tackle(), new Tailwhip(), new Quickattack(), new Focusenergy() },
			[4] = new List<Move>() { new Quickattack() },
			[7] = new List<Move>() { new Focusenergy() },
			[10] = new List<Move>() { new Bite() },
			[13] = new List<Move>() { new Laserfocus() },
			[16] = new List<Move>() { new Takedown() },
			[19] = new List<Move>() { new Assurance() },
			[24] = new List<Move>() { new Crunch() },
			[29] = new List<Move>() { new Suckerpunch() },
			[34] = new List<Move>() { new Superfang() },
			[39] = new List<Move>() { new Doubleedge() },
			[44] = new List<Move>() { new Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Chargebeam(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Endeavor(), new Endure(), new Facade(), new Frustration(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irontail(), new Lastresort(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Superfang(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uproar(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override int Weight => 185;
		public override int ExpYield => 145;
		public override int CatchRate => 127;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}