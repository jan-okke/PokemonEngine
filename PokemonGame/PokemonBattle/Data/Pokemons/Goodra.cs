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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sapsipper(), new Abilities.Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gooey() };
		public override Stats BaseStats => new Stats(90, 100, 70, 110, 150, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Aquatail() },
			[1] = new List<Move>() { new Moves.Aquatail(), new Moves.Acidspray(), new Moves.Poisontail(), new Moves.Tearfullook(), new Moves.Feint(), new Moves.Absorb(), new Moves.Tackle(), new Moves.Watergun(), new Moves.Dragonbreath() },
			[15] = new List<Move>() { new Moves.Protect() },
			[20] = new List<Move>() { new Moves.Flail() },
			[25] = new List<Move>() { new Moves.Waterpulse() },
			[30] = new List<Move>() { new Moves.Raindance() },
			[35] = new List<Move>() { new Moves.Dragonpulse() },
			[43] = new List<Move>() { new Moves.Curse() },
			[49] = new List<Move>() { new Moves.Bodyslam() },
			[58] = new List<Move>() { new Moves.Muddywater() },
			[67] = new List<Move>() { new Moves.Powerwhip() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Dracometeor(), new Moves.Dragonpulse(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Irontail(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Weatherball() };
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