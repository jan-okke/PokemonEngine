using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drakloak : Pokemon
	{
		public override string Name => "Drakloak";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Clearbody(), new Abilities.Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cursedbody() };
		public override Stats BaseStats => new Stats(68, 80, 50, 60, 50, 102);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Dragonpulse() },
			[1] = new List<Move>() { new Moves.Dragonpulse(), new Moves.Astonish(), new Moves.Infestation(), new Moves.Quickattack(), new Moves.Bite() },
			[6] = new List<Move>() { new Moves.Lockon() },
			[12] = new List<Move>() { new Moves.Assurance() },
			[18] = new List<Move>() { new Moves.Hex() },
			[24] = new List<Move>() { new Moves.Agility() },
			[30] = new List<Move>() { new Moves.Doublehit() },
			[36] = new List<Move>() { new Moves.Uturn() },
			[42] = new List<Move>() { new Moves.Dragondance() },
			[48] = new List<Move>() { new Moves.Phantomforce() },
			[54] = new List<Move>() { new Moves.Takedown() },
			[61] = new List<Move>() { new Moves.Dragonrush() },
			[66] = new List<Move>() { new Moves.Doubleedge() },
			[72] = new List<Move>() { new Moves.Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Beatup(), new Moves.Breakingswipe(), new Moves.Brine(), new Moves.Dive(), new Moves.Dracometeor(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Outrage(), new Moves.Phantomforce(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uturn(), new Moves.Willowisp() };
		public override int Weight => 110;
		public override int ExpYield => 144;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}