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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Ironfist() };
		public override Stats BaseStats => new Stats(76, 104, 71, 104, 71, 108);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Closecombat() },
			[1] = new List<Move>() { new Moves.Closecombat(), new Moves.Machpunch(), new Moves.Flareblitz(), new Moves.Scratch(), new Moves.Leer(), new Moves.Ember(), new Moves.Taunt() },
			[7] = new List<Move>() { new Moves.Ember() },
			[9] = new List<Move>() { new Moves.Taunt() },
			[12] = new List<Move>() { new Moves.Poweruppunch() },
			[16] = new List<Move>() { new Moves.Furyswipes() },
			[19] = new List<Move>() { new Moves.Flamewheel() },
			[26] = new List<Move>() { new Moves.Feint() },
			[29] = new List<Move>() { new Moves.Uturn() },
			[42] = new List<Move>() { new Moves.Firespin() },
			[52] = new List<Move>() { new Moves.Acrobatics() },
			[58] = new List<Move>() { new Moves.Calmmind() },
			[68] = new List<Move>() { new Moves.Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Blastburn(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dualchop(), new Moves.Earthquake(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Firepunch(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Laserfocus(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Nastyplot(), new Moves.Overheat(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Uturn(), new Moves.Willowisp(), new Moves.Workup() };
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