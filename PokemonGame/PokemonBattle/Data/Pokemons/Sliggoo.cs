using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sliggoo : Pokemon
	{
		public override string Name => "Sliggoo";
		public override List<Ability> AvailableAbilities => new() {new Sapsipper(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gooey() };
		public override Stats BaseStats => new Stats(68, 75, 53, 83, 113, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Acidspray() },
			[1] = new List<Move>() { new Acidspray(), new Absorb(), new Tackle(), new Watergun(), new Dragonbreath() },
			[15] = new List<Move>() { new Protect() },
			[20] = new List<Move>() { new Flail() },
			[25] = new List<Move>() { new Waterpulse() },
			[30] = new List<Move>() { new Raindance() },
			[35] = new List<Move>() { new Dragonpulse() },
			[43] = new List<Move>() { new Curse() },
			[49] = new List<Move>() { new Bodyslam() },
			[56] = new List<Move>() { new Muddywater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Dracometeor(), new Dragonpulse(), new Endure(), new Facade(), new Hiddenpower(), new Icebeam(), new Irontail(), new Muddywater(), new Mudshot(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Round(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Sunnyday(), new Thunderbolt() };
		public override int Weight => 175;
		public override int ExpYield => 158;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}