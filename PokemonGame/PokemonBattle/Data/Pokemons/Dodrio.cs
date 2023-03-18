using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dodrio : Pokemon
	{
		public override string Name => "Dodrio";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Tangledfeet() };
		public override Stats BaseStats => new Stats(60, 110, 70, 110, 60, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Triattack() },
			[1] = new List<Move>() { new Triattack(), new Peck(), new Growl(), new Quickattack() },
			[5] = new List<Move>() { new Quickattack() },
			[8] = new List<Move>() { new Leer() },
			[12] = new List<Move>() { new Furyattack() },
			[15] = new List<Move>() { new Wingattack() },
			[19] = new List<Move>() { new Pluck() },
			[22] = new List<Move>() { new Doublehit() },
			[26] = new List<Move>() { new Agility() },
			[29] = new List<Move>() { new Uproar() },
			[34] = new List<Move>() { new Acupressure() },
			[38] = new List<Move>() { new Swordsdance() },
			[43] = new List<Move>() { new Lunge() },
			[47] = new List<Move>() { new Drillpeck() },
			[52] = new List<Move>() { new Endeavor() },
			[56] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Endure(), new Facade(), new Fly(), new Frustration(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Knockoff(), new Payback(), new Pluck(), new Protect(), new Rest(), new Return(), new Roost(), new Round(), new Skyattack(), new Sleeptalk(), new Snore(), new Steelwing(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Torment(), new Uproar(), new Workup() };
		public override int Weight => 852;
		public override int ExpYield => 165;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}