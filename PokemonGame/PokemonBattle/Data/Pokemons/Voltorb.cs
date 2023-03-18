using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Voltorb : Pokemon
	{
		public override string Name => "Voltorb";
		public override List<Ability> AvailableAbilities => new() {new Soundproof(), new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Aftermath() };
		public override Stats BaseStats => new Stats(40, 30, 50, 100, 55, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Charge(), new Tackle() },
			[4] = new List<Move>() { new Thundershock() },
			[6] = new List<Move>() { new Eerieimpulse() },
			[9] = new List<Move>() { new Spark() },
			[11] = new List<Move>() { new Rollout() },
			[13] = new List<Move>() { new Screech() },
			[16] = new List<Move>() { new Chargebeam() },
			[20] = new List<Move>() { new Swift() },
			[22] = new List<Move>() { new Electroball() },
			[26] = new List<Move>() { new Selfdestruct() },
			[29] = new List<Move>() { new Lightscreen() },
			[34] = new List<Move>() { new Magnetrise() },
			[37] = new List<Move>() { new Discharge() },
			[41] = new List<Move>() { new Explosion() },
			[46] = new List<Move>() { new Gyroball() },
			[48] = new List<Move>() { new Mirrorcoat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Chargebeam(), new Confide(), new Doubleteam(), new Endure(), new Explosion(), new Facade(), new Flash(), new Foulplay(), new Frustration(), new Gyroball(), new Hiddenpower(), new Lightscreen(), new Magiccoat(), new Magnetrise(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snore(), new Substitute(), new Swagger(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Torment(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 104;
		public override int ExpYield => 66;
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