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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Cutecharm(), new Abilities.Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Friendguard() };
		public override Stats BaseStats => new Stats(90, 30, 15, 40, 20, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Sing(), new Moves.Pound(), new Moves.Copycat() },
			[4] = new List<Move>() { new Moves.Defensecurl() },
			[8] = new List<Move>() { new Moves.Sweetkiss() },
			[12] = new List<Move>() { new Moves.Disarmingvoice() },
			[16] = new List<Move>() { new Moves.Disable() },
			[20] = new List<Move>() { new Moves.Charm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Charm(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mistyterrain(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Wildcharge(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Covet(), new Moves.Faketears(), new Moves.Gravity(), new Moves.Healpulse(), new Moves.Lastresort(), new Moves.Mistyterrain(), new Moves.Perishsong(), new Moves.Present(), new Moves.Rollout(), new Moves.Wish() };
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