using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spiritomb : Pokemon
	{
		public override string Name => "Spiritomb";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Infiltrator() };
		public override Stats BaseStats => new Stats(50, 92, 108, 35, 92, 108);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Nightshade(), new Confuseray() },
			[5] = new List<Move>() { new Shadowsneak() },
			[10] = new List<Move>() { new Spite() },
			[15] = new List<Move>() { new Payback() },
			[20] = new List<Move>() { new Nastyplot() },
			[25] = new List<Move>() { new Hex() },
			[30] = new List<Move>() { new Memento() },
			[35] = new List<Move>() { new Suckerpunch() },
			[40] = new List<Move>() { new Curse() },
			[45] = new List<Move>() { new Shadowball() },
			[50] = new List<Move>() { new Darkpulse() },
			[55] = new List<Move>() { new Hypnosis() },
			[60] = new List<Move>() { new Dreameater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Burningjealousy(), new Calmmind(), new Darkpulse(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Flash(), new Foulplay(), new Gigaimpact(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Icywind(), new Imprison(), new Lashout(), new Nastyplot(), new Payback(), new Phantomforce(), new Poltergeist(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Retaliate(), new Rocktomb(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Torment(), new Trick(), new Uproar(), new Waterpulse(), new Willowisp(), new Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Destinybond(), new Disable(), new Foulplay(), new Grudge(), new Imprison(), new Painsplit(), new Shadowsneak(), new Smokescreen() };
		public override int Weight => 1080;
		public override int ExpYield => 170;
		public override int CatchRate => 100;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}