using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Delcatty : Pokemon
	{
		public override string Name => "Delcatty";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Normalize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Wonderskin() };
		public override Stats BaseStats => new Stats(70, 65, 65, 90, 55, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Fakeout(), new Sing(), new Attract() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Calmmind(), new Chargebeam(), new Confide(), new Covet(), new Dig(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Endure(), new Facade(), new Flash(), new Frustration(), new Gigaimpact(), new Grassknot(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Irontail(), new Laserfocus(), new Lastresort(), new Nastyplot(), new Payback(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uproar(), new Waterpulse(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override int Weight => 326;
		public override int ExpYield => 140;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}