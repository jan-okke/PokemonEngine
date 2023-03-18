using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zebstrika : Pokemon
	{
		public override string Name => "Zebstrika";
		public override List<Ability> AvailableAbilities => new() {new Lightningrod(), new Motordrive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sapsipper() };
		public override Stats BaseStats => new Stats(75, 100, 63, 116, 80, 63);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Iondeluge(), new Quickattack(), new Tailwhip(), new Charge(), new Thunderwave() },
			[4] = new List<Move>() { new Tailwhip() },
			[8] = new List<Move>() { new Charge() },
			[11] = new List<Move>() { new Shockwave() },
			[15] = new List<Move>() { new Thunderwave() },
			[18] = new List<Move>() { new Flamecharge() },
			[22] = new List<Move>() { new Pursuit() },
			[25] = new List<Move>() { new Spark() },
			[31] = new List<Move>() { new Stomp() },
			[36] = new List<Move>() { new Discharge() },
			[42] = new List<Move>() { new Agility() },
			[47] = new List<Move>() { new Wildcharge() },
			[53] = new List<Move>() { new Thrash() },
			[58] = new List<Move>() { new Iondeluge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bounce(), new Chargebeam(), new Confide(), new Doubleteam(), new Facade(), new Flamecharge(), new Frustration(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Laserfocus(), new Lightscreen(), new Lowkick(), new Magnetrise(), new Overheat(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Toxic(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 795;
		public override int ExpYield => 174;
		public override int CatchRate => 75;
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