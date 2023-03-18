using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Combusken : Pokemon
	{
		public override string Name => "Combusken";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Speedboost() };
		public override Stats BaseStats => new Stats(60, 85, 60, 55, 85, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Doublekick() },
			[1] = new List<Move>() { new Doublekick(), new Flamethrower(), new Featherdance(), new Scratch(), new Growl(), new Ember(), new Quickattack() },
			[9] = new List<Move>() { new Flamecharge() },
			[12] = new List<Move>() { new Detect() },
			[15] = new List<Move>() { new Sandattack() },
			[20] = new List<Move>() { new Aerialace() },
			[25] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Bounce() },
			[35] = new List<Move>() { new Focusenergy() },
			[40] = new List<Move>() { new Blazekick() },
			[45] = new List<Move>() { new Bulkup() },
			[50] = new List<Move>() { new Reversal() },
			[55] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Assurance(), new Attract(), new Batonpass(), new Blazekick(), new Bodyslam(), new Bounce(), new Brickbreak(), new Bulkup(), new Coaching(), new Cut(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Overheat(), new Poisonjab(), new Protect(), new Rest(), new Revenge(), new Reversal(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thunderpunch(), new Willowisp(), new Workup() };
		public override int Weight => 195;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}