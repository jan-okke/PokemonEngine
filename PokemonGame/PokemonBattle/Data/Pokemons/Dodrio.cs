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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Tangledfeet() };
		public override Stats BaseStats => new Stats(60, 110, 70, 60, 60, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Triattack() },
			[1] = new List<Move>() { new Moves.Triattack(), new Moves.Peck(), new Moves.Growl(), new Moves.Quickattack() },
			[5] = new List<Move>() { new Moves.Quickattack() },
			[8] = new List<Move>() { new Moves.Leer() },
			[12] = new List<Move>() { new Moves.Furyattack() },
			[15] = new List<Move>() { new Moves.Wingattack() },
			[19] = new List<Move>() { new Moves.Pluck() },
			[22] = new List<Move>() { new Moves.Doublehit() },
			[26] = new List<Move>() { new Moves.Agility() },
			[29] = new List<Move>() { new Moves.Uproar() },
			[34] = new List<Move>() { new Moves.Acupressure() },
			[38] = new List<Move>() { new Moves.Swordsdance() },
			[43] = new List<Move>() { new Moves.Lunge() },
			[47] = new List<Move>() { new Moves.Drillpeck() },
			[52] = new List<Move>() { new Moves.Endeavor() },
			[56] = new List<Move>() { new Moves.Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Knockoff(), new Moves.Payback(), new Moves.Pluck(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Uproar(), new Moves.Workup() };
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