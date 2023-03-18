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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Furcoat() };
		public override Stats BaseStats => new Stats(75, 80, 60, 65, 90, 102);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
			[5] = new List<Move>() { new Moves.Sandattack() },
			[9] = new List<Move>() { new Moves.Babydolleyes() },
			[12] = new List<Move>() { new Moves.Headbutt() },
			[15] = new List<Move>() { new Moves.Tailwhip() },
			[22] = new List<Move>() { new Moves.Bite() },
			[27] = new List<Move>() { new Moves.Odorsleuth() },
			[33] = new List<Move>() { new Moves.Retaliate() },
			[35] = new List<Move>() { new Moves.Takedown() },
			[38] = new List<Move>() { new Moves.Charm() },
			[42] = new List<Move>() { new Moves.Suckerpunch() },
			[48] = new List<Move>() { new Moves.Cottonguard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Lastresort(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Roleplay(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thunderwave(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Captivate(), new Moves.Mimic(), new Moves.Refresh(), new Moves.Roleplay(), new Moves.Workup() };
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