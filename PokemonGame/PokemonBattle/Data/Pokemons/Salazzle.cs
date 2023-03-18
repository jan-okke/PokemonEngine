using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Salazzle : Pokemon
	{
		public override string Name => "Salazzle";
		public override List<Ability> AvailableAbilities => new() {new Corrosion() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Oblivious() };
		public override Stats BaseStats => new Stats(68, 64, 60, 117, 111, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Firelash() },
			[1] = new List<Move>() { new Firelash(), new Knockoff(), new Encore(), new Torment(), new Swagger(), new Disable(), new Scratch(), new Endeavor(), new Pound(), new Poisongas(), new Smog(), new Ember() },
			[15] = new List<Move>() { new Poisonfang() },
			[20] = new List<Move>() { new Sweetscent() },
			[25] = new List<Move>() { new Nastyplot() },
			[30] = new List<Move>() { new Incinerate() },
			[37] = new List<Move>() { new Venoshock() },
			[44] = new List<Move>() { new Dragonpulse() },
			[51] = new List<Move>() { new Venomdrench() },
			[58] = new List<Move>() { new Flamethrower() },
			[65] = new List<Move>() { new Toxic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Beatup(), new Breakingswipe(), new Corrosivegas(), new Crosspoison(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Encore(), new Endure(), new Facade(), new Faketears(), new Fireblast(), new Flamethrower(), new Flareblitz(), new Fling(), new Foulplay(), new Gunkshot(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Leechlife(), new Nastyplot(), new Overheat(), new Payback(), new Poisonjab(), new Protect(), new Rest(), new Round(), new Scaleshot(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Swift(), new Taunt(), new Thief(), new Thunderwave(), new Venomdrench(), new Venoshock(), new Willowisp() };
		public override int Weight => 222;
		public override int ExpYield => 168;
		public override int CatchRate => 45;
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