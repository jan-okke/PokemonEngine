using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Umbreon : Pokemon
	{
		public override string Name => "Umbreon";
		public override List<Ability> AvailableAbilities => new() {new Synchronize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(95, 65, 110, 60, 130, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Snarl() },
			[1] = new List<Move>() { new Foulplay(), new Snarl(), new Covet(), new Swift(), new Bite(), new Copycat(), new Batonpass(), new Takedown(), new Charm(), new Doubleedge(), new Helpinghand(), new Tackle(), new Growl(), new Tailwhip() },
			[5] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Babydolleyes() },
			[20] = new List<Move>() { new Confuseray() },
			[25] = new List<Move>() { new Assurance() },
			[30] = new List<Move>() { new Moonlight() },
			[35] = new List<Move>() { new Guardswap() },
			[40] = new List<Move>() { new Darkpulse() },
			[45] = new List<Move>() { new Screech() },
			[50] = new List<Move>() { new Meanlook() },
			[55] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Batonpass(), new Bodyslam(), new Charm(), new Crunch(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Faketears(), new Flash(), new Focusenergy(), new Foulplay(), new Gigaimpact(), new Guardswap(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Lashout(), new Payback(), new Payday(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Retaliate(), new Round(), new Screech(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Throatchop(), new Torment(), new Weatherball(), new Wonderroom(), new Workup() };
		public override int Weight => 270;
		public override int ExpYield => 184;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}