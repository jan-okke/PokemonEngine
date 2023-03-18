using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rattata : Pokemon
	{
		public override string Name => "Rattata";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Guts() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(30, 56, 35, 72, 25, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Tailwhip() },
			[4] = new List<Move>() { new Quickattack() },
			[7] = new List<Move>() { new Focusenergy() },
			[10] = new List<Move>() { new Bite() },
			[13] = new List<Move>() { new Laserfocus() },
			[16] = new List<Move>() { new Takedown() },
			[19] = new List<Move>() { new Assurance() },
			[22] = new List<Move>() { new Crunch() },
			[25] = new List<Move>() { new Suckerpunch() },
			[28] = new List<Move>() { new Superfang() },
			[31] = new List<Move>() { new Doubleedge() },
			[34] = new List<Move>() { new Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Chargebeam(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Endeavor(), new Endure(), new Facade(), new Frustration(), new Grassknot(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irontail(), new Lastresort(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Substitute(), new Sunnyday(), new Superfang(), new Swagger(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uproar(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Bite(), new Counter(), new Finalgambit(), new Flamewheel(), new Furyswipes(), new Lastresort(), new Revenge(), new Reversal(), new Screech(), new Uproar() };
		public override int Weight => 35;
		public override int ExpYield => 51;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}