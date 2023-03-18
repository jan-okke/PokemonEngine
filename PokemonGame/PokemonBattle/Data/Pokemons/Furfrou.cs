using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Furfrou : Pokemon
	{
		public override string Name => "Furfrou";
		public override List<Ability> AvailableAbilities => new() {new Furcoat() };
		public override Stats BaseStats => new Stats(75, 80, 60, 65, 90, 102);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[5] = new List<Move>() { new Sandattack() },
			[9] = new List<Move>() { new Babydolleyes() },
			[12] = new List<Move>() { new Headbutt() },
			[15] = new List<Move>() { new Tailwhip() },
			[22] = new List<Move>() { new Bite() },
			[27] = new List<Move>() { new Odorsleuth() },
			[33] = new List<Move>() { new Retaliate() },
			[35] = new List<Move>() { new Takedown() },
			[38] = new List<Move>() { new Charm() },
			[42] = new List<Move>() { new Suckerpunch() },
			[48] = new List<Move>() { new Cottonguard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Chargebeam(), new Confide(), new Darkpulse(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Facade(), new Frustration(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Lastresort(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Roleplay(), new Round(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Thunderwave(), new Toxic(), new Uproar(), new Uturn(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Captivate(), new Mimic(), new Refresh(), new Roleplay(), new Workup() };
		public override int Weight => 280;
		public override int ExpYield => 165;
		public override int CatchRate => 160;
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