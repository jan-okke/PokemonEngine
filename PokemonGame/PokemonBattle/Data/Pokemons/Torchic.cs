using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Torchic : Pokemon
	{
		public override string Name => "Torchic";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Speedboost() };
		public override Stats BaseStats => new Stats(45, 60, 40, 70, 50, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Growl() },
			[3] = new List<Move>() { new Ember() },
			[6] = new List<Move>() { new Quickattack() },
			[9] = new List<Move>() { new Flamecharge() },
			[12] = new List<Move>() { new Detect() },
			[15] = new List<Move>() { new Sandattack() },
			[18] = new List<Move>() { new Aerialace() },
			[21] = new List<Move>() { new Slash() },
			[24] = new List<Move>() { new Bounce() },
			[27] = new List<Move>() { new Focusenergy() },
			[30] = new List<Move>() { new Flamethrower() },
			[33] = new List<Move>() { new Featherdance() },
			[36] = new List<Move>() { new Reversal() },
			[39] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Assurance(), new Attract(), new Batonpass(), new Bodyslam(), new Bounce(), new Cut(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Firepledge(), new Firespin(), new Flamethrower(), new Flareblitz(), new Focusenergy(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Lowkick(), new Megakick(), new Megapunch(), new Overheat(), new Protect(), new Rest(), new Reversal(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Willowisp(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Batonpass(), new Counter(), new Crushclaw(), new Curse(), new Featherdance(), new Feint(), new Lastresort(), new Lowkick(), new Nightslash(), new Peck(), new Reversal() };
		public override int Weight => 25;
		public override int ExpYield => 62;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}