using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Goodra : Pokemon
	{
		public override string Name => "Goodra";
		public override List<Ability> AvailableAbilities => new() {new Sapsipper(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gooey() };
		public override Stats BaseStats => new Stats(90, 100, 70, 110, 150, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Aquatail() },
			[1] = new List<Move>() { new Aquatail(), new Acidspray(), new Poisontail(), new Tearfullook(), new Feint(), new Absorb(), new Tackle(), new Watergun(), new Dragonbreath() },
			[15] = new List<Move>() { new Protect() },
			[20] = new List<Move>() { new Flail() },
			[25] = new List<Move>() { new Waterpulse() },
			[30] = new List<Move>() { new Raindance() },
			[35] = new List<Move>() { new Dragonpulse() },
			[43] = new List<Move>() { new Curse() },
			[49] = new List<Move>() { new Bodyslam() },
			[58] = new List<Move>() { new Muddywater() },
			[67] = new List<Move>() { new Powerwhip() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Blizzard(), new Bodypress(), new Bodyslam(), new Breakingswipe(), new Brutalswing(), new Bulldoze(), new Dracometeor(), new Dragonpulse(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Focusblast(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Irontail(), new Megakick(), new Megapunch(), new Muddywater(), new Mudshot(), new Outrage(), new Powerwhip(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Round(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Weatherball() };
		public override int Weight => 1505;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}