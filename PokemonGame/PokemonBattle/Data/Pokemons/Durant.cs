using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Durant : Pokemon
	{
		public override string Name => "Durant";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Hustle() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Truant() };
		public override Stats BaseStats => new Stats(58, 109, 112, 109, 48, 48);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Furycutter(), new Sandattack() },
			[4] = new List<Move>() { new Visegrip() },
			[8] = new List<Move>() { new Metalclaw() },
			[12] = new List<Move>() { new Beatup() },
			[16] = new List<Move>() { new Bugbite() },
			[20] = new List<Move>() { new Bite() },
			[24] = new List<Move>() { new Agility() },
			[28] = new List<Move>() { new Dig() },
			[32] = new List<Move>() { new Xscissor() },
			[36] = new List<Move>() { new Crunch() },
			[40] = new List<Move>() { new Metalsound() },
			[44] = new List<Move>() { new Ironhead() },
			[48] = new List<Move>() { new Entrainment() },
			[52] = new List<Move>() { new Irondefense() },
			[56] = new List<Move>() { new Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Batonpass(), new Beatup(), new Crunch(), new Dig(), new Endure(), new Energyball(), new Facade(), new Flashcannon(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Irondefense(), new Ironhead(), new Protect(), new Rest(), new Retaliate(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Screech(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Snore(), new Steelbeam(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Thunderfang(), new Thunderwave(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Firstimpression(), new Flail(), new Infestation(), new Metalburst(), new Strugglebug() };
		public override int Weight => 330;
		public override int ExpYield => 169;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}