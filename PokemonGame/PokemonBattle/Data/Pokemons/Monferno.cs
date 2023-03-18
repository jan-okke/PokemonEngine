using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Monferno : Pokemon
	{
		public override string Name => "Monferno";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Ironfist() };
		public override Stats BaseStats => new Stats(64, 78, 52, 78, 52, 81);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Machpunch() },
			[1] = new List<Move>() { new Machpunch(), new Scratch(), new Leer(), new Ember() },
			[7] = new List<Move>() { new Ember() },
			[9] = new List<Move>() { new Taunt() },
			[12] = new List<Move>() { new Poweruppunch() },
			[16] = new List<Move>() { new Furyswipes() },
			[19] = new List<Move>() { new Flamewheel() },
			[26] = new List<Move>() { new Feint() },
			[29] = new List<Move>() { new Torment() },
			[36] = new List<Move>() { new Closecombat() },
			[39] = new List<Move>() { new Firespin() },
			[46] = new List<Move>() { new Acrobatics() },
			[49] = new List<Move>() { new Slackoff() },
			[56] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Brickbreak(), new Bulkup(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Dualchop(), new Endeavor(), new Endure(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Flamecharge(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Grassknot(), new Gunkshot(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Lowkick(), new Lowsweep(), new Nastyplot(), new Overheat(), new Poisonjab(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stealthrock(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thunderpunch(), new Torment(), new Uturn(), new Willowisp(), new Workup() };
		public override int Weight => 220;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}