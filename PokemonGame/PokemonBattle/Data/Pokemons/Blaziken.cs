using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Blaziken : Pokemon
	{
		public override string Name => "Blaziken";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Speedboost() };
		public override Stats BaseStats => new Stats(80, 120, 70, 110, 70, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Closecombat(), new Doublekick(), new Firepunch(), new Bravebird(), new Flamethrower(), new Featherdance(), new Scratch(), new Growl(), new Ember(), new Quickattack() },
			[9] = new List<Move>() { new Flamecharge() },
			[12] = new List<Move>() { new Detect() },
			[15] = new List<Move>() { new Sandattack() },
			[20] = new List<Move>() { new Aerialace() },
			[25] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Bounce() },
			[35] = new List<Move>() { new Focusenergy() },
			[42] = new List<Move>() { new Blazekick() },
			[49] = new List<Move>() { new Bulkup() },
			[56] = new List<Move>() { new Reversal() },
			[63] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Assurance(), new Attract(), new Aurasphere(), new Batonpass(), new Blastburn(), new Blazekick(), new Bodyslam(), new Bounce(), new Bravebird(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Cut(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Gigaimpact(), new Heatcrash(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Overheat(), new Poisonjab(), new Protect(), new Rest(), new Revenge(), new Reversal(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swift(), new Swordsdance(), new Thunderpunch(), new Uturn(), new Willowisp(), new Workup() };
		public override int Weight => 520;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}