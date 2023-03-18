using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Infernape : Pokemon
	{
		public override string Name => "Infernape";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Ironfist() };
		public override Stats BaseStats => new Stats(76, 104, 71, 108, 104, 71);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Closecombat() },
			[1] = new List<Move>() { new Closecombat(), new Machpunch(), new Flareblitz(), new Scratch(), new Leer(), new Ember(), new Taunt() },
			[7] = new List<Move>() { new Ember() },
			[9] = new List<Move>() { new Taunt() },
			[12] = new List<Move>() { new Poweruppunch() },
			[16] = new List<Move>() { new Furyswipes() },
			[19] = new List<Move>() { new Flamewheel() },
			[26] = new List<Move>() { new Feint() },
			[29] = new List<Move>() { new Uturn() },
			[42] = new List<Move>() { new Firespin() },
			[52] = new List<Move>() { new Acrobatics() },
			[58] = new List<Move>() { new Calmmind() },
			[68] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Blastburn(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Calmmind(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Dualchop(), new Earthquake(), new Endeavor(), new Endure(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Flamecharge(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Laserfocus(), new Lowkick(), new Lowsweep(), new Nastyplot(), new Overheat(), new Poisonjab(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thunderpunch(), new Torment(), new Uturn(), new Willowisp(), new Workup() };
		public override int Weight => 550;
		public override int ExpYield => 267;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}