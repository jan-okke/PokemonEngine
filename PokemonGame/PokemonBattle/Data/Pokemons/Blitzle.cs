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
		public override List<Ability> AvailableAbilities => new() {new Lightningrod(), new Motordrive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sapsipper() };
		public override Stats BaseStats => new Stats(45, 60, 32, 50, 32, 76);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack() },
			[4] = new List<Move>() { new Tailwhip() },
			[8] = new List<Move>() { new Charge() },
			[11] = new List<Move>() { new Shockwave() },
			[15] = new List<Move>() { new Thunderwave() },
			[18] = new List<Move>() { new Flamecharge() },
			[22] = new List<Move>() { new Pursuit() },
			[25] = new List<Move>() { new Spark() },
			[29] = new List<Move>() { new Stomp() },
			[32] = new List<Move>() { new Discharge() },
			[36] = new List<Move>() { new Agility() },
			[39] = new List<Move>() { new Wildcharge() },
			[43] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Chargebeam(), new Confide(), new Doubleteam(), new Facade(), new Flamecharge(), new Frustration(), new Hiddenpower(), new Lightscreen(), new Lowkick(), new Magnetrise(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Toxic(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Doubleedge(), new Doublekick(), new Endure(), new Feint(), new Mefirst(), new Rage(), new Sandattack(), new Screech(), new Shockwave(), new Snatch(), new Takedown() };
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