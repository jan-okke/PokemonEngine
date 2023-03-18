using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Salandit : Pokemon
	{
		public override string Name => "Salandit";
		public override List<Ability> AvailableAbilities => new() {new Corrosion() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Oblivious() };
		public override Stats BaseStats => new Stats(48, 44, 40, 77, 71, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Poisongas() },
			[5] = new List<Move>() { new Smog() },
			[10] = new List<Move>() { new Ember() },
			[15] = new List<Move>() { new Poisonfang() },
			[20] = new List<Move>() { new Sweetscent() },
			[25] = new List<Move>() { new Nastyplot() },
			[30] = new List<Move>() { new Incinerate() },
			[35] = new List<Move>() { new Venoshock() },
			[40] = new List<Move>() { new Dragonpulse() },
			[45] = new List<Move>() { new Venomdrench() },
			[50] = new List<Move>() { new Flamethrower() },
			[55] = new List<Move>() { new Toxic() },
			[60] = new List<Move>() { new Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Beatup(), new Dragonclaw(), new Dragonpulse(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Fling(), new Foulplay(), new Gunkshot(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Leechlife(), new Nastyplot(), new Overheat(), new Payback(), new Poisonjab(), new Protect(), new Rest(), new Round(), new Scaleshot(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Swift(), new Taunt(), new Thief(), new Thunderwave(), new Venomdrench(), new Venoshock(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Belch(), new Fakeout(), new Mudslap(), new Sandattack() };
		public override int Weight => 48;
		public override int ExpYield => 64;
		public override int CatchRate => 120;
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