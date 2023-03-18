using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Electrode : Pokemon
	{
		public override string Name => "Electrode";
		public override List<Ability> AvailableAbilities => new() {new Soundproof(), new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Aftermath() };
		public override Stats BaseStats => new Stats(60, 50, 70, 80, 80, 150);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Magneticflux(), new Charge(), new Tackle(), new Eerieimpulse() },
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
			[36] = new List<Move>() { new Magnetrise() },
			[41] = new List<Move>() { new Discharge() },
			[47] = new List<Move>() { new Explosion() },
			[54] = new List<Move>() { new Gyroball() },
			[58] = new List<Move>() { new Mirrorcoat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Chargebeam(), new Confide(), new Doubleteam(), new Endure(), new Explosion(), new Facade(), new Flash(), new Foulplay(), new Frustration(), new Gigaimpact(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Magiccoat(), new Magnetrise(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snore(), new Substitute(), new Swagger(), new Taunt(), new Telekinesis(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Torment(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 666;
		public override int ExpYield => 172;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}