using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Igglybuff : Pokemon
	{
		public override string Name => "Igglybuff";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Friendguard() };
		public override Stats BaseStats => new Stats(90, 30, 15, 40, 20, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sing(), new Pound(), new Copycat() },
			[4] = new List<Move>() { new Defensecurl() },
			[8] = new List<Move>() { new Sweetkiss() },
			[12] = new List<Move>() { new Disarmingvoice() },
			[16] = new List<Move>() { new Disable() },
			[20] = new List<Move>() { new Charm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Bounce(), new Charm(), new Dig(), new Doubleteam(), new Drainingkiss(), new Dreameater(), new Endure(), new Facade(), new Faketears(), new Fireblast(), new Flamethrower(), new Flash(), new Fling(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icywind(), new Lightscreen(), new Megakick(), new Megapunch(), new Mistyterrain(), new Playrough(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Screech(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Thunderwave(), new Uproar(), new Waterpulse(), new Wildcharge(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Covet(), new Faketears(), new Gravity(), new Healpulse(), new Lastresort(), new Mistyterrain(), new Perishsong(), new Present(), new Rollout(), new Wish() };
		public override int Weight => 10;
		public override int ExpYield => 42;
		public override int CatchRate => 170;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}