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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
		public override Stats BaseStats => new Stats(85, 115, 80, 105, 80, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Crunch(), new Moves.Thrash(), new Moves.Zapcannon(), new Moves.Gastroacid(), new Moves.Coil(), new Moves.Iondeluge(), new Moves.Crushclaw(), new Moves.Headbutt(), new Moves.Acid(), new Moves.Discharge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Bind(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Dragontail(), new Moves.Drainpunch(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lightscreen(), new Moves.Magnetrise(), new Moves.Outrage(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superfang(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Toxic(), new Moves.Uturn(), new Moves.Voltswitch(), new Moves.Wildcharge() };
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