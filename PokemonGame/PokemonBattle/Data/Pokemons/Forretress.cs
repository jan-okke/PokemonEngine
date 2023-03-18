using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Forretress : Pokemon
	{
		public override string Name => "Forretress";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
		public override Stats BaseStats => new Stats(75, 90, 140, 60, 60, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Autotomize() },
			[1] = new List<Move>() { new Moves.Autotomize(), new Moves.Heavyslam(), new Moves.Zapcannon(), new Moves.Magnetrise(), new Moves.Toxicspikes(), new Moves.Tackle(), new Moves.Protect(), new Moves.Selfdestruct(), new Moves.Bugbite() },
			[6] = new List<Move>() { new Moves.Selfdestruct() },
			[9] = new List<Move>() { new Moves.Bugbite() },
			[12] = new List<Move>() { new Moves.Takedown() },
			[17] = new List<Move>() { new Moves.Rapidspin() },
			[20] = new List<Move>() { new Moves.Reflect() },
			[23] = new List<Move>() { new Moves.Rollout() },
			[28] = new List<Move>() { new Moves.Spikes() },
			[32] = new List<Move>() { new Moves.Payback() },
			[36] = new List<Move>() { new Moves.Explosion() },
			[42] = new List<Move>() { new Moves.Irondefense() },
			[46] = new List<Move>() { new Moves.Gyroball() },
			[50] = new List<Move>() { new Moves.Doubleedge() },
			[56] = new List<Move>() { new Moves.Magnetrise() },
			[60] = new List<Move>() { new Moves.Zapcannon() },
			[64] = new List<Move>() { new Moves.Heavyslam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Block(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Gravity(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Laserfocus(), new Moves.Lightscreen(), new Moves.Magnetrise(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Telekinesis(), new Moves.Venoshock(), new Moves.Voltswitch() };
		public override int Weight => 1258;
		public override int ExpYield => 163;
		public override int CatchRate => 75;
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