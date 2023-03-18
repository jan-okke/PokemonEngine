using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Eelektross : Pokemon
	{
		public override string Name => "Eelektross";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(85, 115, 80, 50, 105, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Crunch(), new Thrash(), new Zapcannon(), new Gastroacid(), new Coil(), new Iondeluge(), new Crushclaw(), new Headbutt(), new Acid(), new Discharge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aquatail(), new Attract(), new Bind(), new Bounce(), new Brickbreak(), new Chargebeam(), new Confide(), new Cut(), new Doubleteam(), new Dragonclaw(), new Dragonpulse(), new Dragontail(), new Drainpunch(), new Facade(), new Firepunch(), new Flamethrower(), new Flashcannon(), new Focuspunch(), new Frustration(), new Gastroacid(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Knockoff(), new Lightscreen(), new Magnetrise(), new Outrage(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Superfang(), new Superpower(), new Swagger(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Toxic(), new Uturn(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 805;
		public override int ExpYield => 258;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}