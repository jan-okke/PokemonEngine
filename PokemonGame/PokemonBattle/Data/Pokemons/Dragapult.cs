using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dragapult : Pokemon
	{
		public override string Name => "Dragapult";
		public override List<Ability> AvailableAbilities => new() {new Clearbody(), new Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cursedbody() };
		public override Stats BaseStats => new Stats(88, 120, 75, 100, 75, 142);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Dragondarts() },
			[1] = new List<Move>() { new Dragondarts(), new Dragonbreath(), new Suckerpunch(), new Astonish(), new Infestation(), new Quickattack(), new Bite() },
			[6] = new List<Move>() { new Lockon() },
			[12] = new List<Move>() { new Assurance() },
			[18] = new List<Move>() { new Hex() },
			[24] = new List<Move>() { new Agility() },
			[30] = new List<Move>() { new Doublehit() },
			[36] = new List<Move>() { new Uturn() },
			[42] = new List<Move>() { new Dragondance() },
			[48] = new List<Move>() { new Phantomforce() },
			[54] = new List<Move>() { new Takedown() },
			[63] = new List<Move>() { new Dragonrush() },
			[70] = new List<Move>() { new Doubleedge() },
			[78] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Allyswitch(), new Assurance(), new Attract(), new Batonpass(), new Beatup(), new Bodyslam(), new Breakingswipe(), new Brine(), new Dive(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Fly(), new Gigaimpact(), new Helpinghand(), new Hex(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Lightscreen(), new Outrage(), new Phantomforce(), new Protect(), new Psychicfangs(), new Reflect(), new Rest(), new Round(), new Scald(), new Shadowball(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Substitute(), new Surf(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Triattack(), new Uturn(), new Willowisp() };
		public override int Weight => 500;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 3
		};
	}
}