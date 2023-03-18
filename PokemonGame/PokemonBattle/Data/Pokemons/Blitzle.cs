using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Blitzle : Pokemon
	{
		public override string Name => "Blitzle";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Lightningrod(), new Abilities.Motordrive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sapsipper() };
		public override Stats BaseStats => new Stats(45, 60, 32, 50, 32, 76);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Quickattack() },
			[4] = new List<Move>() { new Moves.Tailwhip() },
			[8] = new List<Move>() { new Moves.Charge() },
			[11] = new List<Move>() { new Moves.Shockwave() },
			[15] = new List<Move>() { new Moves.Thunderwave() },
			[18] = new List<Move>() { new Moves.Flamecharge() },
			[22] = new List<Move>() { new Moves.Pursuit() },
			[25] = new List<Move>() { new Moves.Spark() },
			[29] = new List<Move>() { new Moves.Stomp() },
			[32] = new List<Move>() { new Moves.Discharge() },
			[36] = new List<Move>() { new Moves.Agility() },
			[39] = new List<Move>() { new Moves.Wildcharge() },
			[43] = new List<Move>() { new Moves.Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Facade(), new Moves.Flamecharge(), new Moves.Frustration(), new Moves.Hiddenpower(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Magnetrise(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Toxic(), new Moves.Voltswitch(), new Moves.Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Doubleedge(), new Moves.Doublekick(), new Moves.Endure(), new Moves.Feint(), new Moves.Mefirst(), new Moves.Rage(), new Moves.Sandattack(), new Moves.Screech(), new Moves.Shockwave(), new Moves.Snatch(), new Moves.Takedown() };
		public override int Weight => 298;
		public override int ExpYield => 59;
		public override int CatchRate => 190;
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