using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chimchar : Pokemon
	{
		public override string Name => "Chimchar";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Ironfist() };
		public override Stats BaseStats => new Stats(44, 58, 44, 58, 44, 61);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Leer() },
			[6] = new List<Move>() { new Ember() },
			[9] = new List<Move>() { new Taunt() },
			[12] = new List<Move>() { new Poweruppunch() },
			[15] = new List<Move>() { new Furyswipes() },
			[17] = new List<Move>() { new Flamewheel() },
			[23] = new List<Move>() { new Nastyplot() },
			[25] = new List<Move>() { new Torment() },
			[31] = new List<Move>() { new Facade() },
			[33] = new List<Move>() { new Firespin() },
			[39] = new List<Move>() { new Acrobatics() },
			[41] = new List<Move>() { new Slackoff() },
			[47] = new List<Move>() { new Flamethrower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Brickbreak(), new Bulkup(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Endeavor(), new Endure(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Flamecharge(), new Flamethrower(), new Fling(), new Focuspunch(), new Frustration(), new Grassknot(), new Gunkshot(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Lowkick(), new Lowsweep(), new Nastyplot(), new Overheat(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Rockclimb(), new Rocksmash(), new Roleplay(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stealthrock(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thunderpunch(), new Torment(), new Uproar(), new Uturn(), new Willowisp(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Blazekick(), new Counter(), new Doublekick(), new Encore(), new Fakeout(), new Firepunch(), new Focusenergy(), new Heatwave(), new Helpinghand(), new Poweruppunch(), new Quickguard(), new Submission(), new Thunderpunch() };
		public override int Weight => 62;
		public override int ExpYield => 62;
		public override int CatchRate => 45;
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