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
		public override List<Ability> AvailableAbilities => new() {new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(75, 90, 140, 60, 60, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Autotomize() },
			[1] = new List<Move>() { new Autotomize(), new Heavyslam(), new Zapcannon(), new Magnetrise(), new Toxicspikes(), new Tackle(), new Protect(), new Selfdestruct(), new Bugbite() },
			[6] = new List<Move>() { new Selfdestruct() },
			[9] = new List<Move>() { new Bugbite() },
			[12] = new List<Move>() { new Takedown() },
			[17] = new List<Move>() { new Rapidspin() },
			[20] = new List<Move>() { new Reflect() },
			[23] = new List<Move>() { new Rollout() },
			[28] = new List<Move>() { new Spikes() },
			[32] = new List<Move>() { new Payback() },
			[36] = new List<Move>() { new Explosion() },
			[42] = new List<Move>() { new Irondefense() },
			[46] = new List<Move>() { new Gyroball() },
			[50] = new List<Move>() { new Doubleedge() },
			[56] = new List<Move>() { new Magnetrise() },
			[60] = new List<Move>() { new Zapcannon() },
			[64] = new List<Move>() { new Heavyslam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Block(), new Bugbite(), new Bugbuzz(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Drillrun(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Flashcannon(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Gravity(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Laserfocus(), new Lightscreen(), new Magnetrise(), new Painsplit(), new Payback(), new Protect(), new Reflect(), new Rest(), new Return(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Signalbeam(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Telekinesis(), new Venoshock(), new Voltswitch() };
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